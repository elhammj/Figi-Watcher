using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SmartRefri
{
    class TemperatureCriteria:ExpiryCriteria
    {
        public int MaxTemperature { set; get; }
        public int MinTemperature { set; get; }
        

        public override int Add()
        {
            base.Add();
            SmartRefriDBDataSet.temperatureExpiryTblDataTable dataTable = new SmartRefriDBDataSet.temperatureExpiryTblDataTable();
            dataTable.AddtemperatureExpiryTblRow(ID,MaxTemperature,MinTemperature);
            SmartRefriDBDataSetTableAdapters.temperatureExpiryTblTableAdapter tableAdapter = new SmartRefri.SmartRefriDBDataSetTableAdapters.temperatureExpiryTblTableAdapter();
            tableAdapter.Update(dataTable);
            return ID;
        }

        public static TemperatureCriteria GetTemperatureCriteria(int itemID)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            string query = "Select dbo.temperatureExpiryTbl.* from dbo.temperatureExpiryTbl,dbo.expiryCriteriaTbl where (dbo.expiryCriteriaTbl.ID=dbo.temperatureExpiryTbl.ExpiryCriteriaID) AND (dbo.expiryCriteriaTbl.ItemID=" + itemID + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            TemperatureCriteria tempratureCriteria=null;
            if (sqlDataReader.Read())
            {
                tempratureCriteria = new TemperatureCriteria();
                tempratureCriteria.MaxTemperature = Int32.Parse(sqlDataReader["MaxTemperature"].ToString());
                tempratureCriteria.MinTemperature = Int32.Parse(sqlDataReader["MinTemperature"].ToString());
                tempratureCriteria.ID = Int32.Parse(sqlDataReader["ExpiryCriteriaID"].ToString());
            }
            sqlConnection.Close();
            return tempratureCriteria;
        }
    }
}
