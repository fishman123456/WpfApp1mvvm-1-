using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1mvvm
{
    public class Model_Dog : INotifyPropertyChanged
    {
        public string dogName;
        public string dogDescription;
        public string imgPath;

        public string DogName
        {
            get { return dogName; }
            set
            {
                dogName = value;
                OnPropertyChanged("DogName");
            }
        }
        public string DogDescription
        {
            get { return dogDescription; }
            set
            {
                dogDescription = value;
                OnPropertyChanged("DogDescription");
            }
        }
        public string ImgPath
        {
            get { return imgPath; }
            set
            {
                imgPath = value;
                OnPropertyChanged("ImgPath");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
