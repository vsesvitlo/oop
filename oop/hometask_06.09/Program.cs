/*public class Human
    {
        string name;
        int child_count;
        public int count1 = 0;
        public int count2 = 0;
        public int id;

        public Human(string name, int child_count)
        {
            this.name = name;
            this.child_count = child_count;
        }
        public Human(string name)
        {
            this.name = name;
            this.child_count = 0;
        }
        public Human(string name, int child_count, int count1, int count2)
        {
            this.name = name;
            this.child_count = child_count;
            this.count1 = count1;
            this.count2 = count2;
        }
        public int Sum() // Щось повертає, нічого не міняє в собі
        {
            int sum = count1 + count2;
            return sum;
        }
        public bool DoYouHaveMoreThan(int value) // Щось повертає, нічого не міняє в собі
        {
            if (count1 + count2 > value)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Фіча, можна розрахувати скільки кому дістанеться
        /// </summary>
        /// <param name="else_people">кількість претендентів</param>
        /// <returns></returns>
        public int ZapovitForElseHumans(int else_people)  // Щось повертає, нічого не міняє в собі
        {
            return (count1 + count2) / else_people;
        }
        /// <summary>
        /// Заповіт на дітей
        /// </summary>
        /// <returns></returns>
        public int ZapovitForElseHumans()  // Щось повертає, нічого не міняє в собі
        {
            if (child_count > 0)
            {
                return this.ZapovitForElseHumans(child_count);
            }
            return 0;
        }
        public void AddMoneyInCard1(int value) // Щось в собі змінює
        {
            this.count1 += value;
        }
        public void SetName(string name) // Щось в собі змінює
        {
            this.name = name;
        }
        public void SetCards(int c1, int c2) // Щось в собі змінює
        {
            count1 = c1;
            count2 = c2;
        }

    }*///Чому або щось змінює або щось повертає? 
       //Коли програміст щось хоче зробити із обєктом того класу який Ви створили,
       //зазвичай він хоче щоб зробилася якась одна дія. 
       //І дуже не приємно стає коли код крім своєї роботи робить якісь сайд ефекти. 

//Наприклад клас рандом. Екземляр класу рандом може давати випадкове число в якомусь діапазоні random.Next(a, b). 
//Задаючи діапазон Ви не очікуєте що він зробить якісь сайд ефекти по типу:
//буде запрошувати ввести число, або щось на компі переміщати, або ще щось. 
//Очікується що буде чітко зроблена одна робота. 
//От до того ми теж прагнемо щоб так вміти робити, хоча це й не геть в всіх випадках виходить


//...1. Створити клас машина (його будемо використовувати для цього всього завдання і ще для двох).+
//2.Поля класу:
//назва, +
// власник,+
// ціна тачки(без бензину),+
// рік випуску,+
// вага авто без пального(кг), +
// максимальна вмісткість баку для пального(вмісткість в кг), + 
// пробіг(км), +
//  кількість пального на 100 км(в літрах на км), +
// максимальна швидкість(км на годину), +
//кількість сидінь+
//3. Створити 3 конструктори +
//4. Створити метод, який буде повертати гарно форматований текст повну інформацію про цю машину.+
//5. Створити метод, який буде повертати вагу машини із повним заповненим баком. +
//6. Створити метод, який буде повертати ціну на тачку із половною баку бензину. +
//7. Створити метод, який буде повертати вартість повної заправки (в параметри приймає поточну ціну за кг пального)+
//8.Створити метод, який буде повертати кількість кілометрів яку може проїхати тачка (в параметри вводять кг пального)+
//9.Створити метод, який буде повертати вартість проїзду 100 км для однієї людини. Вхідний параметер - ціна бензину.
//Максимальна вмісткість людей - це кількість сидінь. Наприклад якщо на 100 км авто бере 10 кг бензина, бензин по 50 грн/кг,
//вміскість 5 людей, то 10кг*50 грн/кг / 5 людей = 100 грн за 100 км на людину +
//10. Створити метод, який буде повертати скільки коштувало проїхати весь шлях що проїхала машина +
//(вхідний параетер - ціна бензину)
//11.Створити метод, який замія власника+
//12. Створити метод, який додає +10 км до загального пробігу+
//13. Створити метод, який змінює кількість сидінь +
//14. Створити метод, який змінює максимальну швидкість +
//15. Створити метод, який знижує ціну автомобіля на 10% +
//16. Створити метод, який змінює рік випуску на сьогоднішній рік +

