namespace _06_10;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int? b = null;
        Random random = null;
        string example = "ercchvt";

        Person first = new Person("Ann", 39);
        Person2 second = new Person2("Kate", 12);
        Person third = first;
        Person2 fourth = second;
        Person h = new Person();
        Person fifth;
        Person2 sixth;
        Person seventh = default (Person);

        Person2 eighth = default(Person2);
        first.name = "Phild";
        second.name = "Kir";

        Console.WriteLine(first.name);
        Console.WriteLine(second.name);
        Console.WriteLine(third.name);
        Console.WriteLine(fourth.name);
    }
}
struct Person {
    public string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person()
    {
        name = "Bill";
        age = 90;
    }
}


class Person2
{
    public string name;
    int age;

    public Person2(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person2()
    {
        name = "Bill";
        age = 90;
    }
}


