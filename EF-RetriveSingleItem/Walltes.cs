using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RetriveSingleItem
{
    internal class Walltes
    {

        public int Id { get; set; } 
        
        public string Holder { get; set; }

        public decimal Balance { get; set; }

        public override string ToString()
        {
            return $" id [{Id}] , Hloder [{Holder}] , balance [{Balance}]"; 
        }



    }
}