//ну і після всього створіть 6 різних машин (можете адекватні дані ввести, бо будемо ними користуватися ще кілька разів). 
//Потім на основі цих даних земулюємо пошук даних, сервіси і більші класи

namespace hometask_06._09;
class Car
{
    public string title;
    public string owner;
    public int priceWithoutFuel;
    public int yearOfProduction;
    public int weightWithoutFuel;
    public int fuelVolume;
    public int runKm;
    public int fuelVolume100km;
    public int maxSpeed;
    public int seats;
    static public int maxSeats = 7;
   // static public List<>;

    public Car()
    {

        title = "";
        owner = "";
        priceWithoutFuel = 0;
        yearOfProduction = 0;
        weightWithoutFuel = 0;
        fuelVolume = 0;
        runKm = 0;
        fuelVolume100km = 0;
        maxSpeed = 0;
        seats = 0;
    }

    public Car(string title, string owner, int price, int year, int weight, int fuelVolume, int fuelVolume100, int maxSpeed, int seats)
    {
        this.title = title;
        this.owner = owner;
        priceWithoutFuel = price;
        yearOfProduction = year;
        weightWithoutFuel = weight;
        this.fuelVolume = fuelVolume;
        fuelVolume100km = fuelVolume100;
        this.maxSpeed = maxSpeed;
        this.seats = seats;
    }

    public Car(string title, string owner, int priceWithoutFuel, int yearOfProduction, int weightWithoutFuel, int fuelVolume,
        int runKm, int fuelVolume100km, int maxSpeed, int seats)
    {
        this.title = title;
        this.owner = owner;
        this.priceWithoutFuel = priceWithoutFuel;
        this.yearOfProduction = yearOfProduction;
        this.weightWithoutFuel = weightWithoutFuel;
        this.fuelVolume = fuelVolume;
        this.runKm = runKm;
        this.fuelVolume100km = fuelVolume100km;
        this.maxSpeed = maxSpeed;
        this.seats = seats;
    }

    public Car(Car Example)
    {
        this.title = Example.title;
        this.owner = Example.owner;
        this.priceWithoutFuel = Example.priceWithoutFuel;
        this.yearOfProduction = Example.yearOfProduction;
        this.weightWithoutFuel = Example.weightWithoutFuel;
        this.fuelVolume = Example.fuelVolume;
        this.runKm = Example.runKm;
        this.fuelVolume100km = Example.fuelVolume100km;
        this.maxSpeed = Example.maxSpeed;
        this.seats = Example.seats;
    }


    //4. Створити метод, який буде повертати гарно форматований текст повну інформацію про цю машину.+

    public string CarFullInformation()
    {
        string result = $"{this.title} car has {this.owner} owner. The current price without fuel " +
            $"is {this.priceWithoutFuel}. The car was produced in {this.yearOfProduction}. " +
            $"The weight is {this.weightWithoutFuel}. The volume of fuel is {this.fuelVolume}." +
            $"The total run is {this.runKm}. The consumption of fuel after 100 km is {this.fuelVolume100km}." +
            $"The maximum speed of the car is {this.maxSpeed}. There are {this.seats} seats in the car";
        return result;
    }
    //5. Створити метод, який буде повертати вагу машини із повним заповненим баком.+
    public int WeightCarWithFuel()
    {
        int totalWeight = this.fuelVolume + this.weightWithoutFuel;
        return totalWeight;
    }
    //6. Створити метод, який буде повертати ціну на тачку із половною баку бензину. +
    public double PriceCarHalfFuel(int priceFuel)
    {
        double totalPrice = Convert.ToDouble((priceFuel / 2) * this.fuelVolume) + this.priceWithoutFuel;
        return totalPrice;
    }
    //7. Створити метод, який буде повертати вартість повної заправки (в параметри приймає поточну ціну за кг пального)+
    public double PriceTotalFuel(int priceFuelPerKg)
    {
        double totalPriceForFuel = Convert.ToDouble(priceFuelPerKg * this.fuelVolume);
        return totalPriceForFuel;
    }
    //8.Створити метод, який буде повертати кількість кілометрів яку може проїхати тачка
    //(в параметри вводять кг пального)

