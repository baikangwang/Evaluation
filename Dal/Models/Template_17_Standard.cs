using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 计算机软件奖申报模板
    /// </summary>
    [Serializable]
    public class Template_17_Standard : TemplateBase
    {
        /// <summary>
        /// 标准（标准设计）项目—基础信息
        /// </summary>
        public Template_1701 part_01 { get; set; }

        /// <summary>
        /// 标准（标准设计）项目—项目特点
        /// </summary>
        public Template_1702 part_02 { get; set; }
    }

    /// <summary>
    /// 标准（标准设计）项目—基础信息
    /// </summary>
    [Serializable]
    public class Template_1701 : TemplateBase
    {
        /// <summary>
        /// 标准（标准设计）名称  1701001
        /// </summary>
        public string StandardName { get; set; }

        /// <summary>
        /// 标准（标准设计）名称  1701001 数据类别
        /// </summary>
        public string RecordTypeStandardName { get; set; }

        /// <summary>
        /// 标准（标准设计）名称  1701001 是否必填
        /// </summary>
        public bool? IsRequiredStandardName { get; set; }

        /// <summary>
        /// 标准（标准设计）名称  1701001 是否公开
        /// </summary>
        public bool? IsPublicStandardName { get; set; }
        /// <summary>
        /// 标准（标准设计）编号  1701002
        /// </summary>
        public string StandardCode { get; set; }

        /// <summary>
        /// 标准（标准设计）编号  1701002 数据类别
        /// </summary>
        public string RecordTypeStandardCode { get; set; }

        /// <summary>
        /// 标准（标准设计）编号  1701002 是否必填
        /// </summary>
        public bool? IsRequiredStandardCode { get; set; }

        /// <summary>
        /// 标准（标准设计）编号  1701002 是否公开
        /// </summary>
        public bool? IsPublicStandardCode { get; set; }
        /// <summary>
        /// 主编单位  1701003
        /// </summary>
        public string ChiefEditorUnit { get; set; }

        /// <summary>
        /// 主编单位  1701003 数据类别
        /// </summary>
        public string RecordTypeChiefEditorUnit { get; set; }

        /// <summary>
        /// 主编单位  1701003 是否必填
        /// </summary>
        public bool? IsRequiredChiefEditorUnit { get; set; }

        /// <summary>
        /// 主编单位  1701003 是否公开
        /// </summary>
        public bool? IsPublicChiefEditorUnit { get; set; }
        /// <summary>
        /// 参编单位1  1701004
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 参编单位1  1701004 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 参编单位1  1701004 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 参编单位1  1701004 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 承担工作1  1701005
        /// </summary>
        public string UndertakeWork1 { get; set; }

        /// <summary>
        /// 承担工作1  1701005 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork1 { get; set; }

        /// <summary>
        /// 承担工作1  1701005 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork1 { get; set; }

        /// <summary>
        /// 承担工作1  1701005 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork1 { get; set; }
        /// <summary>
        /// 参编单位2  1701006
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 参编单位2  1701006 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 参编单位2  1701006 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 参编单位2  1701006 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 承担工作2  1701007
        /// </summary>
        public string UndertakeWork2 { get; set; }

        /// <summary>
        /// 承担工作2  1701007 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork2 { get; set; }

        /// <summary>
        /// 承担工作2  1701007 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork2 { get; set; }

        /// <summary>
        /// 承担工作2  1701007 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork2 { get; set; }
        /// <summary>
        /// 参编单位3  1701008
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 参编单位3  1701008 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 参编单位3  1701008 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 参编单位3  1701008 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 承担工作3  1701009
        /// </summary>
        public string UndertakeWork3 { get; set; }

        /// <summary>
        /// 承担工作3  1701009 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork3 { get; set; }

        /// <summary>
        /// 承担工作3  1701009 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork3 { get; set; }

        /// <summary>
        /// 承担工作3  1701009 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork3 { get; set; }
        /// <summary>
        /// 参编单位4  1701010
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 参编单位4  1701010 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 参编单位4  1701010 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 参编单位4  1701010 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 承担工作4  1701011
        /// </summary>
        public string UndertakeWork4 { get; set; }

        /// <summary>
        /// 承担工作4  1701011 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork4 { get; set; }

        /// <summary>
        /// 承担工作4  1701011 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork4 { get; set; }

        /// <summary>
        /// 承担工作4  1701011 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork4 { get; set; }
        /// <summary>
        /// 编制起止时间_开始时间  1701012
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 编制起止时间_开始时间  1701012 数据类别
        /// </summary>
        public string RecordTypeStartDate { get; set; }

        /// <summary>
        /// 编制起止时间_开始时间  1701012 是否必填
        /// </summary>
        public bool? IsRequiredStartDate { get; set; }

        /// <summary>
        /// 编制起止时间_开始时间  1701012 是否公开
        /// </summary>
        public bool? IsPublicStartDate { get; set; }
        /// <summary>
        /// 编制起止时间_结束时间  1701013
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 编制起止时间_结束时间  1701013 数据类别
        /// </summary>
        public string RecordTypeEndDate { get; set; }

        /// <summary>
        /// 编制起止时间_结束时间  1701013 是否必填
        /// </summary>
        public bool? IsRequiredEndDate { get; set; }

        /// <summary>
        /// 编制起止时间_结束时间  1701013 是否公开
        /// </summary>
        public bool? IsPublicEndDate { get; set; }
        /// <summary>
        /// 项目来源  1701014
        /// </summary>
        public string ProjectSource { get; set; }

        /// <summary>
        /// 项目来源  1701014 数据类别
        /// </summary>
        public string RecordTypeProjectSource { get; set; }

        /// <summary>
        /// 项目来源  1701014 是否必填
        /// </summary>
        public bool? IsRequiredProjectSource { get; set; }

        /// <summary>
        /// 项目来源  1701014 是否公开
        /// </summary>
        public bool? IsPublicProjectSource { get; set; }
        /// <summary>
        /// 批准立项文件号  1701015
        /// </summary>
        public string ApprovalNumber { get; set; }

        /// <summary>
        /// 批准立项文件号  1701015 数据类别
        /// </summary>
        public string RecordTypeApprovalNumber { get; set; }

        /// <summary>
        /// 批准立项文件号  1701015 是否必填
        /// </summary>
        public bool? IsRequiredApprovalNumber { get; set; }

        /// <summary>
        /// 批准立项文件号  1701015 是否公开
        /// </summary>
        public bool? IsPublicApprovalNumber { get; set; }
        /// <summary>
        /// 批准实施文件号  1701016
        /// </summary>
        public string ImplementNumber { get; set; }

        /// <summary>
        /// 批准实施文件号  1701016 数据类别
        /// </summary>
        public string RecordTypeImplementNumber { get; set; }

        /// <summary>
        /// 批准实施文件号  1701016 是否必填
        /// </summary>
        public bool? IsRequiredImplementNumber { get; set; }

        /// <summary>
        /// 批准实施文件号  1701016 是否公开
        /// </summary>
        public bool? IsPublicImplementNumber { get; set; }
        /// <summary>
        /// 申报单位通讯地址  1701017
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1701017 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1701017 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1701017 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 申报单位联系人  1701018
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1701018 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1701018 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1701018 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  1701019
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1701019 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1701019 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1701019 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话号码  1701020
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话号码  1701020 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话号码  1701020 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话号码  1701020 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 传真号码  1701021
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真号码  1701021 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真号码  1701021 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真号码  1701021 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 邮政编码  1701022
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1701022 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1701022 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1701022 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 电子邮箱  1701023
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1701023 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1701023 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1701023 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 曾获奖项  1701025
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1701025 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1701025 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1701025 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }

        /// <summary>
        /// 申报材料目录  1701026
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  1701026 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  1701026 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  1701026 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }
    }


    /// <summary>
    /// 标准（标准设计）项目—项目特点
    /// </summary>
    [Serializable]
    public class Template_1702 : TemplateBase
    {
        /// <summary>
        /// 标准（标准设计）主要内容  1702001
        /// </summary>
        public string PrimaryCoverage { get; set; }

        /// <summary>
        /// 标准（标准设计）主要内容  1702001 数据类别
        /// </summary>
        public string RecordTypePrimaryCoverage { get; set; }

        /// <summary>
        /// 标准（标准设计）主要内容  1702001 是否必填
        /// </summary>
        public bool? IsRequiredPrimaryCoverage { get; set; }

        /// <summary>
        /// 标准（标准设计）主要内容  1702001 是否公开
        /// </summary>
        public bool? IsPublicPrimaryCoverage { get; set; }
        /// <summary>
        /// 标准（标准设计）主要优缺点和效益  1702002
        /// </summary>
        public string Benefits { get; set; }

        /// <summary>
        /// 标准（标准设计）主要优缺点和效益  1702002 数据类别
        /// </summary>
        public string RecordTypeBenefits { get; set; }

        /// <summary>
        /// 标准（标准设计）主要优缺点和效益  1702002 是否必填
        /// </summary>
        public bool? IsRequiredBenefits { get; set; }

        /// <summary>
        /// 标准（标准设计）主要优缺点和效益  1702002 是否公开
        /// </summary>
        public bool? IsPublicBenefits { get; set; }
        /// <summary>
        /// 申报单位意见  1702003
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1702003 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1702003 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1702003 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 推荐意见  1702004
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 推荐意见  1702004 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 推荐意见  1702004 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 推荐意见  1702004 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }
        /// <summary>
        /// 曾获奖项  1702005
        /// </summary>
        public string Award { get; set; }

        /// <summary>
        /// 曾获奖项  1702005 数据类别
        /// </summary>
        public string RecordTypeAward { get; set; }

        /// <summary>
        /// 曾获奖项  1702005 是否必填
        /// </summary>
        public bool? IsRequiredAward { get; set; }

        /// <summary>
        /// 曾获奖项  1702005 是否公开
        /// </summary>
        public bool? IsPublicAward { get; set; }
        /// <summary>
        /// 申报单位意见填写时间  1702006
        /// </summary>
        public string UnitOpinionDate { get; set; }

        /// <summary>
        /// 申报单位意见填写时间  1702006 数据类别
        /// </summary>
        public string RecordTypeUnitOpinionDate { get; set; }

        /// <summary>
        /// 申报单位意见填写时间  1702006 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinionDate { get; set; }

        /// <summary>
        /// 申报单位意见填写时间  1702006 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinionDate { get; set; }
        /// <summary>
        /// 推荐意见填写时间  1702007
        /// </summary>
        public string RecommendOpinionDate { get; set; }

        /// <summary>
        /// 推荐意见填写时间  1702007 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinionDate { get; set; }

        /// <summary>
        /// 推荐意见填写时间  1702007 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinionDate { get; set; }

        /// <summary>
        /// 推荐意见填写时间  1702007 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinionDate { get; set; }
    }
}

