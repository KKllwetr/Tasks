using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Data
{
    public class LoaderJS : ILoader
    {
        private string _fileName;

        public LoaderJS(string fileName) => _fileName = fileName;

        public Queue<Candle> GetCandles()
        {
            Queue<Candle> candles = new Queue<Candle>();
            var text = File.ReadAllText(_fileName);
            dynamic json = JsonConvert.DeserializeObject(text);

            List<decimal> open = json.o.ToObject<List<decimal>>();
            List<decimal> high = json.h.ToObject<List<decimal>>();
            List<decimal> low = json.l.ToObject<List<decimal>>();
            List<decimal> close = json.c.ToObject<List<decimal>>();
            List<long> timestamp = json.t.ToObject<List<long>>();
            

            for (int i = 0; i < open.Count; i++)
            {
                Candle candle = new Candle()
                {
                    High = high[i],
                    Low = low[i],
                    Open = open[i],
                    Close = close[i],
                    Time = DateTimeOffset.FromUnixTimeSeconds(timestamp[i]).UtcDateTime,
                    TimeStamp = timestamp[i],
                    
                };

                candles.Enqueue(candle);
            }

            return candles;
        }
    }
}
