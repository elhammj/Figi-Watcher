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
    public partial class SettingsPanel : UserControl
    {
        Form1 mainForm;
        List<Item> allItems = new List<Item>();
        List<AlarmStatus> alarms = new List<AlarmStatus>();
        public SettingsPanel(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            showAllItems();
            showMostConsumedItems();
            showMostExpiredItems();
        }

        private void showMostExpiredItems()
        {
            List<Item> allItems = Item.GetMostExpiredItems();
            ShowItemsList showItemsList = new ShowItemsList(allItems, ShowItemsList.createNoneAlarmStatus(allItems.Count), null);
            mostExpiredItemsPanel.Controls.Clear();
            mostExpiredItemsPanel.Controls.Add(showItemsList);
        }

        private void showMostConsumedItems()
        {
            List<Item> allItems = Item.GetMostConsumedItems();
            ShowItemsList showItemsList = new ShowItemsList(allItems, ShowItemsList.createNoneAlarmStatus(allItems.Count), null);
            mostConsumedPanel.Controls.Clear();
            mostConsumedPanel.Controls.Add(showItemsList);
        }

        public void showAllItems()
        {
            List<Item> allItems = Item.GetAllItems();
            ShowItemsList showItemsList = new ShowItemsList(allItems, ShowItemsList.createNoneAlarmStatus(allItems.Count), this);
            
            for (int i = 0; i < allItems.Count; i++)
            {
                searchTextBox.AutoCompleteCustomSource.Add(allItems[i].Name);
            }
            
            allItemsPanel.Controls.Clear();
            allItemsPanel.Controls.Add(showItemsList);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.AddControl(new WelcomePanel(mainForm));
        }


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                List<Item> searchItems = Item.GetItemsByName(searchTextBox.Text);
                ShowItemsList showItemsList = new ShowItemsList(searchItems, ShowItemsList.createNoneAlarmStatus(searchItems.Count), null);
                searchPanel.Controls.Clear();
                if (searchItems.Count > 0)
                {
                    searchPanel.Controls.Add(showItemsList);
                    searchPanel.Visible = true;
                    searchLabel.Visible = false;
                }
                else
                {
                    searchPanel.Visible = false;
                    searchLabel.Visible = true;
                }
            }
            else
            {
                searchLabel.Visible = false;
                searchPanel.Visible = false;
            }

        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            mainForm.AddControl(new WelcomePanel(mainForm));
        }

        
    }
}
