using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sam.Coach
{
    internal class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {

        IEnumerable<int> result = new[] { 3, 5, 8 };
            
        
        // TODO: return the longest raising sequence in the collection provided, i.e.
        // when numbers = [4, 6, -3, 3, 7, 9] then expected result is [-3, 3, 7, 9]
        // when numbers = [9, 6, 4, 5, 2, 0] then expected result is [4, 5]
        Console.WriteLine(result);
        Trace.Write(result);
            
            return result;
        });
    }
}
