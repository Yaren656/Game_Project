using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public class UserManager : PlayerCheckManager, IManagerService<User>
    {

        public void Add(User input)
        {
            Console.WriteLine("Oyuncu güncellendi : " + input.FirstName + " " + input.LastName);
        }

        public void Delete(int Id)
        {
            Console.WriteLine(Id + " numaralı oyuncu silindi.");
        }

        public void Update(User input)
        {
            Console.WriteLine(input.FirstName + " " + input.LastName + "kullanıcısı güncellendi");
        }
        //public bool Check(User user)
        //{
        //    return playerCheckManager.Check(user);
        //}
    }
}
