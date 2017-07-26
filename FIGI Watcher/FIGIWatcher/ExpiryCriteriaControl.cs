using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;

namespace SmartRefri
{
    public partial class ExpiryCriteriaControl : UserControl
    {
        Form1 mainForm;
        VideoStreaming videoStreaming;
        public ExpiryCriteriaControl(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            mainForm.ExpiryCriterias.Clear();
            categoryLabel.Text = mainForm.Item.Type.ToString();
            // ----- camera streaming
            VideoStreaming.video_NewFrame newFramEvent = new VideoStreaming.video_NewFrame(newFrame);
            try
            {
                videoStreaming = new VideoStreaming(newFramEvent);
                videoStreaming.StartStreaming();
            }
            catch (Exception e)
            {
                videoStreaming.CloseVideoSource();
                videoStreaming.cameraExist = false;
                MessageBox.Show(e.Message+"\nCamera is not Connected", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            videoStreamingPictureBox.Image = img;
        }

        private void expiryDateButton_Click(object sender, EventArgs e)
        {
            DateCriteria dateCriteria = new DateCriteria();
            DateTime expiryDate = calculateExpiryDate();
            dateCriteria.ExpiryDate = expiryDate;
            mainForm.ExpiryCriterias.Add(dateCriteria);
            expiryDateButton.Enabled = false;
        }

        private DateTime calculateExpiryDate()
        {
            int timeConst = 500;
            switch (mainForm.Item.Type)
            {
                case ItemType.Milk:
                    timeConst = 150;
                    break;
                case ItemType.Meat:
                    timeConst = 250;
                    break;
                case ItemType.FruitsVegetables:
                    timeConst = 100;
                    break;
                case ItemType.Bakery:
                    timeConst = 300;
                    break;
            }
            int days = timeConst / mainForm.sensorTemp;
            return DateTime.Now.AddDays(days);
        }

        private DateTime getExpiryDateFromDateTimePicker()
        {
            return expiryDateTimePicker.Value;
        }

        private void expiryTemperatureButton_Click(object sender, EventArgs e)
        {
            TemperatureCriteria tempCriteria = new TemperatureCriteria();
            tempCriteria.MinTemperature = getMinTemperature();
            tempCriteria.MaxTemperature = getMaxTemperature();
            mainForm.ExpiryCriterias.Add(tempCriteria);
            expiryTemperatureButton.Enabled = false;
        }

        private int getMinTemperature()
        {
            return (int)minNumericUpDown.Value;
        }

        private int getMaxTemperature()
        {
            return (int)maxNumericUpDown.Value;
        }

        private void ExpiryCriteriaControl_Click(object sender, EventArgs e)
        {
            mainForm.Item.Add();
            // create an entryDate Object
            mainForm.entrydate = new EntryDate();
            mainForm.entrydate.IsIn = true;
            mainForm.entrydate.DateTime = DateTime.Now;
            mainForm.entrydate.ItemID = mainForm.Item.ID;
            mainForm.entrydate.Add();
            // Add Every Expire Criterias
            for (int i = 0; i < mainForm.ExpiryCriterias.Count; i++)
            {
                mainForm.ExpiryCriterias[i].ItemID = mainForm.Item.ID;
                mainForm.ExpiryCriterias[i].Add();
            }
            mainForm.AddControl(new WelcomePanel(mainForm));
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.AddControl(new CategoryNameControl(mainForm));
        }

        private void videoStreamingPictureBox_Click(object sender, EventArgs e)
        {
            DateCriteria dateCriteria = new DateCriteria();
            DateTime expiryDate=DateTime.Now;
            if (videoStreaming.cameraExist)
            {
                if (videoStreaming.streamingVideoCamera)
                {
                    videoStreaming.CloseVideoSource();
                    try
                    {
                        TesseractOCREngine OCREngine = new TesseractOCREngine( new Bitmap(videoStreamingPictureBox.Image,new Size(800,600)));
                        expiryDate=OCREngine.GetExpiredDate();
                        expiryDateTimePicker.Value = expiryDate;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        videoStreaming.StartStreaming();
                        return;
                    }
                }
                else
                {
                    videoStreaming.StartStreaming();
                    return;
                }
            }
            else
            {
                expiryDate = getExpiryDateFromDateTimePicker();
            }
            dateCriteria.ExpiryDate = expiryDate;
            mainForm.ExpiryCriterias.Add(dateCriteria);
            videoStreamingPictureBox.Enabled = false;
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            mainForm.AddControl(new CategoryNameControl(mainForm));
        }


        // --------------- CaMera Streaming


    }
}
