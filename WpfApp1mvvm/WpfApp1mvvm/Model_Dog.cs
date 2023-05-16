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
        // поля собаки, имя, пояснение, фотка
        public string dogName;
        public string dogDescription;
        public string imgPath;

        // get set имени
        public string DogName
        {
            get { return dogName; }
            set
            {
                dogName = value;
                // свойство передающее изменение в поле
                OnPropertyChanged("DogName");
            }
        }
        // get set прояснения
        public string DogDescription
        {
            get { return dogDescription; }
            set
            {
                dogDescription = value;
                // свойство передающее изменение в поле
                OnPropertyChanged("DogDescription");
            }
        }
        // get set фотки
        public string ImgPath
        {
            get { return imgPath; }
            set
            {
                imgPath = value;
                // свойство передающее изменение в поле
                OnPropertyChanged("ImgPath");
            }
        }
        // событие подписанное на изменение обязательное
        public event PropertyChangedEventHandler PropertyChanged;
        
        // изменение  
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
