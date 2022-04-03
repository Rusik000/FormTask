using FormTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTask.FakeRepo
{
    public class UserRepo
    {
        public static List<User> Users { get; set; } = new List<User>
        {
                new User
                {
                    Id=1,
                    Name="Ruslan",
                    Surname="Mustafayev",
                    ImagePath="1.jpeg",
                    Age=21
                },
                new User
                {
                    Id=2,
                    Name="Kamran",
                    Surname="Aliyev",
                    ImagePath="2.jpeg",
                    Age=24
                },
                new User
                {
                    Id=3,
                    Name="Huseyn",
                    Surname="Rustemli",
                    ImagePath="3.jpeg",
                    Age=21
                }
        };
    }
}
