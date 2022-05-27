using System;
using System.ComponentModel.DataAnnotations;

namespace Util.Model
{
    public class Base_Entity
    {
        private bool isDelete = false;
        private string createUser;
        private DateTime createDate;
        private string updateUser;
        private DateTime? updateDate;
        private string remark;

        /// <summary>
        /// 是否删除
        /// </summary>
        [Required]
        [System.ComponentModel.Description("是否删除")]
        public bool IsDelete { get => isDelete; private set => isDelete = value; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        [Required]
        [System.ComponentModel.Description("创建人Id")]
        public string CreateUser { get => createUser; set => createUser = value; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        [System.ComponentModel.Description("创建日期")]
        public DateTime CreateDate { get => createDate; set => createDate = value; }

        /// <summary>
        /// 修改人Id
        /// </summary>
        [System.ComponentModel.Description("修改人Id")]
        public string UpdateUser { get => updateUser; set => updateUser = value; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [System.ComponentModel.Description("修改日期")]
        public DateTime? UpdateDate { get => updateDate; set => updateDate = value; }

        /// <summary>
        /// 备注
        /// </summary>
        [System.ComponentModel.Description("备注")]
        public string Remark { get => remark; set => remark = value; }

        /// <summary>
        /// 删除的同时会记录修改人及修改时间
        /// </summary>
        /// <param name="updateUser"></param>
        public virtual void 删除()
        {
            IsDelete = true;

            记录修改人及修改时间();
        }

        public virtual void 记录创建人及创建时间()
        {
            this.CreateUser = HttpContextHelper.CurrentLoginUser.Key;
            this.CreateDate = DateTime.Now;
            this.UpdateUser = this.CreateUser;
            this.UpdateDate = this.CreateDate;
        }

        public virtual void 记录修改人及修改时间()
        {
            this.UpdateUser = HttpContextHelper.CurrentLoginUser.Key;
            this.UpdateDate = DateTime.Now;
        }
    }
}