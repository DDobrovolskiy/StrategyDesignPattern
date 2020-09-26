using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.DataReader
{
    public static class DataReader
    {
        public static string GetReaderText(IReader reader, string details)
        {
            return reader.GetText(details);
        }

        public static string GetReaderText(Func<string, string> reader, string details)
        {
            return reader?.Invoke(details);
        }
    }
}
