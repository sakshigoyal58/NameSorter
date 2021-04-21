using System.Collections.Generic;

namespace NameSorter
{
    public interface ISorter
    {
        void SortNames(List<NameBuilder> nameList);
    }
}