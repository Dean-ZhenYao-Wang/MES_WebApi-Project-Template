namespace Util
{
    /// <summary>
    /// 错误返回实体
    /// </summary>
    public class ErrorResult : AjaxResult
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="errorCode">错误代码，默认为999999999</param>
        public ErrorResult(string msg = "操作失败!", int errorCode = 999999999)
        {
            Msg = msg;
            Success = false;
            ErrorCode = errorCode;
        }
    }
}