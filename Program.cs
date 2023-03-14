using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace code
{
    internal class Program
    {
    
static void Main(string[] args)
        {
            
            var colors = new Dictionary<int, string>()
            {
                [5] = "green",
                [3] = "blue",
                [8] = "orange",
                [1] = "white",
                [2] = "black",
                [9] = "red",
                [4] = "violet"
            };
            foreach (var color in colors)
            {
                Console.WriteLine($"Key: {color.Key}.  Value: {color.Value}.");
            }
            var maxKey = colors.OrderByDescending(x => x.Key).First().Key;
            var minKey = colors.OrderByDescending(x => x.Key).Last().Key;
            Console.WriteLine();
            Console.WriteLine($"The biggest key: {maxKey}");
            Console.WriteLine($"The smallest key: {minKey}");
            colors.Remove(maxKey);
            colors.Remove(minKey);
            Console.WriteLine();
            Console.WriteLine("Dictionary after removing max and min keys: ");
            foreach (var color in colors)
            {
                Console.WriteLine($"Key: {color.Key}.  Value: {color.Value}.");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Dictionary by keys: ");
           
            var l = colors.OrderBy(key => key.Key);

            var dic = l.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            foreach (var item in dic)
            {

                Console.WriteLine($"Key: {item.Key}. Value: {item.Value}");
            }
            Console.ReadKey();  
        }
    }
}
