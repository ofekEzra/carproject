
namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.vehicleType_motor = new System.Windows.Forms.RadioButton();
            this.vehicleType_car = new System.Windows.Forms.RadioButton();
            this.vehicleName = new System.Windows.Forms.TextBox();
            this.textVtype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.carType = new System.Windows.Forms.ComboBox();
            this.colorsSelect = new System.Windows.Forms.ComboBox();
            this.textcarcolor = new System.Windows.Forms.Label();
            this.textcartype = new System.Windows.Forms.Label();
            this.textmotorcolor = new System.Windows.Forms.Label();
            this.motorcolorbox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddVehicle = new System.Windows.Forms.Button();
            this.chosenCar = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleType_motor
            // 
            this.vehicleType_motor.AutoSize = true;
            this.vehicleType_motor.BackColor = System.Drawing.Color.Gold;
            this.vehicleType_motor.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleType_motor.Location = new System.Drawing.Point(437, 54);
            this.vehicleType_motor.Name = "vehicleType_motor";
            this.vehicleType_motor.Size = new System.Drawing.Size(142, 25);
            this.vehicleType_motor.TabIndex = 18;
            this.vehicleType_motor.TabStop = true;
            this.vehicleType_motor.Text = "MotorCycle";
            this.vehicleType_motor.UseVisualStyleBackColor = false;
            this.vehicleType_motor.CheckedChanged += new System.EventHandler(this.VehicleType_motor_CheckedChanged);
            // 
            // vehicleType_car
            // 
            this.vehicleType_car.AutoSize = true;
            this.vehicleType_car.BackColor = System.Drawing.Color.Gold;
            this.vehicleType_car.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleType_car.Location = new System.Drawing.Point(166, 52);
            this.vehicleType_car.Name = "vehicleType_car";
            this.vehicleType_car.Size = new System.Drawing.Size(63, 25);
            this.vehicleType_car.TabIndex = 17;
            this.vehicleType_car.TabStop = true;
            this.vehicleType_car.Text = "Car";
            this.vehicleType_car.UseVisualStyleBackColor = false;
            this.vehicleType_car.CheckedChanged += new System.EventHandler(this.VehicleType_car_CheckedChanged);
            // 
            // vehicleName
            // 
            this.vehicleName.Location = new System.Drawing.Point(166, 208);
            this.vehicleName.Name = "vehicleName";
            this.vehicleName.Size = new System.Drawing.Size(125, 27);
            this.vehicleName.TabIndex = 19;
            // 
            // textVtype
            // 
            this.textVtype.AutoSize = true;
            this.textVtype.BackColor = System.Drawing.Color.White;
            this.textVtype.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textVtype.Location = new System.Drawing.Point(12, 54);
            this.textVtype.Name = "textVtype";
            this.textVtype.Size = new System.Drawing.Size(122, 21);
            this.textVtype.TabIndex = 20;
            this.textVtype.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Vehicle Name";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Gold;
            this.Submit.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Submit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Submit.Location = new System.Drawing.Point(852, 342);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(133, 67);
            this.Submit.TabIndex = 22;
            this.Submit.Text = "Start Game";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(83, 321);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(0, 20);
            this.results.TabIndex = 23;
            // 
            // carType
            // 
            this.carType.FormattingEnabled = true;
            this.carType.Items.AddRange(new object[] {
            "Sport",
            "Regular"});
            this.carType.Location = new System.Drawing.Point(166, 111);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(115, 28);
            this.carType.TabIndex = 24;
            this.carType.SelectedValueChanged += new System.EventHandler(this.ComboBox1_SelectedValueChanged);
            // 
            // colorsSelect
            // 
            this.colorsSelect.FormattingEnabled = true;
            this.colorsSelect.Items.AddRange(new object[] {
            "Sport",
            "Regular"});
            this.colorsSelect.Location = new System.Drawing.Point(166, 159);
            this.colorsSelect.Name = "colorsSelect";
            this.colorsSelect.Size = new System.Drawing.Size(115, 28);
            this.colorsSelect.TabIndex = 25;
            // 
            // textcarcolor
            // 
            this.textcarcolor.AutoSize = true;
            this.textcarcolor.BackColor = System.Drawing.Color.Cornsilk;
            this.textcarcolor.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcarcolor.Location = new System.Drawing.Point(12, 160);
            this.textcarcolor.Name = "textcarcolor";
            this.textcarcolor.Size = new System.Drawing.Size(69, 23);
            this.textcarcolor.TabIndex = 26;
            this.textcarcolor.Text = "Color";
            // 
            // textcartype
            // 
            this.textcartype.AutoSize = true;
            this.textcartype.BackColor = System.Drawing.Color.White;
            this.textcartype.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcartype.Location = new System.Drawing.Point(12, 112);
            this.textcartype.Name = "textcartype";
            this.textcartype.Size = new System.Drawing.Size(87, 21);
            this.textcartype.TabIndex = 27;
            this.textcartype.Text = "Car Type";
            // 
            // textmotorcolor
            // 
            this.textmotorcolor.AutoSize = true;
            this.textmotorcolor.BackColor = System.Drawing.Color.White;
            this.textmotorcolor.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textmotorcolor.Location = new System.Drawing.Point(351, 111);
            this.textmotorcolor.Name = "textmotorcolor";
            this.textmotorcolor.Size = new System.Drawing.Size(69, 23);
            this.textmotorcolor.TabIndex = 28;
            this.textmotorcolor.Text = "Color";
            // 
            // motorcolorbox
            // 
            this.motorcolorbox.FormattingEnabled = true;
            this.motorcolorbox.Items.AddRange(new object[] {
            "Green",
            "Purple"});
            this.motorcolorbox.Location = new System.Drawing.Point(437, 106);
            this.motorcolorbox.Name = "motorcolorbox";
            this.motorcolorbox.Size = new System.Drawing.Size(115, 28);
            this.motorcolorbox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(891, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddVehicle
            // 
            this.AddVehicle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddVehicle.Location = new System.Drawing.Point(12, 298);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(175, 29);
            this.AddVehicle.TabIndex = 31;
            this.AddVehicle.Text = "Add Vehicle";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.AddVehicle_Click);
            // 
            // chosenCar
            // 
            this.chosenCar.FormattingEnabled = true;
            this.chosenCar.Items.AddRange(new object[] {
            "Sport",
            "Regular"});
            this.chosenCar.Location = new System.Drawing.Point(196, 431);
            this.chosenCar.Name = "chosenCar";
            this.chosenCar.Size = new System.Drawing.Size(115, 28);
            this.chosenCar.TabIndex = 32;
            this.chosenCar.SelectedIndexChanged += new System.EventHandler(this.chosenCar_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(891, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 34;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Lavender;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 429);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 29);
            this.richTextBox1.TabIndex = 36;
            this.richTextBox1.Text = "Choose Car";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 29);
            this.button3.TabIndex = 37;
            this.button3.Text = "Remove Vehicle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 491);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chosenCar);
            this.Controls.Add(this.AddVehicle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motorcolorbox);
            this.Controls.Add(this.textmotorcolor);
            this.Controls.Add(this.textcartype);
            this.Controls.Add(this.textcarcolor);
            this.Controls.Add(this.colorsSelect);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.results);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textVtype);
            this.Controls.Add(this.vehicleName);
            this.Controls.Add(this.vehicleType_motor);
            this.Controls.Add(this.vehicleType_car);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton vehicleType_motor;
        private System.Windows.Forms.RadioButton vehicleType_car;
        private System.Windows.Forms.TextBox vehicleName;
        private System.Windows.Forms.Label textVtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.ComboBox colorsSelect;
        private System.Windows.Forms.Label textcarcolor;
        private System.Windows.Forms.Label textcartype;
        private System.Windows.Forms.Label textmotorcolor;
        private System.Windows.Forms.ComboBox motorcolorbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddVehicle;
        private System.Windows.Forms.ComboBox chosenCar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
    }
}