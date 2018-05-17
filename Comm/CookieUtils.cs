// ***********************************************************************
// Assembly         : FSControllerTier.Common.Utils
// Author           : Charlie Chan
// Created          : 2014-11-26
//
// Last Modified By : Charlie Chan
// Last Modified On : 2014-11-26
// ***********************************************************************
// <copyright file="CookieUtils.cs" company="eCargo">
//     Copyright (c) eCargo. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Web;

/// <summary>
/// The Utils namespace.
/// </summary>
/// <Author>Charlie Chan</Author>
/// <Date>2014-11-26</Date>
namespace Comm.Utils
{
    /// <summary>
    /// Cookie公共操作类
    /// </summary>
    /// <Author>Charlie Chan</Author>
    /// <Date>2014-11-26</Date>
    public class CookieUtils
    {
        /// <summary>
        /// 用户配送区域
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-25 15:39:21</Date>
        public const string MEMBER_DELIVERY = "FS_WEBSITE_MEMBER_DELIVERY";

        /// <summary>
        /// 会员推荐给朋友回访后保存会员信息用Key
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-13 15:26:22</Date>
        public const string MEMBER_REFER = "FS_WEBSITE_MEMBER_REFER";

        /// <summary>
        /// 全局用于m和pc版本的切换
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-13 15:26:22</Date>
        public const string GLOBAL_PC_M = "FS_WEBSITE_GLOBAL_PC_M";

        /// <summary>
        /// 获取cookie值
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public static string GetValue(string key)
        {
            var cookie = HttpContext.Current.Request.Cookies[key];

            if (null == cookie)
            {
                return null;
            }

            return HttpContext.Current.Server.UrlDecode(cookie.Value);
        }

        /// <summary>
        /// 设置Cookie值
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public static void SetValue(string key, string value)
        {
            var cookie = HttpContext.Current.Request.Cookies[key];

            if (null == cookie)
            {
                cookie = new HttpCookie(key);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            else
            {
                ClearValue(key);
            }

            cookie.Expires = DateTime.Now.AddDays(7);
            cookie.Value = HttpContext.Current.Server.UrlEncode(value);
        }

        /// <summary>
        /// 清空指定Cookie
        /// </summary>
        /// <param name="key">The key.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public static void ClearValue(string key)
        {
            var cookie = HttpContext.Current.Request.Cookies[key];

            if (null == cookie)
            {
                return;
            }

            cookie.Expires = DateTime.Now.AddDays(-7);
            cookie.Value = null;
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}
