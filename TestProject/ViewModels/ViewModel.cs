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
                    Human.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Human, true));
                    Car.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Car, true));
                    Bike.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Bike, true));
                    Truck.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Truck, true));
                    Bus.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Bus, true));
                    Taxi.Add(new ChartModel(/*listData[i].Time*/i+1, listData[i].Taxi, true));
                }
            }
        }
    }
}
