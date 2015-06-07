using System;
using System.Collections.Generic;

class PCCatalog
{
    static void Main()
    {
        List<Commputer> pcCatalog = new List<Commputer>();
        List<Components> pcComponentsL = new List<Components>();
        List<Components> pcComponentsT = new List<Components>();
        List<Components> pcComponentsS = new List<Components>();


        pcCatalog.Add(new Commputer("Lenovo T410", pcComponentsL));
        



    }
}

