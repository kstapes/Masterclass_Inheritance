using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{
    class VideoPost:Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        
        public string VideoURL { get; set; }
        public int VideoDuration { get; set; }

        public VideoPost() {}


        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int videoDuration)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.VideoDuration = videoDuration;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} URL: {3} Length: {4} minutes long - by {2}", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.VideoDuration);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing Video");
                timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < VideoDuration)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }
    }
}
