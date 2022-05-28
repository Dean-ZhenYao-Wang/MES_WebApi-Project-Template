using System;
using System.Linq;

namespace BaseDB
{
    public class DbInitializer
    {
        public static void Initialize(BaseDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.用户.Any())
            {
                return;
            }

            var adminKey = Guid.NewGuid().ToString();
            用户 admin = new 用户()
            {
                Key = adminKey,
                登录用户名 = "admin",
                密码 = "123456",
                昵称 = "超级管理员",
                CreateDate = DateTime.Now,
                CreateUser = Guid.Empty.ToString()
            };

            context.用户.Add(admin);
            context.SaveChanges();
        }
    }
}