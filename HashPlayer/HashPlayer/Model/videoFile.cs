using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HashPlayer.Model
{
    public class VideoFile : INotifyPropertyChanged
    {
        private string path;

        public string Path
        {
            get { return path; }
            set
            {
                path = value;
                OnPropertyChanged("Path");
            }
        }

        private int duration;

        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged("Duration");
            }
        }

        private int timeRemaining;

        public int TimeRemaining
        {
            get { return timeRemaining; }
            set
            {
                timeRemaining = value;
                OnPropertyChanged("TimeRemaining");
                OnPropertyChanged("TimePassed");
            }
        }

        private int timePassed;

        public int TimePassed
        {
            get { return timePassed; }
            set
            {
                timePassed = value;
                OnPropertyChanged("TimePassed");
                OnPropertyChanged("TimeRemaining");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public VideoFile()
        {
            this.Path = "no path";
            this.Duration = 0;
            this.TimePassed = 0;
            this.TimeRemaining = 0;
        }
    }
}
