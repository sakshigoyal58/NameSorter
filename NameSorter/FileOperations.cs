using System;
using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class FileOperations : IFileOperations
    {
        List<NameBuilder> nameList = new List<NameBuilder>();
        string fileName = string.Empty;
        ISorter sorter;

        public FileOperations(string fileName, ISorter sorter)
        {
            this.fileName = fileName;
            this.sorter = sorter;
        }

        public void ReadNamesFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string name;
                    while ((name = sr.ReadLine()) != null)
                    {
                        NameBuilder nameBuilder = new NameBuilder();
                        nameBuilder.LastName = name.Substring(name.LastIndexOf(" ") + 1);
                        nameBuilder.FullName = name;
                        nameList.Add(nameBuilder);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                
            }
            catch (IOException ex)
            {
                

            }
            catch(Exception ex)
            {

            }
        }

        public void SortNamesFromFile()
        {
            sorter.SortNames(nameList);
        }

        public void WriteSortedNameListtoFile()
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (NameBuilder nameBuilder in nameList)
                    {
                        outputFile.WriteLine(nameBuilder.FullName);
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
