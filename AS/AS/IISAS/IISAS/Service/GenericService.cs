using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IISAS.Service
{
    abstract class GenericService<T>
    {
        protected Repository.GenericRepository<T> repository;

        public GenericService() { }

        public List<T> GetAll()
        {
            return repository.Load();
        }

        abstract public int returnId(T element);
        abstract public T returnNULL();
        abstract public void deleteOne(T element);
        abstract public void updateOne(T element, T updatedElement);

        public T GetOne(int elementId)
        {
            List<T> elements = GetAll();
            Console.WriteLine("Trazim ID " + elementId.ToString());
            
            foreach (T element in elements)
            {
                Console.WriteLine("Pronasao sam id " + returnId(element).ToString());
                if (returnId(element) == elementId)
                {
                    Console.WriteLine("Ura");
                    return element;
                }
            }
            return returnNULL();
        }

        public void CreateElement(T element)
        {
            List<T> elements = GetAll();
            elements.Add(element);
            repository.SaveElements(elements);
        }

        public void DeleteElement(int elementId)
        {
            List<T> elements = GetAll();
            foreach (T element in elements)
            {
                if (returnId(element) == elementId)
                {
                    deleteOne(element);
                    repository.SaveElements(elements);
                    return;
                }
            }
        }

        public void Update(T updatedElement)
        {
            List<T> elements = GetAll();
            foreach (T element in elements)
            {
                if (returnId(element) == returnId(updatedElement))
                {
                    updateOne(element, updatedElement);
                    repository.SaveElements(elements);
                    return;
                }
            }
        }

        public int getNextId()
        {
            GetAll();
            return repository.getNextId();
        }

    }
}
