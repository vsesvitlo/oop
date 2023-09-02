namespace _30_08;
class Persona
{
    public string name;
    public int count1;
    public int count2;

    public Persona(string name, int count1, int c)
    {
        this.name = name;
        this.count1 = count1;
        count2 = c;
    }


    public Persona(string name, int count1)
    {
        this.name = name;
        this.count1 = count1/2;
        count2 = count1/2;
    }
    public Persona(string name)
    {
        this.name = name;
        count1 = 0;
        count2 = 0;
    }
}


class Program
{
    static void Main(string[] args)
    {

        Persona human = new Persona("Kir");
        Console.WriteLine(human.count2);
    }
}

