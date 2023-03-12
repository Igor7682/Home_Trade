
namespace Home_Trade
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDist = new System.Windows.Forms.TextBox();
            this.textBoxMinSqr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaxSqr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxLayout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(436, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Район";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDist
            // 
            this.textBoxDist.Location = new System.Drawing.Point(543, 309);
            this.textBoxDist.Name = "textBoxDist";
            this.textBoxDist.Size = new System.Drawing.Size(100, 20);
            this.textBoxDist.TabIndex = 4;
            this.textBoxDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLayout_KeyPress);
            // 
            // textBoxMinSqr
            // 
            this.textBoxMinSqr.Location = new System.Drawing.Point(542, 350);
            this.textBoxMinSqr.Name = "textBoxMinSqr";
            this.textBoxMinSqr.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinSqr.TabIndex = 5;
            this.textBoxMinSqr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinSqr_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(436, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "Минимальная площадь";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMaxSqr
            // 
            this.textBoxMaxSqr.Location = new System.Drawing.Point(542, 390);
            this.textBoxMaxSqr.Name = "textBoxMaxSqr";
            this.textBoxMaxSqr.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxSqr.TabIndex = 6;
            this.textBoxMaxSqr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinSqr_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(436, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 53);
            this.label3.TabIndex = 4;
            this.label3.Text = "Максимальная площадь";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(121, 265);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 51);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(722, 213);
            this.dataGridView1.TabIndex = 7;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(121, 359);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(149, 45);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxLayout
            // 
            this.textBoxLayout.Location = new System.Drawing.Point(542, 267);
            this.textBoxLayout.Name = "textBoxLayout";
            this.textBoxLayout.Size = new System.Drawing.Size(100, 20);
            this.textBoxLayout.TabIndex = 3;
            this.textBoxLayout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLayout_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(435, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Планировка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(543, 231);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(436, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Id";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(327, 382);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 35);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "кв. м";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "кв. м";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 442);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLayout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxMaxSqr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMinSqr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDist);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Обмен жилья";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDist;
        private System.Windows.Forms.TextBox textBoxMinSqr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxSqr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxLayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}