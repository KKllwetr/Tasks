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
        World w = new World();
        
        public MainForm()
        {
            InitializeComponent();
            NumberOfHousecomboBox.Items.AddRange(new object[] { "№ 1", "№ 2", "№ 3", "№ 4", "№ 5" });
            w.Start(MyPictureBox.Width - ElementGroupBox.Width, MyPictureBox.Height);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            w.Add((uint)numericUpDown_worker.Value, (uint)numericUpDown_cars.Value, (uint)NumberOfFloorsComboBox.SelectedIndex,
                (uint)numericUpDown_windwos.Value, comboBox_colours.SelectedIndex, NumberOfHousecomboBox.SelectedIndex);
            NumberOfFloorsComboBox.Text = "Кол-во этажей";
            comboBox_colours.Text = "Цвет дома";
            NumberOfHousecomboBox.Text = "Номер участка";
        }

        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            MyPictureBox.Image = w.Draw(MyPictureBox.Width - ElementGroupBox.Width, MyPictureBox.Height);
            Invalidate();
        }
    }
}

