using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Shop
{
    // public string Image { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return string.Format("{0}  {1} (kost: {2})", Name, Description, Price);
    }

    public static List<product> getAll()
    {
        return new List<product>()
        {
            new product()
            {
                Name = "Hamburger",
                Description = "Hamburger met Sla, Tomaat en augurk",
                Price = "5,-"
                
            },
        };

    }

}