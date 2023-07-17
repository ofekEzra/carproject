using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            whiteCar.Visible = false;
            BlueCar.Visible = false;
            greenMotor.Visible = false;
            purpleMotor.Visible = false;
            yellowCar.Visible = false;
            redCar.Visible = false;
        }

        protected Vehicle _mainVehicle;
        int gameSpeed = 0;
        public void SetMainVehicle(Vehicle vehicle)
        {
            _mainVehicle = vehicle;
            switch (_mainVehicle.getVecType())
            {
                case VehicleType.Car:
                    if (_mainVehicle.getColor() == Color.white)
                    {
                        whiteCar.Visible = true;
                    }
                    else if (_mainVehicle.getColor() == Color.red)
                    {
                        redCar.Visible = true;
                    }
                    break;
                case VehicleType.Motorcycle:
                    if (_mainVehicle.getColor() == Color.green)
                    {
                        greenMotor.Visible = true;
                    }
                    else if (_mainVehicle.getColor() == Color.purple)
                    {
                        purpleMotor.Visible = true;
                    }
                    break;
                case VehicleType.SportCar:
                    if (_mainVehicle.getColor() == Color.blue)
                    {
                        BlueCar.Visible = true;
                    }
                    else if (_mainVehicle.getColor() == Color.yellow)
                    {
                        yellowCar.Visible = true;
                    }
                    break;
            }
            
        }
        
        void MoveLine(int speed)
        {
            if (Line4.Top >= 600)
            {
                Line4.Top = 0;
            }
            else
            {
                Line4.Top += speed;
            }
            if (Line3.Top >= 600)
            {
                Line3.Top = 0;
            }
            else
            {
                Line3.Top += speed;
            }
            if (Line1.Top >= 600)
            {
                Line1.Top = 0;
            }
            else
            {
                Line1.Top += speed;
            }
            if (Line2.Top >= 600)
            {
                Line2.Top = 0;
            }
            else
            {
                Line2.Top += speed;
            }

        }

        Random r = new Random();
        int x;
        int y;
        int collectedCoins = 0;

        void Enemy(int speed)
        {
            if (BOM1.Top >= 600)
            {
                x = r.Next(70, 370);
                BOM1.Location = new Point(x, 0);
                
            }
            else
            {
                BOM1.Top += speed;
            }
            if (BOM2.Top >= 600)
            {
                x = r.Next(480, 809);
                BOM2.Location = new Point(x, 0);
               
            }
            else
            {
                BOM2.Top += speed;
            }
        }
        int Strikes = 0;
       
        void GameOver()
        {
            if (_mainVehicle.getColor() == Color.white)
            {
                if (whiteCar.Bounds.IntersectsWith(BOM1.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(70, 370);
                    BOM1.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        
                    }
                    

                }
                if (whiteCar.Bounds.IntersectsWith(BOM2.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(480, 809);
                    BOM2.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                       
                    }
                    
                }
            }

            else if (_mainVehicle.getColor() == Color.red)
            {
                if (redCar.Bounds.IntersectsWith(BOM1.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(70, 370);
                    BOM1.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        
                    }
                    
                }
                if (redCar.Bounds.IntersectsWith(BOM2.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(480, 809);
                    BOM2.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                       
                    }
                    
                }
            }

            else if (_mainVehicle.getColor() == Color.blue)
            {
                if (BlueCar.Bounds.IntersectsWith(BOM1.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(70, 370);
                    BOM1.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        
                    }
                    
                }
                if (BlueCar.Bounds.IntersectsWith(BOM2.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(480, 809);
                    BOM2.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                       
                    }
                   
                }
            }

            else if (_mainVehicle.getColor() == Color.yellow)
            {
                if (yellowCar.Bounds.IntersectsWith(BOM1.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(70, 370);
                    BOM1.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        
                    }
                    
                }
                if (yellowCar.Bounds.IntersectsWith(BOM2.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(480, 809);
                    BOM2.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                       
                    }
                    
                }
            }

            else if (_mainVehicle.getColor() == Color.green)
            {
                if (greenMotor.Bounds.IntersectsWith(BOM1.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(70, 370);
                    BOM1.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        
                    }
                    
                }
                if (greenMotor.Bounds.IntersectsWith(BOM2.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(480, 809);
                    BOM2.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        
                    }
                    
                }
                
            }

            else if (_mainVehicle.getColor() == Color.purple)
            {
                if (purpleMotor.Bounds.IntersectsWith(BOM1.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(70, 370);
                    BOM1.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                    }
                }
                if (purpleMotor.Bounds.IntersectsWith(BOM2.Bounds))
                {
                    Strikes++;
                    label2.Text = "strikes=" + Strikes.ToString();
                    x = r.Next(480, 809);
                    BOM2.Location = new Point(x, 0);
                    if (Strikes >= 3)
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                    }
                }
            }
        }
        void Coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(70, 210);
                coin1.Location = new Point(x, 0);
                
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(290, 480);
                coin2.Location = new Point(x, 0);
                
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(620, 780);
                coin3.Location = new Point(x, 0);
                
            }
            else
            {
                coin3.Top += speed;
            }
        }
        void Coinscolletion()
        {
            if (_mainVehicle.getColor() == Color.white)
            {
                if (whiteCar.Bounds.IntersectsWith(coin1.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    x = r.Next(200, 809);
                    y = r.Next(100, 370);
                    coin1.Location = new Point(x, 0);
                }
                if (whiteCar.Bounds.IntersectsWith(coin2.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin2.Location = new Point(x, 0);
                }
                if (whiteCar.Bounds.IntersectsWith(coin3.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin3.Location = new Point(x, 0);
                }
                
            }


            else if (_mainVehicle.getColor() == Color.red)
            {
                if (redCar.Bounds.IntersectsWith(coin1.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    x = r.Next(90, 809);
                    y = r.Next(100, 370);
                    coin1.Location = new Point(x, 0);
                }
                if (redCar.Bounds.IntersectsWith(coin2.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin2.Location = new Point(x, 0);
                }
                if (redCar.Bounds.IntersectsWith(coin3.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin3.Location = new Point(x, 0);
                }
                
            }

            else if (_mainVehicle.getColor() == Color.blue)
            {
                if (BlueCar.Bounds.IntersectsWith(coin1.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    x = r.Next(200, 809);
                    y = r.Next(100, 370);
                    coin1.Location = new Point(x, 0);
                }
                if (BlueCar.Bounds.IntersectsWith(coin2.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin2.Location = new Point(x, 0);
                }
                if (BlueCar.Bounds.IntersectsWith(coin3.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin3.Location = new Point(x, 0);
                }
               
            }

            else if (_mainVehicle.getColor() == Color.yellow)
            {
                if (yellowCar.Bounds.IntersectsWith(coin1.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    x = r.Next(200, 809);
                    y = r.Next(100, 370);
                    coin1.Location = new Point(x, 0);
                }
                if (yellowCar.Bounds.IntersectsWith(coin2.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin2.Location = new Point(x, 0);
                }
                if (yellowCar.Bounds.IntersectsWith(coin3.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin3.Location = new Point(x, 0);
                }
               
            }

            else if (_mainVehicle.getColor() == Color.green)
            {
                if (greenMotor.Bounds.IntersectsWith(coin1.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    x = r.Next(200, 809);
                    y = r.Next(100, 370);
                    coin1.Location = new Point(x, 0);
                }
                if (greenMotor.Bounds.IntersectsWith(coin2.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin2.Location = new Point(x, 0);
                }
                if (greenMotor.Bounds.IntersectsWith(coin3.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin3.Location = new Point(x, 0);
                }
               
            }
            else if (_mainVehicle.getColor() == Color.purple)
            {
                if (purpleMotor.Bounds.IntersectsWith(coin1.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    x = r.Next(200, 809);
                    y = r.Next(100, 370);
                    coin1.Location = new Point(x, 0);
                }
                if (purpleMotor.Bounds.IntersectsWith(coin2.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin2.Location = new Point(x, 0);
                }
                if (purpleMotor.Bounds.IntersectsWith(coin3.Bounds))
                {
                    collectedCoins++;
                    label1.Text = "coins=" + collectedCoins.ToString();
                    coin3.Location = new Point(x, 0);
                }
               
            }
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_mainVehicle.getColor() == Color.white)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (whiteCar.Left > 70)
                        whiteCar.Left += -_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (whiteCar.Left < 770)
                        whiteCar.Left += _mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < _mainVehicle.getSpeed())
                    {
                        gameSpeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }

            else if (_mainVehicle.getColor() == Color.red)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (redCar.Left > 70)
                        redCar.Left += -_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (redCar.Left < 770)
                        redCar.Left += _mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < _mainVehicle.getSpeed())
                    {
                        gameSpeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }

            else if (_mainVehicle.getColor() == Color.blue)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (BlueCar.Left > 70)
                        BlueCar.Left += -_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (BlueCar.Left < 770)
                        BlueCar.Left += _mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < _mainVehicle.getSpeed())
                    {
                        gameSpeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }

            else if (_mainVehicle.getColor() == Color.yellow)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (yellowCar.Left > 70)
                        yellowCar.Left += -_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (yellowCar.Left < 770)
                        yellowCar.Left +=_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < _mainVehicle.getSpeed())
                    {
                        gameSpeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }

            else if (_mainVehicle.getColor() == Color.green)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (greenMotor.Left > 70)
                        greenMotor.Left += -_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (greenMotor.Left < 770)
                        greenMotor.Left += _mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < _mainVehicle.getSpeed())
                    {
                        gameSpeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }

            else if (_mainVehicle.getColor() == Color.purple)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (purpleMotor.Left > 70)
                        purpleMotor.Left += -_mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (purpleMotor.Left < 770)
                        purpleMotor.Left += _mainVehicle.getSpeed();
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < _mainVehicle.getSpeed())
                    {
                        gameSpeed++;
                    }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }
        }

        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gameSpeed);
            Coins(gameSpeed);
            Coinscolletion();
            Enemy(gameSpeed);
            GameOver();
          
        }
        
    }
}

