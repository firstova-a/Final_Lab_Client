using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клиент
{
    public class Blog
    {
        public int Id { get; set; }
        public string Bird { get; set; }
        public string BirdInLatin { get; set; }
        public int Count { get; set; }
        public string Weather { get; set; }
        public string Place { get; set; }
        public string Comment { get; set; }
        public DateTime Time { get; set; }

        public string Picture { get; set; }
        public virtual Person Author { get; set; }
    }
    public enum UserRole
    {
        Admin = 0,
        Moderator = 1,
        User = 2
    }

    public class Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public string Avatar { get; set; }
    }

    public class MainModel
    {
        public string ErrorMessage { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
