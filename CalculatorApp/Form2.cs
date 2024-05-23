using CalculatorApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<DataMem> aLst = new List<DataMem>();
        public string lastExp {  get; set; }

        public Form2(List<DataMem> data, string lastExp)
        {
            InitializeComponent();

            aLst = data;
            this.lastExp = lastExp;

            dgvData.DataSource = aLst;
        }

        string exp = string.Empty;
        double res = 0.0;

        private void dgvData_CellContentClick(object sender, EventArgs e)
        {
            exp = dgvData.CurrentRow.Cells[0].Value.ToString();
            res = Convert.ToDouble(dgvData.CurrentRow.Cells[1].Value.ToString());
        }
    }
}
