// ***********************************************************************
// Assembly         : FSControllerTier.Common.Utils
// Author           : Charlie Chan
// Created          : 2014-11-26
//
// Last Modified By : Charlie Chan
// Last Modified On : 2014-11-26
// ***********************************************************************
// <copyright file="GlobalUtils.cs" company="eCargo">
//     Copyright (c) eCargo. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;
using System.Web;
using Microsoft.VisualBasic;

namespace Comm.Utils
{
    /// <summary>
    /// 国际化公共操作类
    /// </summary>
    /// <Author>Charlie Chan</Author>
    /// <Date>2014-11-26</Date>
    public class GlobalUtils
    {
        /// <summary>
        /// 推荐给朋友相关Source集合
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-13 15:44:15</Date>
        public static IList<string> Sources = new List<string>
        {
            "Facebook",
            "Sina",
            "Wechat",
            "Email",
            "Personal",
            "Whatsapp"
        };

        /// <summary>
        /// 国际化Cookie用Key值
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public const string Key = "GLOBAL_LANGUAGE_KEY";

        /// <summary>
        /// 资源文件映射路径
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public const string AssemblyPath = "FSControllerTier.Common.Utils.Resources";

        /// <summary>
        /// 简体中文字符串
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public const string ZhCn = "zh-cn";

        /// <summary>
        /// 繁体中文（hk）字符串
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public const string ZhHk = "zh-hk";

        /// <summary>
        /// 根据key得到相关内容
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public static string GetString(string key)
        {
            var result = string.Empty;

            var rm = new ResourceManager(string.Format("{0}.{1}", AssemblyPath, GetLanguage()),
                Assembly.GetExecutingAssembly());
            try
            {
                key = key.Trim();
                result = rm.GetString(key);
            }
            catch (Exception)
            {
                result = GetString(string.Format(GlobalConst.ERROR_NO_KEY, key));
            }

            return result;
        }

        /// <summary>
        /// 得到当前显示语言
        /// </summary>
        /// <returns>LanguageType.</returns>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-26</Date>
        public static string GetLanguage()
        {
            var lang = CookieUtils.GetValue(Key);
            var result = string.Empty;

            switch (lang)
            {
                case ZhCn:
                case ZhHk:
                    result = lang;
                    break;
                default:
                    var languages = HttpContext.Current.Request.UserLanguages;

                    if (null == languages || languages.Count() == 0)
                    {
                        result = ZhHk;
                    }
                    else
                    {
                        var first = languages.First().ToLower();

                        switch (first)
                        {
                            case ZhCn:
                                result = ZhCn;
                                break;
                            default:
                                result = ZhHk;
                                break;
                        }
                    }

                    CookieUtils.SetValue(Key, result);
                    break;
            }

            return result;
        }

        /// <summary>
        /// 得到品牌名称
        /// </summary>
        /// <param name="brandName"></param>
        /// <returns></returns>
        public static string ConvertBrandName(string brandName)
        {
            string result = brandName;

            var brands = brandName.Split(new string[] { "|;|" }, StringSplitOptions.RemoveEmptyEntries);

            if (GetLanguage() == ZhCn)
            {
                if (brands.Count() == 2)
                {
                    result = string.Format("{0} {1}", brands[0], brands[1]);
                }
            }
            else
            {
                if (brands.Count() == 2)
                {
                    result = brands[1];
                }
            }

            return result;
        }
        

        public static string ConvertEmailByLang(string lang, string str)
        {
            return ConvertSimpBylang(lang, str);
        }

        public static string ConvertSimpBylang(string lang, string str)
        {
            string result = "";

            if (lang == ZhCn)
            {
                result = ConvertSimpWithNolang(str);
            }
            else
            {
                result = str;
            }
            return result;
        }

        public static string ConvertSimp(string str)
        {
            string result = "";

            if (GetLanguage() == ZhCn)
            {
                result = ConvertSimpWithNolang(str);
            }
            else
            {
                result = str;
            }
            return result;
        }

        public static string ConvertSimpWithNolang(string str)
        {
            return Strings.StrConv(str, VbStrConv.SimplifiedChinese).Replace("於", "于").Replace("後", "后").Replace("舖", "铺").Replace("甚麽", "什么");
        }
        public static string ConvertTrad(string str)
        {
            string result = "";

            str = str.Replace("发", "髮");
            result = Strings.StrConv(str, VbStrConv.TraditionalChinese)
                .Replace("于", "於")
                .Replace("后", "後")
                .Replace("铺", "舖")
                .Replace("什么", "甚麽")
                .Replace("鉆", "鑽")
                .Replace("表", "錶");

            return result;
        }

