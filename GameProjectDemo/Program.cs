using GameProjectDemo.Entities;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;

using System;

namespace GameProjectDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                FirstName = "Anıl",
                LastName = "Altunyurt",
                DateOfBirth = new DateTime(1997, 9, 9),
                Id = 1,
                NationalityId = "17830650268"

            };

            GamerManager.Add(gamer);
            

            

            
        }
    }
}
//BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
//customerManager.Save(new Customer { DateOfBirth = new DateTime(1997, 1, 6), FirstName = "Anıl", LastName = "Altunyurt", NationalityId = "17830650268" });
//Console.ReadLine();