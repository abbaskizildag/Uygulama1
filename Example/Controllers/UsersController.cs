using Example.Fake;
using Example.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Example.Controllers
{
    [Route("api/[controller]")] //burada direk'de route yapabiliriz. ama controller dersek ilgili controller' yönlendiriyoruz.
    public class UsersController:ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(100);

        [HttpGet] //get request'leri için çalışıcak
        public List<User> Get() //metot string olursa return o türden olmalı
        {//eğer metodu list türünden döndürürsün list tipinde değişken dönmeli
            
            return _users;
        }
        [HttpGet("{id}")] //bu da httpget requestleri ile çalışıcak. ayrıca id ile alacak. güzel parantez içinde yazdık.
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id); //çift eşittir var
            return user;
        }
        //şimdi çalıştırınca iki metot olduğundan program çalıştırmadı. tek metot olunca otomatik çalıştırıyor.

        [HttpPost] //post requesti olacak.
        public User Post ([FromBody]User user)
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editedUser = _users.FirstOrDefault(x => x.Id == user.Id); //user'ı bulduk.
            editedUser.FirstName = user.FirstName; //adını değiştirmiştir eşitledik
            editedUser.LastName = user.LastName; // soyadını değiştirmiştir eşitledik.
            editedUser.Address = user.Address; //adresi değiştirmiştir eşitledik.
            return user;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deletedUser = _users.FirstOrDefault(x => x.Id == id); //user'ı bulduk.
            _users.Remove(deletedUser); //silindi yukarıda bulduğum id'li kayıt.
        }

    }
}
