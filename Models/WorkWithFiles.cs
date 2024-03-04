using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortaOneMVC.Models
{
    public static class WorkWithFiles
    {
        public static List<int> ReadNumbersToList(StreamReader sr)
        {
            var readedList = new List<int>();

            string? line;

            while ((line = sr.ReadLine()) is not null)
            {
                readedList.Add(int.Parse(line));
            }

            return readedList;
        }
    }
}
