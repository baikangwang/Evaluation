using System;

namespace Dal.Models
{
    /// <summary>
    /// 计算机软件奖申报模板
    /// </summary>
    [Serializable]
    public class Template_16_Software : TemplateBase
    {
        /// <summary>
        /// 计算机软件奖—基础信息
        /// </summary>
        public Template_1601 Part_01 { get; set; }

        /// <summary>
        /// 计算机软件奖—项目特点
        /// </summary>
        public Template_1602 Part_02 { get; set; }
    }
    /// <summary>
    /// 计算机软件奖—基础信息
    /// </summary>
    [Serializable]
    public class Template_1601 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1601001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1601001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1601001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1601001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 主要设计设计单位  1601002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 主要设计设计单位  1601002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 主要设计设计单位  1601002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 主要设计设计单位  1601002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 合作单位1  1601003
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1601003 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1601003 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1601003 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1601004
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1601004 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1601004 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1601004 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1601005
        /// </summary>
        public string UndertakeWork1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1601005 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1601005 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1601005 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork1 { get; set; }
        /// <summary>
        /// 合作单位2  1601006
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1601006 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1601006 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1601006 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1601007
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1601007 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1601007 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1601007 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1601008
        /// </summary>
        public string UndertakeWork2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1601008 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1601008 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1601008 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork2 { get; set; }
        /// <summary>
        /// 合作单位3  1601009
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1601009 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1601009 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1601009 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1601010
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1601010 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1601010 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1601010 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1601011
        /// </summary>
        public string UndertakeWork3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1601011 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1601011 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1601011 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork3 { get; set; }
        /// <summary>
        /// 合作单位4  1601012
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1601012 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1601012 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1601012 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1601013
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1601013 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1601013 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1601013 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1601014
        /// </summary>
        public string UndertakeWork4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1601014 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1601014 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1601014 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork4 { get; set; }
        /// <summary>
        /// 申报单位通讯地址  1601015
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1601015 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1601015 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1601015 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 申报单位联系人  1601016
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1601016 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1601016 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1601016 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 电话  1601017
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1601017 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1601017 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1601017 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1601018
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1601018 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1601018 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1601018 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 手机  1601019
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1601019 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1601019 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1601019 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1601020
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1601020 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1601020 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1601020 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 传真  1601021
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1601021 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1601021 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1601021 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 软件开发模式  1601022
        /// </summary>
        public string DevelopmentModel { get; set; }

        /// <summary>
        /// 软件开发模式  1601022 数据类别
        /// </summary>
        public string RecordTypeDevelopmentModel { get; set; }

        /// <summary>
        /// 软件开发模式  1601022 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentModel { get; set; }

        /// <summary>
        /// 软件开发模式  1601022 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentModel { get; set; }
        /// <summary>
        /// 软件类别  1601023
        /// </summary>
        public string SoftwareCategory { get; set; }

        /// <summary>
        /// 软件类别  1601023 数据类别
        /// </summary>
        public string RecordTypeSoftwareCategory { get; set; }

        /// <summary>
        /// 软件类别  1601023 是否必填
        /// </summary>
        public bool? IsRequiredSoftwareCategory { get; set; }

        /// <summary>
        /// 软件类别  1601023 是否公开
        /// </summary>
        public bool? IsPublicSoftwareCategory { get; set; }
        /// <summary>
        /// 软件符合哪类现行国家规范  1601024
        /// </summary>
        public string ConformityNationalNorms { get; set; }

        /// <summary>
        /// 软件符合哪类现行国家规范  1601024 数据类别
        /// </summary>
        public string RecordTypeConformityNationalNorms { get; set; }

        /// <summary>
        /// 软件符合哪类现行国家规范  1601024 是否必填
        /// </summary>
        public bool? IsRequiredConformityNationalNorms { get; set; }

        /// <summary>
        /// 软件符合哪类现行国家规范  1601024 是否公开
        /// </summary>
        public bool? IsPublicConformityNationalNorms { get; set; }
        /// <summary>
        /// 任务来源  1601025
        /// </summary>
        public string ProjectSource { get; set; }

