using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.DataReader
{
    public class DataReader
    {
        public string GetReaderText (IReader reader, string details)
        {
            return reader.GetText(details);
        }
    }
}
