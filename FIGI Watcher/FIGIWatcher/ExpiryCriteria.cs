using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SmartRefri
{
    public class ExpiryCriteria
    {
        public int ID { set; get; }
        public Item Item {set;get;}
        public int ItemID { set; get; }


        public virtual int Add()
        {
            SmartRefriDBDataSet.expiryCriteriaTblDataTable dataTable = new SmartRefriDBDataSet.expiryCriteriaTblDataTable();
            dataTable.AddexpiryCriteriaTblRow(ItemID);
            SmartRefriDBDataSetTableAdapters.expiryCriteriaTblTableAdapter tableAdapter = new SmartRefri.SmartRefriDBDataSetTableAdapters.expiryCriteriaTblTableAdapter();
            tableAdapter.Update(dataTable);
            ID=Int32.Parse(tableAdapter.GetData().Rows[tableAdapter.GetData().Rows.Count - 1].ItemArray[0].ToString());
            return ID;
        }

        public static List<Item> getDateExpiredItems()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            string query = "SELECT dbo.itemTbl.* FROM dbo.itemTbl,dbo.expiryCriteriaTbl,dbo.dateExpiryTbl where (itemTbl.ID = dbo.expiryCriteriaTbl.ItemID) AND (dbo.expiryCriteriaTbl.ID=dbo.dateExpiryTbl.ExpiryCriteriaID) And (dbo.dateExpiryTbl.ExpiryDate-7<GETDATE())";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Item> items = new List<Item>();
            while (sqlDataReader.Read())
            {
                Item item = new Item();
                item.Code = sqlDataReader["Code"].ToString();
                item.Name = sqlDataReader["Name"].ToString();
                item.Type = (ItemType)Int32.Parse(sqlDataReader["Type"].ToString());
                item.Image = sqlDataReader["Image"].ToString();
                item.ID =Int32.Parse(sqlDataReader["ID"].ToString());
                items.Add(item);
            }
            sqlConnection.Close();
            return items;
        }

        public static List<Item> getTemperatureExpiredItems()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            string query = "SELECT dbo.itemTbl.* FROM dbo.itemTbl,dbo.expiryCriteriaTbl,dbo.temperatureExpiryTbl where (itemTbl.ID = dbo.expiryCriteriaTbl.ItemID) AND (dbo.expiryCriteriaTbl.ID=dbo.temperatureExpiryTbl.ExpiryCriteriaID) And (MaxTemperature<" + Properties.Settings.Default.refrigeratorInternalTemperature + " OR MinTemperature>" + Properties.Settings.Default.refrigeratorInternalTemperature + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Item> items = new List<Item>();
            while (sqlDataReader.Read())
            {
                Item item = new Item();
                item.Code = sqlDataReader["Code"].ToString();
                item.Name = sqlDataReader["Name"].ToString();
                item.Type = (ItemType)Int32.Parse(sqlDataReader["Type"].ToString());
                item.Image = sqlDataReader["Image"].ToString();
                item.ID = Int32.Parse(sqlDataReader["ID"].ToString());
                items.Add(item);
            }
            sqlConnection.Close();
            return items;
        }
    }

    public enum AlarmStatus
    {
        None,
        Warning,
        Danger
    }   
}
