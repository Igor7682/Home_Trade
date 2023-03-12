
namespace Home_Trade
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.reg_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.login_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(112, 204);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(173, 45);
            this.reg_button.TabIndex = 4;
            this.reg_button.Text = "Зарегестрироваться";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(112, 153);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(173, 45);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_lb
            // 
            this.login_lb.Location = new System.Drawing.Point(46, 42);
            this.login_lb.Name = "login_lb";
            this.login_lb.Size = new System.Drawing.Size(100, 23);
            this.login_lb.TabIndex = 4;
            this.login_lb.Text = "Логин";
            this.login_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(152, 45);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 1;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(152, 79);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pass.TabIndex = 2;
            this.textBox_Pass.UseSystemPasswordChar = true;
            this.textBox_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Pass_KeyPress);
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_lb);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.login_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_form";
            this.Text = "Обмен жилья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label login_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_Pass;
    }
}