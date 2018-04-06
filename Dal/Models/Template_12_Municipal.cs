using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 市政公用工程设计申报模板
    /// </summary>
    [Serializable]
    public class Template_12_Municipal : TemplateBase
    {
        /// <summary>
        /// 市政公用工程设计申报模板—基础信息
        /// </summary>
        public Template_1201 Part_01 { get; set; }

        /// <summary>
        /// 市政—技术申报内容
        /// </summary>
        public Template_1202 Part_02 { get; set; }
    }
    /// <summary>
    /// 市政公用工程设计申报模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_1201 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1201001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1201001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1201001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1201001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 单位名称  1201002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  1201002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  1201002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  1201002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  1201003
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1201003 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1201003 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1201003 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  1201004
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  1201004 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  1201004 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  1201004 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  1201005
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1201005 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1201005 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1201005 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  1201006
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1201006 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1201006 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1201006 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1201007
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1201007 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1201007 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1201007 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  1201008
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1201008 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1201008 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1201008 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1201009
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1201009 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1201009 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1201009 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  1201010
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1201010 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1201010 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1201010 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1201011
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1201011 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1201011 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1201011 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1201012
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1201012 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1201012 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1201012 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  1201013
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1201013 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1201013 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1201013 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1201014
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1201014 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1201014 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1201014 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1201015
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1201015 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1201015 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1201015 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  1201016
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1201016 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1201016 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1201016 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1201017
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1201017 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1201017 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1201017 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1201018
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1201018 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1201018 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1201018 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  1201019
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1201019 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1201019 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1201019 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1201020
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1201020 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1201020 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1201020 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1201021
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1201021 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1201021 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1201021 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  1201022
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1201022 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1201022 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1201022 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  1201023
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1201023 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1201023 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1201023 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 建设地点  1201024
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1201024 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1201024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1201024 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  1201025
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1201025 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1201025 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1201025 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计开始时间  1201026
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1201026 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1201026 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1201026 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计结束时间  1201027
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计结束时间  1201027 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计结束时间  1201027 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计结束时间  1201027 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 竣工时间  1201028
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1201028 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1201028 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1201028 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工时间  1201029
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工时间  1201029 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工时间  1201029 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工时间  1201029 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 交付使用时间  1201030
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1201030 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1201030 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1201030 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 验收部门  1201031
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1201031 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1201031 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1201031 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 投资来源  1201032
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 投资来源  1201032 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1201032 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1201032 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  1201033
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1201033 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1201033 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1201033 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }

        /// <summary>
        /// 单位资质  1201034
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  1201034 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  1201034 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  1201034 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }

        /// <summary>
        /// 证书编号  1201035
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1201035 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1201035 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1201035 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }
    }

    /// <summary>
    /// 市政—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_1202 : TemplateBase
    {
        /// <summary>
        /// 专业类别  1202001
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1202001 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1202001 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1202001 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }
        /// <summary>
        /// 工程规模  1202002
        /// </summary>
        public string ProjectScale { get; set; }

        /// <summary>
        /// 工程规模  1202002 数据类别
        /// </summary>
        public string RecordTypeProjectScale { get; set; }

        /// <summary>
        /// 工程规模  1202002 是否必填
        /// </summary>
        public bool? IsRequiredProjectScale { get; set; }

        /// <summary>
        /// 工程规模  1202002 是否公开
        /// </summary>
        public bool? IsPublicProjectScale { get; set; }
        /// <summary>
        /// 设计技术及创新要点  1202003
        /// </summary>
        public string TechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1202003 数据类别
        /// </summary>
        public string RecordTypeTechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1202003 是否必填
        /// </summary>
        public bool? IsRequiredTechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1202003 是否公开
        /// </summary>
        public bool? IsPublicTechnologicalInnovation { get; set; }
        /// <summary>
        /// 设计概算  1202004
        /// </summary>
        public string Estimate { get; set; }

        /// <summary>
        /// 设计概算  1202004 数据类别
        /// </summary>
        public string RecordTypeEstimate { get; set; }

        /// <summary>
        /// 设计概算  1202004 是否必填
        /// </summary>
        public bool? IsRequiredEstimate { get; set; }

        /// <summary>
        /// 设计概算  1202004 是否公开
        /// </summary>
        public bool? IsPublicEstimate { get; set; }
        /// <summary>
        /// 竣工结算  1202005
        /// </summary>
        public string Settlement { get; set; }

        /// <summary>
        /// 竣工结算  1202005 数据类别
        /// </summary>
        public string RecordTypeSettlement { get; set; }

        /// <summary>
        /// 竣工结算  1202005 是否必填
        /// </summary>
        public bool? IsRequiredSettlement { get; set; }

        /// <summary>
        /// 竣工结算  1202005 是否公开
        /// </summary>
        public bool? IsPublicSettlement { get; set; }
        /// <summary>
        /// 决算与概算的出入原因  1202006
        /// </summary>
        public string DiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1202006 数据类别
        /// </summary>
        public string RecordTypeDiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1202006 是否必填
        /// </summary>
        public bool? IsRequiredDiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1202006 是否公开
        /// </summary>
        public bool? IsPublicDiscrepancyReason { get; set; }
        /// <summary>
        /// 其他  1202007
        /// </summary>
        public string Others { get; set; }

        /// <summary>
        /// 其他  1202007 数据类别
        /// </summary>
        public string RecordTypeOthers { get; set; }

        /// <summary>
        /// 其他  1202007 是否必填
        /// </summary>
        public bool? IsRequiredOthers { get; set; }

        /// <summary>
        /// 其他  1202007 是否公开
        /// </summary>
        public bool? IsPublicOthers { get; set; }
        /// <summary>
        /// 设计主要特点  1202008
        /// </summary>
        public string MainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1202008 数据类别
        /// </summary>
        public string RecordTypeMainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1202008 是否必填
        /// </summary>
        public bool? IsRequiredMainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1202008 是否公开
        /// </summary>
        public bool? IsPublicMainFeatures { get; set; }

        /// <summary>
        /// 曾获奖项  1202009
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1202009 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1202009 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 是否公开曾获奖项  1202009
        /// </summary>
        public bool? IsPublicAwards { get; set; }

        /// <summary>
        /// 申报单位意见  1202010
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        ///  申报单位意见  1202010 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        ///  申报单位意见  1202010 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 是否公开申报单位意见  1202010
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1202011
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        ///   地方、部门勘察设计同业协会推荐意见  1202011 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        ///   地方、部门勘察设计同业协会推荐意见  1202011 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }
        /// <summary>
        /// 是否公开地方、部门勘察设计同业协会推荐意见  1202011
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
