using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public class KampanyaManager :IManagerService<Kampanyalar>
    {
        public void Add(Kampanyalar input)
        {
            Console.WriteLine("Yeni kampanya eklendi: " + input.KampanyaName);
        }

        public void Delete(int ID)
        {
            Console.WriteLine("Kampanya silindi : " + ID);
        }

        public void Update(Kampanyalar input)
        {
            Console.WriteLine(input.KampanyaName + " güncellendi.");
        }
    }
}
