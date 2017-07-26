using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SmartRefri
{
    public partial class ShowItem : UserControl
    {
        Item item;
        public ShowItem(Item item, AlarmStatus alarmStatus)
        {
            this.item = item;
            this.Dock = DockStyle.None;
            InitializeComponent();
            populateItem(item);
            setAlarm(alarmStatus);
            checkCriteria(item.ID);
        }

        private void checkCriteria(int itemID)
        {
            string toolTipText = "";
            DateCriteria dateCriteria = DateCriteria.GetDateCriteria(itemID);
            if (dateCriteria != null)
            {
                expireLabel.Text = "Expiry Date: " + dateCriteria.ExpiryDate.ToShortDateString() + "\n";
                TimeSpan time = dateCriteria.ExpiryDate - DateTime.Now;
                if (time.Days > 0 && time.Days<8)
                {
                    itemToolTip.ToolTipIcon = ToolTipIcon.Warning;
                    toolTipText = "Expiry Date after " + (time.Days).ToString() + " day(s).";
                }
                else if (time.Days <0)
                {
                    itemToolTip.ToolTipIcon = ToolTipIcon.Error;
                    toolTipText = "Item has been expired" + (time.Days).ToString() + " day(s)ago.";
                }
            }
            TemperatureCriteria tempCriteria = TemperatureCriteria.GetTemperatureCriteria(itemID);
            if (tempCriteria != null)
            {
                expireLabel.Text += "Temp: from " + tempCriteria.MinTemperature + " Cْ  to  " + tempCriteria.MaxTemperature + " Cْ ْ";
                int refTemp = Properties.Settings.Default.refrigeratorInternalTemperature;
                if (refTemp < tempCriteria.MinTemperature || refTemp > tempCriteria.MaxTemperature)
                {
                    if (toolTipText != "")
                        toolTipText += "\n";
                    if (refTemp < tempCriteria.MinTemperature)
                        toolTipText += "Temperature's too low for this item.";
                    else
                        toolTipText += "Temperature's too high for this item.";

                }
            }
            if (toolTipText != "")
            {
                itemToolTip.SetToolTip(this, toolTipText);
            }
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

        private void itemToolTip_Popup(object sender, PopupEventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(Application.StartupPath+@"\sounds\popup.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }

    }
}
