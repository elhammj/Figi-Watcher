using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartRefri
{
    public partial class Form1 : Form
    {
        Control mainControl;
        public Item Item;
        public EntryDate entrydate;
        public List<ExpiryCriteria> ExpiryCriterias=new List<ExpiryCriteria>();
        public int sensorTemp;
        public Form1()
        {
            InitializeComponent();
            AddControl(new WelcomePanel(this));
        }

        public void AddControl(Control control)
        {
            control.Location = mainPanel.Location;
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Dispose();
            }
            Controls.Add(control);
            control.BringToFront();
            if(mainControl!=null)
                mainControl.Dispose();
            mainControl = control;
        }

      
    }
}
