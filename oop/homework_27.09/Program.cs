/*
 using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text Adventure Game!");
        Console.WriteLine("You are in a dark forest. You have two paths ahead.");

        Console.WriteLine("1. Take the left path.");
        Console.WriteLine("2. Take the right path.");

        Console.Write("Enter your choice (1 or 2): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("You chose the left path.");
            Console.WriteLine("You find a treasure chest!");

            Console.WriteLine("1. Open the chest.");
            Console.WriteLine("2. Leave it alone.");

            Console.Write("Enter your choice (1 or 2): ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You open the chest and find a pile of gold. Congratulations, you win!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("You decide not to open the chest and continue your adventure.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over!");
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("You chose the right path.");
            Console.WriteLine("You encounter a fierce dragon!");

            Console.WriteLine("1. Fight the dragon.");
            Console.WriteLine("2. Run away.");

            Console.Write("Enter your choice (1 or 2): ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You bravely fight the dragon, but it's too powerful. Game over!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("You wisely run away from the dragon and escape the forest.");
                Console.WriteLine("Congratulations, you survived!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Game over!");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Game over!");
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadKey();
    }
}


*/
/*using System;

class Address
{
    public string Street;
    public string City;
    public string State;
    public string ZipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}

class Person
{
    public string Name;
    public Address HomeAddress;

    public Person(string name, Address homeAddress)
    {
        Name = name;
        HomeAddress = homeAddress;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {HomeAddress}");
    }
}

class Program
{
    static void Main()
    {
        Address johnAddress = new Address("123 Main St", "Anytown", "CA", "12345");
        Person john = new Person("John Doe", johnAddress);

        Address janeAddress = new Address("456 Elm St", "Otherville", "NY", "54321");
        Person jane = new Person("Jane Smith", janeAddress);

        Console.WriteLine("Person 1:");
        john.DisplayInfo();

        Console.WriteLine("\nPerson 2:");
        jane.DisplayInfo();

        Console.ReadKey();
    }
}
*/


/*using System;
using System.Collections.Generic;

class Product
{
    public int ProductId;
    public string Name;
    public decimal Price;

    public Product(int productId, string name, decimal price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }
}

class ShoppingCart
{
    private List<Product> items = new List<Product>();

    public void AddToCart(Product product)
    {
        items.Add(product);
    }

    public void RemoveFromCart(Product product)
    {
        items.Remove(product);
    }

    public void ViewCart()
    {
        Console.WriteLine("Shopping Cart Contents:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} - ${item.Price}");
        }
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price;
        }
        return total;
    }
}

class Order
{
    public int OrderId;
    public ShoppingCart Cart;
    public DateTime OrderDate;

    public Order(int orderId, ShoppingCart cart)
    {
        OrderId = orderId;
        Cart = cart;
        OrderDate = DateTime.Now;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the E-Commerce System");

        Product product1 = new Product(1, "Laptop", 799.99m);
        Product product2 = new Product(2, "Smartphone", 499.99m);
        Product product3 = new Product(3, "Headphones", 99.99m);

        ShoppingCart cart = new ShoppingCart();
        cart.AddToCart(product1);
        cart.AddToCart(product2);
        cart.AddToCart(product3);

        Console.WriteLine("Your Shopping Cart:");
        cart.ViewCart();

        decimal total = cart.CalculateTotal();
        Console.WriteLine($"Total: ${total}");

        Order order = new Order(1, cart);
        Console.WriteLine($"Order Placed. Order ID: {order.OrderId}, Order Date: {order.OrderDate}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
using System;

namespace ClassObject {

  class Employee {
    public string name;

    public void work(string work) {
      Console.WriteLine("Work: " + work);
      
    }
  }

  class EmployeeDrive {
    static void Main(string[] args) {

      // create Employee object 
      Employee e1= new Employee();

      Console.WriteLine("Employee 1");

      // set name of the Employee 
      e1.name="Gloria";
      Console.WriteLine("Name: " + e1.name);

      //call method of the Employee
      e1.work("Coding"); 

      Console.ReadLine();
     
    }
  }
}

*//*По практиці: 
1. Створити метод який бере три числа і по кругу їх змінює. Повертає void. Перше значення в другу змінну,
Друге значення в третю змінну, Третеє значення в першу змінну +
2. Створити метод який бере 2 значення і оба робить рівними максимальному. +
3. Створити клас який містить список int доходів за місяць і список int витарат за місяць.
Реалізувати можливість додати доходи і витрати. Реалізувати метод який підраховує загальний баланс за місяць.*/
namespace homework_27._09;