        /// <summary>
        /// 任务来源  1601025 数据类别
        /// </summary>
        public string RecordTypeProjectSource { get; set; }

        /// <summary>
        /// 任务来源  1601025 是否必填
        /// </summary>
        public bool? IsRequiredProjectSource { get; set; }

        /// <summary>
        /// 任务来源  1601025 是否公开
        /// </summary>
        public bool? IsPublicProjectSource { get; set; }
        /// <summary>
        /// 开发起止年月_开始时间  1601026
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 开发起止年月_开始时间  1601026 数据类别
        /// </summary>
        public string RecordTypeStartDate { get; set; }

        /// <summary>
        /// 开发起止年月_开始时间  1601026 是否必填
        /// </summary>
        public bool? IsRequiredStartDate { get; set; }

        /// <summary>
        /// 开发起止年月_开始时间  1601026 是否公开
        /// </summary>
        public bool? IsPublicStartDate { get; set; }
        /// <summary>
        /// 开发起止年月_结束时间  1601027
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 开发起止年月_结束时间  1601027 数据类别
        /// </summary>
        public string RecordTypeEndDate { get; set; }

        /// <summary>
        /// 开发起止年月_结束时间  1601027 是否必填
        /// </summary>
        public bool? IsRequiredEndDate { get; set; }

        /// <summary>
        /// 开发起止年月_结束时间  1601027 是否公开
        /// </summary>
        public bool? IsPublicEndDate { get; set; }
        /// <summary>
        /// 试用年月  1601028
        /// </summary>
        public string TrialDate { get; set; }

        /// <summary>
        /// 试用年月  1601028 数据类别
        /// </summary>
        public string RecordTypeTrialDate { get; set; }

        /// <summary>
        /// 试用年月  1601028 是否必填
        /// </summary>
        public bool? IsRequiredTrialDate { get; set; }

        /// <summary>
        /// 试用年月  1601028 是否公开
        /// </summary>
        public bool? IsPublicTrialDate { get; set; }
        /// <summary>
        /// 鉴定部门  1601029
        /// </summary>
        public string IdentificationDepartment { get; set; }

        /// <summary>
        /// 鉴定部门  1601029 数据类别
        /// </summary>
        public string RecordTypeIdentificationDepartment { get; set; }

        /// <summary>
        /// 鉴定部门  1601029 是否必填
        /// </summary>
        public bool? IsRequiredIdentificationDepartment { get; set; }

        /// <summary>
        /// 鉴定部门  1601029 是否公开
        /// </summary>
        public bool? IsPublicIdentificationDepartment { get; set; }
        /// <summary>
        /// 鉴定时间  1601030
        /// </summary>
        public string IdentificationDate { get; set; }

        /// <summary>
        /// 鉴定时间  1601030 数据类别
        /// </summary>
        public string RecordTypeIdentificationDate { get; set; }

        /// <summary>
        /// 鉴定时间  1601030 是否必填
        /// </summary>
        public bool? IsRequiredIdentificationDate { get; set; }

        /// <summary>
        /// 鉴定时间  1601030 是否公开
        /// </summary>
        public bool? IsPublicIdentificationDate { get; set; }
        /// <summary>
        /// 验收部门  1601031
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1601031 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1601031 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1601031 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 验收时间  1601032
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  1601032 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  1601032 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  1601032 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 评测公司  1601033
        /// </summary>
        public string EvaluationCompany { get; set; }

        /// <summary>
        /// 评测公司  1601033 数据类别
        /// </summary>
        public string RecordTypeEvaluationCompany { get; set; }

        /// <summary>
        /// 评测公司  1601033 是否必填
        /// </summary>
        public bool? IsRequiredEvaluationCompany { get; set; }

        /// <summary>
        /// 评测公司  1601033 是否公开
        /// </summary>
        public bool? IsPublicEvaluationCompany { get; set; }
        /// <summary>
        /// 评测时间  1601034
        /// </summary>
        public string EvaluationDate { get; set; }

        /// <summary>
        /// 评测时间  1601034 数据类别
        /// </summary>
        public string RecordTypeEvaluationDate { get; set; }

        /// <summary>
        /// 评测时间  1601034 是否必填
        /// </summary>
        public bool? IsRequiredEvaluationDate { get; set; }

