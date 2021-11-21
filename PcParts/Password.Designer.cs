namespace PcParts
{
    partial class PasswordForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AttempsLabel = new System.Windows.Forms.Label();
            this.IntentNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Attemps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(257, 191);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your password here:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(124, 133);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(21, 191);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AttempsLabel
            // 
            this.AttempsLabel.AutoSize = true;
            this.AttempsLabel.Location = new System.Drawing.Point(109, 166);
            this.AttempsLabel.Name = "AttempsLabel";
            this.AttempsLabel.Size = new System.Drawing.Size(56, 13);
            this.AttempsLabel.TabIndex = 5;
            this.AttempsLabel.Text = "You have ";
            // 
            // IntentNumberLabel
            // 
            this.IntentNumberLabel.AutoSize = true;
            this.IntentNumberLabel.Location = new System.Drawing.Point(168, 166);
            this.IntentNumberLabel.Name = "IntentNumberLabel";
            this.IntentNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.IntentNumberLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "attemps";
            // 
            // Attemps
            // 
            this.Attemps.AutoSize = true;
            this.Attemps.Location = new System.Drawing.Point(168, 166);
            this.Attemps.Name = "Attemps";
            this.Attemps.Size = new System.Drawing.Size(13, 13);
            this.Attemps.TabIndex = 7;
            this.Attemps.Text = "3";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Attemps);
            this.Controls.Add(this.IntentNumberLabel);
            this.Controls.Add(this.AttempsLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Name = "PasswordForm";
            this.Text = "PcParts";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label AttempsLabel;
        private System.Windows.Forms.Label IntentNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Attemps;
    }
}

