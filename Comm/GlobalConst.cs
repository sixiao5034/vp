// ***********************************************************************
// Assembly         : FSControllerTier.Common.Utils
// Author           : Charlie Chan
// Created          : 2014-11-27
//
// Last Modified By : Charlie Chan
// Last Modified On : 2014-11-27
// ***********************************************************************
// <copyright file="GlobalConst.cs" company="eCargo">
//     Copyright (c) eCargo. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// The Utils namespace.
/// </summary>
/// <Author>Charlie Chan</Author>
/// <Date>2014-11-27</Date>
namespace Comm.Utils
{
    /// <summary>
    /// 国际化Key值常量
    /// </summary>
    /// <Author>Charlie Chan</Author>
    /// <Date>2014-11-27</Date>
    public class GlobalConst
    {
        #region Test

        /// <summary>
        /// 国际化语言测试
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public const string TEST_LANGUAGE = "TEST_LANGUAGE";

        #endregion

        #region Menu

        /// <summary>
        /// 主页
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public const string MENU_HOME = "MENU_HOME";

        /// <summary>
        /// 关于我们
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public const string MENU_ABOUT = "MENU_ABOUT";

        #endregion

        #region button

        /// <summary>
        /// 点我试试
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public const string BUTTON_CLICK_TRY = "BUTTON_CLICK_TRY";

        #endregion

        #region Error

        /// <summary>
        /// key不存在
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public const string ERROR_NO_KEY = "ERROR_NO_KEY";

        #endregion

        #region Message

        public const string REMEMBER_INFOMATION = "REMEMBER_INFOMATION";

        /// <summary>
        /// 简繁信息
        /// </summary>
        /// <Author>Charlie Chan</Author>
        /// <Date>2014-11-27</Date>
        public const string MESSAGE_TRY = "MESSAGE_TRY";

        public const string MESSAGE_TRY1 = "MESSAGE_TRY1";
        public const string MESSAGE_TRY2 = "MESSAGE_TRY2";
        public const string MESSAGE_TRY3 = "MESSAGE_TRY3";
        public const string MESSAGE_TRY4 = "MESSAGE_TRY4";

        public const string MESSAGE_YOUREMAIL = "MESSAGE_YOUREMAIL";

        public const string MESSAGE_LOGINVIPACCOUNT = "MESSAGE_LOGINVIPACCOUNT";

        public const string MESSAGE_GETVIPMEMBERSHIPDISCONUT = "MESSAGE_GETVIPMEMBERSHIPDISCONUT";
        public const string MESSAGE_SIGNINNOW = "MESSAGE_SIGNINNOW";
        public const string MESSAGE_TOTAL = "MESSAGE_TOTAL";
        public const string MESSAGE_DISCOUNTS = "MESSAGE_DISCOUNTS";
        public const string MESSAGE_TOTALDISCOUNT = "MESSAGE_TOTALDISCOUNT";
        public const string MESSAGE_LUMPSUM = "MESSAGE_LUMPSUM";
        public const string MESSAGE_ITEM = "MESSAGE_ITEM";
        public const string MESSAGE_CALCULATETHETIMEOFORDER = "MESSAGE_CALCULATETHETIMEOFORDER";
        public const string MESSAGE_SUPPORT = "MESSAGE_SUPPORT";
        public const string MESSAGE_SIGNOUT = "MESSAGE_SIGNOUT";
        public const string MESSAGE_CONTACTUS = "MESSAGE_CONTACTUS";
        public const string MESSAGE_POINTINGFINGERSHOPPING = "MESSAGE_POINTINGFINGERSHOPPING";
        public const string MESSAGE_DELIVERYANDPAYMENT = "MESSAGE_DELIVERYANDPAYMENT";
        public const string MESSAGE_SUMMARY = "MESSAGE_SUMMARY";
        public const string MESSAGE_CONFIRMORDER = "MESSAGE_CONFIRMORDER";
        public const string MESSAGE_BUYNOW = "MESSAGE_BUYNOW";
        public const string MESSAGE_ADDTOCART = "MESSAGE_ADDTOCART";
        public const string MESSAGE_OOS = "MESSAGE_OOS";
        public const string MESSAGE_WANTTOBUY = "MESSAGE_WANTTOBUY";
        public const string MESSAGE_WORDSINTHESEARCHBOX = "MESSAGE_WORDSINTHESEARCHBOX";
        public const string MESSAGE_NOMOREMERCHANDISE = "MESSAGE_NOMOREMERCHANDISE";
        public const string MESSAGE_NOMORESTORES = "MESSAGE_NOMORESTORES";
        public const string MESSAGE_NOMOREEVALUATION = "MESSAGE_NOMOREEVALUATION";
        public const string MESSAGE_APPRAISAL = "MESSAGE_APPRAISAL";
        public const string MESSAGE_HOME = "MESSAGE_HOME";
        public const string MESSAGE_LOGIN = "MESSAGE_LOGIN";
        public const string MESSAGE_VIPMEMBERS = "MESSAGE_VIPMEMBERS";
        public const string MESSAGE_BASICMEMBER = "MESSAGE_BASICMEMBER";
        public const string MESSAGE_UPGRADEVIPSHOPPING = "MESSAGE_UPGRADEVIPSHOPPING";
        public const string MESSAGE_IMMEDIATELYMEMBERSHIP = "MESSAGE_IMMEDIATELYMEMBERSHIP";
        public const string MESSAGE_MEMBERSENJOY = "MESSAGE_MEMBERSENJOY";
        public const string MESSAGE_MYACCOUNT = "MESSAGE_MYACCOUNT";
        public const string MESSAGE_MYFAVORITE = "MESSAGE_MYFAVORITE";
        public const string MESSAGE_SHOPPINGCART = "MESSAGE_SHOPPINGCART";
        public const string MESSAGE_DESIGNER = "MESSAGE_DESIGNER";
        public const string MESSAGE_LIFE = "MESSAGE_LIFE";
        public const string MESSAGE_GIFT = "MESSAGE_GIFT";
        public const string MESSAGE_GIFT_GIVING = "MESSAGE_GIFT_GIVING";
        public const string MESSAGE_JETSO = "MESSAGE_JETSO";
        public const string MESSAGE_ADVANCEDSEARCH = "MESSAGE_ADVANCEDSEARCH";
        public const string MESSAGE_BRAND = "MESSAGE_BRAND";
        public const string MESSAGE_VIEWALL = "MESSAGE_VIEWALL";
        public const string MESSAGE_STORE = "MESSAGE_STORE";
        public const string MESSAGE_MEMBERAREA = "MESSAGE_MEMBERAREA";
        public const string MESSAGE_SHOPPINGMOREFUN = "MESSAGE_SHOPPINGMOREFUN";
        public const string MESSAGE_TELLAFRIEND = "MESSAGE_TELLAFRIEND";
        public const string MESSAGE_RECOMMENDUSTOAFRIEND = "MESSAGE_RECOMMENDUSTOAFRIEND";
        public const string MESSAGE_SHAREYOURSHOPPINGEXPERIENCE = "MESSAGE_SHAREYOURSHOPPINGEXPERIENCE";
        public const string MESSAGE_PICKUPLOCATION = "MESSAGE_PICKUPLOCATION";
        public const string MESSAGE_300CONVENIENCESTORESOK = "MESSAGE_300CONVENIENCESTORESOK";
        public const string MESSAGE_THROUGHOUTTHETERRITORY = "MESSAGE_THROUGHOUTTHETERRITORY";
        public const string MESSAGE_ABOUTUS = "MESSAGE_ABOUTUS";
        public const string MESSAGE_CUSTOMERSERVICE = "MESSAGE_CUSTOMERSERVICE";
        public const string MESSAGE_INSTRUCTIONS = "MESSAGE_INSTRUCTIONS";
        public const string MESSAGE_ASKEDQUESTIONS = "MESSAGE_ASKEDQUESTIONS";
        public const string MESSAGE_ABOUTDELIVERY = "MESSAGE_ABOUTDELIVERY";
        public const string MESSAGE_PAYMENTMETHOD = "MESSAGE_PAYMENTMETHOD";
        public const string MESSAGE_MERCHANTAFFILIATE = "MESSAGE_MERCHANTAFFILIATE";
        public const string MESSAGE_SHOW_AD_QUERY = "MESSAGE_SHOW_AD_QUERY";
        public const string MESSAGE_PICKNETWORK = "MESSAGE_PICKNETWORK";
        public const string MESSAGE_STAYCONNECTED = "MESSAGE_STAYCONNECTED";
        public const string MESSAGE_COPYRIGHT = "MESSAGE_COPYRIGHT";
        public const string MESSAGE_PRIVACYPOLICY = "MESSAGE_PRIVACYPOLICY";
        public const string MESSAGE_TERMSOFUSE = "MESSAGE_TERMSOFUSE";
        public const string MESSAGE_SITEMAP = "MESSAGE_SITEMAP";
        public const string MESSAGE_POINTINGSHOPPINGLTD = "MESSAGE_POINTINGSHOPPINGLTD";
        public const string MESSAGE_TIMEOFRECEIPT = "MESSAGE_TIMEOFRECEIPT";
        public const string MESSAGE_ORDERNUMBER = "MESSAGE_ORDERNUMBER";
        public const string MESSAGE_SHIPPINGADDRESS = "MESSAGE_SHIPPINGADDRESS";
        public const string MESSAGE_DELIVERYDATE = "MESSAGE_DELIVERYDATE";
        public const string MESSAGE_BALANCEDUE = "MESSAGE_BALANCEDUE";
        public const string MESSAGE_TEAINTERVAL = "MESSAGE_TEAINTERVAL";
        public const string MESSAGE_SUGGESTEDRETAILPRICE = "MESSAGE_SUGGESTEDRETAILPRICE";
        public const string MESSAGE_BUY = "MESSAGE_BUY";
        public const string MESSAGE_ENJOYDISCOUNT = "MESSAGE_ENJOYDISCOUNT";
        public const string MESSAGE_ELECTRONICCOUPONS = "MESSAGE_ELECTRONICCOUPONS";
        public const string MESSAGE_PHONE = "MESSAGE_PHONE";
        public const string MESSAGE_EMAIL = "MESSAGE_EMAIL";
        public const string MESSAGE_ADDRESS = "MESSAGE_ADDRESS";
        public const string MESSAGE_GIFTCARD = "MESSAGE_GIFTCARD";
        public const string MESSAGE_ELECTRONICGIFTCARD = "MESSAGE_ELECTRONICGIFTCARD";
        public const string MESSAGE_CONTACTINFORMATION = "MESSAGE_CONTACTINFORMATION";
        public const string MESSAGE_AGIFTBAG = "MESSAGE_AGIFTBAG";
        public const string MESSAGE_ROCKYRELATIONS = "MESSAGE_ROCKYRELATIONS";
        public const string MESSAGE_WATCHOUT = "MESSAGE_WATCHOUT";
        public const string MESSAGE_DELIVERYTIME = "MESSAGE_DELIVERYTIME";
        public const string MESSAGE_DESIGNERNAME = "MESSAGE_DESIGNERNAME";
        public const string MESSAGE_HOMEWARES = "MESSAGE_HOMEWARES";
        public const string MESSAGE_MORE = "MESSAGE_MORE";
        public const string MESSAGE_DES_LABLE = "MESSAGE_DES_LABLE";
        public const string MESSAGE_SELECTORENTER = "MESSAGE_SELECTORENTER";
        public const string MESSAGE_USEOFELECTRONICVOUCHERS = "MESSAGE_USEOFELECTRONICVOUCHERS";
        public const string MESSAGE_SELECT_ELECTRONIC_COUPONS = "MESSAGE_SELECT_ELECTRONIC_COUPONS";
        public const string MESSAGE_INPUT_ELECTRONIC_COUPONS = "MESSAGE_INPUT_ELECTRONIC_COUPONS";
        public const string MESSAGE_ENTER_ELECTRONIC_COUPONS = "MESSAGE_ENTER_ELECTRONIC_COUPONS";
        public const string MESSAGE_ONLY_BE_USED_ONCE = "MESSAGE_ONLY_BE_USED_ONCE";
        public const string MESSAGE_INTEGRAL_BOOK = "MESSAGE_INTEGRAL_BOOK";
        public const string MESSAGE_AVAILABLE_POINTS = "MESSAGE_AVAILABLE_POINTS";
        public const string MESSAGE_INTEGRAL_TO_EXPIRE = "MESSAGE_INTEGRAL_TO_EXPIRE";
        public const string MESSAGE_EXPIRED = "MESSAGE_EXPIRED";
        public const string MESSAGE_FINGERDOLLARS_SOURCES = "MESSAGE_FINGERDOLLARS_SOURCES";
        public const string MESSAGE_DATE = "MESSAGE_DATE";
        public const string MESSAGE_FINGERDOLLARS_EXPENSES = "MESSAGE_FINGERDOLLARS_EXPENSES";
        public const string MESSAGE_FINGERDOLLARS_REMAINING = "MESSAGE_FINGERDOLLARS_REMAINING";
        public const string MESSAGE_USE_POINTS = "MESSAGE_USE_POINTS";
        public const string MESSAGE_ORIENTATION_POINTS = "MESSAGE_ORIENTATION_POINTS";
        public const string MESSAGE_EARN_POINTS = "MESSAGE_EARN_POINTS";
        public const string MESSAGE_BOOK_FINGERDOLLARS = "MESSAGE_BOOK_FINGERDOLLARS";
        public const string MESSAGE_GENERAL_INQUIRIES = "MESSAGE_GENERAL_INQUIRIES";
        public const string MESSAGE_ORDER_TRACKING = "MESSAGE_ORDER_TRACKING";
        public const string MESSAGE_ATTACHED_GREAT_IMPORTANCE = "MESSAGE_ATTACHED_GREAT_IMPORTANCE";
        public const string MESSAGE_NAME = "MESSAGE_NAME";
        public const string MESSAGE_CALL = "MESSAGE_CALL";
        public const string MESSAGE_MR = "MESSAGE_MR";
        public const string MESSAGE_MS = "MESSAGE_MS";
        public const string MESSAGE_MRS = "MESSAGE_MRS";
        public const string MESSAGE_YOUR_EMAIL_ADDRESS = "MESSAGE_YOUR_EMAIL_ADDRESS";
        public const string MESSAGE_ISSUE = "MESSAGE_ISSUE";
        public const string MESSAGE_SEND_OUT = "MESSAGE_SEND_OUT";
        public const string MESSAGE_RESET = "MESSAGE_RESET";
        public const string MESSAGE_ORDER_NUMBER = "MESSAGE_ORDER_NUMBER";
        public const string MESSAGE_TAKE_INVOICE_NUMBER = "MESSAGE_TAKE_INVOICE_NUMBER";
        public const string MESSAGE_QUERY_MATTERS = "MESSAGE_QUERY_MATTERS";
        public const string MESSAGE_EMS_TRACKING = "MESSAGE_EMS_TRACKING";
        public const string MESSAGE_TAKE_SEND_INQUIRY = "MESSAGE_TAKE_SEND_INQUIRY";
        public const string MESSAGE_ACCOUNT_INQUIRY = "MESSAGE_ACCOUNT_INQUIRY";
        public const string MESSAGE_CANCEL_ORDER = "MESSAGE_CANCEL_ORDER";
        public const string MESSAGE_RETURNS = "MESSAGE_RETURNS";
        public const string MESSAGE_REFUND = "MESSAGE_REFUND";
        public const string MESSAGE_COMPLAINTS = "MESSAGE_COMPLAINTS";
        public const string MESSAGE_REQUIRED = "MESSAGE_REQUIRED";
        public const string MESSAGE_YOUR_OPINION = "MESSAGE_YOUR_OPINION";
        public const string MESSAGE_COLOR = "MESSAGE_COLOR";
        public const string MESSAGE_GIFT_PRICE = "MESSAGE_GIFT_PRICE";
        public const string MESSAGE_CLASSIFICATION = "MESSAGE_CLASSIFICATION";
        public const string MESSAGE_CHOOSE_COLOR = "MESSAGE_CHOOSE_COLOR";
        public const string MESSAGE_RED = "MESSAGE_RED";
        public const string MESSAGE_PINK = "MESSAGE_PINK";
        public const string MESSAGE_ORANGE = "MESSAGE_ORANGE";
        public const string MESSAGE_YELLOW = "MESSAGE_YELLOW";
        public const string MESSAGE_GREEN = "MESSAGE_GREEN";
        public const string MESSAGE_BLUE = "MESSAGE_BLUE";
        public const string MESSAGE_PURPLE = "MESSAGE_PURPLE";
        public const string MESSAGE_BLACK = "MESSAGE_BLACK";
        public const string MESSAGE_WHITE = "MESSAGE_WHITE";
        public const string MESSAGE_GRAY = "MESSAGE_GRAY";
        public const string MESSAGE_BROWN = "MESSAGE_BROWN";
        public const string MESSAGE_ALL_GIFTS_PRICE = "MESSAGE_ALL_GIFTS_PRICE";
        public const string MESSAGE_ALL_CATEGORY = "MESSAGE_ALL_CATEGORY";
        public const string MESSAGE_BEST_FRIEND = "MESSAGE_BEST_FRIEND";
        public const string MESSAGE_TO_LOVE = "MESSAGE_TO_LOVE";
        public const string MESSAGE_SEX = "MESSAGE_SEX";
        public const string MESSAGE_ALL_SEX = "MESSAGE_ALL_SEX";
        public const string MESSAGE_ABOUT_SHIPPING = "MESSAGE_ABOUT_SHIPPING";
        public const string MESSAGE_DELIVERY_NETWORK = "MESSAGE_DELIVERY_NETWORK";
        public const string MESSAGE_PAYMENT_METHOD = "MESSAGE_PAYMENT_METHOD";
        public const string MESSAGE_BECOME_A_MEMBER = "MESSAGE_BECOME_A_MEMBER";
        public const string MESSAGE_NOVICE_SHOPPING_EXPRESS = "MESSAGE_NOVICE_SHOPPING_EXPRESS";
        public const string MESSAGE_BECOME_MERCHANTS = "MESSAGE_BECOME_MERCHANTS";
        public const string MESSAGE_ACCOUNT_MANAGEMENT = "MESSAGE_ACCOUNT_MANAGEMENT";
        public const string MESSAGE_SHOPPING_NOTES = "MESSAGE_SHOPPING_NOTES";
        public const string MESSAGE_RETURNS_AND_REFUNDS = "MESSAGE_RETURNS_AND_REFUNDS";
        public const string MESSAGE_POLICY_AND_RULES = "MESSAGE_POLICY_AND_RULES";
        public const string MESSAGE_TEMP_OUT = "MESSAGE_TEMP_OUT";
        public const string MESSAGE_ADDITIONAL_VIP = "MESSAGE_ADDITIONAL_VIP";
        public const string MESSAGE_ADD_TO_CART = "MESSAGE_ADD_TO_CART";
        public const string MESSAGE_BUY_NOW_HTML = "MESSAGE_BUY_NOW_HTML";
        public const string MESSAGE_TEMPORARILY_OUT_STOCK_HTML = "MESSAGE_TEMPORARILY_OUT_STOCK_HTML";
        public const string MESSAGE_PROFILE = "MESSAGE_PROFILE";
        public const string MESSAGE_MY_EVALUATION = "MESSAGE_MY_EVALUATION";
        public const string MESSAGE_MY_FINGERDOLLARS = "MESSAGE_MY_FINGERDOLLARS";
        public const string MESSAGE_MY_ECOUPONS = "MESSAGE_MY_ECOUPONS";
        public const string MESSAGE_MODIFY_PERSONAL_INFORMATION = "MESSAGE_MODIFY_PERSONAL_INFORMATION";
        public const string MESSAGE_SHIPPING_ADDRESS = "MESSAGE_SHIPPING_ADDRESS";
        public const string MESSAGE_MY_ORDER = "MESSAGE_MY_ORDER";
        public const string MESSAGE_PRODUCT_ORDER = "MESSAGE_PRODUCT_ORDER";
        public const string MESSAGE_LIINVITE = "MESSAGE_LIINVITE";
        public const string MESSAGE_LIGIFTCARD = "MESSAGE_LIGIFTCARD";
        public const string MESSAGE_RESET_PASSWORD = "MESSAGE_RESET_PASSWORD";
        public const string MESSAGE_PASSWORD = "MESSAGE_PASSWORD";
        public const string MESSAGE_FORGOT_PASSWORD = "MESSAGE_FORGOT_PASSWORD";
        public const string MESSAGE_NOT_MEMBER = "MESSAGE_NOT_MEMBER";
        public const string MESSAGE_REGACCOUNT = "MESSAGE_REGACCOUNT";
        public const string MESSAGE_USER_NAME = "MESSAGE_USER_NAME";
        public const string MESSAGE_REGCONFIRMEMAIL = "MESSAGE_REGCONFIRMEMAIL";
        public const string MESSAGE_REGCONFIRMPASSWORD = "MESSAGE_REGCONFIRMPASSWORD";
        public const string MESSAGE_APPROACH_US = "MESSAGE_APPROACH_US";
        public const string MESSAGE_SELECTED = "MESSAGE_SELECTED";
        public const string MESSAGE_CONVENIENCE_STORE = "MESSAGE_CONVENIENCE_STORE";
        public const string MESSAGE_NEWSPAPER = "MESSAGE_NEWSPAPER";
        public const string MESSAGE_FREE_NEWSPAPER = "MESSAGE_FREE_NEWSPAPER";
        public const string MESSAGE_MAGAZINE = "MESSAGE_MAGAZINE";
        public const string MESSAGE_BLOG = "MESSAGE_BLOG";
        public const string MESSAGE_SEARCH_ENGINE_ADVERTISING = "MESSAGE_SEARCH_ENGINE_ADVERTISING";
        public const string MESSAGE_ONLINE_ADVERTISING = "MESSAGE_ONLINE_ADVERTISING";
        public const string MESSAGE_PHONE_ADVERTISING_PROGRAM = "MESSAGE_PHONE_ADVERTISING_PROGRAM";
        public const string MESSAGE_OTHER_SITES = "MESSAGE_OTHER_SITES";
        public const string MESSAGE_FACEBOOK = "MESSAGE_FACEBOOK";
        public const string MESSAGE_MICROBLOGGING = "MESSAGE_MICROBLOGGING";
        public const string MESSAGE_OTHER_SOCIAL_MEDIA = "MESSAGE_OTHER_SOCIAL_MEDIA";
        public const string MESSAGE_FRIENDS = "MESSAGE_FRIENDS";
        public const string MESSAGE_AGREE = "MESSAGE_AGREE";
        public const string MESSAGE_SUCCESSFULLY_UPGRADED_VIP = "MESSAGE_SUCCESSFULLY_UPGRADED_VIP";
        public const string MESSAGE_PASSWORD_IS_INCORRECT = "MESSAGE_PASSWORD_IS_INCORRECT";
        public const string MESSAGE_ACCOUNT_EXPIRED = "MESSAGE_ACCOUNT_EXPIRED";
        public const string MESSAGE_EMAIL_NOT_REGISTERED = "MESSAGE_EMAIL_NOT_REGISTERED";
        public const string MESSAGE_CONGRATULATIONS = "MESSAGE_CONGRATULATIONS";
        public const string MESSAGE_CONGRATULATIONS_1 = "MESSAGE_CONGRATULATIONS_1";
        public const string MESSAGE_CONGRATULATIONS_2 = "MESSAGE_CONGRATULATIONS_2";
        public const string MESSAGE_CONGRATULATIONS_3 = "MESSAGE_CONGRATULATIONS_3";
        public const string MESSAGE_CONGRATULATIONS_VIP = "MESSAGE_CONGRATULATIONS_VIP";
        public const string MESSAGE_RMB_ME = "MESSAGE_RMB_ME";
        public const string MESSAGE_NEW_SHIPPING_ADDRESS = "MESSAGE_NEW_SHIPPING_ADDRESS";
        public const string MESSAGE_MANDATORY = "MESSAGE_MANDATORY";
        public const string MESSAGE_FILL_IN = "MESSAGE_FILL_IN";
        public const string MESSAGE_PLEASE_SELECT = "MESSAGE_PLEASE_SELECT";
        public const string MESSAGE_SHIPPING_ADDRESS_REFERRED = "MESSAGE_SHIPPING_ADDRESS_REFERRED";
        public const string MESSAGE_DELIVERY_AREA = "MESSAGE_DELIVERY_AREA";
        public const string MESSAGE_SERVICES = "MESSAGE_SERVICES";
        public const string MESSAGE_BUILDING_ROOM = "MESSAGE_BUILDING_ROOM";
        public const string MESSAGE_BUILDING_BLOCK = "MESSAGE_BUILDING_BLOCK";
        public const string MESSAGE_ESTATE_COURT = "MESSAGE_ESTATE_COURT";
        public const string MESSAGE_STREET = "MESSAGE_STREET";
        public const string MESSAGE_ADDRESS_CODE = "MESSAGE_ADDRESS_CODE";
        public const string MESSAGE_RESIDENTIAL = "MESSAGE_RESIDENTIAL";
        public const string MESSAGE_HONG_KONG_ISLAND = "MESSAGE_HONG_KONG_ISLAND";
        public const string MESSAGE_KOWLOON = "MESSAGE_KOWLOON";
        public const string MESSAGE_KOWLOON_BAY = "MESSAGE_KOWLOON_BAY";
        public const string MESSAGE_NEW_TERRITORIES = "MESSAGE_NEW_TERRITORIES";
        public const string MESSAGE_ISLANDS = "MESSAGE_ISLANDS";
        public const string MESSAGE_INCREASE = "MESSAGE_INCREASE";
        public const string MESSAGE_TOTAL_NUMBER_ORDERS = "MESSAGE_TOTAL_NUMBER_ORDERS";
        public const string MESSAGE_LAST_TRADING_HOURS = "MESSAGE_LAST_TRADING_HOURS";
        public const string MESSAGE_ORDER_STATUS = "MESSAGE_ORDER_STATUS";
        public const string MESSAGE_TRANSACTION_HISTORY = "MESSAGE_TRANSACTION_HISTORY";
        public const string MESSAGE_COMMODITY = "MESSAGE_COMMODITY";
        public const string MESSAGE_QUANTITY = "MESSAGE_QUANTITY";
        public const string MESSAGE_STATUS = "MESSAGE_STATUS";
        public const string MESSAGE_DELIVERY_INFORMATION = "MESSAGE_DELIVERY_INFORMATION";
        public const string MESSAGE_MESSAGE_DELIVERY = "MESSAGE_MESSAGE_DELIVERY";
        public const string MESSAGE_CANCELLED = "MESSAGE_CANCELLED";
        public const string MESSAGE_CANCEL_THE_ORDER = "MESSAGE_CANCEL_THE_ORDER";
        public const string MESSAGE_BEING_PROCESSED = "MESSAGE_BEING_PROCESSED";
        public const string MESSAGE_SHIPPING_BOX = "MESSAGE_SHIPPING_BOX";
        public const string MESSAGE_CARGO_SIZE = "MESSAGE_CARGO_SIZE";
        public const string MESSAGE_LENGTH = "MESSAGE_LENGTH";
        public const string MESSAGE_CARGO_WEIGHT = "MESSAGE_CARGO_WEIGHT";
        public const string MESSAGE_SHOP_TAKE_CHARGE = "MESSAGE_SHOP_TAKE_CHARGE";
        public const string MESSAGE_POINT_DELIVERY_CHARGES = "MESSAGE_POINT_DELIVERY_CHARGES";
        public const string MESSAGE_27_LENGTH = "MESSAGE_27_LENGTH";
        public const string MESSAGE_EQUAL_45_CM = "MESSAGE_EQUAL_45_CM";
        public const string MESSAGE_1_KG = "MESSAGE_1_KG";
        public const string MESSAGE_45_LENGTH = "MESSAGE_45_LENGTH";
        public const string MESSAGE_EQUAL_70_CM = "MESSAGE_EQUAL_70_CM";
        public const string MESSAGE_2_KG = "MESSAGE_2_KG";
        public const string MESSAGE_38_LENGTH = "MESSAGE_38_LENGTH";
        public const string MESSAGE_NOT_APPLICABLE = "MESSAGE_NOT_APPLICABLE";
        public const string MESSAGE_6_KG = "MESSAGE_6_KG";
        public const string MESSAGE_48_LENGTH = "MESSAGE_48_LENGTH";
        public const string MESSAGE_8_KG = "MESSAGE_8_KG";
        public const string MESSAGE_57_LENGTH = "MESSAGE_57_LENGTH";
        public const string MESSAGE_12_KG = "MESSAGE_12_KG";
        public const string MESSAGE_SMALLER_CAPACITY_CARGO = "MESSAGE_SMALLER_CAPACITY_CARGO";
        public const string MESSAGE_SUBTOTAL = "MESSAGE_SUBTOTAL";
        public const string MESSAGE_FREIGHT = "MESSAGE_FREIGHT";
        public const string MESSAGE_VERIFY_PHONE_NUMBER = "MESSAGE_VERIFY_PHONE_NUMBER";
        public const string MESSAGE_FIRST_PURCHASE = "MESSAGE_FIRST_PURCHASE";
        public const string MESSAGE_ENTER_YOUR_VERIFICATION = "MESSAGE_ENTER_YOUR_VERIFICATION";
        public const string MESSAGE_MOBILE_NUMBER = "MESSAGE_MOBILE_NUMBER";
        public const string MESSAGE_VERIFICATION_CODE = "MESSAGE_VERIFICATION_CODE";
        public const string MESSAGE_CONFIRM = "MESSAGE_CONFIRM";
        public const string MESSAGE_VERIFICATION_CODE_ERROR = "MESSAGE_VERIFICATION_CODE_ERROR";
        public const string MESSAGE_REISSUE_THE_VERIFICATION_CODE = "MESSAGE_REISSUE_THE_VERIFICATION_CODE";
        public const string MESSAGE_REPLACE_THE_PHONE_NUMBER = "MESSAGE_REPLACE_THE_PHONE_NUMBER";
        public const string MESSAGE_REFERRAL_PRODUCTS = "MESSAGE_REFERRAL_PRODUCTS";
        public const string MESSAGE_THEME_PROMOTION = "MESSAGE_THEME_PROMOTION";
        public const string MESSAGE_LATEST_FINE_POINTS = "MESSAGE_LATEST_FINE_POINTS";
        public const string MESSAGE_LIMITED_PERIOD = "MESSAGE_LIMITED_PERIOD";
        public const string MESSAGE_LIMITED_NUMBER = "MESSAGE_LIMITED_NUMBER";
        public const string MESSAGE_DIRECT_FREE_DELIVERY = "MESSAGE_DIRECT_FREE_DELIVERY";
        public const string MESSAGE_POINTING_SALE = "MESSAGE_POINTING_SALE";
        public const string MESSAGE_PURCHASE_EVALUATION = "MESSAGE_PURCHASE_EVALUATION";
        public const string MESSAGE_MEMBER = "MESSAGE_MEMBER";
        public const string MESSAGE_COMMENT = "MESSAGE_COMMENT";
        public const string MESSAGE_WRITE_EVALUATION = "MESSAGE_WRITE_EVALUATION";
        public const string MESSAGE_WRITE_A_COMMENT = "MESSAGE_WRITE_A_COMMENT";
        public const string MESSAGE_VIEW_ALL = "MESSAGE_VIEW_ALL";
        public const string MESSAGE_THE_REVIEWS = "MESSAGE_THE_REVIEWS";
        public const string MESSAGE_PRODUCT_EVALUATED = "MESSAGE_PRODUCT_EVALUATED";
        public const string MESSAGE_ONLY_MEMBERSHIP_COMMENTS = "MESSAGE_ONLY_MEMBERSHIP_COMMENTS";
        public const string MESSAGE_CATEGORY = "MESSAGE_CATEGORY";
        public const string MESSAGE_PRODUCT_DATE_ADDED = "MESSAGE_PRODUCT_DATE_ADDED";
        public const string MESSAGE_PRODUCT_INFORMATION = "MESSAGE_PRODUCT_INFORMATION";
        public const string MESSAGE_DEPOT_INFORMATION = "MESSAGE_DEPOT_INFORMATION";
        public const string MESSAGE_PRICE = "MESSAGE_PRICE";
        public const string MESSAGE_PRICE_FIGURES = "MESSAGE_PRICE_FIGURES";
        public const string MESSAGE_DETERMINE = "MESSAGE_DETERMINE";
        public const string MESSAGE_ANY_TIME = "MESSAGE_ANY_TIME";
        public const string MESSAGE_LAST24 = "MESSAGE_LAST24";
        public const string MESSAGE_LASTWEEK = "MESSAGE_LASTWEEK";
        public const string MESSAGE_CUSTOM = "MESSAGE_CUSTOM";
        public const string MESSAGE_EXCLUSIVE_MERCHANDISE = "MESSAGE_EXCLUSIVE_MERCHANDISE";
        public const string MESSAGE_DESIGNER_GOODS = "MESSAGE_DESIGNER_GOODS";
        public const string MESSAGE_DISCOUNT_GOODS = "MESSAGE_DISCOUNT_GOODS";
        public const string MESSAGE_EXCLUSIVE_SHOP = "MESSAGE_EXCLUSIVE_SHOP";
        public const string MESSAGE_TAKE_SHOP = "MESSAGE_TAKE_SHOP";
        public const string MESSAGE_DELIVERY_POINT = "MESSAGE_DELIVERY_POINT";
        public const string MESSAGE_TURNOVER_TIME = "MESSAGE_TURNOVER_TIME";
        public const string MESSAGE_SPANORDERTOTALAMOUNT = "MESSAGE_SPANORDERTOTALAMOUNT";
        public const string MESSAGE_ORDER_DETAILS = "MESSAGE_ORDER_DETAILS";
        public const string MESSAGE_PRICES = "MESSAGE_PRICES";
        public const string MESSAGE_PENDING = "MESSAGE_PENDING";
        public const string MESSAGE_BEEN_SERVED = "MESSAGE_BEEN_SERVED";
        public const string MESSAGE_COMPLETED = "MESSAGE_COMPLETED";
        public const string MESSAGE_TREATMENT = "MESSAGE_TREATMENT";
        public const string MESSAGE_HAS_RECEIVED = "MESSAGE_HAS_RECEIVED";
        public const string MESSAGE_SHIPPED = "MESSAGE_SHIPPED";
        public const string MESSAGE_UNCOLLECTED = "MESSAGE_UNCOLLECTED";
        public const string MESSAGE_PRICE_PAID = "MESSAGE_PRICE_PAID";
        public const string MESSAGE_UNPAID = "MESSAGE_UNPAID";
        public const string MESSAGE_RATED = "MESSAGE_RATED";
        public const string MESSAGE_NO_EVALUATION = "MESSAGE_NO_EVALUATION";
        public const string MESSAGE_PAYMENT_ONLY = "MESSAGE_PAYMENT_ONLY";
        public const string MESSAGE_ABOUTUSCONTENT = "MESSAGE_ABOUTUSCONTENT";
        public const string MESSAGE_ABOUTUSCONTENT_2 = "MESSAGE_ABOUTUSCONTENT_2";
        public const string MESSAGE_ABOUTUSCONTENT_3 = "MESSAGE_ABOUTUSCONTENT_3";
        public const string MESSAGE_ABOUTUSCONTENT_4 = "MESSAGE_ABOUTUSCONTENT_4";
        public const string MESSAGE_FENG_GROUP = "MESSAGE_FENG_GROUP";
        public const string MESSAGE_LISTED_COMPANIES = "MESSAGE_LISTED_COMPANIES";
        public const string MESSAGE_RETAIL_ASIA_LIMITED = "MESSAGE_RETAIL_ASIA_LIMITED";
        public const string MESSAGE_ABOUTUSCONTENT_5 = "MESSAGE_ABOUTUSCONTENT_5";
        public const string MESSAGE_BRICKS = "MESSAGE_BRICKS";
        public const string MESSAGE_2_DAYS_DELIVERY = "MESSAGE_2_DAYS_DELIVERY";
        public const string MESSAGE_ABOUTUSCONTENT_6 = "MESSAGE_ABOUTUSCONTENT_6";
        public const string MESSAGE_IN_HONG_KONG = "MESSAGE_IN_HONG_KONG";
        public const string MESSAGE_OK_CONVENIENCE_STORE = "MESSAGE_OK_CONVENIENCE_STORE";
        public const string MESSAGE_DELIVERY = "MESSAGE_DELIVERY";
        public const string MESSAGE_ABOUTUSCONTENT_7 = "MESSAGE_ABOUTUSCONTENT_7";
        public const string MESSAGE_CASH_ON_DELIVERY = "MESSAGE_CASH_ON_DELIVERY";
        public const string MESSAGE_ABOUTUSCONTENT_8 = "MESSAGE_ABOUTUSCONTENT_8";
        public const string MESSAGE_LITERALACCOUNT = "MESSAGE_LITERALACCOUNT";
        public const string MESSAGE_ADDRESS_CODE_2 = "MESSAGE_ADDRESS_CODE_2";
        public const string MESSAGE_ADDRESS_CODE_3 = "MESSAGE_ADDRESS_CODE_3";
        public const string MESSAGE_DELETE = "MESSAGE_DELETE";
        public const string MESSAGE_MODIFICATION = "MESSAGE_MODIFICATION";
        public const string MESSAGE_CANCEL_2 = "MESSAGE_CANCEL_2";
        public const string MESSAGE_PLEASE_ADD_ADDRESS = "MESSAGE_PLEASE_ADD_ADDRESS";
        public const string MESSAGE_SEARCH_RESULTS = "MESSAGE_SEARCH_RESULTS";
        public const string MESSAGE_SORT_BY = "MESSAGE_SORT_BY";
        public const string MESSAGE_ITEM_1 = "MESSAGE_ITEM_1";
        public const string MESSAGE_TOTAL_SEARCH_RESULTS = "MESSAGE_TOTAL_SEARCH_RESULTS";
        public const string MESSAGE_LOWEST = "MESSAGE_LOWEST";
        public const string MESSAGE_HIGHEST = "MESSAGE_HIGHEST";
        public const string MESSAGE_DISCOUNT = "MESSAGE_DISCOUNT";
        public const string MESSAGE_SEARCH_A_DISCOUNT = "MESSAGE_SEARCH_A_DISCOUNT";
        public const string MESSAGE_DELIVERY_METHODS = "MESSAGE_DELIVERY_METHODS";
        public const string MESSAGE_PICK_UP_THE_GOODS = "MESSAGE_PICK_UP_THE_GOODS";
        public const string MESSAGE_PRODUCT_FEATURES = "MESSAGE_PRODUCT_FEATURES";
        public const string MESSAGE_SEARCH_PRODUCT_FEATURES = "MESSAGE_SEARCH_PRODUCT_FEATURES";
        public const string MESSAGE_LATEST_RELEASED = "MESSAGE_LATEST_RELEASED";
        public const string MESSAGE_PRODUCTION_AREA = "MESSAGE_PRODUCTION_AREA";
        public const string MESSAGE_OCCASION = "MESSAGE_OCCASION";
        public const string MESSAGE_LOAD_MORE = "MESSAGE_LOAD_MORE";
        public const string MESSAGE_NEW_SEARCH = "MESSAGE_NEW_SEARCH";
        public const string MESSAGE_DEFAULT_SORT = "MESSAGE_DEFAULT_SORT";
        public const string MESSAGE_MOST_POPULAR = "MESSAGE_MOST_POPULAR";
        public const string MESSAGE_HIGHEST_RATING = "MESSAGE_HIGHEST_RATING";
        public const string MESSAGE_PRICE_LOW_TO_HIGH = "MESSAGE_PRICE_LOW_TO_HIGH";
        public const string MESSAGE_PRICE_FROM_HIGH_TO_LOW = "MESSAGE_PRICE_FROM_HIGH_TO_LOW";
        public const string MESSAGE_HIGHEST_DISCOUNT = "MESSAGE_HIGHEST_DISCOUNT";
        public const string MESSAGE_NO_SEARCH_RESULTS = "MESSAGE_NO_SEARCH_RESULTS";
        public const string MESSAGE_NO_SEARCH_RESEARCH = "MESSAGE_NO_SEARCH_RESEARCH";
        public const string MESSAGE_DID_NOT_FIND = "MESSAGE_DID_NOT_FIND";
        public const string MESSAGE_DID_NOMATCH = "MESSAGE_DID_NOMATCH";
        public const string MESSAGE_RELATED_GOODS = "MESSAGE_RELATED_GOODS";
        public const string MESSAGE_DID_NOT_FILTER_FIND = "MESSAGE_DID_NOT_FILTER_FIND";
        public const string MESSAGE_LOOKING_FOR = "MESSAGE_LOOKING_FOR";
        public const string MESSAGE_ALL_REGIONS = "MESSAGE_ALL_REGIONS";
        public const string MESSAGE_ALL_OBJECTS = "MESSAGE_ALL_OBJECTS";
        public const string MESSAGE_KEYWORD_SEARCH = "MESSAGE_KEYWORD_SEARCH";
        public const string MESSAGE_COMMODITY_PRICE = "MESSAGE_COMMODITY_PRICE";
        public const string MESSAGE_PRICE_FROM = "MESSAGE_PRICE_FROM";
        public const string MESSAGE_TO = "MESSAGE_TO";
        public const string MESSAGE_CBDISCOUNT = "MESSAGE_CBDISCOUNT";
        public const string MESSAGE_SHIPPING_METHODS = "MESSAGE_SHIPPING_METHODS";
        public const string MESSAGE_SEARCH = "MESSAGE_SEARCH";
        public const string MESSAGE_ALL_SEARCH = "MESSAGE_ALL_SEARCH";
        public const string MESSAGE_PRODUCT_NAME = "MESSAGE_PRODUCT_NAME";
        public const string MESSAGE_STORE_BRAND_NAME = "MESSAGE_STORE_BRAND_NAME";
        public const string MESSAGE_HOME_AND_INTERIOR = "MESSAGE_HOME_AND_INTERIOR";
        public const string MESSAGE_KIDS = "MESSAGE_KIDS";
        public const string MESSAGE_MOBILE_AND_DIGITAL = "MESSAGE_MOBILE_AND_DIGITAL";
        public const string MESSAGE_COMPACT_ELECTRONICS = "MESSAGE_COMPACT_ELECTRONICS";
        public const string MESSAGE_STATIONERY = "MESSAGE_STATIONERY";
        public const string MESSAGE_APPAREL_AND_ACCESSORIES = "MESSAGE_APPAREL_AND_ACCESSORIES";
        public const string MESSAGE_HEALTH_AND_BEAUTY = "MESSAGE_HEALTH_AND_BEAUTY";
        public const string MESSAGE_TRAVEL = "MESSAGE_TRAVEL";
        public const string MESSAGE_ALL_DESIGN = "MESSAGE_ALL_DESIGN";
        public const string MESSAGE_HONG_KONG = "MESSAGE_HONG_KONG";
        public const string MESSAGE_CHINA = "MESSAGE_CHINA";
        public const string MESSAGE_JAPAN = "MESSAGE_JAPAN";
        public const string MESSAGE_TAIWAN = "MESSAGE_TAIWAN";
        public const string MESSAGE_KOREA = "MESSAGE_KOREA";
        public const string MESSAGE_OTHER_ASIA = "MESSAGE_OTHER_ASIA";
        public const string MESSAGE_EUROPE_AND_AMERICA = "MESSAGE_EUROPE_AND_AMERICA";
        public const string MESSAGE_AUSTRALIA_AND_NEW_ZEALAND = "MESSAGE_AUSTRALIA_AND_NEW_ZEALAND";
        public const string MESSAGE_OTHER = "MESSAGE_OTHER";
        public const string MESSAGE_PARTNER = "MESSAGE_PARTNER";
        public const string MESSAGE_CHILDREN = "MESSAGE_CHILDREN";
        public const string MESSAGE_PETS = "MESSAGE_PETS";
        public const string MESSAGE_COMPANY = "MESSAGE_COMPANY";
        public const string MESSAGE_GRADUATION = "MESSAGE_GRADUATION";
        public const string MESSAGE_HOMES = "MESSAGE_HOMES";
        public const string MESSAGE_NEWLYWED = "MESSAGE_NEWLYWED";
        public const string MESSAGE_PARTY = "MESSAGE_PARTY";
        public const string MESSAGE_CBDISCOUNT_2 = "MESSAGE_CBDISCOUNT_2";
        public const string MESSAGE_SEARCH_CRITERIA = "MESSAGE_SEARCH_CRITERIA";
        public const string MESSAGE_NO_SEARCH_RESULTS_2 = "MESSAGE_NO_SEARCH_RESULTS_2";
        public const string MESSAGE_TITLE_BRAND = "MESSAGE_TITLE_BRAND";
        public const string MESSAGE_DESCRIPTIONTAG_BRAND = "MESSAGE_DESCRIPTIONTAG_BRAND";
        public const string MESSAGE_BRAND_SEARCH = "MESSAGE_BRAND_SEARCH";
        public const string MESSAGE_VIEW_ALL_BRANDS = "MESSAGE_VIEW_ALL_BRANDS";
        public const string MESSAGE_TOP_BRANDS = "MESSAGE_TOP_BRANDS";
        public const string MESSAGE_FEATURED_GIFTS = "MESSAGE_FEATURED_GIFTS";
        public const string MESSAGE_GIFT_MERCHANDISE = "MESSAGE_GIFT_MERCHANDISE";
        public const string MESSAGE_BETWEEN_BUSINESSES = "MESSAGE_BETWEEN_BUSINESSES";
        public const string MESSAGE_VIEW_ALL_PRODUCTS = "MESSAGE_VIEW_ALL_PRODUCTS";
        public const string MESSAGE_ALL = "MESSAGE_ALL";
        public const string MESSAGE_DELIVERY_2 = "MESSAGE_DELIVERY_2";
        public const string MESSAGE_LATEST_PROMOTION = "MESSAGE_LATEST_PROMOTION";
        public const string MESSAGE_LATEST_PROMOTION_2 = "MESSAGE_LATEST_PROMOTION_2";
        public const string MESSAGE_CLEARANCE = "MESSAGE_CLEARANCE";
        public const string MESSAGE_COMBINATION_OFFER = "MESSAGE_COMBINATION_OFFER";
        public const string MESSAGE_GOODS_PURCHASED = "MESSAGE_GOODS_PURCHASED";

