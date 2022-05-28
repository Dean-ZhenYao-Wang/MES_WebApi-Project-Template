using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BaseDB
{
    public partial class 用户
    {
        public void 修改登录用户名(string accountNumber)
        {
            登录用户名 = accountNumber;
        }

        public void 修改密码(string passWord)
        {
            密码 = passWord;
        }

        public void 修改昵称(string name)
        {
            昵称 = name;
        }

        public void 修改用户信息(string accountNumber, string passWord, string name, List<string> list_OrgId, List<string> list_RoleId)
        {
            修改登录用户名(accountNumber);
            修改密码(passWord);
            修改昵称(name);
            var list_OldOrg = 所属的组织列表
               .Where(m => m.IsDelete == false && m.用户Key.Equals(Key))
               .ToList();

            if (list_OrgId == null || !list_OrgId.Any())
            {
                if (list_OldOrg.Any())
                {
                    list_OldOrg.ForEach(m =>
                    {
                        m.删除();
                    });
                }
            }
            else
            {
                list_OrgId.ForEach(orgId =>
                {
                    if (!list_OldOrg.Where(m => m.组织Key.Equals(orgId)).Any())
                    {
                        var r_x_o = new BaseDB.用户_组织()
                        {
                            Key = Guid.NewGuid().ToString(),
                            用户Key = Key,
                            组织Key = orgId
                        };
                        r_x_o.记录创建人及创建时间();
                        所属的组织列表.Add(r_x_o);
                    }
                });

                var list_DeleteOrg = list_OldOrg.Where(m => !list_OrgId.Contains(m.组织Key)).ToList();
                list_DeleteOrg.ForEach(m =>
                {
                    m.删除();
                });
            }

            var list_OldRole = 拥有的角色列表
                .Where(m => m.IsDelete == false && m.用户Key.Equals(Key))
                .ToList();

            if (list_RoleId == null || !list_RoleId.Any())
            {
                if (list_OldRole.Any())
                {
                    list_OldRole.ForEach(m =>
                    {
                        m.删除();
                    });
                }
            }
            else
            {
                List<BaseDB.用户_角色> list_AddRole = new List<BaseDB.用户_角色>();
                list_RoleId.ForEach(roleId =>
                {
                    if (!list_OldRole.Where(m => m.角色Key.Equals(roleId)).Any())
                    {
                        var r_x_r = new BaseDB.用户_角色()
                        {
                            Key = Guid.NewGuid().ToString(),
                            用户Key = Key,
                            角色Key = roleId
                        };
                        r_x_r.记录创建人及创建时间();
                        拥有的角色列表.Add(r_x_r);
                    }
                });

                var list_DeleteRole = list_OldRole.Where(m => !list_RoleId.Contains(m.角色Key)).ToList();
                list_DeleteRole.ForEach(m =>
                {
                    m.删除();
                });
            }
        }

        public override void 删除()
        {
            var listRole = 拥有的角色列表.Where(m => m.IsDelete == false && m.用户Key.Equals(Key)).ToList();
            listRole.ForEach(m =>
            {
                m.删除();
            });
            var listOrg = 所属的组织列表.Where(m => m.IsDelete == false && m.用户Key.Equals(Key)).ToList();
            listOrg.ForEach(m =>
            {
                m.删除();
            });
            base.删除();
        }
    }
}