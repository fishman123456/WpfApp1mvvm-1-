using System;
using System.Collections.Generic;
using System.Linq;
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


    public class ViewModel : INotifyPropertyChanged
    {
        private Model_Dog selectedDog;

        public Model_Dog SelectedDog
        {
            get { return selectedDog; }
            set
            {
                selectedDog = value;
                OnPropertyChanged("SelectedDog");
            }
        }


        public ObservableCollection<Model_Dog> Dogs { get; set; }
        public ViewModel()
        {
            Dogs = new ObservableCollection<Model_Dog> {
            new Model_Dog {DogName = "Золотистый ретривер", DogDescription = "Золотистые ретриверы — это не просто собаки. Они становятся лучшими друзьями своих хозяев и полноправными членами семьи, в которые их принимают",ImgPath = "IMG/GoldenRetriever.jpg" },
            new Model_Dog { DogName = "Волчья собака Сарлоса", DogDescription = "Саарлосвольф, как ее еще называют, — очень смелая собака, способная, благодаря своему по-волчьи чуткому обонянию, мгновенно понимать настроение человека и при необходимости защищать его от опасности. Выдрессированных представителей породы применяют в спасательных операциях, так как они не только способны находить людей, но и тащить вещи, превышающие их собственный вес.", ImgPath = "IMG/saarloswolfhond.jpg" },
            new Model_Dog { DogName = "Шиба-ину", DogDescription = "Шиба-ину — одна из самых древних пород собак из Азии. Археологи обнаружили, что предки современных iиба-ину были завезены в Японию более двух с половиной тысячелетий назад.", ImgPath = "IMG/shibaInu.jpg" },
            new Model_Dog { DogName = "Сибирский хаски", DogDescription = "На родине — в районах Дальнего Севера России — местные жители использовали предков хаски для передвижения по тундре и к местам выпаса оленей.", ImgPath = "IMG/siberianHusky.jpg" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}

