using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_005_classes.Models
{
    internal class Calculator
    {
        private double _sum = 0;
        public double Add(double value)
        {
            return _sum += value;
        }
    }
}
