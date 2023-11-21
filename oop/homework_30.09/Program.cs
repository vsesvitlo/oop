using System.Collections;
using System.Collections.Generic;

namespace homework_30._09;
/*1. Метод який за вказаним вхідним товаром каже чи є він в корзині чи немає (повертає true, false) +
2. В класі продуктів додати знижку на товар, double. Наприклад 20%, або 15% +
3. Метод який повертає загальну ціну продуктів без знижки +
4. Метод який повертає загальну ціну продуктів зі знижкою +
5. Метод який повертає реальни відсоток знижки загальний. 
Якщо купили 3 товари (хліб 40 - 25% знижки, вода 10 - 0% знижки, молоко 50 - 10% знижки)
то загальна вартість без знижки 100, зі знижкою  85, то знижка виходить
(заг_сум-зниж_сум)/(заг_сум) = (100-85)/100 = 15 %  +
6. Метод який приймає параметром іншу корзину і забирає з неє всі товари собі + 
7. Метод який викидає один випадковий товар (якщо є хоча б один, якщо немає то нічого не робиться) +
8. Метод який видаляє з корзини всі товари без знижки +
9. Метод який перекидає в іншу корзину всі товари які мають знижку більшу як 10%.
Тобто в нього ці товари зникають, а якась інша нова корзина їх отримує + */

public class Product
{
    private string title;
    private int cost;
    private double discount;

    public Product()
    {
        title = "";
        cost = 0;
        discount = 0; ;
    }
    public Product(string title, int cost, double discount)
    {
        this.title = title;
        this.cost = cost;
        this.discount = discount;
    }
    public double WithoutDiscount()
    {
        double costWithountDiscount = Convert.ToDouble(cost);
        return costWithountDiscount;
        
    }
    public double AddDiscount()
    {
       double newCost = Convert.ToDouble(cost) - (Convert.ToDouble(cost) * discount)/100;
       return newCost;
    }

    public double totalDiscount()
    {
        double realDiscount = (WithoutDiscount() - AddDiscount())/100;
        return realDiscount;
    }
    public double GetDiscount()
    {
        return discount;
    }
}
public class Cart
{
    List<Product> list = new List<Product>();

    public Cart()
    {
        list = new List<Product>();
    }

    public bool CheckCart(Product item)
    {
        bool result = false;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == item)
            {
                result = true;
            }
        }
        return result;
    }
    public void AddCart(Product item)
    {
        list.Add(item);
    }
    public void RemoveCart(Product item)
    {
        list.Remove(item);
    }
    public void RemoveRandomCart()
    {
        Random rnd = new Random();
        int mIndex = rnd.Next(list.Count);
        if (list.Count >= 1)
        {
            list.RemoveAt(mIndex); 
        }
    }
    public void RemoveAllCart()
    {
        list.RemoveRange(0, list.Count);
    }
    public void RemoveAllWithoutDiscount()
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].GetDiscount() == 0){
                list.Remove(list[i]);
            }
        }
    }
    public void Information()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
    public void NewCartCopy(Cart newCart)
    {
        for (int i = 0; i < list.Count; i++)
        { 
            this.list.Add(list[i]);
            newCart.list.Remove(list[i]);
        }
    }
    public void Moving (Cart newCart)
    {
        
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].GetDiscount() >= 10)
            {
                
                newCart.list.Add(list[i]);
                this.list.Remove(list[i]);
            }
           
        }
    }
    public double TotalSum()
    {
        double result = 0;
         for(int i = 0; i < list.Count; i++)
        {
            result += list[i].WithoutDiscount();
        }
        return result;
    }
    public double DiscountSum()
    {
        double discountSum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].GetDiscount() > 0)
            {
                double newSum = Convert.ToDouble(list[i].WithoutDiscount()) - (Convert.ToDouble(list[i].WithoutDiscount()) *
                    list[i].GetDiscount()) / 100;
                discountSum += newSum;
            }   
        }
        return discountSum;
    }
    public double DiscountSumSave()
    {
        double saving = (TotalSum() - DiscountSum()) / TotalSum();

        return saving;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //List<Product> list = new List<Product>();
        //list = new List<Product>();
        Cart ownCart = new Cart();
        Product bread = new Product("bread", 39, 10);
        Product water = new Product("water", 10, 20);
        Product jogurt = new Product("jogurt", 45, 0);
        Product milk = new Product("milk", 20, 15);
        ownCart.AddCart(bread);
        ownCart.AddCart(water);
        ownCart.AddCart(jogurt);
        ownCart.AddCart(milk);

        Cart movingCart = new Cart();
        ownCart.Moving(movingCart);
        Console.WriteLine(movingCart.TotalSum());

        /*
        Console.WriteLine(ownCart.CheckCart(bread));
        Console.WriteLine(ownCart.CheckCart(water));
        Console.WriteLine(bread.WithoutDiscount());
        Console.WriteLine(bread.AddDiscount());
        Console.WriteLine(water.AddDiscount());
        Console.WriteLine(jogurt.AddDiscount());
        Console.WriteLine(milk.AddDiscount());

        Console.WriteLine(bread.totalDiscount());
        Console.WriteLine(ownCart.TotalSum());
        Console.WriteLine(ownCart.DiscountSum());
        Console.WriteLine(ownCart.DiscountSumSave());
        //Console.WriteLine(water.discount);

        Cart copyCart = ownCart;
        copyCart.NewCartCopy(ownCart);
        Console.WriteLine(copyCart.TotalSum());
        ownCart.RemoveRandomCart();
        Console.WriteLine(ownCart.TotalSum());
        ownCart.RemoveAllWithoutDiscount();
        Console.WriteLine(ownCart.TotalSum());

        Cart movingCart = new Cart();
        movingCart.Moving(copyCart);
        Console.WriteLine(movingCart.TotalSum()); */
    }
}

