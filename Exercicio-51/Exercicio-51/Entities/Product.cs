using System.Globalization;

namespace Exercicio_51.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InstalledUICulture);
        }


    }
}
