using System;

namespace WarmWinter
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Stack<int> hats = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            LinkedList<int> scarfs = new LinkedList<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            List<int> sets = new();


            while (hats.Any() && scarfs.Any())
            {
                int hat = hats.Pop();
                int scarf = scarfs.FirstOrDefault();

                if (hat > scarf)
                {
                    sets.Add(hat + scarf);
                    scarfs.Remove(scarf);
                }
                else if (scarf > hat)
                {
                    scarfs.Remove(scarf);
                    scarfs.AddFirst(scarf);
                }
                else if (scarf == hat)
                {
                    hat += 1;
                    hats.Push(hat);
                    scarfs.Remove(scarf);
                }
            }

            int maxPriceSet = sets.Max();

            Console.WriteLine($"The most expensive set is: {maxPriceSet}");

            foreach (var set in sets)
            {
                Console.Write($"{set} ");
            }
        }
    }
}