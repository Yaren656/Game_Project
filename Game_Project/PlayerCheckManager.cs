using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public class PlayerCheckManager : IManagerService<Gamer>
    {
        public void Add(Gamer input) => throw new NotImplementedException();

        public bool Check(User user)
        {
            if (user.FirstName == null && user.LastName == null && user.TCNo == null && user.YearOfBirth != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(int ID) => throw new NotImplementedException();
        public void Update(Gamer input) => throw new NotImplementedException();
    }
}