        /// <summary>
        /// 评测时间  1601034 是否公开
        /// </summary>
        public bool? IsPublicEvaluationDate { get; set; }
        /// <summary>
        /// 软件著作权登记号  1601035
        /// </summary>
        public string CopyrightRegistrationNumber { get; set; }

        /// <summary>
        /// 软件著作权登记号  1601035 数据类别
        /// </summary>
        public string RecordTypeCopyrightRegistrationNumber { get; set; }

        /// <summary>
        /// 软件著作权登记号  1601035 是否必填
        /// </summary>
        public bool? IsRequiredCopyrightRegistrationNumber { get; set; }

        /// <summary>
        /// 软件著作权登记号  1601035 是否公开
        /// </summary>
        public bool? IsPublicCopyrightRegistrationNumber { get; set; }
        /// <summary>
        /// 著作权人  1601036
        /// </summary>
        public string CopyrightOwner { get; set; }

        /// <summary>
        /// 著作权人  1601036 数据类别
        /// </summary>
        public string RecordTypeCopyrightOwner { get; set; }

        /// <summary>
        /// 著作权人  1601036 是否必填
        /// </summary>
        public bool? IsRequiredCopyrightOwner { get; set; }

        /// <summary>
        /// 著作权人  1601036 是否公开
        /// </summary>
        public bool? IsPublicCopyrightOwner { get; set; }
        /// <summary>
        /// 保密级别  1601037
        /// </summary>
        public string SecurityLevel { get; set; }

        /// <summary>
        /// 保密级别  1601037 数据类别
        /// </summary>
        public string RecordTypeSecurityLevel { get; set; }

        /// <summary>
        /// 保密级别  1601037 是否必填
        /// </summary>
        public bool? IsRequiredSecurityLevel { get; set; }

        /// <summary>
        /// 保密级别  1601037 是否公开
        /// </summary>
        public bool? IsPublicSecurityLevel { get; set; }
        /// <summary>
        /// 单位资质  1601038
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  1601038 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  1601038 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  1601038 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  1601039
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1601039 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1601039 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1601039 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

