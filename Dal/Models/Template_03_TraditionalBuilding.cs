using System;

namespace Dal.Models
{
    /// <summary>
    /// 传统建筑模板
    /// </summary>
    [Serializable]
    public class Template_03_TraditionalBuilding : TemplateBase
    {
        /// <summary>
        /// 传统建筑模板—基础信息
        /// </summary>
        public Template_0301 Part_01 { get; set; }

        /// <summary>
        /// 传统建筑模板—技术申报内容
        /// </summary>
        public Template_0302 Part_02 { get; set; }
    }
    /// <summary>
    /// 传统建筑模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_0301 : TemplateBase
    {
        /// <summary>
        /// 项目名称  0301001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0301001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0301001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0301001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 单位名称  0301002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  0301002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  0301002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 单位名称  0301002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0301003
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0301003 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0301003 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0301003 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0301004
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0301004 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0301004 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0301004 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0301005
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0301005 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0301005 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0301005 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0301006
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0301006 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0301006 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0301006 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0301007
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0301007 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0301007 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0301007 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0301008
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0301008 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0301008 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0301008 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0301009
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0301009 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0301009 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0301009 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0301010
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0301010 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0301010 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0301010 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0301011
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0301011 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0301011 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0301011 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0301012
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0301012 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0301012 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0301012 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0301013
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0301013 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0301013 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0301013 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0301014
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0301014 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0301014 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0301014 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0301015
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0301015 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0301015 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0301015 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0301016
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0301016 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0301016 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0301016 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0301017
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0301017 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0301017 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0301017 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0301018
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0301018 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0301018 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0301018 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0301019
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0301019 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0301019 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0301019 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0301020
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0301020 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0301020 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0301020 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0301021
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0301021 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0301021 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0301021 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 业主单位  0301022
        /// </summary>
        public string OwnerUnit { get; set; }

        /// <summary>
        /// 业主单位  0301022 数据类别
        /// </summary>
        public string RecordTypeOwnerUnit { get; set; }

        /// <summary>
        /// 业主单位  0301022 是否必填
        /// </summary>
        public bool? IsRequiredOwnerUnit { get; set; }

        /// <summary>
        /// 业主单位  0301022 是否公开
        /// </summary>
        public bool? IsPublicOwnerUnit { get; set; }
        /// <summary>
        /// 施工单位  0301023
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0301023 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0301023 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0301023 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 项目地点  0301024
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 项目地点  0301024 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 项目地点  0301024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 项目地点  0301024 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  0301025
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0301025 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0301025 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0301025 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计开始时间  0301026
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  0301026 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  0301026 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计开始时间  0301026 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计终止时间  0301027
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计终止时间  0301027 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计终止时间  0301027 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计终止时间  0301027 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 竣工时间  0301028
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0301028 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0301028 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0301028 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 验收时间  0301029
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  0301029 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  0301029 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  0301029 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 验收部门  0301030
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0301030 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0301030 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0301030 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 交付使用时间  0301031
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0301031 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0301031 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0301031 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 资金来源  0301032
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 资金来源  0301032 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 资金来源  0301032 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 资金来源  0301032 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  0301033
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0301033 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0301033 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0301033 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }

        /// <summary>
        /// 专业类别  0301034
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0301034 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0301034 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0301034 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }
    }

    /// <summary>
    /// 传统建筑模板—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_0302 : TemplateBase
    {
        /// <summary>
        /// 技术申报内容  0302001
        /// </summary>
        public string TechnicalDeclarationContent { get; set; }

        /// <summary>
        /// 技术申报内容  0302001 数据类别
        /// </summary>
        public string RecordTypeTechnicalDeclarationContent { get; set; }

        /// <summary>
        /// 技术申报内容  0302001 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalDeclarationContent { get; set; }

        /// <summary>
        /// 技术申报内容  0302001 是否公开
        /// </summary>
        public bool? IsPublicTechnicalDeclarationContent { get; set; }
    }


}
