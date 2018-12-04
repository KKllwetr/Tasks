namespace Task_4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElementGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox_colours = new System.Windows.Forms.ComboBox();
            this.numericUpDown_cars = new System.Windows.Forms.NumericUpDown();
            this.label_cars = new System.Windows.Forms.Label();
            this.numericUpDown_worker = new System.Windows.Forms.NumericUpDown();
            this.label_worker = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.numericUpDown_windwos = new System.Windows.Forms.NumericUpDown();
            this.NumberOfHousecomboBox = new System.Windows.Forms.ComboBox();
            this.NumberOfFloorsComboBox = new System.Windows.Forms.ComboBox();
            this.label_windows = new System.Windows.Forms.Label();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            this.ElementGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_windwos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ElementGroupBox
            // 
            this.ElementGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ElementGroupBox.Controls.Add(this.comboBox_colours);
            this.ElementGroupBox.Controls.Add(this.numericUpDown_cars);
            this.ElementGroupBox.Controls.Add(this.label_cars);
            this.ElementGroupBox.Controls.Add(this.numericUpDown_worker);
            this.ElementGroupBox.Controls.Add(this.label_worker);
            this.ElementGroupBox.Controls.Add(this.button_add);
            this.ElementGroupBox.Controls.Add(this.numericUpDown_windwos);
            this.ElementGroupBox.Controls.Add(this.NumberOfHousecomboBox);
            this.ElementGroupBox.Controls.Add(this.NumberOfFloorsComboBox);
            this.ElementGroupBox.Controls.Add(this.label_windows);
            this.ElementGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ElementGroupBox.Location = new System.Drawing.Point(1062, 0);
            this.ElementGroupBox.Name = "ElementGroupBox";
            this.ElementGroupBox.Size = new System.Drawing.Size(255, 692);
            this.ElementGroupBox.TabIndex = 0;
            this.ElementGroupBox.TabStop = false;
            this.ElementGroupBox.Text = "Инструменты";
            // 
            // comboBox_colours
            // 
            this.comboBox_colours.FormattingEnabled = true;
            this.comboBox_colours.Items.AddRange(new object[] {
            "Красный",
            "Синий",
            "Серый",
            "Зелёный"});
            this.comboBox_colours.Location = new System.Drawing.Point(21, 63);
            this.comboBox_colours.Name = "comboBox_colours";
            this.comboBox_colours.Size = new System.Drawing.Size(171, 28);
            this.comboBox_colours.TabIndex = 11;
            this.comboBox_colours.Text = "Цвет дома ";
            // 
            // numericUpDown_cars
            // 
            this.numericUpDown_cars.Location = new System.Drawing.Point(141, 195);
            this.numericUpDown_cars.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_cars.Name = "numericUpDown_cars";
            this.numericUpDown_cars.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown_cars.TabIndex = 10;
            // 
            // label_cars
            // 
            this.label_cars.AutoSize = true;
            this.label_cars.Location = new System.Drawing.Point(6, 197);
            this.label_cars.Name = "label_cars";
            this.label_cars.Size = new System.Drawing.Size(125, 20);
            this.label_cars.TabIndex = 9;
            this.label_cars.Text = "Кол-во техники";
            // 
            // numericUpDown_worker
            // 
            this.numericUpDown_worker.Location = new System.Drawing.Point(141, 163);
            this.numericUpDown_worker.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_worker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_worker.Name = "numericUpDown_worker";
            this.numericUpDown_worker.Size = new System.Drawing.Size(50, 26);
            this.numericUpDown_worker.TabIndex = 8;
            this.numericUpDown_worker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_worker
            // 
            this.label_worker.AutoSize = true;
            this.label_worker.Location = new System.Drawing.Point(6, 165);
            this.label_worker.Name = "label_worker";
            this.label_worker.Size = new System.Drawing.Size(126, 20);
            this.label_worker.TabIndex = 7;
            this.label_worker.Text = "Кол-во рабочих";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(125, 231);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(104, 39);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Добавить ";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // numericUpDown_windwos
            // 
            this.numericUpDown_windwos.Location = new System.Drawing.Point(109, 131);
            this.numericUpDown_windwos.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_windwos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_windwos.Name = "numericUpDown_windwos";
            this.numericUpDown_windwos.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown_windwos.TabIndex = 5;
            this.numericUpDown_windwos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberOfHousecomboBox
            // 
            this.NumberOfHousecomboBox.FormattingEnabled = true;
            this.NumberOfHousecomboBox.Location = new System.Drawing.Point(20, 97);
            this.NumberOfHousecomboBox.Name = "NumberOfHousecomboBox";
            this.NumberOfHousecomboBox.Size = new System.Drawing.Size(171, 28);
            this.NumberOfHousecomboBox.TabIndex = 4;
            this.NumberOfHousecomboBox.Text = "Номер участка ";
            // 
            // NumberOfFloorsComboBox
            // 
            this.NumberOfFloorsComboBox.FormattingEnabled = true;
            this.NumberOfFloorsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NumberOfFloorsComboBox.Location = new System.Drawing.Point(20, 29);
            this.NumberOfFloorsComboBox.Name = "NumberOfFloorsComboBox";
            this.NumberOfFloorsComboBox.Size = new System.Drawing.Size(171, 28);
            this.NumberOfFloorsComboBox.TabIndex = 3;
            this.NumberOfFloorsComboBox.Text = "Кол-во этажей";
            // 
            // label_windows
            // 
            this.label_windows.AutoSize = true;
            this.label_windows.Location = new System.Drawing.Point(6, 133);
            this.label_windows.Name = "label_windows";
            this.label_windows.Size = new System.Drawing.Size(100, 20);
            this.label_windows.TabIndex = 0;
            this.label_windows.Text = "Кол-во окон";
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(1317, 692);
            this.MyPictureBox.TabIndex = 1;
            this.MyPictureBox.TabStop = false;
            this.MyPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPictureBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 692);
            this.Controls.Add(this.ElementGroupBox);
            this.Controls.Add(this.MyPictureBox);
            this.Name = "MainForm";
            this.Text = "Task 4";
            this.ElementGroupBox.ResumeLayout(false);
            this.ElementGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_windwos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ElementGroupBox;
        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.Label label_windows;
        private System.Windows.Forms.ComboBox NumberOfFloorsComboBox;
        private System.Windows.Forms.ComboBox NumberOfHousecomboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown_windwos;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.NumericUpDown numericUpDown_worker;
        private System.Windows.Forms.Label label_worker;
        private System.Windows.Forms.NumericUpDown numericUpDown_cars;
        private System.Windows.Forms.Label label_cars;
        private System.Windows.Forms.ComboBox comboBox_colours;
    }
}

