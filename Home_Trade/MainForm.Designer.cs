
namespace Home_Trade
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_makeAdv = new System.Windows.Forms.Button();
            this.button_ShowUserAdv = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_makeAdv
            // 
            this.button_makeAdv.Location = new System.Drawing.Point(114, 237);
            this.button_makeAdv.Name = "button_makeAdv";
            this.button_makeAdv.Size = new System.Drawing.Size(163, 45);
            this.button_makeAdv.TabIndex = 3;
            this.button_makeAdv.Text = "Создать объявление";
            this.button_makeAdv.UseVisualStyleBackColor = true;
            this.button_makeAdv.Click += new System.EventHandler(this.button_makeAdv_Click);
            // 
            // button_ShowUserAdv
            // 
            this.button_ShowUserAdv.Location = new System.Drawing.Point(114, 168);
            this.button_ShowUserAdv.Name = "button_ShowUserAdv";
            this.button_ShowUserAdv.Size = new System.Drawing.Size(163, 45);
            this.button_ShowUserAdv.TabIndex = 2;
            this.button_ShowUserAdv.Text = "Просмотреть свои объявления";
            this.button_ShowUserAdv.UseVisualStyleBackColor = true;
            this.button_ShowUserAdv.Click += new System.EventHandler(this.button_ShowUserAdv_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(114, 95);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(163, 45);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Поиск объявления";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 340);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(92, 64);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Сменить уччетную запись";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 426);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_ShowUserAdv);
            this.Controls.Add(this.button_makeAdv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Обмен жилья";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_makeAdv;
        private System.Windows.Forms.Button button_ShowUserAdv;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLogin;
    }
}

