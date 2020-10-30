using System;
using System.ComponentModel;

namespace PaymentRecorder
{
    public class PaymentData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentNullException("propertyName");
            }
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        private string _seq_no;
        public string seq_no
        {
            get { return _seq_no; }
            set
            {
                if (_seq_no != value)
                    _seq_no = value;
                OnPropertyChanged("seq_no");
            }
        }

        private string _datetime;
        public string datetime
        {
            get { return _datetime; }
            set
            {
                if (_datetime != value)
                    _datetime = value;
                OnPropertyChanged("datetime");
            }
        }

        private string _payment;
        public string payment
        {
            get { return _payment; }
            set
            {
                if (_payment != value)
                    _payment = value;
                OnPropertyChanged("payment");
            }
        }

        private string _comment;
        public string comment
        {
            get { return _comment; }
            set
            {
                if (_comment != value)
                    _comment = value;
                OnPropertyChanged("comment");
            }
        }

    }
}
