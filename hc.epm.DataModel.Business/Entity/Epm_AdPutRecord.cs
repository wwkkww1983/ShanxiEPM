//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2018-05-14 14:26:50
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Epm_AdPutRecord:广告投放记录表
	///</summary>
	 public  class  Epm_AdPutRecord:BaseBusiness
	{ 
		///<summary>
		///广告位Id
		///</summary>
		public long? AdTargetId { get; set; }

		///<summary>
		///广告位编码
		///</summary>
		public string AdTargetNum { get; set; }

		///<summary>
		///广告位名称
		///</summary>
		public string AdTargetName { get; set; }

		///<summary>
		///广告名称
		///</summary>
		public string AdName { get; set; }

		///<summary>
		///价格（元）
		///</summary>
		public decimal? Price { get; set; }

		///<summary>
		///广告类型Key
		///</summary>
		public string AdTypeNo { get; set; }

		///<summary>
		///广告类型Value
		///</summary>
		public string AdTypeName { get; set; }

		///<summary>
		///开始时间
		///</summary>
		public DateTime? StartTime { get; set; }

		///<summary>
		///结束时间
		///</summary>
		public DateTime? EndTime { get; set; }

		///<summary>
		///图片链接
		///</summary>
		public string AdUrl { get; set; }

		///<summary>
		///排序
		///</summary>
		public int? Sort { get; set; }

        ///<summary>
        ///状态（1禁用 0启用）
        ///</summary>
        public int? State { get; set; }

		///<summary>
		///备注
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///创建单位Id
		///</summary>
		public long? CrtCompanyId { get; set; }

		///<summary>
		///创建单位Name
		///</summary>
		public string CrtCompanyName { get; set; }

	}
}

