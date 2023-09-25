namespace _22._09;

class Program
{
    public class Human
    {
        public string name;
        public int age;

        public Human(string firstName, int age)
        {
            name = firstName;
            this.age = age;
        }
       public string ReturnSome()
        {
            return name;
        }
        public int ReturnSomeAge()
        {
            return age;
        }

       
    }
    static void Main(string[] args)
    {
        List<int> intsList = new List<int>();
        intsList.Add(0);
        intsList.AddRange(new int[] { 0, 3, 9, 6 });


        LinkedList<int> intsListLink = new LinkedList<int>();
        intsListLink.AddLast(0);
        intsListLink.Concat(new int[] { 0, 3, 9, 6 });
        Human men = new Human("Karl", 45);
        Human women = new Human("Ann", 25);
        Console.WriteLine(men.name);
        Console.WriteLine(men.age);
        string result = men.ReturnSome();
        string result1 = women.ReturnSome();
    }
    


}

