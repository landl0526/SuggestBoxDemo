using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SuggestBoxDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<VehicleExpert> _ExpertCollection;
        public ObservableCollection<VehicleExpert> ExpertCollection
        {
            get { return _ExpertCollection; }
            set
            {
                _ExpertCollection = value;
            }
        }
        public MainPage()
        {
            InitializeComponent();

            ExpertCollection = new ObservableCollection<VehicleExpert>();
            ExpertCollection.Add(new VehicleExpert { ExpertName = "RALPH", Code = "GURA" });
            ExpertCollection.Add(new VehicleExpert { ExpertName = "KIRK", Code = "JUKI" });
            ExpertCollection.Add(new VehicleExpert { ExpertName = "EDGAR", Code = "EDDI" });
            ExpertCollection.Add(new VehicleExpert { ExpertName = "CHRISTIAN", Code = "XIAN" });
            ExpertCollection.Add(new VehicleExpert { ExpertName = "RUEL", Code = "RUEL" });
            ExpertCollection.Add(new VehicleExpert { ExpertName = "JOSEPH", Code = "CAJO" });
            AutosuggestBox.ItemsSource = ExpertCollection;
        }
    }

    public class VehicleExpert : INotifyPropertyChanged
    {
        private string _code;

        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (_code != value)
                {
                    _code = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _expertName;

        public string ExpertName
        {
            get
            {
                return _expertName;
            }
            set
            {
                if (_expertName != value)
                {
                    _expertName = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