/*class Program
{
    public class Circle
    {
        public int a;
        public int b;
        public int c;

        public Circle(int а_first, int b_second, int c_third)
        {
            a = а_first;
            b = b_second;
            c = c_third;
        }

    public void ReturnCircle(ref int first, ref int second, ref int third)
        {
            int zero = first;
            first = second;
            second = third;
            third = zero;
        }

    }
    static void Main(string[] args)
    {
        Circle Example = new Circle(6, 7, 8);
        int one = 6;
        int two = 7;
        int three = 8;
        Example.ReturnCircle(ref one, ref two, ref three);
        Console.WriteLine(one);
        Console.WriteLine(two);
        Console.WriteLine(three);
    }
}*/

class Program
{
    public class Numbers
    {
        public int a;
        public int b;

        public Numbers(int one, int two)
        {
            a = one;
            b = two;
        }

        public void Maximaze(ref int first, ref int second)
        {
            int doubleForFirst = first;
            //int doubleForSecond = second;
            if (second > first)
            {
                a = second;
            }
            if (first > second)
            {
                b = first;
            }    
        }
}
        static void Main(string[] args)
        {
            Numbers ForChange = new Numbers(44, 8);
        //ForChange.Maximaze(4, 8);
        int one = 44;
        int two = 8;
       
        ForChange.Maximaze(ref one, ref two);
            Console.WriteLine(ForChange.a);
            Console.WriteLine(ForChange.b);
        }
    }

/*
class Program
{
    public class Incomes
    {
        public int wage;
        public int additionalIncomes;

        public Incomes(int wage, int additionalIncomes)
        {
            this.wage = wage;
            this.additionalIncomes = additionalIncomes;
        }
        public Incomes()
        {
            wage = 0;
            additionalIncomes = 0;
        }
    }
    public class Expences
    {
        public int rent;
        public int food;
        public int sport;
        public int selfDevelopment;
        public int childrenExpences;
        public int pets;
        public int additionalExpences;

        public Expences(int rent, int food, int sport, int selfDevelopment, int childrenExpences,
            int pets, int additionalExpences)
        {
            this.rent = rent;
            this.food = food;
            this.sport = sport;
            this.selfDevelopment = selfDevelopment;
            this.childrenExpences = childrenExpences;
            this.pets = pets;
            this.additionalExpences = additionalExpences;
        }
        public Expences()
        {
            rent = 0;
            food = 0;
            sport = 0;
            selfDevelopment = 0;
            childrenExpences = 0;
            pets = 0;
            additionalExpences = 0;
        }
        public int Budget(int )
        {

        }
    }
        static void Main(string[] args)
        {

        }

    }
*/
/*class Program
{   
    public class Incomes
    {
        public int wage;
        public int additionalIncomes;

        public Incomes(int wage, int additionalIncomes)
        {
            this.wage = wage;
            this.additionalIncomes = additionalIncomes;
        }
        public Incomes()
        {
            wage = 0;
            additionalIncomes = 0;
        }
    }
    public class Expences
    {
        public int rent;
        public int food;
        public int sport;
        public int selfDevelopment;
        public int childrenExpences;
        public int pets;
        public int additionalExpences;

        public Expences(int rent, int food, int sport, int selfDevelopment, int childrenExpences,
            int pets, int additionalExpences)
        {
            this.rent = rent;
            this.food = food;
            this.sport = sport;
            this.selfDevelopment = selfDevelopment;
            this.childrenExpences = childrenExpences;
            this.pets = pets;
            this.additionalExpences = additionalExpences;
        }
        public Expences()
        {
            rent = 0;
            food = 0;
            sport = 0;
            selfDevelopment = 0;
            childrenExpences = 0;
            pets = 0;
            additionalExpences = 0;
        }
        
        class Budget
        {
            private List<Incomes> incomes = new List<Incomes> ();

            public void AddToIncomes(Incomes plus)
            {
                incomes.Add(plus);
            }
            private List<Expences> expences = new List<Expences>();

            public void AddToExpences(Expences plus)
            {
                expences.Add(plus);
            }
           

                public int Revenue()
                {
                    int totalIncomes = 0;
                    int totalExpences = 0;
                    int total;
                    foreach (var item in incomes)
                    {
                        totalIncomes += item.wage + item.additionalIncomes;
                    }
                    foreach (var item in expences)
                    {
                        totalExpences += item.rent + item.sport + item.pets + item.selfDevelopment + item.food +
                        item.additionalExpences + item.childrenExpences;
                    }
                    total = totalIncomes - totalExpences;
                    return total;
                }
            }
        }
    
}
    static void Main(string[] args)
    {

    }

}
*/