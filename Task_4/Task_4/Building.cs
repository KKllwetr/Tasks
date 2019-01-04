using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Task_4
{
    public enum Colour : byte
    {
        Red = 1,
        Blue,
        Gray,
        Green
    }

    public class Building
    {
        private static object threadLock = new object();
        const double complexity_floor = 100; // условная единица для строительство этажа
        const double complexity_window = 40; // условная единица для окна
        private static object loc = new object();
        uint floors;
        uint windows;
        Colour c;
        bool roof;
        uint apartments;
        double totalresource;
        bool end;
        double progress;//прогресс 0-100 %
        public delegate void AccountStateHandler(object sender, AccountEventArgs e);
        public event AccountStateHandler DearthOfMaterials;
        public event AccountStateHandler ReadyForRoofing;
        Stonemasons stonemasons;
        IList<IConstructionEquipments> constructions;
        int number;
        public bool Roof { get { return roof; } set { roof = value; } }
        public Building() { }
        public bool ENd { get { return end; } set { end = value; } }
        public Building(uint floors, uint windows, uint apartments, int c, IList<IConstructionEquipments> constructions,
            Stonemasons stonemasons, int number)
        {
            switch (c)
            {
                case 1:
                    this.c = Colour.Red;
                    break;
                case 2:
                    this.c = Colour.Blue;
                    break;
                case 3:
                    this.c = Colour.Gray;
                    break;
                case 4:
                    this.c = Colour.Green;
                    break;
                default:
                    this.c = Colour.Blue;
                    break;
            }
            this.floors = floors;
            this.windows = windows;
            this.apartments = apartments;
            this.totalresource = floors * complexity_floor + windows * complexity_window;
            roof = false;
            end = false;
            this.stonemasons = stonemasons;
            this.constructions = constructions;
            this.number = number;
        }


        public void Build()
        {
            lock (loc)
            {
                while (progress < 100)
                {
                    if (progress == 70 && DearthOfMaterials != null)
                        DearthOfMaterials(this, new AccountEventArgs("Нужны строй материалы, Дать?", true));
                    if (progress == 90 && ReadyForRoofing != null)
                        ReadyForRoofing(this, new AccountEventArgs("Можно крыть крышу?", true));
                    if (progress == 100)
                        return;
                    if (ENd)
                        return;
                    progress += 5;
                    Thread.Sleep(300);
                }
            }
        }

        public double Progress { get { return progress; } }
        public uint Floor { get { return floors; } }
        public uint Windows { get { return windows; } }
        public Colour Colours { get { return c; } }
        public uint Apartments { get { return apartments; } }
        public int Number { get { return number; } }
    }
}
