using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class PersonType
{


    /// <summary>
    /// There are no comments for 所属的组织列表 in the schema.
    /// </summary>
    public virtual IList<用户_组织> 所属的组织列表 { get; set; }

    /// <summary>
    /// 登录用户名
    /// </summary>
    public virtual string 登录用户名 { get; set; }

    /// <summary>
    /// There are no comments for 密码 in the schema.
    /// </summary>
    public virtual string 密码 { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    public virtual string 昵称 { get; set; }

    /// <summary>
    /// 性别。未知、男、女
    /// </summary>
    public virtual int? 性别 { get; set; }

    /// <summary>
    /// 邮件
    /// </summary>
    public virtual string 邮件 { get; set; }

    /// <summary>
    /// There are no comments for 手机 in the schema.
    /// </summary>
    public virtual string 手机 { get; set; }

    /// <summary>
    /// 代码。身份证、员工编号等
    /// </summary>
    public virtual string Code { get; set; }

    /// <summary>
    /// There are no comments for 头像 in the schema.
    /// </summary>
    public virtual string 头像 { get; set; }

    /// <summary>
    /// There are no comments for 年龄 in the schema.
    /// </summary>
    public virtual int? 年龄 { get; set; }

    /// <summary>
    /// There are no comments for 生日 in the schema.
    /// </summary>
    public virtual string 生日 { get; set; }
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
                    var r_x_o = new 用户_组织()
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
        };

        if (list_RoleId == null || !list_RoleId.Any())
        {
            if (PersonnelClassID.Any())
            {
                PersonnelClassID.Clear();
            }
        }
        else
        {
            list_RoleId.ForEach(roleId =>
            {
                if (!PersonnelClassID.Where(m => m.Value.Equals(roleId)).Any())
                {
                    var r_x_r = new IdentifierType()
                    {
                        Value = roleId,
                    };
                    PersonnelClassID.Add(r_x_r);
                }
            });

            PersonnelClassID.RemoveAll(m => !list_RoleId.Contains(m.Value));
        }
    }

    public override void 删除()
    {
        var listOrg = 所属的组织列表.Where(m => m.IsDelete == false && m.用户Key.Equals(Key)).ToList();
        listOrg.ForEach(m =>
        {
            m.删除();
        });
        base.删除();
    }

}