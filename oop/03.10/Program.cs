namespace _03._10

{

public class Ques
    {
        private string name;
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            init
            {
                name = value;
            }
            
        }
        public Ques()
        {
            Name = "";
            Age = 0;

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            MapPoint m = new MapPoint();
            m.Mer = 700;
            m.SetPar(500);
            //Console.WriteLine(m.Mer);

            Ques first = new Ques();
            //first.Name = "Albert";
            first.Age = -5;
            Console.WriteLine(first.Age);
        }
    }

    class MapPoint
    {
        private double par;

        private double mer;
        public double Mer
        {
            get
            {
                return mer;
            }
            set
            {
                if (value < 0 || value > 360)
                {
                    mer = 0;
                }
                else
                    mer = value;
            }
        }

        public double GetPar()
        {
            return par;
        }
        public void SetPar(double par)
        {
           /* for (int i = 10 - 1; i >= 0; i--)
                Console.WriteLine("hi");
           */


            if (par >= -90 && par <= 90)
                this.par = par;
            this.par += 1;

            if (par >= -90 && par <= 90)
            { this.par = par; }

        }


    }
}