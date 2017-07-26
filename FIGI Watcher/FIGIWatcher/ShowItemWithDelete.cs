using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmartRefri
{
    public partial class ShowItemWithDelete : UserControl
    {
        SettingsPanel settingPanel;
        Item item;
        public ShowItemWithDelete(Item item,AlarmStatus alarmStatus,SettingsPanel settingPanel)
        {
            this.item = item;
            this.settingPanel = settingPanel;
            this.Dock = DockStyle.None;
            InitializeComponent();
            populateItem(item);
            setAlarm(alarmStatus);
            checkCriteria(item.ID);
        }

        private void checkCriteria(int itemID)
        {
            DateCriteria dateCriteria=DateCriteria.GetDateCriteria(itemID);
            if (dateCriteria!=null)
                expireLabel.Text = "Expiry Date: " + dateCriteria.ExpiryDate.ToShortDateString()+"\n";
            TemperatureCriteria tempCriteria = TemperatureCriteria.GetTemperatureCriteria(itemID);
            if (tempCriteria!=null)
            expireLabel.Text += "Best Temp: from " + tempCriteria.MinTemperature + "Cْ  to  " + tempCriteria.MaxTemperature+"Cْ";
        }

        private void setAlarm(AlarmStatus alarmStatus)
        {
            if (alarmStatus == AlarmStatus.Warning)
            {
                alarmPictureBox.Visible = true;
                //alarmPictureBox.Image = Properties.Resources.Bullet_RedFlashing;
            }
            else if (alarmStatus == AlarmStatus.Danger)
            {
                alarmPictureBox.Visible = true;
                alarmPictureBox.Image = Properties.Resources.Bullet_RedFlashing;
            }
        }

        private void populateItem(Item item)
        {
            nameLabel.Text = item.Name;
            typeLabel.Text = item.Type.ToString();
            codeLabel.Text = "Code: " + item.Code;
            if (item.Image != "")
            {
                if (File.Exists(Application.StartupPath + "\\itemImages\\" + item.Image))
                    itemPictureBox.Image = Image.FromFile(Application.StartupPath + "\\itemImages\\" + item.Image);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Item data will be deleted permanetly, are you sure?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                item.Delete();
                settingPanel.Initialize();
            }
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Item data will be deleted permanetly, are you sure?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                item.Delete();
                settingPanel.Initialize();
            }
        }

    }
}