        public const string MESSAGE_COMB_COUPON = "MESSAGE_COMB_COUPON";

        public const string MESSAGE_INVENTORY_SHORTAGE = "MESSAGE_INVENTORY_SHORTAGE";
        public const string MESSAGE_FOLLOWING_COMMODITY = "MESSAGE_FOLLOWING_COMMODITY";
        public const string MESSAGE_JUST_PIECES = "MESSAGE_JUST_PIECES";
        public const string MESSAGE_VALID_UNTIL = "MESSAGE_VALID_UNTIL";
        public const string MESSAGE_SELECT_SHIPPING_METHOD = "MESSAGE_SELECT_SHIPPING_METHOD";
        public const string MESSAGE_RECEIVING_THE_GIFT = "MESSAGE_RECEIVING_THE_GIFT";
        public const string MESSAGE_DELIVERY_NUMBER = "MESSAGE_DELIVERY_NUMBER";
        public const string MESSAGE_SERVICE_CENTER = "MESSAGE_SERVICE_CENTER";
        public const string MESSAGE_POINTING_AVAILABLE = "MESSAGE_POINTING_AVAILABLE";
        public const string MESSAGE_SEASONING_BOTTLE = "MESSAGE_SEASONING_BOTTLE";
        public const string MESSAGE_BUY_2 = "MESSAGE_BUY_2";
        public const string MESSAGE_CONTINUE_SHOPPING = "MESSAGE_CONTINUE_SHOPPING";
        public const string MESSAGE_NOTIFICATION_ISSUES = "MESSAGE_NOTIFICATION_ISSUES";
        public const string MESSAGE_ORDER_DETAILS_1 = "MESSAGE_ORDER_DETAILS_1";
        public const string MESSAGE_CUSTOMER_SERVICE_OFFICER = "MESSAGE_CUSTOMER_SERVICE_OFFICER";
        public const string MESSAGE_DESIRED_QUERY = "MESSAGE_DESIRED_QUERY";
        public const string MESSAGE_GETTING_STARTED = "MESSAGE_GETTING_STARTED";
        public const string MESSAGE_ENQUIRY_FORM = "MESSAGE_ENQUIRY_FORM";
        public const string MESSAGE_ANSWER_1 = "MESSAGE_ANSWER_1";
        public const string MESSAGE_ANSWER_2 = "MESSAGE_ANSWER_2";
        public const string MESSAGE_ANSWER_3 = "MESSAGE_ANSWER_3";
        public const string MESSAGE_ANSWER_4 = "MESSAGE_ANSWER_4";
        public const string MESSAGE_ANSWER_5 = "MESSAGE_ANSWER_5";
        public const string MESSAGE_ANSWER_6 = "MESSAGE_ANSWER_6";
        public const string MESSAGE_CONTACT_INFORMATION = "MESSAGE_CONTACT_INFORMATION";
        public const string MESSAGE_CALL_US = "MESSAGE_CALL_US";
        public const string MESSAGE_OPEN_TIME = "MESSAGE_OPEN_TIME";
        public const string MESSAGE_EMAIL_US = "MESSAGE_EMAIL_US";
        public const string MESSAGE_ANSWER_7 = "MESSAGE_ANSWER_7";
        public const string MESSAGE_DETAIL = "MESSAGE_DETAIL";
        public const string MESSAGE_HOTLINE = "MESSAGE_HOTLINE";
        public const string MESSAGE_GENERAL_CUSTOMER_INQUIRIES = "MESSAGE_GENERAL_CUSTOMER_INQUIRIES";
        public const string MESSAGE_CUSTOMER_SERVICE = "MESSAGE_CUSTOMER_SERVICE";
        public const string MESSAGE_TECHNICAL_SUPPORT = "MESSAGE_TECHNICAL_SUPPORT";
        public const string MESSAGE_COMMERCIAL_COOPERATION = "MESSAGE_COMMERCIAL_COOPERATION";
        public const string MESSAGE_COPYRIGHTDATE = "MESSAGE_COPYRIGHTDATE";
        public const string MESSAGE_COPYRIGHTCONTENT_1 = "MESSAGE_COPYRIGHTCONTENT_1";
        public const string MESSAGE_COPYRIGHTCONTENT_2 = "MESSAGE_COPYRIGHTCONTENT_2";
        public const string MESSAGE_COPYRIGHTCONTENT_3 = "MESSAGE_COPYRIGHTCONTENT_3";
        public const string MESSAGE_COPYRIGHTCONTENT_4 = "MESSAGE_COPYRIGHTCONTENT_4";
        public const string MESSAGE_COPYRIGHTCONTENT_5 = "MESSAGE_COPYRIGHTCONTENT_5";
        public const string MESSAGE_COPYRIGHTCONTENT_6 = "MESSAGE_COPYRIGHTCONTENT_6";
        public const string MESSAGE_COPYRIGHTCONTENT_7 = "MESSAGE_COPYRIGHTCONTENT_7";
        public const string MESSAGE_COPYRIGHTCONTENT_8 = "MESSAGE_COPYRIGHTCONTENT_8";
        public const string MESSAGE_COPYRIGHTCONTENT_9 = "MESSAGE_COPYRIGHTCONTENT_9";
        public const string MESSAGE_COPYRIGHTCONTENT_10 = "MESSAGE_COPYRIGHTCONTENT_10";
        public const string MESSAGE_COPYRIGHTCONTENT_11 = "MESSAGE_COPYRIGHTCONTENT_11";
        public const string MESSAGE_COPYRIGHTCONTENT_12 = "MESSAGE_COPYRIGHTCONTENT_12";
        public const string MESSAGE_COPYRIGHTCONTENT_13 = "MESSAGE_COPYRIGHTCONTENT_13";
        public const string MESSAGE_COPYRIGHTCONTENT_14 = "MESSAGE_COPYRIGHTCONTENT_14";
        public const string MESSAGE_COPYRIGHTCONTENT_15 = "MESSAGE_COPYRIGHTCONTENT_15";
        public const string MESSAGE_INQUIRY = "MESSAGE_INQUIRY";
        public const string MESSAGE_OFFER_NUMBER = "MESSAGE_OFFER_NUMBER";
        public const string MESSAGE_ELECTRONIC_COUPON_NAME = "MESSAGE_ELECTRONIC_COUPON_NAME";
        public const string MESSAGE_EFFECTIVE_DATE = "MESSAGE_EFFECTIVE_DATE";
        public const string MESSAGE_DUE_DATE = "MESSAGE_DUE_DATE";
        public const string MESSAGE_VALUE = "MESSAGE_VALUE";
        public const string MESSAGE_FINGERSHOPPING_CASH_COUPON = "MESSAGE_FINGERSHOPPING_CASH_COUPON";
        public const string MESSAGE_UNUSED = "MESSAGE_UNUSED";
        public const string MESSAGE_EXPIRED_1 = "MESSAGE_EXPIRED_1";
        public const string MESSAGE_USED_ORDER_NUMBER = "MESSAGE_USED_ORDER_NUMBER";
        public const string MESSAGE_CANCELLED_ORDER_NUMBER = "MESSAGE_CANCELLED_ORDER_NUMBER";
        public const string MESSAGE_VIEW = "MESSAGE_VIEW";
        public const string MESSAGE_TERMS_OF_USE = "MESSAGE_TERMS_OF_USE";
        public const string MESSAGE_THE_USE_OF_CASH = "MESSAGE_THE_USE_OF_CASH";
        public const string MESSAGE_SHUT_DOWN = "MESSAGE_SHUT_DOWN";
        public const string MESSAGE_MY_E_COUPONS = "MESSAGE_MY_E_COUPONS";
        public const string MESSAGE_POINTINGFINGERSHOPPING_2 = "MESSAGE_POINTINGFINGERSHOPPING_2";
        public const string MESSAGE_ELECTRONIC_TICKET_RECORD = "MESSAGE_ELECTRONIC_TICKET_RECORD";
        public const string MESSAGE_ELECTRONIC_COUPONS = "MESSAGE_ELECTRONIC_COUPONS";
        public const string MESSAGE_EXPIRED_ELECTRONIC_VOUCHER = "MESSAGE_EXPIRED_ELECTRONIC_VOUCHER";
        public const string MESSAGE_GUIDE_ANSWER_1 = "MESSAGE_GUIDE_ANSWER_1";
        public const string MESSAGE_GUIDE_ANSWER_2 = "MESSAGE_GUIDE_ANSWER_2";
        public const string MESSAGE_GUIDE_ANSWER_3 = "MESSAGE_GUIDE_ANSWER_3";
        public const string MESSAGE_GUIDE_ANSWER_4 = "MESSAGE_GUIDE_ANSWER_4";
        public const string MESSAGE_ADD_TO_MY_FAVORITE = "MESSAGE_ADD_TO_MY_FAVORITE";
        public const string MESSAGE_SHARE_WITH_YOUR_FRIENDS = "MESSAGE_SHARE_WITH_YOUR_FRIENDS";
        public const string MESSAGE_GUIDE_ANSWER_5 = "MESSAGE_GUIDE_ANSWER_5";
        public const string MESSAGE_BACK_TO_TOP = "MESSAGE_BACK_TO_TOP";
        public const string MESSAGE_GUIDE_ANSWER_6 = "MESSAGE_GUIDE_ANSWER_6";
        public const string MESSAGE_GUIDE_ANSWER_7 = "MESSAGE_GUIDE_ANSWER_7";
        public const string MESSAGE_GUIDE_ANSWER_8 = "MESSAGE_GUIDE_ANSWER_8";
        public const string MESSAGE_LEFT_HOME_PAGE = "MESSAGE_LEFT_HOME_PAGE";
        public const string MESSAGE_LOGIN_2 = "MESSAGE_LOGIN_2";
        public const string MESSAGE_GUIDE_ANSWER_9 = "MESSAGE_GUIDE_ANSWER_9";
        public const string MESSAGE_LEFT_HOME_PAGE_2 = "MESSAGE_LEFT_HOME_PAGE_2";
        public const string MESSAGE_GUIDE_ANSWER_10 = "MESSAGE_GUIDE_ANSWER_10";
        public const string MESSAGE_GUIDE_ANSWER_11 = "MESSAGE_GUIDE_ANSWER_11";
        public const string MESSAGE_IT = "MESSAGE_IT";
        public const string MESSAGE_GUIDE_ANSWER_12 = "MESSAGE_GUIDE_ANSWER_12";
        public const string MESSAGE_GUIDE_ANSWER_13 = "MESSAGE_GUIDE_ANSWER_13";
        public const string MESSAGE_EDIT_ACCOUNT_INFORMATION = "MESSAGE_EDIT_ACCOUNT_INFORMATION";
        public const string MESSAGE_FORGOT_PASSWORD_2 = "MESSAGE_FORGOT_PASSWORD_2";
        public const string MESSAGE_CHANGE_OK_CONVENIENCE = "MESSAGE_CHANGE_OK_CONVENIENCE";
        public const string MESSAGE_CHECK_ORDER = "MESSAGE_CHECK_ORDER";
        public const string MESSAGE_VIEW_MY_EVALUATION = "MESSAGE_VIEW_MY_EVALUATION";
        public const string MESSAGE_RELATED_NUMBER_DESCRIPTION = "MESSAGE_RELATED_NUMBER_DESCRIPTION";
        public const string MESSAGE_ACCMAN_1 = "MESSAGE_ACCMAN_1";
        public const string MESSAGE_ACCMAN_2 = "MESSAGE_ACCMAN_2";
        public const string MESSAGE_ACCMAN_3 = "MESSAGE_ACCMAN_3";
        public const string MESSAGE_ACCMAN_4 = "MESSAGE_ACCMAN_4";
        public const string MESSAGE_ACCMAN_5 = "MESSAGE_ACCMAN_5";
        public const string MESSAGE_ACCMAN_6 = "MESSAGE_ACCMAN_6";
        public const string MESSAGE_ACCMAN_7 = "MESSAGE_ACCMAN_7";
        public const string MESSAGE_ACCMAN_8 = "MESSAGE_ACCMAN_8";
        public const string MESSAGE_ACCMAN_9 = "MESSAGE_ACCMAN_9";
        public const string MESSAGE_ACCMAN_10 = "MESSAGE_ACCMAN_10";
        public const string MESSAGE_ACCMAN_11 = "MESSAGE_ACCMAN_11";
        public const string MESSAGE_ACCMAN_12 = "MESSAGE_ACCMAN_12";
        public const string MESSAGE_ACCMAN_13 = "MESSAGE_ACCMAN_13";
        public const string MESSAGE_EXPLANATION = "MESSAGE_EXPLANATION";
        public const string MESSAGE_AWAITING_PROCESSING = "MESSAGE_AWAITING_PROCESSING";

