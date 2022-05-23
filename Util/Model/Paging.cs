using System;

namespace Util.Model
{
    public class Paging
    {
        /// <summary>
        /// 当前第几页
        /// </summary>
        public int? PageIndex { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// 本页有多少条
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 一共有多少条
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 分为多少页
        /// </summary>
        public int TotalPages => PageSize > 0 ? (int)Math.Ceiling(TotalCount / (decimal)PageSize.Value) : 0;

        /// <summary>
        /// 是否有前一页
        /// </summary>
        public bool HasPreviousPage => PageIndex - 1 > 0;

        /// <summary>
        /// 是否有后一页
        /// </summary>
        public bool HasNextPage => TotalPages > 0 && PageIndex + 1 <= TotalPages;
    }
}