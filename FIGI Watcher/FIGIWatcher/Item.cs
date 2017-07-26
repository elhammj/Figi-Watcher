using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SmartRefri
{
    public class Item
    {
        public int ID{set;get;}
        public string Code { set; get; }
        public string Name { set; get; }
        public ItemType Type { set; get; }
        public string Image { set; get; }

        public int Add()
        {
            SmartRefriDBDataSet.itemTblDataTable dataTable = new SmartRefriDBDataSet.itemTblDataTable();
            dataTable.AdditemTblRow(Code, Name, (int)Type, Image);
            SmartRefriDBDataSetTableAdapters.itemTblTableAdapter tableAdapter = new SmartRefri.SmartRefriDBDataSetTableAdapters.itemTblTableAdapter();
            tableAdapter.Update(dataTable);
            ID=Int32.Parse(tableAdapter.GetData().Rows[tableAdapter.GetData().Rows.Count - 1].ItemArray[0].ToString());
            return ID;
        }

        public static List<Item> GetRecentlyAddedItems()
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            string query = "SELECT Top 3 dbo.itemTbl.* FROM dbo.itemTbl,dbo.entryDateTbl where (itemTbl.ID = dbo.entryDateTbl.ItemID) order By dbo.entryDateTbl.DateTime DESC ";
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

        public static List<Item> GetAllItems()
        {
            return QueryItems("SELECT dbo.itemTbl.* FROM dbo.itemTbl");
        }

        public void Delete()
        {
            string query="DELETE FROM [SmartRefriDB].[dbo].[itemTbl] WHERE Code='"+Code+"'";
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static List<Item> GetMostConsumedItems()
        {
            return QueryItems("Select * from dbo.itemTbl WHERE Code= (SELECT Top 1 Code FROM dbo.itemTbl group by Code Order By count(Code))");
        }

        public static List<Item> GetMostExpiredItems()
        {
            return QueryItems("Select * from dbo.itemTbl WHERE Code=(SELECT Top 1 Code FROM dbo.itemTbl,dbo.expiryCriteriaTbl,dbo.dateExpiryTbl,dbo.entryDateTbl where (itemTbl.ID = dbo.expiryCriteriaTbl.ItemID) AND (dbo.expiryCriteriaTbl.ID=dbo.dateExpiryTbl.ExpiryCriteriaID) And (dbo.dateExpiryTbl.ExpiryDate<GETDATE() and not(dbo.entryDateTbl.IsIn=0 and dbo.entryDateTbl.DateTime < dbo.dateExpiryTbl.ExpiryDate )) group by Code)");
        }

        public static List<Item> QueryItems(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.MyConnectionString);
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

        public static List<Item> GetItemsByName(string name)
        {
            return QueryItems("Select * from dbo.itemTbl WHERE Name like '%" + name + "%'");
        }
    }

    public enum ItemType
    {
        Milk,
        Meat,
        FruitsVegetables,
        Preservers,
        Bakery,
        Others
    }
}