        public const string MESSAGE_BEING_PROCESSED_2 = "MESSAGE_BEING_PROCESSED_2";
        public const string MESSAGE_HAS_BEEN_CANCELED = "MESSAGE_HAS_BEEN_CANCELED";
        public const string MESSAGE_IS_COMPLETED = "MESSAGE_IS_COMPLETED";
        public const string MESSAGE_RETURN = "MESSAGE_RETURN";
        public const string MESSAGE_PRODUCT_STATUS = "MESSAGE_PRODUCT_STATUS";
        public const string MESSAGE_TO_BE_PROCESSED = "MESSAGE_TO_BE_PROCESSED";
        public const string MESSAGE_IS_BEING_PROCESSED = "MESSAGE_IS_BEING_PROCESSED";
        public const string MESSAGE_TRANSIT = "MESSAGE_TRANSIT";
        public const string MESSAGE_IN_TRANSIT = "MESSAGE_IN_TRANSIT";
        public const string MESSAGE_TO_THE_SHOP = "MESSAGE_TO_THE_SHOP";
        public const string MESSAGE_WAITING_FOR_CUSTOMERS = "MESSAGE_WAITING_FOR_CUSTOMERS";
        public const string MESSAGE_HAS_DELIVERY = "MESSAGE_HAS_DELIVERY";
        public const string MESSAGE_EXTRACTED_AND_SIGN = "MESSAGE_EXTRACTED_AND_SIGN";
        public const string MESSAGE_HAS_RECEIPT = "MESSAGE_HAS_RECEIPT";
        public const string MESSAGE_DELIVERED_TO_AND_RECEIPT = "MESSAGE_DELIVERED_TO_AND_RECEIPT";
        public const string MESSAGE_RETURN_THE_APPLICATION = "MESSAGE_RETURN_THE_APPLICATION";
        public const string MESSAGE_GOODS_RETURNS = "MESSAGE_GOODS_RETURNS";
        public const string MESSAGE_TAKE_OVERDUE = "MESSAGE_TAKE_OVERDUE";
        public const string MESSAGE_ACCMAN_14 = "MESSAGE_ACCMAN_14";
        public const string MESSAGE_TO_BE_PUT = "MESSAGE_TO_BE_PUT";
        public const string MESSAGE_ACCMAN_15 = "MESSAGE_ACCMAN_15";
        public const string MESSAGE_COMMODITY_TRADING = "MESSAGE_COMMODITY_TRADING";
        public const string MESSAGE_IS_CANCELED = "MESSAGE_IS_CANCELED";
        public const string MESSAGE_ACCMAN_16 = "MESSAGE_ACCMAN_16";
        public const string MESSAGE_COMMODITY_TRADING_2 = "MESSAGE_COMMODITY_TRADING_2";
        public const string MESSAGE_PAYMENT_STATUS = "MESSAGE_PAYMENT_STATUS";
        public const string MESSAGE_PAY_FOR_GOODS = "MESSAGE_PAY_FOR_GOODS";
        public const string MESSAGE_PAID = "MESSAGE_PAID";
        public const string MESSAGE_HAVE_BEEN_PAID = "MESSAGE_HAVE_BEEN_PAID";
        public const string MESSAGE_A_REFUND = "MESSAGE_A_REFUND";
        public const string MESSAGE_REFUND_REQUEST__PROCESSED = "MESSAGE_REFUND_REQUEST__PROCESSED";
        public const string MESSAGE_EVALUATION_OF_STATE = "MESSAGE_EVALUATION_OF_STATE";
        public const string MESSAGE_ACCMAN_17 = "MESSAGE_ACCMAN_17";
        public const string MESSAGE_PICK_UP = "MESSAGE_PICK_UP";
        public const string MESSAGE_ACCMAN_18 = "MESSAGE_ACCMAN_18";
        public const string MESSAGE_HAS_MADE_ASSESSMENT = "MESSAGE_HAS_MADE_ASSESSMENT";
        public const string MESSAGE_ACCMAN_19 = "MESSAGE_ACCMAN_19";
        public const string MESSAGE_ACCMAN_20 = "MESSAGE_ACCMAN_20";
        public const string MESSAGE_ACCMAN_21 = "MESSAGE_ACCMAN_21";
        public const string MESSAGE_ACCMAN_22 = "MESSAGE_ACCMAN_22";
        public const string MESSAGE_ACCMAN_23 = "MESSAGE_ACCMAN_23";
        public const string MESSAGE_ACCMAN_24 = "MESSAGE_ACCMAN_24";
        public const string MESSAGE_TRACK_SHIPMENTS = "MESSAGE_TRACK_SHIPMENTS";
        public const string MESSAGE_DELIVERY_NUMBER_2 = "MESSAGE_DELIVERY_NUMBER_2";
        public const string MESSAGE_ACCMAN_25 = "MESSAGE_ACCMAN_25";
        public const string MESSAGE_TRANSACTION_NUMBER = "MESSAGE_TRANSACTION_NUMBER";
        public const string MESSAGE_ACCMAN_26 = "MESSAGE_ACCMAN_26";
        public const string MESSAGE_ACCMAN_27 = "MESSAGE_ACCMAN_27";
        public const string MESSAGE_ACCMAN_28 = "MESSAGE_ACCMAN_28";
        public const string MESSAGE_ACCMAN_29 = "MESSAGE_ACCMAN_29";
        public const string MESSAGE_BUYERS_RULE = "MESSAGE_BUYERS_RULE";
        public const string MESSAGE_FINGERSHOPPING_SHOPPING_PROCESS = "MESSAGE_FINGERSHOPPING_SHOPPING_PROCESS";
        public const string MESSAGE_ENSURE_THAT_KAI = "MESSAGE_ENSURE_THAT_KAI";
        public const string MESSAGE_GIFTS_METHODS = "MESSAGE_GIFTS_METHODS";
        public const string MESSAGE_GUIDE_BUY_2 = "MESSAGE_GUIDE_BUY_2";
        public const string MESSAGE_STEP = "MESSAGE_STEP";
        public const string MESSAGE_GUIDE_BUY_3 = "MESSAGE_GUIDE_BUY_3";
        public const string MESSAGE_GUIDE_BUY_4 = "MESSAGE_GUIDE_BUY_4";
        public const string MESSAGE_GUIDE_BUY_5 = "MESSAGE_GUIDE_BUY_5";
        public const string MESSAGE_GUIDE_BUY_6 = "MESSAGE_GUIDE_BUY_6";
        public const string MESSAGE_GUIDE_BUY_7 = "MESSAGE_GUIDE_BUY_7";
        public const string MESSAGE_GUIDE_BUY_8 = "MESSAGE_GUIDE_BUY_8";
        public const string MESSAGE_GUIDE_BUY_9 = "MESSAGE_GUIDE_BUY_9";
        public const string MESSAGE_GUIDE_BUY_10 = "MESSAGE_GUIDE_BUY_10";
        public const string MESSAGE_GUIDE_BUY_11 = "MESSAGE_GUIDE_BUY_11";
        public const string MESSAGE_GUIDE_BUY_12 = "MESSAGE_GUIDE_BUY_12";
        public const string MESSAGE_GUIDE_BUY_13 = "MESSAGE_GUIDE_BUY_13";
        public const string MESSAGE_GUIDE_BUY_14 = "MESSAGE_GUIDE_BUY_14";
        public const string MESSAGE_GUIDE_BUY_15 = "MESSAGE_GUIDE_BUY_15";
        public const string MESSAGE_GUIDE_BUY_16 = "MESSAGE_GUIDE_BUY_16";
        public const string MESSAGE_GUIDE_BUY_17 = "MESSAGE_GUIDE_BUY_17";
        public const string MESSAGE_GUIDE_BUY_18 = "MESSAGE_GUIDE_BUY_18";
        public const string MESSAGE_GUIDE_BUY_19 = "MESSAGE_GUIDE_BUY_19";
        public const string MESSAGE_GUIDE_BUY_20 = "MESSAGE_GUIDE_BUY_20";
        public const string MESSAGE_GUIDE_BUY_21 = "MESSAGE_GUIDE_BUY_21";
        public const string MESSAGE_GUIDE_BUY_22 = "MESSAGE_GUIDE_BUY_22";
        public const string MESSAGE_GUIDE_BUY_23 = "MESSAGE_GUIDE_BUY_23";
        public const string MESSAGE_GUIDE_BUY_24 = "MESSAGE_GUIDE_BUY_24";
        public const string MESSAGE_DELIVERY_METHODS_AND_TIME = "MESSAGE_DELIVERY_METHODS_AND_TIME";
        public const string MESSAGE_DISTRIBUTION_COSTS_CATEGORY = "MESSAGE_DISTRIBUTION_COSTS_CATEGORY";
        public const string MESSAGE_SHOP_FETCH_DETAILS = "MESSAGE_SHOP_FETCH_DETAILS";
        public const string MESSAGE_DELIVERY_DETAILS = "MESSAGE_DELIVERY_DETAILS";
        public const string MESSAGE_GUIDE_DELIVERY = "MESSAGE_GUIDE_DELIVERY";
        public const string MESSAGE_GUIDE_DELIVERY_1 = "MESSAGE_GUIDE_DELIVERY_1";
        public const string MESSAGE_GUIDE_DELIVERY_2 = "MESSAGE_GUIDE_DELIVERY_2";
        public const string MESSAGE_GUIDE_DELIVERY_3 = "MESSAGE_GUIDE_DELIVERY_3";
        public const string MESSAGE_GUIDE_DELIVERY_4 = "MESSAGE_GUIDE_DELIVERY_4";
        public const string MESSAGE_DELIVERY_TIME = "MESSAGE_DELIVERY_TIME";
        public const string MESSAGE_DELIVERY_TIME_MC = "MESSAGE_DELIVERY_TIME_MC";
        public const string MESSAGE_DELIVERY_TIME_MCK = "MESSAGE_DELIVERY_TIME_MCK";
        public const string MESSAGE_CONFIRM_ORDER_TIME = "MESSAGE_CONFIRM_ORDER_TIME";
        public const string MESSAGE_TIME_TO_SEND = "MESSAGE_TIME_TO_SEND";
        public const string MESSAGE_GUIDE_DELIVERY_5 = "MESSAGE_GUIDE_DELIVERY_5";
        public const string MESSAGE_GUIDE_DELIVERY_6 = "MESSAGE_GUIDE_DELIVERY_6";
        public const string MESSAGE_GUIDE_DELIVERY_7 = "MESSAGE_GUIDE_DELIVERY_7";
        public const string MESSAGE_GUIDE_DELIVERY_8 = "MESSAGE_GUIDE_DELIVERY_8";
        public const string MESSAGE_PRECAUTIONS = "MESSAGE_PRECAUTIONS";
        public const string MESSAGE_GUIDE_DELIVERY_9 = "MESSAGE_GUIDE_DELIVERY_9";
        public const string MESSAGE_GUIDE_DELIVERY_10 = "MESSAGE_GUIDE_DELIVERY_10";
        public const string MESSAGE_GUIDE_DELIVERY_11 = "MESSAGE_GUIDE_DELIVERY_11";
        public const string MESSAGE_GUIDE_DELIVERY_13 = "MESSAGE_GUIDE_DELIVERY_13";
        public const string MESSAGE_GUIDE_DELIVERY_12 = "MESSAGE_GUIDE_DELIVERY_12";
        public const string MESSAGE_GUIDE_DELIVERY_120 = "MESSAGE_GUIDE_DELIVERY_120";
        public const string MESSAGE_GUIDE_DELIVERY_14 = "MESSAGE_GUIDE_DELIVERY_14";
        public const string MESSAGE_GUIDE_DELIVERY_15 = "MESSAGE_GUIDE_DELIVERY_15";
        public const string MESSAGE_GUIDE_DELIVERY_16 = "MESSAGE_GUIDE_DELIVERY_16";
        public const string MESSAGE_SHIPPING_BAGS = "MESSAGE_SHIPPING_BAGS";
        public const string MESSAGE_ACCOMMODATE_THE_SIZE = "MESSAGE_ACCOMMODATE_THE_SIZE";
        public const string MESSAGE_WEIGHT_CAN_ACCOMMODATE = "MESSAGE_WEIGHT_CAN_ACCOMMODATE";
        public const string MESSAGE_S_CARGO_BAG = "MESSAGE_S_CARGO_BAG";
        public const string MESSAGE_GUIDE_DELIVERY_17 = "MESSAGE_GUIDE_DELIVERY_17";
        public const string MESSAGE_GUIDE_DELIVERY_18 = "MESSAGE_GUIDE_DELIVERY_18";
        public const string MESSAGE_GUIDE_DELIVERY_19 = "MESSAGE_GUIDE_DELIVERY_19";
        public const string MESSAGE_A_CARGO_BAG = "MESSAGE_A_CARGO_BAG";
        public const string MESSAGE_GUIDE_DELIVERY_20 = "MESSAGE_GUIDE_DELIVERY_20";
        public const string MESSAGE_GUIDE_DELIVERY_21 = "MESSAGE_GUIDE_DELIVERY_21";
        public const string MESSAGE_GUIDE_DELIVERY_22 = "MESSAGE_GUIDE_DELIVERY_22";
        public const string MESSAGE_B_CARGO_BAG = "MESSAGE_B_CARGO_BAG";
        public const string MESSAGE_C_CARGO_BAG = "MESSAGE_C_CARGO_BAG";
        public const string MESSAGE_D_CARGO_BAG = "MESSAGE_D_CARGO_BAG";
        public const string MESSAGE_GUIDE_DELIVERY_23 = "MESSAGE_GUIDE_DELIVERY_23";
        public const string MESSAGE_REMARK = "MESSAGE_REMARK";
        public const string MESSAGE_GUIDE_DELIVERY_24 = "MESSAGE_GUIDE_DELIVERY_24";
        public const string MESSAGE_GUIDE_DELIVERY_25 = "MESSAGE_GUIDE_DELIVERY_25";
        public const string MESSAGE_GUIDE_DELIVERY_26 = "MESSAGE_GUIDE_DELIVERY_26";
        public const string MESSAGE_GUIDE_DELIVERY_27 = "MESSAGE_GUIDE_DELIVERY_27";
        public const string MESSAGE_GUIDE_DELIVERY_28 = "MESSAGE_GUIDE_DELIVERY_28";
        public const string MESSAGE_GUIDE_DELIVERY_29 = "MESSAGE_GUIDE_DELIVERY_29";
        public const string MESSAGE_GUIDE_DELIVERY_30 = "MESSAGE_GUIDE_DELIVERY_30";
        public const string MESSAGE_GUIDE_DELIVERY_31 = "MESSAGE_GUIDE_DELIVERY_31";
        public const string MESSAGE_GUIDE_DELIVERY_32 = "MESSAGE_GUIDE_DELIVERY_32";
        public const string MESSAGE_SERVICE_FEES = "MESSAGE_SERVICE_FEES";
        public const string MESSAGE_GUIDE_DELIVERY_33 = "MESSAGE_GUIDE_DELIVERY_33";
        public const string MESSAGE_DELIVERY_TERMS_AND_CONDITIONS = "MESSAGE_DELIVERY_TERMS_AND_CONDITIONS";

        public const string MESSAGE_GUIDE_DELIVERY_34 = "MESSAGE_GUIDE_DELIVERY_34";
        public const string MESSAGE_GUIDE_DELIVERY_35 = "MESSAGE_GUIDE_DELIVERY_35";
        public const string MESSAGE_GUIDE_DELIVERY_36 = "MESSAGE_GUIDE_DELIVERY_36";
        public const string MESSAGE_GUIDE_DELIVERY_37 = "MESSAGE_GUIDE_DELIVERY_37";
        public const string MESSAGE_GUIDE_DELIVERY_38 = "MESSAGE_GUIDE_DELIVERY_38";
        public const string MESSAGE_GUIDE_DELIVERY_39 = "MESSAGE_GUIDE_DELIVERY_39";
        public const string MESSAGE_GUIDE_DELIVERY_40 = "MESSAGE_GUIDE_DELIVERY_40";
        public const string MESSAGE_GUIDE_DELIVERY_41 = "MESSAGE_GUIDE_DELIVERY_41";
        public const string MESSAGE_GUIDE_DELIVERY_42 = "MESSAGE_GUIDE_DELIVERY_42";
        public const string MESSAGE_GUIDE_DELIVERY_43 = "MESSAGE_GUIDE_DELIVERY_43";
        public const string MESSAGE_GUIDE_DELIVERY_44 = "MESSAGE_GUIDE_DELIVERY_44";
        public const string MESSAGE_GUIDE_DELIVERY_45 = "MESSAGE_GUIDE_DELIVERY_45";
        public const string MESSAGE_DELIVERY_TABLE = "MESSAGE_DELIVERY_TABLE";
        public const string MESSAGE_THIRD_PARTY_LOGISTICS = "MESSAGE_THIRD_PARTY_LOGISTICS";

        public const string MESSAGE_GUIDE_DELIVERY_46 = "MESSAGE_GUIDE_DELIVERY_46";
        public const string MESSAGE_GUIDE_DELIVERY_47 = "MESSAGE_GUIDE_DELIVERY_47";
        public const string MESSAGE_GUIDE_DELIVERY_48 = "MESSAGE_GUIDE_DELIVERY_48";
        public const string MESSAGE_NO_DELIVERY = "MESSAGE_NO_DELIVERY";
        public const string MESSAGE_DELIVERY_3 = "MESSAGE_DELIVERY_3";
        public const string MESSAGE_GUIDE_DELIVERY_49 = "MESSAGE_GUIDE_DELIVERY_49";
        public const string MESSAGE_GUIDE_DELIVERY_50 = "MESSAGE_GUIDE_DELIVERY_50";
        public const string MESSAGE_GUIDE_DELIVERY_51 = "MESSAGE_GUIDE_DELIVERY_51";
        public const string MESSAGE_GUIDE_DELIVERY_52 = "MESSAGE_GUIDE_DELIVERY_52";
        public const string MESSAGE_GUIDE_DELIVERY_53 = "MESSAGE_GUIDE_DELIVERY_53";

        public const string MESSAGE_GUIDE_DELIVERY_54 = "MESSAGE_GUIDE_DELIVERY_54";
        public const string MESSAGE_GUIDE_DELIVERY_55 = "MESSAGE_GUIDE_DELIVERY_55";
        public const string MESSAGE_GUIDE_DELIVERY_56 = "MESSAGE_GUIDE_DELIVERY_56";
        public const string MESSAGE_GUIDE_DELIVERY_57 = "MESSAGE_GUIDE_DELIVERY_57";
        public const string MESSAGE_GUIDE_DELIVERY_58 = "MESSAGE_GUIDE_DELIVERY_58";
        public const string MESSAGE_GUIDE_DELIVERY_59 = "MESSAGE_GUIDE_DELIVERY_59";
        public const string MESSAGE_GUIDE_DELIVERY_60 = "MESSAGE_GUIDE_DELIVERY_60";


        public const string MESSAGE_GUIDE_DELIVERY_61 = "MESSAGE_GUIDE_DELIVERY_61";
        public const string MESSAGE_GUIDE_DELIVERY_62 = "MESSAGE_GUIDE_DELIVERY_62";
        public const string MESSAGE_GUIDE_DELIVERY_63 = "MESSAGE_GUIDE_DELIVERY_63";
        public const string MESSAGE_GUIDE_DELIVERY_64 = "MESSAGE_GUIDE_DELIVERY_64";

        public const string MESSAGE_GUIDE_DELIVERY_65 = "MESSAGE_GUIDE_DELIVERY_65";
        public const string MESSAGE_GUIDE_DELIVERY_66 = "MESSAGE_GUIDE_DELIVERY_66";
        public const string MESSAGE_GUIDE_DELIVERY_67 = "MESSAGE_GUIDE_DELIVERY_67";
        public const string MESSAGE_GUIDE_DELIVERY_68 = "MESSAGE_GUIDE_DELIVERY_68";
        public const string MESSAGE_GUIDE_DELIVERY_69 = "MESSAGE_GUIDE_DELIVERY_69";
        public const string MESSAGE_GUIDE_DELIVERY_70 = "MESSAGE_GUIDE_DELIVERY_70";
        public const string MESSAGE_GUIDE_DELIVERY_71 = "MESSAGE_GUIDE_DELIVERY_71";
        public const string MESSAGE_GUIDE_DELIVERY_72 = "MESSAGE_GUIDE_DELIVERY_72";
        public const string MESSAGE_GUIDE_DELIVERY_73 = "MESSAGE_GUIDE_DELIVERY_73";
        public const string MESSAGE_GUIDE_DELIVERY_74 = "MESSAGE_GUIDE_DELIVERY_74";
        public const string MESSAGE_GUIDE_DELIVERY_75 = "MESSAGE_GUIDE_DELIVERY_75";
        public const string MESSAGE_GUIDE_DELIVERY_76 = "MESSAGE_GUIDE_DELIVERY_76";
        public const string MESSAGE_GUIDE_DELIVERY_77 = "MESSAGE_GUIDE_DELIVERY_77";
        public const string MESSAGE_GUIDE_DELIVERY_78 = "MESSAGE_GUIDE_DELIVERY_78";
        public const string MESSAGE_DISTRIBUTION_COSTS = "MESSAGE_DISTRIBUTION_COSTS";

        public const string MESSAGE_POINTING_SHOPPING = "MESSAGE_POINTING_SHOPPING";
        public const string MESSAGE_DELIVERY_AND_PAYMENT = "MESSAGE_DELIVERY_AND_PAYMENT";
        public const string MESSAGE_COMPLETION_TRANSACTION = "MESSAGE_COMPLETION_TRANSACTION";
        public const string MESSAGE_PRESS = "MESSAGE_PRESS";
        public const string MESSAGE_SIMPLE_PERSONAL_INFORMATION = "MESSAGE_SIMPLE_PERSONAL_INFORMATION";
        public const string MESSAGE_THE_APPLICATION = "MESSAGE_THE_APPLICATION";
        public const string MESSAGE_GUIDE_JOIN = "MESSAGE_GUIDE_JOIN";
        public const string MESSAGE_GUIDE_JOIN_1 = "MESSAGE_GUIDE_JOIN_1";
        public const string MESSAGE_GUIDE_JOIN_2 = "MESSAGE_GUIDE_JOIN_2";
        public const string MESSAGE_GUIDE_JOIN_3 = "MESSAGE_GUIDE_JOIN_3";
        public const string MESSAGE_STORE_TO_TAKE = "MESSAGE_STORE_TO_TAKE";
        public const string MESSAGE_DELIVERY_PERIOD_AND_SHOPS = "MESSAGE_DELIVERY_PERIOD_AND_SHOPS";
        public const string MESSAGE_SELECT_THE_PAYMENT_METHOD = "MESSAGE_SELECT_THE_PAYMENT_METHOD";
        public const string MESSAGE_GUIDE_JOIN_4 = "MESSAGE_GUIDE_JOIN_4";
        public const string MESSAGE_GUIDE_JOIN_5 = "MESSAGE_GUIDE_JOIN_5";
        public const string MESSAGE_GUIDE_JOIN_6 = "MESSAGE_GUIDE_JOIN_6";
        public const string MESSAGE_GUIDE_JOIN_10 = "MESSAGE_GUIDE_JOIN_10";
        public const string MESSAGE_GUIDE_JOIN_7 = "MESSAGE_GUIDE_JOIN_7";
        public const string MESSAGE_GUIDE_JOIN_8 = "MESSAGE_GUIDE_JOIN_8";
        public const string MESSAGE_GUIDE_JOIN_9 = "MESSAGE_GUIDE_JOIN_9";
        public const string MESSAGE_GUIDE_JOIN_11 = "MESSAGE_GUIDE_JOIN_11";
        public const string MESSAGE_GUIDE_JOIN_12 = "MESSAGE_GUIDE_JOIN_12";

        public const string MESSAGE_GUIDE_JOINVENDOR = "MESSAGE_GUIDE_JOINVENDOR";
        public const string MESSAGE_SELLERS_RULES = "MESSAGE_SELLERS_RULES";
        public const string MESSAGE_GUIDE_JOINVENDOR_1 = "MESSAGE_GUIDE_JOINVENDOR_1";
        public const string MESSAGE_GUIDE_JOINVENDOR_2 = "MESSAGE_GUIDE_JOINVENDOR_2";
        public const string MESSAGE_GUIDE_JOINVENDOR_3 = "MESSAGE_GUIDE_JOINVENDOR_3";

