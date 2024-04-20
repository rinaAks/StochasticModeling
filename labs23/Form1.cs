using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs23
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
        private void button1_Click(object sender, EventArgs e)
        {
            num5 = 1;
            answersProb.Clear(); statistics.Clear(); answersText.Clear();
            statistics = new List<int>(new int[5]);

            for (int i = 0; i < 5; i++)
            {
                chart1.Series[i].Points.Clear();
            }
            answersText.Add(label1.Text);
            answersText.Add(label2.Text);
            answersText.Add(label3.Text);
            answersText.Add(label4.Text);
            answersText.Add(label5.Text);

            answersProb.Add((double)num1.Value);
            answersProb.Add((double)num2.Value);
            answersProb.Add((double)num3.Value);
            answersProb.Add((double)num4.Value);
            for (int i = 0; i < answersProb.Count; i++) { num5 -= answersProb[i]; }
            if(num5 < 0) { throw new ArgumentException("Сумма значений больше 1"); }
            answersProb.Add(num5);
            label8.Visible = true; label8.Text = num5.ToString();
            int attemptsNum = (int)numAttempts.Value;


            for (int i = 0; i < attemptsNum; i++)
            {
                double value = (double)rnd.NextDouble();
                for (int j = 0; j < answersProb.Count; j++) 
                {
                    value -= answersProb[j];
                    if(value <= 0)
                    {
                        statistics[j] += 1;
                        break;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (answersProb[i] == answersProb.Max())
                {
                    label9.Visible = true;
                    if (textBox1.Text != "") label9.Text = answersText[i];
                    else label9.Text = "Нет текста\nдля гадания!";
                }
                chart1.Series[i].Points.AddXY(i,  statistics[i]);
            }
        }
    }
}
