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
    public partial class CategoryNameControl : UserControl
    {
        Form1 mainForm;
        public CategoryNameControl(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void milkButton_Click(object sender, EventArgs e)
        {
            mainForm.Item.Type = ItemType.Milk;
            forwardToNextPanel();
        }

        private void forwardToNextPanel()
        {
            mainForm.Item.Name = itemNameTextBox.Text;
            mainForm.AddControl(new ExpiryCriteriaControl(mainForm));
        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            mainForm.Item.Type = ItemType.Meat;
            forwardToNextPanel();
        }

        private void vegetablesButton_Click(object sender, EventArgs e)
        {
            mainForm.Item.Type = ItemType.FruitsVegetables;
            forwardToNextPanel();
        }

        private void preserversButton_Click(object sender, EventArgs e)
        {
            mainForm.Item.Type = ItemType.Preservers;
            forwardToNextPanel();
        }

        private void bakeryButton_Click(object sender, EventArgs e)
        {
            mainForm.Item.Type = ItemType.Bakery;
            forwardToNextPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Item.Type = ItemType.Others;
            forwardToNextPanel();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.AddControl(new BarCodeImageControl(mainForm));
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            mainForm.AddControl(new BarCodeImageControl(mainForm));
        }

    }
}