        public const string MESSAGE_PAYMENT_METHOD_2 = "MESSAGE_PAYMENT_METHOD_2";
        public const string MESSAGE_USE_OF_ELECTRONIC_VOUCHERS = "MESSAGE_USE_OF_ELECTRONIC_VOUCHERS";
        public const string MESSAGE_FEE_OVERVIEW_TABLE = "MESSAGE_FEE_OVERVIEW_TABLE";
        public const string MESSAGE_PAYMENT_TERMS_AND_CONDITIONS = "MESSAGE_PAYMENT_TERMS_AND_CONDITIONS";
        public const string MESSAGE_THE_FOLLOWING_PAYMENT_METHODS = "MESSAGE_THE_FOLLOWING_PAYMENT_METHODS";
        public const string MESSAGE_DELIVERY_PAYMENT_METHOD = "MESSAGE_DELIVERY_PAYMENT_METHOD";
        public const string MESSAGE_CONVENIENCE_STORE_TO_PAY = "MESSAGE_CONVENIENCE_STORE_TO_PAY";
        public const string MESSAGE_GUIDE_PAY_1 = "MESSAGE_GUIDE_PAY_1";
        public const string MESSAGE_GUIDE_PAY_2 = "MESSAGE_GUIDE_PAY_2";
        public const string MESSAGE_GUIDE_PAY_3 = "MESSAGE_GUIDE_PAY_3";
        public const string MESSAGE_GUIDE_PAY_4 = "MESSAGE_GUIDE_PAY_4";
        public const string MESSAGE_FAST_MONEY = "MESSAGE_FAST_MONEY";
        public const string MESSAGE_GUIDE_PAY_5 = "MESSAGE_GUIDE_PAY_5";
        public const string MESSAGE_GUIDE_PAY_6 = "MESSAGE_GUIDE_PAY_6";
        public const string MESSAGE_GUIDE_PAY_7 = "MESSAGE_GUIDE_PAY_7";

        public const string MESSAGE_GUIDE_PAY_8 = "MESSAGE_GUIDE_PAY_8";
        public const string MESSAGE_GUIDE_PAY_9 = "MESSAGE_GUIDE_PAY_9";
        public const string MESSAGE_GUIDE_PAY_10 = "MESSAGE_GUIDE_PAY_10";
        public const string MESSAGE_GUIDE_PAY_11 = "MESSAGE_GUIDE_PAY_11";
        public const string MESSAGE_GUIDE_PAY_12 = "MESSAGE_GUIDE_PAY_12";
        public const string MESSAGE_GUIDE_PAY_13 = "MESSAGE_GUIDE_PAY_13";
        public const string MESSAGE_GUIDE_PAY_14 = "MESSAGE_GUIDE_PAY_14";
        public const string MESSAGE_GUIDE_PAY_15 = "MESSAGE_GUIDE_PAY_15";
        public const string MESSAGE_GUIDE_PAY_16 = "MESSAGE_GUIDE_PAY_16";
        public const string MESSAGE_PROJECT = "MESSAGE_PROJECT";
        public const string MESSAGE_UNIT = "MESSAGE_UNIT";
        public const string MESSAGE_FEE = "MESSAGE_FEE";
        public const string MESSAGE_GUIDE_PAY_17 = "MESSAGE_GUIDE_PAY_17";
        public const string MESSAGE_PAY_2 = "MESSAGE_PAY_2";
        public const string MESSAGE_GUIDE_PAY_18 = "MESSAGE_GUIDE_PAY_18";
        public const string MESSAGE_GUIDE_PAY_19 = "MESSAGE_GUIDE_PAY_19";
        public const string MESSAGE_GUIDE_PAY_20 = "MESSAGE_GUIDE_PAY_20";
        public const string MESSAGE_GUIDE_PAY_21 = "MESSAGE_GUIDE_PAY_21";
        public const string MESSAGE_GUIDE_PAY_22 = "MESSAGE_GUIDE_PAY_22";
        public const string MESSAGE_GUIDE_PAY_23 = "MESSAGE_GUIDE_PAY_23";
        public const string MESSAGE_GUIDE_PAY_24 = "MESSAGE_GUIDE_PAY_24";
        public const string MESSAGE_GUIDE_PAY_25 = "MESSAGE_GUIDE_PAY_25";
        public const string MESSAGE_GENERAL_TERMS_AND_CONDITIONS = "MESSAGE_GENERAL_TERMS_AND_CONDITIONS";
        public const string MESSAGE_GUIDE_PAY_26 = "MESSAGE_GUIDE_PAY_26";
        public const string MESSAGE_GUIDE_PAY_27 = "MESSAGE_GUIDE_PAY_27";
        public const string MESSAGE_GUIDE_PAY_28 = "MESSAGE_GUIDE_PAY_28";
        public const string MESSAGE_GUIDE_PAY_29 = "MESSAGE_GUIDE_PAY_29";
        public const string MESSAGE_GUIDE_PAY_30 = "MESSAGE_GUIDE_PAY_30";
        public const string MESSAGE_GUIDE_PAY_31 = "MESSAGE_GUIDE_PAY_31";
        public const string MESSAGE_GUIDE_PAY_32 = "MESSAGE_GUIDE_PAY_32";
        public const string MESSAGE_GUIDE_PAY_33 = "MESSAGE_GUIDE_PAY_33";
        public const string MESSAGE_GUIDE_PAY_34 = "MESSAGE_GUIDE_PAY_34";
        public const string MESSAGE_GUIDE_PAY_35 = "MESSAGE_GUIDE_PAY_35";
        public const string MESSAGE_GUIDE_PAY_36 = "MESSAGE_GUIDE_PAY_36";
        public const string MESSAGE_GUIDE_PAY_37 = "MESSAGE_GUIDE_PAY_37";
        public const string MESSAGE_GUIDE_PAY_38 = "MESSAGE_GUIDE_PAY_38";
        public const string MESSAGE_GUIDE_PAY_39 = "MESSAGE_GUIDE_PAY_39";
        public const string MESSAGE_GUIDE_PAY_40 = "MESSAGE_GUIDE_PAY_40";
        public const string MESSAGE_GUIDE_PAY_41 = "MESSAGE_GUIDE_PAY_41";
        public const string MESSAGE_GUIDE_PAY_42 = "MESSAGE_GUIDE_PAY_42";

        public const string MESSAGE_GUIDE_PAY_43 = "MESSAGE_GUIDE_PAY_43";
        public const string MESSAGE_GUIDE_PAY_44 = "MESSAGE_GUIDE_PAY_44";
        public const string MESSAGE_GUIDE_PAY_45 = "MESSAGE_GUIDE_PAY_45";
        public const string MESSAGE_GUIDE_PAY_46 = "MESSAGE_GUIDE_PAY_46";
        public const string MESSAGE_GUIDE_PAY_47 = "MESSAGE_GUIDE_PAY_47";
        public const string MESSAGE_GUIDE_PAY_48 = "MESSAGE_GUIDE_PAY_48";
        public const string MESSAGE_GUIDE_PAY_49 = "MESSAGE_GUIDE_PAY_49";
        public const string MESSAGE_GUIDE_PAY_50 = "MESSAGE_GUIDE_PAY_50";
        public const string MESSAGE_GUIDE_PAY_51 = "MESSAGE_GUIDE_PAY_51";
        public const string MESSAGE_GUIDE_REGULATION_1 = "MESSAGE_GUIDE_REGULATION_1";
        public const string MESSAGE_MEMBERS_MUST = "MESSAGE_MEMBERS_MUST";

        public const string MESSAGE_GUIDE_REGULATION_2 = "MESSAGE_GUIDE_REGULATION_2";
        public const string MESSAGE_GUIDE_REGULATION_3 = "MESSAGE_GUIDE_REGULATION_3";
        public const string MESSAGE_GUIDE_REGULATION_4 = "MESSAGE_GUIDE_REGULATION_4";
        public const string MESSAGE_GUIDE_REGULATION_5 = "MESSAGE_GUIDE_REGULATION_5";
        public const string MESSAGE_MEMBERS_CAN_NOT = "MESSAGE_MEMBERS_CAN_NOT";
        public const string MESSAGE_GUIDE_REGULATION_10 = "MESSAGE_GUIDE_REGULATION_10";
        public const string MESSAGE_GUIDE_REGULATION_6 = "MESSAGE_GUIDE_REGULATION_6";
        public const string MESSAGE_GUIDE_REGULATION_7 = "MESSAGE_GUIDE_REGULATION_7";
        public const string MESSAGE_GUIDE_REGULATION_8 = "MESSAGE_GUIDE_REGULATION_8";
        public const string MESSAGE_GUIDE_REGULATION_9 = "MESSAGE_GUIDE_REGULATION_9";
        public const string MESSAGE_SIGN_A_SERVICE_AGREEMENT = "MESSAGE_SIGN_A_SERVICE_AGREEMENT";
        public const string MESSAGE_GUIDE_REGULATION_11 = "MESSAGE_GUIDE_REGULATION_11";
        public const string MESSAGE_DELIVERY_RULES = "MESSAGE_DELIVERY_RULES";
        public const string MESSAGE_INTELLECTUAL_PROPERTY_RULES = "MESSAGE_INTELLECTUAL_PROPERTY_RULES";
        public const string MESSAGE_COSTS_TO_BE_PAID = "MESSAGE_COSTS_TO_BE_PAID";
        public const string MESSAGE_RETURNS_AND_REFUNDS_2 = "MESSAGE_RETURNS_AND_REFUNDS_2";
        public const string MESSAGE_TAX_POLICY = "MESSAGE_TAX_POLICY";
        public const string MESSAGE_CUSTOMER_COMMENTS = "MESSAGE_CUSTOMER_COMMENTS";

        public const string MESSAGE_GUIDE_REGULATION_12 = "MESSAGE_GUIDE_REGULATION_12";
        public const string MESSAGE_GUIDE_REGULATION_13 = "MESSAGE_GUIDE_REGULATION_13";
        public const string MESSAGE_GUIDE_REGULATION_14 = "MESSAGE_GUIDE_REGULATION_14";
        public const string MESSAGE_GUIDE_REGULATION_15 = "MESSAGE_GUIDE_REGULATION_15";
        public const string MESSAGE_GUIDE_REGULATION_16 = "MESSAGE_GUIDE_REGULATION_16";
        public const string MESSAGE_GUIDE_REGULATION_17 = "MESSAGE_GUIDE_REGULATION_17";
        public const string MESSAGE_GUIDE_REGULATION_18 = "MESSAGE_GUIDE_REGULATION_18";
        public const string MESSAGE_GUIDE_REGULATION_19 = "MESSAGE_GUIDE_REGULATION_19";

        public const string MESSAGE_GUIDE_REGULATION_20 = "MESSAGE_GUIDE_REGULATION_20";
        public const string MESSAGE_GUIDE_REGULATION_21 = "MESSAGE_GUIDE_REGULATION_21";
        public const string MESSAGE_GUIDE_REGULATION_22 = "MESSAGE_GUIDE_REGULATION_22";
        public const string MESSAGE_GUIDE_REGULATION_23 = "MESSAGE_GUIDE_REGULATION_23";
        public const string MESSAGE_GUIDE_REGULATION_24 = "MESSAGE_GUIDE_REGULATION_24";
        public const string MESSAGE_GUIDE_REGULATION_25 = "MESSAGE_GUIDE_REGULATION_25";
        public const string MESSAGE_PAYMENT_RULES = "MESSAGE_PAYMENT_RULES";
        public const string MESSAGE_SHOPPING_RULES = "MESSAGE_SHOPPING_RULES";
        public const string MESSAGE_PROBLEM_ITEMS = "MESSAGE_PROBLEM_ITEMS";
        public const string MESSAGE_GUIDE_REGULATION_26 = "MESSAGE_GUIDE_REGULATION_26";
        public const string MESSAGE_UNACKNOWLEDGE_TIME_ORDERS = "MESSAGE_UNACKNOWLEDGE_TIME_ORDERS";
        public const string MESSAGE_RETURN_THE_APPLICATION_PROCESS = "MESSAGE_RETURN_THE_APPLICATION_PROCESS";
        public const string MESSAGE_RETURNS_TERMS_AND_CONDITIONS = "MESSAGE_RETURNS_TERMS_AND_CONDITIONS";
        public const string MESSAGE_REFUND_TERMS_AND_CONDITIONS = "MESSAGE_REFUND_TERMS_AND_CONDITIONS";
        public const string MESSAGE_GUIDE_RETURN = "MESSAGE_GUIDE_RETURN";
        public const string MESSAGE_GUIDE_RETURN_2 = "MESSAGE_GUIDE_RETURN_2";
        public const string MESSAGE_GUIDE_RETURN_3 = "MESSAGE_GUIDE_RETURN_3";
        public const string MESSAGE_GUIDE_RETURN_4 = "MESSAGE_GUIDE_RETURN_4";
        public const string MESSAGE_GUIDE_RETURN_5 = "MESSAGE_GUIDE_RETURN_5";
        public const string MESSAGE_GUIDE_RETURN_6 = "MESSAGE_GUIDE_RETURN_6";
        public const string MESSAGE_GUIDE_RETURN_7 = "MESSAGE_GUIDE_RETURN_7";
        public const string MESSAGE_RETURN_THE_APPLICATION_2 = "MESSAGE_RETURN_THE_APPLICATION_2";
        public const string MESSAGE_NOT_BE_PROCESSED_RETURNS = "MESSAGE_NOT_BE_PROCESSED_RETURNS";
        public const string MESSAGE_APPLICATION_PERIOD_RETURNED = "MESSAGE_APPLICATION_PERIOD_RETURNED";
        public const string MESSAGE_PRELIMINARY_APPROVAL = "MESSAGE_PRELIMINARY_APPROVAL";
        public const string MESSAGE_DEFECTS_IDENTIFIED = "MESSAGE_DEFECTS_IDENTIFIED";
        public const string MESSAGE_REPLACEMENT_OR_REFUND = "MESSAGE_REPLACEMENT_OR_REFUND";

        public const string MESSAGE_GUIDE_RETURN_10 = "MESSAGE_GUIDE_RETURN_10";
        public const string MESSAGE_GUIDE_RETURN_11 = "MESSAGE_GUIDE_RETURN_11";
        public const string MESSAGE_GUIDE_RETURN_12 = "MESSAGE_GUIDE_RETURN_12";
        public const string MESSAGE_GUIDE_RETURN_13 = "MESSAGE_GUIDE_RETURN_13";
        public const string MESSAGE_GUIDE_RETURN_14 = "MESSAGE_GUIDE_RETURN_14";
        public const string MESSAGE_GUIDE_RETURN_15 = "MESSAGE_GUIDE_RETURN_15";
        public const string MESSAGE_GUIDE_RETURN_16 = "MESSAGE_GUIDE_RETURN_16";
        public const string MESSAGE_GUIDE_RETURN_8 = "MESSAGE_GUIDE_RETURN_8";
        public const string MESSAGE_GUIDE_RETURN_9 = "MESSAGE_GUIDE_RETURN_9";
        public const string MESSAGE_INDIVIDUAL_RETURN_POLICY = "MESSAGE_INDIVIDUAL_RETURN_POLICY";
        public const string MESSAGE_INITIAL_APPLICATION = "MESSAGE_INITIAL_APPLICATION";
        public const string MESSAGE_RETURN_THE_GOODS = "MESSAGE_RETURN_THE_GOODS";
        public const string MESSAGE_FORMALLY_ACCEPTED = "MESSAGE_FORMALLY_ACCEPTED";
        public const string MESSAGE_OR_VISIT = "MESSAGE_OR_VISIT";
        public const string MESSAGE_APPLICATIONS_WERE_ACCEPTED = "MESSAGE_APPLICATIONS_WERE_ACCEPTED";

