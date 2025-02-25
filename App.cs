using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Beauty_Game;

internal class App
{
    public void Run()
    {
        
    }

    public void RndCislaLidi() 
    {
 
        for (int i = 0; i < 20; i++)
        {

            i++;
        }
    }
     public void random()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rnd.Next(0, 100));
        }
    }
}
