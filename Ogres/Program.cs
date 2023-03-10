using System;
using OgresKoffiEmmanuel;
using OgresKoffiEmmanuel.Modeles;

public class Program
{
   
    

    public static void Main(string[] args)
    {
        CuisineContext context = new();
       
        List<Ogres> listOgre = new List<Ogres>();
        Ogres ogre1 = new Ogres("Gaspard");
        Ogres ogre2 = new Ogres("Yebark");
        Ogres ogre3 = new Ogres("Xeek");
        listOgre.Add(ogre1);
        listOgre.Add(ogre2);
        listOgre.Add(ogre3);

       
         Task to1 = Task.Run(ogre1.MangerLePlat);
        Task to2= Task.Run(ogre2.MangerLePlat);
        Task to3=Task.Run(ogre3.MangerLePlat);
        Task.WaitAll(to1, to2, to3);

      
      





    }


}

