namespace oop;
class Human
{
    public string name;
    public int phoneNum;
    public DateTime birthday;
}


class Program
{
   
    static void Main(string[] args)
    {
        Human[] humans = new Human[3];

        humans[0] = new Human();
        humans[1] = new Human();
        humans[2] = new Human();

        humans[0].name = "Natalia";
        humans[1].name = "Olga";
        humans[2].name = "Katerina";

        humans[0].phoneNum = 356536;
        humans[1].phoneNum = 756896;
        humans[2].phoneNum = 956532;

        humans[0].birthday = new DateTime(1996, 4, 17);
        humans[1].birthday = new DateTime(1990, 11, 17);
        humans[2].birthday = new DateTime(1992, 5, 16);

        int[][] info = new int[4][];
        info[0] = new int[3];
        info[1] = new int[3];
        info[2] = new int[3];
        info[3] = new int[3];
    

        string[] name = new string[3];
        int[] phoneNum = new int[3];
        DateTime[] birthday = new DateTime[3];
        name[0] = "Natalia";
        name[1] = "Olga";
        name[2] = "Katerina";
        phoneNum[0] = 356536;
        phoneNum[1] = 756896;
        phoneNum[2] = 956532;
        birthday[0] = new DateTime(1996, 4, 17);
        birthday[1] = new DateTime(1990, 11, 17);
        birthday[2] = new DateTime(1992, 5, 16);
        

    }
}

