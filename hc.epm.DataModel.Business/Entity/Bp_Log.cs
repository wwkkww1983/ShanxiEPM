//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2018-07-26 18:03:58
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Basic
{
    ///<summary>
    ///Bp_Log: 基础平台数据接收日志
    ///</summary>
    public class Bp_Log
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        ///<summary>
        /// 流水号
        ///</summary>
        public string SerialNo { get; set; }

        ///<summary>
        ///接口名称
        ///</summary>
        public string InterFaceName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        ///<summary>
        ///日志类型
        ///</summary>
        public string LogType { get; set; }

        ///<summary>
        ///日志描述
        ///</summary>
        public string Describe { get; set; }

        ///<summary>
        ///状态
        ///</summary>
        public int State { get; set; }

        ///<summary>
        ///响应时间
        ///</summary>
        public DateTime? ResponseTime { get; set; }

    }
}
