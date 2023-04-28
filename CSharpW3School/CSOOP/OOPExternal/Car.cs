using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExternal
{
    class Car : Vehicle
    {
        private string model;
        private string color;
        private int speed;

        // constructor no paramater
        public Car()
        {
            model = "Honda";
            color = "red";
            speed = 100;
            country = "Japan";
        }

        // constructor with paramater
        public Car(string model, string color, int speed, string country)
        {
            this.model = model;
            this.color = color; 
            this.speed = speed;
            this.country = country;
        }

        public void inforCar()
        {
            Console.WriteLine($"Model: {this.model} color: {this.color} speed: {this.speed} country: {this.country}");
        }
        
        // set & get
        public string Model
        { get; set; }
        public string Color
        { get; set; }
        public int Speed
        { get; set; }
        public string Country
        { get; set; }

    }
}

