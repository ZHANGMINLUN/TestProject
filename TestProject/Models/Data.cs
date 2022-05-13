using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Data : IData
    {
        int _time;
        int _human;
        int _car;
        int _bike;
        int _truck;
        int _bus;
        int _taxi;

        public Data()
        {

        }
        public Data(int time, int human, int car, int bike, int truck, int bus, int taxi)
        {
            this._time = time;
            this._human = human;
            this._car = car;
            this._bike = bike;
            this._truck = truck;
            this._bus = bus;
            this._taxi = taxi;
        }


        public int Time { get { return _time; } set { _time = value; } }
        public int Human { get { return _human; } set { _human += value; } }
        public int Car { get { return _car; } set { _car += value; } }
        public int Bike { get { return _bike; } set { _bike += value; } }
        public int Truck { get { return _truck; } set { _truck += value; } }
        public int Bus { get { return _bus; } set { _bus += value; } }
        public int Taxi { get { return _taxi; } set { _taxi += value; } }
    }
}