        public const string MESSAGE_GUIDE_RETURN_17 = "MESSAGE_GUIDE_RETURN_17";
        public const string MESSAGE_GUIDE_RETURN_18 = "MESSAGE_GUIDE_RETURN_18";
        public const string MESSAGE_GUIDE_RETURN_19 = "MESSAGE_GUIDE_RETURN_19";
        public const string MESSAGE_GUIDE_RETURN_20 = "MESSAGE_GUIDE_RETURN_20";
        public const string MESSAGE_GUIDE_RETURN_21 = "MESSAGE_GUIDE_RETURN_21";
        public const string MESSAGE_WITHOUT_ACCEPTING = "MESSAGE_WITHOUT_ACCEPTING";
        public const string MESSAGE_ON_THE_7_DAY = "MESSAGE_ON_THE_7_DAY";
        public const string MESSAGE_FIRST_SERVICE_CONTACT = "MESSAGE_FIRST_SERVICE_CONTACT";
        public const string MESSAGE_ENTIRELY_NEW_STATE = "MESSAGE_ENTIRELY_NEW_STATE";
        public const string MESSAGE_CAUSED_SERIOUS_DAMAGE = "MESSAGE_CAUSED_SERIOUS_DAMAGE";
        public const string MESSAGE_LOST_OR_DAMAGED = "MESSAGE_LOST_OR_DAMAGED";
        public const string MESSAGE_DESIGN_OR_COLOR = "MESSAGE_DESIGN_OR_COLOR";
        public const string MESSAGE_PRODUCT_SIZE_ERROR = "MESSAGE_PRODUCT_SIZE_ERROR";
        public const string MESSAGE_GIFTS_IN_ANY = "MESSAGE_GIFTS_IN_ANY";
        public const string MESSAGE_LISTED_NO_RETURN = "MESSAGE_LISTED_NO_RETURN";
        public const string MESSAGE_RETURN_ARRANGEMENT = "MESSAGE_RETURN_ARRANGEMENT";
        public const string MESSAGE_DISPLAY_OR_SHOOTING_REASON = "MESSAGE_DISPLAY_OR_SHOOTING_REASON";
        public const string MESSAGE_OTHER_REASONABLE_RETURNS = "MESSAGE_OTHER_REASONABLE_RETURNS";
        public const string MESSAGE_RETURN_DIFFERENT_CATEGORIES = "MESSAGE_RETURN_DIFFERENT_CATEGORIES";
        public const string MESSAGE_FURTHER_IDENTIFICATION_OF_GOODS = "MESSAGE_FURTHER_IDENTIFICATION_OF_GOODS";
        public const string MESSAGE_PACKAGING_HAS_BEEN_OPENED = "MESSAGE_PACKAGING_HAS_BEEN_OPENED";
        public const string MESSAGE_WATCHES_JEWELRY = "MESSAGE_WATCHES_JEWELRY";
        public const string MESSAGE_INTERNAL_AND_EXTERNAL_PACKAGING = "MESSAGE_INTERNAL_AND_EXTERNAL_PACKAGING";
        public const string MESSAGE_BEAUTY_AND_HEALTH = "MESSAGE_BEAUTY_AND_HEALTH";
        public const string MESSAGE_ELECTRICAL_GOODS = "MESSAGE_ELECTRICAL_GOODS";
        public const string MESSAGE_REPLACEMENT_OF_GOODS = "MESSAGE_REPLACEMENT_OF_GOODS";
        public const string MESSAGE_RETURN_THE_GOODS_SERVICE = "MESSAGE_RETURN_THE_GOODS_SERVICE";
        public const string MESSAGE_LISTED_IN_THE_RETURNABLE = "MESSAGE_LISTED_IN_THE_RETURNABLE";
        public const string MESSAGE_GUIDE_RETURN_22 = "MESSAGE_GUIDE_RETURN_22";
        public const string MESSAGE_GUIDE_RETURN_23 = "MESSAGE_GUIDE_RETURN_23";
        public const string MESSAGE_GUIDE_RETURN_24 = "MESSAGE_GUIDE_RETURN_24";
        public const string MESSAGE_GUIDE_RETURN_25 = "MESSAGE_GUIDE_RETURN_25";
        public const string MESSAGE_GUIDE_RETURN_26 = "MESSAGE_GUIDE_RETURN_26";
        public const string MESSAGE_GUIDE_RETURN_27 = "MESSAGE_GUIDE_RETURN_27";
        public const string MESSAGE_GUIDE_RETURN_28 = "MESSAGE_GUIDE_RETURN_28";
        public const string MESSAGE_GUIDE_RETURN_29 = "MESSAGE_GUIDE_RETURN_29";
        public const string MESSAGE_GUIDE_RETURN_30 = "MESSAGE_GUIDE_RETURN_30";
        public const string MESSAGE_GUIDE_RETURN_31 = "MESSAGE_GUIDE_RETURN_31";
        public const string MESSAGE_COMMODITY_REFUND_IS_LIMITED = "MESSAGE_COMMODITY_REFUND_IS_LIMITED";
        public const string MESSAGE_12_AFTER_THE_CONFIRMATION = "MESSAGE_12_AFTER_THE_CONFIRMATION";
        public const string MESSAGE_PAID_FOR_FAILURE_TO_DELIVERY = "MESSAGE_PAID_FOR_FAILURE_TO_DELIVERY";
        public const string MESSAGE_COMMODITY_REFUND_IS_LIMITED_3 = "MESSAGE_COMMODITY_REFUND_IS_LIMITED_3";
        public const string MESSAGE_PRECAUTIONS_RETURN_1 = "MESSAGE_PRECAUTIONS_RETURN_1";
        public const string MESSAGE_PRECAUTIONS_RETURN_2 = "MESSAGE_PRECAUTIONS_RETURN_2";
        public const string MESSAGE_PRECAUTIONS_RETURN_3 = "MESSAGE_PRECAUTIONS_RETURN_3";
        public const string MESSAGE_PRECAUTIONS_RETURN_4 = "MESSAGE_PRECAUTIONS_RETURN_4";
        public const string MESSAGE_PRECAUTIONS_RETURN_5 = "MESSAGE_PRECAUTIONS_RETURN_5";
        public const string MESSAGE_PRECAUTIONS_RETURN_6 = "MESSAGE_PRECAUTIONS_RETURN_6";
        public const string MESSAGE_CONVENIENCE_STORES_EXTRACTION = "MESSAGE_CONVENIENCE_STORES_EXTRACTION";
        public const string MESSAGE_CONVENIENCE_STORES_EXTRACTION_2 = "MESSAGE_CONVENIENCE_STORES_EXTRACTION_2";
        public const string MESSAGE_ON_LINE_PAYMENT_OR_PAYMENT = "MESSAGE_ON_LINE_PAYMENT_OR_PAYMENT";
        public const string MESSAGE_SENT_SAMEADDRESS = "MESSAGE_SENT_SAMEADDRESS";
        public const string MESSAGE_ONLY_ONLINE_PAYMENT = "MESSAGE_ONLY_ONLINE_PAYMENT";
        public const string MESSAGE_NOT_TO_STORE_EXTRACTION = "MESSAGE_NOT_TO_STORE_EXTRACTION";
        public const string MESSAGE_MODIFY_SHOPPING_CART = "MESSAGE_MODIFY_SHOPPING_CART";
        public const string MESSAGE_NEXT_STEP = "MESSAGE_NEXT_STEP";
        public const string MESSAGE_DELIVERY_WHERE = "MESSAGE_DELIVERY_WHERE";
        public const string MESSAGE_FILL_CONTACT_ADDRESS = "MESSAGE_FILL_CONTACT_ADDRESS";
        public const string MESSAGE_MOBILE_PHONE = "MESSAGE_MOBILE_PHONE";
        public const string MESSAGE_CREDIT_CARD = "MESSAGE_CREDIT_CARD";
        public const string MESSAGE_RECIPIENT_NAME = "MESSAGE_RECIPIENT_NAME";
        public const string MESSAGE_CORRECT_RECIPIENT_PHONE = "MESSAGE_CORRECT_RECIPIENT_PHONE";
        public const string MESSAGE_CORRECT_RECIPIENT_EMAIL = "MESSAGE_CORRECT_RECIPIENT_EMAIL";
        public const string MESSAGE_SHIPPINGADDRESS_1 = "MESSAGE_SHIPPINGADDRESS_1";
        public const string MESSAGE_NEW_ADDRESS = "MESSAGE_NEW_ADDRESS";
        public const string MESSAGE_A_GIFT = "MESSAGE_A_GIFT";
        public const string MESSAGE_GIFT_OPTION_IS_ONLY = "MESSAGE_GIFT_OPTION_IS_ONLY";
        public const string MESSAGE_YES = "MESSAGE_YES";
        public const string MESSAGE_NO = "MESSAGE_NO";
        public const string MESSAGE_RECIPIENT_PHONE = "MESSAGE_RECIPIENT_PHONE";
        public const string MESSAGE_RECIPIENT_EMAIL = "MESSAGE_RECIPIENT_EMAIL";
        public const string MESSAGE_CARD_EMAIL_RECIPIENT = "MESSAGE_CARD_EMAIL_RECIPIENT";
        public const string MESSAGE_PRECEDING_THE_RECIPIENT = "MESSAGE_PRECEDING_THE_RECIPIENT";
        public const string MESSAGE_CONTENT = "MESSAGE_CONTENT";
        public const string MESSAGE_GIVER_ENTERTAIN = "MESSAGE_GIVER_ENTERTAIN";
        public const string MESSAGE_CHRISTMAS_GIFT_BAG = "MESSAGE_CHRISTMAS_GIFT_BAG";
        public const string MESSAGE_GIVE_ME_A_GIFT_BAG = "MESSAGE_GIVE_ME_A_GIFT_BAG";
        public const string MESSAGE_CERTIFIED = "MESSAGE_CERTIFIED";
        public const string MESSAGE_SELECT_CARK = "MESSAGE_SELECT_CARK";
        public const string MESSAGE_SELECT_CARK_2 = "MESSAGE_SELECT_CARK_2";
        public const string MESSAGE_SELECT_POINT = "MESSAGE_SELECT_POINT";
        public const string MESSAGE_INPUT_ERROR = "MESSAGE_INPUT_ERROR";
        public const string MESSAGE_COUPON_DUPLICATE = "MESSAGE_COUPON_DUPLICATE";
        public const string MESSAGE_COUPON_ERROR = "MESSAGE_COUPON_ERROR";
        public const string MESSAGE_NOT_YET_VERIFIY = "MESSAGE_NOT_YET_VERIFIY";
        public const string MESSAGE_VERIFIY = "MESSAGE_VERIFIY";
        public const string MESSAGE_SHOWINFO = "MESSAGE_SHOWINFO";
        public const string MESSAGE_MACAO = "MESSAGE_MACAO";
        public const string MESSAGE_MACAO_DISABLED = "MESSAGE_MACAO_DISABLED";
        public const string MESSAGE_NO_ADDRESS = "MESSAGE_NO_ADDRESS";
        public const string MESSAGE_CHANGE_ADDRESS = "MESSAGE_CHANGE_ADDRESS";
        public const string MESSAGE_11_NUMBER = "MESSAGE_11_NUMBER";
        public const string MESSAGE_8_NUMBER = "MESSAGE_8_NUMBER";
        public const string MESSAGE_9_NUMBER = "MESSAGE_9_NUMBER";
        public const string MESSAGE_MEMBER_ERROR = "MESSAGE_MEMBER_ERROR";
        public const string MESSAGE_HAD_VERIFIY = "MESSAGE_HAD_VERIFIY";
        public const string MESSAGE_INPUT_PHONE = "MESSAGE_INPUT_PHONE";
        public const string MESSAGE_INPUT_PHONE_ERROR = "MESSAGE_INPUT_PHONE_ERROR";
        public const string MESSAGE_SHOP_TAKE_DATE = "MESSAGE_SHOP_TAKE_DATE";
        public const string MESSAGE_BRANCH = "MESSAGE_BRANCH";
        public const string MESSAGE_OK_CONVENIENCE_STORE_1 = "MESSAGE_OK_CONVENIENCE_STORE_1";
        public const string MESSAGE_OK_CONVENIENCE_STORE_NAME = "MESSAGE_OK_CONVENIENCE_STORE_NAME";
        public const string MESSAGE_OK_CONVENIENCE_STORE_POSITION = "MESSAGE_OK_CONVENIENCE_STORE_POSITION";
        public const string MESSAGE_HOURS = "MESSAGE_HOURS";
        public const string MESSAGE_USE_LIMIT = "MESSAGE_USE_LIMIT";
        public const string MESSAGE_SHEUNG_WAN = "MESSAGE_SHEUNG_WAN";
        public const string MESSAGE_NO_STORES = "MESSAGE_NO_STORES";
        public const string MESSAGE_NO_STORES_1 = "MESSAGE_NO_STORES_1";
        public const string MESSAGE_STORE_PAYMENTS = "MESSAGE_STORE_PAYMENTS";
        public const string MESSAGE_ONLINE_PAYMENT = "MESSAGE_ONLINE_PAYMENT";
        public const string MESSAGE_ONLINE_PAYMENT_LIMIT = "MESSAGE_ONLINE_PAYMENT_LIMIT";
        public const string MESSAGE_GIFTS_DELIVERY_SHIPPING = "MESSAGE_GIFTS_DELIVERY_SHIPPING";
        public const string MESSAGE_GIFTS_DELIVERY_ONLINE = "MESSAGE_GIFTS_DELIVERY_ONLINE";
        public const string MESSAGE_SELECT_FINGERDOLLARS = "MESSAGE_SELECT_FINGERDOLLARS";
        public const string MESSAGE_SELECT_THE_AREA = "MESSAGE_SELECT_THE_AREA";
        public const string MESSAGE_USE = "MESSAGE_USE";
        public const string MESSAGE_FULL = "MESSAGE_FULL";
        public const string MESSAGE_SELECT_THE_DATE = "MESSAGE_SELECT_THE_DATE";
        public const string MESSAGE_DELIVERY_ERROR = "MESSAGE_DELIVERY_ERROR";
        public const string MESSAGE_DELIVERY_ERROR_2 = "MESSAGE_DELIVERY_ERROR_2";
        public const string MESSAGE_DELIVERY_1WEEK = "MESSAGE_DELIVERY_1WEEK";
        public const string MESSAGE_PLEASE_SELECT_STORES = "MESSAGE_PLEASE_SELECT_STORES";
        public const string MESSAGE_DELIVERY_NUMBER_3 = "MESSAGE_DELIVERY_NUMBER_3";
        public const string MESSAGE_DAY_GIFT_NEW_HOME = "MESSAGE_DAY_GIFT_NEW_HOME";
        public const string MESSAGE_DELIVERY_ADDRESS = "MESSAGE_DELIVERY_ADDRESS";
        public const string MESSAGE_USE_POINT = "MESSAGE_USE_POINT";
        public const string MESSAGE_USE_POINT_2 = "MESSAGE_USE_POINT_2";
        public const string MESSAGE_ELECTRONIC_TICKET_NUMBER = "MESSAGE_ELECTRONIC_TICKET_NUMBER";
        public const string MESSAGE_HIDE = "MESSAGE_HIDE";
        public const string MESSAGE_CATEGORIES = "MESSAGE_CATEGORIES";
        public const string MESSAGE_PRODUCT_TAGS = "MESSAGE_PRODUCT_TAGS";
        public const string MESSAGE_DESIGNER_1 = "MESSAGE_DESIGNER_1";
        public const string MESSAGE_DESIGNER_2 = "MESSAGE_DESIGNER_2";
        public const string MESSAGE_THE_MAJOR_DESIGN = "MESSAGE_THE_MAJOR_DESIGN";
        public const string MESSAGE_DESIGNER_SEARCH = "MESSAGE_DESIGNER_SEARCH";
        public const string MESSAGE_CHINESE_NAME_CORRECT_FORMAT = "MESSAGE_CHINESE_NAME_CORRECT_FORMAT";
        public const string MESSAGE_EN_NAME_CORRECT_FORMAT = "MESSAGE_EN_NAME_CORRECT_FORMAT";
        public const string MESSAGE_ACCOUNT_NAME_CORRECT_FORMAT = "MESSAGE_ACCOUNT_NAME_CORRECT_FORMAT";
        public const string MESSAGE_DATE_CORRECT_FORMAT = "MESSAGE_DATE_CORRECT_FORMAT";
        public const string MESSAGE_NEWEMAIL_ERROR = "MESSAGE_NEWEMAIL_ERROR";
        public const string MESSAGE_NEWPASSWORD_ERROR = "MESSAGE_NEWPASSWORD_ERROR";
        public const string MESSAGE_NEWMOBILE_ERROR = "MESSAGE_NEWMOBILE_ERROR";
        public const string MESSAGE_NEWMOBILEOTHER_ERROR = "MESSAGE_NEWMOBILEOTHER_ERROR";
        public const string MESSAGE_MEMID = "MESSAGE_MEMID";
        public const string MESSAGE_EITHER = "MESSAGE_EITHER";
        public const string MESSAGE_ENGLISHNAME = "MESSAGE_ENGLISHNAME";
        public const string MESSAGE_GIRL = "MESSAGE_GIRL";
        public const string MESSAGE_BOY = "MESSAGE_BOY";
        public const string MESSAGE_BIRTHDATE = "MESSAGE_BIRTHDATE";
        public const string MESSAGE_EDUCATION = "MESSAGE_EDUCATION";
        public const string MESSAGE_PRIMARY_EDUCATION = "MESSAGE_PRIMARY_EDUCATION";
        public const string MESSAGE_CITY_2 = "MESSAGE_CITY_2";
        public const string MESSAGE_DISTICT = "MESSAGE_DISTICT";
        public const string MESSAGE_FAMILY_PAY = "MESSAGE_FAMILY_PAY";
        public const string MESSAGE_OTHERPHONE = "MESSAGE_OTHERPHONE";
        public const string MESSAGE_CURRENTPASSWORD = "MESSAGE_CURRENTPASSWORD";
        public const string MESSAGE_NEW_PASSWORD = "MESSAGE_NEW_PASSWORD";
        public const string MESSAGE_CONFIRM_PASSWORD_2 = "MESSAGE_CONFIRM_PASSWORD_2";
        public const string MESSAGE_CURRENT_EMAIL = "MESSAGE_CURRENT_EMAIL";
        public const string MESSAGE_NEW_EMAIL = "MESSAGE_NEW_EMAIL";
        public const string MESSAGE_CONFIRM_EMAIL = "MESSAGE_CONFIRM_EMAIL";
        public const string MESSAGE_MY_PREFERENCES = "MESSAGE_MY_PREFERENCES";
        public const string MESSAGE_FOOD = "MESSAGE_FOOD";
        public const string MESSAGE_HOME_2 = "MESSAGE_HOME_2";
        public const string MESSAGE_THE_WORK = "MESSAGE_THE_WORK";
        public const string MESSAGE_PET_2 = "MESSAGE_PET_2";
        public const string MESSAGE_TIDE_STUFF = "MESSAGE_TIDE_STUFF";
        public const string MESSAGE_PHONE_2 = "MESSAGE_PHONE_2";
        public const string MESSAGE_DIGITAL = "MESSAGE_DIGITAL";
        public const string MESSAGE_COMPACT_APPLIANCE = "MESSAGE_COMPACT_APPLIANCE";
        public const string MESSAGE_STATIONERY_2 = "MESSAGE_STATIONERY_2";
        public const string MESSAGE_BOUTIQUE_GIFT = "MESSAGE_BOUTIQUE_GIFT";
        public const string MESSAGE_COSMETOLOGY = "MESSAGE_COSMETOLOGY";
        public const string MESSAGE_HEALTH = "MESSAGE_HEALTH";
        public const string MESSAGE_ENVIRONMENTAL_PROTECTION = "MESSAGE_ENVIRONMENTAL_PROTECTION";
        public const string MESSAGE_SENT_FINGERSHOPPING = "MESSAGE_SENT_FINGERSHOPPING";
        public const string MESSAGE_SECONDARY_LEVEL = "MESSAGE_SECONDARY_LEVEL";
        public const string MESSAGE_COLLEGE_DEGREE = "MESSAGE_COLLEGE_DEGREE";
        public const string MESSAGE_UNIVERSITY_DEGREE = "MESSAGE_UNIVERSITY_DEGREE";
        public const string MESSAGE_MASTER_DEGREE_OR_HIGHER = "MESSAGE_MASTER_DEGREE_OR_HIGHER";
        public const string MESSAGE_HONGKONG_2 = "MESSAGE_HONGKONG_2";
        public const string MESSAGE_MACAO_2 = "MESSAGE_MACAO_2";
        public const string MESSAGE_SINGAPORE = "MESSAGE_SINGAPORE";
        public const string MESSAGE_MALAYSIA = "MESSAGE_MALAYSIA";
        public const string MESSAGE_AUSTRALIA = "MESSAGE_AUSTRALIA";
        public const string MESSAGE_NEW_ZEALAND = "MESSAGE_NEW_ZEALAND";
        public const string MESSAGE_UNITED_KINGDOM = "MESSAGE_UNITED_KINGDOM";
        public const string MESSAGE_USA = "MESSAGE_USA";
        public const string MESSAGE_WESTERN = "MESSAGE_WESTERN";
        public const string MESSAGE_WAN_CHAI = "MESSAGE_WAN_CHAI";
        public const string MESSAGE_EASTERN = "MESSAGE_EASTERN";
        public const string MESSAGE_SOUTHERN_DISTRICT = "MESSAGE_SOUTHERN_DISTRICT";
        public const string MESSAGE_YAU_TSIM_MONG_DISTRICT = "MESSAGE_YAU_TSIM_MONG_DISTRICT";
        public const string MESSAGE_SHAM_SHUI_PO_DISTRICT = "MESSAGE_SHAM_SHUI_PO_DISTRICT";
        public const string MESSAGE_KOWLOON_CITY_DISTRICT = "MESSAGE_KOWLOON_CITY_DISTRICT";
        public const string MESSAGE_WONG_TAI_SIN_DISTRICT = "MESSAGE_WONG_TAI_SIN_DISTRICT";
        public const string MESSAGE_KWUN_TONG = "MESSAGE_KWUN_TONG";
        public const string MESSAGE_KWAI_TSING_DISTRICT = "MESSAGE_KWAI_TSING_DISTRICT";
        public const string MESSAGE_TSUEN_WAN = "MESSAGE_TSUEN_WAN";
        public const string MESSAGE_TUEN_MUN = "MESSAGE_TUEN_MUN";
        public const string MESSAGE_YUEN_LONG = "MESSAGE_YUEN_LONG";
        public const string MESSAGE_NORTH = "MESSAGE_NORTH";
        public const string MESSAGE_TAI_PO_DISTRICT = "MESSAGE_TAI_PO_DISTRICT";
        public const string MESSAGE_SHA_TIN_DISTRICT = "MESSAGE_SHA_TIN_DISTRICT";
        public const string MESSAGE_SAI_KUNG_DISTRICT = "MESSAGE_SAI_KUNG_DISTRICT";
        public const string MESSAGE_ISLANDS_DISTRICT = "MESSAGE_ISLANDS_DISTRICT";
        public const string MESSAGE_LESS = "MESSAGE_LESS";
        public const string MESSAGE_BETWEEN = "MESSAGE_BETWEEN";
        public const string MESSAGE_MORE_2 = "MESSAGE_MORE_2";
        public const string MESSAGE_PASSWORD_ERROR = "MESSAGE_PASSWORD_ERROR";
        public const string MESSAGE_PASSWORD_Empty = "MESSAGE_PASSWORD_Empty";
        public const string MESSAGE_UPDATE_SUCCESS_ALERT_SESSION_NAME = "MESSAGE_UPDATE_SUCCESS_ALERT_SESSION_NAME";
        public const string MESSAGE_HOME_3 = "MESSAGE_HOME_3";
        public const string MESSAGE_MAGAZINE_EDITORIAL = "MESSAGE_MAGAZINE_EDITORIAL";
        public const string MESSAGE_MAGAZINE_EDITORIAL_1 = "MESSAGE_MAGAZINE_EDITORIAL_1";

        public const string MESSAGE_FAQ_ANSWER_1 = "MESSAGE_FAQ_ANSWER_1";
        public const string MESSAGE_FAQ_ANSWER_2 = "MESSAGE_FAQ_ANSWER_2";
        public const string MESSAGE_FAQ_ANSWER_3 = "MESSAGE_FAQ_ANSWER_3";
        public const string MESSAGE_FAQ_ANSWER_4 = "MESSAGE_FAQ_ANSWER_4";
        public const string MESSAGE_FAQ_ANSWER_5 = "MESSAGE_FAQ_ANSWER_5";
        public const string MESSAGE_FAQ_ANSWER_6 = "MESSAGE_FAQ_ANSWER_6";
        public const string MESSAGE_FAQ_ANSWER_7 = "MESSAGE_FAQ_ANSWER_7";
        public const string MESSAGE_FAQ_ANSWER_8 = "MESSAGE_FAQ_ANSWER_8";
        public const string MESSAGE_FAQ_ANSWER_9 = "MESSAGE_FAQ_ANSWER_9";

        public const string MESSAGE_FAQ_ANSWER_10 = "MESSAGE_FAQ_ANSWER_10";
        public const string MESSAGE_FAQ_ANSWER_11 = "MESSAGE_FAQ_ANSWER_11";
        public const string MESSAGE_FAQ_ANSWER_12 = "MESSAGE_FAQ_ANSWER_12";
        public const string MESSAGE_FAQ_ANSWER_13 = "MESSAGE_FAQ_ANSWER_13";
        public const string MESSAGE_FAQ_ANSWER_14 = "MESSAGE_FAQ_ANSWER_14";
        public const string MESSAGE_FAQ_ANSWER_15 = "MESSAGE_FAQ_ANSWER_15";
        public const string MESSAGE_FAQ_ANSWER_16 = "MESSAGE_FAQ_ANSWER_16";
        public const string MESSAGE_FAQ_ANSWER_17 = "MESSAGE_FAQ_ANSWER_17";
        public const string MESSAGE_FAQ_ANSWER_18 = "MESSAGE_FAQ_ANSWER_18";
        public const string MESSAGE_FAQ_ANSWER_19 = "MESSAGE_FAQ_ANSWER_19";
        public const string MESSAGE_FAQ_ANSWER_20 = "MESSAGE_FAQ_ANSWER_20";

        public const string MESSAGE_FAQ_CONTENT_1 = "MESSAGE_FAQ_CONTENT_1";
        public const string MESSAGE_FAQ_CONTENT_2 = "MESSAGE_FAQ_CONTENT_2";
        public const string MESSAGE_FAQ_CONTENT_3 = "MESSAGE_FAQ_CONTENT_3";
        public const string MESSAGE_FAQ_CONTENT_3_1 = "MESSAGE_FAQ_CONTENT_3_1";
        public const string MESSAGE_FAQ_CONTENT_3_2 = "MESSAGE_FAQ_CONTENT_3_2";
        public const string MESSAGE_FAQ_CONTENT_4 = "MESSAGE_FAQ_CONTENT_4";
        public const string MESSAGE_FAQ_CONTENT_4_1 = "MESSAGE_FAQ_CONTENT_4_1";
        public const string MESSAGE_FAQ_CONTENT_4_2 = "MESSAGE_FAQ_CONTENT_4_2";
        public const string MESSAGE_FAQ_CONTENT_4_3 = "MESSAGE_FAQ_CONTENT_4_3";
        public const string MESSAGE_FAQ_CONTENT_4_4 = "MESSAGE_FAQ_CONTENT_4_4";
        public const string MESSAGE_FAQ_CONTENT_5 = "MESSAGE_FAQ_CONTENT_5";
        public const string MESSAGE_FAQ_CONTENT_6 = "MESSAGE_FAQ_CONTENT_6";
        public const string MESSAGE_FAQ_CONTENT_7 = "MESSAGE_FAQ_CONTENT_7";
        public const string MESSAGE_FAQ_CONTENT_8 = "MESSAGE_FAQ_CONTENT_8";
        public const string MESSAGE_FAQ_CONTENT_9 = "MESSAGE_FAQ_CONTENT_9";
        public const string MESSAGE_FAQ_CONTENT_10 = "MESSAGE_FAQ_CONTENT_10";
        public const string MESSAGE_FAQ_CONTENT_11 = "MESSAGE_FAQ_CONTENT_11";
        public const string MESSAGE_FAQ_CONTENT_12_1 = "MESSAGE_FAQ_CONTENT_12_1";
        public const string MESSAGE_FAQ_CONTENT_12_2 = "MESSAGE_FAQ_CONTENT_12_2";
        public const string MESSAGE_FAQ_CONTENT_13_1 = "MESSAGE_FAQ_CONTENT_13_1";
        public const string MESSAGE_FAQ_CONTENT_13_2 = "MESSAGE_FAQ_CONTENT_13_2";
        public const string MESSAGE_FAQ_CONTENT_14 = "MESSAGE_FAQ_CONTENT_14";
        public const string MESSAGE_RETURN_AND_REFUND = "MESSAGE_RETURN_AND_REFUND";
        public const string MESSAGE_FAQ_CONTENT_15_1 = "MESSAGE_FAQ_CONTENT_15_1";
        public const string MESSAGE_FAQ_CONTENT_15_2 = "MESSAGE_FAQ_CONTENT_15_2";
        public const string MESSAGE_FAQ_CONTENT_16 = "MESSAGE_FAQ_CONTENT_16";
        public const string MESSAGE_VIP_STARS_AND_CONDITIONS = "MESSAGE_VIP_STARS_AND_CONDITIONS";
        public const string MESSAGE_FAQ_CONTENT_17 = "MESSAGE_FAQ_CONTENT_17";
        public const string MESSAGE_FAQ_CONTENT_18 = "MESSAGE_FAQ_CONTENT_18";
        public const string MESSAGE_FAQ_CONTENT_19_1 = "MESSAGE_FAQ_CONTENT_19_1";
        public const string MESSAGE_FAQ_CONTENT_19_2 = "MESSAGE_FAQ_CONTENT_19_2";
        public const string MESSAGE_FAQ_CONTENT_20 = "MESSAGE_FAQ_CONTENT_20";
        public const string MESSAGE_MY_FEEDBACK = "MESSAGE_MY_FEEDBACK";
        public const string MESSAGE_RED_COLOR = "MESSAGE_RED_COLOR";
        public const string MESSAGE_BIG = "MESSAGE_BIG";
        public const string MESSAGE_TC = "MESSAGE_TC";
        public const string MESSAGE_EN = "MESSAGE_EN";
        public const string MESSAGE_COPYRIGHTDATE_2 = "MESSAGE_COPYRIGHTDATE_2";

        public const string MESSAGE_FINGERDOLLARS_TERMS_1 = "MESSAGE_FINGERDOLLARS_TERMS_1";
        public const string MESSAGE_FINGERDOLLARS_TERMS_2 = "MESSAGE_FINGERDOLLARS_TERMS_2";
        public const string MESSAGE_FINGERDOLLARS_TERMS_3 = "MESSAGE_FINGERDOLLARS_TERMS_3";
        public const string MESSAGE_FINGERDOLLARS_TERMS_4 = "MESSAGE_FINGERDOLLARS_TERMS_4";
        public const string MESSAGE_FINGERDOLLARS_TERMS_5 = "MESSAGE_FINGERDOLLARS_TERMS_5";
        public const string MESSAGE_FINGERDOLLARS_TERMS_6 = "MESSAGE_FINGERDOLLARS_TERMS_6";
        public const string MESSAGE_FINGERDOLLARS_TERMS_7 = "MESSAGE_FINGERDOLLARS_TERMS_7";
        public const string MESSAGE_FINGERDOLLARS_TERMS_8 = "MESSAGE_FINGERDOLLARS_TERMS_8";
        public const string MESSAGE_FINGERDOLLARS_TERMS_9 = "MESSAGE_FINGERDOLLARS_TERMS_9";
        public const string MESSAGE_FINGERDOLLARS_TERMS_10 = "MESSAGE_FINGERDOLLARS_TERMS_10";
        public const string MESSAGE_FINGERDOLLARS_TERMS_11 = "MESSAGE_FINGERDOLLARS_TERMS_11";
        public const string MESSAGE_FINGERDOLLARS_TERMS_12 = "MESSAGE_FINGERDOLLARS_TERMS_12";
        public const string MESSAGE_FINGERDOLLARS_TERMS_13 = "MESSAGE_FINGERDOLLARS_TERMS_13";
        public const string MESSAGE_FINGERDOLLARS_TERMS_14 = "MESSAGE_FINGERDOLLARS_TERMS_14";
        public const string MESSAGE_FINGERDOLLARS_TERMS_15 = "MESSAGE_FINGERDOLLARS_TERMS_15";
        public const string MESSAGE_FINGERDOLLARS_TERMS_16 = "MESSAGE_FINGERDOLLARS_TERMS_16";
        public const string MESSAGE_FINGERDOLLARS_TERMS_17 = "MESSAGE_FINGERDOLLARS_TERMS_17";

