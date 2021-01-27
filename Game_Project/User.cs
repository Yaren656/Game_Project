using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Project
{
    public abstract class User : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string TCNo { get; set; }
    }
}
