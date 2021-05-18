using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation9Lab
{
    public partial class Form1 : Form
    {
        private decimal prob5 = 0;
        private BasicSensor rnd = new BasicSensor();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsProbsOk())
            {
                label_validation.Text = "";
                chart1.Series[0].Points.Clear();
                int[] statistics = new int[5] { 0, 0, 0, 0, 0 };
                decimal[] probs = new decimal[5] { 
                    numericUpDown_prob1.Value,
                    numericUpDown_prob2.Value,
                    numericUpDown_prob3.Value,
                    numericUpDown_prob4.Value,
                    prob5 };
                List<decimal> p = new List<decimal>();
                decimal ex = 0, dx = 0, deltaE = 0, deltaT = 0, Ex = 0, Dx = 0, Chi = 0;

                for (int i = 0; i < numericUpDown_experiments.Value; i++)
                {
                    double randNum = rnd.GetRandomNumber();
                    double a = 0;
                    for (int j = 0; j < probs.Length; j++)
                    {
                        a += Convert.ToDouble(probs[j]);
                        if(a > randNum)
                        {
                            statistics[j]++;
                            break;
                        }
                    }
                }

                for (int i = 0; i < statistics.Length; i++)
                {
                    Ex += probs[i] * (i + 1);
                }

                for (int i = 0; i < statistics.Length; i++)
                {
                    Dx += probs[i] * ((i + 1) * (i + 1));
                }
                Dx = Dx - Ex * Ex;

                for (int i = 0; i < statistics.Length; i++)
                {
                    p.Add(statistics[i] / numericUpDown_experiments.Value);
                }

                for (int i = 0; i < statistics.Length; i++)
                {
                    ex += p[i] * (i + 1);            
                }

                for (int i = 0; i < statistics.Length; i++)
                {
                    dx += p[i] * ((i + 1) * (i + 1));                  
                }
                dx = dx - ex * ex;
                deltaE = Math.Abs(ex - Ex);
                deltaT = Math.Abs(dx - Dx);

                for (int i = 0; i < statistics.Length; i++)
                {
                    Chi += (statistics[i] * statistics[i]) / (numericUpDown_experiments.Value * probs[i]);
                }
                Chi = Chi - numericUpDown_experiments.Value;
                label_chi.Text = Convert.ToString(Math.Round(Chi, 3));
                label_average.Text = Convert.ToString(Math.Round(ex, 3));
                label_averageD.Text = "(error = " + Convert.ToString(Convert.ToInt32(deltaE * 100)) + "%)";
                label_var.Text = Convert.ToString(Math.Round(dx, 3));
                label_varD.Text = "(error = " + Convert.ToString(Convert.ToInt32(deltaT * 100)) + "%)";
                if(Chi < 11.07m)
                {
                    label_isTrue.Text = "is true";
                }
                else
                {
                    label_isTrue.Text = "is false";
                }
                for(int i = 0; i < statistics.Length; i++)
                {
                    chart1.Series[0].Points.AddXY(i + 1, statistics[i] / numericUpDown_experiments.Value);
                }
            }
            else
            {
                label_validation.Text = "You entered incorrect probs";
            }
        }
        
        private bool IsProbsOk()
        {
            decimal p = numericUpDown_prob1.Value + numericUpDown_prob2.Value
                + numericUpDown_prob3.Value + numericUpDown_prob4.Value;
            if(p < 1)
            {
                prob5 = 1 - p;
                return true;
            }
            return false;
        }
    }
}