        public const string MESSAGE_FINGERDOLLARS_TERMS_18 = "MESSAGE_FINGERDOLLARS_TERMS_18";
        public const string MESSAGE_FINGERDOLLARS_TERMS_19 = "MESSAGE_FINGERDOLLARS_TERMS_19";
        public const string MESSAGE_FINGERDOLLARS_TERMS_20 = "MESSAGE_FINGERDOLLARS_TERMS_20";
        public const string MESSAGE_FINGERDOLLARS_TERMS_21 = "MESSAGE_FINGERDOLLARS_TERMS_21";
        public const string MESSAGE_FINGERDOLLARS_TERMS_22 = "MESSAGE_FINGERDOLLARS_TERMS_22";
        public const string MESSAGE_FINGERDOLLARS_TERMS_23 = "MESSAGE_FINGERDOLLARS_TERMS_23";
        public const string MESSAGE_FREE_DELIVERY = "MESSAGE_FREE_DELIVERY";
        public const string MESSAGE_TELL_A_FRIEND = "MESSAGE_TELL_A_FRIEND";
        public const string MESSAGE_LOTTERY = "MESSAGE_LOTTERY";
        public const string MESSAGE_LUCKY_DRAW = "MESSAGE_LUCKY_DRAW";
        public const string MESSAGE_ALL_COLOR = "MESSAGE_ALL_COLOR";
        public const string MESSAGE_COMPANY_PARTNERS = "MESSAGE_COMPANY_PARTNERS";
        public const string MESSAGE_TO_LOVE_2 = "MESSAGE_TO_LOVE_2";
        public const string MESSAGE_ALL_PRICES = "MESSAGE_ALL_PRICES";
        public const string MESSAGE_FINGERSHOPPING_COM = "MESSAGE_FINGERSHOPPING_COM";
        public const string MESSAGE_POINTING_LIFE = "MESSAGE_POINTING_LIFE";
        public const string MESSAGE_BRAND_DEALERS = "MESSAGE_BRAND_DEALERS";
        public const string MESSAGE_OWNS_STOCK = "MESSAGE_OWNS_STOCK";
        public const string MESSAGE_REGISTERED_COMPANY = "MESSAGE_REGISTERED_COMPANY";
        public const string MESSAGE_EFFORTS_TO_PROMOTE = "MESSAGE_EFFORTS_TO_PROMOTE";
        public const string MESSAGE_SERVICE_AND_PROMOTION = "MESSAGE_SERVICE_AND_PROMOTION";
        public const string MESSAGE_DISCUSS_JOINING_DETAILS = "MESSAGE_DISCUSS_JOINING_DETAILS";
        public const string MESSAGE_PLEASE_EMAIL = "MESSAGE_PLEASE_EMAIL";
        public const string MESSAGE_CONTACT_OUR_BUSINESS = "MESSAGE_CONTACT_OUR_BUSINESS";
        public const string MESSAGE_SPECIAL_THANKS_TO = "MESSAGE_SPECIAL_THANKS_TO";
        public const string MESSAGE_GOUPMALL_COLLECTING = "MESSAGE_GOUPMALL_COLLECTING";
        public const string MESSAGE_LIMITED_EDITION = "MESSAGE_LIMITED_EDITION";
        public const string MESSAGE_LIMITED_TIME = "MESSAGE_LIMITED_TIME";
        public const string MESSAGE_SUBSCRIBE_TO_ENEWS = "MESSAGE_SUBSCRIBE_TO_ENEWS";
        public const string VIP_SUBSCRIBE_TO_ENEWS = "VIP_SUBSCRIBE_TO_ENEWS";
        public const string MESSAGE_EMAIL_FORMAT_ERROR = "MESSAGE_EMAIL_FORMAT_ERROR";
        public const string MESSAGE_ACCOUNT_FORMAT_ERROR = "MESSAGE_ACCOUNT_FORMAT_ERROR";
        public const string MESSAGE_PASSWORDERROR = "MESSAGE_PASSWORDERROR";
        public const string MESSAGE_PASSWORDERROR_2 = "MESSAGE_PASSWORDERROR_2";
        public const string MESSAGE_SUBSCRIBE_TO_ELECTRONIC_INFORMATION = "MESSAGE_SUBSCRIBE_TO_ELECTRONIC_INFORMATION";
        public const string MESSAGE_OFFER_EXPIRED = "MESSAGE_OFFER_EXPIRED";
        public const string MESSAGE_MEMBER_OF_VIP_STARS = "MESSAGE_MEMBER_OF_VIP_STARS";
        public const string MESSAGE_UPGRADED_VIP_MEMBER_STARS = "MESSAGE_UPGRADED_VIP_MEMBER_STARS";
        public const string MESSAGE_WINNING_NUMBERS = "MESSAGE_WINNING_NUMBERS";
        public const string MESSAGE_SUCCESS_WINNING_NUMBERS = "MESSAGE_SUCCESS_WINNING_NUMBERS";
        public const string MESSAGE_FINGERSHOPPING_LOGIN = "MESSAGE_FINGERSHOPPING_LOGIN";
        public const string MESSAGE_FINGERSHOPPING_MEMBER_REGISTRATION = "MESSAGE_FINGERSHOPPING_MEMBER_REGISTRATION";
        public const string MESSAGE_CERTIFIED_CODE = "MESSAGE_CERTIFIED_CODE";
        public const string MESSAGE_AUTHENTICATION_CODE = "MESSAGE_AUTHENTICATION_CODE";
        public const string MESSAGE_FILL_IN_WINNING_NUMBER = "MESSAGE_FILL_IN_WINNING_NUMBER";
        public const string MESSAGE_FILL_IN_EMAIL = "MESSAGE_FILL_IN_EMAIL";
        public const string MESSAGE_ENTER_A_PASSWORD = "MESSAGE_ENTER_A_PASSWORD";
        public const string MESSAGE_FILL_IN_ACCOUNT_NAME = "MESSAGE_FILL_IN_ACCOUNT_NAME";
        public const string MESSAGE_FILL_IN_USER_NAME = "MESSAGE_FILL_IN_USER_NAME";
        public const string MESSAGE_USER_NAME_FORMAT = "MESSAGE_USER_NAME_FORMAT";
        public const string MESSAGE_RFVRGMPHON = "MESSAGE_RFVRGMPHON";
        public const string MESSAGE_RFVRGVERIFYCODE = "MESSAGE_RFVRGVERIFYCODE";
        public const string MESSAGE_AUTHENTICATION_CODE_ERRO = "MESSAGE_AUTHENTICATION_CODE_ERRO";
        public const string MESSAGE_CHKRGAGREE = "MESSAGE_CHKRGAGREE";
        public const string MESSAGE_RFVRGAGREE = "MESSAGE_RFVRGAGREE";
        public const string MESSAGE_CHKRGNEWSLETTER = "MESSAGE_CHKRGNEWSLETTER";
        public const string MESSAGE_RFVRGNEWSLETTER = "MESSAGE_RFVRGNEWSLETTER";
        public const string MESSAGE_FINGERSHOPPING_ACCOUNT = "MESSAGE_FINGERSHOPPING_ACCOUNT";
        public const string MESSAGE_ENTER_THE_WINNING_NUMBERS = "MESSAGE_ENTER_THE_WINNING_NUMBERS";
        public const string MESSAGE_HAVE_TO_LOG_IN = "MESSAGE_HAVE_TO_LOG_IN";
        public const string MESSAGE_CHECK_BEFORE_SUBMITTING = "MESSAGE_CHECK_BEFORE_SUBMITTING";
        public const string MESSAGE_BEING_MEMBER = "MESSAGE_BEING_MEMBER";
        public const string MESSAGE_REDEMPTION_PRIZES = "MESSAGE_REDEMPTION_PRIZES";
        public const string MESSAGE_PROCEDURES_PERFORMED = "MESSAGE_PROCEDURES_PERFORMED";
        public const string MESSAGE_AUTHENTICATION_CODE_SENT = "MESSAGE_AUTHENTICATION_CODE_SENT";
        public const string MESSAGE_ACCOUNT_REGISTRATION = "MESSAGE_ACCOUNT_REGISTRATION";
        public const string MESSAGE_REGISTRATION_ACCOUNT_ERROR = "MESSAGE_REGISTRATION_ACCOUNT_ERROR";
        public const string MESSAGE_PRIZE_REDEMPTION_DETAILS = "MESSAGE_PRIZE_REDEMPTION_DETAILS";
        public const string MESSAGE_WINNING_NUMBERS_1 = "MESSAGE_WINNING_NUMBERS_1";
        public const string MESSAGE_PRIZE = "MESSAGE_PRIZE";
        public const string MESSAGE_PERIOD = "MESSAGE_PERIOD";
        public const string MESSAGE_PLACE = "MESSAGE_PLACE";
        public const string MESSAGE_SCORE = "MESSAGE_SCORE";
        public const string MESSAGE_MY_COMMENT = "MESSAGE_MY_COMMENT";
        public const string MESSAGE_PERSONAL_INFORMATION = "MESSAGE_PERSONAL_INFORMATION";
        public const string MESSAGE_NO_ANY_EVALUATION = "MESSAGE_NO_ANY_EVALUATION";
        public const string MESSAGE_COMMENTS_BLANK = "MESSAGE_COMMENTS_BLANK";
        public const string MESSAGE_INQUIRY_1 = "MESSAGE_INQUIRY_1";
        public const string MESSAGE_ANY_ELECTRONIC_COUPONS = "MESSAGE_ANY_ELECTRONIC_COUPONS";
        public const string MESSAGE_MY_ECOUPONS_3 = "MESSAGE_MY_ECOUPONS_3";
        public const string MESSAGE_MY_EVOUCHER = "MESSAGE_MY_EVOUCHER";
        public const string MESSAGE_ALL_ELECTRONIC_COUPONS = "MESSAGE_ALL_ELECTRONIC_COUPONS";
        public const string MESSAGE_ELECTRONIC_COUPONS_USED = "MESSAGE_ELECTRONIC_COUPONS_USED";
        public const string MESSAGE_EXPIRED_ELECTRONIC_VOUCHER_1 = "MESSAGE_EXPIRED_ELECTRONIC_VOUCHER_1";
        public const string MESSAGE_SAVED_SEARCH = "MESSAGE_SAVED_SEARCH";
        public const string MESSAGE_NO_LOVE_MERCHANDISE = "MESSAGE_NO_LOVE_MERCHANDISE";
        public const string MESSAGE_MY_FAVOURITE_FINGERSHOPPING = "MESSAGE_MY_FAVOURITE_FINGERSHOPPING";
        public const string MESSAGE_STORE_IN_FINGERSHOPPING = "MESSAGE_STORE_IN_FINGERSHOPPING";
        public const string MESSAGE_MY_FAVOURITE = "MESSAGE_MY_FAVOURITE";
        public const string MESSAGE_MY_POINTS = "MESSAGE_MY_POINTS";
        public const string MESSAGE_POINTS_METHOD = "MESSAGE_POINTS_METHOD";
        public const string MESSAGE_FINGERDOLLARS_METHOD = "MESSAGE_FINGERDOLLARS_METHOD";
        public const string MESSAGE_FOLLOWING_COMMODITIES = "MESSAGE_FOLLOWING_COMMODITIES";
        public const string MESSAGE_MY_FINGERDOLLARS_1 = "MESSAGE_MY_FINGERDOLLARS_1";
        public const string MESSAGE_HAVE_NO_ORDERS = "MESSAGE_HAVE_NO_ORDERS";
        public const string MESSAGE_FAVORITE_STORES = "MESSAGE_FAVORITE_STORES";
        public const string MESSAGE_MY_PROFILE = "MESSAGE_MY_PROFILE";
        public const string MESSAGE_MEMBERSHIP_CATEGORY_BASIC_MEMBER = "MESSAGE_MEMBERSHIP_CATEGORY_BASIC_MEMBER";
        public const string MESSAGE_MEMBERSHIP_CATEGORY = "MESSAGE_MEMBERSHIP_CATEGORY";
        public const string MESSAGE_UPGRADE_THE_VIP = "MESSAGE_UPGRADE_THE_VIP";
        public const string MESSAGE_JOIN_DATETIME = "MESSAGE_JOIN_DATETIME";
        public const string MESSAGE_CUMULATIVE_START_DATE = "MESSAGE_CUMULATIVE_START_DATE";
        public const string MESSAGE_CUMULATIVE_MATURITY_DATE = "MESSAGE_CUMULATIVE_MATURITY_DATE";
        public const string MESSAGE_CUMULATIVE_DURATION = "MESSAGE_CUMULATIVE_DURATION";
        public const string MESSAGE_AMOUNT_OF_CONSUMPTION = "MESSAGE_AMOUNT_OF_CONSUMPTION";
        public const string MESSAGE_CUMULATIVE_AMOUNT_REQUIRED = "MESSAGE_CUMULATIVE_AMOUNT_REQUIRED";
        public const string MESSAGE_ACCUMULATED_IN = "MESSAGE_ACCUMULATED_IN";
        public const string MESSAGE_UNSUCCESSFUL = "MESSAGE_UNSUCCESSFUL";
        public const string MESSAGE_VIP_MEMBERSHIP = "MESSAGE_VIP_MEMBERSHIP";
        public const string MESSAGE_NEW_OFFER = "MESSAGE_NEW_OFFER";
        public const string MESSAGE_CHOOSE_YOUR_PICK = "MESSAGE_CHOOSE_YOUR_PICK";
        public const string MESSAGE_LINK_HAS_EXPIRED = "MESSAGE_LINK_HAS_EXPIRED";
        public const string MESSAGE_ORDER_SUMMARY = "MESSAGE_ORDER_SUMMARY";
        public const string MESSAGE_PAYMENT_USE = "MESSAGE_PAYMENT_USE";
        public const string MESSAGE_CREDIT_CARD_NUMBER = "MESSAGE_CREDIT_CARD_NUMBER";
        public const string MESSAGE_DISTRIBUTION_AND_COLLECTION_MATTERS = "MESSAGE_DISTRIBUTION_AND_COLLECTION_MATTERS";
        public const string MESSAGE_TOTAL_FREIGHT = "MESSAGE_TOTAL_FREIGHT";
        public const string MESSAGE_USE_FINGERDOLLARS = "MESSAGE_USE_FINGERDOLLARS";
        public const string MESSAGE_OTHER_CHARGES = "MESSAGE_OTHER_CHARGES";
        public const string MESSAGE_EARN_FINGERDOLLARS = "MESSAGE_EARN_FINGERDOLLARS";
        public const string MESSAGE_TOTAL_PAYMENTS = "MESSAGE_TOTAL_PAYMENTS";
        public const string MESSAGE_CHECKOUT_ONLINE_USE = "MESSAGE_CHECKOUT_ONLINE_USE";
        public const string MESSAGE_PACKAGE_TYPE = "MESSAGE_PACKAGE_TYPE";
        public const string MESSAGE_EXPRESS_SHIPPING = "MESSAGE_EXPRESS_SHIPPING";
        public const string MESSAGE_PRIVACY = "MESSAGE_PRIVACY";
        public const string MESSAGE_PRIVACY_1 = "MESSAGE_PRIVACY_1";
        public const string MESSAGE_PRIVACY_1_1 = "MESSAGE_PRIVACY_1_1";
        public const string MESSAGE_PRIVACY_1_2 = "MESSAGE_PRIVACY_1_2";
        public const string MESSAGE_PRIVACY_1_3 = "MESSAGE_PRIVACY_1_3";

        public const string MESSAGE_PRIVACY_2 = "MESSAGE_PRIVACY_2";
        public const string MESSAGE_PRIVACY_2_1 = "MESSAGE_PRIVACY_2_1";
        public const string MESSAGE_PRIVACY_2_2 = "MESSAGE_PRIVACY_2_2";
        public const string MESSAGE_PRIVACY_2_3 = "MESSAGE_PRIVACY_2_3";
        public const string MESSAGE_PRIVACY_2_4 = "MESSAGE_PRIVACY_2_4";


        public const string MESSAGE_PRIVACY_3 = "MESSAGE_PRIVACY_3";
        public const string MESSAGE_PRIVACY_3_1 = "MESSAGE_PRIVACY_3_1";
        public const string MESSAGE_PRIVACY_3_2 = "MESSAGE_PRIVACY_3_2";
        public const string MESSAGE_PRIVACY_3_3 = "MESSAGE_PRIVACY_3_3";
        public const string MESSAGE_PRIVACY_3_4 = "MESSAGE_PRIVACY_3_4";
        public const string MESSAGE_PRIVACY_3_5 = "MESSAGE_PRIVACY_3_5";
        public const string MESSAGE_PRIVACY_3_6 = "MESSAGE_PRIVACY_3_6";
        public const string MESSAGE_PRIVACY_3_OTHER = "MESSAGE_PRIVACY_3_OTHER";
        public const string MESSAGE_PRIVACY_4 = "MESSAGE_PRIVACY_4";
        public const string MESSAGE_PRIVACY_4_1 = "MESSAGE_PRIVACY_4_1";
        public const string MESSAGE_PRIVACY_5 = "MESSAGE_PRIVACY_5";
        public const string MESSAGE_PRIVACY_5_1 = "MESSAGE_PRIVACY_5_1";
        public const string MESSAGE_PRIVACY_5_2 = "MESSAGE_PRIVACY_5_2";

        public const string MESSAGE_PRIVACY_6 = "MESSAGE_PRIVACY_6";
        public const string MESSAGE_PRIVACY_6_1 = "MESSAGE_PRIVACY_6_1";
        public const string MESSAGE_PRIVACY_6_2 = "MESSAGE_PRIVACY_6_2";
        public const string MESSAGE_PRIVACY_6_3 = "MESSAGE_PRIVACY_6_3";

        public const string MESSAGE_PRIVACY_7 = "MESSAGE_PRIVACY_7";
        public const string MESSAGE_PRIVACY_7_1 = "MESSAGE_PRIVACY_7_1";

        public const string MESSAGE_PRIVACY_8 = "MESSAGE_PRIVACY_8";
        public const string MESSAGE_PRIVACY_8_1 = "MESSAGE_PRIVACY_8_1";
        public const string MESSAGE_PRIVACY_8_2 = "MESSAGE_PRIVACY_8_2";
        public const string MESSAGE_PRIVACY_8_3 = "MESSAGE_PRIVACY_8_3";
        public const string MESSAGE_PRIVACY_9 = "MESSAGE_PRIVACY_9";
        public const string MESSAGE_PRIVACY_9_1 = "MESSAGE_PRIVACY_9_1";
        public const string MESSAGE_PRIVACY_10 = "MESSAGE_PRIVACY_10";
        public const string MESSAGE_PRIVACY_10_1 = "MESSAGE_PRIVACY_10_1";
        public const string MESSAGE_PRIVACY_10_2 = "MESSAGE_PRIVACY_10_2";
        public const string MESSAGE_PRIVACY_10_3 = "MESSAGE_PRIVACY_10_3";
        public const string MESSAGE_LIPREORDERLOGO = "MESSAGE_LIPREORDERLOGO";
        public const string MESSAGE_LICERTIFIEDPROFESSIONALLOGO = "MESSAGE_LICERTIFIEDPROFESSIONALLOGO";
        public const string MESSAGE_LIENVIRONMENTFRIENDLYLOGO = "MESSAGE_LIENVIRONMENTFRIENDLYLOGO";
        public const string MESSAGE_LILIMITEDQUANTITYLOGO = "MESSAGE_LILIMITEDQUANTITYLOGO";
        public const string MESSAGE_LILIMITEDPERIODLOGO = "MESSAGE_LILIMITEDPERIODLOGO";
        public const string MESSAGE_LIEXCLUSIVELOGO = "MESSAGE_LIEXCLUSIVELOGO";
        public const string MESSAGE_LIDESIGNERBRANDLOGO = "MESSAGE_LIDESIGNERBRANDLOGO";
        public const string MESSAGE_PRODUCT_DESCRIPTION = "MESSAGE_PRODUCT_DESCRIPTION";
        public const string MESSAGE_PRODUCT_ATTRIBUTES = "MESSAGE_PRODUCT_ATTRIBUTES";
        public const string MESSAGE_ITEMS_2 = "MESSAGE_ITEMS_2";
        public const string MESSAGE_LINKRATING = "MESSAGE_LINKRATING";
        public const string MESSAGE_SIZE_CHART = "MESSAGE_SIZE_CHART";
        public const string MESSAGE_DELIVERY_DETAILS_2 = "MESSAGE_DELIVERY_DETAILS_2";
        public const string MESSAGE_FAVORITE = "MESSAGE_FAVORITE";
        public const string MESSAGE_CUSTOMER_REVIEWS = "MESSAGE_CUSTOMER_REVIEWS";
        public const string MESSAGE_ADD_TO_FAVORITES = "MESSAGE_ADD_TO_FAVORITES";
        public const string MESSAGE_FAVORITE_NUMBER = "MESSAGE_FAVORITE_NUMBER";
        public const string MESSAGE_ENTER_SHOP = "MESSAGE_ENTER_SHOP";
        public const string MESSAGE_OUR_FAVORITE = "MESSAGE_OUR_FAVORITE";
        public const string MESSAGE_GOODS_ONLY_LAST = "MESSAGE_GOODS_ONLY_LAST";
        public const string MESSAGE_ADJUST_THE_PURCHASE = "MESSAGE_ADJUST_THE_PURCHASE";
        public const string MESSAGE_PRODUCT_DOES_NOT = "MESSAGE_PRODUCT_DOES_NOT";
        public const string MESSAGE_CHOOSE_ANOTHER_MATCH = "MESSAGE_CHOOSE_ANOTHER_MATCH";
        public const string MESSAGE_GOODS_DELIVERY_DATE = "MESSAGE_GOODS_DELIVERY_DATE";
        public const string MESSAGE_FASTEST_SELECTABLE = "MESSAGE_FASTEST_SELECTABLE";
        public const string MESSAGE_NO_COMMENTS = "MESSAGE_NO_COMMENTS";
        public const string MESSAGE_REVIEWS = "MESSAGE_REVIEWS";
        public const string MESSAGE_HAVE_RECEIPT_RATING = "MESSAGE_HAVE_RECEIPT_RATING";
        public const string MESSAGE_SELLING_PRICE = "MESSAGE_SELLING_PRICE";
        public const string MESSAGE_CONCESSIONS_TO_CART = "MESSAGE_CONCESSIONS_TO_CART";
        public const string MESSAGE_BUY_THIS_OFFER = "MESSAGE_BUY_THIS_OFFER";
        public const string MESSAGE_PRODUCT_SIZE = "MESSAGE_PRODUCT_SIZE";
        public const string MESSAGE_LONG = "MESSAGE_LONG";
        public const string MESSAGE_WIDE = "MESSAGE_WIDE";
        public const string MESSAGE_HIGH = "MESSAGE_HIGH";
        public const string MESSAGE_PAGE = "MESSAGE_PAGE";
        public const string MESSAGE_WITH_PACKAGING = "MESSAGE_WITH_PACKAGING";
        public const string MESSAGE_NW = "MESSAGE_NW";
        public const string MESSAGE_COUNTRY_OF_ORIGIN = "MESSAGE_COUNTRY_OF_ORIGIN";
        public const string MESSAGE_REGION_OF_ORIGIN = "MESSAGE_REGION_OF_ORIGIN";
        public const string MESSAGE_DESIGNED_TO = "MESSAGE_DESIGNED_TO";
        public const string MESSAGE_SHELF_LIFE = "MESSAGE_SHELF_LIFE";
        public const string MESSAGE_MAINTENANCE_PERIOD = "MESSAGE_MAINTENANCE_PERIOD";
        public const string MESSAGE_MODEL = "MESSAGE_MODEL";
        public const string MESSAGE_FIREDN_EMAIL = "MESSAGE_FIREDN_EMAIL";
        public const string MESSAGE_FIREDN_EMAIL_2 = "MESSAGE_FIREDN_EMAIL_2";
        public const string MESSAGE_ENGLISH_VERSION_SHALL = "MESSAGE_ENGLISH_VERSION_SHALL";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_1_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_1_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_1_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_1_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_1_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_1_3";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_2_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_2_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_2_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_2_2";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_2_2_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_2_2_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_2_2_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_2_2_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_2_2_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_2_2_3";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_6 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_6";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_7 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_7";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_8 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_8";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_9 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_9";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_10 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_10";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_11 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_11";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_12 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_12";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_13 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_13";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_14 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_14";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_15 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_15";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_16 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_16";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_17 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_17";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_18 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_18";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_19 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_19";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_20 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_20";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_21 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_21";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_3_3_22 = "MESSAGE_REGISTRATION_TERMS_POPUP_3_3_22";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_4_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_4_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_4_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_4_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_4_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_4_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_4_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_4_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_4_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_4_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_5_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_5_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_6 = "MESSAGE_REGISTRATION_TERMS_POPUP_6";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_6_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_6_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_7 = "MESSAGE_REGISTRATION_TERMS_POPUP_7";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_7_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_7_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_8 = "MESSAGE_REGISTRATION_TERMS_POPUP_8";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_8_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_8_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_9 = "MESSAGE_REGISTRATION_TERMS_POPUP_9";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_9_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_9_1";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_10 = "MESSAGE_REGISTRATION_TERMS_POPUP_10";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_10_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_10_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_11 = "MESSAGE_REGISTRATION_TERMS_POPUP_11";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_11_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_11_1";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_11_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_11_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_11_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_11_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_12 = "MESSAGE_REGISTRATION_TERMS_POPUP_12";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_12_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_12_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_13 = "MESSAGE_REGISTRATION_TERMS_POPUP_13";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_13_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_13_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_14 = "MESSAGE_REGISTRATION_TERMS_POPUP_14";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_14_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_14_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_14_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_14_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_15 = "MESSAGE_REGISTRATION_TERMS_POPUP_15";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_15_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_15_1";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16 = "MESSAGE_REGISTRATION_TERMS_POPUP_16";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_4";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_4_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_4_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_4_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_4_2";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_6 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_6";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_7 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_7";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_8 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_8";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_9 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_9";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_10 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_10";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_11 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_11";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_5_12 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_5_12";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_6 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_6";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_7 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_7";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_16_8 = "MESSAGE_REGISTRATION_TERMS_POPUP_16_8";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_17 = "MESSAGE_REGISTRATION_TERMS_POPUP_17";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_17_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_17_1";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18 = "MESSAGE_REGISTRATION_TERMS_POPUP_18";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_2_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_2_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_2_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_2_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_2_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_2_3";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_3_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_3_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_3_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_3_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_3_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_3_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_3_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_3_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_3_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_3_5";


        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_4_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_4_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_4_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_4_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_18_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_18_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19 = "MESSAGE_REGISTRATION_TERMS_POPUP_19";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_1_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_1_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_5 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_5";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_19_6 = "MESSAGE_REGISTRATION_TERMS_POPUP_19_6";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_20 = "MESSAGE_REGISTRATION_TERMS_POPUP_20";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_20_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_20_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_20_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_20_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_21 = "MESSAGE_REGISTRATION_TERMS_POPUP_21";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_21_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_21_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_22 = "MESSAGE_REGISTRATION_TERMS_POPUP_22";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_22_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_22_2";

        public const string MESSAGE_REGISTRATION_TERMS_POPUP_23 = "MESSAGE_REGISTRATION_TERMS_POPUP_23";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_23_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_23_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_24 = "MESSAGE_REGISTRATION_TERMS_POPUP_24";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_24_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_24_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_25 = "MESSAGE_REGISTRATION_TERMS_POPUP_25";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_25_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_25_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_26 = "MESSAGE_REGISTRATION_TERMS_POPUP_26";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_26_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_26_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_27 = "MESSAGE_REGISTRATION_TERMS_POPUP_27";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_27_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_27_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_28 = "MESSAGE_REGISTRATION_TERMS_POPUP_28";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_28_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_28_1";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_28_2 = "MESSAGE_REGISTRATION_TERMS_POPUP_28_2";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_28_3 = "MESSAGE_REGISTRATION_TERMS_POPUP_28_3";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_28_4 = "MESSAGE_REGISTRATION_TERMS_POPUP_28_4";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_29 = "MESSAGE_REGISTRATION_TERMS_POPUP_29";
        public const string MESSAGE_REGISTRATION_TERMS_POPUP_29_1 = "MESSAGE_REGISTRATION_TERMS_POPUP_29_1";
        public const string MESSAGE_POST_METHOD = "MESSAGE_POST_METHOD";
        public const string MESSAGE_OFFERS_TIPS = "MESSAGE_OFFERS_TIPS";
        public const string MESSAGE_EXPECTED_DELIVERY_DATE = "MESSAGE_EXPECTED_DELIVERY_DATE";
        public const string MESSAGE_ELECTRONIC_COUPONS_OR_POINTING_GIFT_CARD = "MESSAGE_ELECTRONIC_COUPONS_OR_POINTING_GIFT_CARD";
        public const string MESSAGE_PLOT_POINT_CASH = "MESSAGE_PLOT_POINT_CASH";
        public const string MESSAGE_BACK_SHOPPING = "MESSAGE_BACK_SHOPPING";
        public const string MESSAGE_TO_CHECKOUT = "MESSAGE_TO_CHECKOUT";
        public const string MESSAGE_BUY_GROCERIES = "MESSAGE_BUY_GROCERIES";
        public const string MESSAGE_FREE_SHIPPING_ON_ORDERS = "MESSAGE_FREE_SHIPPING_ON_ORDERS";
        public const string MESSAGE_RESERVATIONS_GOODS_ORDERS = "MESSAGE_RESERVATIONS_GOODS_ORDERS";
        public const string MESSAGE_SPOT_ORDERS = "MESSAGE_SPOT_ORDERS";
        public const string MESSAGE_BOOKING_PERIOD_HAS_ENDED = "MESSAGE_BOOKING_PERIOD_HAS_ENDED";
        public const string MESSAGE_COMBINATION_BUY = "MESSAGE_COMBINATION_BUY";
        public const string MESSAGE_TOTAL_PAYMENTS_1 = "MESSAGE_TOTAL_PAYMENTS_1";
        public const string MESSAGE_RETURN_TO_CART = "MESSAGE_RETURN_TO_CART";
        public const string MESSAGE_REGISTERED_FOR_RENEWAL = "MESSAGE_REGISTERED_FOR_RENEWAL";
        public const string MESSAGE_SHOPPING_CART_IS_EMPTY = "MESSAGE_SHOPPING_CART_IS_EMPTY";
        public const string MESSAGE_SEARCH_FILTERS = "MESSAGE_SEARCH_FILTERS";
        public const string MESSAGE_FIND_THE_PAGE = "MESSAGE_FIND_THE_PAGE";
        public const string MESSAGE_LINKS_MAY_BE_DEAD = "MESSAGE_LINKS_MAY_BE_DEAD";
        public const string MESSAGE_SSL_IS_REQUIRED = "MESSAGE_SSL_IS_REQUIRED";
        public const string MESSAGE_URL_HTTPS_SECURE = "MESSAGE_URL_HTTPS_SECURE";
        public const string MESSAGE_SYSTEM_UPGRADE = "MESSAGE_SYSTEM_UPGRADE";
        public const string MESSAGE_THIS_SITE_SYSTEM_UPGRADE = "MESSAGE_THIS_SITE_SYSTEM_UPGRADE";
        public const string MESSAGE_WEB_SERVER_BUSY = "MESSAGE_WEB_SERVER_BUSY";
        public const string MESSAGE_WEB_PAGE_IS_CURRENTLY_UNAVAILABLE = "MESSAGE_WEB_PAGE_IS_CURRENTLY_UNAVAILABLE";
        public const string MESSAGE_FAVORITE_1 = "MESSAGE_FAVORITE_1";
        public const string MESSAGE_LOGIN_VIEW_MORE = "MESSAGE_LOGIN_VIEW_MORE";
        public const string MESSAGE_REVIEW_1 = "MESSAGE_REVIEW_1";
        public const string MESSAGE_FIND_FAVORITE_PRODUCTS = "MESSAGE_FIND_FAVORITE_PRODUCTS";
        public const string MESSAGE_STORE_RATINGS = "MESSAGE_STORE_RATINGS";
        public const string MESSAGE_SHOP = "MESSAGE_SHOP";
        public const string MESSAGE_LETTERS_OR_CLASSIFICATION = "MESSAGE_LETTERS_OR_CLASSIFICATION";
        public const string MESSAGE_STORE_NAME_CATEGORY = "MESSAGE_STORE_NAME_CATEGORY";
        public const string MESSAGE_VIEW_ALL_STORES = "MESSAGE_VIEW_ALL_STORES";
        public const string MESSAGE_ARTICLE_PRODUCT_REVIEWS = "MESSAGE_ARTICLE_PRODUCT_REVIEWS";
        public const string MESSAGE_VIEW_THIS_SHOP_ALL_REVIEWS = "MESSAGE_VIEW_THIS_SHOP_ALL_REVIEWS";
        public const string MESSAGE_COYPRIGHT_2 = "MESSAGE_COYPRIGHT_2";
        public const string MESSAGE_TREND_STATIONERY = "MESSAGE_TREND_STATIONERY";
        public const string MESSAGE_CHANGE_PASSWORD = "MESSAGE_CHANGE_PASSWORD";
        public const string MESSAGE_OUR_PARTNERSHIP = "MESSAGE_OUR_PARTNERSHIP";
        public const string MESSAGE_STORE_LOCATION = "MESSAGE_STORE_LOCATION";
        public const string MESSAGE_DELIVERY_TO_REMOTE_OR_FAILURE = "MESSAGE_DELIVERY_TO_REMOTE_OR_FAILURE";
        public const string MESSAGE_STORENO = "MESSAGE_STORENO";
        public const string MESSAGE_SELECT_A_REGION = "MESSAGE_SELECT_A_REGION";
        public const string MESSAGE_SHOPS_IN_REMOTE_PLACES = "MESSAGE_SHOPS_IN_REMOTE_PLACES";
        public const string MESSAGE_FOUND = "MESSAGE_FOUND";
        public const string MESSAGE_SHOPS = "MESSAGE_SHOPS";
        public const string MESSAGE_CONFIRM_YOUR_ORDER_DETAILS = "MESSAGE_CONFIRM_YOUR_ORDER_DETAILS";
        public const string MESSAGE_SHEK_KONG = "MESSAGE_SHEK_KONG";
        public const string MESSAGE_KEYCHAIN = "MESSAGE_KEYCHAIN";
        public const string MESSAGE_AIR_PURIFIER = "MESSAGE_AIR_PURIFIER";
        public const string MESSAGE_RABBIT_TAPE_DISPENSER = "MESSAGE_RABBIT_TAPE_DISPENSER";
        public const string MESSAGE_PACKAGING_CATEGORY = "MESSAGE_PACKAGING_CATEGORY";
        public const string MESSAGE_BUY_TWO = "MESSAGE_BUY_TWO";
        public const string MESSAGE_PLOT_POINTS = "MESSAGE_PLOT_POINTS";
        public const string MESSAGE_ACCUMULATED_POINTS = "MESSAGE_ACCUMULATED_POINTS";
        public const string MESSAGE_USE_ONLINE_CHECKOUT = "MESSAGE_USE_ONLINE_CHECKOUT";
        public const string MESSAGE_CANCELED_ONCE_CONFIRMED = "MESSAGE_CANCELED_ONCE_CONFIRMED";
        public const string MESSAGE_CONFIRM_YOUR_ORDER = "MESSAGE_CONFIRM_YOUR_ORDER";
        public const string MESSAGE_MORE_GOODS_ORDERED = "MESSAGE_MORE_GOODS_ORDERED";
        public const string MESSAGE_EARN_FINGERDOLLARS_1 = "MESSAGE_EARN_FINGERDOLLARS_1";
        public const string MESSAGE_PRIZE_REDEMPTION_1 = "MESSAGE_PRIZE_REDEMPTION_1";
        public const string MESSAGE_REGISTERED_FOR_RENEWAL_1 = "MESSAGE_REGISTERED_FOR_RENEWAL_1";
        public const string MESSAGE_THE_TRANSACTION_FAILED = "MESSAGE_THE_TRANSACTION_FAILED";
        public const string MESSAGE_CART_MODIFY_SUBSCRIPTION = "MESSAGE_CART_MODIFY_SUBSCRIPTION";
        public const string MESSAGE_LOGIN_TIMED_OUT = "MESSAGE_LOGIN_TIMED_OUT";
        public const string MESSAGE_DATA_INPUT_OVER_TIME = "MESSAGE_DATA_INPUT_OVER_TIME";
        public const string MESSAGE_LAST_PIECE_OF_MERCHANDISE = "MESSAGE_LAST_PIECE_OF_MERCHANDISE";
        public const string MESSAGE_DELIVERY_WAIVE = "MESSAGE_DELIVERY_WAIVE";
        public const string MESSAGE_TRANSLATION_SOLELY = "MESSAGE_TRANSLATION_SOLELY";
        public const string MESSAGE_PREVAIL = "MESSAGE_PREVAIL";
        public const string MESSAGE_TERMS_17_1 = "MESSAGE_TERMS_17_1";
        public const string MESSAGE_TERMS_17_2_1 = "MESSAGE_TERMS_17_2_1";
        public const string MESSAGE_TERMS_17_2_2 = "MESSAGE_TERMS_17_2_2";
        public const string MESSAGE_TERMS_17_2_3 = "MESSAGE_TERMS_17_2_3";
        public const string MESSAGE_TERMS_17_2_4 = "MESSAGE_TERMS_17_2_4";
        public const string MESSAGE_TERMS_17_2_5 = "MESSAGE_TERMS_17_2_5";
        public const string MESSAGE_TERMS_17_2_6 = "MESSAGE_TERMS_17_2_6";
        public const string MESSAGE_TERMS_17_2_7 = "MESSAGE_TERMS_17_2_7";
        public const string MESSAGE_TERMS_17_2_8 = "MESSAGE_TERMS_17_2_8";
        public const string MESSAGE_TERMS_17_2_9 = "MESSAGE_TERMS_17_2_9";
        public const string MESSAGE_TERMS_17_3 = "MESSAGE_TERMS_17_3";
        public const string MESSAGE_TERMS_17_4 = "MESSAGE_TERMS_17_4";
        public const string MESSAGE_TERMS_17_4_1 = "MESSAGE_TERMS_17_4_1";
        public const string MESSAGE_TERMS_17_4_2 = "MESSAGE_TERMS_17_4_2";
        public const string MESSAGE_TERMS_17_4_3 = "MESSAGE_TERMS_17_4_3";
        public const string MESSAGE_TERMS_17_5 = "MESSAGE_TERMS_17_5";
        public const string MESSAGE_TERMS_17_6 = "MESSAGE_TERMS_17_6";
        public const string MESSAGE_TERMS_17_6_1 = "MESSAGE_TERMS_17_6_1";
        public const string MESSAGE_TERMS_17_6_1_1 = "MESSAGE_TERMS_17_6_1_1";
        public const string MESSAGE_TERMS_17_6_1_2 = "MESSAGE_TERMS_17_6_1_2";
        public const string MESSAGE_TERMS_17_6_2 = "MESSAGE_TERMS_17_6_2";
        public const string MESSAGE_TERMS_17_7 = "MESSAGE_TERMS_17_7";
        public const string MESSAGE_TERMS_17_7_1 = "MESSAGE_TERMS_17_7_1";
        public const string MESSAGE_TERMS_17_8 = "MESSAGE_TERMS_17_8";
        public const string MESSAGE_TERMS_17_7_2 = "MESSAGE_TERMS_17_7_2";
        public const string MESSAGE_TERMS_17_7_3 = "MESSAGE_TERMS_17_7_3";
        public const string MESSAGE_TERMS_17_7_4 = "MESSAGE_TERMS_17_7_4";
        public const string MESSAGE_TERMS_17_7_5 = "MESSAGE_TERMS_17_7_5";
        public const string MESSAGE_TERMS_17_7_6 = "MESSAGE_TERMS_17_7_6";
        public const string MESSAGE_TERMS_17_7_7 = "MESSAGE_TERMS_17_7_7";

