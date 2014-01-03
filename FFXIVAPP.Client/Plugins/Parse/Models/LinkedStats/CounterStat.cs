// FFXIVAPP.Client
// CounterStat.cs
// 
// � 2013 Ryan Wilson

using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.Plugins.Parse.Models.LinkedStats
{
    [DoNotObfuscate]
    public class CounterStat : NumericStat
    {
        public CounterStat(string name, decimal value) : base(name, 0m)
        {
        }

        public CounterStat(string name) : base(name, 0m)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="amount"> </param>
        /// <returns> </returns>
        private decimal Increment(decimal amount)
        {
            Value += amount;
            return Value;
        }
    }
}