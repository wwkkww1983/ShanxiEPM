//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2019-09-02 11:49:59
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
using System.ComponentModel.DataAnnotations;

namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Temp_TzSecondTalkAudit:
	///</summary>
	 public  class  Temp_TzSecondTalkAudit
	{
        [Key]
        public long Id { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DataId { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectId { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectName { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectCodeInvest { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectCodeWhole { get; set; }

		///<summary>
		///
		///</summary>
		public string ProjectCodeProject { get; set; }

		///<summary>
		///
		///</summary>
		public string Approvar { get; set; }

		///<summary>
		///
		///</summary>
		public string ApprovarId { get; set; }

		///<summary>
		///
		///</summary>
		public string ApprovarInvest { get; set; }

		///<summary>
		///
		///</summary>
		public string ApprovarWhole { get; set; }

		///<summary>
		///
		///</summary>
		public string ApprovarProject { get; set; }

		///<summary>
		///
		///</summary>
		public string SecondWillType { get; set; }

		///<summary>
		///
		///</summary>
		public string SecondWillName { get; set; }

		///<summary>
		///
		///</summary>
		public string Remark { get; set; }

		///<summary>
		///
		///</summary>
		public string OperationTypeType { get; set; }

		///<summary>
		///
		///</summary>
		public string OperationTypeName { get; set; }

		///<summary>
		///
		///</summary>
		public string State_Type { get; set; }

		///<summary>
		///
		///</summary>
		public string State_Name { get; set; }

		///<summary>
		///
		///</summary>
		public int? State { get; set; }

        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