        public const string MESSAGE_TERMS_17_7_8 = "MESSAGE_TERMS_17_7_8";
        public const string MESSAGE_TERMS_17_7_9 = "MESSAGE_TERMS_17_7_9";
        public const string MESSAGE_TERMS_17_9 = "MESSAGE_TERMS_17_9";
        public const string MESSAGE_TERMS_17_10 = "MESSAGE_TERMS_17_10";
        public const string MESSAGE_THEME_PROMOTION_1 = "MESSAGE_THEME_PROMOTION_1";

        public const string MESSAGE_2014_LAST_UPDATED = "MESSAGE_2014_LAST_UPDATED";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_1 = "MESSAGE_VIP_MEMBERSHIP_TERMS_1";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_2 = "MESSAGE_VIP_MEMBERSHIP_TERMS_2";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_3 = "MESSAGE_VIP_MEMBERSHIP_TERMS_3";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_4 = "MESSAGE_VIP_MEMBERSHIP_TERMS_4";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_5 = "MESSAGE_VIP_MEMBERSHIP_TERMS_5";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_6 = "MESSAGE_VIP_MEMBERSHIP_TERMS_6";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_7 = "MESSAGE_VIP_MEMBERSHIP_TERMS_7";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_8 = "MESSAGE_VIP_MEMBERSHIP_TERMS_8";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_9 = "MESSAGE_VIP_MEMBERSHIP_TERMS_9";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_10 = "MESSAGE_VIP_MEMBERSHIP_TERMS_10";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_11 = "MESSAGE_VIP_MEMBERSHIP_TERMS_11";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_12 = "MESSAGE_VIP_MEMBERSHIP_TERMS_12";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_13 = "MESSAGE_VIP_MEMBERSHIP_TERMS_13";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_14 = "MESSAGE_VIP_MEMBERSHIP_TERMS_14";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_15 = "MESSAGE_VIP_MEMBERSHIP_TERMS_15";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_16 = "MESSAGE_VIP_MEMBERSHIP_TERMS_16";
        public const string MESSAGE_VIP_MEMBERSHIP_TERMS_17 = "MESSAGE_VIP_MEMBERSHIP_TERMS_17";

        public const string MESSAGE_GUIDE_BUY_25 = "MESSAGE_GUIDE_BUY_25";
        public const string MESSAGE_FINGER_LTD = "MESSAGE_FINGER_LTD";
        public const string MESSAGE_SELECT_DELIVERY_AREA = "MESSAGE_SELECT_DELIVERY_AREA";
        public const string MESSAGE_CHINA_DISTRIBUTABLE_PROVINCES = "MESSAGE_CHINA_DISTRIBUTABLE_PROVINCES";
        public const string MESSAGE_MAINLAND_CHINA = "MESSAGE_MAINLAND_CHINA";
        public const string MESSAGE_MAINLAND_MACAO = "MESSAGE_MAINLAND_MACAO";
        public const string MESSAGE_MAINLAND_MACAU = "MESSAGE_MAINLAND_MACAU";
        public const string MESSAGE_RANDOM = "MESSAGE_RANDOM";

        public const string MESSAGE_RECVNAME = "MESSAGE_RECVNAME";
        public const string MESSAGE_RECV_PHONE = "MESSAGE_RECV_PHONE";
        public const string MESSAGE_DELIVERY_INFORMATION_2 = "MESSAGE_DELIVERY_INFORMATION_2";
        public const string MESSAGE_DELIVERY_WITHIN = "MESSAGE_DELIVERY_WITHIN";
        public const string MESSAGE_RECIPIENT_ADDRESS = "MESSAGE_RECIPIENT_ADDRESS";
        public const string MACAO_OK_CONVENIENCE_STORE_1 = "MACAO_OK_CONVENIENCE_STORE_1";
        public const string MESSAGE_FILL_IN_CORRECT = "MESSAGE_FILL_IN_CORRECT";
        public const string MESSAGE_POSTAL_CODE = "MESSAGE_POSTAL_CODE";
        public const string MESSAGE_6_DIGITS = "MESSAGE_6_DIGITS";
        public const string MESSAGE_RECIPIENT_ADDRESS_1 = "MESSAGE_RECIPIENT_ADDRESS_1";
        public const string MESSAGE_DOWN_LINE = "MESSAGE_DOWN_LINE";
        public const string MESSAGE_11_CHARACTERS_35_ENGLISH = "MESSAGE_11_CHARACTERS_35_ENGLISH";
        public const string MESSAGE_11_CHARACTERS_35_ENGLISH_2 = "MESSAGE_11_CHARACTERS_35_ENGLISH_2";
        public const string MESSAGE_RECVNAME_2 = "MESSAGE_RECVNAME_2";
        public const string MESSAGE_RECV_PHONE_2 = "MESSAGE_RECV_PHONE_2";
        public const string MESSAGE_8_DIGITS = "MESSAGE_8_DIGITS";
        public const string MESSAGE_11_DIGITS = "MESSAGE_11_DIGITS";
        public const string MESSAGE_6_DIGITS_2 = "MESSAGE_6_DIGITS_2";
        public const string MESSAGE_11_CHARACTERS_35_ENGLISH_3 = "MESSAGE_11_CHARACTERS_35_ENGLISH_3";
        public const string MESSAGE_RECIPIENT_INFORMATION = "MESSAGE_RECIPIENT_INFORMATION";
        public const string MESSAGE_12_CHARACTERS_36_ENGLISH = "MESSAGE_12_CHARACTERS_36_ENGLISH";
        public const string MESSAGE_PHONE_3 = "MESSAGE_PHONE_3";
        public const string MESSAGE_8_DIGITS_2 = "MESSAGE_8_DIGITS_2";
        public const string MESSAGE_DEFAULT_SHIPPING_ADDRESS = "MESSAGE_DEFAULT_SHIPPING_ADDRESS";
        public const string MESSAGE_POINT_DELIVERY_CHARGES_2 = "MESSAGE_POINT_DELIVERY_CHARGES_2";
        public const string MESSAGE_GUANGDONG_PROVINCE = "MESSAGE_GUANGDONG_PROVINCE";
        public const string MESSAGE_OTHER_REGIONS = "MESSAGE_OTHER_REGIONS";
        public const string MESSAGE_150_CM_LESS = "MESSAGE_150_CM_LESS";
        public const string MESSAGE_3_M_LESS = "MESSAGE_3_M_LESS";
        public const string MESSAGE_2_KG_LESS = "MESSAGE_2_KG_LESS";
        public const string MESSAGE_2_M_LESS = "MESSAGE_2_M_LESS";
        public const string MESSAGE_2_KG_MORE = "MESSAGE_2_KG_MORE";
        public const string MESSAGE_5_KG_LESS = "MESSAGE_5_KG_LESS";
        public const string MESSAGE_5_KG_MORE = "MESSAGE_5_KG_MORE";
        public const string MESSAGE_8_KG_LESS = "MESSAGE_8_KG_LESS";
        public const string MESSAGE_8_KG_MORE = "MESSAGE_8_KG_MORE";
        public const string MESSAGE_10_KG_LESS = "MESSAGE_10_KG_LESS";

        public const string MESSAGE_5_6_KG_LESS = "MESSAGE_5_6_KG_LESS";
        public const string MESSAGE_6_8_KG_LESS = "MESSAGE_6_8_KG_LESS";
        public const string MESSAGE_8_9_KG_LESS = "MESSAGE_8_9_KG_LESS";
        public const string MESSAGE_9_10_KG_LESS = "MESSAGE_9_10_KG_LESS";

        public const string MESSAGE_12_CHARACTERS_36_ENGLISH_2 = "MESSAGE_12_CHARACTERS_36_ENGLISH_2";
        public const string MESSAGE_DELIVERY_AREA_2 = "MESSAGE_DELIVERY_AREA_2";
        public const string MESSAGE_DELIVERY_ADDRESS_2 = "MESSAGE_DELIVERY_ADDRESS_2";
        public const string MESSAGE_EXPECTED_DELIVERY_TIME = "MESSAGE_EXPECTED_DELIVERY_TIME";
        public const string MESSAGE_DELIVERY_INFORMATION_3 = "MESSAGE_DELIVERY_INFORMATION_3";
        public const string MESSAGE_LOCAL_DELIVERY_TIME = "MESSAGE_LOCAL_DELIVERY_TIME";
        public const string MESSAGE_DELIVERY_TIME_CHINA = "MESSAGE_DELIVERY_TIME_CHINA";

        public const string MESSAGE_CITY = "MESSAGE_CITY";
        public const string MESSAGE_COUNTIES = "MESSAGE_COUNTIES";
        public const string MESSAGE_PROVINCE = "MESSAGE_PROVINCE";
        public const string MESSAGE_ONLY_HONG_KONG = "MESSAGE_ONLY_HONG_KONG";
        public const string MESSAGE_DIVNOCHINA = "MESSAGE_DIVNOCHINA";
        public const string MESSAGE_DELIVERY_COUNTY = "MESSAGE_DELIVERY_COUNTY";
        public const string MESSAGE_DIVNOCK = "MESSAGE_DIVNOCK";

        //public const string MESSAGE_ONLY_HONG_KONG = "MESSAGE_ONLY_HONG_KONG";
        public const string MESSAGE_HONG_KONG_MAINLAND_CHINA = "MESSAGE_HONG_KONG_MAINLAND_CHINA";
        public const string MESSAGE_HONG_KONG_MAINLAND_CHINA_MC = "MESSAGE_HONG_KONG_MAINLAND_CHINA_MC";
        public const string MESSAGE_HONG_KONG_MAINLAND_MC = "MESSAGE_HONG_KONG_MAINLAND_MC";

        public const string MESSAGE_Des_ONLY_HONG_KONG = "MESSAGE_Des_ONLY_HONG_KONG";
        public const string MESSAGE_Des_HONG_KONG_MAINLAND_CHINA = "MESSAGE_Des_HONG_KONG_MAINLAND_CHINA";
        public const string MESSAGE_Des_HONG_KONG_MAINLAND_CHINA_MC = "MESSAGE_Des_HONG_KONG_MAINLAND_CHINA_MC";
        public const string MESSAGE_Des_HONG_KONG_MAINLAND_MC = "MESSAGE_Des_HONG_KONG_MAINLAND_MC";




        public const string MESSAGE_CLEAR_PRODUCT = "MESSAGE_CLEAR_PRODUCT";
        public const string MESSAGE_LANG = "MESSAGE_LANG";
        public const string MESSAGE_ZHCN = "MESSAGE_ZHCN";
        public const string MESSAGE_ZHHK = "MESSAGE_ZHHK";
        public const string MESSAGE_FAVORITE_PRODUCT = "MESSAGE_FAVORITE_PRODUCT";
        public const string MESSAGE_NO_LOVE_SHOP = "MESSAGE_NO_LOVE_SHOP";

        public const string MESSAGE_BUY_GET = "MESSAGE_BUY_GET";
        public const string MESSAGE_HOME_NEW = "MESSAGE_HOME_NEW";
        public const string MESSAGE_HOME_SALE = "MESSAGE_HOME_SALE";
        public const string MESSAGE_HOME_VIP = "MESSAGE_HOME_VIP";
        public const string MESSAGE_PERSONAL_DATA = "MESSAGE_PERSONAL_DATA";
        public const string MESSAGE_APPLICATION = "MESSAGE_APPLICATION";
        public const string MESSAGE_TOTAL_2 = "MESSAGE_TOTAL_2";
        public const string MESSAGE_NOT_SCORE = "MESSAGE_NOT_SCORE";
        public const string MESSAGE_DESTOPPAGE = "MESSAGE_DESTOPPAGE";
        public const string MESSAGE_POINTINGSHOPPINGLTD_1 = "MESSAGE_POINTINGSHOPPINGLTD_1";
        public const string MESSAGE_BACKORDER = "MESSAGE_BACKORDER";
        public const string MESSAGE_REVISION = "MESSAGE_REVISION";
        public const string MESSAGE_EITHER_2 = "MESSAGE_EITHER_2";
        public const string MESSAGE_SHOP_CARGORY = "MESSAGE_SHOP_CARGORY";
        public const string MESSAGE_CANCEL_LIKE = "MESSAGE_CANCEL_LIKE";
        public const string MESSAGE_BRAND_CARGORY = "MESSAGE_BRAND_CARGORY";
        public const string MESSAGE_PRODUCT_FITTER = "MESSAGE_PRODUCT_FITTER";
        public const string MESSAGE_TOP_BRANDS_2 = "MESSAGE_TOP_BRANDS_2";
        public const string MESSAGE_VIEW_DESIGNER = "MESSAGE_VIEW_DESIGNER";
        public const string MESSAGE_VIEW_ALL_COMMENT = "MESSAGE_VIEW_ALL_COMMENT";
        public const string MESSAGE_FEE_DETAIL = "MESSAGE_FEE_DETAIL";
        public const string MESSAGE_SHOP_CONTENT = "MESSAGE_SHOP_CONTENT";
        public const string MESSAGE_BUY_CONMMENT = "MESSAGE_BUY_CONMMENT";
        public const string MESSAGE_GIFT_LIMIIT = "MESSAGE_GIFT_LIMIIT";
        public const string MESSAGE_GIFT_NOTE = "MESSAGE_GIFT_NOTE";
        public const string MESSAGE_THANKS = "MESSAGE_THANKS";
        public const string MESSAGE_CLICK_CONFIRM = "MESSAGE_CLICK_CONFIRM";
        public const string MESSAGE_IF = "MESSAGE_IF";
        public const string MESSAGE_GIFT_MERCHANDISE_2 = "MESSAGE_GIFT_MERCHANDISE_2";
        public const string MESSAGE_FILITER = "MESSAGE_FILITER";
        public const string MESSAGE_DELIVERY_AREA_3 = "MESSAGE_DELIVERY_AREA_3";
        public const string MESSAGE_7_DIGITS_50 = "MESSAGE_7_DIGITS_50";
        public const string MESSAGE_7_DIGITS = "MESSAGE_7_DIGITS";
        public const string MESSAGE_TERMS_17_6_1_3 = "MESSAGE_TERMS_17_6_1_3";
        public const string MESSAGE_TERMS_18_1 = "MESSAGE_TERMS_18_1";
        public const string MESSAGE_GUIDE_DELIVERY_CN_POST = "MESSAGE_GUIDE_DELIVERY_CN_POST";
        public const string MESSAGE_GUIDE_DELIVERY_CN_TABLE = "MESSAGE_GUIDE_DELIVERY_CN_TABLE";
        public const string MESSAGE_GUIDE_DELIVERY_CN_INFO = "MESSAGE_GUIDE_DELIVERY_CN_INFO";
        public const string MESSAGE_GUIDE_DELIVERY_MC_INFO = "MESSAGE_GUIDE_DELIVERY_MC_INFO";
        public const string MESSAGE_DELIVERY_POINT_DETAILS = "MESSAGE_DELIVERY_POINT_DETAILS";
        public const string MESSAGE_DELIVERY_NOTM3P_TITLE = "MESSAGE_DELIVERY_NOTM3P_TITLE";
        public const string MESSAGE_DELIVERY_NOTM3P_DETAILS = "MESSAGE_DELIVERY_NOTM3P_DETAILS";
        public const string MESSAGE_RETURN_THE_APPLICATION_PROCESS_HK = "MESSAGE_RETURN_THE_APPLICATION_PROCESS_HK";
        public const string MESSAGE_RETURN_THE_APPLICATION_PROCESS_CN = "MESSAGE_RETURN_THE_APPLICATION_PROCESS_CN";
        public const string MESSAGE_RETURN_THE_APPLICATION_PROCESS_MC = "MESSAGE_RETURN_THE_APPLICATION_PROCESS_MC";
        public const string MESSAGE_RETURN_THE_APPLICATION_PROCESS_MC_HTML = "MESSAGE_RETURN_THE_APPLICATION_PROCESS_MC_HTML";
        public const string MESSAGE_GUIDE_PAY_42_1 = "MESSAGE_GUIDE_PAY_42_1";
        public const string MESSAGE_FAQ_ANSWER_21 = "MESSAGE_FAQ_ANSWER_21";
        public const string MESSAGE_FAQ_ANSWER_22 = "MESSAGE_FAQ_ANSWER_22";
        public const string MESSAGE_FAQ_ANSWER_23 = "MESSAGE_FAQ_ANSWER_23";
        public const string MESSAGE_FAQ_CONTENT_21 = "MESSAGE_FAQ_CONTENT_21";
        public const string MESSAGE_FAQ_CONTENT_22 = "MESSAGE_FAQ_CONTENT_22";
        public const string MESSAGE_FAQ_CONTENT_23 = "MESSAGE_FAQ_CONTENT_23";
        public const string MESSAGE_NOT_DELIVERY = "MESSAGE_NOT_DELIVERY";
        public const string MESSAGE_NOT_MC_DELIVERY = "MESSAGE_NOT_MC_DELIVERY";
        public const string MESSAGE_CN_QTY = "MESSAGE_CN_QTY";
        public const string MESSAGE_CN_QTY_2 = "MESSAGE_CN_QTY_2";
        public const string MESSAGE_CARD_OFFERS = "MESSAGE_CARD_OFFERS";
        public const string MESSAGE_DISABLE_DATE = "MESSAGE_DISABLE_DATE";

        public const string MESSAGE_INDIVIDUALITY = "MESSAGE_INDIVIDUALITY";
        public const string MESSAGE_TYPE_LATTICE = "MESSAGE_TYPE_LATTICE";
        public const string MESSAGE_UTILITY_TYPE = "MESSAGE_UTILITY_TYPE";
        public const string MESSAGE_JOKES = "MESSAGE_JOKES";
        public const string MESSAGE_TECHNOFREAK = "MESSAGE_TECHNOFREAK";
        public const string MESSAGE_COMESTIBLE = "MESSAGE_COMESTIBLE";
        public const string MESSAGE_HEALTH_TYPE = "MESSAGE_HEALTH_TYPE";
        public const string MESSAGE_GLADLY = "MESSAGE_GLADLY";
        public const string MESSAGE_LOVELINESS = "MESSAGE_LOVELINESS";

        public const string MESSAGE_RANGE_PRICE = "MESSAGE_RANGE_PRICE";
        public const string MESSAGE_RANGE_PRICE_50 = "MESSAGE_RANGE_PRICE_50";
        public const string MESSAGE_RANGE_PRICE_51_100 = "MESSAGE_RANGE_PRICE_51_100";
        public const string MESSAGE_RANGE_PRICE_101_200 = "MESSAGE_RANGE_PRICE_101_200";
        public const string MESSAGE_RANGE_PRICE_201_500 = "MESSAGE_RANGE_PRICE_201_500";
        public const string MESSAGE_RANGE_PRICE_500 = "MESSAGE_RANGE_PRICE_500";

        public const string MESSAGE_DEVOTION_CATEGORY = "MESSAGE_DEVOTION_CATEGORY";
        public const string MESSAGE_PARENTS = "MESSAGE_PARENTS";
        public const string MESSAGE_MATE = "MESSAGE_MATE";
        public const string MESSAGE_PET = "MESSAGE_PET";
        public const string MESSAGE_PRICE_HIGH_TO_LOW = "MESSAGE_PRICE_HIGH_TO_LOW";


        //推广记录
        public const string MESSAGE_REFERRALRECORD = "MESSAGE_REFERRALRECORD";

        public const string MESSAGE_REFERER_TITLE = "MESSAGE_REFERER_TITLE";

        public const string MESSAGE_REFERER_EMAIL_COL = "MESSAGE_REFERER_EMAIL_COL";
        public const string MESSAGE_REFERER_INVITEDATE_COL = "MESSAGE_REFERER_INVITEDATE_COL";
        public const string MESSAGE_REFERER_JOINDATE_COL = "MESSAGE_REFERER_JOINDATE_COL";
        public const string MESSAGE_REFERER_ENTITLEDATE_COL = "MESSAGE_REFERER_ENTITLEDATE_COL";
        public const string MESSAGE_REFERER_STATUS_COL = "MESSAGE_REFERER_STATUS_COL";

        public const string MESSAGE_INVITE_DATE = "MESSAGE_INVITE_DATE";
        public const string MESSAGE_JOIN_DATE = "MESSAGE_JOIN_DATE";
        public const string MESSAGE_ENTITLE_DATE = "MESSAGE_ENTITLE_DATE";
        public const string MESSAGE_REFERERSTATUS_SENT = "MESSAGE_REFERERSTATUS_SENT";
        public const string MESSAGE_REFERERSTATUS_INPROGRESS = "MESSAGE_REFERERSTATUS_INPROGRESS";
        public const string MESSAGE_REFERERSTATUS_EXPIRED = "MESSAGE_REFERERSTATUS_EXPIRED";
        public const string MESSAGE_REFERERSTATUS_AWARDED = "MESSAGE_REFERERSTATUS_AWARDED";

        public const string REFERRAL_INPROGRESS_COUNT = "REFERRAL_INPROGRESS_COUNT";
        public const string REFERRAL_AWARDED_COUNT = "REFERRAL_AWARDED_COUNT";

        //推广规则说明
        public const string REFERRAL_RULEEXPLAIN_1 = "REFERRAL_RULEEXPLAIN_1";
        public const string REFERRAL_RULEEXPLAIN_2 = "REFERRAL_RULEEXPLAIN_2";
        public const string REFERRAL_RULEEXPLAIN_3 = "REFERRAL_RULEEXPLAIN_3";
        public const string REFERRAL_RULEEXPLAIN_4 = "REFERRAL_RULEEXPLAIN_4";
        public const string REFERRAL_RULEEXPLAIN_5 = "REFERRAL_RULEEXPLAIN_5";
        public const string REFERRAL_RULEEXPLAIN_6 = "REFERRAL_RULEEXPLAIN_6";
        public const string REFERRAL_RULEEXPLAIN_7 = "REFERRAL_RULEEXPLAIN_7";
        public const string REFERRAL_RULEEXPLAIN_8 = "REFERRAL_RULEEXPLAIN_8";
        public const string REFERRAL_RULEEXPLAIN_9 = "REFERRAL_RULEEXPLAIN_9";
        public const string REFERRAL_RULEEXPLAIN_1_0 = "REFERRAL_RULEEXPLAIN_1_0";
        public const string REFERRAL_RULEEXPLAIN_1_1 = "REFERRAL_RULEEXPLAIN_1_1";

