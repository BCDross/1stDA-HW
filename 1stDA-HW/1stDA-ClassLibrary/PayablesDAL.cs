using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _1stDA_ClassLibrary
{
    public static class PayablesDAL
    {
        const string connectString = @"Server=localhost;Database=Payables;Integrated Security=SSPI";
        private const string sqlErrorMessage = "Database operation failed. Please contact your System Admin.";

        public static DataSet GetData()
        {
            try
            {
                SqlDataAdapter invoiceDataAdapter = new SqlDataAdapter();
                invoiceDataAdapter.SelectCommand = new SqlCommand();

                invoiceDataAdapter.SelectCommand.Connection = new SqlConnection();
                invoiceDataAdapter.SelectCommand.Connection.ConnectionString = connectString;

                invoiceDataAdapter.SelectCommand.CommandText = "select InvoiceNumber, InvoiceDate, InvoiceTotal from Invoices where InvoiceTotal > 5000;";

                DataSet invoiceDataSet = new DataSet("Invoice DataSet");

                invoiceDataAdapter.Fill(invoiceDataSet, "InvoiceSet");

                return invoiceDataSet;
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
