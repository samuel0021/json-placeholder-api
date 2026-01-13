using JsonPlaceholderApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPlaceholderApi.DisplayMethods
{
    public class UserMethods
    {
        public void DisplayUsers(List<User> users)
        {
            Console.WriteLine($"Total de users: {users.Count}");

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"ID: {users[i].Id}");
                Console.WriteLine($"Name: {users[i].Name}");
                Console.WriteLine($"UserName: {users[i].UserName}");
                Console.WriteLine($"Email: {users[i].Email}\n");

                Console.WriteLine($"Address:");
                Console.WriteLine($"    Street: {users[i].Address.Street}");
                Console.WriteLine($"    Suite: {users[i].Address.Suite}");
                Console.WriteLine($"    City: {users[i].Address.City}");
                Console.WriteLine($"    Zipcode: {users[i].Address.Zipcode}\n");

                Console.WriteLine($"    Geo:");
                Console.WriteLine($"        Lat: {users[i].Address.Geo.Lat}");
                Console.WriteLine($"        Lng: {users[i].Address.Geo.Lng}\n");

                Console.WriteLine($"Company:");
                Console.WriteLine($"    Name: {users[i].Company.Name}");
                Console.WriteLine($"    CatchPhrase: {users[i].Company.CatchPhrase}");
                Console.WriteLine($"    Bs: {users[i].Company.Bs}\n");

                Console.WriteLine($"Phone: {users[i].Phone}");
                Console.WriteLine($"Website: {users[i].Website}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
