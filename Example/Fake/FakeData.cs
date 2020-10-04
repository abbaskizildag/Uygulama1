using Bogus;
using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int number) //dışardan sayı alsın
        {
            if (_users==null) //burada users'ı kontrol ediyoruz. eğer üretildiyse aynı ürünü devamke. 
            {
                _users = new Faker<User>() //user türünden data oluştur dedik. Faker bogus'un bir metodu
                .RuleFor(u => u.Id, f => f.IndexFaker + 1) //benim user'ım ID'si için şöyle bir fakedata istiyorum
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .Generate(number); //dışarıdan gelen sayı kadar üretsin
            }
            
            return _users;
        }

    }
}
