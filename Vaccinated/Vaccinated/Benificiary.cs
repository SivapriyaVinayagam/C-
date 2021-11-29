using Vaccinated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccinated
{
    class Benificiary 
    {
        public int RegNo { get; set; }
        public string Name { get; set; }
        public double MobNo { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Gendr gender { get; set; }
        private DateTime DueDate { get; set; }
        

        public List<VaccineDetails> VD { get; set; }
       
    
    }
   


    public enum Gendr
    {
        Male = 1,
        Female,
        Transgender
    }
   
}


