using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;



namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private VehicleList vehicleList;
        
        public Form2()
        {
            InitializeComponent();
            vehicleList = new VehicleList();
            colorsSelect.Items.Clear();
            chosenCar.Items.Clear();
            Submit.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 mainGame = new Form1();
            mainGame.Show();
            Vehicle chosenVehicle = vehicleList[chosenCar.SelectedIndex];
            mainGame.SetMainVehicle(chosenVehicle);
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            colorsSelect.Items.Clear();
            if (carType.SelectedItem.ToString() == "Sport")
            {
                colorsSelect.Items.Add("Blue");
                colorsSelect.Items.Add("Yellow");
            } else if (carType.SelectedItem.ToString() == "Regular")
            {
                colorsSelect.Items.Add("White");
                colorsSelect.Items.Add("Red");
            }
           
        }

        private void VehicleType_motor_CheckedChanged(object sender, EventArgs e)
        {
            carType.Visible = false;
            colorsSelect.Visible = false;
            textcartype.Visible = false;
            textcarcolor.Visible = false;
            textmotorcolor.Visible = true;
            motorcolorbox.Visible = true;
            
            
        }
        private void VehicleType_car_CheckedChanged(object sender, EventArgs e)
        {
            carType.Visible = true;
            colorsSelect.Visible = true;
            textcartype.Visible = true;
            textcarcolor.Visible = true;
            motorcolorbox.Visible = false;
            textmotorcolor.Visible = false;
        }

        private void AddVehicle_Click(object sender, EventArgs e)
        {
            if(chosenCar.Items.IndexOf(vehicleName.Text) > -1)
            {
                
                errorProvider2.SetError(vehicleName, "Name is already taken.");
                return;
            }

            if (vehicleName.Text == "")
            {
                errorProvider1.SetError(vehicleName, "No name has been choosen");
            }
            if (textcarcolor.Text == "")
            {
                errorProvider1.SetError(colorsSelect, "No color has been choosen");
            }
            if (textcartype.Text == "")
            {
                errorProvider1.SetError(carType, "No car type has been choosen");
            }
            if (vehicleType_car.Checked)
            {
                if (carType.Text == "Regular")
                {
                  
                    if (colorsSelect.Text == "White")
                    {
                        Car car = new Car(vehicleName.Text, Color.white);
                        vehicleList.Add(car);
                    }
                    else if (colorsSelect.Text == "Red")
                    {
                        Car car = new Car(vehicleName.Text, Color.red);
                        vehicleList.Add(car);
                    }
                }

                else if (carType.Text == "Sport")
                {
                    if (colorsSelect.Text == "Blue")
                        vehicleList.Add(new SportCar(vehicleName.Text, 20, Color.blue));
                    else if (colorsSelect.Text == "Yellow")
                    {
                        vehicleList.Add(new SportCar(vehicleName.Text, 20, Color.yellow));
                    }
                }

            }
            else if (vehicleType_motor.Checked)
            {
                if (motorcolorbox.Text == "")
                {
                    errorProvider1.SetError(motorcolorbox, "No car type has been choosen");
                }
                if (motorcolorbox.Text == "Green")
                {
                    vehicleList.Add(new MotorCycle(vehicleName.Text, Color.green));

                }
                else if (motorcolorbox.Text == "Purple")
                {
                    vehicleList.Add(new MotorCycle(vehicleName.Text, Color.purple));
                }
            }

            chosenCar.Items.Clear();
            
            
            for (int i = 0; i < vehicleList.NextIndex; i++)
            {
                chosenCar.Items.Add(vehicleList[i].getName());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < vehicleList.NextIndex; i++)
            {
                if (chosenCar.SelectedItem.ToString() == vehicleList[i].getName())
                {
                    chosenCar.Items.Remove(vehicleList[i].getName());
                    vehicleList.Remove(vehicleList[i]);
                }
            }

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            
                IFormatter formatter = new BinaryFormatter(); 
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                { 
                    formatter.Serialize(stream, vehicleList);
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                vehicleList = (VehicleList)binaryFormatter.Deserialize(stream);
                chosenCar.Invalidate();
                chosenCar.Items.Clear();

                for (int i = 0; i < vehicleList.NextIndex; i++)
                {
                    chosenCar.Items.Add(vehicleList[i].getName());
                }

            }
        }

        private void chosenCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
        }
    }
}
