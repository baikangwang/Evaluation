using System;

namespace Dal.Models
{
    /// <summary>
    /// 居住区规划与居住建筑模板
    /// </summary>
    [Serializable]
    public class Template_02_ResidentialBuilding : TemplateBase
    {
        /// <summary>
        /// 居住建筑—基础信息
        /// </summary>
        public Template_0201 Part_01 { get; set; }

        /// <summary>
        /// 居住建筑—技术申报内容—建筑
        /// </summary>
        public Template_0202 Part_02 { get; set; }

        /// <summary>
        /// 居住建筑—技术申报内容—结构
        /// </summary>
        public Template_0203 Part_03 { get; set; }

        /// <summary>
        /// 居住建筑—技术申报内容—设备
        /// </summary>
        public Template_0204 Part_04 { get; set; }

        /// <summary>
        /// 居住建筑—技术申报内容—电气
        /// </summary>
        public Template_0205 Part_05 { get; set; }

        /// <summary>
        /// 居住建筑—技术申报内容—技术经济指标
        /// </summary>
        public Template_0206 Part_06 { get; set; }
    }
    /// <summary>
    /// 居住建筑—基础信息
    /// </summary>
    [Serializable]
    public class Template_0201 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  0201001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0201001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0201001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0201001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  0201002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0201002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0201002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0201002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  0201003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0201003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0201003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0201003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0201004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0201004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0201004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0201004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0201005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0201005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0201005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0201005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0201006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0201006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0201006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0201006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0201007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0201007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0201007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0201007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0201008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0201008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0201008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0201008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0201009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0201009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0201009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0201009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0201010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0201010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0201010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0201010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0201011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0201011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0201011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0201011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0201012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0201012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0201012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0201012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0201013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0201013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0201013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0201013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0201014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0201014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0201014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0201014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0201015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0201015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0201015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0201015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0201016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0201016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0201016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0201016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0201017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0201017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0201017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0201017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0201018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0201018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0201018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0201018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0201019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0201019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0201019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0201019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0201020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0201020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0201020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0201020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0201021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0201021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0201021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0201021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0201022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0201022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0201022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0201022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  0201023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0201023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0201023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0201023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0201024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0201024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0201024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0201024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  0201025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  0201025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0201025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0201025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  0201026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0201026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0201026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0201026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  0201027
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0201027 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0201027 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0201027 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0201028
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0201028 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0201028 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0201028 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0201029
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0201029 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0201029 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0201029 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  0201030
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0201030 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0201030 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0201030 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  0201031
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0201031 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0201031 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0201031 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0201032
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0201032 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0201032 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0201032 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  0201033
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0201033 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0201033 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0201033 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  0201034
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0201034 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0201034 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0201034 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  0201035
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0201035 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0201035 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0201035 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 投资来源  0201036
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 投资来源  0201036 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 投资来源  0201036 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 投资来源  0201036 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  0201037
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0201037 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0201037 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0201037 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }

        /// <summary>
        /// 专业类别  0201038
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0201038 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0201038 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0201038 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }
        /// <summary>
        /// 单位资质  0201039
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0201039 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0201039 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0201039 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  0201040
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0201040 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0201040 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0201040 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

        /// <summary>
        /// 申报材料目录  0201041
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0201041 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0201041 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0201041 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }

    }


    /// <summary>
    /// 居住建筑—技术申报内容—建筑
    /// </summary>
    [Serializable]
    public class Template_0202 : TemplateBase
    {
        /// <summary>
        /// 建筑功能（使用性质）_地上  0202001
        /// </summary>
        public string UseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0202001 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0202001 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0202001 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Overground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  0202002
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0202002 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0202002 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0202002 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  0202003
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  0202003 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  0202003 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  0202003 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  0202004
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0202004 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0202004 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0202004 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总用地面积  0202005
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0202005 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0202005 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0202005 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 代征地面积  0202006
        /// </summary>
        public string ExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0202006 数据类别
        /// </summary>
        public string RecordTypeExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0202006 是否必填
        /// </summary>
        public bool? IsRequiredExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0202006 是否公开
        /// </summary>
        public bool? IsPublicExpropriationArea { get; set; }
        /// <summary>
        /// 建设用地面积  0202007
        /// </summary>
        public string ConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0202007 数据类别
        /// </summary>
        public string RecordTypeConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0202007 是否必填
        /// </summary>
        public bool? IsRequiredConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0202007 是否公开
        /// </summary>
        public bool? IsPublicConstructionArea { get; set; }
        /// <summary>
        /// 总建筑面积  0202008
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0202008 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0202008 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0202008 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 地上面积  0202009
        /// </summary>
        public string OvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0202009 数据类别
        /// </summary>
        public string RecordTypeOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0202009 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0202009 是否公开
        /// </summary>
        public bool? IsPublicOvergroundArea { get; set; }
        /// <summary>
        /// 地下面积  0202010
        /// </summary>
        public string UndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0202010 数据类别
        /// </summary>
        public string RecordTypeUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0202010 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0202010 是否公开
        /// </summary>
        public bool? IsPublicUndergroundArea { get; set; }
        /// <summary>
        /// 建筑基底面积  0202011
        /// </summary>
        public string BuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0202011 数据类别
        /// </summary>
        public string RecordTypeBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0202011 是否必填
        /// </summary>
        public bool? IsRequiredBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0202011 是否公开
        /// </summary>
        public bool? IsPublicBuildingArea { get; set; }
        /// <summary>
        /// 绿地面积  0202012
        /// </summary>
        public string GreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0202012 数据类别
        /// </summary>
        public string RecordTypeGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0202012 是否必填
        /// </summary>
        public bool? IsRequiredGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0202012 是否公开
        /// </summary>
        public bool? IsPublicGreenArea { get; set; }
        /// <summary>
        /// 绿化率  0202013
        /// </summary>
        public string GreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0202013 数据类别
        /// </summary>
        public string RecordTypeGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0202013 是否必填
        /// </summary>
        public bool? IsRequiredGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0202013 是否公开
        /// </summary>
        public bool? IsPublicGreeningRate { get; set; }
        /// <summary>
        /// 容积率  0202014
        /// </summary>
        public string PlotRatio { get; set; }

        /// <summary>
        /// 容积率  0202014 数据类别
        /// </summary>
        public string RecordTypePlotRatio { get; set; }

        /// <summary>
        /// 容积率  0202014 是否必填
        /// </summary>
        public bool? IsRequiredPlotRatio { get; set; }

        /// <summary>
        /// 容积率  0202014 是否公开
        /// </summary>
        public bool? IsPublicPlotRatio { get; set; }
        /// <summary>
        /// 建筑密度  0202015
        /// </summary>
        public string BuildingDensity { get; set; }

        /// <summary>
        /// 建筑密度  0202015 数据类别
        /// </summary>
        public string RecordTypeBuildingDensity { get; set; }

        /// <summary>
        /// 建筑密度  0202015 是否必填
        /// </summary>
        public bool? IsRequiredBuildingDensity { get; set; }

        /// <summary>
        /// 建筑密度  0202015 是否公开
        /// </summary>
        public bool? IsPublicBuildingDensity { get; set; }
        /// <summary>
        /// 建筑分类  0202016
        /// </summary>
        public string BuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类  0202016 数据类别
        /// </summary>
        public string RecordTypeBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类  0202016 是否必填
        /// </summary>
        public bool? IsRequiredBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类  0202016 是否公开
        /// </summary>
        public bool? IsPublicBuildingClassification { get; set; }
        /// <summary>
        /// 耐火等级  0202017
        /// </summary>
        public string FireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0202017 数据类别
        /// </summary>
        public string RecordTypeFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0202017 是否必填
        /// </summary>
        public bool? IsRequiredFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0202017 是否公开
        /// </summary>
        public bool? IsPublicFireResistanceRating { get; set; }
        /// <summary>
        /// 建筑高度  0202018
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0202018 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0202018 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0202018 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 地上层数  0202019
        /// </summary>
        public string OvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0202019 数据类别
        /// </summary>
        public string RecordTypeOvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0202019 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0202019 是否公开
        /// </summary>
        public bool? IsPublicOvergroundLayerCount { get; set; }
        /// <summary>
        /// 地下层数  0202020
        /// </summary>
        public string UndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0202020 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0202020 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0202020 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayerCount { get; set; }
        /// <summary>
        /// 机动车停车计  0202021
        /// </summary>
        public string AutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停车计  0202021 数据类别
        /// </summary>
        public string RecordTypeAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停车计  0202021 是否必填
        /// </summary>
        public bool? IsRequiredAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停车计  0202021 是否公开
        /// </summary>
        public bool? IsPublicAutoParkingCount { get; set; }
        /// <summary>
        /// 地上停车（机动车）  0202022
        /// </summary>
        public string OvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0202022 数据类别
        /// </summary>
        public string RecordTypeOvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0202022 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0202022 是否公开
        /// </summary>
        public bool? IsPublicOvergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 地下停车（机动车）  0202023
        /// </summary>
        public string UndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0202023 数据类别
        /// </summary>
        public string RecordTypeUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0202023 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0202023 是否公开
        /// </summary>
        public bool? IsPublicUndergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 自行车停车计  0202024
        /// </summary>
        public string BicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车计  0202024 数据类别
        /// </summary>
        public string RecordTypeBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车计  0202024 是否必填
        /// </summary>
        public bool? IsRequiredBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车计  0202024 是否公开
        /// </summary>
        public bool? IsPublicBicycleParkingCount { get; set; }
        /// <summary>
        /// 地上停车（自行车）  0202025
        /// </summary>
        public string OvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0202025 数据类别
        /// </summary>
        public string RecordTypeOvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0202025 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0202025 是否公开
        /// </summary>
        public bool? IsPublicOvergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 地下停车（自行车）  0202026
        /// </summary>
        public string UndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0202026 数据类别
        /// </summary>
        public string RecordTypeUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0202026 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0202026 是否公开
        /// </summary>
        public bool? IsPublicUndergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 防空地下室_建筑面积  0202027
        /// </summary>
        public string Basement_ConstructionArea { get; set; }

        /// <summary>
        /// 防空地下室_建筑面积  0202027 数据类别
        /// </summary>
        public string RecordTypeBasement_ConstructionArea { get; set; }

        /// <summary>
        /// 防空地下室_建筑面积  0202027 是否必填
        /// </summary>
        public bool? IsRequiredBasement_ConstructionArea { get; set; }

        /// <summary>
        /// 防空地下室_建筑面积  0202027 是否公开
        /// </summary>
        public bool? IsPublicBasement_ConstructionArea { get; set; }
        /// <summary>
        /// 防空地下室_战时用途  0202028
        /// </summary>
        public string Basement_WartimeUse { get; set; }

        /// <summary>
        /// 防空地下室_战时用途  0202028 数据类别
        /// </summary>
        public string RecordTypeBasement_WartimeUse { get; set; }

        /// <summary>
        /// 防空地下室_战时用途  0202028 是否必填
        /// </summary>
        public bool? IsRequiredBasement_WartimeUse { get; set; }

        /// <summary>
        /// 防空地下室_战时用途  0202028 是否公开
        /// </summary>
        public bool? IsPublicBasement_WartimeUse { get; set; }
        /// <summary>
        /// 防空地下室_平时用途  0202029
        /// </summary>
        public string Basement_UsuallyUse { get; set; }

        /// <summary>
        /// 防空地下室_平时用途  0202029 数据类别
        /// </summary>
        public string RecordTypeBasement_UsuallyUse { get; set; }

        /// <summary>
        /// 防空地下室_平时用途  0202029 是否必填
        /// </summary>
        public bool? IsRequiredBasement_UsuallyUse { get; set; }

        /// <summary>
        /// 防空地下室_平时用途  0202029 是否公开
        /// </summary>
        public bool? IsPublicBasement_UsuallyUse { get; set; }
        /// <summary>
        /// 防空地下室_抗力级别  0202030
        /// </summary>
        public string Basement_ResistanceLevel { get; set; }

        /// <summary>
        /// 防空地下室_抗力级别  0202030 数据类别
        /// </summary>
        public string RecordTypeBasement_ResistanceLevel { get; set; }

        /// <summary>
        /// 防空地下室_抗力级别  0202030 是否必填
        /// </summary>
        public bool? IsRequiredBasement_ResistanceLevel { get; set; }

        /// <summary>
        /// 防空地下室_抗力级别  0202030 是否公开
        /// </summary>
        public bool? IsPublicBasement_ResistanceLevel { get; set; }
        /// <summary>
        /// 防空地下室_防化级别  0202031
        /// </summary>
        public string Basement_AntichemicalLevel { get; set; }

        /// <summary>
        /// 防空地下室_防化级别  0202031 数据类别
        /// </summary>
        public string RecordTypeBasement_AntichemicalLevel { get; set; }

        /// <summary>
        /// 防空地下室_防化级别  0202031 是否必填
        /// </summary>
        public bool? IsRequiredBasement_AntichemicalLevel { get; set; }

        /// <summary>
        /// 防空地下室_防化级别  0202031 是否公开
        /// </summary>
        public bool? IsPublicBasement_AntichemicalLevel { get; set; }
        /// <summary>
        /// 住宅用地  0202032
        /// </summary>
        public string ResidentialLand { get; set; }

        /// <summary>
        /// 住宅用地  0202032 数据类别
        /// </summary>
        public string RecordTypeResidentialLand { get; set; }

        /// <summary>
        /// 住宅用地  0202032 是否必填
        /// </summary>
        public bool? IsRequiredResidentialLand { get; set; }

        /// <summary>
        /// 住宅用地  0202032 是否公开
        /// </summary>
        public bool? IsPublicResidentialLand { get; set; }
        /// <summary>
        /// 配套公建用地  0202033
        /// </summary>
        public string SupportingConstructionLand { get; set; }

        /// <summary>
        /// 配套公建用地  0202033 数据类别
        /// </summary>
        public string RecordTypeSupportingConstructionLand { get; set; }

        /// <summary>
        /// 配套公建用地  0202033 是否必填
        /// </summary>
        public bool? IsRequiredSupportingConstructionLand { get; set; }

        /// <summary>
        /// 配套公建用地  0202033 是否公开
        /// </summary>
        public bool? IsPublicSupportingConstructionLand { get; set; }
        /// <summary>
        /// 非配套公建用地  0202034
        /// </summary>
        public string NonMatchingConstructionLand { get; set; }

        /// <summary>
        /// 非配套公建用地  0202034 数据类别
        /// </summary>
        public string RecordTypeNonMatchingConstructionLand { get; set; }

        /// <summary>
        /// 非配套公建用地  0202034 是否必填
        /// </summary>
        public bool? IsRequiredNonMatchingConstructionLand { get; set; }

        /// <summary>
        /// 非配套公建用地  0202034 是否公开
        /// </summary>
        public bool? IsPublicNonMatchingConstructionLand { get; set; }
        /// <summary>
        /// 道路用地  0202035
        /// </summary>
        public string LandForRoads { get; set; }

        /// <summary>
        /// 道路用地  0202035 数据类别
        /// </summary>
        public string RecordTypeLandForRoads { get; set; }

        /// <summary>
        /// 道路用地  0202035 是否必填
        /// </summary>
        public bool? IsRequiredLandForRoads { get; set; }

        /// <summary>
        /// 道路用地  0202035 是否公开
        /// </summary>
        public bool? IsPublicLandForRoads { get; set; }
        /// <summary>
        /// 公共绿地  0202036
        /// </summary>
        public string GreenSpace { get; set; }

        /// <summary>
        /// 公共绿地  0202036 数据类别
        /// </summary>
        public string RecordTypeGreenSpace { get; set; }

        /// <summary>
        /// 公共绿地  0202036 是否必填
        /// </summary>
        public bool? IsRequiredGreenSpace { get; set; }

        /// <summary>
        /// 公共绿地  0202036 是否公开
        /// </summary>
        public bool? IsPublicGreenSpace { get; set; }
        /// <summary>
        /// 配套公建面积  0202037
        /// </summary>
        public string SupportingConstructionArea { get; set; }

        /// <summary>
        /// 配套公建面积  0202037 数据类别
        /// </summary>
        public string RecordTypeSupportingConstructionArea { get; set; }

        /// <summary>
        /// 配套公建面积  0202037 是否必填
        /// </summary>
        public bool? IsRequiredSupportingConstructionArea { get; set; }

        /// <summary>
        /// 配套公建面积  0202037 是否公开
        /// </summary>
        public bool? IsPublicSupportingConstructionArea { get; set; }
        /// <summary>
        /// 非配套公建面积  0202038
        /// </summary>
        public string NonMatchingConstructionArea { get; set; }

        /// <summary>
        /// 非配套公建面积  0202038 数据类别
        /// </summary>
        public string RecordTypeNonMatchingConstructionArea { get; set; }

        /// <summary>
        /// 非配套公建面积  0202038 是否必填
        /// </summary>
        public bool? IsRequiredNonMatchingConstructionArea { get; set; }

        /// <summary>
        /// 非配套公建面积  0202038 是否公开
        /// </summary>
        public bool? IsPublicNonMatchingConstructionArea { get; set; }
        /// <summary>
        /// 居住建筑面积  0202039
        /// </summary>
        public string ResidentialBuildingArea { get; set; }

        /// <summary>
        /// 居住建筑面积  0202039 数据类别
        /// </summary>
        public string RecordTypeResidentialBuildingArea { get; set; }

        /// <summary>
        /// 居住建筑面积  0202039 是否必填
        /// </summary>
        public bool? IsRequiredResidentialBuildingArea { get; set; }

        /// <summary>
        /// 居住建筑面积  0202039 是否公开
        /// </summary>
        public bool? IsPublicResidentialBuildingArea { get; set; }
        /// <summary>
        /// 平均每套建筑面积  0202040
        /// </summary>
        public string AverageAreaPerSet { get; set; }

        /// <summary>
        /// 平均每套建筑面积  0202040 数据类别
        /// </summary>
        public string RecordTypeAverageAreaPerSet { get; set; }

        /// <summary>
        /// 平均每套建筑面积  0202040 是否必填
        /// </summary>
        public bool? IsRequiredAverageAreaPerSet { get; set; }

        /// <summary>
        /// 平均每套建筑面积  0202040 是否公开
        /// </summary>
        public bool? IsPublicAverageAreaPerSet { get; set; }
        /// <summary>
        /// 总居住户数  0202041
        /// </summary>
        public string TotalHousehold { get; set; }

        /// <summary>
        /// 总居住户数  0202041 数据类别
        /// </summary>
        public string RecordTypeTotalHousehold { get; set; }

        /// <summary>
        /// 总居住户数  0202041 是否必填
        /// </summary>
        public bool? IsRequiredTotalHousehold { get; set; }

        /// <summary>
        /// 总居住户数  0202041 是否公开
        /// </summary>
        public bool? IsPublicTotalHousehold { get; set; }
        /// <summary>
        /// 每户人均数  0202042
        /// </summary>
        public string AveragePersonPerHousehold { get; set; }

        /// <summary>
        /// 每户人均数  0202042 数据类别
        /// </summary>
        public string RecordTypeAveragePersonPerHousehold { get; set; }

        /// <summary>
        /// 每户人均数  0202042 是否必填
        /// </summary>
        public bool? IsRequiredAveragePersonPerHousehold { get; set; }

        /// <summary>
        /// 每户人均数  0202042 是否公开
        /// </summary>
        public bool? IsPublicAveragePersonPerHousehold { get; set; }
        /// <summary>
        /// 总居住人数  0202043
        /// </summary>
        public string TotalPerson { get; set; }

        /// <summary>
        /// 总居住人数  0202043 数据类别
        /// </summary>
        public string RecordTypeTotalPerson { get; set; }

        /// <summary>
        /// 总居住人数  0202043 是否必填
        /// </summary>
        public bool? IsRequiredTotalPerson { get; set; }

        /// <summary>
        /// 总居住人数  0202043 是否公开
        /// </summary>
        public bool? IsPublicTotalPerson { get; set; }
        /// <summary>
        /// 公共人均绿地  0202044
        /// </summary>
        public string PerPersonGreenSpace { get; set; }

        /// <summary>
        /// 公共人均绿地  0202044 数据类别
        /// </summary>
        public string RecordTypePerPersonGreenSpace { get; set; }

        /// <summary>
        /// 公共人均绿地  0202044 是否必填
        /// </summary>
        public bool? IsRequiredPerPersonGreenSpace { get; set; }

        /// <summary>
        /// 公共人均绿地  0202044 是否公开
        /// </summary>
        public bool? IsPublicPerPersonGreenSpace { get; set; }
        /// <summary>
        /// 机动车指标  0202045
        /// </summary>
        public string VehicleIndicators { get; set; }

        /// <summary>
        /// 机动车指标  0202045 数据类别
        /// </summary>
        public string RecordTypeVehicleIndicators { get; set; }

        /// <summary>
        /// 机动车指标  0202045 是否必填
        /// </summary>
        public bool? IsRequiredVehicleIndicators { get; set; }

        /// <summary>
        /// 机动车指标  0202045 是否公开
        /// </summary>
        public bool? IsPublicVehicleIndicators { get; set; }
        /// <summary>
        /// 自行车指标  0202046
        /// </summary>
        public string BicycleIndicators { get; set; }

        /// <summary>
        /// 自行车指标  0202046 数据类别
        /// </summary>
        public string RecordTypeBicycleIndicators { get; set; }

        /// <summary>
        /// 自行车指标  0202046 是否必填
        /// </summary>
        public bool? IsRequiredBicycleIndicators { get; set; }

        /// <summary>
        /// 自行车指标  0202046 是否公开
        /// </summary>
        public bool? IsPublicBicycleIndicators { get; set; }
        /// <summary>
        /// 住宅类型_总栋数  0202047
        /// </summary>
        public string BuildingCount { get; set; }

        /// <summary>
        /// 住宅类型_总栋数  0202047 数据类别
        /// </summary>
        public string RecordTypeBuildingCount { get; set; }

        /// <summary>
        /// 住宅类型_总栋数  0202047 是否必填
        /// </summary>
        public bool? IsRequiredBuildingCount { get; set; }

        /// <summary>
        /// 住宅类型_总栋数  0202047 是否公开
        /// </summary>
        public bool? IsPublicBuildingCount { get; set; }
        /// <summary>
        /// 住宅类型_保障房  0202048
        /// </summary>
        public string SecurityHousing { get; set; }

        /// <summary>
        /// 住宅类型_保障房  0202048 数据类别
        /// </summary>
        public string RecordTypeSecurityHousing { get; set; }

        /// <summary>
        /// 住宅类型_保障房  0202048 是否必填
        /// </summary>
        public bool? IsRequiredSecurityHousing { get; set; }

        /// <summary>
        /// 住宅类型_保障房  0202048 是否公开
        /// </summary>
        public bool? IsPublicSecurityHousing { get; set; }
        /// <summary>
        /// 住宅类型_商品房  0202049
        /// </summary>
        public string CommercialHousing { get; set; }

        /// <summary>
        /// 住宅类型_商品房  0202049 数据类别
        /// </summary>
        public string RecordTypeCommercialHousing { get; set; }

        /// <summary>
        /// 住宅类型_商品房  0202049 是否必填
        /// </summary>
        public bool? IsRequiredCommercialHousing { get; set; }

        /// <summary>
        /// 住宅类型_商品房  0202049 是否公开
        /// </summary>
        public bool? IsPublicCommercialHousing { get; set; }
        /// <summary>
        /// 住宅类型_公寓  0202050
        /// </summary>
        public string Apartment { get; set; }

        /// <summary>
        /// 住宅类型_公寓  0202050 数据类别
        /// </summary>
        public string RecordTypeApartment { get; set; }

        /// <summary>
        /// 住宅类型_公寓  0202050 是否必填
        /// </summary>
        public bool? IsRequiredApartment { get; set; }

        /// <summary>
        /// 住宅类型_公寓  0202050 是否公开
        /// </summary>
        public bool? IsPublicApartment { get; set; }
        /// <summary>
        /// 住宅类型_其他  0202051
        /// </summary>
        public string OtherResidentialType { get; set; }

        /// <summary>
        /// 住宅类型_其他  0202051 数据类别
        /// </summary>
        public string RecordTypeOtherResidentialType { get; set; }

        /// <summary>
        /// 住宅类型_其他  0202051 是否必填
        /// </summary>
        public bool? IsRequiredOtherResidentialType { get; set; }

        /// <summary>
        /// 住宅类型_其他  0202051 是否公开
        /// </summary>
        public bool? IsPublicOtherResidentialType { get; set; }
        /// <summary>
        /// 保障房_限价商品房  0202052
        /// </summary>
        public string CappedPriceHousing { get; set; }

        /// <summary>
        /// 保障房_限价商品房  0202052 数据类别
        /// </summary>
        public string RecordTypeCappedPriceHousing { get; set; }

        /// <summary>
        /// 保障房_限价商品房  0202052 是否必填
        /// </summary>
        public bool? IsRequiredCappedPriceHousing { get; set; }

        /// <summary>
        /// 保障房_限价商品房  0202052 是否公开
        /// </summary>
        public bool? IsPublicCappedPriceHousing { get; set; }
        /// <summary>
        /// 保障房_经济适用房  0202053
        /// </summary>
        public string AffordableHousing { get; set; }

        /// <summary>
        /// 保障房_经济适用房  0202053 数据类别
        /// </summary>
        public string RecordTypeAffordableHousing { get; set; }

        /// <summary>
        /// 保障房_经济适用房  0202053 是否必填
        /// </summary>
        public bool? IsRequiredAffordableHousing { get; set; }

        /// <summary>
        /// 保障房_经济适用房  0202053 是否公开
        /// </summary>
        public bool? IsPublicAffordableHousing { get; set; }
        /// <summary>
        /// 保障房_公租房  0202054
        /// </summary>
        public string PRH { get; set; }

        /// <summary>
        /// 保障房_公租房  0202054 数据类别
        /// </summary>
        public string RecordTypePRH { get; set; }

        /// <summary>
        /// 保障房_公租房  0202054 是否必填
        /// </summary>
        public bool? IsRequiredPRH { get; set; }

        /// <summary>
        /// 保障房_公租房  0202054 是否公开
        /// </summary>
        public bool? IsPublicPRH { get; set; }
        /// <summary>
        /// 保障房_廉租房  0202055
        /// </summary>
        public string LowRentHousing { get; set; }

        /// <summary>
        /// 保障房_廉租房  0202055 数据类别
        /// </summary>
        public string RecordTypeLowRentHousing { get; set; }

        /// <summary>
        /// 保障房_廉租房  0202055 是否必填
        /// </summary>
        public bool? IsRequiredLowRentHousing { get; set; }

        /// <summary>
        /// 保障房_廉租房  0202055 是否公开
        /// </summary>
        public bool? IsPublicLowRentHousing { get; set; }
        /// <summary>
        /// 层数特征_1-6层_地上  0202056
        /// </summary>
        public string OvergroundLayer_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_地上  0202056 数据类别
        /// </summary>
        public string RecordTypeOvergroundLayer_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_地上  0202056 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundLayer_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_地上  0202056 是否公开
        /// </summary>
        public bool? IsPublicOvergroundLayer_Less6 { get; set; }
        /// <summary>
        /// 层数特征_7-10层_地上  0202057
        /// </summary>
        public string OvergroundLayer_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_地上  0202057 数据类别
        /// </summary>
        public string RecordTypeOvergroundLayer_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_地上  0202057 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundLayer_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_地上  0202057 是否公开
        /// </summary>
        public bool? IsPublicOvergroundLayer_7To10 { get; set; }
        /// <summary>
        /// 层数特征_10层以上_地上  0202058
        /// </summary>
        public string OvergroundLayer_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_地上  0202058 数据类别
        /// </summary>
        public string RecordTypeOvergroundLayer_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_地上  0202058 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundLayer_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_地上  0202058 是否公开
        /// </summary>
        public bool? IsPublicOvergroundLayer_Above10 { get; set; }
        /// <summary>
        /// 层数特征_1-6层_地下  0202059
        /// </summary>
        public string UndergroundLayer_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_地下  0202059 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayer_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_地下  0202059 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayer_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_地下  0202059 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayer_Less6 { get; set; }
        /// <summary>
        /// 层数特征_7-10层_地下  0202060
        /// </summary>
        public string UndergroundLayer_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_地下  0202060 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayer_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_地下  0202060 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayer_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_地下  0202060 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayer_7To10 { get; set; }
        /// <summary>
        /// 层数特征_10层以上_地下  0202061
        /// </summary>
        public string UndergroundLayer_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_地下  0202061 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayer_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_地下  0202061 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayer_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_地下  0202061 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayer_Above10 { get; set; }
        /// <summary>
        /// 层数特征_1-6层_高度  0202062
        /// </summary>
        public string Height_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_高度  0202062 数据类别
        /// </summary>
        public string RecordTypeHeight_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_高度  0202062 是否必填
        /// </summary>
        public bool? IsRequiredHeight_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_高度  0202062 是否公开
        /// </summary>
        public bool? IsPublicHeight_Less6 { get; set; }
        /// <summary>
        /// 层数特征_7-10层_高度  0202063
        /// </summary>
        public string Height_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_高度  0202063 数据类别
        /// </summary>
        public string RecordTypeHeight_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_高度  0202063 是否必填
        /// </summary>
        public bool? IsRequiredHeight_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_高度  0202063 是否公开
        /// </summary>
        public bool? IsPublicHeight_7To10 { get; set; }
        /// <summary>
        /// 层数特征_10层以上_高度  0202064
        /// </summary>
        public string Height_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_高度  0202064 数据类别
        /// </summary>
        public string RecordTypeHeight_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_高度  0202064 是否必填
        /// </summary>
        public bool? IsRequiredHeight_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_高度  0202064 是否公开
        /// </summary>
        public bool? IsPublicHeight_Above10 { get; set; }
        /// <summary>
        /// 层数特征_1-6层_栋数  0202065
        /// </summary>
        public string Count_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_栋数  0202065 数据类别
        /// </summary>
        public string RecordTypeCount_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_栋数  0202065 是否必填
        /// </summary>
        public bool? IsRequiredCount_Less6 { get; set; }

        /// <summary>
        /// 层数特征_1-6层_栋数  0202065 是否公开
        /// </summary>
        public bool? IsPublicCount_Less6 { get; set; }
        /// <summary>
        /// 层数特征_7-10层_栋数  0202066
        /// </summary>
        public string Count_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_栋数  0202066 数据类别
        /// </summary>
        public string RecordTypeCount_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_栋数  0202066 是否必填
        /// </summary>
        public bool? IsRequiredCount_7To10 { get; set; }

        /// <summary>
        /// 层数特征_7-10层_栋数  0202066 是否公开
        /// </summary>
        public bool? IsPublicCount_7To10 { get; set; }
        /// <summary>
        /// 层数特征_10层以上_栋数  0202067
        /// </summary>
        public string Count_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_栋数  0202067 数据类别
        /// </summary>
        public string RecordTypeCount_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_栋数  0202067 是否必填
        /// </summary>
        public bool? IsRequiredCount_Above10 { get; set; }

        /// <summary>
        /// 层数特征_10层以上_栋数  0202067 是否公开
        /// </summary>
        public bool? IsPublicCount_Above10 { get; set; }
        /// <summary>
        /// 居住建筑类补充信息备注  0202068
        /// </summary>
        public string ResidentialInfoMemo { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0202068 数据类别
        /// </summary>
        public string RecordTypeResidentialInfoMemo { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0202068 是否必填
        /// </summary>
        public bool? IsRequiredResidentialInfoMemo { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0202068 是否公开
        /// </summary>
        public bool? IsPublicResidentialInfoMemo { get; set; }
        /// <summary>
        /// 建筑专业设计主要特点  0202069
        /// </summary>
        public string ConstructionFeatures { get; set; }

        /// <summary>
        /// 建筑专业设计主要特点  0202069 数据类别
        /// </summary>
        public string RecordTypeConstructionFeatures { get; set; }

        /// <summary>
        /// 建筑专业设计主要特点  0202069 是否必填
        /// </summary>
        public bool? IsRequiredConstructionFeatures { get; set; }

        /// <summary>
        /// 建筑专业设计主要特点  0202069 是否公开
        /// </summary>
        public bool? IsPublicConstructionFeatures { get; set; }
        /// <summary>
        /// 项目概况  0202070
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0202070 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0202070 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 是否公开项目概况  0202070
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }

        /// <summary>
        /// 技术特色  0202071
        /// </summary>
        public string TechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  0202071 数据类别
        /// </summary>
        public string RecordTypeTechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  0202071 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalFeatures { get; set; }

        /// <summary>
        /// 是否公开技术特色  0202071
        /// </summary>
        public bool? IsPublicTechnicalFeatures { get; set; }
        /// <summary>
        /// 技术成效与深度  0202072
        /// </summary>
        public string TechnicalDepth { get; set; }

        /// <summary>
        /// 技术成效与深度  0202072 数据类别
        /// </summary>
        public string RecordTypeTechnicalDepth { get; set; }

        /// <summary>
        /// 技术成效与深度  0202072 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalDepth { get; set; }

        /// <summary>
        /// 是否公开技术成效与深度  0202072
        /// </summary>

        public bool? IsPublicTechnicalDepth { get; set; }
        /// <summary>
        /// 综合效益  0202073
        /// </summary>
        public string ComprehensiveBenefit { get; set; }

        /// <summary>
        ///  综合效益  0202073 数据类别
        /// </summary>
        public string RecordTypeComprehensiveBenefit { get; set; }

        /// <summary>
        ///  综合效益  0202073 是否必填
        /// </summary>
        public bool? IsRequiredComprehensiveBenefit { get; set; }

        /// <summary>
        /// 是否公开综合效益  0202073
        /// </summary>
        public bool? IsPublicComprehensiveBenefit { get; set; }
        /// <summary>
        /// 用地规模  0202074
        /// </summary>
        public string Landscale { get; set; }

        /// <summary>
        /// 用地规模  0202074 数据类别
        /// </summary>
        public string RecordTypeLandscale { get; set; }

        /// <summary>
        /// 用地规模  0202074 是否必填
        /// </summary>
        public bool? IsRequiredLandscale { get; set; }

        /// <summary>
        /// 用地规模  0202074 是否公开
        /// </summary>
        public bool? IsPublicLandscale { get; set; }
        /// <summary>
        /// 结构类型  0202075
        /// </summary>
        public string Structuretype { get; set; }

        /// <summary>
        /// 结构类型  0202075 数据类别
        /// </summary>
        public string RecordTypeStructuretype { get; set; }

        /// <summary>
        /// 结构类型  0202075 是否必填
        /// </summary>
        public bool? IsRequiredStructuretype { get; set; }

        /// <summary>
        /// 结构类型  0202075 是否公开
        /// </summary>
        public bool? IsPublicStructuretype { get; set; }
        /// <summary>
        /// 居住建筑用地  0202076
        /// </summary>
        public string Residentialbuildingland { get; set; }

        /// <summary>
        /// 居住建筑用地  0202076 数据类别
        /// </summary>
        public string RecordTypeResidentialbuildingland { get; set; }

        /// <summary>
        /// 居住建筑用地  0202076 是否必填
        /// </summary>
        public bool? IsRequiredResidentialbuildingland { get; set; }

        /// <summary>
        /// 居住建筑用地  0202076 是否公开
        /// </summary>
        public bool? IsPublicResidentialbuildingland { get; set; }
        /// <summary>
        /// 公共建筑用地  0202077
        /// </summary>
        public string Publicbuildingland { get; set; }

        /// <summary>
        /// 公共建筑用地  0202077 数据类别
        /// </summary>
        public string RecordTypePublicbuildingland { get; set; }

        /// <summary>
        /// 公共建筑用地  0202077 是否必填
        /// </summary>
        public bool? IsRequiredPublicbuildingland { get; set; }

        /// <summary>
        /// 公共建筑用地  0202077 是否公开
        /// </summary>
        public bool? IsPublicPublicbuildingland { get; set; }
        /// <summary>
        /// 道路广场用地  0202078
        /// </summary>
        public string Landforroad { get; set; }

        /// <summary>
        /// 道路广场用地  0202078 数据类别
        /// </summary>
        public string RecordTypeLandforroad { get; set; }

        /// <summary>
        /// 道路广场用地  0202078 是否必填
        /// </summary>
        public bool? IsRequiredLandforroad { get; set; }

        /// <summary>
        /// 道路广场用地  0202078 是否公开
        /// </summary>
        public bool? IsPublicLandforroad { get; set; }
        /// <summary>
        /// 绿化用地  0202079
        /// </summary>
        public string Greenforland { get; set; }

        /// <summary>
        /// 绿化用地  0202079 数据类别
        /// </summary>
        public string RecordTypeGreenforland { get; set; }

        /// <summary>
        /// 绿化用地  0202079 是否必填
        /// </summary>
        public bool? IsRequiredGreenforland { get; set; }

        /// <summary>
        /// 绿化用地  0202079 是否公开
        /// </summary>
        public bool? IsPublicGreenforland { get; set; }
        /// <summary>
        /// 建筑面积-总计  0202080
        /// </summary>
        public string Grossfloorall { get; set; }

        /// <summary>
        /// 建筑面积-总计  0202080 数据类别
        /// </summary>
        public string RecordTypeGrossfloorall { get; set; }

        /// <summary>
        /// 建筑面积-总计  0202080 是否必填
        /// </summary>
        public bool? IsRequiredGrossfloorall { get; set; }

        /// <summary>
        /// 建筑面积-总计  0202080 是否公开
        /// </summary>
        public bool? IsPublicGrossfloorall { get; set; }
        /// <summary>
        /// 建筑面积-住宅  0202081
        /// </summary>
        public string Grossfloorhome { get; set; }

        /// <summary>
        /// 建筑面积-住宅  0202081 数据类别
        /// </summary>
        public string RecordTypeGrossfloorhome { get; set; }

        /// <summary>
        /// 建筑面积-住宅  0202081 是否必填
        /// </summary>
        public bool? IsRequiredGrossfloorhome { get; set; }

        /// <summary>
        /// 建筑面积-住宅  0202081 是否公开
        /// </summary>
        public bool? IsPublicGrossfloorhome { get; set; }
        /// <summary>
        /// 建筑面积-公建  0202082
        /// </summary>
        public string Grossfloorpublic { get; set; }

        /// <summary>
        /// 建筑面积-公建  0202082 数据类别
        /// </summary>
        public string RecordTypeGrossfloorpublic { get; set; }

        /// <summary>
        /// 建筑面积-公建  0202082 是否必填
        /// </summary>
        public bool? IsRequiredGrossfloorpublic { get; set; }

        /// <summary>
        /// 建筑面积-公建  0202082 是否公开
        /// </summary>
        public bool? IsPublicGrossfloorpublic { get; set; }
        /// <summary>
        /// 建筑高度（最高）  0202083
        /// </summary>
        public string Buildingheight { get; set; }

        /// <summary>
        /// 建筑高度（最高）  0202083 数据类别
        /// </summary>
        public string RecordTypeBuildingheight { get; set; }

        /// <summary>
        /// 建筑高度（最高）  0202083 是否必填
        /// </summary>
        public bool? IsRequiredBuildingheight { get; set; }

        /// <summary>
        /// 建筑高度（最高）  0202083 是否公开
        /// </summary>
        public bool? IsPublicBuildingheight { get; set; }
        /// <summary>
        /// 建筑高度（单体）  0202084
        /// </summary>
        public string Buildingsigle { get; set; }

        /// <summary>
        /// 建筑高度（单体）  0202084 数据类别
        /// </summary>
        public string RecordTypeBuildingsigle { get; set; }

        /// <summary>
        /// 建筑高度（单体）  0202084 是否必填
        /// </summary>
        public bool? IsRequiredBuildingsigle { get; set; }

        /// <summary>
        /// 建筑高度（单体）  0202084 是否公开
        /// </summary>
        public bool? IsPublicBuildingsigle { get; set; }
        /// <summary>
        /// 容 积 率  0202085
        /// </summary>
        public string Volumeratio { get; set; }

        /// <summary>
        /// 容 积 率  0202085 数据类别
        /// </summary>
        public string RecordTypeVolumeratio { get; set; }

        /// <summary>
        /// 容 积 率  0202085 是否必填
        /// </summary>
        public bool? IsRequiredVolumeratio { get; set; }

        /// <summary>
        /// 容 积 率  0202085 是否公开
        /// </summary>
        public bool? IsPublicVolumeratio { get; set; }
        /// <summary>
        /// 绿 化 率   0202086
        /// </summary>
        public string Greeningrate { get; set; }

        /// <summary>
        /// 绿 化 率   0202086 数据类别
        /// </summary>
        public string RecordTypeGreeningrate { get; set; }

        /// <summary>
        /// 绿 化 率   0202086 是否必填
        /// </summary>
        public bool? IsRequiredGreeningrate { get; set; }

        /// <summary>
        /// 绿 化 率   0202086 是否公开
        /// </summary>
        public bool? IsPublicGreeningrate { get; set; }
        /// <summary>
        /// 住宅平均每套建筑面积  0202087
        /// </summary>
        public string Averagefloor { get; set; }

        /// <summary>
        /// 住宅平均每套建筑面积  0202087 数据类别
        /// </summary>
        public string RecordTypeAveragefloor { get; set; }

        /// <summary>
        /// 住宅平均每套建筑面积  0202087 是否必填
        /// </summary>
        public bool? IsRequiredAveragefloor { get; set; }

        /// <summary>
        /// 住宅平均每套建筑面积  0202087 是否公开
        /// </summary>
        public bool? IsPublicAveragefloor { get; set; }
        /// <summary>
        /// 总居住户数（户）  0202088
        /// </summary>
        public string Totalnumber { get; set; }

        /// <summary>
        /// 总居住户数（户）  0202088 数据类别
        /// </summary>
        public string RecordTypeTotalnumber { get; set; }

        /// <summary>
        /// 总居住户数（户）  0202088 是否必填
        /// </summary>
        public bool? IsRequiredTotalnumber { get; set; }

        /// <summary>
        /// 总居住户数（户）  0202088 是否公开
        /// </summary>
        public bool? IsPublicTotalnumber { get; set; }
        /// <summary>
        /// 总居住户数（人）  0202089
        /// </summary>
        public string Totalnumberpeople { get; set; }

        /// <summary>
        /// 总居住户数（人）  0202089 数据类别
        /// </summary>
        public string RecordTypeTotalnumberpeople { get; set; }

        /// <summary>
        /// 总居住户数（人）  0202089 是否必填
        /// </summary>
        public bool? IsRequiredTotalnumberpeople { get; set; }

        /// <summary>
        /// 总居住户数（人）  0202089 是否公开
        /// </summary>
        public bool? IsPublicTotalnumberpeople { get; set; }
        /// <summary>
        /// 机动车停放数量  0202090
        /// </summary>
        public string Parkingquantity { get; set; }

        /// <summary>
        /// 机动车停放数量  0202090 数据类别
        /// </summary>
        public string RecordTypeParkingquantity { get; set; }

        /// <summary>
        /// 机动车停放数量  0202090 是否必填
        /// </summary>
        public bool? IsRequiredParkingquantity { get; set; }

        /// <summary>
        /// 机动车停放数量  0202090 是否公开
        /// </summary>
        public bool? IsPublicParkingquantity { get; set; }
        /// <summary>
        /// 机动车停放数量-总计  0202091
        /// </summary>
        public string Parkingquantityall { get; set; }

        /// <summary>
        /// 机动车停放数量-总计  0202091 数据类别
        /// </summary>
        public string RecordTypeParkingquantityall { get; set; }

        /// <summary>
        /// 机动车停放数量-总计  0202091 是否必填
        /// </summary>
        public bool? IsRequiredParkingquantityall { get; set; }

        /// <summary>
        /// 机动车停放数量-总计  0202091 是否公开
        /// </summary>
        public bool? IsPublicParkingquantityall { get; set; }
        /// <summary>
        /// 机动车停放数量-地上  0202092
        /// </summary>
        public string Parkingquantityup { get; set; }

        /// <summary>
        /// 机动车停放数量-地上  0202092 数据类别
        /// </summary>
        public string RecordTypeParkingquantityup { get; set; }

        /// <summary>
        /// 机动车停放数量-地上  0202092 是否必填
        /// </summary>
        public bool? IsRequiredParkingquantityup { get; set; }

        /// <summary>
        /// 机动车停放数量-地上  0202092 是否公开
        /// </summary>
        public bool? IsPublicParkingquantityup { get; set; }
        /// <summary>
        /// 机动车停放数量-地下  0202093
        /// </summary>
        public string Parkingquantitydown { get; set; }

        /// <summary>
        /// 机动车停放数量-地下  0202093 数据类别
        /// </summary>
        public string RecordTypeParkingquantitydown { get; set; }

        /// <summary>
        /// 机动车停放数量-地下  0202093 是否必填
        /// </summary>
        public bool? IsRequiredParkingquantitydown { get; set; }

        /// <summary>
        /// 机动车停放数量-地下  0202093 是否公开
        /// </summary>
        public bool? IsPublicParkingquantitydown { get; set; }
        /// <summary>
        /// 自行车停放数量  0202094
        /// </summary>
        public string Numberofparked { get; set; }

        /// <summary>
        /// 自行车停放数量  0202094 数据类别
        /// </summary>
        public string RecordTypeNumberofparked { get; set; }

        /// <summary>
        /// 自行车停放数量  0202094 是否必填
        /// </summary>
        public bool? IsRequiredNumberofparked { get; set; }

        /// <summary>
        /// 自行车停放数量  0202094 是否公开
        /// </summary>
        public bool? IsPublicNumberofparked { get; set; }
        /// <summary>
        /// 自行车停放数量-总计  0202095
        /// </summary>
        public string Numberofparkedall { get; set; }

        /// <summary>
        /// 自行车停放数量-总计  0202095 数据类别
        /// </summary>
        public string RecordTypeNumberofparkedall { get; set; }

        /// <summary>
        /// 自行车停放数量-总计  0202095 是否必填
        /// </summary>
        public bool? IsRequiredNumberofparkedall { get; set; }

        /// <summary>
        /// 自行车停放数量-总计  0202095 是否公开
        /// </summary>
        public bool? IsPublicNumberofparkedall { get; set; }
        /// <summary>
        /// 自行车停放数量-地上  0202096
        /// </summary>
        public string Numberofparkedup { get; set; }

        /// <summary>
        /// 自行车停放数量-地上  0202096 数据类别
        /// </summary>
        public string RecordTypeNumberofparkedup { get; set; }

        /// <summary>
        /// 自行车停放数量-地上  0202096 是否必填
        /// </summary>
        public bool? IsRequiredNumberofparkedup { get; set; }

        /// <summary>
        /// 自行车停放数量-地上  0202096 是否公开
        /// </summary>
        public bool? IsPublicNumberofparkedup { get; set; }
        /// <summary>
        /// 自行车停放数量-地下  0202097
        /// </summary>
        public string Numberofparkeddown { get; set; }

        /// <summary>
        /// 自行车停放数量-地下  0202097 数据类别
        /// </summary>
        public string RecordTypeNumberofparkeddown { get; set; }

        /// <summary>
        /// 自行车停放数量-地下  0202097 是否必填
        /// </summary>
        public bool? IsRequiredNumberofparkeddown { get; set; }

        /// <summary>
        /// 自行车停放数量-地下  0202097 是否公开
        /// </summary>
        public bool? IsPublicNumberofparkeddown { get; set; }
        /// <summary>
        /// 机动车停车率  0202098
        /// </summary>
        public string Vehicleparkingrate { get; set; }

        /// <summary>
        /// 机动车停车率  0202098 数据类别
        /// </summary>
        public string RecordTypeVehicleparkingrate { get; set; }

        /// <summary>
        /// 机动车停车率  0202098 是否必填
        /// </summary>
        public bool? IsRequiredVehicleparkingrate { get; set; }

        /// <summary>
        /// 机动车停车率  0202098 是否公开
        /// </summary>
        public bool? IsPublicVehicleparkingrate { get; set; }
        /// <summary>
        /// 自行车停车率  0202099
        /// </summary>
        public string Bicycleparkingrate { get; set; }

        /// <summary>
        /// 自行车停车率  0202099 数据类别
        /// </summary>
        public string RecordTypeBicycleparkingrate { get; set; }

        /// <summary>
        /// 自行车停车率  0202099 是否必填
        /// </summary>
        public bool? IsRequiredBicycleparkingrate { get; set; }

        /// <summary>
        /// 自行车停车率  0202099 是否公开
        /// </summary>
        public bool? IsPublicBicycleparkingrate { get; set; }
        /// <summary>
        /// 暖通/空调方式  0202100
        /// </summary>
        public string HVACmode { get; set; }

        /// <summary>
        /// 暖通/空调方式  0202100 数据类别
        /// </summary>
        public string RecordTypeHVACmode { get; set; }

        /// <summary>
        /// 暖通/空调方式  0202100 是否必填
        /// </summary>
        public bool? IsRequiredHVACmode { get; set; }

        /// <summary>
        /// 暖通/空调方式  0202100 是否公开
        /// </summary>
        public bool? IsPublicHVACmode { get; set; }
        /// <summary>
        /// 冷热源方式  0202101
        /// </summary>
        public string Coldandheat { get; set; }

        /// <summary>
        /// 冷热源方式  0202101 数据类别
        /// </summary>
        public string RecordTypeColdandheat { get; set; }

        /// <summary>
        /// 冷热源方式  0202101 是否必填
        /// </summary>
        public bool? IsRequiredColdandheat { get; set; }

        /// <summary>
        /// 冷热源方式  0202101 是否公开
        /// </summary>
        public bool? IsPublicColdandheat { get; set; }
        /// <summary>
        /// 给排水方式  0202102
        /// </summary>
        public string Watersupply { get; set; }

        /// <summary>
        /// 给排水方式  0202102 数据类别
        /// </summary>
        public string RecordTypeWatersupply { get; set; }

        /// <summary>
        /// 给排水方式  0202102 是否必填
        /// </summary>
        public bool? IsRequiredWatersupply { get; set; }

        /// <summary>
        /// 给排水方式  0202102 是否公开
        /// </summary>
        public bool? IsPublicWatersupply { get; set; }
        /// <summary>
        /// 消防给水方式  0202103
        /// </summary>
        public string Firewatersupply { get; set; }

        /// <summary>
        /// 消防给水方式  0202103 数据类别
        /// </summary>
        public string RecordTypeFirewatersupply { get; set; }

        /// <summary>
        /// 消防给水方式  0202103 是否必填
        /// </summary>
        public bool? IsRequiredFirewatersupply { get; set; }

        /// <summary>
        /// 消防给水方式  0202103 是否公开
        /// </summary>
        public bool? IsPublicFirewatersupply { get; set; }
        /// <summary>
        /// 电热采暖  0202104
        /// </summary>
        public string Electrothermalheating { get; set; }

        /// <summary>
        /// 电热采暖  0202104 数据类别
        /// </summary>
        public string RecordTypeElectrothermalheating { get; set; }

        /// <summary>
        /// 电热采暖  0202104 是否必填
        /// </summary>
        public bool? IsRequiredElectrothermalheating { get; set; }

        /// <summary>
        /// 电热采暖  0202104 是否公开
        /// </summary>
        public bool? IsPublicElectrothermalheating { get; set; }
        /// <summary>
        /// 电梯总数  0202105
        /// </summary>
        public string Elevatortotal { get; set; }

        /// <summary>
        /// 电梯总数  0202105 数据类别
        /// </summary>
        public string RecordTypeElevatortotal { get; set; }

        /// <summary>
        /// 电梯总数  0202105 是否必填
        /// </summary>
        public bool? IsRequiredElevatortotal { get; set; }

        /// <summary>
        /// 电梯总数  0202105 是否公开
        /// </summary>
        public bool? IsPublicElevatortotal { get; set; }
        /// <summary>
        /// 设计概算  0202106
        /// </summary>
        public string Designestimate { get; set; }

        /// <summary>
        /// 设计概算  0202106 数据类别
        /// </summary>
        public string RecordTypeDesignestimate { get; set; }

        /// <summary>
        /// 设计概算  0202106 是否必填
        /// </summary>
        public bool? IsRequiredDesignestimate { get; set; }

        /// <summary>
        /// 设计概算  0202106 是否公开
        /// </summary>
        public bool? IsPublicDesignestimate { get; set; }
        /// <summary>
        /// 竣工结算  0202107
        /// </summary>
        public string Finalsettlement { get; set; }

        /// <summary>
        /// 竣工结算  0202107 数据类别
        /// </summary>
        public string RecordTypeFinalsettlement { get; set; }

        /// <summary>
        /// 竣工结算  0202107 是否必填
        /// </summary>
        public bool? IsRequiredFinalsettlement { get; set; }

        /// <summary>
        /// 竣工结算  0202107 是否公开
        /// </summary>
        public bool? IsPublicFinalsettlement { get; set; }
        /// <summary>
        /// 住宅单方工程造价  0202108
        /// </summary>
        public string Residentialunilateral { get; set; }

        /// <summary>
        /// 住宅单方工程造价  0202108 数据类别
        /// </summary>
        public string RecordTypeResidentialunilateral { get; set; }

        /// <summary>
        /// 住宅单方工程造价  0202108 是否必填
        /// </summary>
        public bool? IsRequiredResidentialunilateral { get; set; }

        /// <summary>
        /// 住宅单方工程造价  0202108 是否公开
        /// </summary>
        public bool? IsPublicResidentialunilateral { get; set; }
        /// <summary>
        /// 概算变更主要原因  0202109
        /// </summary>
        public string Mainreasonforchange { get; set; }

        /// <summary>
        /// 概算变更主要原因  0202109 数据类别
        /// </summary>
        public string RecordTypeMainreasonforchange { get; set; }

        /// <summary>
        /// 概算变更主要原因  0202109 是否必填
        /// </summary>
        public bool? IsRequiredMainreasonforchange { get; set; }

        /// <summary>
        /// 概算变更主要原因  0202109 是否公开
        /// </summary>
        public bool? IsPublicMainreasonforchange { get; set; }
        /// <summary>
        /// 项目的主要优缺点及社会经济效益  0202110
        /// </summary>
        public string Mainadvantagesanddisadvantages { get; set; }

        /// <summary>
        /// 项目的主要优缺点及社会经济效益  0202110 数据类别
        /// </summary>
        public string RecordTypeMainadvantagesanddisadvantages { get; set; }

        /// <summary>
        /// 项目的主要优缺点及社会经济效益  0202110 是否必填
        /// </summary>
        public bool? IsRequiredMainadvantagesanddisadvantages { get; set; }

        /// <summary>
        /// 项目的主要优缺点及社会经济效益  0202110 是否公开
        /// </summary>
        public bool? IsPublicMainadvantagesanddisadvantages { get; set; }

        /// <summary>
        /// 住宅类型  0202111
        /// </summary>
        public string ResidentialType { get; set; }

        /// <summary>
        /// 住宅类型  0202110 数据类别
        /// </summary>
        public string RecordTypeResidentialType { get; set; }

        /// <summary>
        /// 住宅类型  0202110 是否必填
        /// </summary>
        public bool? IsRequiredResidentialType { get; set; }

        /// <summary>
        /// 住宅类型  0202110 是否公开
        /// </summary>
        public bool? IsPublicResidentialType { get; set; }       

    }


    /// <summary>
    /// 居住建筑—技术申报内容—结构
    /// </summary>
    [Serializable]
    public class Template_0203 : TemplateBase
    {
        /// <summary>
        /// 结构体系  0203001
        /// </summary>
        public string StructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0203001 数据类别
        /// </summary>
        public string RecordTypeStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0203001 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0203001 是否公开
        /// </summary>
        public bool? IsPublicStructuralSystem { get; set; }
        /// <summary>
        /// 抗震设防烈度  0203002
        /// </summary>
        public string SeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0203002 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0203002 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0203002 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationIntensity { get; set; }
        /// <summary>
        /// 抗震设防类别  0203003
        /// </summary>
        public string SeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0203003 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0203003 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0203003 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationCategory { get; set; }
        /// <summary>
        /// 基本地震加速度  0203004
        /// </summary>
        public string BasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0203004 数据类别
        /// </summary>
        public string RecordTypeBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0203004 是否必填
        /// </summary>
        public bool? IsRequiredBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0203004 是否公开
        /// </summary>
        public bool? IsPublicBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 设计地震分组  0203005
        /// </summary>
        public string EarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0203005 数据类别
        /// </summary>
        public string RecordTypeEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0203005 是否必填
        /// </summary>
        public bool? IsRequiredEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0203005 是否公开
        /// </summary>
        public bool? IsPublicEarthquakeGrouping { get; set; }
        /// <summary>
        /// 建筑场地土类别  0203006
        /// </summary>
        public string ConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0203006 数据类别
        /// </summary>
        public string RecordTypeConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0203006 是否必填
        /// </summary>
        public bool? IsRequiredConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0203006 是否公开
        /// </summary>
        public bool? IsPublicConstructionSiteSoilType { get; set; }
        /// <summary>
        /// 基础类型  0203007
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 基础类型  0203007 数据类别
        /// </summary>
        public string RecordTypeBaseType { get; set; }

        /// <summary>
        /// 基础类型  0203007 是否必填
        /// </summary>
        public bool? IsRequiredBaseType { get; set; }

        /// <summary>
        /// 基础类型  0203007 是否公开
        /// </summary>
        public bool? IsPublicBaseType { get; set; }
        /// <summary>
        /// 结构安全等级  0203008
        /// </summary>
        public string StructuralSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0203008 数据类别
        /// </summary>
        public string RecordTypeStructuralSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0203008 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0203008 是否公开
        /// </summary>
        public bool? IsPublicStructuralSafetyLevel { get; set; }
        /// <summary>
        /// 混凝土总用量  0203009
        /// </summary>
        public string ConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0203009 数据类别
        /// </summary>
        public string RecordTypeConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0203009 是否必填
        /// </summary>
        public bool? IsRequiredConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0203009 是否公开
        /// </summary>
        public bool? IsPublicConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度  0203010
        /// </summary>
        public string PerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0203010 数据类别
        /// </summary>
        public string RecordTypePerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0203010 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0203010 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  0203011
        /// </summary>
        public string SteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0203011 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0203011 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0203011 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  0203012
        /// </summary>
        public string SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0203012 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0203012 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0203012 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  0203013
        /// </summary>
        public string PerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0203013 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0203013 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0203013 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  0203014
        /// </summary>
        public string PerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0203014 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0203014 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0203014 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 振型程序名称  0203015
        /// </summary>
        public string ModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0203015 数据类别
        /// </summary>
        public string RecordTypeModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0203015 是否必填
        /// </summary>
        public bool? IsRequiredModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0203015 是否公开
        /// </summary>
        public bool? IsPublicModeProgramName { get; set; }
        /// <summary>
        /// 振型号1  0203016
        /// </summary>
        public string VibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0203016 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0203016 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0203016 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum1 { get; set; }
        /// <summary>
        /// 周期1  0203017
        /// </summary>
        public string VibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0203017 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0203017 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0203017 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle1 { get; set; }
        /// <summary>
        /// 转角1  0203018
        /// </summary>
        public string VibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0203018 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0203018 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0203018 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle1 { get; set; }
        /// <summary>
        /// 平动系数(x+y)1  0203019
        /// </summary>
        public string TranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0203019 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0203019 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0203019 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient1 { get; set; }
        /// <summary>
        /// 扭转系数1  0203020
        /// </summary>
        public string TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0203020 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0203020 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0203020 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient1 { get; set; }
        /// <summary>
        /// 振型号2  0203021
        /// </summary>
        public string VibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0203021 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0203021 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0203021 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum2 { get; set; }
        /// <summary>
        /// 周期2  0203022
        /// </summary>
        public string VibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0203022 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0203022 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0203022 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle2 { get; set; }
        /// <summary>
        /// 转角2  0203023
        /// </summary>
        public string VibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0203023 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0203023 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0203023 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle2 { get; set; }
        /// <summary>
        /// 平动系数(x+y)2  0203024
        /// </summary>
        public string TranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0203024 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0203024 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0203024 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient2 { get; set; }
        /// <summary>
        /// 扭转系数2  0203025
        /// </summary>
        public string TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0203025 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0203025 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0203025 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient2 { get; set; }
        /// <summary>
        /// 振型号3  0203026
        /// </summary>
        public string VibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0203026 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0203026 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0203026 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum3 { get; set; }
        /// <summary>
        /// 周期3  0203027
        /// </summary>
        public string VibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0203027 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0203027 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0203027 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle3 { get; set; }
        /// <summary>
        /// 转角3  0203028
        /// </summary>
        public string VibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0203028 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0203028 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0203028 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle3 { get; set; }
        /// <summary>
        /// 平动系数(x+y)3  0203029
        /// </summary>
        public string TranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0203029 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0203029 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0203029 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient3 { get; set; }
        /// <summary>
        /// 扭转系数3  0203030
        /// </summary>
        public string TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0203030 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0203030 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0203030 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient3 { get; set; }
        /// <summary>
        /// 振型号4  0203031
        /// </summary>
        public string VibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0203031 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0203031 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0203031 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum4 { get; set; }
        /// <summary>
        /// 周期4  0203032
        /// </summary>
        public string VibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0203032 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0203032 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0203032 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle4 { get; set; }
        /// <summary>
        /// 转角4  0203033
        /// </summary>
        public string VibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0203033 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0203033 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0203033 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle4 { get; set; }
        /// <summary>
        /// 平动系数(x+y)4  0203034
        /// </summary>
        public string TranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0203034 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0203034 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0203034 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient4 { get; set; }
        /// <summary>
        /// 扭转系数4  0203035
        /// </summary>
        public string TorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0203035 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0203035 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0203035 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient4 { get; set; }
        /// <summary>
        /// 振型号5  0203036
        /// </summary>
        public string VibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0203036 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0203036 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0203036 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum5 { get; set; }
        /// <summary>
        /// 周期5  0203037
        /// </summary>
        public string VibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0203037 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0203037 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0203037 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle5 { get; set; }
        /// <summary>
        /// 转角5  0203038
        /// </summary>
        public string VibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0203038 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0203038 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0203038 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle5 { get; set; }
        /// <summary>
        /// 平动系数(x+y)5  0203039
        /// </summary>
        public string TranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0203039 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0203039 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0203039 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient5 { get; set; }
        /// <summary>
        /// 扭转系数5  0203040
        /// </summary>
        public string TorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0203040 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0203040 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0203040 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient5 { get; set; }
        /// <summary>
        /// 振型号6  0203041
        /// </summary>
        public string VibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0203041 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0203041 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0203041 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum6 { get; set; }
        /// <summary>
        /// 周期6  0203042
        /// </summary>
        public string VibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0203042 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0203042 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0203042 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle6 { get; set; }
        /// <summary>
        /// 转角6  0203043
        /// </summary>
        public string VibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0203043 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0203043 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0203043 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle6 { get; set; }
        /// <summary>
        /// 平动系数(x+y)6  0203044
        /// </summary>
        public string TranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0203044 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0203044 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0203044 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient6 { get; set; }
        /// <summary>
        /// 扭转系数6  0203045
        /// </summary>
        public string TorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0203045 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0203045 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0203045 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient6 { get; set; }
        /// <summary>
        /// 振型号7  0203046
        /// </summary>
        public string VibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0203046 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0203046 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0203046 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum7 { get; set; }
        /// <summary>
        /// 周期7  0203047
        /// </summary>
        public string VibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0203047 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0203047 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0203047 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle7 { get; set; }
        /// <summary>
        /// 转角7  0203048
        /// </summary>
        public string VibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0203048 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0203048 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0203048 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle7 { get; set; }
        /// <summary>
        /// 平动系数(x+y)7  0203049
        /// </summary>
        public string TranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0203049 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0203049 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0203049 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient7 { get; set; }
        /// <summary>
        /// 扭转系数7  0203050
        /// </summary>
        public string TorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0203050 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0203050 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0203050 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient7 { get; set; }
        /// <summary>
        /// 振型号8  0203051
        /// </summary>
        public string VibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0203051 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0203051 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0203051 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum8 { get; set; }
        /// <summary>
        /// 周期8  0203052
        /// </summary>
        public string VibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0203052 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0203052 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0203052 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle8 { get; set; }
        /// <summary>
        /// 转角8  0203053
        /// </summary>
        public string VibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0203053 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0203053 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0203053 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle8 { get; set; }
        /// <summary>
        /// 平动系数(x+y)8  0203054
        /// </summary>
        public string TranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0203054 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0203054 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0203054 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient8 { get; set; }
        /// <summary>
        /// 扭转系数8  0203055
        /// </summary>
        public string TorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0203055 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0203055 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0203055 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient8 { get; set; }
        /// <summary>
        /// 振型号9  0203056
        /// </summary>
        public string VibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0203056 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0203056 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0203056 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum9 { get; set; }
        /// <summary>
        /// 周期9  0203057
        /// </summary>
        public string VibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0203057 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0203057 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0203057 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle9 { get; set; }
        /// <summary>
        /// 转角9  0203058
        /// </summary>
        public string VibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0203058 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0203058 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0203058 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle9 { get; set; }
        /// <summary>
        /// 平动系数(x+y)9  0203059
        /// </summary>
        public string TranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0203059 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0203059 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0203059 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient9 { get; set; }
        /// <summary>
        /// 扭转系数9  0203060
        /// </summary>
        public string TorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0203060 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0203060 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0203060 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient9 { get; set; }
        /// <summary>
        /// 是否考虑扭转耦联  0203061
        /// </summary>
        public string IsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0203061 数据类别
        /// </summary>
        public string RecordTypeIsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0203061 是否必填
        /// </summary>
        public bool? IsRequiredIsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0203061 是否公开
        /// </summary>
        public bool? IsPublicIsConsiderCoupling { get; set; }
        /// <summary>
        /// X向基底剪力(kN)  0203062
        /// </summary>
        public string BaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0203062 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0203062 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0203062 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)  0203063
        /// </summary>
        public string BaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0203063 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0203063 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0203063 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y { get; set; }
        /// <summary>
        /// X向基底剪重比  0203064
        /// </summary>
        public string BasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0203064 数据类别
        /// </summary>
        public string RecordTypeBasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0203064 是否必填
        /// </summary>
        public bool? IsRequiredBasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0203064 是否公开
        /// </summary>
        public bool? IsPublicBasalShearRatio_X { get; set; }
        /// <summary>
        /// Y向基底剪重比  0203065
        /// </summary>
        public string BasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0203065 数据类别
        /// </summary>
        public string RecordTypeBasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0203065 是否必填
        /// </summary>
        public bool? IsRequiredBasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0203065 是否公开
        /// </summary>
        public bool? IsPublicBasalShearRatio_Y { get; set; }
        /// <summary>
        /// X向最小剪重比（层号）  0203066
        /// </summary>
        public string MinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0203066 数据类别
        /// </summary>
        public string RecordTypeMinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0203066 是否必填
        /// </summary>
        public bool? IsRequiredMinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0203066 是否公开
        /// </summary>
        public bool? IsPublicMinShearWeightRatio_X { get; set; }
        /// <summary>
        /// Y向最小剪重比（层号）  0203067
        /// </summary>
        public string MinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0203067 数据类别
        /// </summary>
        public string RecordTypeMinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0203067 是否必填
        /// </summary>
        public bool? IsRequiredMinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0203067 是否公开
        /// </summary>
        public bool? IsPublicMinShearWeightRatio_Y { get; set; }
        /// <summary>
        /// X向最大层间位移角  0203068
        /// </summary>
        public string MaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0203068 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0203068 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0203068 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X { get; set; }
        /// <summary>
        /// Y向最大层间位移角  0203069
        /// </summary>
        public string MaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0203069 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0203069 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0203069 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y { get; set; }
        /// <summary>
        /// X向最大位移比（层号）  0203070
        /// </summary>
        public string MaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0203070 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0203070 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0203070 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacementRatio_X { get; set; }
        /// <summary>
        /// Y向最大位移比（层号）  0203071
        /// </summary>
        public string MaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0203071 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0203071 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0203071 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacementRatio_Y { get; set; }
        /// <summary>
        /// 时程分析波名1  0203072
        /// </summary>
        public string TimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0203072 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0203072 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0203072 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName1 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)1  0203073
        /// </summary>
        public string BaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0203073 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0203073 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0203073 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X1 { get; set; }
        /// <summary>
        /// X向最大层间位移角1  0203074
        /// </summary>
        public string MaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0203074 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0203074 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0203074 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X1 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)1  0203075
        /// </summary>
        public string BaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0203075 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0203075 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0203075 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y1 { get; set; }
        /// <summary>
        /// Y向最大层间位移角1  0203076
        /// </summary>
        public string MaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0203076 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0203076 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0203076 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y1 { get; set; }
        /// <summary>
        /// 时程分析波名2  0203077
        /// </summary>
        public string TimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0203077 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0203077 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0203077 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName2 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)2  0203078
        /// </summary>
        public string BaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0203078 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0203078 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0203078 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X2 { get; set; }
        /// <summary>
        /// X向最大层间位移角2  0203079
        /// </summary>
        public string MaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0203079 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0203079 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0203079 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X2 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)2  0203080
        /// </summary>
        public string BaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0203080 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0203080 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0203080 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y2 { get; set; }
        /// <summary>
        /// Y向最大层间位移角2  0203081
        /// </summary>
        public string MaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0203081 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0203081 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0203081 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y2 { get; set; }
        /// <summary>
        /// 时程分析波名3  0203082
        /// </summary>
        public string TimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0203082 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0203082 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0203082 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName3 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)3  0203083
        /// </summary>
        public string BaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0203083 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0203083 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0203083 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X3 { get; set; }
        /// <summary>
        /// X向最大层间位移角3  0203084
        /// </summary>
        public string MaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0203084 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0203084 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0203084 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X3 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)3  0203085
        /// </summary>
        public string BaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0203085 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0203085 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0203085 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y3 { get; set; }
        /// <summary>
        /// Y向最大层间位移角3  0203086
        /// </summary>
        public string MaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0203086 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0203086 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0203086 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y3 { get; set; }
        /// <summary>
        /// 时程分析波名4  0203087
        /// </summary>
        public string TimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0203087 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0203087 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0203087 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName4 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)4  0203088
        /// </summary>
        public string BaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0203088 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0203088 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0203088 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X4 { get; set; }
        /// <summary>
        /// X向最大层间位移角4  0203089
        /// </summary>
        public string MaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0203089 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0203089 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0203089 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X4 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)4  0203090
        /// </summary>
        public string BaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0203090 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0203090 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0203090 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y4 { get; set; }
        /// <summary>
        /// Y向最大层间位移角4  0203091
        /// </summary>
        public string MaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0203091 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0203091 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0203091 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y4 { get; set; }
        /// <summary>
        /// 时程分析波名5  0203092
        /// </summary>
        public string TimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0203092 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0203092 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0203092 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName5 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)5  0203093
        /// </summary>
        public string BaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0203093 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0203093 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0203093 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X5 { get; set; }
        /// <summary>
        /// X向最大层间位移角5  0203094
        /// </summary>
        public string MaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0203094 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0203094 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0203094 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X5 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)5  0203095
        /// </summary>
        public string BaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0203095 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0203095 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0203095 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y5 { get; set; }
        /// <summary>
        /// Y向最大层间位移角5  0203096
        /// </summary>
        public string MaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0203096 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0203096 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0203096 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y5 { get; set; }
        /// <summary>
        /// 时程分析波名6  0203097
        /// </summary>
        public string TimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0203097 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0203097 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0203097 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName6 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)6  0203098
        /// </summary>
        public string BaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0203098 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0203098 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0203098 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X6 { get; set; }
        /// <summary>
        /// X向最大层间位移角6  0203099
        /// </summary>
        public string MaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0203099 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0203099 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0203099 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X6 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)6  0203100
        /// </summary>
        public string BaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0203100 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0203100 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0203100 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y6 { get; set; }
        /// <summary>
        /// Y向最大层间位移角6  0203101
        /// </summary>
        public string MaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0203101 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0203101 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0203101 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y6 { get; set; }
        /// <summary>
        /// 时程分析波名7  0203102
        /// </summary>
        public string TimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0203102 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0203102 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0203102 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName7 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)7  0203103
        /// </summary>
        public string BaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0203103 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0203103 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0203103 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X7 { get; set; }
        /// <summary>
        /// X向最大层间位移角7  0203104
        /// </summary>
        public string MaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0203104 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0203104 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0203104 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X7 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)7  0203105
        /// </summary>
        public string BaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0203105 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0203105 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0203105 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y7 { get; set; }
        /// <summary>
        /// Y向最大层间位移角7  0203106
        /// </summary>
        public string MaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0203106 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0203106 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0203106 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y7 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0203107
        /// </summary>
        public string BaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0203107 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0203107 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0203107 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X_Avg { get; set; }
        /// <summary>
        /// X向最大层间位移角_各波平均值  0203108
        /// </summary>
        public string MaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0203108 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0203108 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0203108 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X_Avg { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0203109
        /// </summary>
        public string BaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0203109 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0203109 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0203109 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y_Avg { get; set; }
        /// <summary>
        /// Y向最大层间位移角_各波平均值  0203110
        /// </summary>
        public string MaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0203110 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0203110 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0203110 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y_Avg { get; set; }
        /// <summary>
        /// 结构专业设计主要特点  0203111
        /// </summary>
        public string StructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0203111 数据类别
        /// </summary>
        public string RecordTypeStructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0203111 是否必填
        /// </summary>
        public bool? IsRequiredStructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0203111 是否公开
        /// </summary>
        public bool? IsPublicStructuralFeatures { get; set; }
        /// <summary>
        /// 曾获奖项  0203112
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0203112 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0203112 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0203112 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  0203113
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0203113 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0203113 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0203113 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0203114
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0203114 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0203114 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0203114 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }


    /// <summary>
    /// 居住建筑—技术申报内容—设备
    /// </summary>
    [Serializable]
    public class Template_0204 : TemplateBase
    {
        /// <summary>
        /// 供暖方式  0204001
        /// </summary>
        public string HeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0204001 数据类别
        /// </summary>
        public string RecordTypeHeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0204001 是否必填
        /// </summary>
        public bool? IsRequiredHeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0204001 是否公开
        /// </summary>
        public bool? IsPublicHeatingMode { get; set; }
        /// <summary>
        /// 供暖建筑面积  0204002
        /// </summary>
        public string HeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0204002 数据类别
        /// </summary>
        public string RecordTypeHeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0204002 是否必填
        /// </summary>
        public bool? IsRequiredHeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0204002 是否公开
        /// </summary>
        public bool? IsPublicHeatingConstructionArea { get; set; }
        /// <summary>
        /// 供暖热负荷  0204003
        /// </summary>
        public string SpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0204003 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0204003 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0204003 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoad { get; set; }
        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0204004
        /// </summary>
        public string SpaceHeatingLoadIndicators_TotalArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0204004 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoadIndicators_TotalArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0204004 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoadIndicators_TotalArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0204004 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoadIndicators_TotalArea { get; set; }
        /// <summary>
        /// 供暖热负荷指标_空调建筑面积  0204004
        /// </summary>
        public string SpaceHeatingLoadIndicators_AirConArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_空调建筑面积  0204004 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoadIndicators_AirConArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_空调建筑面积  0204004 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoadIndicators_AirConArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_空调建筑面积  0204004 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoadIndicators_AirConArea { get; set; }
        /// <summary>
        /// 空调系统形式  0204005
        /// </summary>
        public string AirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0204005 数据类别
        /// </summary>
        public string RecordTypeAirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0204005 是否必填
        /// </summary>
        public bool? IsRequiredAirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0204005 是否公开
        /// </summary>
        public bool? IsPublicAirConSysMode { get; set; }
        /// <summary>
        /// 空调建筑面积  0204006
        /// </summary>
        public string AirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0204006 数据类别
        /// </summary>
        public string RecordTypeAirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0204006 是否必填
        /// </summary>
        public bool? IsRequiredAirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0204006 是否公开
        /// </summary>
        public bool? IsPublicAirConBuildingArea { get; set; }
        /// <summary>
        /// 空调冷负荷  0204007
        /// </summary>
        public string AirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0204007 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0204007 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0204007 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingLoad { get; set; }
        /// <summary>
        /// 空调冷指标_总建筑面积  0204008
        /// </summary>
        public string AirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0204008 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0204008 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0204008 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingIndicators_TotalArea { get; set; }
        /// <summary>
        /// 空调冷指标_空调建筑面积  0204009
        /// </summary>
        public string AirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0204009 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0204009 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0204009 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingIndicators_AirConArea { get; set; }
        /// <summary>
        /// 空调热负荷  0204010
        /// </summary>
        public string AirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0204010 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0204010 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0204010 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingLoad { get; set; }
        /// <summary>
        /// 空调热指标_总建筑面积  0204011
        /// </summary>
        public string AirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0204011 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0204011 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0204011 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingIndicators_TotalArea { get; set; }
        /// <summary>
        /// 空调热指标_空调建筑面积  0204012
        /// </summary>
        public string AirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0204012 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0204012 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0204012 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingIndicators_AirConArea { get; set; }
        /// <summary>
        /// 冷水机组类型1  0204013
        /// </summary>
        public string ChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0204013 数据类别
        /// </summary>
        public string RecordTypeChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0204013 是否必填
        /// </summary>
        public bool? IsRequiredChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0204013 是否公开
        /// </summary>
        public bool? IsPublicChillerType1 { get; set; }
        /// <summary>
        /// 单台设计制冷量1  0204014
        /// </summary>
        public string ChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0204014 数据类别
        /// </summary>
        public string RecordTypeChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0204014 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0204014 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput1 { get; set; }
        /// <summary>
        /// 冷水机组台数1  0204015
        /// </summary>
        public string ChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0204015 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0204015 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0204015 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity1 { get; set; }
        /// <summary>
        /// 冷水机组类型2  0204016
        /// </summary>
        public string ChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0204016 数据类别
        /// </summary>
        public string RecordTypeChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0204016 是否必填
        /// </summary>
        public bool? IsRequiredChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0204016 是否公开
        /// </summary>
        public bool? IsPublicChillerType2 { get; set; }
        /// <summary>
        /// 单台设计制冷量2  0204017
        /// </summary>
        public string ChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0204017 数据类别
        /// </summary>
        public string RecordTypeChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0204017 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0204017 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput2 { get; set; }
        /// <summary>
        /// 冷水机组台数2  0204018
        /// </summary>
        public string ChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0204018 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0204018 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0204018 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity2 { get; set; }
        /// <summary>
        /// 冷水机组类型3  0204019
        /// </summary>
        public string ChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0204019 数据类别
        /// </summary>
        public string RecordTypeChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0204019 是否必填
        /// </summary>
        public bool? IsRequiredChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0204019 是否公开
        /// </summary>
        public bool? IsPublicChillerType3 { get; set; }
        /// <summary>
        /// 单台设计制冷量3  0204020
        /// </summary>
        public string ChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0204020 数据类别
        /// </summary>
        public string RecordTypeChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0204020 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0204020 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput3 { get; set; }
        /// <summary>
        /// 冷水机组台数3  0204021
        /// </summary>
        public string ChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0204021 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0204021 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0204021 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity3 { get; set; }
        /// <summary>
        /// 制热设备类型1  0204022
        /// </summary>
        public string HeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0204022 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0204022 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0204022 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType1 { get; set; }
        /// <summary>
        /// 单台设计供热量1  0204023
        /// </summary>
        public string HeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0204023 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0204023 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0204023 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput1 { get; set; }
        /// <summary>
        /// 制热设备台数1  0204024
        /// </summary>
        public string HeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0204024 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0204024 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0204024 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity1 { get; set; }
        /// <summary>
        /// 制热设备类型2  0204025
        /// </summary>
        public string HeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0204025 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0204025 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0204025 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType2 { get; set; }
        /// <summary>
        /// 单台设计供热量2  0204026
        /// </summary>
        public string HeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0204026 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0204026 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0204026 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput2 { get; set; }
        /// <summary>
        /// 制热设备台数2  0204027
        /// </summary>
        public string HeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0204027 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0204027 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0204027 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity2 { get; set; }
        /// <summary>
        /// 制热设备类型3  0204028
        /// </summary>
        public string HeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0204028 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0204028 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0204028 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType3 { get; set; }
        /// <summary>
        /// 单台设计供热量3  0204029
        /// </summary>
        public string HeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0204029 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0204029 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0204029 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput3 { get; set; }
        /// <summary>
        /// 制热设备台数3  0204030
        /// </summary>
        public string HeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0204030 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0204030 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0204030 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity3 { get; set; }
        /// <summary>
        /// 供暖系统制式  0204031
        /// </summary>
        public string HeatingSystem { get; set; }

        /// <summary>
        /// 供暖系统制式  0204031 数据类别
        /// </summary>
        public string RecordTypeHeatingSystem { get; set; }

        /// <summary>
        /// 供暖系统制式  0204031 是否必填
        /// </summary>
        public bool? IsRequiredHeatingSystem { get; set; }

        /// <summary>
        /// 供暖系统制式  0204031 是否公开
        /// </summary>
        public bool? IsPublicHeatingSystem { get; set; }
        /// <summary>
        /// 空调水系统制式  0204032
        /// </summary>
        public string AirConWaterSystem { get; set; }

        /// <summary>
        /// 空调水系统制式  0204032 数据类别
        /// </summary>
        public string RecordTypeAirConWaterSystem { get; set; }

        /// <summary>
        /// 空调水系统制式  0204032 是否必填
        /// </summary>
        public bool? IsRequiredAirConWaterSystem { get; set; }

        /// <summary>
        /// 空调水系统制式  0204032 是否公开
        /// </summary>
        public bool? IsPublicAirConWaterSystem { get; set; }
        /// <summary>
        /// 给水系统形式  0204033
        /// </summary>
        public string WaterSupplySystem { get; set; }

        /// <summary>
        /// 给水系统形式  0204033 数据类别
        /// </summary>
        public string RecordTypeWaterSupplySystem { get; set; }

        /// <summary>
        /// 给水系统形式  0204033 是否必填
        /// </summary>
        public bool? IsRequiredWaterSupplySystem { get; set; }

        /// <summary>
        /// 给水系统形式  0204033 是否公开
        /// </summary>
        public bool? IsPublicWaterSupplySystem { get; set; }
        /// <summary>
        /// 中水系统形式  0204034
        /// </summary>
        public string ReclaimedWaterSystem { get; set; }

        /// <summary>
        /// 中水系统形式  0204034 数据类别
        /// </summary>
        public string RecordTypeReclaimedWaterSystem { get; set; }

        /// <summary>
        /// 中水系统形式  0204034 是否必填
        /// </summary>
        public bool? IsRequiredReclaimedWaterSystem { get; set; }

        /// <summary>
        /// 中水系统形式  0204034 是否公开
        /// </summary>
        public bool? IsPublicReclaimedWaterSystem { get; set; }
        /// <summary>
        /// 雨、污水系统形式  0204035
        /// </summary>
        public string SewageSystem { get; set; }

        /// <summary>
        /// 雨、污水系统形式  0204035 数据类别
        /// </summary>
        public string RecordTypeSewageSystem { get; set; }

        /// <summary>
        /// 雨、污水系统形式  0204035 是否必填
        /// </summary>
        public bool? IsRequiredSewageSystem { get; set; }

        /// <summary>
        /// 雨、污水系统形式  0204035 是否公开
        /// </summary>
        public bool? IsPublicSewageSystem { get; set; }
        /// <summary>
        /// 消防给水系统形式  0204036
        /// </summary>
        public string FireWaterSupplySystem { get; set; }

        /// <summary>
        /// 消防给水系统形式  0204036 数据类别
        /// </summary>
        public string RecordTypeFireWaterSupplySystem { get; set; }

        /// <summary>
        /// 消防给水系统形式  0204036 是否必填
        /// </summary>
        public bool? IsRequiredFireWaterSupplySystem { get; set; }

        /// <summary>
        /// 消防给水系统形式  0204036 是否公开
        /// </summary>
        public bool? IsPublicFireWaterSupplySystem { get; set; }
        /// <summary>
        /// 设计特点_暖通、空调  0204037
        /// </summary>
        public string Features_HVAC { get; set; }

        /// <summary>
        /// 设计特点_暖通、空调  0204037 数据类别
        /// </summary>
        public string RecordTypeFeatures_HVAC { get; set; }

        /// <summary>
        /// 设计特点_暖通、空调  0204037 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_HVAC { get; set; }

        /// <summary>
        /// 设计特点_暖通、空调  0204037 是否公开
        /// </summary>
        public bool? IsPublicFeatures_HVAC { get; set; }
        /// <summary>
        /// 设计特点_动力  0204038
        /// </summary>
        public string Features_Power { get; set; }

        /// <summary>
        /// 设计特点_动力  0204038 数据类别
        /// </summary>
        public string RecordTypeFeatures_Power { get; set; }

        /// <summary>
        /// 设计特点_动力  0204038 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_Power { get; set; }

        /// <summary>
        /// 设计特点_动力  0204038 是否公开
        /// </summary>
        public bool? IsPublicFeatures_Power { get; set; }
        /// <summary>
        /// 设计特点_给排水  0204039
        /// </summary>
        public string Features_WaterSupplyAndDrainage { get; set; }

        /// <summary>
        /// 设计特点_给排水  0204039 数据类别
        /// </summary>
        public string RecordTypeFeatures_WaterSupplyAndDrainage { get; set; }

        /// <summary>
        /// 设计特点_给排水  0204039 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_WaterSupplyAndDrainage { get; set; }

        /// <summary>
        /// 设计特点_给排水  0204039 是否公开
        /// </summary>
        public bool? IsPublicFeatures_WaterSupplyAndDrainage { get; set; }
        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0204040
        /// </summary>
        public string Features_FireFacilities { get; set; }

        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0204040 数据类别
        /// </summary>
        public string RecordTypeFeatures_FireFacilities { get; set; }

        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0204040 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_FireFacilities { get; set; }

        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0204040 是否公开
        /// </summary>
        public bool? IsPublicFeatures_FireFacilities { get; set; }
    }


    /// <summary>
    /// 居住建筑—技术申报内容—电气
    /// </summary>
    [Serializable]
    public class Template_0205 : TemplateBase
    {
        /// <summary>
        /// 供电电源设计情况  0205001
        /// </summary>
        public string ElectricitySupplyDesign { get; set; }

        /// <summary>
        /// 供电电源设计情况  0205001 数据类别
        /// </summary>
        public string RecordTypeElectricitySupplyDesign { get; set; }

        /// <summary>
        /// 供电电源设计情况  0205001 是否必填
        /// </summary>
        public bool? IsRequiredElectricitySupplyDesign { get; set; }

        /// <summary>
        /// 供电电源设计情况  0205001 是否公开
        /// </summary>
        public bool? IsPublicElectricitySupplyDesign { get; set; }
        /// <summary>
        /// 用电负荷等级确定情况  0205002
        /// </summary>
        public string ElectricityLoadLevels { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0205002 数据类别
        /// </summary>
        public string RecordTypeElectricityLoadLevels { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0205002 是否必填
        /// </summary>
        public bool? IsRequiredElectricityLoadLevels { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0205002 是否公开
        /// </summary>
        public bool? IsPublicElectricityLoadLevels { get; set; }
        /// <summary>
        /// 防雷设计类别及方式  0205003
        /// </summary>
        public string LightningProtection { get; set; }

        /// <summary>
        /// 防雷设计类别及方式  0205003 数据类别
        /// </summary>
        public string RecordTypeLightningProtection { get; set; }

        /// <summary>
        /// 防雷设计类别及方式  0205003 是否必填
        /// </summary>
        public bool? IsRequiredLightningProtection { get; set; }

        /// <summary>
        /// 防雷设计类别及方式  0205003 是否公开
        /// </summary>
        public bool? IsPublicLightningProtection { get; set; }
        /// <summary>
        /// 强电设计  0205004
        /// </summary>
        public string HighVoltageDesign { get; set; }

        /// <summary>
        /// 强电设计  0205004 数据类别
        /// </summary>
        public string RecordTypeHighVoltageDesign { get; set; }

        /// <summary>
        /// 强电设计  0205004 是否必填
        /// </summary>
        public bool? IsRequiredHighVoltageDesign { get; set; }

        /// <summary>
        /// 强电设计  0205004 是否公开
        /// </summary>
        public bool? IsPublicHighVoltageDesign { get; set; }
        /// <summary>
        /// 弱电设计  0205005
        /// </summary>
        public string LowVoltageDesign { get; set; }

        /// <summary>
        /// 弱电设计  0205005 数据类别
        /// </summary>
        public string RecordTypeLowVoltageDesign { get; set; }

        /// <summary>
        /// 弱电设计  0205005 是否必填
        /// </summary>
        public bool? IsRequiredLowVoltageDesign { get; set; }

        /// <summary>
        /// 弱电设计  0205005 是否公开
        /// </summary>
        public bool? IsPublicLowVoltageDesign { get; set; }
        /// <summary>
        /// 电力总用电负荷  0205006
        /// </summary>
        public string TotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0205006 数据类别
        /// </summary>
        public string RecordTypeTotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0205006 是否必填
        /// </summary>
        public bool? IsRequiredTotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0205006 是否公开
        /// </summary>
        public bool? IsPublicTotalElectricityload { get; set; }
        /// <summary>
        /// 照明总用电负荷  0205007
        /// </summary>
        public string TotalLightingLoad { get; set; }

        /// <summary>
        /// 照明总用电负荷  0205007 数据类别
        /// </summary>
        public string RecordTypeTotalLightingLoad { get; set; }

        /// <summary>
        /// 照明总用电负荷  0205007 是否必填
        /// </summary>
        public bool? IsRequiredTotalLightingLoad { get; set; }

        /// <summary>
        /// 照明总用电负荷  0205007 是否公开
        /// </summary>
        public bool? IsPublicTotalLightingLoad { get; set; }
        /// <summary>
        /// 变压器配置  0205008
        /// </summary>
        public string TransformerConfig { get; set; }

        /// <summary>
        /// 变压器配置  0205008 数据类别
        /// </summary>
        public string RecordTypeTransformerConfig { get; set; }

        /// <summary>
        /// 变压器配置  0205008 是否必填
        /// </summary>
        public bool? IsRequiredTransformerConfig { get; set; }

        /// <summary>
        /// 变压器配置  0205008 是否公开
        /// </summary>
        public bool? IsPublicTransformerConfig { get; set; }
        /// <summary>
        /// 变压器配置单位  0205009
        /// </summary>
        public string TransformerConfigUnit { get; set; }

        /// <summary>
        /// 变压器配置单位  0205009 数据类别
        /// </summary>
        public string RecordTypeTransformerConfigUnit { get; set; }

        /// <summary>
        /// 变压器配置单位  0205009 是否必填
        /// </summary>
        public bool? IsRequiredTransformerConfigUnit { get; set; }

        /// <summary>
        /// 变压器配置单位  0205009 是否公开
        /// </summary>
        public bool? IsPublicTransformerConfigUnit { get; set; }
        /// <summary>
        /// 变压器装机密度  0205010
        /// </summary>
        public string TransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0205010 数据类别
        /// </summary>
        public string RecordTypeTransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0205010 是否必填
        /// </summary>
        public bool? IsRequiredTransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0205010 是否公开
        /// </summary>
        public bool? IsPublicTransformerDensity { get; set; }
        /// <summary>
        /// 备用电源设置情况及总容量  0205011
        /// </summary>
        public string StandbyElectricity { get; set; }

        /// <summary>
        /// 备用电源设置情况及总容量  0205011 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricity { get; set; }

        /// <summary>
        /// 备用电源设置情况及总容量  0205011 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricity { get; set; }

        /// <summary>
        /// 备用电源设置情况及总容量  0205011 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricity { get; set; }
        /// <summary>
        /// 备用电源装机密度  0205012
        /// </summary>
        public string StandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0205012 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0205012 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0205012 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensity { get; set; }
        /// <summary>
        /// 备用电源装机密度单位  0205013
        /// </summary>
        public string StandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0205013 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0205013 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0205013 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensityUnit { get; set; }
        /// <summary>
        /// 用电指标_经济适用房  0205014
        /// </summary>
        public string Indicators_AffordableHousing { get; set; }

        /// <summary>
        /// 用电指标_经济适用房  0205014 数据类别
        /// </summary>
        public string RecordTypeIndicators_AffordableHousing { get; set; }

        /// <summary>
        /// 用电指标_经济适用房  0205014 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_AffordableHousing { get; set; }

        /// <summary>
        /// 用电指标_经济适用房  0205014 是否公开
        /// </summary>
        public bool? IsPublicIndicators_AffordableHousing { get; set; }
        /// <summary>
        /// 用电指标_商品房  0205015
        /// </summary>
        public string Indicators_CommercialHousing { get; set; }

        /// <summary>
        /// 用电指标_商品房  0205015 数据类别
        /// </summary>
        public string RecordTypeIndicators_CommercialHousing { get; set; }

        /// <summary>
        /// 用电指标_商品房  0205015 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_CommercialHousing { get; set; }

        /// <summary>
        /// 用电指标_商品房  0205015 是否公开
        /// </summary>
        public bool? IsPublicIndicators_CommercialHousing { get; set; }
        /// <summary>
        /// 用电指标_公寓  0205016
        /// </summary>
        public string Indicators_Apartment { get; set; }

        /// <summary>
        /// 用电指标_公寓  0205016 数据类别
        /// </summary>
        public string RecordTypeIndicators_Apartment { get; set; }

        /// <summary>
        /// 用电指标_公寓  0205016 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Apartment { get; set; }

        /// <summary>
        /// 用电指标_公寓  0205016 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Apartment { get; set; }
        /// <summary>
        /// 用电指标_其他  0205017
        /// </summary>
        public string Indicators_Other { get; set; }

        /// <summary>
        /// 用电指标_其他  0205017 数据类别
        /// </summary>
        public string RecordTypeIndicators_Other { get; set; }

        /// <summary>
        /// 用电指标_其他  0205017 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Other { get; set; }

        /// <summary>
        /// 用电指标_其他  0205017 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Other { get; set; }
        /// <summary>
        /// 用电备注  0205018
        /// </summary>
        public string ElectricityMemo { get; set; }

        /// <summary>
        /// 用电备注  0205018 数据类别
        /// </summary>
        public string RecordTypeElectricityMemo { get; set; }

        /// <summary>
        /// 用电备注  0205018 是否必填
        /// </summary>
        public bool? IsRequiredElectricityMemo { get; set; }

        /// <summary>
        /// 用电备注  0205018 是否公开
        /// </summary>
        public bool? IsPublicElectricityMemo { get; set; }
        /// <summary>
        /// 电气专业设计特点_强电  0205019
        /// </summary>
        public string ElectricityFeatures_HighVoltage { get; set; }

        /// <summary>
        /// 电气专业设计特点_强电  0205019 数据类别
        /// </summary>
        public string RecordTypeElectricityFeatures_HighVoltage { get; set; }

        /// <summary>
        /// 电气专业设计特点_强电  0205019 是否必填
        /// </summary>
        public bool? IsRequiredElectricityFeatures_HighVoltage { get; set; }

        /// <summary>
        /// 电气专业设计特点_强电  0205019 是否公开
        /// </summary>
        public bool? IsPublicElectricityFeatures_HighVoltage { get; set; }
        /// <summary>
        /// 电气专业设计特点_弱电  0205020
        /// </summary>
        public string ElectricityFeatures_LowVoltage { get; set; }

        /// <summary>
        /// 电气专业设计特点_弱电  0205020 数据类别
        /// </summary>
        public string RecordTypeElectricityFeatures_LowVoltage { get; set; }

        /// <summary>
        /// 电气专业设计特点_弱电  0205020 是否必填
        /// </summary>
        public bool? IsRequiredElectricityFeatures_LowVoltage { get; set; }

        /// <summary>
        /// 电气专业设计特点_弱电  0205020 是否公开
        /// </summary>
        public bool? IsPublicElectricityFeatures_LowVoltage { get; set; }
        /// <summary>
        /// 电气专业设计特点_节能  0205021
        /// </summary>
        public string ElectricityFeatures_Efficient { get; set; }

        /// <summary>
        /// 电气专业设计特点_节能  0205021 数据类别
        /// </summary>
        public string RecordTypeElectricityFeatures_Efficient { get; set; }

        /// <summary>
        /// 电气专业设计特点_节能  0205021 是否必填
        /// </summary>
        public bool? IsRequiredElectricityFeatures_Efficient { get; set; }

        /// <summary>
        /// 电气专业设计特点_节能  0205021 是否公开
        /// </summary>
        public bool? IsPublicElectricityFeatures_Efficient { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0205022
        /// </summary>
        public string StandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0205022 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0205022 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0205022 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensityKW { get; set; }
    }


    /// <summary>
    /// 居住建筑—技术申报内容—技术经济指标
    /// </summary>
    [Serializable]
    public class Template_0206 : TemplateBase
    {
        /// <summary>
        /// 单位规模建筑面积指标  0206001
        /// </summary>
        public string UnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0206001 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0206001 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0206001 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicators { get; set; }
        /// <summary>
        /// 单位规模建筑面积指标单位  0206002
        /// </summary>
        public string UnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0206002 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0206002 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0206002 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicatorsUnit { get; set; }
        /// <summary>
        /// 使用面积系数  0206003
        /// </summary>
        public string UseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0206003 数据类别
        /// </summary>
        public string RecordTypeUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0206003 是否必填
        /// </summary>
        public bool? IsRequiredUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0206003 是否公开
        /// </summary>
        public bool? IsPublicUseAreaCoefficient { get; set; }
        /// <summary>
        /// 单位建筑面积耗热量指标  0206004
        /// </summary>
        public string UnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0206004 数据类别
        /// </summary>
        public string RecordTypeUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0206004 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0206004 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaHotConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积耗冷量指标  0206005
        /// </summary>
        public string UnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0206005 数据类别
        /// </summary>
        public string RecordTypeUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0206005 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0206005 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaColdConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积变压器装机容量  0206006
        /// </summary>
        public string UnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0206006 数据类别
        /// </summary>
        public string RecordTypeUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0206006 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0206006 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaTransformerCapacity { get; set; }
        /// <summary>
        /// 日供水量  0206007
        /// </summary>
        public string DailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0206007 数据类别
        /// </summary>
        public string RecordTypeDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0206007 是否必填
        /// </summary>
        public bool? IsRequiredDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0206007 是否公开
        /// </summary>
        public bool? IsPublicDailyWaterSupply { get; set; }
        /// <summary>
        /// 概算_总造价_人民币  0206008
        /// </summary>
        public string Estimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0206008 数据类别
        /// </summary>
        public string RecordTypeEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0206008 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0206008 是否公开
        /// </summary>
        public bool? IsPublicEstimate_RMB { get; set; }
        /// <summary>
        /// 概算_总造价_外币  0206009
        /// </summary>
        public string Estimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0206009 数据类别
        /// </summary>
        public string RecordTypeEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0206009 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0206009 是否公开
        /// </summary>
        public bool? IsPublicEstimate_ForeignCurrency { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0206010
        /// </summary>
        public string Estimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0206010 数据类别
        /// </summary>
        public string RecordTypeEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0206010 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0206010 是否公开
        /// </summary>
        public bool? IsPublicEstimate_CivilEngineering { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0206011
        /// </summary>
        public string Estimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0206011 数据类别
        /// </summary>
        public string RecordTypeEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0206011 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0206011 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Install { get; set; }
        /// <summary>
        /// 概算_单位建筑面积造价  0206012
        /// </summary>
        public string Estimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0206012 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0206012 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0206012 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitAreaRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价  0206013
        /// </summary>
        public string Estimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0206013 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0206013 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0206013 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价单位  0206014
        /// </summary>
        public string Estimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0206014 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0206014 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0206014 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 竣工决算_总造价_人民币  0206015
        /// </summary>
        public string Settlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0206015 数据类别
        /// </summary>
        public string RecordTypeSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0206015 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0206015 是否公开
        /// </summary>
        public bool? IsPublicSettlement_RMB { get; set; }
        /// <summary>
        /// 竣工决算_总造价_外币  0206016
        /// </summary>
        public string Settlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0206016 数据类别
        /// </summary>
        public string RecordTypeSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0206016 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0206016 是否公开
        /// </summary>
        public bool? IsPublicSettlement_ForeignCurrency { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0206017
        /// </summary>
        public string Settlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0206017 数据类别
        /// </summary>
        public string RecordTypeSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0206017 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0206017 是否公开
        /// </summary>
        public bool? IsPublicSettlement_CivilEngineering { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0206018
        /// </summary>
        public string Settlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0206018 数据类别
        /// </summary>
        public string RecordTypeSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0206018 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0206018 是否公开
        /// </summary>
        public bool? IsPublicSettlement_Install { get; set; }
        /// <summary>
        /// 竣工决算_单位建筑面积造价  0206019
        /// </summary>
        public string Settlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0206019 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0206019 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0206019 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitAreaRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价  0206020
        /// </summary>
        public string Settlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0206020 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0206020 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0206020 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价单位  0206021
        /// </summary>
        public string Settlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0206021 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0206021 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0206021 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 结算与概算出入的主要原因  0206022
        /// </summary>
        public string Estimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0206022 数据类别
        /// </summary>
        public string RecordTypeEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0206022 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0206022 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Settlement_Difference { get; set; }
        /// <summary>
        /// 经济专业主要特点  0206023
        /// </summary>
        public string EconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0206023 数据类别
        /// </summary>
        public string RecordTypeEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0206023 是否必填
        /// </summary>
        public bool? IsRequiredEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0206023 是否公开
        /// </summary>
        public bool? IsPublicEconomicsFeatures { get; set; }
    }

}
