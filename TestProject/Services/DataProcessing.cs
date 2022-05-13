using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TestProject.Models;

namespace TestProject.Services
{
    public class DataProcessing
    {
        string path;
        public DataProcessing(string filename)
        {
            this.path = String.Format("./{0}.csv", filename);
        }

        int count = 0;
        public List<Data> ReadCsv()
        {
            List<Data> ListData = new List<Data>();
            string[] lines = File.ReadAllLines(path);
            lines = lines.Skip(1).ToArray();

            Data data = new Data();
            foreach (string line in lines)
            {
                string[] s = line.Split(',');
                data.Time = int.Parse(s[0]);
                data.Human = int.Parse(s[1]);
                data.Car = int.Parse(s[2]);
                data.Bike = int.Parse(s[3]);
                data.Truck = int.Parse(s[4]);
                data.Bus = int.Parse(s[5]);
                data.Taxi = int.Parse(s[6]);

                count = (++count) % 60;
                if (count == 0)
                {
                    ListData.Add(data);
                    data = new Data();
                }
            }
            if (count != 0) ListData.Add(data);
            return ListData;
        }
    }
}
