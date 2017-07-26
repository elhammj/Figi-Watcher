using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace SmartRefri
{
    public partial class WelcomePanel : UserControl
    {
        Form1 mainForm;
        List<Item> monitoringItems = new List<Item>();
        List<AlarmStatus> alarms = new List<AlarmStatus>();
        public WelcomePanel(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("ddd dd MMM yyyy") + " " + DateTime.Now.ToShortTimeString();
            mainForm.sensorTemp = TemperatureSensor.GetLastTemperature();
            tempLabel.Text = mainForm.sensorTemp.ToString() + "ْC";
            showRecentlyAddedItems();
            showMonitoringItems();
        }

        private void showRecentlyAddedItems()
        {
            List<Item> recentlyAddedItems = Item.GetRecentlyAddedItems();
            List<AlarmStatus> noneAlarms = new List<AlarmStatus>();
            for (int i = 0; i < recentlyAddedItems.Count; i++)
            {
                noneAlarms.Add(AlarmStatus.None);
            }
            ShowItemsList showItemsList = new ShowItemsList(recentlyAddedItems, noneAlarms, null);
            recentlyAddedPanel.Controls.Add(showItemsList);
        }

        private void showMonitoringItems()
        {
            addDateExpiredItems();
            addTemperatureExpiredItems();
            ShowItemsList showItemsList = new ShowItemsList(monitoringItems, alarms, null);
            if (monitoringItems.Count> 0)
                using (var soundPlayer = new SoundPlayer(Application.StartupPath + @"\sounds\alarm.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }

            monitoringExpirtyPanel.Controls.Add(showItemsList);
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("ddd dd MMM yyyy") + " " + DateTime.Now.ToShortTimeString();
        }

        private void inputLabel_MouseHover(object sender, EventArgs e)
        {
            inputLabel.BackColor = Color.FromArgb(50, Color.BlueViolet);
        }

        private void inputLabel_MouseLeave(object sender, EventArgs e)
        {
            inputLabel.BackColor = Color.FromArgb(0, Color.BlueViolet);
        }

        private void inputLabel_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.AddControl(new BarCodeImageControl(mainForm));
        }

        private void addDateExpiredItems()
        {
            List<Item> dateExpiredItems = ExpiryCriteria.getDateExpiredItems();
            List<AlarmStatus> dateAlarms = new List<AlarmStatus>();
            for (int i = 0; i < dateExpiredItems.Count; i++)
            {
                alarms.Add(AlarmStatus.Danger);
            }
            monitoringItems.AddRange(dateExpiredItems);
            alarms.AddRange(dateAlarms);
        }

        private void addTemperatureExpiredItems()
        {
            List<Item> temepratureExpiredItems = ExpiryCriteria.getTemperatureExpiredItems();
            List<AlarmStatus> temperatureAlarms = new List<AlarmStatus>();
            for (int i = 0; i < temepratureExpiredItems.Count; i++)
            {
                alarms.Add(AlarmStatus.Warning);
            }
            for (int i = 0; i < temepratureExpiredItems.Count; i++)
            {
                if(monitoringItems.Contains(temepratureExpiredItems[i]))
                {
                    temepratureExpiredItems.RemoveAt(i);
                    i--;
                }
            }
            monitoringItems.AddRange(temepratureExpiredItems);
            alarms.AddRange(temperatureAlarms);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.AddControl(new SettingsPanel(mainForm));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm.AddControl(new SettingsPanel(mainForm));
        }


        


    }
}
