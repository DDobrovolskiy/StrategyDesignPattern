using System;
using StrategyDesignPattern.DataReader;
using StrategyDesignPattern.Interface;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DataReader.DataReader dataReader = new DataReader.DataReader();

            Console.WriteLine(dataReader.GetReaderText(new StringDataReader(), "first\ntwo\nthree\nfoue\nfive"));

            Console.WriteLine("---");

            Console.WriteLine(dataReader.GetReaderText(new FileDataReader(), @"C:\Users\Dmitry\Desktop\CSharp Project\StrategyDesignPattern\StrategyDesignPattern\StrategyDesignPattern\Text.txt"));

            Console.ReadKey();
        }
    }
}
