using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Message
    {
        public ILoader Loader { get; private set; }
        public Queue<Candle> Candles { get; private set; }

        public Candle GetCandle() => Candles.Dequeue();
        public void Update() => Candles = Loader.GetCandles();

        public Message(ILoader loader)
        {
            Loader = loader;
            Candles = loader.GetCandles();
        }
    }
}
