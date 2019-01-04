using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_4.Techniques;
using System.Threading;

namespace Task_4
{
    class World
    {
        Bitmap bitmap;
        IList<Building> buildings;
        public IList<Building> Buildings { get; set; }
        List<Thread> threads = new List<Thread>();

        public void Start(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            buildings = new List<Building>()
            {
               new Building (4, 2 , 1, 1, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),1),
               new Building (3, 2 , 1, 2, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),2),
               new Building (2, 2 , 1, 3, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),3),
               new Building (1, 2 , 1, 4, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),4),
            };
            Demonstrate();
        } 

        public void Demonstrate()
        {
            for (int i = 0; i < buildings.Count; i++)
            {
                buildings[i].DearthOfMaterials += Show_Message;
                buildings[i].ReadyForRoofing += Show_Message2;
                Thread myThread = new Thread(buildings[i].Build);
                myThread.Name = "Поток " + i.ToString();
                threads.Add(myThread);
                myThread.Start();
            }
        }

        public void Add(uint _countworker, uint _countcars, uint floor, uint windows, int colors, int number)
        {
            IList<IConstructionEquipments> list = new List<IConstructionEquipments>();
            Stonemasons stonemason = new Stonemasons(10, _countworker);
            for (int i = 0; i < _countcars; i++)
                list.Add(new ConstructionCrane());
            Building b = new Building(floor + 1, windows, 1, colors + 1, list, stonemason, number + 1);
            b.DearthOfMaterials += Show_Message;
            b.ReadyForRoofing += Show_Message2;
            buildings.Add(b);
            Thread myThread = new Thread(buildings[buildings.Count - 1].Build);
            myThread.Name = "Поток " + buildings.Count.ToString();
            threads.Add(myThread);
            myThread.Start();
        }

        public Bitmap Draw(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            Drawing.Draw(bitmap, buildings);
            return bitmap;
        }

        private static void Show_Message(object sender, AccountEventArgs e)
        {
            Building home = new Building();
            if (sender is Building)
                home = (Building)sender;
            home.ENd = true;
            home.DearthOfMaterials -= Show_Message;
            DialogResult resultofmaterials = MessageBox.Show(e.Message, "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            if (resultofmaterials == DialogResult.Yes)
                home.ENd = false;
        }

        private static void Show_Message2(object sender, AccountEventArgs e)
        {
            Building home = new Building();
            if (sender is Building)
                home = (Building)sender;
            home.ReadyForRoofing -= Show_Message2;
            DialogResult result = MessageBox.Show(e.Message, "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                           MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                home.Roof = true;
        }
    }
}
