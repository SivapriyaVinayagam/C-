using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccinated
{
    class VaccineDetails
    {

        public VaccineName vaccineType { get; set; }
        
        public  DateTime Date { get; set; }
       public VaccineDetails(VaccineName vaccineType,DateTime Date)
        {
            this.vaccineType = vaccineType;
            this.Date = Date;
        }
       
    }
   
    public enum VaccineName
    {
        Covaxin =1,
        Covishield
    }
   
  



}
