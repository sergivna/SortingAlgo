using CalculateTimes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Result> data = Sort.CalculateRealData();

            Series ls = new Series("Аналіз часу виконання алгоритмів сортування");
                   

            foreach (var item in data)
            {
                ls.Points.AddXY(item.Algo+item.Count+"Type"+item.Type, item.AverageTime.Seconds);
            }

            chart1.Series.Add(ls);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
