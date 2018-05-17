using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Web.Caching;
using System.Web.Hosting;

namespace Comm.Utils
{
    /// <summary>
    /// 缓存帮助类
    /// </summary>
    /// <Author>Charlie Chan</Author>
    /// <Date>2014-12-15 10:35:47</Date>
    public class CacheUtils
    {
        #region delivery key

        /// <summary>
        /// 获取门店
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:40:15</Date>
        public const string STORES = "FS_WEBSITE_STORES";
        /// <summary>
        /// 中国区配送地址缓存key
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:40:15</Date>
        public const string DELIVERY_CN = "FS_WEBSITE_DELIVERY_CN";
        /// <summary>
        /// 澳门区配送地址缓存key
        /// </summary>
        /// <Author>Hongtao</Author>
        /// <Date>2015-10-27</Date>
        public const string DELIVERY_MC = "FS_WEBSITE_DELIVERY_MC";
        /// <summary>
        /// 香港区配送地址缓存key
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:40:29</Date>
        public const string DELIVERY_HK = "FS_WEBSITE_DELIVERY_HK";

        #endregion

        private static Cache _cache;

        /// <summary>
        /// 缓存时间，分钟
        /// </summary>
        /// <value>The save time.</value>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:36:01</Date>
        public static double SaveTime
        {
            get;
            set;
        }

        static CacheUtils()
        {
            _cache = HostingEnvironment.Cache;
            SaveTime = 30.0;
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.Object.</returns>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:36:21</Date>
        public static object Get(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            return _cache.Get(key);
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns>``0.</returns>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:36:34</Date>
        public static T Get<T>(string key)
        {
            object obj = Get(key);
            return obj == null ? default(T) : (T)obj;
        }

        /// <summary>
        /// 增加缓存
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="dependency">The dependency.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="callback">The callback.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:37:08</Date>
        public static void Insert(string key, object value, CacheDependency dependency, CacheItemPriority priority, CacheItemRemovedCallback callback)
        {
            if (null == value)
            {
                return;
            }

            _cache.Insert(key, value, dependency, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(SaveTime), priority, callback);
        }

        /// <summary>
        /// 增加缓存
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="dependency">The dependency.</param>
        /// <param name="callback">The callback.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:37:19</Date>
        public static void Insert(string key, object value, CacheDependency dependency, CacheItemRemovedCallback callback)
        {
            Insert(key, value, dependency, CacheItemPriority.Default, callback);
        }

        /// <summary>
        /// 增加缓存
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="dependency">The dependency.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:37:36</Date>
        public static void Insert(string key, object value, CacheDependency dependency)
        {
            Insert(key, value, dependency, CacheItemPriority.Default, null);
        }

        /// <summary>
        /// 增加缓存
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:37:41</Date>
        public static void Insert(string key, object value)
        {
            Insert(key, value, null, CacheItemPriority.Default, null);
        }

        /// <summary>
        /// 删除缓存
        /// </summary>
        /// <param name="key">The key.</param>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:37:45</Date>
        public static void Remove(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return;
            }

            _cache.Remove(key);
        }

        /// <summary>
        /// 得到所有缓存的key
        /// </summary>
        /// <returns>IList{System.String}.</returns>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:38:05</Date>
        public static IList<string> GetKeys()
        {
            List<string> keys = new List<string>();
            IDictionaryEnumerator enumerator = _cache.GetEnumerator();
            while (enumerator.MoveNext())
            {
                keys.Add(enumerator.Key.ToString());
            }

            return keys.AsReadOnly();
        }

        /// <summary>
        /// 删除所有缓存
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-12-15 10:37:58</Date>
        public static void RemoveAll()
        {
            IList<string> keys = GetKeys();
            foreach (string key in keys)
            {
                _cache.Remove(key);
            }
        }

    }
}
