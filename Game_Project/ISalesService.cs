using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public interface ISalesService<T>:IManagerService<T>
    {
        public void Add(T input, Kampanyalar kampanyalar);
    }
}
