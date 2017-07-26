using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartRefri
{
    public partial class ShowItemsList : UserControl
    {
        public ShowItemsList(List<Item> items,List<AlarmStatus> alarms,SettingsPanel settingPanelForDelete)
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            for (int i = 0; i < items.Count; i++)
            {
                if (settingPanelForDelete != null)
                {
                    ShowItemWithDelete showItemWithDelete = new ShowItemWithDelete(items[i], alarms[i],settingPanelForDelete);
                    flowLayoutPanel.Controls.Add(showItemWithDelete);
                }
                else
                {
                    ShowItem showItem = new ShowItem(items[i], alarms[i]);
                    flowLayoutPanel.Controls.Add(showItem);
                }
                
            }

        }
            public static List<AlarmStatus> createNoneAlarmStatus(int count)
            {
                List<AlarmStatus> noneAlarms = new List<AlarmStatus>();
                for (int i = 0; i < count; i++)
                {
                    noneAlarms.Add(AlarmStatus.None);
                }
                return noneAlarms;
            }
    }
}
