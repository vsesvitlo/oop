namespace _29._09;
public class Product
{
    public string title;
    public int cost;


    public Product()
    {
        title = "";
        cost = 0;
    }
    public Product(string title, int cost)
    {
        this.title = title;
        this.cost = cost;
    }
    public override string ToString()
    {
        string total = title + " " + cost.ToString();
        return total;

    }
}

public class Cart
{
    List<Product> list = new List<Product>();

    public Cart()
    {
     list = new List<Product>();
    }

    public void AddCart(Product item)
    {
        list.Add(item);
    }
    public void RemoveCart(Product item)
    {
        list.Remove(item);
    }
    public void RemoveAllCart()
    {
        list.RemoveRange(0, list.Count);
    }

    public void Information()
    {
      for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Product bread = new Product ("bread", 39);
        Product water = new Product("water", 10);
        Product jogurt = new Product("jogurt", 45);
        Product milk = new Product("milk", 20);
        Cart ownCart = new Cart();
        //ownCart.AddCart(bread);
        ownCart.AddCart(water);
        ownCart.AddCart(jogurt);
        ownCart.AddCart(milk);
        //ownCart.Information();
        //ownCart.RemoveAllCart();
        ownCart.RemoveCart(bread);
        ownCart.Information();
    }
}

