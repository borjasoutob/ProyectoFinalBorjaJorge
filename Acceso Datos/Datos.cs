using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos
    {
        //private static Conexion Conexion_BD = new Conexion();
        DataSet dataSet = new DataSet();
        public DataSet Prueba()
        {

            DataTable CustomerTable = dataSet.Tables.Add("Customer");
            CustomerTable.Columns.Add("CustomerId", typeof(int));
            CustomerTable.Columns.Add("FirstName", typeof(string));
            CustomerTable.Columns.Add("LastName", typeof(string));
            CustomerTable.Columns.Add("Company", typeof(string));
            CustomerTable.Columns.Add("Address", typeof(string));
            CustomerTable.Columns.Add("City", typeof(string));
            CustomerTable.Columns.Add("State", typeof(string));
            CustomerTable.Columns.Add("Country", typeof(string));
            CustomerTable.Columns.Add("PostalCode", typeof(string));
            CustomerTable.Columns.Add("Phone", typeof(string));
            CustomerTable.Columns.Add("Fax", typeof(string));
            CustomerTable.Columns.Add("Email", typeof(string));
            CustomerTable.Columns.Add("SupportRepId", typeof(int));


            DataTable InvoiceTable = dataSet.Tables.Add("Invoice");
            InvoiceTable.Columns.Add("InvoiceId", typeof(int));
            InvoiceTable.Columns.Add("CustomerId", typeof(int));
            InvoiceTable.Columns.Add("InvoiceDate", typeof(DateTime));
            InvoiceTable.Columns.Add("BillingAddress", typeof(string));
            InvoiceTable.Columns.Add("BillingCity", typeof(string));
            InvoiceTable.Columns.Add("BillingState", typeof(string));
            InvoiceTable.Columns.Add("BillingCountry", typeof(string));
            InvoiceTable.Columns.Add("BillingPostalCode", typeof(string));
            InvoiceTable.Columns.Add("Total", typeof(SqlMoney));


            DataTable InvoiceLineTable = dataSet.Tables.Add("InvoiceLine");
            InvoiceLineTable.Columns.Add("InvoiceLineId", typeof(int));
            InvoiceLineTable.Columns.Add("InvoiceId", typeof(int));
            InvoiceLineTable.Columns.Add("TrackId", typeof(int));
            InvoiceLineTable.Columns.Add("UnitPrice", typeof(SqlMoney));
            InvoiceLineTable.Columns.Add("Quantity", typeof(int));


            /*
            SqlConnection sqlConnection = Conexion_BD.AbrirConexion();
            SqlDataAdapter CustomerAdapter = new SqlDataAdapter("SELECT*FROM Customer", sqlConnection);
            SqlDataAdapter InvoiceAdapter = new SqlDataAdapter("SELECT*FROM Invoice", sqlConnection);
            SqlDataAdapter InvoiceLineAdapter = new SqlDataAdapter("SELECT*FROM InvoiceLine", sqlConnection);
            SqlConnection sqlcerrar = Conexion_BD.CerrarConexion();
            



            CustomerAdapter.Fill(CustomerTable);
            InvoiceAdapter.Fill(InvoiceTable);
            InvoiceLineAdapter.Fill(InvoiceLineTable);
            */


            return dataSet;
        }
    }
}
