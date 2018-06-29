using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point24App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcBad_Click(object sender, EventArgs e)
        {
            List<List<double>> listresult = calc24WithExpressionTree.UtilityMain.CalcBadList(int.Parse(tbMax.Text));

            int no = 1;
            foreach (var item in listresult)
            {
                listboxCalcBad.Items.Add(no++ + ":" + item[0] + "," + item[1] + "," + item[2] + "," + item[3]);
            }
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            listboxCalOut.Items.Clear();

            List<double> listone = new List<double> { double.Parse(tb1.Text), double.Parse(tb2.Text), double.Parse(tb3.Text), double.Parse(tb4.Text) };

            List<string> listresult;
            bool isok = calc24WithExpressionTree.UtilityMain.CalcOne(listone, out listresult);

            if (!isok)
            {
                listboxCalOut.Items.Add("On result");
            }
            foreach (var item in listresult)
            {
                listboxCalOut.Items.Add(item);
            }
        }
    }
}