    public double TotalDistance(int fuelKg)
    {
        double totalDistance = Convert.ToDouble(fuelKg * this.fuelVolume100km)/100 ;
        return totalDistance;
    }
    public double TotalDistance()
    {
        return TotalDistance(this.fuelVolume);
    }
    //9.Створити метод, який буде повертати вартість проїзду 100 км для однієї людини. Вхідний параметер - ціна бензину.
    //Максимальна вмісткість людей - це кількість сидінь. Наприклад якщо на 100 км авто бере 10 кг бензина, бензин по 50 грн/кг,
    //вміскість 5 людей, то 10кг*50 грн/кг / 5 людей = 100 грн за 100 км на людину +
    public double PricePerPerson(double price)
    {
        double pricePerPerson = (this.fuelVolume100km * price) / seats;
        return pricePerPerson;

    }
    //10. Створити метод, який буде повертати скільки коштувало проїхати весь шлях що проїхала машина +
    //(вхідний параетер - ціна бензину)

    public double PriceWhole(double price)
    {
        double priceWhole = this.runKm * price;
        return priceWhole;
    }

    //11.Створити метод, який замія власника +
    public void ChangeOwner(string newOwner)
    {
        this.owner = newOwner;
    }
    //12. Створити метод, який додає +10 км до загального пробігу +
    public void AddRun()
    {
        this.runKm += 10;
    }
    //13. Створити метод, який змінює кількість сидінь +
    public void ChangeSeats(int forChange, char dir)
    {
        if (dir == '+')
        {
            this.seats += forChange;

            if(this.seats > maxSeats)
            {
                this.seats = maxSeats;
            }

        }
       else {
            this.seats -= forChange;
       }
        Car.maxSeats = 8;
    }
    //14. Створити метод, який змінює максимальну швидкість +
    public void ChangeSpeed(int forChange, char dir)
    {
        if (dir == '+')
        {
            this.maxSpeed += forChange;
        }
        else
        {
            this.maxSpeed -= forChange;
        }
    }
    //15. Створити метод, який знижує ціну автомобіля на 10% +
    public void PriceDown()
    {
        this.priceWithoutFuel = Convert.ToInt32(Convert.ToDouble(this.priceWithoutFuel * 0.9));
    }

    //16. Створити метод, який змінює рік випуску на сьогоднішній рік +
    public void ChangeYear()
    {
        this.yearOfProduction = 2023;
    }

    public void ChangeCar(Car forChange)
    {
        this.title = forChange.title;
        this.owner = forChange.owner;
    }

    public void SeatsShop(Car forSeats)
    {
        ChangeSeats(1, '-');
        forSeats.ChangeSeats(1, '+');
    }


}
class Program
{
    static void Main(string[] args)
    {
        Car Honda = new Car("Honda NSX", "Japonsko",71591,1991, 1720, 32, 0, 148000, 201 ,2);
        Car Fiat = new Car("Fiat Freemont", "Italie", 14495, 2015, 2089, 77, 0, 79930, 100, 7);
        Car Toyota = new Car("Toyota Prius", "Japonsko", 12258, 2009, 1350, 45, 0, 123867, 180, 5);
        Car Renault = new Car("Renault Megane", "Francie", 12872, 2017,1823, 60, 0, 92747, 230, 4);
        Car Citroen = new Car("Citroen C4 Picasso", "Francie", 15000, 2014, 2030, 60, 0, 32000, 209, 5);
        Car Volkswagen = new Car("Volkswagen Passat", "Nemecko", 22000, 2015, 2310, 66, 0, 144000, 238, 5);
        Console.WriteLine(Honda.CarFullInformation());
        Console.WriteLine(Renault.TotalDistance());
        Citroen.ChangeCar(Volkswagen);
        Console.WriteLine(Citroen.title);
        Fiat.SeatsShop(Honda);
        Console.WriteLine(Honda.seats);
        Console.WriteLine(Fiat.seats);

        Car Fake = new Car(Honda);
        Console.WriteLine(Fake.owner);
        Console.WriteLine(Honda.owner);

        Car HondaItalie = new Car(Honda);
        HondaItalie.ChangeOwner(Fiat.owner);
        Console.WriteLine(HondaItalie.owner);


        List<long> NewList = new List<long>();
        NewList.Add(4);
        NewList.Add(34);
        NewList.Add(74);
        NewList.Add(104);
        NewList.Add(14);
        NewList[0] = 2;
        NewList[4] = 2;

        Console.WriteLine(NewList.Count());
        Console.WriteLine(NewList[4]);
    }


}

