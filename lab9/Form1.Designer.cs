namespace lab9
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            this.numAttempts = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbVar = new System.Windows.Forms.Label();
            this.lbHiSqv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Точно нет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорее нет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Непонятно";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скорее да";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Точно да";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(129, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вероятность\r\nнаступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество\r\nпопыток";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 7;
            // 
            // num1
            // 
            this.num1.DecimalPlaces = 3;
            this.num1.Location = new System.Drawing.Point(141, 170);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(71, 22);
            this.num1.TabIndex = 8;
            this.num1.Value = new decimal(new int[] {
            264,
            0,
            0,
            196608});
            // 
            // num2
            // 
            this.num2.DecimalPlaces = 3;
            this.num2.Location = new System.Drawing.Point(141, 231);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(71, 22);
            this.num2.TabIndex = 9;
            this.num2.Value = new decimal(new int[] {
            127,
            0,
            0,
            196608});
            // 
            // num3
            // 
            this.num3.DecimalPlaces = 3;
            this.num3.Location = new System.Drawing.Point(141, 285);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(71, 22);
            this.num3.TabIndex = 10;
            this.num3.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // num4
            // 
            this.num4.DecimalPlaces = 3;
            this.num4.Location = new System.Drawing.Point(141, 340);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(71, 22);
            this.num4.TabIndex = 11;
            this.num4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numAttempts
            // 
            this.numAttempts.Location = new System.Drawing.Point(391, 41);
            this.numAttempts.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAttempts.Name = "numAttempts";
            this.numAttempts.Size = new System.Drawing.Size(71, 22);
            this.numAttempts.TabIndex = 13;
            this.numAttempts.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(291, 101);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series4";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series5";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(576, 364);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Location = new System.Drawing.Point(288, 491);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(104, 16);
            this.lbMean.TabIndex = 18;
            this.lbMean.Text = "Матожидание: ";
            // 
            // lbVar
            // 
            this.lbVar.AutoSize = true;
            this.lbVar.Location = new System.Drawing.Point(288, 519);
            this.lbVar.Name = "lbVar";
            this.lbVar.Size = new System.Drawing.Size(83, 16);
            this.lbVar.TabIndex = 19;
            this.lbVar.Text = "Дисперсия: ";
            // 
            // lbHiSqv
            // 
            this.lbHiSqv.AutoSize = true;
            this.lbHiSqv.Location = new System.Drawing.Point(288, 548);
            this.lbHiSqv.Name = "lbHiSqv";
            this.lbHiSqv.Size = new System.Drawing.Size(150, 16);
            this.lbHiSqv.TabIndex = 20;
            this.lbHiSqv.Text = "Критерий хи квадрат: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 586);
            this.Controls.Add(this.lbHiSqv);
            this.Controls.Add(this.lbVar);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numAttempts);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown num3;
        private System.Windows.Forms.NumericUpDown num4;
        private System.Windows.Forms.NumericUpDown numAttempts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbVar;
        private System.Windows.Forms.Label lbHiSqv;
    }
}

