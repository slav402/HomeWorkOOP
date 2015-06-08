using System;
using System.Collections.Generic;
using System.Linq;

class PCCatalog
{
    static void Main()
    {
        List<Computer> pcCatalog = new List<Computer>();
        List<Components> pcComponentsL = new List<Components>();
        pcComponentsL.Add(new Components("CPU: ", "Intel® Core™i5 - 2520M 2,50GHz", 142.99m));
        pcComponentsL.Add(new Components("RAM: ", "4GB DDR3", 57.99m));
        pcComponentsL.Add(new Components("HDD: ", "320GB SATA", 89.99m));
        //Computer lenovo = new Computer("Lenovo T410", pcComponentsL);

        List<Components> pcComponentsT = new List<Components>();
        pcComponentsT.Add(new Components("CPU: ", "Intel® Core™i3 - 2,20GHz", 99.99m));
        pcComponentsT.Add(new Components("RAM: ", "4GB DDR2", 38.99m));
        pcComponentsT.Add(new Components("HDD: ", "520GB SATA", 139.99m));
        //Computer toshiba = new Computer("Toshiba TECRA 10C", pcComponentsT);

        List<Components> pcComponentsS = new List<Components>();
        pcComponentsS.Add(new Components("CPU: ", "Intel® Core™i7 - 2520M 2,60GHz", 169.99m));
        pcComponentsS.Add(new Components("RAM: ", "8GB DDR3", 108.99m));
        pcComponentsS.Add(new Components("HDD: ", "1TB SSD", 138.99m));
        //Computer sony = new Computer("SONY VAIO", pcComponentsS);

        //pcCatalog.Add(lenovo);
        //pcCatalog.Add(toshiba);
        //pcCatalog.Add(sony);

        pcCatalog.Add(new Computer("Lenovo T410", pcComponentsL));
        pcCatalog.Add(new Computer("Toshiba TECRA 10C", pcComponentsT));
        pcCatalog.Add(new Computer("SONY VAIO", pcComponentsS));

        var sortCatalog = pcCatalog.OrderBy(compPrice => compPrice.Price);

        foreach (var comp in sortCatalog)
        {
            Console.WriteLine(comp);
        }
    }
}

