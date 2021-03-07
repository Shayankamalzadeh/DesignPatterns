using Singletone;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletoneForMultiThread firstInstance =  SingletoneForMultiThread.Instance;
            SingletoneForMultiThread Secondinstance = SingletoneForMultiThread.Instance;
            var x = ReferenceEquals(firstInstance, Secondinstance);

            Console.WriteLine(x);
        }
    }
}
