using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public interface IManagerService<T>
    {
        public void Add(T input);
        public void Delete(int ID);
        public void Update(T input);
    }
}
