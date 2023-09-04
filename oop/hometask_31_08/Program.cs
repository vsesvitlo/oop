//1. Створити клас собак. В класі 3 поля: кличка, вік, порода. Зробити 3 конструктори.
//Один повний, другий для новонародженого, і третій пустий (кличка виставляється "Doge", порода "streetracer").+ 
//2.Створити клас Книжка. Книга має: автор, назва, рік, кількість сторінок. Придумати 3 конструктори. + 
//3. Є масив {1, 2, 9, 7, 4 , 4, 1, 2, 3,1}. Порахувати скільки в цьому класі є дзеркальних повторень.
//Тобто на першій і останній позиції однакове, на другій і передостанній і тд. Попробуйте через 2 поінтери. 
//4. Є масив a = {1, 2, 9, 7, 4, 1,1, 4, 2, 4, 1, 2, 3,1} і є ще один масив b = {1, 2, 4, 8}.
//Яких чисел з масива b немає в масиві a

/*

using System.Diagnostics.Metrics;

namespace hometask_31_08;
class Dog
{
    public string name;
    public int age;
    public string bride;

    public Dog(string name, int age, string bride)
    {
        this.name = name;
        this.age = age;
        this.bride = bride;
    }

    public Dog(string newborn, string bride)
    {
        this.name = newborn;
        age = 0;
        this.bride = bride;
    }
    public Dog()
    {
        name = "";
        age = 0;
        bride = "";
    }
}



class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Phild", 5, "withoutBreed");
        Dog dogNewborn = new Dog("Bim", "shepherd");
        Dog empty = new Dog("Doge", "streetracer");
        Console.WriteLine(dog.age);
        Console.WriteLine(dogNewborn.name);
        Console.WriteLine(empty.bride);
    }
}
*/
//2.Створити клас Книжка. Книга має: автор, назва, рік, кількість сторінок. Придумати 3 конструктори. +

/*using System.Diagnostics.Metrics;

namespace hometask_31_08;

class Book
{
    public string author;
    public string title;
    public int year;
    public int countPages;

    public Book()
    {
        author = "";
        title = "";
        year = 0;
        countPages = 0;
    }
    public Book(string author, string title, int year, int pages)
    {
        this.author = author;
        this.title = title;
        this.year = year;
        countPages = pages;
    }

    public Book(string titleBook, int yearPublish, int pageAmount)
    {
        author = "";
        title = titleBook;
        year = yearPublish;
        countPages = pageAmount;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Book bookNew = new Book("Axel Scheffler", "Pip and Posy", 2019, 24);
        Book book = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10);
        Book bookLost = new Book( "Pip and Posy:The snowy day", 2017, 24);
        Console.WriteLine(bookNew.author);
        Console.WriteLine(book.title);
        Console.WriteLine(bookLost.year);
    }
}*/

//3. Є масив {1, 2, 9, 7, 4, 4, 1, 2, 3,1}. Порахувати скільки в цьому класі є дзеркальних повторень.
//Тобто на першій і останній позиції однакове, на другій і передостанній і тд. Попробуйте через 2 поінтери. 
//Попробуйте на дзеркальне перетворення із вказівником на старт і кінець може вийде

using System.Diagnostics.Metrics;

namespace hometask_31_08;


class Program
{
    static void Main(string[] args)
    {
        static int CountTheSame(int[] count)
        {
            int first = count[0];
            int last = count[count.Length - 1];
            int result = 0;

            for (int i = 1; i < count.Length; i++)
            {
                if(first == last)
                {
                    result++;
                    //Console.WriteLine(first);
                    //Console.WriteLine(last);
                }
                first = count[i];
                last = count[count.Length - i];

            }
            return result;

        }
        int count = CountTheSame(new int[] { 1, 2, 9, 7, 4, 4, 1, 2, 3, 1 });
        Console.WriteLine(count);
    }
}

//4. Є масив a = {1, 2, 9, 7, 4, 1,1, 4, 2, 4, 1, 2, 3,1} і є ще один масив b = {1, 2, 4, 8}.
//Яких чисел з масива b немає в масиві a
/*
using System.Diagnostics.Metrics;

namespace hometask_31_08;


class Program
{
    static void Main(string[] args)
    {
        static int[] Compare(int[] arr1, int[] arr2)
        {
            int count = 0;
            int countForLength = 0;
            int[] result = new int[countForLength];
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if(k < arr2.Length)
                {
                    if (arr2[k] == arr1[i])
                    {
                        count++;
                   
                        
                    }
                    k++;
                }
            }
            countForLength = arr2.Length - count;
           Console.WriteLine(countForLength);

            int j = 0;
            int l = 0;
            int compare = arr2[0];
            for (int n = 0; n < arr1.Length; n++)
            {
                if (j < arr2.Length)
                {
                   if (l < countForLength)
                    {
                        if (compare != arr1[n])
                        {
                            //result[l] = compare;
                            //Console.WriteLine(compare);
                        }
                        compare = arr2[j];
                        //result[l] = compare;
                        //Console.WriteLine(compare);
                        j++;
                        l++;

                    }
                }
            }

            return result;

        }
        Compare(new int[] { 1, 2, 9, 7, 4, 1, 1, 4, 2, 4, 1, 2, 3, 1 }, new int[] { 20, 1, 2, 4, 8, 10});
    }
}*/