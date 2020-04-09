using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentsRecords = new SortedList();

            studentsRecords.Add("Luiz Fernando");
            studentsRecords.Add("Lot");
            studentsRecords.Add("Gilmar");
            studentsRecords.Add("Fábio");
            studentsRecords.Add("Mateus");
            studentsRecords.Add("Gaspar");
            studentsRecords.Add("Leandro");
            studentsRecords.Add("Willian");

            studentsRecords.SetSortStrategy(new QuickSort());
            studentsRecords.Sort();

            studentsRecords.SetSortStrategy(new ShellSort());
            studentsRecords.Sort();

            studentsRecords.SetSortStrategy(new MergeSort());
            studentsRecords.Sort();

            Console.ReadKey();
        }
    }
}