        /// <summary>
        /// 申报材料目录  1601040
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  1601040 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  1601040 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  1601040 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }
    }


    /// <summary>
    /// 计算机软件奖—项目特点
    /// </summary>
    [Serializable]
    public class Template_1602 : TemplateBase
    {
        /// <summary>
        /// 运行操作系统名称及版本号  1602001
        /// </summary>
        public string OsVersion { get; set; }

        /// <summary>
        /// 运行操作系统名称及版本号  1602001 数据类别
        /// </summary>
        public string RecordTypeOsVersion { get; set; }

        /// <summary>
        /// 运行操作系统名称及版本号  1602001 是否必填
        /// </summary>
        public bool? IsRequiredOsVersion { get; set; }

        /// <summary>
        /// 运行操作系统名称及版本号  1602001 是否公开
        /// </summary>
        public bool? IsPublicOsVersion { get; set; }
        /// <summary>
        /// 支撑环境名称及版本号  1602002
        /// </summary>
        public string SupportEnvironment { get; set; }

        /// <summary>
        /// 支撑环境名称及版本号  1602002 数据类别
        /// </summary>
        public string RecordTypeSupportEnvironment { get; set; }

        /// <summary>
        /// 支撑环境名称及版本号  1602002 是否必填
        /// </summary>
        public bool? IsRequiredSupportEnvironment { get; set; }

        /// <summary>
        /// 支撑环境名称及版本号  1602002 是否公开
        /// </summary>
        public bool? IsPublicSupportEnvironment { get; set; }
        /// <summary>
        /// 编程语言名称及版本号  1602003
        /// </summary>
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// 编程语言名称及版本号  1602003 数据类别
        /// </summary>
        public string RecordTypeProgrammingLanguage { get; set; }

        /// <summary>
        /// 编程语言名称及版本号  1602003 是否必填
        /// </summary>
        public bool? IsRequiredProgrammingLanguage { get; set; }

        /// <summary>
        /// 编程语言名称及版本号  1602003 是否公开
        /// </summary>
        public bool? IsPublicProgrammingLanguage { get; set; }
        /// <summary>
        /// 主要适用行业  1602004
        /// </summary>
        public string ApplicableIndustry { get; set; }

        /// <summary>
        /// 主要适用行业  1602004 数据类别
        /// </summary>
        public string RecordTypeApplicableIndustry { get; set; }

        /// <summary>
        /// 主要适用行业  1602004 是否必填
        /// </summary>
        public bool? IsRequiredApplicableIndustry { get; set; }

        /// <summary>
        /// 主要适用行业  1602004 是否公开
        /// </summary>
        public bool? IsPublicApplicableIndustry { get; set; }
        /// <summary>
        /// 主要用途  1602005
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// 主要用途  1602005 数据类别
        /// </summary>
        public string RecordTypePurpose { get; set; }

        /// <summary>
        /// 主要用途  1602005 是否必填
        /// </summary>
        public bool? IsRequiredPurpose { get; set; }

        /// <summary>
        /// 主要用途  1602005 是否公开
        /// </summary>
        public bool? IsPublicPurpose { get; set; }
        /// <summary>
        /// 软件主要功能、技术架构及创新概述  1602006
        /// </summary>
        public string MainFunctions { get; set; }

        /// <summary>
        /// 软件主要功能、技术架构及创新概述  1602006 数据类别
        /// </summary>
        public string RecordTypeMainFunctions { get; set; }

        /// <summary>
        /// 软件主要功能、技术架构及创新概述  1602006 是否必填
        /// </summary>
        public bool? IsRequiredMainFunctions { get; set; }

        /// <summary>
        /// 软件主要功能、技术架构及创新概述  1602006 是否公开
        /// </summary>
        public bool? IsPublicMainFunctions { get; set; }
        /// <summary>
        /// 该软件与当前国内外同类软件的综合比较  1602007
        /// </summary>
        public string Comparison { get; set; }

        /// <summary>
        /// 该软件与当前国内外同类软件的综合比较  1602007 数据类别
        /// </summary>
        public string RecordTypeComparison { get; set; }

        /// <summary>
        /// 该软件与当前国内外同类软件的综合比较  1602007 是否必填
        /// </summary>
        public bool? IsRequiredComparison { get; set; }

        /// <summary>
        /// 该软件与当前国内外同类软件的综合比较  1602007 是否公开
        /// </summary>
        public bool? IsPublicComparison { get; set; }
        /// <summary>
        /// 该软件的经济与社会效益  1602008
        /// </summary>
        public string Benefits { get; set; }

        /// <summary>
        /// 该软件的经济与社会效益  1602008 数据类别
        /// </summary>
        public string RecordTypeBenefits { get; set; }

        /// <summary>
        /// 该软件的经济与社会效益  1602008 是否必填
        /// </summary>
        public bool? IsRequiredBenefits { get; set; }

        /// <summary>
        /// 该软件的经济与社会效益  1602008 是否公开
        /// </summary>
        public bool? IsPublicBenefits { get; set; }
        /// <summary>
        /// 申报单位意见  1602009
        /// </summary>
        public string Opinion { get; set; }

        /// <summary>
        /// 申报单位意见  1602009 数据类别
        /// </summary>
        public string RecordTypeOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1602009 是否必填
        /// </summary>
        public bool? IsRequiredOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1602009 是否公开
        /// </summary>
        public bool? IsPublicOpinion { get; set; }
        /// <summary>
        /// 申报单位填写时间  1602010
        /// </summary>
        public string CompanyOpinionDate { get; set; }

        /// <summary>
        /// 申报单位填写时间  1602010 数据类别
        /// </summary>
        public string RecordTypeCompanyOpinionDate { get; set; }

        /// <summary>
        /// 申报单位填写时间  1602010 是否必填
        /// </summary>
        public bool? IsRequiredCompanyOpinionDate { get; set; }

        /// <summary>
        /// 申报单位填写时间  1602010 是否公开
        /// </summary>
        public bool? IsPublicCompanyOpinionDate { get; set; }
        /// <summary>
        /// 曾获奖项  1602011
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1602011 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1602011 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1602011 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1602012
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1602012 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1602012 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1602012 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
