using System.Collections.Generic;

namespace Util.Model
{
    public interface IPagedList<T>
    {
        /// <summary>
        /// 当前第几页
        /// </summary>
        int PageIndex { get; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        int PageSize { get; }

        /// <summary>
        /// 本页有多少条
        /// </summary>
        int Count { get; set; }

        /// <summary>
        /// 一共有多少条
        /// </summary>
        int TotalCount { get; }

        /// <summary>
        /// 分为多少页
        /// </summary>
        int TotalPages { get; }

        /// <summary>
        /// 是否有前一页
        /// </summary>
        bool HasPreviousPage { get; }

        /// <summary>
        /// 是否有后一页
        /// </summary>
        bool HasNextPage { get; }

        /// <summary>
        /// 本页的数据
        /// </summary>
        IList<T> Items { get; }
    }
}