using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    public class Calculator
    {
        public int total;
        public List<int> numbers = new List<int>();

        public void Add(int number)
        {
            numbers.Add(number);
        }

        public int Sum()
        {
            return numbers.Sum();
        }
    }
}
