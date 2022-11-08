using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Repository
{
    abstract class GenericRepository<T>
    {
        protected String FileLocation;
        protected int nextId;

        public GenericRepository(String FileLocation)
        {
            this.FileLocation = FileLocation;
            nextId = 0;
        }

        public List<T> Load()
        {
            List<T> elements = new List<T>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');
                    T element = makeObject(words);

                    elements.Add(element);
                    nextId = returnId(element);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: ", e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block");
            }
            return elements;
        }

        abstract public T makeObject(string[] words);
        abstract public int returnId(T element);
        abstract public bool isDeleted(T element);
        abstract public String ObjectToString(T element);

        public void SaveElements(List<T> elements)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (T element in elements)
            {
                if (!isDeleted(element))
                {
                    line = ObjectToString(element);
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void DeleteFile()
        {
            File.Delete(FileLocation);
        }

        public int getNextId()
        {
            nextId++;
            return nextId;
        }
    }
}
