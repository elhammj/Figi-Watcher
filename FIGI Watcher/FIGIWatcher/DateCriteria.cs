using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SmartRefri
{
    class DateCriteria:ExpiryCriteria
    {
        public DateTime ExpiryDate { set; get; }
        public override int Add()
        {
            base.Add();
            SmartRefriDBDataSet.dateExpiryTblDataTable dataTable = new SmartRefriDBDataSet.dateExpiryTblDataTable();
            dataTable.AdddateExpiryTblRow(ID,ExpiryDate);
            SmartRefriDBDataSetTableAdapters.dateExpiryTblTableAdapter tableAdapter = new SmartRefri.SmartRefriDBDataSetTableAdapters.dateExpiryTblTableAdapter();
            tableAdapter.Update(dataTable);
            return ID;
        }

        public static DateCriteria GetDateCriteria(int itemID)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            string query = "Select dbo.dateExpiryTbl.* from dbo.dateExpiryTbl,dbo.expiryCriteriaTbl where (dbo.expiryCriteriaTbl.ID=dbo.dateExpiryTbl.ExpiryCriteriaID) AND (dbo.expiryCriteriaTbl.ItemID="+itemID+")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DateCriteria dateCriteria=null;
            if (sqlDataReader.Read())
            {
                dateCriteria = new DateCriteria();
                dateCriteria.ExpiryDate = DateTime.Parse(sqlDataReader["ExpiryDate"].ToString());
                dateCriteria.ID = Int32.Parse(sqlDataReader["ExpiryCriteriaID"].ToString()); 
            }
            sqlConnection.Close();
            return dateCriteria;
        }
    }
}
