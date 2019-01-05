using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Data
{
    public class Monitor
    {
        public delegate void NewCandleEvent(Candle candle, decimal indicator);
        public event NewCandleEvent NewCandle;
        private Thread Thread { get; set; }
        public Message Message { get; set; }
        public IIndicator Indicator { get; set; }

        public Monitor(Message mes, IIndicator indicator)
        {
            Message = mes;
            Indicator = indicator;
        }

        public void Run()
        {
            Thread = new Thread(new ThreadStart(Update));
            Thread.Start();
        }

        private void Update()
        {
            while (Message.Candles.Count != 0)
            {
                var candle = Message.GetCandle();
                NewCandle?.Invoke(candle, Indicator.Calculate(candle));
                Thread.Sleep(1000);
            }
        }

        public void Dispose() => Thread.Abort();
    }
}
