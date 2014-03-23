using System;
using System.Collections.Generic;
using System.Text;

namespace testApplication
{
    public class wndSettings : components.UI.Windows.wndAppSettings.wndAppSettings
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox test_textBox1;
    
        public wndSettings()
            : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.test_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test_textBox1
            // 
            this.test_textBox1.Location = new System.Drawing.Point(12, 25);
            this.test_textBox1.Name = "test_textBox1";
            this.test_textBox1.Size = new System.Drawing.Size(260, 20);
            this.test_textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(197, 229);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // wndSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_textBox1);
            this.Name = "wndSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void save_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

    }
}
