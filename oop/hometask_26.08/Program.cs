//1.Створити 6 дат народження. Знайти середнє, визначити хто молодший за середнє. 
//2. Є набір чисел {1,5,7,9,12, 15,18, 25}. Із цього масиву створити новий масив
//чисел де будуть тільки ті числа які діляться націло на п'ять. +
//3. Згенерувати рандомний набір на 20 елементів від 1 до 100. 
//Знайти середнє арифметичне. І виписати в окремий масив всі числа і більші за середнє арифметичне і парні.
/*class Human
{
    public DateTime birthday;
}
class Program
{

    static void Main(string[] args)
    {
        Human[] humans = new Human[6];

        humans[0] = new Human();
        humans[1] = new Human();
        humans[2] = new Human();
        humans[3] = new Human();
        humans[4] = new Human();
        humans[5] = new Human();

        humans[0].birthday = new DateTime(1996, 4, 17);
        humans[1].birthday = new DateTime(1990, 11, 17);
        humans[2].birthday = new DateTime(1992, 5, 16);
        humans[3].birthday = new DateTime(1999, 8, 11);
        humans[4].birthday = new DateTime(1989, 10, 1);
        humans[5].birthday = new DateTime(1982, 2, 26);

        long sum = 0;
        DateTime mediana = new DateTime();
        
        for(int i = 0; i < humans.Length; i++)
        {
            sum += humans[i].birthday.Nanosecond;
            //DateTime.
            //mediana = sum / humans.Length;
            //Console.WriteLine(humans.birthday.Length);

        }
    }
}*/


int[] CheckFive(int[] forCalculation)
{
    int count = 0;
    for (int i = 0; i < forCalculation.Length; i++)
    {
        if (forCalculation[i] % 5 == 0)
        {
            count++;
            // Console.WriteLine(forCalculation[i]);
        }
    }
    int[] result = new int[count];

    int k = 0;

    for (int j = 0; j < forCalculation.Length; j++)
    {
        if (k < result.Length)
        {
            if (forCalculation[j] % 5 == 0)
            {
                result[k] = forCalculation[j];

                //Console.WriteLine(forCalculation[j]);
                k++;
            }
        }
    }
    return result;
}
CheckFive(new int[] { 1, 5, 7, 9, 12, 15, 18, 25 });




static int[] RandomListNumbers()
{

    var randomList = new Random(0);
    int[] randomForCalculation = new int[20];
    int sum = 0;
    int average = 0;
    int count = 0;
    
    for (int i = 0; i < randomForCalculation.Length; i++)
    {
        int transformRandom = randomList.Next(1, 100);
        randomForCalculation[i] = transformRandom;
        //Console.WriteLine(randomForCalculation[i]);
        sum += randomForCalculation[i];
        //Console.WriteLine(sum);
    }
    for (int b = 0; b < randomForCalculation.Length; b++)
    {
        average = sum / randomForCalculation.Length;
           //Console.WriteLine(average);
        if (randomForCalculation[b] >= average && randomForCalculation[b] % 2 == 0)
            {
                count++;
            //Console.WriteLine(count);
        }
        
    }
    //Console.WriteLine(average);
    //Console.WriteLine(count);
    int[] listMoreAverage = new int[count];
    int k = 0;
    for (int m = 0; m < randomForCalculation.Length; m++)
    {
        if (k < count)
    {
            if ((randomForCalculation[m] >= average) && (randomForCalculation[m] % 2 == 0))
            {
                listMoreAverage[k] = randomForCalculation[m];
               Console.WriteLine(listMoreAverage[k]);
                k++;
            }
        }
    }

    return listMoreAverage;

}
RandomListNumbers();