using Business.Concrete;
using Entities.Concrete;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            Person person1 = new Person();
            person1.FirstName = "sinan";
            person1.LastName = "nalçacı";
            person1.DateOfBirthYear=1985;
            person1.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



        }
    }
}