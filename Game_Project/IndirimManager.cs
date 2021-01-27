using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public class IndirimManager :Indirimler
    {
        public void Add(Indirimler input)
        {
            Console.WriteLine("Oyun " + input.Price +"fiyatı ile" + input.user.FirstName + "'e satıldı. ");
        }


        public void Delete(int Id)
        {
            Console.WriteLine("Oyun silindi");
        }

        public void Update(Indirimler input)
        {
            Console.WriteLine("İndirim güncellendi.");
        }

      
    }
}
