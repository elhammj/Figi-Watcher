using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;

namespace SmartRefri
{
    public partial class BarCodeImageControl : UserControl
    {
        Form1 mainForm;
        bool cameraExist = false;
        bool streamingVideoCamera = false;
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource = null;

        public BarCodeImageControl(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void barcodePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (barcodePictureBox.Image != null && barcodePictureBox.Image.Size.Width > barcodePictureBox.Size.Width)
                barcodePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                barcodePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }


        private void itemImagePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (itemImagePictureBox.Image != null && itemImagePictureBox.Image.Size.Width > itemImagePictureBox.Size.Width)
                itemImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                itemImagePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }


        private void BarCodeImageControl_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.Item = new Item();
            mainForm.Item.Code = itemCodeTextBox.Text;
            try
            {
                CloseVideoSource();
                Image itemImage = itemImagePictureBox.Image;
                string itemImageName = Path.GetRandomFileName().Replace('.', 'a');
                string fullImageFileName = Application.StartupPath + "\\itemImages\\" + itemImageName + ".bmp";
                itemImage.Save(fullImageFileName);
                mainForm.Item.Image = itemImageName + ".bmp";
            }
            catch (Exception exception)
            {
                mainForm.Item.Image = "";
                CloseVideoSource();
            }
            mainForm.AddControl(new CategoryNameControl(mainForm));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            barcodePictureBox.Image = Properties.Resources.barCode;
            itemCodeTextBox.Focus();
            //
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                    throw new ApplicationException();
                cameraExist = true; //make dafault to first cam
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                CloseVideoSource();
                videoSource.DesiredFrameSize = new Size(200, 250);
                //videoSource.DesiredFrameRate = 10;
                videoSource.Start();
                streamingVideoCamera = true;
            }
            catch (ApplicationException)
            {
                cameraExist = false;
                Image itemImage = getItemCameraImage();
                itemImagePictureBox.Image = itemImage;
            }
            //


            timer.Enabled = false;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            itemImagePictureBox.Image = img;
        }

        private void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }

        private Bitmap getItemCameraImage()
        {
            return Properties.Resources.item;
        }

        private void itemImagePictureBox_Click(object sender, EventArgs e)
        {
            if (!cameraExist)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    itemImagePictureBox.Image = new Bitmap(Image.FromFile(openFileDialog1.FileName),new Size(200, 250));
                }
            }
            else
            {
                if (streamingVideoCamera)
                    CloseVideoSource();
                else
                    videoSource.Start();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.AddControl(new WelcomePanel(mainForm));
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            mainForm.AddControl(new WelcomePanel(mainForm));
        }

    }
}
