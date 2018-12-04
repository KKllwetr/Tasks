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
    public partial class MainForm : Form
    {
        Bitmap bitmap;
        IList<Building> buildings;
        List<Thread> threads = new List<Thread>();

        public MainForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(MyPictureBox.Width, MyPictureBox.Height);
            buildings = new List<Building>();
            NumberOfHousecomboBox.Items.AddRange(new object[] { "№ 1", "№ 2", "№ 3", "№ 4", "№ 5" });
            buildings = new List<Building>()
            {
               new Building (4, 2 , 1, 1, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),1),
               new Building (3, 2 , 1, 2, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),2),
               new Building (2, 2 , 1, 3, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),3),
               new Building (1, 2 , 1, 4, new List<IConstructionEquipments> (){new ConstructionCrane(), new ConstructionCrane()}, new Stonemasons(10, 5),4),
            };
            Paintt();
        }

        public void Paintt()
        {
            for (int i = 0; i < buildings.Count; i++)
            {
                buildings[i].DearthOfMaterials += Show_Message;
                buildings[i].ReadyForRoofing += Show_Message2;
                Thread myThread = new Thread(buildings[i].Build);
                myThread.Name = "Поток " + i.ToString();
                threads.Add ( myThread);
                myThread.Start();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (NumberOfHousecomboBox.SelectedIndex == -1 || NumberOfFloorsComboBox.SelectedIndex == -1
                || comboBox_colours.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите значение", "Ошибка");
                return;
            }
            foreach (var i in buildings)
                if (i.Number == NumberOfHousecomboBox.SelectedIndex + 1)
                {
                    MessageBox.Show("место занято", "Ошибка");
                    return;
                }
            IList<IConstructionEquipments> list = new List<IConstructionEquipments>();
            Stonemasons stonemason = new Stonemasons(10, (uint)numericUpDown_worker.Value);
            for (int i = 0; i < numericUpDown_cars.Value; i++)
                list.Add(new ConstructionCrane());
            Building b = new Building((uint)NumberOfFloorsComboBox.SelectedIndex + 1, (uint)numericUpDown_windwos.Value, 1,
                comboBox_colours.SelectedIndex + 1, list, stonemason, NumberOfHousecomboBox.SelectedIndex + 1);
            b.DearthOfMaterials += Show_Message;
            b.ReadyForRoofing += Show_Message2;
            buildings.Add(b);
            Thread myThread = new Thread(buildings[buildings.Count-1].Build);
            myThread.Name = "Поток " + buildings.Count.ToString();
            threads.Add (myThread);
            myThread.Start();
            NumberOfFloorsComboBox.Text = "Кол-во этажей";
            comboBox_colours.Text = "Цвет дома";
            NumberOfHousecomboBox.Text = "Номер участка";
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

        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            bitmap = new Bitmap(MyPictureBox.Width - ElementGroupBox.Width, MyPictureBox.Height);
            Drawing.Draw(bitmap, buildings);
            MyPictureBox.Image = bitmap;
            Invalidate();
        }
    }
}

