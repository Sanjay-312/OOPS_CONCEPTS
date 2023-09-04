namespace OOPS_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person.learningCsharp();

            //Inheritance
            //BabyDog dogbaby = new BabyDog();
            //Dog dog = new Dog();

            //dogbaby.bark();
            //dog.bark();
            //Console.WriteLine(dog.name);
            //Console.WriteLine(dogbaby.name);


            //method overloading
             //Calculation add = new Calculation();
             //add.addition(5, 6);
             //add.addition(7, 8, 9);
             //add.addition(8, 10, 11);

            //method overriding

            //Beast beast = new Beast();
            //Cat cat = new Cat();
            //Pig pig = new Pig();

            //beast.makeSound();
            //cat.makeSound();
            //pig.makeSound();


            //Bank sbi = new Bank();
            //sbi.accountNumber = 34419335497;
            //sbi.name = "sanjeeva";
            //sbi.balance = 5000;
            //sbi.getBalance();
            //sbi.deposit();
            //sbi.withdraw();

            //Laptop dell = new Laptop();
            //dell.setModel("inspiron");
            //Console.WriteLine(dell.getModel());

            //Mobile oppo = new Mobile();
            //oppo.price = 10000;
            //Console.WriteLine(oppo.price);


            //abstract classes and methods
            Shape shape;
            shape = new Rectangle();
            shape.draw();
            shape = new Square();
            shape.draw();

            //interfaces
            Car car1;
            car1 = new Audi();
            car1.maxSpeed();
            car1= new Benz();
            car1.maxSpeed();



        }
    }
}