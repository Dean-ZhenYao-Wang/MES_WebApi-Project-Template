using System.Collections.Generic;

namespace Util
{
    /// <summary>
    /// 数据表格分页
    /// </summary>
    public class Pagination
    {
        private string sortType = "asc";

        #region 默认方案

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 每页行数
        /// </summary>
        public int PageRows { get; set; } = int.MaxValue;

        /// <summary>
        /// 排序列
        /// </summary>
        public string SortField { get; set; } = "Id";

        /// <summary>
        /// 排序类型
        /// </summary>
        public string SortType { get => sortType; set => sortType = (value ?? string.Empty).Contains("desc") ? "desc" : "asc"; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                int pages = Total / PageRows;
                pages = Total % PageRows == 0 ? pages : pages + 1;
                return pages;
            }
        }

        #endregion 默认方案

        #region AntdVue方案

        public AjaxResultPage<List<T>> BuildTableResult_AntdVue<T>(List<T> dataList)
        {
            return new AjaxResultPage<List<T>> { Data = dataList, Success = true, Pagination = this, Msg = "操作成功!" };
        }

        #endregion AntdVue方案
    }
}