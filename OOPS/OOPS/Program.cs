namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes and Objects");
            Car car = new Car { Make = "Toyota", Model = "Corolla" };
            car.Drive();
            Console.WriteLine("");

            Console.WriteLine("Encapsulation");
            BankAccount account = new BankAccount(1000);  // Initial balance: 1000
            account.Deposit(500);  // Deposits 500
            account.Withdraw(300); // Withdraws 300
            account.Withdraw(2000); // Attempt to withdraw more than balance

            // account.balance = 5000;  // ERROR: balance is private
            Console.WriteLine($"Final Balance: {account.Balance}"); // Access via property
            Console.WriteLine("");

            Console.WriteLine("Single Inheritance");
            Dog dog = new Dog();
            dog.Eat();  // Inherited method from Animal class
            dog.Bark(); // Method from Dog class
            Console.WriteLine("");

            Console.WriteLine("Multilevel Inheritance");
            Child obj = new Child();
            obj.GrandparentMethod(); // Inherited from Grandparent
            obj.ParentMethod();      // Inherited from Parent
            obj.ChildMethod();       // Defined in Child
            Console.WriteLine("");

            Console.WriteLine("Hierarchical Inheritance");
            DogHi dogHi = new DogHi();
            dogHi.EatHi();  // Inherited from Animal
            dogHi.BarkHi();

            Cat cat = new Cat();
            cat.EatHi();  // Inherited from Animal
            cat.Meow();
            Console.WriteLine("");

            //C# doesn't support Multiple Inheritance, but it allows multiple interface inheritance.
            Console.WriteLine("Multiple Inheritance");
            Human person = new Human();
            person.Walk();
            person.Run();
            Console.WriteLine("");

            Console.WriteLine("Compile-Time Polymorphism using Method Overloading");
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(2, 3));       // Output: 5
            Console.WriteLine(calc.Add(2, 3, 4));    // Output: 9
            Console.WriteLine(calc.Add(2.5, 3.5));   // Output: 6.0
            Console.WriteLine("");

            Console.WriteLine("Compile-Time Polymorphism using Operator Overloading");
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(1, 2);
            Complex result = c1 + c2; // Calls overloaded operator +
            result.Display(); // Output: 4 + 6i
            Console.WriteLine("");

            Console.WriteLine("Run-Time Polymorphism using Method Overriding");
            AnimalPoly animal = new DogPoly(); // Parent reference, child object
            animal.SpeakPoly(); // Output: Dog barks (Overridden method)
            Console.WriteLine("");

            Console.WriteLine("Run-Time Polymorphism using Interfaces");
            IShape shape1 = new Circle();
            IShape shape2 = new Rectangle();

            shape1.Draw(); // Output: Drawing a Circle.
            shape2.Draw(); // Output: Drawing a Rectangle.
            Console.WriteLine("");

            Console.WriteLine("Abstraction using Abstract Classes");
            AnimalAbs catAbs = new CatAbs();
            catAbs.SpeakAbs(); // Output: Cat meows.
            catAbs.EatAbs();   // Output: This animal eats food.
            Console.WriteLine("");

            Console.WriteLine("Abstraction using Interfaces");
            IAnimal dogAbs = new DogAbs();
            dogAbs.Speak(); // Output: Dog barks.
        }
    }
}
