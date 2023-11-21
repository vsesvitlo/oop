namespace homework_05._10;
/*
 * 
 * . Гляньте в Шилда є розід "свойства и индексатри"
2. З книжки нової 228 сторінкаПоверніться, будь ласка, до класу літака і класу машин. 
 * Із них найбільш значущі, на Вашу думку, поля обгорнути властивостями. 
Так щоб властивості допомагали (наприклад кількість пального і сидінь не може бути менша 0).

Наприклад назва не може бути більша за 30 символів, що більше відрізає і тд..*/
namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MapPoint m = new MapPoint();
            m.Mer = 700;
            m.SetPar(500);
            Console.WriteLine(m.Mer);
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
            for (int i = 10 - 1; i >= 0; i--)
                Console.WriteLine("hi");



            if (par >= -90 && par <= 90)
                this.par = par;
            this.par += 1;

            if (par >= -90 && par <= 90)
            { this.par = par; }

        }


    }
}