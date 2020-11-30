using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ExpanderXamarin.Model
{
    public class InboxInfo : INotifyPropertyChanged
    {
        #region Fields

        private string title;
        private string subject;
        private string desc;
        private string date;
        private bool isExpanded;
        private FontAttributes fontStyle = FontAttributes.Bold;
        #endregion

        #region Constructor

        public InboxInfo()
        {

        }

        #endregion

        #region Properties

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
                OnPropertyChanged("Subject");
            }
        }

        public string Description
        {
            get
            {
                return desc;
            }

            set
            {
                desc = value;
                OnPropertyChanged("Description");
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }


        public bool IsExpanded
        {
            get 
            {
                return isExpanded;
            }
            set
            {
                isExpanded = value;
                OnPropertyChanged("IsExpanded"); 
            }
        }
        
        public FontAttributes FontStyle
        {
            get 
            {
                return fontStyle;
            }
            set
            {
                fontStyle = value;
                OnPropertyChanged("FontStyle"); 
            }
        }
        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
