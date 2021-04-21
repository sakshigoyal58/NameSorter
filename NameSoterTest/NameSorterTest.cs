using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;

namespace NameSorterTest
{
    [TestClass]
    public class NameSorterTest
    {
        [TestMethod]
        public void SortNameTest()
        {
            string fileName = "unsorted-names-list.txt";
            ISorter sorter = new Sorter();
            IFileOperations fileOperations = new FileOperations(fileName, sorter);
            fileOperations.ReadNamesFromFile();
            fileOperations.SortNamesFromFile();
            fileOperations.WriteSortedNameListtoFile();
        }
    }
}
