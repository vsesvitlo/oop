namespace homework_9._10;
/*
1. Гляньте в Шилда є розід "свойства и индексатри"
2. З книжки нової 228 сторінка

271 сторінка тут

391 сторінка по шилду

1. Створити структуру "Точка" (Point), яка містить два цілих числа, координати x та y. 
 Додайте конструктор, що приймає початкові значення цих координат. +
2. Створити структуру "Прямокутник" (Rectangle),
яка містить дві точки: верхню ліву і нижню праву. Реалізуйте метод, що обчислює площу прямокутника. +
3. Створити структуру "Календарний захід" (CalendarEvent),
яка представляє подію у календарі з назвою, датою початку і датою закінчення.
Додайте метод для обчислення тривалості події в годинах.*/
class Program
{

    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y){
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
    }

    struct Rectangle
    {
        public Point topLeft;
        public Point bottomRigth;

        public Rectangle(Point a, Point b)
        {
            topLeft = a;
            bottomRigth = b;
        }
        public int SquareRectangle(Point a, Point b)
        {
            int width = b.x - a.x;
            int height = a.y - b.y;
            int square = width * height;
            return Math.Abs(square);
        }

    }

    struct CalendarEvent
    {
        public string name;
        public DateTime begin;
        public DateTime end;


        public CalendarEvent(string title, DateTime first, DateTime second)
        {
            name = title;
            begin = first;
            end = second;
        }
        public static TimeSpan ReturnSpan(DateTime begin, DateTime end)
        {
            TimeSpan result = end - begin;
            return result;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }

    static void Main(string[] args)
    {
        Point first = new Point(9, 8);
        Point second = new Point(15, 0);
        Console.WriteLine(first.x);
        Rectangle Calc = new Rectangle(first, second);
        Console.WriteLine(Calc.SquareRectangle(first, second));

        DateTime start = new DateTime(2023, 10, 7, 11, 6, 8);
        DateTime finish = new DateTime(2023, 10, 8, 10, 4, 6);
        string title = "Event";
        CalendarEvent Example = new CalendarEvent(title, start, finish);
        //Console.WriteLine(Example.ReturnSpan(start, finish));

    }
}

