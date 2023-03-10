using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgresKoffiEmmanuel.Modeles;


namespace OgresKoffiEmmanuel
{
    public class Ogres
    {
        public CuisineContext context = new();
        private static readonly object verrou = new();
        private static readonly Random random = new();
        private string nomOgres { get; set; }
        private string NomPlat{ get; set; }
        private int Id { get; set; }
        private int nombreBouchees { get;set; }
        public List<Plat> _plats { get; set; }



        public Ogres()
        {

        }
        public Ogres(string _nomOgre)
        {
            nomOgres = _nomOgre;
            _plats = new List<Plat>();
        }





        public void MangerLePlat()
        {
      
           while(context.Plats.Count<Plat>()>0)
           {
               
                lock (verrou)
                {
                    var platAConserver=context.Plats.First<Plat>();
                    Id = platAConserver.PlatId;
                    NomPlat = platAConserver.NomPlat;
                    nombreBouchees = platAConserver.NombreBouchees;
                   context.Plats.Remove(platAConserver);
                    context.SaveChanges();
                }
               for(int i=0;i<nombreBouchees;i++)
                {
                    Thread.Sleep(50);
                    Console.WriteLine(nomOgres+" "+"Hummmm... C'est délicieux");
                    Console.WriteLine("Moi" + " " + nomOgres + " " + "mange" + NomPlat + " "+ "dont Id=" + Id);

                }
           }

        }        
    }
        
}
