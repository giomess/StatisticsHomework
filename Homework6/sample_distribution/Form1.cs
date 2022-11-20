using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace sample_distribution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                using (var reader = new StreamReader(@"C:\Users\ACER\Desktop\file.csv"))
                {
                    List<string> listA = new List<string>();
                    List<string> listB = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        foreach (var i in values)
                    {
                        listA.Add(i);
                    }

                }

                //int a = listA.Count;
                //richTextBox1.AppendText(a.ToString());
                var rnd = new Random();
                var selectedItems = new List<string>();
                var mean = new List<float>();
                var variance = new List<double>();
                double value = 0;
                float somma = 0;
                for (int j = 0; j < 5; j++) //5 sample
                {
                    for (int i = 0; i < 10; i++) //ogni sample ha 10 valori
                    {
                        int index = rnd.Next(1, listA.Count);
                        selectedItems.Add(listA[index]);
                    }
                    foreach (var item in selectedItems)
                    {
                        richTextBox1.AppendText(item + '\n');
                        somma = somma + float.Parse(item);
                    }
                    float media = somma / 10;
                    mean.Add(media); //avrò 5 medie

                    for (int i = 0; i < selectedItems.Count; i++)
                    {
                        value = value + Math.Pow(double.Parse(selectedItems[i]) - media, 2);
                    }
                    variance.Add(value / selectedItems.Count);
                   
                    selectedItems.Clear();
                    somma = 0;
                    value = 0;
                }
                foreach (var v in variance)
                {
                    richTextBox2.AppendText(v.ToString() + '\n');
                }


                foreach (var m in mean)
                {
                    richTextBox3.AppendText(m.ToString() + '\n');
                }
                
                this.chart1.Series.Clear();
                this.chart2.Series.Clear();
                var series = this.chart1.Series.Add("Mean");
                var series1 = this.chart2.Series.Add("Variance");
                for (int i = 0; i < mean.Count; i++)
                {
                    series.Points.AddXY(i, mean[i]);
                }
                for (int i=0;i<variance.Count; i++)
                {
                    series1.Points.AddXY(i, variance[i]);
                }


                //mean and variance of each distribution
                double sum = 0;
                foreach(var m in mean)
                {
                     sum = sum + m;
                }
                double final_mean = sum / mean.Count;
                sum = 0;
                foreach(var v in variance)
                {
                    //sum = sum+ Math.Pow((v - final_mean),2);
                    sum=sum + v;
                }
                double final_variance = sum / variance.Count;

                textBox1.Text = "Final mean: " + final_mean;
                textBox2.Text = "Final variance: " + final_variance;
            }
            
            }
            }
        }
    

