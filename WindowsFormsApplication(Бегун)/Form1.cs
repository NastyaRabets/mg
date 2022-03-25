using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Бегун_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Стационарные источники"].Points.AddXY("2020", 600);
            chart1.Series["Стационарные источники"].Points.AddXY("2021", 450);
            chart1.Series["Стационарные источники"].Points.AddXY("2022", 250);
            
           // Общий выброс

            chart2.Series["Общий выброс"].Points.AddXY("2020", 300);
            chart2.Series["Общий выброс"].Points.AddXY("2021", 502);
            chart2.Series["Общий выброс"].Points.AddXY("2022", 420);
            
            //Передвижные источники

            chart3.Series["Передвижные источники"].Points.AddXY("2020", 422);
            chart3.Series["Передвижные источники"].Points.AddXY("2021", 502);
            chart3.Series["Передвижные источники"].Points.AddXY("2022", 325);

            chart4.Series["Series1"].Points.AddXY("Передвижные источники", 500);
            chart4.Series["Series1"].Points.AddXY("Общий выброс", 350);
            chart4.Series["Series1"].Points.AddXY("Стационарные источники", 220);


        }
    }
}
