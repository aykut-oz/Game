using GalaxyReederGame.AppServices;
using GalaxyReederGame.Interfaces;
using GalaxyReederGame.Interfaces.Service;
using GalaxyReederGame.Models;
using System;

namespace GalaxyReederGame
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = 1;
            IIdentityVerificationService ıdentityVerificationService = new IdentityVerificationService();
            IAuthorizationService authorizationService = new AuthorizationService();
            IUserService userService = new UserService();
            IGameService gameService = new GameService();
              
            //New gamer
            Gamer gamer = new Gamer { RegisterNumber = Guid.NewGuid().ToString().Substring(0, 10), Email = "test@test.com", Avatar = "~/Images/avatar.ico", FirstName = "ad", LastName = "soyad", CreationTime = DateTime.Now, Id = count, IsActive = true, IsEmailVerification = false, ModificationTime = null, NickName = "Gamer1", Password = "pass1234.", BirthYear = 1991, IdentityNumber = "1111111111", JoinCampaignCount = 0, MembershipDate = DateTime.Now };

            Game game = new Game { CurrencyId = 1, GameType = "Actin", Id = 1, IsAutomaticSale = false, Name = "LOTR", PosterUrl = "~/Images/lotr.png", ReleaseDate = DateTime.Now.Date, SalePrice = 299, Size = 10024 };

            gameService.Create(game);

            // not> ad-soyad-doğum yılı ve kimlik numaranızı girerek bu aşamayı geçebilirsiniz. örnek verilerden dolayı false döner.
            if (gamer.IdentityNumber.Length == 11)
            {
                var returnIdentityControl = ıdentityVerificationService.TCQuery(gamer.FirstName, gamer.LastName, gamer.IdentityNumber, 1992);
                if (returnIdentityControl)//tc kimlik no doğrulandı
                {
                    var returnUserId = userService.CreateAndReturnUserId(gamer);
                    if (returnUserId > 0)
                        authorizationService.AddUserAuthorization(returnUserId, "BasicGamer"); //yetkilendirme veriyoruz.

                    Console.WriteLine("********************");
                    Console.WriteLine("1-)Sale\n2-ApplyCampaign)");
                    Console.WriteLine("************************");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Game " + game.Name + " sold for " + gamer.Email);
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("********************");
                        Console.WriteLine("1-)%10\n2-%20)");
                        Console.WriteLine("************************");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            var result = game.SalePrice-((game.SalePrice * 10) / 100);
                            Console.WriteLine("%10 Discount applied for {0}", game.Name);
                            Console.WriteLine("Sale Amount {0}", result);
                        }
                        else if (choice2 == 2)
                        {
                            var result = game.SalePrice-((game.SalePrice * 20) / 100);
                            Console.WriteLine("%20 Discount applied for {0}", game.Name);
                            Console.WriteLine("Sale Amount {0}", result);
                        }

                    }



                }
                else
                {
                    Console.WriteLine("Your IdentityNumber could not be verified");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Your IdentityNumber length short or long than 11");
            }


        }
    }
}
