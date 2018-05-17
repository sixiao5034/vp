// ***********************************************************************
// Assembly         : FSControllerTier
// Author           : Charlie
// Created          : 05-13-2015
//
// Last Modified By : Charlie
// Last Modified On : 05-13-2015
// ***********************************************************************
// <copyright file="IpHelper.cs" company="eCgo">
//     Copyright (c) eCgo. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Comm.Utils
{
    /// <summary>
    /// IP 帮助类
    /// </summary>
    /// <Author>Charlie</Author>
    /// <Date>2015-05-13 15:35:45</Date>
    public class IpUtils
    {
        #region 私有成员
        /// <summary>
        /// The _province path
        /// </summary>
        /// <Author>Charlie</Author>
        ///   <Date>2015-05-13 15:35:29</Date>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:45</Date>
        private readonly string _provincePath = HttpContext.Current.Server.MapPath("~/Data/Province.txt");
        /// <summary>
        /// The _data path
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:45</Date>
        private readonly string _dataPath = HttpContext.Current.Server.MapPath("~/Data/qqwry.dat");
        /// <summary>
        /// The _ip
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private string _ip = GlobalUtils.UserHostAddress;
        /// <summary>
        /// The _country
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private string _country;
        /// <summary>
        /// The _local
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private string _local;

        /// <summary>
        /// The _first start ip
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private long _firstStartIp;
        /// <summary>
        /// The _last start ip
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private long _lastStartIp;
        /// <summary>
        /// The _objfs
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private FileStream _objfs;
        /// <summary>
        /// The _start ip
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private long _startIp;
        /// <summary>
        /// The _end ip
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private long _endIp;
        /// <summary>
        /// The _country flag
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private int _countryFlag;
        /// <summary>
        /// The _end ip off
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private long _endIpOff;
        /// <summary>
        /// The _err MSG
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        private string _errMsg;
        #endregion

        #region 公共属性

        /// <summary>
        /// Sets the ip.
        /// </summary>
        /// <value>The ip.</value>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        public string Ip
        {
            set { _ip = value; }
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        public string Country
        {
            get { return _country; }
        }
        /// <summary>
        /// Gets the local.
        /// </summary>
        /// <value>The local.</value>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        public string Local
        {
            get { return _local; }
        }
        /// <summary>
        /// Gets the error MSG.
        /// </summary>
        /// <value>The error MSG.</value>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:44</Date>
        public string ErrMsg
        {
            get { return _errMsg; }
        }
        #endregion

        #region 搜索匹配数据
        /// <summary>
        /// Qs the qwry.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private void QQwry()
        {
            const string pattern = @"(((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))\.){3}((\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))";
            var objRe = new Regex(pattern);
            var objMa = objRe.Match(_ip);
            if (!objMa.Success)
            {
                _errMsg = "IP格式错误";
                return;
            }

            var ipInt = IpToInt(_ip);
            if (ipInt >= IpToInt("127.0.0.0") && ipInt <= IpToInt("127.255.255.255"))
            {
                _country = "本机内部环回地址";
                _local = "";
            }
            else if ((ipInt >= IpToInt("0.0.0.0") && ipInt <= IpToInt("2.255.255.255")) || (ipInt >= IpToInt("64.0.0.0") && ipInt <= IpToInt("126.255.255.255")) || (ipInt >= IpToInt("58.0.0.0") && ipInt <= IpToInt("60.255.255.255")))
            {
                _country = "网络保留地址";
                _local = "";
            }

            _objfs = new FileStream(_dataPath, FileMode.Open, FileAccess.Read);

            try
            {
                //objfs.Seek(0,SeekOrigin.Begin);
                _objfs.Position = 0;
                var buff = new Byte[8];
                _objfs.Read(buff, 0, 8);
                _firstStartIp = buff[0] + buff[1] * 256 + buff[2] * 256 * 256 + buff[3] * 256 * 256 * 256;
                _lastStartIp = buff[4] * 1 + buff[5] * 256 + buff[6] * 256 * 256 + buff[7] * 256 * 256 * 256;
                var recordCount = Convert.ToInt64((_lastStartIp - _firstStartIp) / 7.0);
                if (recordCount <= 1)
                {
                    _country = "FileDataError";
                    _objfs.Close();
                    return;
                }
                var rangE = recordCount;
                long rangB = 0;
                while (rangB < rangE - 1)
                {
                    var recNo = (rangE + rangB) / 2;
                    GetStartIp(recNo);
                    if (ipInt == _startIp)
                    {
                        rangB = recNo;
                        break;
                    }
                    if (ipInt > _startIp)
                    {
                        rangB = recNo;
                    }
                    else
                    {
                        rangE = recNo;
                    }
                }
                GetStartIp(rangB);
                GetEndIp();
                if (_startIp <= ipInt && _endIp >= ipInt)
                {
                    GetCountry();
                    _local = _local.Replace("（我们一定要解放台湾！！！）", "");
                }
                else
                {
                    _country = "未知";
                    _local = "";
                }
                _objfs.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        #endregion

        #region IP地址转换成Int数据
        /// <summary>
        /// Ips the automatic int.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <returns>System.Int64.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private long IpToInt(string ip)
        {
            char[] dot = { '.' };
            var ipArr = ip.Split(dot);
            if (ipArr.Length == 3)
            {
                ip = ip + ".0";
            }
            ipArr = ip.Split(dot);

            long p1 = long.Parse(ipArr[0]) * 256 * 256 * 256;
            long p2 = long.Parse(ipArr[1]) * 256 * 256;
            long p3 = long.Parse(ipArr[2]) * 256;
            long p4 = long.Parse(ipArr[3]);
            var ipInt = p1 + p2 + p3 + p4;
            return ipInt;
        }
        #endregion

        #region int转换成IP
        /// <summary>
        /// Ints the automatic ip.
        /// </summary>
        /// <param name="ipInt">The ip int.</param>
        /// <returns>System.String.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        public string IntToIp(long ipInt)
        {
            var seg1 = (ipInt & 0xff000000) >> 24;
            if (seg1 < 0)
            {
                seg1 += 0x100;
            }
            var seg2 = (ipInt & 0x00ff0000) >> 16;
            if (seg2 < 0)
            {
                seg2 += 0x100;
            }
            var seg3 = (ipInt & 0x0000ff00) >> 8;
            if (seg3 < 0)
            {
                seg3 += 0x100;
            }
            var seg4 = (ipInt & 0x000000ff);
            if (seg4 < 0)
            {
                seg4 += 0x100;
            }
            var ip = seg1 + "." + seg2 + "." + seg3 + "." + seg4;

            return ip;
        }
        #endregion

        #region 获取起始IP范围
        /// <summary>
        /// Gets the start ip.
        /// </summary>
        /// <param name="recNo">The record no.</param>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private void GetStartIp(long recNo)
        {
            var offSet = _firstStartIp + recNo * 7;
            //objfs.Seek(offSet,SeekOrigin.Begin);
            _objfs.Position = offSet;
            var buff = new Byte[7];
            _objfs.Read(buff, 0, 7);

            _endIpOff = Convert.ToInt64(buff[4].ToString(CultureInfo.InvariantCulture)) +
                Convert.ToInt64(buff[5].ToString(CultureInfo.InvariantCulture)) * 256 +
                Convert.ToInt64(buff[6].ToString(CultureInfo.InvariantCulture)) * 256 * 256;
            _startIp = Convert.ToInt64(buff[0].ToString(CultureInfo.InvariantCulture)) +
                Convert.ToInt64(buff[1].ToString(CultureInfo.InvariantCulture)) * 256 +
                Convert.ToInt64(buff[2].ToString(CultureInfo.InvariantCulture)) * 256 * 256 +
                Convert.ToInt64(buff[3].ToString(CultureInfo.InvariantCulture)) * 256 * 256 * 256;
        }
        #endregion

        #region 获取结束IP
        /// <summary>
        /// Gets the end ip.
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private void GetEndIp()
        {
            //objfs.Seek(endIpOff,SeekOrigin.Begin);
            _objfs.Position = _endIpOff;
            var buff = new Byte[5];
            _objfs.Read(buff, 0, 5);
            _endIp = Convert.ToInt64(buff[0].ToString(CultureInfo.InvariantCulture)) +
                Convert.ToInt64(buff[1].ToString(CultureInfo.InvariantCulture)) * 256 +
                Convert.ToInt64(buff[2].ToString(CultureInfo.InvariantCulture)) * 256 * 256 +
                Convert.ToInt64(buff[3].ToString(CultureInfo.InvariantCulture)) * 256 * 256 * 256;
            _countryFlag = buff[4];
        }
        #endregion

        #region 获取国家/区域偏移量
        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private void GetCountry()
        {
            switch (_countryFlag)
            {
                case 1:
                case 2:
                    _country = GetFlagStr(_endIpOff + 4);
                    _local = (1 == _countryFlag) ? " " : GetFlagStr(_endIpOff + 8);
                    break;
                default:
                    _country = GetFlagStr(_endIpOff + 4);
                    _local = GetFlagStr(_objfs.Position);
                    break;
            }
        }

        #endregion

        #region 获取国家/区域字符串
        /// <summary>
        /// Gets the flag string.
        /// </summary>
        /// <param name="offSet">The off set.</param>
        /// <returns>System.String.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private string GetFlagStr(long offSet)
        {
            var buff = new Byte[3];
            while (true)
            {
                //objfs.Seek(offSet,SeekOrigin.Begin);
                _objfs.Position = offSet;
                var flag = _objfs.ReadByte();
                if (flag == 1 || flag == 2)
                {
                    _objfs.Read(buff, 0, 3);
                    if (flag == 2)
                    {
                        _countryFlag = 2;
                        _endIpOff = offSet - 4;
                    }
                    offSet = Convert.ToInt64(buff[0].ToString(CultureInfo.InvariantCulture)) +
                        Convert.ToInt64(buff[1].ToString(CultureInfo.InvariantCulture)) * 256 +
                        Convert.ToInt64(buff[2].ToString(CultureInfo.InvariantCulture)) * 256 * 256;
                }
                else
                {
                    break;
                }
            }
            if (offSet < 12)
            {
                return " ";
            }
            _objfs.Position = offSet;
            return GetStr();
        }
        #endregion

        #region GetStr
        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <returns>System.String.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        private string GetStr()
        {
            var str = "";
            var buff = new byte[2];
            while (true)
            {
                var lowC = (Byte)_objfs.ReadByte();
                if (lowC == 0)
                {
                    break;
                }
                if (lowC > 127)
                {
                    var upC = (byte)_objfs.ReadByte();
                    buff[0] = lowC;
                    buff[1] = upC;
                    var enc = Encoding.GetEncoding("GB2312");
                    str += enc.GetString(buff);
                }
                else
                {
                    str += (char)lowC;
                }
            }
            return str;
        }
        #endregion

        #region 获取IP地址
        /// <summary>
        /// 根据ip得到地理位置
        /// </summary>
        /// <returns>System.String.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        public string IpLocation()
        {
            QQwry();
            return _country + _local;
        }

        #endregion

        /// <summary>
        /// 判断是否中国内地
        /// </summary>
        /// <returns><c>true</c> if this instance is china; otherwise, <c>false</c>.</returns>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-13 15:35:43</Date>
        public bool IsChina()
        {
            if (string.IsNullOrEmpty(IpLocation())) return true;
            var provinces = CacheUtils.Get<List<string>>("FINGERSHOPPING_IP_PROCICES");

            if (null == provinces || 0 == provinces.Count)
            {
                provinces = new List<string>();
                var sr = new StreamReader(_provincePath, Encoding.Default);
                var province = sr.ReadLine();

                while (!string.IsNullOrEmpty(province))
                {
                    provinces.Add(province);
                    province = sr.ReadLine();
                }

                CacheUtils.Insert("FINGERSHOPPING_IP_PROCICES", provinces);
            }

            var currentProvince = provinces.FirstOrDefault(p => Country.StartsWith(p));
            return !string.IsNullOrEmpty(currentProvince);
        }
    }
}
