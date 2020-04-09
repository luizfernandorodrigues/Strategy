using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortedStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortedStrategy = sortStrategy;
        }

        public void Add(string nome)
        {
            _list.Add(nome);
        }

        public void Sort()
        {
            _sortedStrategy.Sort(_list);

            foreach (var item in _list)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
