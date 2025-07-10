using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{


    public interface ICarpet
    {
        string GetSku();

        string GetBrand();

        string ManufacturerCity();
    }

    public class BaseCarpet
    {
        public string Brand { get; set; }

        public string City { get; set; }
        public string Sku { get; set; }
    }

    public abstract class BaseFactory
    {
        public abstract ICarpet CreateCarpet();
    }

    public class TabrizCarpetFactory : BaseFactory
    {
        public override ICarpet CreateCarpet()
        {
            return new TabrizCarpet("amiri");
        }
    }

    public class TabrizCarpet : BaseCarpet, ICarpet
    {
        public TabrizCarpet(string brand)
        {
            this.Brand = brand;
            base.City = "Tabriz";
            base.Sku = $"{base.City}-{base.Brand}";

        }

        string ICarpet.GetBrand()
        {
            return Brand;
        }

        string ICarpet.GetSku()
        {
            return Sku;
        }

        string ICarpet.ManufacturerCity()
        {
            return City;
        }
    }

}
