using System;
using System.Linq;

namespace OOPExternal
{
    class Propgram
    {
        static void Main(string[] args)
        {
            /* Car myCar1 = new Car();
            Car myCar2 = new Car();

            myCar2.model = "Yamaha";
            myCar2.color = "grey";
            myCar2.speed = 200;
            
            Console.WriteLine(myCar1.model);
            Console.WriteLine(myCar1.color);
            Console.WriteLine(myCar1.speed);
            Console.WriteLine(myCar2.model);
            Console.WriteLine(myCar2.color);
            Console.WriteLine(myCar2.speed);

            myCar1.inforCar();
            myCar2.inforCar(); */

            // create object without constructor
            //Car myCar3 = new Car();
            //myCar3.inforCar();
            // create object with constructor
            //Car myCar4 = new Car("Suziki", "black", 150);
            //myCar4.inforCar();

            //set & get
            // set kiểu đầy đủ
            /* Car myCar5 = new Car();
            myCar5.Model = "Vinfast";
            myCar5.Color = "white";
            myCar5.Speed = 300;
            Console.WriteLine(myCar5.Model);
            Console.WriteLine(myCar5.Color);
            Console.WriteLine(myCar5.Speed); */
            // set kiểu nhanh gọn
            /* Car myCar5 = new Car() { Model = "BMW", Color = "yellow", Speed = 420, Country = "German"};
            Console.WriteLine(myCar5.Model);
            Console.WriteLine(myCar5.Color);
            Console.WriteLine(myCar5.Speed);
            Console.WriteLine(myCar5.Country); */

            // Inheritance
            //Car myCar6 = new Car();
            //myCar6.inforCar();
            //myCar6.action();

            // Polimorphism
            /* Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();
            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound(); */

            // Abstraction
            /* Apple myApple = new Apple();
            myApple.nameOfFruit();
            myApple.benefit(); */

            // Interface
            /* Pig myPig = new Pig();
            myPig.animalAction();
            myPig.animalAction2(); */

            // try cacth
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Loi roi !");
            }
        }
    }
}
