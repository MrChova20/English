namespace MainApp
{
    partial class Data_Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTradioButton = new System.Windows.Forms.RadioButton();
            this.XMLradioButton = new System.Windows.Forms.RadioButton();
            this.JSONradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 317);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTradioButton);
            this.groupBox1.Controls.Add(this.XMLradioButton);
            this.groupBox1.Controls.Add(this.JSONradioButton);
            this.groupBox1.Location = new System.Drawing.Point(347, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TXTradioButton
            // 
            this.TXTradioButton.AutoSize = true;
            this.TXTradioButton.Location = new System.Drawing.Point(52, 17);
            this.TXTradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.TXTradioButton.Name = "TXTradioButton";
            this.TXTradioButton.Size = new System.Drawing.Size(72, 29);
            this.TXTradioButton.TabIndex = 1;
            this.TXTradioButton.TabStop = true;
            this.TXTradioButton.Text = ".txt";
            this.TXTradioButton.UseVisualStyleBackColor = true;
            // 
            // XMLradioButton
            // 
            this.XMLradioButton.AutoSize = true;
            this.XMLradioButton.Location = new System.Drawing.Point(52, 137);
            this.XMLradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.XMLradioButton.Name = "XMLradioButton";
            this.XMLradioButton.Size = new System.Drawing.Size(76, 29);
            this.XMLradioButton.TabIndex = 3;
            this.XMLradioButton.TabStop = true;
            this.XMLradioButton.Text = "xml";
            this.XMLradioButton.UseVisualStyleBackColor = true;
            this.XMLradioButton.CheckedChanged += new System.EventHandler(this.XMLradioButton_CheckedChanged);
            // 
            // JSONradioButton
            // 
            this.JSONradioButton.AutoSize = true;
            this.JSONradioButton.Location = new System.Drawing.Point(52, 73);
            this.JSONradioButton.Margin = new System.Windows.Forms.Padding(2);
            this.JSONradioButton.Name = "JSONradioButton";
            this.JSONradioButton.Size = new System.Drawing.Size(83, 29);
            this.JSONradioButton.TabIndex = 2;
            this.JSONradioButton.TabStop = true;
            this.JSONradioButton.Text = "json";
            this.JSONradioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select one:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Data_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Data_Viewer";
            this.Text = "Data viewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TXTradioButton;
        private System.Windows.Forms.RadioButton XMLradioButton;
        private System.Windows.Forms.RadioButton JSONradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}