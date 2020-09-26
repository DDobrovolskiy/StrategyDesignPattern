using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace StrategyDesignPattern.Interface
{
    public class FileDataReader : IReader
    {
        public string GetText(string details)
        {
            if(string.IsNullOrEmpty(details))
            {
                return string.Empty;
            }

            using(StreamReader fileReder = new StreamReader(details))
            {
                var dataArray = fileReder.ReadToEnd().Trim().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var resultText = dataArray.Select((x, i) => $"{i + 1}: {x}");
                return string.Join('\n', resultText);
            }
        }
    }
}
