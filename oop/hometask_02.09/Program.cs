
/*Ви робили завдання: 
2. Створити клас Книжка. Книга має: автор, назва, рік, кількість сторінок. Придумати 3 конструктори. 
до нього будемо дописувати. 
1. Додати ще одне поле: рейтинг книги (нехай число double від 0-10). +-
2. Створити ще одни конструктор який приймає в себе всі поля. +
3. Додати метод який повертає просто рік коли випущена книга. +
4. Додати метод який приймає рік і повертає чи на той рік була випущена книга чи ще ні (true або false) +
5. Додати метод який змінює назву книги на нову. +
6. Додати метод який змінуює рейтинг книги (Якщо користувач вкаже нове значення не коректно,
не в межах 0-10 то значення не змінювати) +
7. Додати метод який рахує кількість символів в назві книги +
8. Додати метод який рахує кількість символів в авторі книги +
9. Додати метод який рахує кількість символів в назві книги і авторі книги загалом (можна використати попередні методи) + 
10. Додати метод який рахує специфічний коефіцієнт книги. Коефіцієнт: кількість балів поділити на кількість сторінок + */

namespace hometask_02._09;

//1. Додати ще одне поле: рейтинг книги(нехай число double від 0-10). +

     class Book
    {
        public string author;
        public string title;
        public int year;
        public int countPages;
        public double rating = Random.Shared.Next(0, 10);

      
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
    //2. Створити ще одни конструктор який приймає в себе всі поля. +
        public Book(string author, string title, int year, int countPages, double rate)
        {
        this.author = author;
        this.title = title;
        this.year = year;
        this.countPages = countPages;
        rating = rate;
        }
}
class Program
{
    static void Main(string[] args)
    {
        Book bookNew = new Book("Axel Scheffler", "Pip and Posy", 2019, 24);
        Book book = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10);
        Book bookLost = new Book("Pip and Posy:The snowy day", 2017, 24);


        Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
        //Console.WriteLine(bookRating.author);



        //3. Додати метод який повертає просто рік коли випущена книга.+
        static int YearOfPublishing(Book book)
        {
            Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
            //Console.WriteLine(bookRating.year);
            return bookRating.year;
        }


        //4. Додати метод який приймає рік і повертає чи на той рік була випущена книга чи ще ні(true або false) +

        static bool YearCheck(Book book)
        {
            Console.WriteLine("Please, enter the year of book`s publishing");
            int randomYear = Convert.ToInt32(Console.ReadLine());

           Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);

            bool check = false;
            if (randomYear == bookRating.year)
            {
                check = true;
                //Console.WriteLine(check);
            }
            return check;
        }

        //5. Додати метод який змінює назву книги на нову.+
        static Book TitleChange(string newBookTitle)
        { 
            Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
            bookRating.title = newBookTitle;
            return bookRating;
        }

        //6.Додати метод який змінуює рейтинг книги(Якщо користувач вкаже нове значення не коректно,
        //не в межах 0 - 10 то значення не змінювати) +

        static double ChangingRating()
        {
            Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
            Console.WriteLine("Please, enter your own rating for the book from 0 to 10");
            string initial = Console.ReadLine();
            double changing = Convert.ToDouble(initial);
            if(changing <= 10 && changing >= 0)
            {
                bookRating.rating = changing;
            }
            //bookRating.rating = Random.Shared.Next(0, 10);?

            return bookRating.rating;
        }

        //7.Додати метод який рахує кількість символів в назві книги +

        static int TitleSymbols()
        {
            Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
            int result = 0;
            for(int i = 0; i < bookRating.title.Length; i++)
            {
                if(bookRating.title[i].ToString() != " ")
                {
                    result++;
                }
            }
            return result;

        }
        //8. Додати метод який рахує кількість символів в авторі книги +

        static int AuthorSymbols()
        {
            Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
            int result = 0;
            for (int i = 0; i < bookRating.author.Length; i++)
            {
                if (bookRating.author[i].ToString() != " ")
                {
                    result++;
                }
            }
            return result;

        }

        //9.Додати метод який рахує кількість символів в назві книги і авторі книги
        //загалом(можна використати попередні методи) +

        static int Symbols()
        {
            int sum = TitleSymbols() + AuthorSymbols();

            return sum;

        }
        

        //10.Додати метод який рахує специфічний коефіцієнт книги.
        //Коефіцієнт: кількість балів поділити на кількість сторінок +


        static double Coefficient()
        {
            Book bookRating = new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10);
            double result = ChangingRating() / Convert.ToDouble(bookRating.countPages);
            return result;
        }

        int yearPublish = YearOfPublishing(new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10));
        Console.WriteLine(yearPublish);

        bool yearChecking = YearCheck(new Book("Britt Allcroft", "Thomas & Friends", 2016, 10, 10));
        Console.WriteLine(yearChecking);

        Book newBook = TitleChange("Friends & Thomas");
        Console.WriteLine(newBook.title);

        double change = ChangingRating();
        Console.WriteLine(change);

        int symbolsTitle = TitleSymbols();
        Console.WriteLine(symbolsTitle);

        int symbolsAuthor = AuthorSymbols();
        Console.WriteLine(symbolsAuthor);

        int symbols = Symbols();
        Console.WriteLine(symbols);

        double coef = Coefficient();
        Console.WriteLine(coef);

    }
}
   

