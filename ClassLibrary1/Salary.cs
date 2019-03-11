using System;

namespace ClassLibrary1
{
    public class Salary : ISalary
    {
        public double Total(double x)
        {
            return x * 3.14;
        }
    }
}
