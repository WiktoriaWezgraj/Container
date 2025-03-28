using System.ComponentModel.DataAnnotations;

namespace Container
{
    public class Container
    {
        List<int> container = new List<int>();
        public int maxLength = 5;

        public void TryAdd(int value)
        {
            if (container.Count < maxLength+1)
            {
                container.Add(value);
            }
            else
            {
                Console.WriteLine("Operation not possible.");
            }
        }

        public void ForceAdd(int value)
        {
            TryAdd(value);
            if (container.Count > maxLength)
            {
                container.RemoveAt(0);
                container.Add(value);
            }
        }

        public void GetAll()
        {
            for (int i = 0; i < container.Count; i++) 
            {
                Console.WriteLine(container[i]);
            }
        }

        class Program
        {
            static void Main()
            {
                var numberContainer = new Container();
                numberContainer.TryAdd(1);
                numberContainer.TryAdd(2);
                numberContainer.TryAdd(3);
                numberContainer.TryAdd(4);
                numberContainer.TryAdd(5);
                numberContainer.TryAdd(6);
                numberContainer.ForceAdd(99);
                numberContainer.GetAll();
                
            }
        }
    }
}
