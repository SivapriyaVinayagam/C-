using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccinated
{
    class Program
    {
        static void Main(string[] args)
        {

            string Option1 = "";

            Console.WriteLine(" ***************WELCOME TO VACCINATE *************");
            List<Benificiary> Details = new List<Benificiary>();
            Benificiary Person1 = new Benificiary();
            Person1.RegNo = 1001;
            Person1.Name = "Siva";
            Person1.MobNo = 8072978317;
            Person1.City = " Ettayapuram";
            Person1.Age = 23;
            Person1.gender = (Gendr)1;

            Details.Add(Person1);

            Benificiary Person2 = new Benificiary();
            Person2.RegNo = Person1.RegNo + 1;
            Person2.Name = "priya";
            Person2.MobNo = 8072977653;
            Person2.City = " Kovilpatti";
            Person2.Age = 21;
            Person2.gender = (Gendr)2;
            Details.Add(Person2);

            do
            {

                Console.WriteLine(" Enter What Do You Need :\n  1.Benificiary Registration \n   2.Vaccination\n  3.Exit ");
                int Purpose = int.Parse(Console.ReadLine());
                if (Purpose == 1)
                {

                    int i = 2;
                    Benificiary Person3 = new Benificiary();

                    Console.Write(" Enter Your Name : ");
                    Person3.Name = Console.ReadLine();
                    Console.Write("Enter Your MobNo : ");
                    Person3.MobNo = double.Parse(Console.ReadLine());
                    Console.Write("Enter Your City : ");
                    Person3.City = Console.ReadLine();
                    Console.Write("Enter Your Age : ");
                    Person3.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your gender :\n 1.Male \n 2.Female\n 3.Transgender\n ");
                    Person3.gender = (Gendr)int.Parse(Console.ReadLine());
                    int regno = Person1.RegNo + i;
                    Console.WriteLine("  Your RegNo is :{0} ", regno);
                    Person3.RegNo = regno;
                    Details.Add(Person3);

                    foreach (Benificiary People in Details)

                    {
                        Console.WriteLine("RegNo :{0}   Name :{1}  Age : {2}   gender :{3}  MobNo :{4}  city : {5}", People.RegNo, People.Name, People.Age, People.gender, People.MobNo, People.City);
                        Console.WriteLine("*********************************************************************************");

                    }

                }
                if (Purpose == 2)
                {
                    Console.WriteLine("Enter Your RegNo : ");
                    int RegNo = int.Parse(Console.ReadLine());
                    foreach (Benificiary reg in Details)
                    {

                        if (RegNo == reg.RegNo)
                        {
                            Console.WriteLine("1.Take Vaccination\n 2.Vaccination History\n 3.Next Due Date\n 4.Exit");
                            int Vaccination = int.Parse(Console.ReadLine());
                        }
                    }
                }


            } while (Option1 =="yes");
        }





    }
}


                          /*  if (Vaccination == 1)
                            {
                                Console.WriteLine(" Which Type of Vaccination Do You  Want :\n 1.Covaxin \n 2.Covishield ");
                               
                                VaccineDetails vaccine = new VaccineDetails();
                                vaccine.vaccineType = (VaccineName)int.Parse(Console.ReadLine());
                                if (Details.VD == null)
                                {
                                    Details.VD = new List<VaccineDetails>();

                                }
                                Details.VD.Add(vaccine);
 
                            }
                            if(Vaccination == 2)
                            {
                                VaccinationHistory(RegNo);

                            }
                            if(Vaccination == 3)
                            {
                                DueDate(RegNo);
                                
                            }
                            if(Vaccination == 4)
                            {
                                break;
                            }
                           

                        }
                    
                        
                    }
                }
                Console.WriteLine(" Do You Want Continue :Yes/No ");
                Option1 = Console.ReadLine();

            } while (Option1 == "Yes");


            Console.ReadKey();
        }
        public void VaccinationHistory(int Regno)
        {
            foreach(Benificiary details in Details)
            {
                if(details.RegNo == Regno)
                {
                    if(details.VD != null)
                    {
                        Console.WriteLine($"Name :{details.Name}\n" + $"Age :{details.Age}\n" + $"Gender :{details.gender}\n" + $"MobNo :{details.MobNo}\n" + $"City :{details.City}\n" + $"Vaccination :{details.VD[0].vaccineType}");

                    }
                }
            }
        }
        public void DueDate(int RegNo)
        {
            foreach(Benificiary details in Details)
            {
                if (details.RegNo == RegNo)
                {
                    if(details.VD != null)
                    {
                        Console.WriteLine($"Next Vaccine Due :{details.VD[0].vaccineType}");
                        Console.WriteLine($"DueDate :{details.VD[0].Date.AddDays(30)}");
                    }
                    else if (details.VD.Count == 2)
                    {
                        Console.Write("You Are Completed Vaccination Course");
                    }
                }
            }
           
        }
    }
}*/
