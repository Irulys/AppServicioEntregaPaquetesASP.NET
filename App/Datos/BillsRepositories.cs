using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;

namespace App.Datos
{
    public class BillsRepositories
    {

            public IEnumerable<Bills> getBills()
            {
                List<Bills> data = new List<Bills>();


                Person send  = new Person();
                Person recib =  new Person();

                Package pg1 =  new Package("T123",send,recib,46.5,5000.0);
                Package pg2 =  new Package("T124",recib,send,26.5,4000.0);
                Package pg3 =  new Package("T125",send,recib,16.5,3000.0);

                Dictionary<Package, double> packages1 = new Dictionary<Package, double>();

                packages1.Add(pg1,pg1.calculateCost());
                packages1.Add(pg2,pg2.calculateCost());

               Dictionary<Package, double> packages2 = new Dictionary<Package, double>();

               packages2.Add(pg1,pg1.calculateCost());
               packages2.Add(pg3,pg3.calculateCost());

                Bills b1 = new Bills(new DateTime(), packages1);
                Bills b2 = new Bills(new DateTime(), packages2);

                data.Add(b1);
                data.Add(b2);

                return data;
            }

}