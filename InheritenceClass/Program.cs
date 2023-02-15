using InheritenceClass;
using System;

class InharitanceExample
{    public static void Main(string[] args)
    {
        Chef vikram = new Chef();
        vikram.MakeChicken();
        vikram.MakeRajma();
        vikram.ChefSpecial();

        IndianChef Ram = new IndianChef();
        Ram.MakeChicken();
        Ram.MakeRajma();
        Ram.MakeNaan();
        Ram.ChefSpecial();

        SouthIndianChef RamaRaju = new SouthIndianChef();
        RamaRaju.MakeNaan();
        RamaRaju.ChefSpecial();
        RamaRaju.MakeRajma();

    }
}
