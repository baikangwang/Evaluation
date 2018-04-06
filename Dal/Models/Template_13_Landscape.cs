using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 园林景观专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_13_Landscape : TemplateBase
    {
        /// <summary>
        /// 园林景观专项奖—基础信息
        /// </summary>
        public Template_1301 Part_01 { get; set; }

        /// <summary>
        /// 园林景观专项奖—技术申报内容
        /// </summary>
        public Template_1302 Part_02 { get; set; }
    }

    /// <summary>
    /// 园林景观专项奖—基础信息
    /// </summary>
    [Serializable]
    public class Template_1301 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1301001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1301001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1301001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1301001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 单位名称  1301002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  1301002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  1301002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  1301002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  1301003
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1301003 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1301003 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1301003 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  1301004
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  1301004 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  1301004 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  1301004 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  1301005
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1301005 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1301005 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1301005 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  1301006
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1301006 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1301006 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1301006 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1301007
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1301007 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1301007 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1301007 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  1301008
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1301008 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1301008 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1301008 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1301009
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1301009 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1301009 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1301009 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  1301010
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1301010 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1301010 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1301010 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1301011
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1301011 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1301011 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1301011 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1301012
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1301012 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1301012 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1301012 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  1301013
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1301013 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1301013 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1301013 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1301014
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1301014 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1301014 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1301014 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1301015
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1301015 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1301015 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1301015 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  1301016
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1301016 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1301016 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1301016 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1301017
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1301017 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1301017 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1301017 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1301018
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1301018 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1301018 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1301018 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  1301019
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1301019 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1301019 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1301019 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1301020
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1301020 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1301020 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1301020 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1301021
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1301021 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1301021 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1301021 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  1301022
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1301022 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1301022 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1301022 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  1301023
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1301023 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1301023 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1301023 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 建设地点  1301024
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1301024 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1301024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1301024 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  1301025
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1301025 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1301025 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1301025 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计开始时间  1301026
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1301026 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1301026 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1301026 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计结束时间  1301027
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计结束时间  1301027 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计结束时间  1301027 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计结束时间  1301027 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 竣工时间  1301028
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1301028 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1301028 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1301028 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工时间  1301029
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工时间  1301029 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工时间  1301029 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工时间  1301029 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 交付使用时间  1301030
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1301030 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1301030 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1301030 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 验收部门  1301031
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1301031 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1301031 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1301031 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 投资来源  1301032
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 投资来源  1301032 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1301032 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1301032 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  1301033
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1301033 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1301033 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1301033 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }

        /// <summary>
        /// 单位资质  1301034
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  1301034 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  1301034 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  1301034 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  1301035
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1301035 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1301035 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1301035 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

    }


    /// <summary>
    /// 园林景观专项奖—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_1302 : TemplateBase
    {
        /// <summary>
        /// 专业类别  1302001
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1302001 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1302001 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1302001 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }
        /// <summary>
        /// 工程规模  1302002
        /// </summary>
        public string ProjectScale { get; set; }

        /// <summary>
        /// 工程规模  1302002 数据类别
        /// </summary>
        public string RecordTypeProjectScale { get; set; }

        /// <summary>
        /// 工程规模  1302002 是否必填
        /// </summary>
        public bool? IsRequiredProjectScale { get; set; }

        /// <summary>
        /// 工程规模  1302002 是否公开
        /// </summary>
        public bool? IsPublicProjectScale { get; set; }
        /// <summary>
        /// 设计技术及创新要点  1302003
        /// </summary>
        public string TechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1302003 数据类别
        /// </summary>
        public string RecordTypeTechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1302003 是否必填
        /// </summary>
        public bool? IsRequiredTechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1302003 是否公开
        /// </summary>
        public bool? IsPublicTechnologicalInnovation { get; set; }
        /// <summary>
        /// 设计概算  1302004
        /// </summary>
        public string Estimate { get; set; }

        /// <summary>
        /// 设计概算  1302004 数据类别
        /// </summary>
        public string RecordTypeEstimate { get; set; }

        /// <summary>
        /// 设计概算  1302004 是否必填
        /// </summary>
        public bool? IsRequiredEstimate { get; set; }

        /// <summary>
        /// 设计概算  1302004 是否公开
        /// </summary>
        public bool? IsPublicEstimate { get; set; }
        /// <summary>
        /// 竣工结算  1302005
        /// </summary>
        public string Settlement { get; set; }

        /// <summary>
        /// 竣工结算  1302005 数据类别
        /// </summary>
        public string RecordTypeSettlement { get; set; }

        /// <summary>
        /// 竣工结算  1302005 是否必填
        /// </summary>
        public bool? IsRequiredSettlement { get; set; }

        /// <summary>
        /// 竣工结算  1302005 是否公开
        /// </summary>
        public bool? IsPublicSettlement { get; set; }
        /// <summary>
        /// 决算与概算的出入原因  1302006
        /// </summary>
        public string DiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1302006 数据类别
        /// </summary>
        public string RecordTypeDiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1302006 是否必填
        /// </summary>
        public bool? IsRequiredDiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1302006 是否公开
        /// </summary>
        public bool? IsPublicDiscrepancyReason { get; set; }
        /// <summary>
        /// 其他  1302007
        /// </summary>
        public string Others { get; set; }

        /// <summary>
        /// 其他  1302007 数据类别
        /// </summary>
        public string RecordTypeOthers { get; set; }

        /// <summary>
        /// 其他  1302007 是否必填
        /// </summary>
        public bool? IsRequiredOthers { get; set; }

        /// <summary>
        /// 其他  1302007 是否公开
        /// </summary>
        public bool? IsPublicOthers { get; set; }
        /// <summary>
        /// 设计主要特点  1302008
        /// </summary>
        public string MainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1302008 数据类别
        /// </summary>
        public string RecordTypeMainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1302008 是否必填
        /// </summary>
        public bool? IsRequiredMainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1302008 是否公开
        /// </summary>
        public bool? IsPublicMainFeatures { get; set; }

        /// <summary>
        /// 项目概况  1302009
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  1302009 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  1302009 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  1302009 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 技术特色  1302010
        /// </summary>
        public string TechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  1302010 数据类别
        /// </summary>
        public string RecordTypeTechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  1302010 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  1302010 是否公开
        /// </summary>
        public bool? IsPublicTechnicalFeatures { get; set; }
        /// <summary>
        /// 曾获奖项  1302011
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1302011 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1302011 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1302011 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  1302012
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1302012 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1302012 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1302012 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1302013
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1302013 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1302013 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1302013 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
