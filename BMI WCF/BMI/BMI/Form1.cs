using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//
            BMIServiceReference.BMIcalculatorServiceClient service = new BMIServiceReference.BMIcalculatorServiceClient();
            BMIServiceReference.Person p = new BMIServiceReference.Person();
            p.Name = nameT.Text;
            
            p.weight = Convert.ToDouble(weightT.Text);
            p.height = Convert.ToDouble(heightT.Text);
            label4.Text = p.Name + ", your BMI is:";
            label3.Text= service.Calculatebmi(p).ToString();
        }


    }
}
