using System;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var someBl = new BusinessLogic(new GoodDataBase());
            someBl.DoSomeActions();
        }
    }
}