using System;

namespace Game_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IndirimManager ındirimManager = new IndirimManager();
            Games game = new Games { Id = 3, GameName = "COD" };
            Kampanyalar kampanyalar = new Kampanyalar { Id = 2, KampanyaName = "öğrenci indirimi" };
            User gamer = new Gamer { ID = 4, FirstName = "Yaren", LastName = "Yuvka", TCNo = "3674729308" };
            Indirimler sales = new Indirimler();
            sales.Id = 3;
            sales.games = game;
            sales.Price = 120;
            sales.user = (Gamer)gamer;
            Console.WriteLine ( gamer.FirstName + " " + game.GameName + " oyununu " + kampanyalar.KampanyaName + " ile " + sales.Price + "TL'ye satın aldı");
            
        }
    }
}
