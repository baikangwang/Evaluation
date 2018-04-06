using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 优秀工业工程设计奖申报模板
    /// </summary>
    [Serializable]
    public class Template_15_Industry : TemplateBase
    {
        /// <summary>
        /// 优秀工业工程设计奖—基础信息
        /// </summary>
        public Template_1501 Part_01 { get; set; }

        /// <summary>
        /// 优秀工业工程设计奖—技术申报内容
        /// </summary>
        public Template_1502 Part_02 { get; set; }
    }

    /// <summary>
    /// 优秀工业工程设计奖—基础信息
    /// </summary>
    [Serializable]
    public class Template_1501 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1501001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1501001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1501001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1501001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 申报单位  1501002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1501002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1501002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1501002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  1501003
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1501003 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1501003 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1501003 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  1501004
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  1501004 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  1501004 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  1501004 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  1501005
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1501005 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1501005 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1501005 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  1501006
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1501006 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1501006 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1501006 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1501007
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1501007 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1501007 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1501007 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  1501008
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1501008 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1501008 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1501008 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1501009
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1501009 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1501009 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1501009 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  1501010
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1501010 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1501010 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1501010 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1501011
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1501011 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1501011 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1501011 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1501012
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1501012 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1501012 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1501012 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  1501013
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1501013 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1501013 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1501013 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1501014
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1501014 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1501014 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1501014 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1501015
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1501015 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1501015 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1501015 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  1501016
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1501016 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1501016 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1501016 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1501017
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1501017 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1501017 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1501017 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1501018
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1501018 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1501018 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1501018 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  1501019
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1501019 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1501019 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1501019 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1501020
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1501020 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1501020 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1501020 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1501021
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1501021 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1501021 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1501021 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 施工单位  1501022
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1501022 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1501022 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1501022 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 建设地点  1501023
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1501023 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1501023 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1501023 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  1501024
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1501024 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1501024 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1501024 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计开始时间  1501025
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1501025 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1501025 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  1501025 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计终止时间  1501026
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计终止时间  1501026 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计终止时间  1501026 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计终止时间  1501026 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  1501027
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1501027 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1501027 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1501027 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  1501028
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1501028 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1501028 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1501028 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  1501029
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1501029 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1501029 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1501029 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  1501030
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1501030 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1501030 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1501030 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  1501031
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1501031 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1501031 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1501031 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  1501032
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1501032 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1501032 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1501032 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 投资来源  1501033
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 投资来源  1501033 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1501033 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1501033 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  1501034
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1501034 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1501034 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1501034 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }
    }


    /// <summary>
    /// 优秀工业工程设计奖—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_1502 : TemplateBase
    {
        /// <summary>
        /// 专业类别  1502001
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1502001 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1502001 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  1502001 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }
        /// <summary>
        /// 建设规模  1502002
        /// </summary>
        public string ProjectScale { get; set; }

        /// <summary>
        /// 建设规模  1502002 数据类别
        /// </summary>
        public string RecordTypeProjectScale { get; set; }

        /// <summary>
        /// 建设规模  1502002 是否必填
        /// </summary>
        public bool? IsRequiredProjectScale { get; set; }

        /// <summary>
        /// 建设规模  1502002 是否公开
        /// </summary>
        public bool? IsPublicProjectScale { get; set; }
        /// <summary>
        /// 设计技术及创新要点  1502003
        /// </summary>
        public string TechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1502003 数据类别
        /// </summary>
        public string RecordTypeTechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1502003 是否必填
        /// </summary>
        public bool? IsRequiredTechnologicalInnovation { get; set; }

        /// <summary>
        /// 设计技术及创新要点  1502003 是否公开
        /// </summary>
        public bool? IsPublicTechnologicalInnovation { get; set; }
        /// <summary>
        /// 设计概算  1502004
        /// </summary>
        public string Estimate { get; set; }

        /// <summary>
        /// 设计概算  1502004 数据类别
        /// </summary>
        public string RecordTypeEstimate { get; set; }

        /// <summary>
        /// 设计概算  1502004 是否必填
        /// </summary>
        public bool? IsRequiredEstimate { get; set; }

        /// <summary>
        /// 设计概算  1502004 是否公开
        /// </summary>
        public bool? IsPublicEstimate { get; set; }
        /// <summary>
        /// 竣工决算  1502005
        /// </summary>
        public string Settlement { get; set; }

        /// <summary>
        /// 竣工决算  1502005 数据类别
        /// </summary>
        public string RecordTypeSettlement { get; set; }

        /// <summary>
        /// 竣工决算  1502005 是否必填
        /// </summary>
        public bool? IsRequiredSettlement { get; set; }

        /// <summary>
        /// 竣工决算  1502005 是否公开
        /// </summary>
        public bool? IsPublicSettlement { get; set; }
        /// <summary>
        /// 决算与概算的出入原因  1502006
        /// </summary>
        public string DiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1502006 数据类别
        /// </summary>
        public string RecordTypeDiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1502006 是否必填
        /// </summary>
        public bool? IsRequiredDiscrepancyReason { get; set; }

        /// <summary>
        /// 决算与概算的出入原因  1502006 是否公开
        /// </summary>
        public bool? IsPublicDiscrepancyReason { get; set; }
        /// <summary>
        /// 其他  1502007
        /// </summary>
        public string Others { get; set; }

        /// <summary>
        /// 其他  1502007 数据类别
        /// </summary>
        public string RecordTypeOthers { get; set; }

        /// <summary>
        /// 其他  1502007 是否必填
        /// </summary>
        public bool? IsRequiredOthers { get; set; }

        /// <summary>
        /// 其他  1502007 是否公开
        /// </summary>
        public bool? IsPublicOthers { get; set; }
        /// <summary>
        /// 设计主要特点  1502008
        /// </summary>
        public string MainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1502008 数据类别
        /// </summary>
        public string RecordTypeMainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1502008 是否必填
        /// </summary>
        public bool? IsRequiredMainFeatures { get; set; }

        /// <summary>
        /// 设计主要特点  1502008 是否公开
        /// </summary>
        public bool? IsPublicMainFeatures { get; set; }
    }
}
