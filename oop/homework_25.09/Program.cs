/*По практиці: потренувати тіж самі методи, this, конструктори. 
Ми зробили клас машин, можемо зробити ще додатково класи Літак і ПлаваючийЗасіб. 
(Потім використаємо машину, літак і плаваючий засіб для того щоб реалізувати в них спільний інтерфейс)
Цього разу для класу літак завадння:
1. Поля класу: назва літака,+
назва бренду,+
вага латака,+
кількість сидінь,+
рік випуску,+
ціна літака, +
поточна кількість пального (кг),+
кількість пального (кг) на 1000 км польоту,+
максимальна дальність польоту,+
місткість баку (кг). +
2. Зробити 3 конструктори. Один з них повний, два інші із меншою кількістю параметрів. +
3. Додати метод який повертає вагу літака +
4. Додати метод змінює вагу літака +
5. Додати метод який повертає кількість сидінь +
6. Додати метод змінює кількість сидінь +
7. Додати метод який заповнює бак до кінця. 
8. Додати метод який каже скільки залишилося в баку пального в абсолютних значення.
9. Додати метод який каже скільки % пального в баку(від 0 до 100%, якщо бак заповнений на половину то 50% і тд). 
10. Додати метод який віднімає вказану кількість сидінь (тобто в літака стає менше загалом міць), якщо попробувати відняти відємне число то нічого не станеться
11. Додати метод який розраховує вартість польоту на 1000км за вказаним показником ціни палива за кг
12. Додати метод який розраховує вартість польоту на вказану кількість км і за вказаним показником ціни палива за кг
13. Додати метод який повертає кількість років літаку на цей момент*/



using System.Security.Cryptography;

namespace homework_25._09;
public class Airplane
{
    public string nameAirplane;
    public string brandAirplane;
    public int weightAirplane;
    public int seatsAirplane;
    public int yearProductionAirplane;
    public int priceAirplane;
    public int currentFuelAmmountAirplane;
    public int consumptionFuelAirplanePer1000;
    public int rangeAirplane;
    public int maximumFuelAmmountAirplane;

    public Airplane(string name, string brand, int weight, int seats, int yearProduction, int price,
        int currentFuelAmmount, int consumption1000, int distance, int maximumFuelAmmount)
    {
        nameAirplane = name;
        brandAirplane = brand;
        weightAirplane = weight;
        seatsAirplane = seats;
        yearProductionAirplane = yearProduction;
        priceAirplane = price;
        currentFuelAmmountAirplane = currentFuelAmmount;
        consumptionFuelAirplanePer1000 = consumption1000;
        rangeAirplane = distance;
        maximumFuelAmmountAirplane = maximumFuelAmmount;
    }
    public Airplane(string nameAirplane, string brand, int weight, int seats, int yearProduction, int maximumOilAmmount)
    {
        this.nameAirplane = nameAirplane;
        brandAirplane = brand;
        weightAirplane = weight;
        seatsAirplane = seats;
        yearProductionAirplane = yearProduction;
        priceAirplane = 0;
        currentFuelAmmountAirplane = 0;
        consumptionFuelAirplanePer1000 = 0;
        rangeAirplane = 0;
        maximumFuelAmmountAirplane = maximumOilAmmount;
    }
    public Airplane(string nameAirplane, string brandAirplane)
    {
        this.nameAirplane = nameAirplane;
        this.brandAirplane = brandAirplane;
        weightAirplane = 0;
        seatsAirplane = 0;
        yearProductionAirplane = 0;
        priceAirplane = 0;
        currentFuelAmmountAirplane = 0;
        consumptionFuelAirplanePer1000 = 0;
        rangeAirplane = 0;
        maximumFuelAmmountAirplane = 0;
    }
    // 3. Додати метод який повертає вагу літака +
    public int Weight()
    {
        return weightAirplane;
    }
    //4. Додати метод змінює вагу літака +
    public void ChangeWeight(int newWeignt)
    {
        weightAirplane = newWeignt;
    }
    //5. Додати метод який повертає кількість сидінь
    public int Seats()
    {
        return seatsAirplane;
    }
    //6. Додати метод змінює кількість сидінь
    public void ChangeSeats(int forChange)
    {
        seatsAirplane += forChange;
    }
    //7. Додати метод який заповнює бак до кінця.+

    public int FullFuel()
    {
        currentFuelAmmountAirplane = maximumFuelAmmountAirplane;
        return currentFuelAmmountAirplane;
    }
    //8. Додати метод який каже скільки залишилося в баку пального в абсолютних значення.+

    public double FuelRests()
    {
        double rests = Convert.ToDouble(currentFuelAmmountAirplane);
        return rests;
    }

    //9. Додати метод який каже скільки % пального в баку(від 0 до 100%, якщо бак заповнений на половину то 50% і тд).

    public double CalculatePercentage()
    {
        double full = (100 * Convert.ToDouble(currentFuelAmmountAirplane))/ Convert.ToDouble(maximumFuelAmmountAirplane);
        return full;
    }
    //10. Додати метод який віднімає вказану кількість сидінь(тобто в літака стає менше загалом міць),
    //якщо попробувати відняти відємне число то нічого не станеться+
    public void ChangeSeatsForComfort(int forDecreasing)
    {
        if (forDecreasing >= 0)
        {
            seatsAirplane -= forDecreasing;
        }
        else if(forDecreasing >= seatsAirplane)
        {
            seatsAirplane = 10;
        }
    }

    //11. Додати метод який розраховує вартість польоту на 1000км за вказаним показником ціни палива за кг+
    public double CalculationPrice1000(double fuelPrice)
    {
        double pricePer1000 = Convert.ToDouble(consumptionFuelAirplanePer1000) * fuelPrice;
        return pricePer1000;
    }
    // 12. Додати метод який розраховує вартість польоту на вказану кількість км і за вказаним показником ціни палива за кг +
    public double CalculationPrice(double distance, double fuelPrice)
    {
        double pricePerFlight = distance * fuelPrice;
        return pricePerFlight;
    }

    //13. Додати метод який повертає кількість років літаку на цей момент +
    public int HowOld()
    {
        int calcOld = 2023 - yearProductionAirplane;
        return calcOld;
    }
   
}
class Program
{
    static void Main(string[] args)
    {
        Airplane Mria = new Airplane("An-225 Mriya", "Antonov", 285000, 400, 1988, 500000000, 10, 300000, 15400, 1300);
        Console.WriteLine(Mria.Weight());
        Mria.ChangeWeight(640000);
        Console.WriteLine(Mria.weightAirplane);
        Console.WriteLine(Mria.seatsAirplane);
        Mria.ChangeSeats(6);
        Console.WriteLine(Mria.seatsAirplane);
        
        Console.WriteLine(Mria.currentFuelAmmountAirplane);
        Console.WriteLine(Mria.FuelRests());
        Console.WriteLine(Mria.CalculatePercentage());
        Console.WriteLine(Mria.FullFuel());
        Mria.ChangeSeatsForComfort(7);
        Console.WriteLine(Mria.seatsAirplane);
        Console.WriteLine(Mria.CalculationPrice1000(50));
        Console.WriteLine(Mria.CalculationPrice(7000, 50));
        Console.WriteLine(Mria.HowOld());
    }
}
