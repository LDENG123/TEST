using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Class1: INotifyPropertyChanged
    {
         public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged1(string propertyName = null)
    {
        if (PropertyChanged != null)
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
        public Class1()
        {
            Str1[0] = "W1";
            Str1[1] = "W2";
            Task.Run(() =>
            { int i = 0;
              
                while (true)
                {
                   
                    i++;
                    //Str = i.ToString();
                    if (i > 257)
                    {
                        i = 0;
                    }
                    Thread.Sleep(500);
                }

            });
        
        }
    private string str;
        public string Str
        {
            get { return str; }
            set
            {
                str = value;
                OnPropertyChanged1("Str");
            }
        }
        private string str2;
        public string Str2
        {
            get { return str2; }
            set
            {
                str2 = value;
                OnPropertyChanged1("Str2");
            }
        }
        private string[] str1=new string[] { "A1", "Q2" };
        public string[] Str1
        {
            get { return str1; }
            set
            {
                str1 = value;
                OnPropertyChanged1("Str1");
            }
        }
    }
}
