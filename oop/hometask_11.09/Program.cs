/*Завдання на закріплення: 
Теорія: 
1. шилд 218 сторінка pdf файла. "Передача объектов методам по ссылке"
Проаналізуйте теорію і що написано в коді. Що означає передати по ссилці?
Додати в клас автомобіль: 
1. Метод який приймає інший автомобіль і копіює з нього тільки пробіг+
2. Метод який приймає інший автомобіль і забирає все пальне 
3. Метод який приймає параметрами два автомобіля і з першого бере вагу, а з другого бере рік випуску
4. (щось не звичне, якщо будуть запитання - пишіть) Метод приймає дургий автомобіль.
В середині метода створюється новий екземпляр машини який бере частину параметрів від одного автомобіля
і другу частину параметрів від іншого. Потім метод повертає новонародженого автомобіля*/

namespace hometask_11._09;


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
    public int MaxSeats
    {
        get
        {
            return maxSeats;
        }
        set
        {
            if (value < 0 || value > 9)
            {
                maxSeats = 0;
            }
            else
                maxSeats = value;
        }

    }
    public int MaxSpeed
    {
        get
        {
            return maxSpeed;
        }
        set
        {
            if (value < 0 || value > 300)
            {
                maxSpeed = 0;
            }
            else
                maxSpeed = value;
        }

    }
    // 1. Метод який приймає інший автомобіль і копіює з нього тільки пробіг

    public void RunCopyCar(Car forChange)
    {
        this.runKm = forChange.runKm;
    }
    //2.Mетод який приймає інший автомобіль і забирає все пальне
    public void GettingFuel(Car forFuel)
    {
        this.fuelVolume += forFuel.fuelVolume;
        forFuel.fuelVolume = 0;
    }

    //3. Метод який приймає параметрами два автомобіля і з першого бере вагу, а з другого бере рік випуску

    public void WeightYear(Car forWeight, Car forYear)
    {
        this.weightWithoutFuel = forWeight.weightWithoutFuel;
        this.yearOfProduction = forYear.yearOfProduction;
    }
    //4. Метод приймає дургий автомобіль.
    // В середині метода створюється новий екземпляр машини який бере частину параметрів від одного автомобіля
    //і другу частину параметрів від іншого.Потім метод повертає новонародженого автомобіля

    public Car NewCarTransform (Car newTranformation)
    {
        Car newBorn = new Car(title, owner, priceWithoutFuel, yearOfProduction, weightWithoutFuel, fuelVolume,
        runKm, fuelVolume100km, maxSpeed, seats);

        newBorn.title = newTranformation.title;
        newBorn.owner = newTranformation.owner;
        newBorn.priceWithoutFuel = newTranformation.priceWithoutFuel;

        return newBorn;
    }

    public Car Clone()
    {
        Car newClone = new Car(title, owner, priceWithoutFuel, yearOfProduction, weightWithoutFuel, fuelVolume,
        runKm, fuelVolume100km, maxSpeed, seats);
        return newClone;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car Honda = new Car("Honda NSX", "Japonsko", 71591, 1991, 1720, 32, 148000, 0, 201, 2);
            Car Fiat = new Car("Fiat Freemont", "Italie", 14495, 2015, 2089, 77, 79930, 0, 100, 7);
            Car Toyota = new Car("Toyota Prius", "Japonsko", 12258, 2009, 1350, 45, 123867, 0, 180, 5);
            Car Renault = new Car("Renault Megane", "Francie", 12872, 2017, 1823, 60, 92747, 0, 230, 4);
            Car Citroen = new Car("Citroen C4 Picasso", "Francie", 15000, 2014, 2030, 60, 32000, 0, 209, 5);
            Car Volkswagen = new Car("Volkswagen Passat", "Nemecko", 22000, 2015, 2310, 66, 144000, 0, 238, 5);
            
            Citroen.RunCopyCar(Volkswagen);
            Console.WriteLine(Citroen.runKm);

            Honda.GettingFuel(Toyota);
            Console.WriteLine(Toyota.fuelVolume);
            Console.WriteLine(Honda.fuelVolume);

            Renault.WeightYear(Citroen, Toyota);
            Console.WriteLine(Renault.weightWithoutFuel);
            Console.WriteLine(Renault.yearOfProduction);


            Car NewBorn = Honda.NewCarTransform(Toyota);

            Car NewClone = Fiat.Clone();



        }
    }
}

