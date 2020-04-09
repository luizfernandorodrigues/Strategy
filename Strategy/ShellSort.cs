using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shel Sorted list");
        }
    }
}
