using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Util.Model;

namespace Util
{
    public static partial class Extention
    {
        /// <summary>
        /// 复制序列中的数据
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="iEnumberable">原数据</param>
        /// <param name="startIndex">原数据开始复制的起始位置</param>
        /// <param name="length">需要复制的数据长度</param>
        /// <returns></returns>
        public static IEnumerable<T> Copy<T>(this IEnumerable<T> iEnumberable, int startIndex, int length)
        {
            T[] sourceArray = iEnumberable.ToArray();
            T[] newArray = new T[length];
            Array.Copy(sourceArray, startIndex, newArray, 0, length);

            return newArray;
        }

        /// <summary>
        /// 给IEnumerable拓展ForEach方法
        /// </summary>
        /// <typeparam name="T">模型类</typeparam>
        /// <param name="iEnumberable">数据源</param>
        /// <param name="func">方法</param>
        public static void ForEach<T>(this ICollection<T> iEnumberable, Action<T> func)
        {
            foreach (T item in iEnumberable)
            {
                func(item);
            }
        }

        /// <summary>
        /// 给IEnumerable拓展ForEach方法
        /// </summary>
        /// <typeparam name="T">模型类</typeparam>
        /// <param name="iEnumberable">数据源</param>
        /// <param name="func">方法</param>
        public static void ForEach<T>(this ICollection<T> iEnumberable, Action<T, int> func)
        {
            T[] array = iEnumberable.ToArray();
            for (int i = 0; i < array.Count(); i++)
            {
                func(array[i], i);
            }
        }

        /// <summary>
        /// IEnumerable转换为List'T'
        /// </summary>
        /// <typeparam name="T">参数</typeparam>
        /// <param name="source">数据源</param>
        /// <returns></returns>
        public static List<T> CastToList<T>(this Array source)
        {
            return new List<T>(source.Cast<T>());
        }

        /// <summary>
        /// 将IEnumerable'T'转为对应的DataTable
        /// </summary>
        /// <typeparam name="T">数据模型</typeparam>
        /// <param name="iEnumberable">数据源</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> iEnumberable)
        {
            return iEnumberable.ToJson().ToDataTable();
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="iEnumberable">数据源</param>
        /// <param name="pagination">分页参数</param>
        /// <returns></returns>
        public static IEnumerable<T> GetPagination<T>(this IEnumerable<T> iEnumberable, Pagination pagination)
        {
            return iEnumberable.AsQueryable().OrderBy($@"{pagination.SortField} {pagination.SortType}").Skip((pagination.PageIndex - 1) * pagination.PageRows).Take(pagination.PageRows).ToList();
        }

        public static PagedList<T> ToPagedList<T>(this IEnumerable<T> source, int pageIndex = 1, int pageSize = 20)
        {
            var data = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PagedList<T>(data.ToList(), pageIndex, pageSize, source.Count());
        }

        public static PagedList<T> ToPagedList<T>(this IList<T> source, int pageIndex = 1, int pageSize = 20)
        {
            var data = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PagedList<T>(data.ToList(), pageIndex, pageSize, source.Count);
        }

        public static PagedList<T> ToPagedList<T>(this List<T> source, int pageIndex = 1, int pageSize = 20)
        {
            var data = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PagedList<T>(data.ToList(), pageIndex, pageSize, source.Count);
        }

        public static PagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageIndex = 1, int pageSize = 20)
        {
            var data = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PagedList<T>(data.ToList(), pageIndex, pageSize, source.Count());
        }

        public static async Task<PagedList<T>> ToPagedListAsync<T>(this IQueryable<T> source, int pageIndex = 1, int pageSize = 20)
        {
            var data = source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PagedList<T>(await data.ToListAsync(), pageIndex, pageSize, await source.CountAsync());
        }

        public static TimeSpan Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, TimeSpan> selector)
        {
            return source.Select(selector).Sum();
        }

        public static decimal SumHour<TSource>(this IEnumerable<TSource> source, Func<TSource, TimeSpan> selector)
        {
            return source.Select(selector).SumHour();
        }

        public static decimal SumHour<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            return source.Select(selector).SumHour();
        }

        public static TimeSpan Sum(this IEnumerable<TimeSpan> source)
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            foreach (TimeSpan item in source)
            {
                timeSpan += item;
            }
            return timeSpan;
        }

        public static decimal SumHour(this IEnumerable<TimeSpan> source)
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            foreach (TimeSpan item in source)
            {
                timeSpan += item;
            }
            decimal hour = (timeSpan.Days * 24) + timeSpan.Hours + (timeSpan.Minutes / 60) + (timeSpan.Seconds / 3600);
            return Math.Round(hour, 2, MidpointRounding.AwayFromZero);
        }

        public static decimal SumHour(this IEnumerable<decimal> source)
        {
            decimal hour = 0;
            foreach (decimal item in source)
            {
                hour += item;
            }
            return Math.Round(hour, 2, MidpointRounding.AwayFromZero);
        }

        public static void AddRange<T>(this ICollection<T> source, IEnumerable<T> data)
        {
            foreach (T item in data)
            {
                source.Add(item);
            }
        }
    }
}