        //推荐发送邮件
        public const string REFERRAL_PARAGRAPH_1 = "REFERRAL_PARAGRAPH_1";
        public const string REFERRAL_PARAGRAPH_3 = "REFERRAL_PARAGRAPH_3";
        public const string REFERRAL_PARAGRAPH_5 = "REFERRAL_PARAGRAPH_5";
        public const string REFERRAL_PARAGRAPH_7_1 = "REFERRAL_PARAGRAPH_7_1";
        public const string REFERRAL_PARAGRAPH_12 = "REFERRAL_PARAGRAPH_12";
        public const string REFERRAL_PARAGRAPH_13 = "REFERRAL_PARAGRAPH_13";
        public const string REFERRAL_PARAGRAPH_14 = "REFERRAL_PARAGRAPH_14";
        public const string REFERRAL_PARAGRAPH_15 = "REFERRAL_PARAGRAPH_15";
        public const string REFERRAL_PARAGRAPH_16 = "REFERRAL_PARAGRAPH_16";
        public const string REFERRAL_PARAGRAPH_17 = "REFERRAL_PARAGRAPH_17";
        public const string REFERRAL_PARAGRAPH_18 = "REFERRAL_PARAGRAPH_18";
        public const string REFERRAL_PARAGRAPH_22 = "REFERRAL_PARAGRAPH_22";
        public const string REFERRAL_DEFAULT_MSG = "REFERRAL_DEFAULT_MSG";
        public const string REFFERAL_EXAMPLE_EMAILS = "REFFERAL_EXAMPLE_EMAILS";

        //推荐给朋友
        public const string REFFERAL_REFER_1 = "REFFERAL_REFER_1";
        public const string REFFERAL_REFER_2 = "REFFERAL_REFER_2";
        public const string REFFERAL_REFER_3 = "REFFERAL_REFER_3";
        public const string REFFERAL_REFER_4 = "REFFERAL_REFER_4";
        public const string REFFERAL_REFER_5 = "REFFERAL_REFER_5";
        public const string REFFERAL_REFER_6 = "REFFERAL_REFER_6";
        public const string REFFERAL_REFER_7 = "REFFERAL_REFER_7";
        public const string REFFERAL_REFER_8 = "REFFERAL_REFER_8";
        public const string REFFERAL_REFER_9 = "REFFERAL_REFER_9";
        public const string REFFERAL_REFER_10 = "REFFERAL_REFER_10";
        public const string REFFERAL_REFER_11 = "REFFERAL_REFER_11";
        public const string REFFERAL_REFER_15 = "REFFERAL_REFER_15";
        public const string REFFERAL_REFER_16 = "REFFERAL_REFER_16";
        public const string MESSAGE_REFER_EARN_Footer = "MESSAGE_REFER_EARN_Footer";
        /// <summary>
        /// 请先选择提货日期
        /// </summary>
        public const string MESSAGE_FIRST_GET_DATE = "MESSAGE_FIRST_GET_DATE";
        /// <summary>
        /// 如5分钟后仍未收到验证码，请按「重新发出验证码」并停留于此版面，及联络客户服务主任以取得验证码。请按右下角即时通话，或致电热线2991-6688，亦可以电邮cs@fingershopping.com联络客户服务主任。
        /// </summary>
        public const string MESSAGE_PHONE_VERIFICATION = "MESSAGE_PHONE_VERIFICATION";
        /// <summary>
        /// 秒后可重发信息
        /// </summary>
        public const string MESSAGE_PHONE_VERIFICATION_CHECK = "MESSAGE_PHONE_VERIFICATION_CHECK";
        /// <summary>
        /// 已选
        /// </summary>
        public const string MESSAGE_DATA_SELECTED = "MESSAGE_DATA_SELECTED";
        /// <summary>
        /// 订单一经确认，即代表您已知悉：订单确认后将不能取消;配送过程中或可能产生关税问题，关税由客户承担，配送时间亦会有所延迟;详情请查阅网站「中国内地送货方法及通知」
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-05-15 15:24:49</Date>
        public const string MESSAGE_CN_DELIVERY_NOTIFY = "MESSAGE_CN_DELIVERY_NOTIFY";
        /// <summary>
        /// 訂單確認後將不能取消;<br />配送至澳門的訂單如因顧客個人因素而未能如期取貨，第三方物流將重新配送逾期未取之商品回港，已付之運費將不獲退回，我們亦會於取消訂單前從已付款項中扣除回港相關的配送費用，詳情請查閱網站「<a href="customer_guide_delivery.aspx#answer5" target="_blank" style="color:#999900;text-decoration: underline;">澳門送貨方法及通知</a>」
        /// </summary>
        /// <Author>Hongtao</Author>
        /// <Date>2015-10-23 09:28:00</Date>
        public const string MESSAGE_MC_DELIVERY_NOTIFY = "MESSAGE_MC_DELIVERY_NOTIFY";
        /// <summary>
        /// 其他浏览器正在登录你的账户，请重新检查购物车所买货品
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-06-12 11:27:57</Date>
        public const string MESSAGE_CHECK_CART_ITEM_BY_OTHER = "MESSAGE_CHECK_CART_ITEM_BY_OTHER";
        /// <summary>
        /// 请选择送货方式
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-06-12 11:38:55</Date>
        public const string MESSAGE_DELIVERY_PAYMENT_WAY = "MESSAGE_DELIVERY_PAYMENT_WAY";
        /// <summary>
        /// 推荐细则
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-10 15:59:27</Date>
        public const string MESSAGE_REFER_RULE = "MESSAGE_REFER_RULE";

        /// <summary>
        /// 推荐赚奖赏
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-10 17:50:20</Date>
        public const string MESSAGE_REFER_EARN = "MESSAGE_REFER_EARN";

        /// <summary>
        /// 条款及细则
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-16 15:58:46</Date>
        public const string MESSAGE_RULE = "MESSAGE_RULE";

        /// <summary>
        /// 已成功传送邀请，您可到「我的推荐记录」查看相关推荐记录。
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-21 12:33:27</Date>
        public const string MESSAGE_REFER_SEND_SUCCESS = "MESSAGE_REFER_SEND_SUCCESS";

        /// <summary>
        /// 传送邀请失败，请重试。
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-21 13:46:29</Date>
        public const string MESSAGE_REFER_SEND_FAILED = "MESSAGE_REFER_SEND_FAILED";

        /// <summary>
        /// 下列电邮地址已被用作登记成为会员，系统将不会传送邀请。
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-21 15:23:26</Date>
        public const string MESSAGE_ERROR_MEMBER_MAILS = "MESSAGE_ERROR_MEMBER_MAILS";

        /// <summary>
        /// 您曾於3個月內傳送邀請至下列電郵地址，系統暫不會再傳送邀請。
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-21 15:25:38</Date>
        public const string MESSAGE_ERROR_SEND_MAILS = "MESSAGE_ERROR_SEND_MAILS";

        /// <summary>
        /// 下列電郵地址的格式錯誤，系統將不會傳送邀請。
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-21 15:25:38</Date>
        public const string MESSAGE_ERROR_MAILS = "MESSAGE_ERROR_MAILS";

        /// <summary>
        /// 写给朋友的话字数限于200中文字内
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-24 17:12:14</Date>
        public const string REFFERAL_REFER_12 = "REFFERAL_REFER_12";
        /// <summary>
        ///暫時沒有分享記錄。
        /// </summary>
        /// <Author>Justin.Liu</Author>
        /// <Date>2015-07-24 17:12:14</Date>
        public const string REFFERAL_REFER_13 = "REFFERAL_REFER_13";
        /// <summary>
        ///分享说明
        /// </summary>
        /// <Author>Justin.Liu</Author>
        /// <Date>2015-07-24 17:12:14</Date>
        public const string REFFERAL_REFER_14 = "REFFERAL_REFER_14";
        /// <summary>
        /// OG 标题
        /// </summary>
        public const string MESSAGE_OG_TITLE = "MESSAGE_OG_TITLE";
        /// <summary>
        /// OG 描述
        /// </summary>
        public const string MESSAGE_OG_DES = "MESSAGE_OG_DES";

        public const string MESSAGE_FREEGIFT_HINT = "MESSAGE_FREEGIFT_HINT";
        public const string MESSAGE_REDEMPTION_CODE_COUNT = "MESSAGE_REDEMPTION_CODE_COUNT";
        #endregion

        #region Refer

        /// <summary>
        /// 写给朋友的话不多于100个中文字200个英文字
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-29 17:58:05</Date>
        public const string REFFERAL_REFER_100_200 = "REFFERAL_REFER_100_200";

        /// <summary>
        /// 推荐给朋友的电邮不多于300个英文字
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-29 18:00:26</Date>
        public const string REFFERAL_REFER_300 = "REFFERAL_REFER_300";

        /// <summary>
        /// 推荐给朋友的电邮不多于15个
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-07-29 18:14:01</Date>
        public const string REFFERAL_REFER_EMAILS_15 = "REFFERAL_REFER_EMAILS_15";

        /// <summary>
        /// 系统会传送邀请：
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-08-07 12:25:41</Date>
        public const string MESSAGE_REFER_SEND = "MESSAGE_REFER_SEND";

        /// <summary>
        /// 微信
        /// </summary>
        public const string REFFERAL_WEIXIN_TITLE = "REFFERAL_WEIXIN_TITLE";
        public const string REFFERAL_WEIXIN_DES = "REFFERAL_WEIXIN_DES";

        public const string MESSAGE_CN_CART_NOTIFY = "MESSAGE_CN_CART_NOTIFY";
        public const string MESSAGE_MC_CART_NOTIFY = "MESSAGE_MC_CART_NOTIFY";
        public const string MESSAGE_MC_CART_WARNING = "MESSAGE_MC_CART_WARNING";

        /// <summary>
        /// 必须填写真实的收件人姓名
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-08-12 16:08:23</Date>
        public const string MESSAGE_REAL_NEMA_REQUIRED = "MESSAGE_REAL_NEMA_REQUIRED";

        /// <summary>
        /// 未发货
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-08-12 16:36:22</Date>
        public const string MESSAGE_NO_DELIVERY_2 = "MESSAGE_NO_DELIVERY_2";

        /// <summary>
        /// 追踪物流
        /// </summary>
        /// <Author>Charlie</Author>
        /// <Date>2015-08-12 16:38:01</Date>
        public const string MESSAGE_TRACKING_LOGISTICS = "MESSAGE_TRACKING_LOGISTICS";

        public const string MESSAGE_CN_TOTAL_NOTE = "MESSAGE_CN_TOTAL_NOTE";
        public const string MESSAGE_CN_TOTAL_NOTE_TITLE = "MESSAGE_CN_TOTAL_NOTE_TITLE";
        public const string MESSAGE_CN_TOTAL_NOTE_INFO = "MESSAGE_CN_TOTAL_NOTE_INFO";
        public const string MESSAGE_MC_TOTAL_NOTE = "MESSAGE_MC_TOTAL_NOTE";
        public const string MESSAGE_MC_TOTAL_NOTE_TITLE = "MESSAGE_MC_TOTAL_NOTE_TITLE";
        public const string MESSAGE_MC_TOTAL_NOTE_INFO = "MESSAGE_MC_TOTAL_NOTE_INFO";

        public const string REFERRAL_SUBSCRIBE_TO_ENEWS = "REFERRAL_SUBSCRIBE_TO_ENEWS";
        public const string REFERRAL_CONGRATULATIONS = "REFERRAL_CONGRATULATIONS";

        /*edit by hongtao 2015.10.08.0003 begin*/
        public const string LUCKYDRAW_LOGIN = "LUCKYDRAW_LOGIN";
        public const string LUCKYDRAW_REGISTER = "LUCKYDRAW_REGISTER";
        public const string LUCKYDRAW_LoggedIn_1 = "LUCKYDRAW_LoggedIn_1";
        public const string LUCKYDRAW_LoggedIn_2 = "LUCKYDRAW_LoggedIn_2";
        public const string LUCKYDRAW_MSG1 = "LUCKYDRAW_MSG1";
        public const string LUCKYDRAW_MSG2 = "LUCKYDRAW_MSG2";
        public const string LUCKYDRAW_MSG3 = "LUCKYDRAW_MSG3";
        public const string LUCKYDRAW_MSG4 = "LUCKYDRAW_MSG4";
        public const string LUCKYDRAW_MSG5 = "LUCKYDRAW_MSG5";
        public const string LUCKYDRAW_MSG6 = "LUCKYDRAW_MSG6";
        public const string LUCKYDRAW_MSG7 = "LUCKYDRAW_MSG7";
        public const string LUCKYDRAW_MSG8 = "LUCKYDRAW_MSG8";
        public const string LUCKYDRAW_MSG9 = "LUCKYDRAW_MSG9";
        public const string LUCKYDRAW_MSG10 = "LUCKYDRAW_MSG10";
        public const string LUCKYDRAW_MESSAGE_ENEWS = "LUCKYDRAW_MESSAGE_ENEWS";
        public const string LUCKYDRAW_REFERRAL_TO_ENEWS = "LUCKYDRAW_REFERRAL_TO_ENEWS";
        public const string LUCKYDRAW_SUBSCRIBE_TO_ENEWS = "LUCKYDRAW_SUBSCRIBE_TO_ENEWS";
        public const string FREE_GIFTS_REDEMPTION_PAGE1 = "FREE_GIFTS_REDEMPTION_PAGE1";
        public const string FREE_GIFTS_REDEMPTION_PAGE2 = "FREE_GIFTS_REDEMPTION_PAGE2";
        public const string FREE_GIFTS_REDEMPTION_PAGE3 = "FREE_GIFTS_REDEMPTION_PAGE3";
        public const string FREE_GIFTS_REDEMPTION_PAGE4 = "FREE_GIFTS_REDEMPTION_PAGE4";
        public const string FREE_GIFTS_REDEMPTION_PAGE5 = "FREE_GIFTS_REDEMPTION_PAGE5";
        public const string FREE_GIFTS_REDEMPTION_PAGE6 = "FREE_GIFTS_REDEMPTION_PAGE6";
        /*edit by hongtao 2015.10.08.0003 end*/


        #endregion

        /// <summary>
        /// 您可能喜欢的商品
        /// </summary>
        public const string EMARSYS_YOUMAYLIKE = "EMARSYS_YOUMAYLIKE";
        /// <summary>
        /// 相關商品推薦
        /// </summary>
        public const string EMARSYS_RECOMMEND = "EMARSYS_RECOMMEND";
        /// <summary>
        /// 其他人同時購買了以下商品
        /// </summary>
        public const string EMARSYS_PURCHASE = "EMARSYS_PURCHASE";

        public const string MESSAGE_PLEASE_EMAIL_CONTACT = "MESSAGE_PLEASE_EMAIL_CONTACT";

        public const string MESSAGE_HOME_TITLE = "MESSAGE_HOME_TITLE";

        public const string MESSAGE_SHOW_TITLE = "MESSAGE_SHOW_TITLE";
        public const string MESSAGE_SHOPPING_ADDRESS = "MESSAGE_SHOPPING_ADDRESS";
        public const string MESSAGE_ORDER_HISTORY = "MESSAGE_ORDER_HISTORY";
        public const string MESSAGE_MY_ELECTRONIC = "MESSAGE_MY_ELECTRONIC";
        public const string MESSAGE_MYPROFILE = "MESSAGE_MYPROFILE";
        public const string MESSAGE_STORE_REVIEWS = "MESSAGE_STORE_REVIEWS";
        public const string MESSAGE_GIFT_CARD_SHOW = "MESSAGE_GIFT_CARD_SHOW";
        public const string MESSAGE_GIFT_RANDOM = "MESSAGE_GIFT_RANDOM";
        public const string MESSAGE_UPDATE_DELIVERY = "MESSAGE_UPDATE_DELIVERY";
        public const string MESSAGE_UPDATE_STORE = "MESSAGE_UPDATE_STORE";
        public const string MESSAGE_ORDER_CONFIRMATION = "MESSAGE_ORDER_CONFIRMATION";
        public const string MESSAGE_PRICE_CASH = "MESSAGE_PRICE_CASH";
        public const string MESSAGE_RECOMMEND = "MESSAGE_RECOMMEND";
        public const string MESSAGE_RECOMMEND_TERMS = "MESSAGE_RECOMMEND_TERMS";
        public const string MESSAGE_RECOVERY_RECORD = "MESSAGE_RECOVERY_RECORD";
        public const string MESSAGE_ACCOUNT = "MESSAGE_ACCOUNT";
        public const string MESSAGE_POLICY_REGULATIONS = "MESSAGE_POLICY_REGULATIONS";
        public const string MESSAGE_METHOD = "MESSAGE_METHOD";
        public const string MESSAGE_PLEASE_CONTACT = "MESSAGE_PLEASE_CONTACT";
        public const string MESSAGE_VIP = "MESSAGE_VIP";
        public const string MESSAGE_PRIVACY_POLICY = "MESSAGE_PRIVACY_POLICY";
        public const string MESSAGE_TERMSOFUSE_C = "MESSAGE_TERMSOFUSE_C";
        public const string MESSAGE_TERMSOFUSE_E = "MESSAGE_TERMSOFUSE_E";
        public const string MESSAGE_EXIST_EMAILANDPHONE_NO = "MESSAGE_EXIST_EMAILANDPHONE_NO";
        public const string MESSAGE_VERIFY_EMAILANDPHONE_NO = "MESSAGE_VERIFY_EMAILANDPHONE_NO";
        public const string MESSAGE_NOT_VERIFY_PHONE_NO = "MESSAGE_NOT_VERIFY_PHONE_NO";
        public const string MESSAGE_MY_HOME = "MESSAGE_MY_HOME";
        public const string MESSAGE_MY_STORE = "MESSAGE_MY_STORE";
        public const string MESSAGE_SHOW_COUPON_REDEEM = "MESSAGE_SHOW_COUPON_REDEEM";

        public const string MESSAGE_SHOW_NO_COUPON_LIMITED = "MESSAGE_SHOW_NO_COUPON_LIMITED";
        public const string MESSAGE_SHOW_NO_COUPON_FIRSTLIMITED = "MESSAGE_SHOW_NO_COUPON_FIRSTLIMITED";

        public const string MESSAGE_TOTAL_STORE_REVIEWS = "MESSAGE_TOTAL_STORE_REVIEWS";
        public const string MESSAGE_STORE_LIKE = "MESSAGE_STORE_LIKE";
        public const string MESSAGE_NOT_FIND_BRAND = "MESSAGE_NOT_FIND_BRAND";

        public const string MESSAGE_SHOW_LOGIN_CODE = "MESSAGE_SHOW_LOGIN_CODE";

        public const string MESSAGE_BTB_SHOW_INFO = "MESSAGE_BTB_SHOW_INFO";
        public const string MESSAGE_ValidVipDay_Coupon = "MESSAGE_ValidVipDay_Coupon";
        public const string MESSAGE_EDITORSCHOICE = "MESSAGE_EDITORSCHOICE";
        public const string MESSAGE_SHOPPING_MC = "MESSAGE_SHOPPING_MC";
        public const string MESSAGE_OUT_OF_STOCK = "MESSAGE_OUT_OF_STOCK";

        public const string MESSAGE_RECOMMENDFRIENDS = "MESSAGE_RECOMMENDFRIENDS";
        public const string MESSAGE_HEADER_ADVANTAGE1 = "MESSAGE_HEADER_ADVANTAGE1";
        public const string MESSAGE_HEADER_ADVANTAGE2 = "MESSAGE_HEADER_ADVANTAGE2";
        public const string MESSAGE_HEADER_ADVANTAGE3 = "MESSAGE_HEADER_ADVANTAGE3";
        public const string MACAO_OK_CONVENIENCE_STORE = "MACAO_OK_CONVENIENCE_STORE";
        public const string MESSAGE_GUIDE_DELIVERY_MCK = "MESSAGE_GUIDE_DELIVERY_MCK";
        public const string MESSAGE_GUIDE_DELIVERY_MCK_1 = "MESSAGE_GUIDE_DELIVERY_MCK_1";
        public const string MESSAGE_GUIDE_DELIVERY_MCK_2 = "MESSAGE_GUIDE_DELIVERY_MCK_2";
        public const string MESSAGE_GUIDE_DELIVERY_MCK_3 = "MESSAGE_GUIDE_DELIVERY_MCK_3";
        public const string MESSAGE_GUIDE_DELIVERY_MCK_4 = "MESSAGE_GUIDE_DELIVERY_MCK_4";
        public const string MESSAGE_GUIDE_DELIVERY_MCK_5 = "MESSAGE_GUIDE_DELIVERY_MCK_5";
        public const string MESSAGE_HK_PICKUP = "MESSAGE_HK_PICKUP";
        public const string MESSAGE_MCK_PICKUP = "MESSAGE_MCK_PICKUP";

        public const string MESSAGE_SAMBO = "MESSAGE_SAMBO";
        public const string MESSAGE_PERFUME = "MESSAGE_PERFUME";
        public const string MESSAGE_CHRISTMAS = "MESSAGE_CHRISTMAS";
        public const string MESSAGE_TASTE = "MESSAGE_TASTE";
        public const string MESSAGE_GIFTBOX = "MESSAGE_GIFTBOX";
        public const string MESSAGE_CHRISTMAS_GIFT_GIRL = "MESSAGE_CHRISTMAS_GIFT_GIRL";
        public const string MESSAGE_CHRISTMAS_GIFT_BOY = "MESSAGE_CHRISTMAS_GIFT_BOY";
        public const string MESSAGE_KEYWORD = "MESSAGE_KEYWORD";
        public const string MESSAGE_WINTER = "MESSAGE_WINTER";
        public const string MESSAGE_FASHION = "MESSAGE_FASHION";
        public const string MESSAGE_PARTY_TIME = "MESSAGE_PARTY_TIME";
        public const string MESSAGE_SELFIE = "MESSAGE_SELFIE";

        public const string MESSAGE_HOT_SEARCH = "MESSAGE_HOT_SEARCH";
        public const string MESSAGE_RESET_FILTER = "MESSAGE_RESET_FILTER";
        public const string MESSAGE_SCREENING_CONDITIONS = "MESSAGE_SCREENING_CONDITIONS";

        public const string MESSAGE_NOT_SET_FILTER = "MESSAGE_NOT_SET_FILTER";
        public const string MESSAGE_DATE_FR_TO = "MESSAGE_DATE_FR_TO";

        public const string MESSAGE_COUPON_DATA = "MESSAGE_COUPON_DATA";
        public const string MESSAGE_COMMODITY_BARCODE = "MESSAGE_COMMODITY_BARCODE";
        public const string MESSAGE_BARCODE = "MESSAGE_BARCODE";

        public const string MESSAGE_COUPON_SHOW_1 = "MESSAGE_COUPON_SHOW_1";
        public const string MESSAGE_COUPON_SHOW_2 = "MESSAGE_COUPON_SHOW_2";
        public const string MESSAGE_COUPON_SHOW_3 = "MESSAGE_COUPON_SHOW_3";
        public const string MESSAGE_COUPON_SHOW_4 = "MESSAGE_COUPON_SHOW_4";
        public const string MESSAGE_COUPON_SHOW_5 = "MESSAGE_COUPON_SHOW_5";
        public const string MESSAGE_COUPON_SHOW_6 = "MESSAGE_COUPON_SHOW_6";
        public const string MESSAGE_COUPON_SHOW_7 = "MESSAGE_COUPON_SHOW_7";
        public const string MESSAGE_COUPON_SHOW_8 = "MESSAGE_COUPON_SHOW_8";
        public const string MESSAGE_COUPON_SHOW_9 = "MESSAGE_COUPON_SHOW_9";
        public const string MESSAGE_COUPON_SHOW_10 = "MESSAGE_COUPON_SHOW_10";
        public const string MESSAGE_COUPON_SHOW_11 = "MESSAGE_COUPON_SHOW_11";
        public const string MESSAGE_COUPON_SHOW_12 = "MESSAGE_COUPON_SHOW_12";
        public const string MESSAGE_COUPON_SHOW_13 = "MESSAGE_COUPON_SHOW_13";
        public const string MESSAGE_COUPON_SHOW_14 = "MESSAGE_COUPON_SHOW_14";
        public const string MESSAGE_COUPON_SHOW_15 = "MESSAGE_COUPON_SHOW_15";
        public const string MESSAGE_COUPON_SHOW_16 = "MESSAGE_COUPON_SHOW_16";
        public const string MESSAGE_COUPON_SHOW_17 = "MESSAGE_COUPON_SHOW_17";
        public const string MESSAGE_COUPON_SHOW_18 = "MESSAGE_COUPON_SHOW_18";
        public const string MESSAGE_COUPON_SHOW_19 = "MESSAGE_COUPON_SHOW_19";
        public const string MESSAGE_SHOW_OFFLINE_1 = "MESSAGE_SHOW_OFFLINE_1";
        public const string MESSAGE_SHOW_OFFLINE_2 = "MESSAGE_SHOW_OFFLINE_2";
        public const string MESSAGE_SHOW_OFFLINE_3 = "MESSAGE_SHOW_OFFLINE_3";
        public const string MESSAGE_SHOW_OFFLINE_4 = "MESSAGE_SHOW_OFFLINE_4";
        public const string MESSAGE_SHOW_OFFLINE_5 = "MESSAGE_SHOW_OFFLINE_5";
        public const string MESSAGE_SHOW_OFFLINE_6 = "MESSAGE_SHOW_OFFLINE_6";
        public const string MESSAGE_SHOW_OFFLINE_7 = "MESSAGE_SHOW_OFFLINE_7";

        public const string MESSAGE_SHOW_M3P = "MESSAGE_SHOW_M3P";

        public const string MESSAGE_POSITIVE_CARGO_GUARANTEE = "MESSAGE_POSITIVE_CARGO_GUARANTEE";
        public const string MESSAGE_POSITIVE_CARGO_GUARANTEE_SHOW = "MESSAGE_POSITIVE_CARGO_GUARANTEE_SHOW";
        public const string MESSAGE_SHOP_INVALID = "MESSAGE_SHOP_INVALID";
        public const string MESSAGE_ORDER_NOT_COUPON = "MESSAGE_ORDER_NOT_COUPON";
        public const string GLOBAL_GOTO_PC = "GLOBAL_GOTO_PC";
        public const string GLOBAL_GOTO_M = "GLOBAL_GOTO_M";

        public const string MESSAGE_SHOW_NUMBER_OF_PURCHASE = "MESSAGE_SHOW_NUMBER_OF_PURCHASE";
        public const string MESSAGE_COUPON_EXPIRED = "MESSAGE_COUPON_EXPIRED";

        public const string MESSAGE_ORDER_CAVEAT_INFO = "MESSAGE_ORDER_CAVEAT_INFO";

        public const string MESSAGE_REDEMPTION_DATE = "MESSAGE_REDEMPTION_DATE";
        public const string MESSAGE_ACTIVITY_OVER = "MESSAGE_ACTIVITY_OVER";

        public const string MESSAGE_SHOW_DATA = "MESSAGE_SHOW_DATA";
        public const string MESSAGE_SHOW_PAYMENT_METHOD = "MESSAGE_SHOW_PAYMENT_METHOD";

        public const string MESSAGE_Redemption_Of_The_Site = "MESSAGE_Redemption_Of_The_Site";
        public const string MESSAGE_Redemption_Of_The_Number = "MESSAGE_Redemption_Of_The_Number";

        public const string MESSAGE_LOTTERY_ALL = "MESSAGE_LOTTERY_ALL";

        public const string MESSAGE_SHOW_DESC = "MESSAGE_SHOW_DESC";
    }
}
