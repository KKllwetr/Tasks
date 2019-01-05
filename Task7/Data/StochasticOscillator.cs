using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class StochasticOscillator : IIndicator 
    {
        public StochasticOscillator()
        {}

        public decimal Calculate(Candle candle) => (candle.Close - candle.Low) / (candle.High - candle.Low) * 100;
    }
}
