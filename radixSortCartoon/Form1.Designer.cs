namespace radixSortCartoon
{
    partial class Form1
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
            this.genButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randArr = new System.Windows.Forms.TextBox();
            this.sortArr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.genButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genButton.Location = new System.Drawing.Point(42, 225);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(178, 37);
            this.genButton.TabIndex = 2;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = false;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sortButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortButton.Location = new System.Drawing.Point(405, 225);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(178, 37);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your random array:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your sorted array:";
            // 
            // randArr
            // 
            this.randArr.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randArr.Location = new System.Drawing.Point(42, 67);
            this.randArr.Name = "randArr";
            this.randArr.ReadOnly = true;
            this.randArr.Size = new System.Drawing.Size(541, 32);
            this.randArr.TabIndex = 7;
            // 
            // sortArr
            // 
            this.sortArr.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortArr.Location = new System.Drawing.Point(42, 164);
            this.sortArr.Name = "sortArr";
            this.sortArr.ReadOnly = true;
            this.sortArr.Size = new System.Drawing.Size(541, 32);
            this.sortArr.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(654, 350);
            this.Controls.Add(this.sortArr);
            this.Controls.Add(this.randArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.genButton);
            this.Name = "Form1";
            this.Text = "Radix sorting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox randArr;
        private System.Windows.Forms.TextBox sortArr;
    }
}

