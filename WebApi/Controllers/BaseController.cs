using IRepository_DB;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ValidateModel]
    [FormatResponse]
    public class BaseController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;
        public readonly dynamic CurrentLoginUser;

        public BaseController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
            CurrentLoginUser = HttpContextHelper.CurrentLoginUser;
        }

        /// <summary>
        /// 返回JSON
        /// </summary>
        /// <param name="jsonStr">json字符串</param>
        /// <returns></returns>
        protected ContentResult JsonContent(string jsonStr)
        {
            return base.Content(jsonStr, "application/json", Encoding.UTF8);
        }

        /// <summary>
        /// 返回html
        /// </summary>
        /// <param name="body">html内容</param>
        /// <returns></returns>
        protected ContentResult HtmlContent(string body)
        {
            return base.Content(body);
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        /// <returns></returns>
        protected AjaxResult Success()
        {
            AjaxResult res = new AjaxResult
            {
                Success = true,
                Msg = "请求成功！",
            };

            return res;
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        /// <param name="data">返回数据</param>
        /// <returns></returns>
        protected AjaxResult<T> Success<T>(T data)
        {
            AjaxResult<T> res = new AjaxResult<T>
            {
                Success = true,
                Msg = "操作成功",
                Data = data
            };

            return res;
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        /// <param name="data">返回数据</param>
        /// <param name="msg">返回消息</param>
        /// <returns></returns>
        protected AjaxResult<T> Success<T>(T data, string msg)
        {
            AjaxResult<T> res = new AjaxResult<T>
            {
                Success = true,
                Msg = msg,
                Data = data
            };

            return res;
        }

        /// <summary>
        /// 返回错误
        /// </summary>
        /// <returns></returns>
        protected AjaxResult Error()
        {
            AjaxResult res = new AjaxResult
            {
                Success = false,
                Msg = "请求失败！",
            };

            return res;
        }

        /// <summary>
        /// 返回错误
        /// </summary>
        /// <param name="msg">错误提示</param>
        /// <returns></returns>
        protected AjaxResult Error(string msg)
        {
            AjaxResult res = new AjaxResult
            {
                Success = false,
                Msg = msg,
            };

            return res;
        }

        /// <summary>
        /// 返回表格数据
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="list">数据列表</param>
        /// <returns></returns>
        protected AjaxResult<List<T>> DataTable<T>(List<T> list)
        {
            return DataTable(list, new Pagination());
        }

        /// <summary>
        /// 返回表格数据
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="list">数据列表</param>
        /// <param name="pagination">分页参数</param>
        /// <returns></returns>
        protected AjaxResult<List<T>> DataTable<T>(List<T> list, Pagination pagination)
        {
            return pagination.BuildTableResult_AntdVue(list);
        }

        protected void Save()
        {
            unitOfWork.Save();
        }

        protected async Task SaveAsync()
        {
            await unitOfWork.SaveAsync();
        }

        protected async Task Publish(INotification eventObj)
        {
            await mediator.Publish(eventObj);
        }
    }
}