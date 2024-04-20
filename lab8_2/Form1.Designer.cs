namespace lab8_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            num1 = new NumericUpDown();
            label2 = new Label();
            num2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            num3 = new NumericUpDown();
            num4 = new NumericUpDown();
            num5 = new NumericUpDown();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 149);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Точно нет";
            // 
            // num1
            // 
            num1.Location = new Point(155, 147);
            num1.Name = "num1";
            num1.Size = new Size(71, 27);
            num1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 207);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Скорее нет";
            // 
            // num2
            // 
            num2.Location = new Point(155, 205);
            num2.Name = "num2";
            num2.Size = new Size(71, 27);
            num2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 268);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Непонятно";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 328);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 5;
            label4.Text = "Скорее да";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 393);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 6;
            label5.Text = "Точно да";
            // 
            // num3
            // 
            num3.Location = new Point(155, 261);
            num3.Name = "num3";
            num3.Size = new Size(71, 27);
            num3.TabIndex = 7;
            // 
            // num4
            // 
            num4.Location = new Point(155, 326);
            num4.Name = "num4";
            num4.Size = new Size(71, 27);
            num4.TabIndex = 8;
            // 
            // num5
            // 
            num5.Location = new Point(155, 391);
            num5.Name = "num5";
            num5.Size = new Size(71, 27);
            num5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(144, 94);
            label6.Name = "label6";
            label6.Size = new Size(101, 40);
            label6.TabIndex = 10;
            label6.Text = "Вероятность\r\nнаступления";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 49);
            label7.Name = "label7";
            label7.Size = new Size(90, 40);
            label7.TabIndex = 12;
            label7.Text = "Количество\r\nпопыток";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(421, 55);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 27);
            numericUpDown1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 518);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(num2);
            Controls.Add(label2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)num2).EndInit();
            ((System.ComponentModel.ISupportInitialize)num3).EndInit();
            ((System.ComponentModel.ISupportInitialize)num4).EndInit();
            ((System.ComponentModel.ISupportInitialize)num5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown num1;
        private Label label2;
        private NumericUpDown num2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown num3;
        private NumericUpDown num4;
        private NumericUpDown num5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private NumericUpDown numericUpDown1;
    }
}