        public static bool IsCheckCnDomain
        {
            get
            {
                var domain = HttpContext.Current.Request.Url.AbsoluteUri.ToLower();
                var isUat = domain.StartsWith("http://wwwuat") || domain.StartsWith("https://wwwuat");
                return !isUat;
            }
        }

        public static bool IsShowWechat
        {
            get { return true; }
        }

        public static bool IsAllShowWechat
        {
            get { return false; }
        }

        public static bool IsShowShare
        {
            get { return true; }
        }

        public static string ShowShare(bool isStyle)
        {
            if (IsShowShare)
            {
                return string.Empty;
            }

            return isStyle ? " style='display: none;'" : " display: none;";
        }

        /// <summary>
        /// 是否属于中国
        /// </summary>
        /// <returns></returns>
        public static bool IsChina()
        {
            var result = IsShowShare;
            if (!result)
            {
                return true;
            }
            var ipHelper = new IpUtils { Ip = UserIp() };
            return ipHelper.IsChina();
        }

        /// <summary>
        /// 用户IP
        /// </summary>
        /// <returns>System.String.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-06-08 12:29:15</Date>
        public static string UserIp()
        {
            //如果客户端使用了代理服务器，则利用HTTP_X_FORWARDED_FOR找到客户端IP地址
            var userHostAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            //否则直接读取REMOTE_ADDR获取客户端IP地址
            if (string.IsNullOrEmpty(userHostAddress))
            {
                userHostAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            else
            {
                userHostAddress = userHostAddress.Split(',')[0].Trim();

                if (string.IsNullOrEmpty(userHostAddress))
                {
                    userHostAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
            }
            //前两者均失败，则利用Request.UserHostAddress属性获取IP地址，但此时无法确定该IP是客户端IP还是代理IP
            if (string.IsNullOrEmpty(userHostAddress))
            {
                userHostAddress = UserHostAddress;
            }
            //最后判断获取是否成功，并检查IP地址的格式（检查其格式非常重要）
            if (!string.IsNullOrEmpty(userHostAddress) && IsIp(userHostAddress))
            {
                return userHostAddress;
            }
            return "127.0.0.1";
        }

        public static string UserHostAddress
        {
            get
            {
                string ipAddress;

                if (null == HttpContext.Current || string.IsNullOrEmpty(HttpContext.Current.Request.UserHostAddress))
                {
                    ipAddress = "localhost";
                }
                else
                {
                    ipAddress = HttpContext.Current.Request.UserHostAddress;
                }

                return ipAddress;
            }
        }

        /// <summary>
        /// 检查IP地址格式
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIp(string ip)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        /// <summary>
        /// 用户所在地
        /// </summary>
        /// <returns>System.String.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-06-08 12:29:23</Date>
        public static string UserLocation()
        {
            var ipHelper = new IpUtils { Ip = UserIp() };
            return ipHelper.IpLocation();
        }

        /// <summary>
        /// 用户使用系统
        /// </summary>
        /// <returns>System.String.</returns>
        /// <Author>Kenneth</Author>
        /// <Date>2016-07-29 09:53:23</Date>
        public static string GetUserAgent()
        {
            var userAgent = HttpContext.Current.Request.UserAgent.ToLower();
            if (string.IsNullOrEmpty(userAgent))
            {
                userAgent = "";
            }

            return userAgent;
        }

        public static bool IsUsingIPhone()
        {
            return (GetUserAgent().Contains("iphone;")) ? true : false;
        }

        public static bool IsUsingIPad()
        {
            return (GetUserAgent().Contains("ipad;")) ? true : false;
        }

        public static bool IsUsingAndroid()
        {
            return (GetUserAgent().Contains("android;")) ? true : false;
        }

        public static bool IsUsingWindows10()
        {
            return (GetUserAgent().Contains("windows nt 10.0;")) ? true : false;
        }

        /// <summary>  
        /// 截取指定长度的字符串  
        /// </summary>  
        /// <param name="str">截取前的字符串</param>  
        /// <param name="length">要截取的字节长度</param>  
        /// <returns>截取后的字符串</returns>  
        public static string CutString(string str, int length)
        {
            int len = 0;            //字符串最終長度
            int sLen = str.Length;  //字符串長度
            //截取的字符串
            StringBuilder returnStr = new StringBuilder();
            for (int i = 0; i < sLen; i++)
            {
                //截取字符
                string s = str.Substring(i, 1);
                //將字符轉為字節
                byte[] bytes = Encoding.UTF8.GetBytes(s);               //單個字符的字節
                //長度大於1, 表示是中文字符
                if (bytes.Length > 1)
                {
                    len += 2;
                }
                else
                {
                    len++;
                }
                //不能超出最大長度
                if (len > length)
                {
                    break;
                }
                returnStr.Append(s);
            }
            return returnStr.ToString();
        }
        
    }
}
