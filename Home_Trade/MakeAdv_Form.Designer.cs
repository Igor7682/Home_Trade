
namespace Home_Trade
{
    partial class MakeAdv_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAdv_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_District = new System.Windows.Forms.TextBox();
            this.textBox_sqr = new System.Windows.Forms.TextBox();
            this.textBox_lay = new System.Windows.Forms.TextBox();
            this.button_CreateApart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Район";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(91, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Площадь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(91, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Планировка";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_District
            // 
            this.textBox_District.Location = new System.Drawing.Point(197, 66);
            this.textBox_District.Name = "textBox_District";
            this.textBox_District.Size = new System.Drawing.Size(100, 20);
            this.textBox_District.TabIndex = 1;
            // 
            // textBox_sqr
            // 
            this.textBox_sqr.Location = new System.Drawing.Point(197, 105);
            this.textBox_sqr.Name = "textBox_sqr";
            this.textBox_sqr.Size = new System.Drawing.Size(100, 20);
            this.textBox_sqr.TabIndex = 2;
            this.textBox_sqr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sqr_KeyPress);
            // 
            // textBox_lay
            // 
            this.textBox_lay.Location = new System.Drawing.Point(197, 143);
            this.textBox_lay.Name = "textBox_lay";
            this.textBox_lay.Size = new System.Drawing.Size(100, 20);
            this.textBox_lay.TabIndex = 3;
            // 
            // button_CreateApart
            // 
            this.button_CreateApart.Location = new System.Drawing.Point(155, 221);
            this.button_CreateApart.Name = "button_CreateApart";
            this.button_CreateApart.Size = new System.Drawing.Size(142, 36);
            this.button_CreateApart.TabIndex = 4;
            this.button_CreateApart.Text = "Создать";
            this.button_CreateApart.UseVisualStyleBackColor = true;
            this.button_CreateApart.Click += new System.EventHandler(this.button_CreateApart_Click);
            // 
            // MakeAdv_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 332);
            this.Controls.Add(this.button_CreateApart);
            this.Controls.Add(this.textBox_lay);
            this.Controls.Add(this.textBox_sqr);
            this.Controls.Add(this.textBox_District);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeAdv_Form";
            this.Text = "Обмен жилья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_District;
        private System.Windows.Forms.TextBox textBox_sqr;
        private System.Windows.Forms.TextBox textBox_lay;
        private System.Windows.Forms.Button button_CreateApart;
    }
}