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
            this.zero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.two = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.six = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.seven = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.five = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.currArr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.genButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genButton.Location = new System.Drawing.Point(42, 352);
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
            this.sortButton.Location = new System.Drawing.Point(405, 352);
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
            this.label2.Location = new System.Drawing.Point(39, 250);
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
            this.sortArr.Location = new System.Drawing.Point(42, 291);
            this.sortArr.Name = "sortArr";
            this.sortArr.ReadOnly = true;
            this.sortArr.Size = new System.Drawing.Size(541, 32);
            this.sortArr.TabIndex = 8;
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(612, 45);
            this.zero.Name = "zero";
            this.zero.ReadOnly = true;
            this.zero.Size = new System.Drawing.Size(261, 32);
            this.zero.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "0:";
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(614, 123);
            this.two.Name = "two";
            this.two.ReadOnly = true;
            this.two.Size = new System.Drawing.Size(261, 32);
            this.two.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "2:";
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(612, 203);
            this.four.Name = "four";
            this.four.ReadOnly = true;
            this.four.Size = new System.Drawing.Size(261, 32);
            this.four.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "4:";
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(612, 284);
            this.six.Name = "six";
            this.six.ReadOnly = true;
            this.six.Size = new System.Drawing.Size(261, 32);
            this.six.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "6:";
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(612, 357);
            this.eight.Name = "eight";
            this.eight.ReadOnly = true;
            this.eight.Size = new System.Drawing.Size(261, 32);
            this.eight.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(609, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "8:";
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(896, 357);
            this.nine.Name = "nine";
            this.nine.ReadOnly = true;
            this.nine.Size = new System.Drawing.Size(261, 32);
            this.nine.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(893, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "9:";
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(896, 284);
            this.seven.Name = "seven";
            this.seven.ReadOnly = true;
            this.seven.Size = new System.Drawing.Size(261, 32);
            this.seven.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(893, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "7:";
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(896, 203);
            this.five.Name = "five";
            this.five.ReadOnly = true;
            this.five.Size = new System.Drawing.Size(261, 32);
            this.five.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(893, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "5:";
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(898, 123);
            this.three.Name = "three";
            this.three.ReadOnly = true;
            this.three.Size = new System.Drawing.Size(261, 32);
            this.three.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(895, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "3:";
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(896, 45);
            this.one.Name = "one";
            this.one.ReadOnly = true;
            this.one.Size = new System.Drawing.Size(261, 32);
            this.one.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(893, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "1:";
            // 
            // currArr
            // 
            this.currArr.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currArr.Location = new System.Drawing.Point(44, 178);
            this.currArr.Name = "currArr";
            this.currArr.ReadOnly = true;
            this.currArr.Size = new System.Drawing.Size(541, 32);
            this.currArr.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Your current array:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1213, 443);
            this.Controls.Add(this.currArr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.five);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.three);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.one);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.six);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.four);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.two);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.TextBox zero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox six;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nine;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox seven;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox five;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox currArr;
        private System.Windows.Forms.Label label8;
    }
}

