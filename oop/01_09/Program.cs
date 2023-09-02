namespace _01_09;

class Program
{
    static void Main(string[] args)
    {
       string[] ListUnique(string[] shop, string[] list) {
            int result = 0;
           

            int k = 0;
            for(int i = 0; i < list.Length; i++)
            {
                for(int j = 0; j < shop.Length; j++)
                {
                        if (list[i] == shop[j])
                        {  
                        result++;
                        }
                }
                   
            }
            string[] products = new string[result];
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < shop.Length; j++)
                {
                    if (list[i] == shop[j])
                    {
                        products[k] = shop[j];
                        k++;
                    }
                }

            }

            return products;
        }

       string[] result = ListUnique(new string[] { "хліб", "помідор", "вода", "масло", "сир", "ківі" },
         new string[] { "банан", "вода", "сир", "яблоко" });
        for(int h = 0; h < result.Length; h++)
        {
            Console.WriteLine(result[h]);
        }
       
    }
}

