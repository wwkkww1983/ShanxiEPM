//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由华春网络代码生成工具生成
// version 1.0
// author hanshiwei 2017.07.24
// auto create time:2019-08-23 16:47:22
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using hc.epm.DataModel.BaseCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace hc.epm.DataModel.Business
{
    ///<summary>
    ///Epm_TzProjectApproval:项目批复请示
    ///</summary>
    public class Epm_TzProjectApproval : BaseBusiness
    {
        public Epm_TzProjectApproval()
        {
            TzAttachs = new List<Epm_TzAttachs>();
        }

        ///<summary>
        ///
        ///</summary>
        public long? DataId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public long? ProjectId { get; set; }

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
        public DateTime? ApplyTime { get; set; }

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

        [NotMapped]
        public List<Epm_TzAttachs> TzAttachs { get; set; }

    }
}

