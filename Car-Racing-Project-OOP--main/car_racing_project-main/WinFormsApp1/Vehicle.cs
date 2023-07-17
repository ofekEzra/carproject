
using static System.Console;
namespace WinFormsApp1
{
    using System;
    using System.Collections;

    public enum VehicleType
    {
        Motorcycle,
        Car,
        SportCar
    }

    public enum Color
    {
        red,
        white,
        yellow,
        blue,
        green,
        purple
    }

    [Serializable]
    public abstract class Vehicle
    {
        protected string _name;
        protected int _speed;
        protected VehicleType _vecType;
        protected Color _color;
        public string getName()
        {
            return _name;
        }

        public VehicleType getVecType()
        {
            return _vecType;
        }
        public int getSpeed()
        {
            return _speed;
        }
        public Color getColor()
        {
            return _color;
        }

    }

    [Serializable]
    public class Car : Vehicle
    {
        public Car(string name, Color color)
        {
            _name = name;
            _speed = 10;
            _vecType = VehicleType.Car;
            _color = color;
        }
    }

    [Serializable]
    public class SportCar : Car
    {
        public SportCar(string name, int speed, Color color) : base(name, color)
        {
            _name = name;
            _speed = 22;
            _vecType = VehicleType.SportCar;
            _color = color;
        }

    }
    [Serializable]
    public class RegularCar : Car
    {
        public RegularCar(string name, Color color) : base(name, color)
        {
            _name = name;
            _speed = 10;
            _vecType = VehicleType.SportCar;
            _color = color;

        }

    }

    [Serializable]
    public class MotorCycle : Vehicle
    {
        public MotorCycle(string name, Color color)
        {
            _name = name;
            _speed = 15;
            _vecType = VehicleType.Motorcycle;
            _color = color;
        }
    }
  
    [Serializable]
    public class VehicleList
    {
        protected SortedList vehicleList;

        public VehicleList()
        {
            vehicleList = new SortedList();
        }
        public int NextIndex
        {
            get
            {
                return vehicleList.Count;
            }

        }

        public void Add(Vehicle vehicle)
        {
            vehicleList.Add(vehicle.getName(), vehicle);
        }
        public void Remove(Vehicle vehicle)
        {
            vehicleList.Remove(vehicle.getName());
        }

        public Vehicle this[int index]
        {
            get
            {
                if (index >= vehicleList.Count)
                    return (Vehicle)null;
                
                return (Vehicle)vehicleList.GetByIndex(index);
            }
            set
            {
                if (index <= vehicleList.Count)
                    vehicleList[index] = value; //!!!		
            }
        }
    }

}
