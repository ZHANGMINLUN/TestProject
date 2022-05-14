using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TestProject.Models;
using TestProject.Services;

namespace TestProject.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<ChartModel> Human { get; set; }
        public ObservableCollection<ChartModel> Car { get; set; }
        public ObservableCollection<ChartModel> Bike { get; set; }
        public ObservableCollection<ChartModel> Truck { get; set; }
        public ObservableCollection<ChartModel> Bus { get; set; }
        public ObservableCollection<ChartModel> Taxi { get; set; }

        DataProcessing dataProcessing;
        List<Data> listData;
        public ViewModel()
        {
            Human = new ObservableCollection<ChartModel>();
            Car = new ObservableCollection<ChartModel>();
            Bike = new ObservableCollection<ChartModel>();
            Truck = new ObservableCollection<ChartModel>();
            Bus = new ObservableCollection<ChartModel>();
            Taxi = new ObservableCollection<ChartModel>();

            dataProcessing = new DataProcessing("Testing Data");
            listData = dataProcessing.ReadCsv();
            getData();
        }

        public void getData()
        {
            if (this.Human.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    Human.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Human));
                    Car.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Car));
                    Bike.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Bike));
                    Truck.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Truck));
                    Bus.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Bus));
                    Taxi.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Taxi));
                }
            }
        }


        #region Stupid Method
        private bool _visHuman = true;
        public bool VisibleHuman
        {
            get
            {
                return this._visHuman;
            }
            set
            {
                if (this._visHuman != value)
                {
                    this._visHuman = value;
                    //this.OnPropertyChanged("ShowLabels");
                }
            }
        }

        private bool _visCar = true;
        public bool VisibleCar
        {
            get
            {
                return this._visCar;
            }
            set
            {
                if (this._visCar != value)
                {
                    this._visCar = value;
                    //this.OnPropertyChanged("ShowLabels");
                }
            }
        }

        private bool _visBike = true;
        public bool VisibleBike
        {
            get
            {
                return this._visBike;
            }
            set
            {
                if (this._visBike != value)
                {
                    this._visBike = value;
                    //this.OnPropertyChanged("ShowLabels");
                }
            }
        }

        private bool _visTruck = true;
        public bool VisibleTruck
        {
            get
            {
                return this._visTruck;
            }
            set
            {
                if (this._visTruck != value)
                {
                    this._visTruck = value;
                    //this.OnPropertyChanged("ShowLabels");
                }
            }
        }

        private bool _visBus = true;
        public bool VisibleBus
        {
            get
            {
                return this._visBus;
            }
            set
            {
                if (this._visBus != value)
                {
                    this._visBus = value;
                    //this.OnPropertyChanged("ShowLabels");
                }
            }
        }

        private bool _visTaxi = true;
        public bool VisibleTaxi
        {
            get
            {
                return this._visTaxi;
            }
            set
            {
                if (this._visTaxi != value)
                {
                    this._visTaxi = value;
                    //this.OnPropertyChanged("ShowLabels");
                }
            }
        }
        #endregion
    }
}
