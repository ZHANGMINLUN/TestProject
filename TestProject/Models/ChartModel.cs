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
        bool _isShow;
        public ChartModel(int index, int value, bool isShow)
        {
            this._index = index;
            this._value = value;
            this._isShow = isShow;
        }

        public int Index { get { return _index; } set {; } }
        public int Value { get { return _value; } set {; } }
        public bool IsShow { get { return _isShow; } set {; } }
    }
}
