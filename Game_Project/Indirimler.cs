using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public class Indirimler : IEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public Gamer user { get; set; }
        public Games games { get; set; }
    }
}
