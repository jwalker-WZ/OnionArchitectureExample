using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    //Base entity that is used by all other entities.
    public class IEntity
    {
        //This is used as the primary key for entities.
        public int Id { get; set; }
    }
}
