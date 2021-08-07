using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class DelegateTask
    {
        private Func<double, double, double> _sumHandler;
        public void Run()
        {
            var res = 0d;
            _sumHandler += Sum;
            _sumHandler += Sum;
            TryCatch(() => res = SumOfSumHandler(5, 6));
            Console.WriteLine(res);
        }

        private double Sum(double x, double y)
        {
            return x + y;
        }

        private void TryCatch(Action handler)
        {
            try
            {
                handler.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message, e.StackTrace);
            }
        }

        private double SumOfSumHandler(double x, double y)
        {
            var sum = 0d;
            var listOfDelegate = _sumHandler.GetInvocationList();
            foreach (var item in listOfDelegate)
            {
                sum += (item as Func<double, double, double>).Invoke(x, y);
            }

            return sum;
        }
    }
}
