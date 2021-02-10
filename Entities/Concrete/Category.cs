using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    public class Category : Entity
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
