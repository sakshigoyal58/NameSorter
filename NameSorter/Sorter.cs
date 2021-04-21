using System;
using System.Collections.Generic;

namespace NameSorter
{
    public class Sorter : ISorter
    {
        public void SortNames(List<NameBuilder> nameList)
        {
            nameList.Sort((x, y) => { return String.Compare(x.LastName, y.LastName); });

         }
    }
}
