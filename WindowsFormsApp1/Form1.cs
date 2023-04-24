using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelDataType1.Text = dateTimePicker1.Value.ToString(" MMMM dd, yyyy");

            labelDataType2.Text = dateTimePicker1.Value.ToShortDateString();

            labelDataType3.Text = dateTimePicker1.Value.ToLongDateString();

            labelTimeType1.Text = dateTimePicker1.Value.ToShortTimeString();

            labelTimeType2.Text = dateTimePicker1.Value.ToLongTimeString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
