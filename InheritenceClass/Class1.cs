using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceClass
{
    class Chef
    {
        public void MakeRajma()
        {
            Console.WriteLine("Chef makes Rajma");
        }
        public void MakeChicken()
        {
            Console.WriteLine("Chef makes Chicken");
        }
        public virtual void ChefSpecial()
        {
            Console.WriteLine("Chef makes best Rajma");
        }

    }

    class IndianChef : Chef
    {
        public void MakeNaan()
        {
            Console.WriteLine("Chef makes Aloo Naan");
        }

        public void MakePavBhaji()
        {
            Console.WriteLine("Chef makes PavBhaji");
        }

        public override void ChefSpecial()
        {
            Console.WriteLine("Chef makes best PavBhaji");
        }
    }

    class SouthIndianChef : IndianChef
    {
        public void MakeIdli()
        {
            Console.WriteLine("Chef makes Idli");
        }

        public void MakeDosa()
        {
            Console.WriteLine("Chef make Dosa");
        }
        public virtual void ChefSpecial()
        {
            Console.WriteLine("Chef makes best Masala Dosa");
        }
    }
}
