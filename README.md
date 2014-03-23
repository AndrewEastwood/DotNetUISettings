DotNetUISettings
================

If you want to have xml configuration used in your project and you do not prefer default dotNet Properties functionality so this might be helpful for you.
Using this component you will be able to save and restore control's values into standard readable xml file.
Additionaly it supports mutiple configuration profiles within the single project.

So, how to use this stuff:

1. Add reference to "components" libarary into your project

2. Create an empty public class

```
    public class wndSettings
    {
    }
```


3. Add inheritance to this class

```
    public class wndSettings : components.UI.Windows.wndAppSettings.wndAppSettings
    {
    }
    
```


4. Refresh your solution explorer and you will see that the created class becomes a form

5. Open the 'wndSettings' in the designer

6. Add textBox control with the following name: "test_textBox1"

7. Add "Save" button, and add onClick handler. Drop the following lines into the onClick handler:

```
        private void save_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
```

8. Make sure that you have the "SaveSettingsOnClose" property enabled for your settings form (wndSettings)

9. Then opend the 'wndSettings' form source add modify it's constructor:

```
        public wndSettings()
            : base()
        {
            InitializeComponent(); // <==== we must add this to override base settings form with our custom controls and form properties
        }
```

Alright. We have configured settings window that can save it's own textBox control value into settings file.
Let's compile our test application and see what happen.
Once we have the settings window opened type smth into textBox and hit the "Save" button.
Then navigate into your app directory and you have to see new "config" directory with one file "test.xml".
If you open this file you have see the following:
```
<document name="test" version="1.6.1">
    <property name="textBox1" value="" />
</document>
```

The document's name is the same as the file name and related to first part of control name "test_textBox1"; (it's "test")
Then inside the document there are all proprties related to "test" document.
If you add another textbox or whatever which name starts with "test_" their values will be added into this "test.xml" document.
You can have as much as you want documents with control values, just add control that starts with different name, like this "network_proxy", and you will get new file "network.xml" with the one peroperty "proxy"

Now we have to configure settings import to our application.
10. Let's open Program.cs file and add dependencies:
```
using components.Public;
```

11. And finnaly add this into the "Main" function

```
    ApplicationConfiguration.Instance.LoadConfigurationData();
```

Compile your application and enjoy! :)


Control name convention.

You must use the char "_" to separate folding blocks of the property. The last part of the name that goes after last "_" is the property name. So if you have a textbox control with the name "demo_general_name" then you will get the following:
```
File name: demo.xml
<document name="demo" version="1.6.1">
    <section name="general">
        <property name="textBox1" value="" />
    </section>
</document>
```

It's because you have "demo" and "general" and then "name".