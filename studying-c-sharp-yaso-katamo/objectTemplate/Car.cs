using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_yaso_katamo.objectTemplate
{
    public class Car
    {
        public string name = "Mazda";
        public string color = "black";
        public int waight = 100;
        public bool automatic = true;

        public void ChangeName(string carName)
        {
            name = carName;

        }
        public void ChangeColor(string carColor) 
        {
            color = carColor;
        }

        public void ToggleBoolProperty()
        {
            automatic = !automatic;
        }


    }
    public class UseCar
    {
        public static void Demo()
        {
            
            Car car = new Car();
            Console.WriteLine($"type of car: {car.name} \n type of color: {car.color} \n size of waight: {car.waight} \n type of machine: {car.automatic} \n");

            //שינויי ראשון
            car.name = "hyundai i30 premume";
            car.color = "white";
            car.waight = 50;
            car.automatic = true;

            Console.WriteLine($"type of car: {car.name} \n type of color: {car.color} \n size of waight: {car.waight} \n type of machine: {car.automatic} \n");


            car.ChangeName("mazerti");
            car.ChangeColor("red");
            car.ToggleBoolProperty();

            Console.WriteLine($"type of car: {car.name} \n type of color: {car.color} \n size of waight: {car.waight} \n type of machine: {car.automatic} \n");



            Garge garge = new Garge(20);
            for (int i=0; i<garge.cars.Length; i++)
            {
                Console.WriteLine($"type of car: {garge.cars[i].name}\n type of color: {garge.cars[i].color}\n size of waight: {garge.cars[i].waight}\n type of machine: {garge.cars[i].automatic}\n");

            }


        }

    }
    class Garge
    {
        public Car[] cars = new Car[3];
        public int idCar;
        //בנאיי
        public Garge(int idCar)
        {
            this.idCar = idCar;
            cars[0] = new Car();

            cars[1] = new Car();
            cars[1].name = "toyota";
            cars[1].color = "gray";
            cars[1].waight = 60;
            cars[1].automatic = true;

            cars[2] = new Car();
            cars[2].name = "suzuki";
            cars[2].name = "blue";
            cars[2].waight = 45;
            cars[2].automatic = true;
            cars[2].ToggleBoolProperty();



        }
    }

}
