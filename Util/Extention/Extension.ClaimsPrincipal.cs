using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Util
{
    public static partial class Extension
    {
        /// <summary>
        /// 从指定主体获取用户ID。
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static bool GetUserID(this ClaimsPrincipal user, out Guid userID)
        {
            if (user.GetPropertyValue(ClaimTypes.NameIdentifier) is string userIdStr &&
                Guid.TryParse(userIdStr, out userID))
            {
                return true;
            }
            else
            {
                userID = Guid.Empty;
                return false;
            }
        }
    }
}
