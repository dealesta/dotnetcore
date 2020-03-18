using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Item>()
            {
                new Item{ Id=1, Name="Stuff 1", Price= 22},
                new Item{ Id=2, Name="Stuff 2"},
            };
            
            items.ForEach(i => Console.WriteLine(i.ToString()));
            var otherItems = items.Select(i => new { i.Id, i.Name, NewPrice = i.Price ?? 1 }).ToList();

            otherItems.ForEach(i => Console.WriteLine($"{i.Id}\t{i.Name}\t{i.NewPrice}\n"));
        }
    }

    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Price}\n";
        }
    }
}
