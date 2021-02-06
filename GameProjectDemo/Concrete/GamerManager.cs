using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Başarıyla Eklendi" + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Adlı Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + ": Oyuncu Bilgileri Güncellendi");
        }
    }
}
