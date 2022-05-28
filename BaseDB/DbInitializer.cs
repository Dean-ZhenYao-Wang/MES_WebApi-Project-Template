using System;
using System.Linq;

namespace BaseDB
{
    public class DbInitializer
    {
        public static void Initialize(BaseDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Peoples.Any())
            {
                return;
            }

            var adminKey = Guid.NewGuid().ToString();
            PersonType admin = new PersonType()
            {
                Key = adminKey,
                登录用户名 = "admin",
                密码 = "123456",
                昵称 = "超级管理员",
                CreateDate = DateTime.Now,
                CreateUser = Guid.Empty.ToString()
            };

            context.Peoples.Add(admin);
            context.SaveChanges();
        }
    }
}