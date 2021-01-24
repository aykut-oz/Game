using GalaxyReederGame.Interfaces;
using GalaxyReederGame.Interfaces.Class;
using GalaxyReederGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyReederGame.AppServices
{
    class UserService : IUserService
    {
        public long CreateAndReturnUserId(UserBase user)
        {
            if (user.Email!=""||user.Email!=null)
            {
                Console.WriteLine(user.Email+" User Added");
                
                return 1;
            }
            else
            {
                return 0;
            }
           

        }

        public void Delete(long userId)
        {
            if (userId>0)
            {
                Console.WriteLine("User Deleted");
            }
            else
            {
                Console.WriteLine("User Not Deleted");
            }
        }

        public void GetUser(long userId)
        {
            if (userId>0)
            {
                //dbden userId üzerinden dönen bilgileri yazdırırız.
                Console.WriteLine("User Informations:.......");
            }
        }

        public void List(List<UserBase> users)
        {
            int count = 1;
            foreach (var user in users)
            {

                Console.WriteLine(count + " "+ user +" Listened");
                count++;
            }
        }

        public void Update(UserBase user)
        {
            
            Console.WriteLine("Successfull! "+user + " Updated");
        }
    }
}
