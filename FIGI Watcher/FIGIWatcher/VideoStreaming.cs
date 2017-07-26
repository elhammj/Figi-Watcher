using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;

namespace SmartRefri
{
    class VideoStreaming
    {
        public bool cameraExist = false;
        public bool streamingVideoCamera = false;
        public FilterInfoCollection videoDevices;
        public VideoCaptureDevice videoSource = null;
        public delegate void video_NewFrame(object sender, NewFrameEventArgs eventArgs);
        public video_NewFrame newFramEvent;
        public VideoStreaming(video_NewFrame newFramEvent)
        {
            this.newFramEvent = newFramEvent;
        }
        public void StartStreaming()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
                throw new ApplicationException();
            cameraExist = true; //make dafault to first cam
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(newFramEvent);
            CloseVideoSource();
            videoSource.DesiredFrameSize = new Size(200, 250);
            //videoSource.DesiredFrameRate = 10;
            videoSource.Start();
            streamingVideoCamera = true;
        }

        public void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    streamingVideoCamera = false;
                    videoSource = null;
                }
        }
    }
}
