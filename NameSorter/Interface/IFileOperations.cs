namespace NameSorter
{
    public interface IFileOperations
    {
        void ReadNamesFromFile();
        void SortNamesFromFile();
        void WriteSortedNameListtoFile();
    }
}