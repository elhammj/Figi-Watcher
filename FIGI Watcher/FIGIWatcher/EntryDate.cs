using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartRefri
{
    public class EntryDate
    {
        public int ID { set; get; }
        public DateTime DateTime { set; get; }
        public bool IsIn { set; get; }
        public Item Item { set; get; }
        public int ItemID { set; get; }

        public int Add()
        {
            SmartRefriDBDataSet.entryDateTblDataTable dataTable = new SmartRefriDBDataSet.entryDateTblDataTable();
            dataTable.AddentryDateTblRow(DateTime, IsIn, ItemID);
            SmartRefriDBDataSetTableAdapters.entryDateTblTableAdapter tableAdapter = new SmartRefri.SmartRefriDBDataSetTableAdapters.entryDateTblTableAdapter();
            tableAdapter.Update(dataTable);
            ID=Int32.Parse(tableAdapter.GetData().Rows[tableAdapter.GetData().Rows.Count - 1].ItemArray[0].ToString());
            return ID;
        }
    }
}
