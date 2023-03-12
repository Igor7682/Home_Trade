
namespace Home_Trade
{
    partial class Reg_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_form));
            this.textBox_pass2 = new System.Windows.Forms.TextBox();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_lb = new System.Windows.Forms.Label();
            this.reg_button = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pass2
            // 
            this.textBox_pass2.Location = new System.Drawing.Point(175, 117);
            this.textBox_pass2.Name = "textBox_pass2";
            this.textBox_pass2.Size = new System.Drawing.Size(100, 20);
            this.textBox_pass2.TabIndex = 2;
            // 
            // textBox_login2
            // 
            this.textBox_login2.Location = new System.Drawing.Point(175, 83);
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(100, 20);
            this.textBox_login2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_lb
            // 
            this.login_lb.Location = new System.Drawing.Point(69, 82);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(100, 23);
            this.login_lb.TabIndex = 10;
            this.login_lb.Text = "Login";
            this.login_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(102, 172);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(173, 45);
            this.reg_button.TabIndex = 3;
            this.reg_button.Text = "Register";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(102, 232);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(172, 39);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Вернуться";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBox_pass2);
            this.Controls.Add(this.textBox_login2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_lb);
            this.Controls.Add(this.reg_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reg_form";
            this.Text = "Обмен жилья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pass2;
        private System.Windows.Forms.TextBox textBox_login2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_lb;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button buttonClose;
    }
}