using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Model.Interfaces;

namespace TestProject.Models
{
    public class ChartModel : IChartModel
    {
        int _index;
        int _value;
        public ChartModel(int index, int value)
        {
            this._index = index;
            this._value = value;
        }

        public int Index { get { return _index; } set {; } }
        public int Value { get { return _value; } set {; } }
    }
}
