using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1stDA_ClassLibrary;

namespace _1stDA_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet invoiceDataSet;

            invoiceDataSet = PayablesDAL.GetData();

            dataGridViewInvoices.DataSource = invoiceDataSet.Tables["InvoiceSet"];
            dataGridViewInvoices.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewInvoices.AutoResizeColumns();

        }
    }
}
