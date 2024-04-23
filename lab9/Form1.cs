using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        public List<double> answersProb = new List<double>();
        public List<string> answersText = new List<string>();
        public List<int> statistics = new List<int>();
        double num5; int highProbI = 0;
        int size = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            num5 = 1;
            answersProb.Clear(); statistics.Clear(); answersText.Clear();
            statistics = new List<int>(new int[size]);

            for (int i = 0; i < size; i++)
            {
                chart1.Series[i].Points.Clear();
            }

            lbMean.Text = "Матожидание: ";
            lbVar.Text = "Дисперсия: ";
            lbHiSqv.Text = "Критерий хи квадрат: ";

            answersText.Add(label1.Text);
            answersText.Add(label2.Text);
            answersText.Add(label3.Text);
            answersText.Add(label4.Text);
            answersText.Add(label5.Text);

            answersProb.Add((double)num1.Value);
            answersProb.Add((double)num2.Value);
            answersProb.Add((double)num3.Value);
            answersProb.Add((double)num4.Value);
            for (int i = 0; i < size - 1; i++) { num5 -= answersProb[i]; }
            if (num5 < 0) { throw new ArgumentException("Сумма значений больше 1"); }
            answersProb.Add(num5);
            label8.Visible = true; label8.Text = num5.ToString();
            int attemptsNum = (int)numAttempts.Value;


            for (int i = 0; i < attemptsNum; i++)
            {
                double value = (double)rnd.NextDouble();
                for (int j = 0; j < size; j++)
                {
                    value -= answersProb[j];
                    if (value <= 0)
                    {
                        statistics[j] += 1;
                        break;
                    }
                }
            }
            double old_mean = 0, mean = 0, old_var = 0, var = 0, hi_sqv = 0;
            for (int i = 0; i < size; i++)
            {
                if (answersProb[i] == answersProb.Max())
                {
                    label9.Visible = true;
                    if (textBox1.Text != "") label9.Text = answersText[i];
                    else label9.Text = "Нет текста\nдля гадания!";
                }
                chart1.Series[i].Points.AddXY(i, statistics[i]);
                //chart1.Series[i].Points.AddXY(i,  (double)statistics[i]/(double)attemptsNum);

                old_mean += answersProb[i] * (double)i;
                mean += ((double)statistics[i] / (double)attemptsNum) * (double)i;
            }

            for (int i = 0; i < size; i++)
            {
                old_var += answersProb[i] * ((double)i - old_mean) * ((double)i - old_mean);
                var += ((double)statistics[i] / (double)attemptsNum) * ((double)i - mean) * ((double)i - mean);
                hi_sqv += (double)statistics[i] * (double)statistics[i] / ((double)attemptsNum * answersProb[i]);
            }

            hi_sqv -= (double)attemptsNum;

            lbMean.Text += mean + " (погрешность: " + Math.Round((mean * 100 / old_mean - 100), 2) + "% )";
            lbVar.Text += var + " (погрешность: " + Math.Round((var * 100 / old_var - 100), 2) + "% )";
            lbHiSqv.Text += Math.Round(hi_sqv, 2);
            
            //так как size = 5, берём  из таблички значение для size-1, т.е. 9.488
            if(hi_sqv > 9.488)
            {
                lbHiSqv.Text += " > 9.488, плохо!";
            }
            else
            {
                lbHiSqv.Text += " <= 9.488, хорошо!";
            }
        }
    }
}
