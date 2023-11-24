using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Otobus:Tasit
    {
       
        
        //ortak olmayanlar
        public int AyaktaYolcuAdedi { get; set; }
        public bool EngelliRampasi { get; set; }

    }

}
