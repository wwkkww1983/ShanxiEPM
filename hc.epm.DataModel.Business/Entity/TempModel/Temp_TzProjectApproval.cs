//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2019-09-02 11:49:58
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
using System.ComponentModel.DataAnnotations;

namespace hc.epm.DataModel.Business
{ 
	///<summary>
	///Temp_TzProjectApproval:
	///</summary>
	 public  class  Temp_TzProjectApproval
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
		public string ApplyId { get; set; }

		///<summary>
		///
		///</summary>
		public string ApplyName { get; set; }

		///<summary>
		///
		///</summary>
		public string ApplyInvest { get; set; }

		///<summary>
		///
		///</summary>
		public string ApplyWhole { get; set; }

		///<summary>
		///
		///</summary>
		public string ApplyProject { get; set; }

		///<summary>
		///
		///</summary>
		public string ApplyTime { get; set; }

		///<summary>
		///
		///</summary>
		public string LimitTypeType { get; set; }

		///<summary>
		///
		///</summary>
		public string LimitTypeName { get; set; }

		///<summary>
		///
		///</summary>
		public string Drafter { get; set; }

		///<summary>
		///
		///</summary>
		public string SignPeople { get; set; }

		///<summary>
		///
		///</summary>
		public string Signer { get; set; }

		///<summary>
		///
		///</summary>
		public string Titanic { get; set; }

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
		public string StateType { get; set; }

		///<summary>
		///
		///</summary>
		public string StateName { get; set; }

		///<summary>
		///
		///</summary>
		public int? State { get; set; }

        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

