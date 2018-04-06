using System;

namespace Dal.Models
{
    /// <summary>
    /// 公建模板
    /// </summary>
    [Serializable]
    public class Template_01_PublicBuilding : TemplateBase
    {
        /// <summary>
        /// 公建模板—基础信息
        /// </summary>
        public Template_0101 Part_01 { get; set; }

        /// <summary>
        /// 公建模板—技术申报内容—建筑
        /// </summary>
        public Template_0102 Part_02 { get; set; }

        /// <summary>
        /// 公建模板—技术申报内容—结构
        /// </summary>
        public Template_0103 Part_03 { get; set; }

        /// <summary>
        /// 公建模板—技术申报内容—设备
        /// </summary>
        public Template_0104 Part_04 { get; set; }

        /// <summary>
        /// 公建模板—技术申报内容—电气
        /// </summary>
        public Template_0105 Part_05 { get; set; }

        /// <summary>
        /// 公建模板-专业技术指标（电气专业）
        /// </summary>
        public Template_0106 Part_06 { get; set; }
        /// <summary>
        /// 公建模板—技术申报内容—技术经济指标
        /// </summary>
        public Template_0107 Part_07 { get; set; }
    }

    /// <summary>
    /// 公建模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_0101 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  0101001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0101001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0101001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0101001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  0101002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0101002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0101002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0101002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  0101003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0101003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0101003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0101003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0101004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0101004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0101004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0101004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0101005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0101005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0101005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0101005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0101006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0101006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0101006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0101006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0101007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0101007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0101007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0101007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0101008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0101008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0101008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0101008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0101009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0101009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0101009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0101009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0101010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0101010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0101010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0101010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0101011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0101011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0101011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0101011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0101012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0101012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0101012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0101012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0101013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0101013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0101013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0101013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0101014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0101014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0101014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0101014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0101015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0101015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0101015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0101015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0101016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0101016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0101016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0101016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0101017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0101017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0101017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0101017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0101018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0101018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0101018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0101018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0101019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0101019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0101019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0101019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0101020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0101020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0101020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0101020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0101021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0101021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0101021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0101021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0101022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0101022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0101022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0101022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  0101023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0101023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0101023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0101023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0101024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0101024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0101024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0101024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  0101025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  0101025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0101025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0101025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  0101026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0101026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0101026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0101026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  0101027
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0101027 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0101027 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0101027 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0101028
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0101028 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0101028 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0101028 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0101029
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0101029 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0101029 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0101029 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  0101030
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0101030 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0101030 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0101030 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  0101031
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0101031 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0101031 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0101031 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0101032
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0101032 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0101032 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0101032 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  0101033
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0101033 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0101033 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0101033 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  0101034
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0101034 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0101034 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0101034 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  0101035
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0101035 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0101035 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0101035 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 投资来源  0101036
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 投资来源  0101036 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 投资来源  0101036 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 投资来源  0101036 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  0101037
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0101037 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0101037 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  0101037 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }

        /// <summary>
        /// 专业类别  0101038
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0101038 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0101038 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别  0101038 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }
        /// <summary>
        /// 单位资质  0101039
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0101039 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0101039 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0101039 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  0101040
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0101040 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0101040 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0101040 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

        /// <summary>
        /// 申报材料目录  0101041
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0101041 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0101041 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0101041 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }

    }


    /// <summary>
    /// 公建模板—技术申报内容—建筑
    /// </summary>
    [Serializable]
    public class Template_0102 : TemplateBase
    {
        /// <summary>
        /// 建筑功能（使用性质）_地上  0102001
        /// </summary>
        public string UseProperty_Ground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0102001 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Ground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0102001 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Ground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0102001 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Ground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  0102002
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0102002 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0102002 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0102002 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  0102003
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  0102003 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  0102003 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  0102003 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  0102004
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0102004 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0102004 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0102004 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总用地面积  0102005
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0102005 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0102005 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0102005 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 代征地面积  0102006
        /// </summary>
        public string ExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0102006 数据类别
        /// </summary>
        public string RecordTypeExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0102006 是否必填
        /// </summary>
        public bool? IsRequiredExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0102006 是否公开
        /// </summary>
        public bool? IsPublicExpropriationArea { get; set; }
        /// <summary>
        /// 建设用地面积  0102007
        /// </summary>
        public string ConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0102007 数据类别
        /// </summary>
        public string RecordTypeConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0102007 是否必填
        /// </summary>
        public bool? IsRequiredConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0102007 是否公开
        /// </summary>
        public bool? IsPublicConstructionArea { get; set; }
        /// <summary>
        /// 总建筑面积  0102008
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0102008 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0102008 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0102008 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 地上面积  0102009
        /// </summary>
        public string OvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0102009 数据类别
        /// </summary>
        public string RecordTypeOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0102009 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0102009 是否公开
        /// </summary>
        public bool? IsPublicOvergroundArea { get; set; }
        /// <summary>
        /// 地下面积  0102010
        /// </summary>
        public string UndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0102010 数据类别
        /// </summary>
        public string RecordTypeUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0102010 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0102010 是否公开
        /// </summary>
        public bool? IsPublicUndergroundArea { get; set; }
        /// <summary>
        /// 建筑基底面积  0102011
        /// </summary>
        public string BuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0102011 数据类别
        /// </summary>
        public string RecordTypeBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0102011 是否必填
        /// </summary>
        public bool? IsRequiredBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0102011 是否公开
        /// </summary>
        public bool? IsPublicBuildingArea { get; set; }
        /// <summary>
        /// 绿地面积  0102012
        /// </summary>
        public string GreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0102012 数据类别
        /// </summary>
        public string RecordTypeGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0102012 是否必填
        /// </summary>
        public bool? IsRequiredGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0102012 是否公开
        /// </summary>
        public bool? IsPublicGreenArea { get; set; }
        /// <summary>
        /// 绿化率  0102013
        /// </summary>
        public string GreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0102013 数据类别
        /// </summary>
        public string RecordTypeGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0102013 是否必填
        /// </summary>
        public bool? IsRequiredGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0102013 是否公开
        /// </summary>
        public bool? IsPublicGreeningRate { get; set; }
        /// <summary>
        /// 容积率  0102014
        /// </summary>
        public string PlotRatio { get; set; }

        /// <summary>
        /// 容积率  0102014 数据类别
        /// </summary>
        public string RecordTypePlotRatio { get; set; }

        /// <summary>
        /// 容积率  0102014 是否必填
        /// </summary>
        public bool? IsRequiredPlotRatio { get; set; }

        /// <summary>
        /// 容积率  0102014 是否公开
        /// </summary>
        public bool? IsPublicPlotRatio { get; set; }
        /// <summary>
        /// 建筑密度  0102015
        /// </summary>
        public string BuildingDensity { get; set; }

        /// <summary>
        /// 建筑密度  0102015 数据类别
        /// </summary>
        public string RecordTypeBuildingDensity { get; set; }

        /// <summary>
        /// 建筑密度  0102015 是否必填
        /// </summary>
        public bool? IsRequiredBuildingDensity { get; set; }

        /// <summary>
        /// 建筑密度  0102015 是否公开
        /// </summary>
        public bool? IsPublicBuildingDensity { get; set; }
        /// <summary>
        /// 建筑分类  0102016
        /// </summary>
        public string BuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类  0102016 数据类别
        /// </summary>
        public string RecordTypeBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类  0102016 是否必填
        /// </summary>
        public bool? IsRequiredBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类  0102016 是否公开
        /// </summary>
        public bool? IsPublicBuildingClassification { get; set; }
        /// <summary>
        /// 耐火等级  0102017
        /// </summary>
        public string FireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0102017 数据类别
        /// </summary>
        public string RecordTypeFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0102017 是否必填
        /// </summary>
        public bool? IsRequiredFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0102017 是否公开
        /// </summary>
        public bool? IsPublicFireResistanceRating { get; set; }
        /// <summary>
        /// 建筑高度  0102018
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0102018 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0102018 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0102018 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 地上层数  0102019
        /// </summary>
        public string GroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0102019 数据类别
        /// </summary>
        public string RecordTypeGroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0102019 是否必填
        /// </summary>
        public bool? IsRequiredGroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0102019 是否公开
        /// </summary>
        public bool? IsPublicGroundLayerCount { get; set; }
        /// <summary>
        /// 地下层数  0102020
        /// </summary>
        public string UndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0102020 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0102020 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0102020 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayerCount { get; set; }
        /// <summary>
        /// 机动车停车计  0102021
        /// </summary>
        public string AutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停车计  0102021 数据类别
        /// </summary>
        public string RecordTypeAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停车计  0102021 是否必填
        /// </summary>
        public bool? IsRequiredAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停车计  0102021 是否公开
        /// </summary>
        public bool? IsPublicAutoParkingCount { get; set; }
        /// <summary>
        /// 地上停车（机动车）  0102022
        /// </summary>
        public string GroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0102022 数据类别
        /// </summary>
        public string RecordTypeGroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0102022 是否必填
        /// </summary>
        public bool? IsRequiredGroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0102022 是否公开
        /// </summary>
        public bool? IsPublicGroundAutoParkingCount { get; set; }
        /// <summary>
        /// 地下停车（机动车）  0102023
        /// </summary>
        public string UndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0102023 数据类别
        /// </summary>
        public string RecordTypeUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0102023 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0102023 是否公开
        /// </summary>
        public bool? IsPublicUndergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 自行车停车计  0102024
        /// </summary>
        public string BicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车计  0102024 数据类别
        /// </summary>
        public string RecordTypeBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车计  0102024 是否必填
        /// </summary>
        public bool? IsRequiredBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车计  0102024 是否公开
        /// </summary>
        public bool? IsPublicBicycleParkingCount { get; set; }
        /// <summary>
        /// 地上停车（自行车）  0102025
        /// </summary>
        public string GroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0102025 数据类别
        /// </summary>
        public string RecordTypeGroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0102025 是否必填
        /// </summary>
        public bool? IsRequiredGroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0102025 是否公开
        /// </summary>
        public bool? IsPublicGroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 地下停车（自行车）  0102026
        /// </summary>
        public string UndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0102026 数据类别
        /// </summary>
        public string RecordTypeUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0102026 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0102026 是否公开
        /// </summary>
        public bool? IsPublicUndergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 防空地下室_建筑面积  0102027
        /// </summary>
        public string Basement_ConstructionArea { get; set; }

        /// <summary>
        /// 防空地下室_建筑面积  0102027 数据类别
        /// </summary>
        public string RecordTypeBasement_ConstructionArea { get; set; }

        /// <summary>
        /// 防空地下室_建筑面积  0102027 是否必填
        /// </summary>
        public bool? IsRequiredBasement_ConstructionArea { get; set; }

        /// <summary>
        /// 防空地下室_建筑面积  0102027 是否公开
        /// </summary>
        public bool? IsPublicBasement_ConstructionArea { get; set; }
        /// <summary>
        /// 防空地下室_战时用途  0102028
        /// </summary>
        public string Basement_WartimeUse { get; set; }

        /// <summary>
        /// 防空地下室_战时用途  0102028 数据类别
        /// </summary>
        public string RecordTypeBasement_WartimeUse { get; set; }

        /// <summary>
        /// 防空地下室_战时用途  0102028 是否必填
        /// </summary>
        public bool? IsRequiredBasement_WartimeUse { get; set; }

        /// <summary>
        /// 防空地下室_战时用途  0102028 是否公开
        /// </summary>
        public bool? IsPublicBasement_WartimeUse { get; set; }
        /// <summary>
        /// 防空地下室_平时用途  0102029
        /// </summary>
        public string Basement_UsuallyUse { get; set; }

        /// <summary>
        /// 防空地下室_平时用途  0102029 数据类别
        /// </summary>
        public string RecordTypeBasement_UsuallyUse { get; set; }

        /// <summary>
        /// 防空地下室_平时用途  0102029 是否必填
        /// </summary>
        public bool? IsRequiredBasement_UsuallyUse { get; set; }

        /// <summary>
        /// 防空地下室_平时用途  0102029 是否公开
        /// </summary>
        public bool? IsPublicBasement_UsuallyUse { get; set; }
        /// <summary>
        /// 防空地下室_抗力级别  0102030
        /// </summary>
        public string Basement_ResistanceLevel { get; set; }

        /// <summary>
        /// 防空地下室_抗力级别  0102030 数据类别
        /// </summary>
        public string RecordTypeBasement_ResistanceLevel { get; set; }

        /// <summary>
        /// 防空地下室_抗力级别  0102030 是否必填
        /// </summary>
        public bool? IsRequiredBasement_ResistanceLevel { get; set; }

        /// <summary>
        /// 防空地下室_抗力级别  0102030 是否公开
        /// </summary>
        public bool? IsPublicBasement_ResistanceLevel { get; set; }
        /// <summary>
        /// 防空地下室_防化级别  0102031
        /// </summary>
        public string Basement_AntichemicalLevel { get; set; }

        /// <summary>
        /// 防空地下室_防化级别  0102031 数据类别
        /// </summary>
        public string RecordTypeBasement_AntichemicalLevel { get; set; }

        /// <summary>
        /// 防空地下室_防化级别  0102031 是否必填
        /// </summary>
        public bool? IsRequiredBasement_AntichemicalLevel { get; set; }

        /// <summary>
        /// 防空地下室_防化级别  0102031 是否公开
        /// </summary>
        public bool? IsPublicBasement_AntichemicalLevel { get; set; }

        ///// <summary>
        ///// 住宅用地  0102032
        ///// </summary>
        //public string ResidentialLand { get; set; }

        ///// <summary>
        ///// 住宅用地  0102032 数据类别
        ///// </summary>
        //public string RecordTypeResidentialLand { get; set; }

        ///// <summary>
        ///// 住宅用地  0102032 是否必填
        ///// </summary>
        //public bool? IsRequiredResidentialLand { get; set; }

        ///// <summary>
        ///// 住宅用地  0102032 是否公开
        ///// </summary>
        //public bool? IsPublicResidentialLand { get; set; }
        ///// <summary>
        ///// 配套公建用地  0102033
        ///// </summary>
        //public string SupportingConstructionLand { get; set; }

        ///// <summary>
        ///// 配套公建用地  0102033 数据类别
        ///// </summary>
        //public string RecordTypeSupportingConstructionLand { get; set; }

        ///// <summary>
        ///// 配套公建用地  0102033 是否必填
        ///// </summary>
        //public bool? IsRequiredSupportingConstructionLand { get; set; }

        ///// <summary>
        ///// 配套公建用地  0102033 是否公开
        ///// </summary>
        //public bool? IsPublicSupportingConstructionLand { get; set; }
        ///// <summary>
        ///// 非配套公建用地  0102034
        ///// </summary>
        //public string NonMatchingConstructionLand { get; set; }

        ///// <summary>
        ///// 非配套公建用地  0102034 数据类别
        ///// </summary>
        //public string RecordTypeNonMatchingConstructionLand { get; set; }

        ///// <summary>
        ///// 非配套公建用地  0102034 是否必填
        ///// </summary>
        //public bool? IsRequiredNonMatchingConstructionLand { get; set; }

        ///// <summary>
        ///// 非配套公建用地  0102034 是否公开
        ///// </summary>
        //public bool? IsPublicNonMatchingConstructionLand { get; set; }
        ///// <summary>
        ///// 道路用地  0102035
        ///// </summary>
        //public string LandForRoads { get; set; }

        ///// <summary>
        ///// 道路用地  0102035 数据类别
        ///// </summary>
        //public string RecordTypeLandForRoads { get; set; }

        ///// <summary>
        ///// 道路用地  0102035 是否必填
        ///// </summary>
        //public bool? IsRequiredLandForRoads { get; set; }

        ///// <summary>
        ///// 道路用地  0102035 是否公开
        ///// </summary>
        //public bool? IsPublicLandForRoads { get; set; }
        ///// <summary>
        ///// 公共绿地  0102036
        ///// </summary>
        //public string GreenSpace { get; set; }

        ///// <summary>
        ///// 公共绿地  0102036 数据类别
        ///// </summary>
        //public string RecordTypeGreenSpace { get; set; }

        ///// <summary>
        ///// 公共绿地  0102036 是否必填
        ///// </summary>
        //public bool? IsRequiredGreenSpace { get; set; }

        ///// <summary>
        ///// 公共绿地  0102036 是否公开
        ///// </summary>
        //public bool? IsPublicGreenSpace { get; set; }
        ///// <summary>
        ///// 配套公建面积  0102037
        ///// </summary>
        //public string SupportingConstructionArea { get; set; }

        ///// <summary>
        ///// 配套公建面积  0102037 数据类别
        ///// </summary>
        //public string RecordTypeSupportingConstructionArea { get; set; }

        ///// <summary>
        ///// 配套公建面积  0102037 是否必填
        ///// </summary>
        //public bool? IsRequiredSupportingConstructionArea { get; set; }

        ///// <summary>
        ///// 配套公建面积  0102037 是否公开
        ///// </summary>
        //public bool? IsPublicSupportingConstructionArea { get; set; }
        ///// <summary>
        ///// 非配套公建面积  0102038
        ///// </summary>
        //public string NonMatchingConstructionArea { get; set; }

        ///// <summary>
        ///// 非配套公建面积  0102038 数据类别
        ///// </summary>
        //public string RecordTypeNonMatchingConstructionArea { get; set; }

        ///// <summary>
        ///// 非配套公建面积  0102038 是否必填
        ///// </summary>
        //public bool? IsRequiredNonMatchingConstructionArea { get; set; }

        ///// <summary>
        ///// 非配套公建面积  0102038 是否公开
        ///// </summary>
        //public bool? IsPublicNonMatchingConstructionArea { get; set; }
        ///// <summary>
        ///// 居住建筑面积  0102039
        ///// </summary>
        //public string ResidentialBuildingArea { get; set; }

        ///// <summary>
        ///// 居住建筑面积  0102039 数据类别
        ///// </summary>
        //public string RecordTypeResidentialBuildingArea { get; set; }

        ///// <summary>
        ///// 居住建筑面积  0102039 是否必填
        ///// </summary>
        //public bool? IsRequiredResidentialBuildingArea { get; set; }

        ///// <summary>
        ///// 居住建筑面积  0102039 是否公开
        ///// </summary>
        //public bool? IsPublicResidentialBuildingArea { get; set; }
        ///// <summary>
        ///// 平均每套建筑面积  0102040
        ///// </summary>
        //public string AverageAreaPerSet { get; set; }

        ///// <summary>
        ///// 平均每套建筑面积  0102040 数据类别
        ///// </summary>
        //public string RecordTypeAverageAreaPerSet { get; set; }

        ///// <summary>
        ///// 平均每套建筑面积  0102040 是否必填
        ///// </summary>
        //public bool? IsRequiredAverageAreaPerSet { get; set; }

        ///// <summary>
        ///// 平均每套建筑面积  0102040 是否公开
        ///// </summary>
        //public bool? IsPublicAverageAreaPerSet { get; set; }
        ///// <summary>
        ///// 总居住户数  0102041
        ///// </summary>
        //public string TotalHousehold { get; set; }

        ///// <summary>
        ///// 总居住户数  0102041 数据类别
        ///// </summary>
        //public string RecordTypeTotalHousehold { get; set; }

        ///// <summary>
        ///// 总居住户数  0102041 是否必填
        ///// </summary>
        //public bool? IsRequiredTotalHousehold { get; set; }

        ///// <summary>
        ///// 总居住户数  0102041 是否公开
        ///// </summary>
        //public bool? IsPublicTotalHousehold { get; set; }
        ///// <summary>
        ///// 每户人均数  0102042
        ///// </summary>
        //public string AveragePersonPerHousehold { get; set; }

        ///// <summary>
        ///// 每户人均数  0102042 数据类别
        ///// </summary>
        //public string RecordTypeAveragePersonPerHousehold { get; set; }

        ///// <summary>
        ///// 每户人均数  0102042 是否必填
        ///// </summary>
        //public bool? IsRequiredAveragePersonPerHousehold { get; set; }

        ///// <summary>
        ///// 每户人均数  0102042 是否公开
        ///// </summary>
        //public bool? IsPublicAveragePersonPerHousehold { get; set; }
        ///// <summary>
        ///// 总居住人数  0102043
        ///// </summary>
        //public string TotalPerson { get; set; }

        ///// <summary>
        ///// 总居住人数  0102043 数据类别
        ///// </summary>
        //public string RecordTypeTotalPerson { get; set; }

        ///// <summary>
        ///// 总居住人数  0102043 是否必填
        ///// </summary>
        //public bool? IsRequiredTotalPerson { get; set; }

        ///// <summary>
        ///// 总居住人数  0102043 是否公开
        ///// </summary>
        //public bool? IsPublicTotalPerson { get; set; }
        ///// <summary>
        ///// 公共人均绿地  0102044
        ///// </summary>
        //public string PerPersonGreenSpace { get; set; }

        ///// <summary>
        ///// 公共人均绿地  0102044 数据类别
        ///// </summary>
        //public string RecordTypePerPersonGreenSpace { get; set; }

        ///// <summary>
        ///// 公共人均绿地  0102044 是否必填
        ///// </summary>
        //public bool? IsRequiredPerPersonGreenSpace { get; set; }

        ///// <summary>
        ///// 公共人均绿地  0102044 是否公开
        ///// </summary>
        //public bool? IsPublicPerPersonGreenSpace { get; set; }
        ///// <summary>
        ///// 机动车指标  0102045
        ///// </summary>
        //public string VehicleIndicators { get; set; }

        ///// <summary>
        ///// 机动车指标  0102045 数据类别
        ///// </summary>
        //public string RecordTypeVehicleIndicators { get; set; }

        ///// <summary>
        ///// 机动车指标  0102045 是否必填
        ///// </summary>
        //public bool? IsRequiredVehicleIndicators { get; set; }

        ///// <summary>
        ///// 机动车指标  0102045 是否公开
        ///// </summary>
        //public bool? IsPublicVehicleIndicators { get; set; }
        ///// <summary>
        ///// 自行车指标  0102046
        ///// </summary>
        //public string BicycleIndicators { get; set; }

        ///// <summary>
        ///// 自行车指标  0102046 数据类别
        ///// </summary>
        //public string RecordTypeBicycleIndicators { get; set; }

        ///// <summary>
        ///// 自行车指标  0102046 是否必填
        ///// </summary>
        //public bool? IsRequiredBicycleIndicators { get; set; }

        ///// <summary>
        ///// 自行车指标  0102046 是否公开
        ///// </summary>
        //public bool? IsPublicBicycleIndicators { get; set; }
        ///// <summary>
        ///// 住宅类型_总栋数  0102047
        ///// </summary>
        //public string BuildingCount { get; set; }

        ///// <summary>
        ///// 住宅类型_总栋数  0102047 数据类别
        ///// </summary>
        //public string RecordTypeBuildingCount { get; set; }

        ///// <summary>
        ///// 住宅类型_总栋数  0102047 是否必填
        ///// </summary>
        //public bool? IsRequiredBuildingCount { get; set; }

        ///// <summary>
        ///// 住宅类型_总栋数  0102047 是否公开
        ///// </summary>
        //public bool? IsPublicBuildingCount { get; set; }
        ///// <summary>
        ///// 住宅类型_保障房  0102048
        ///// </summary>
        //public string SecurityHousing { get; set; }

        ///// <summary>
        ///// 住宅类型_保障房  0102048 数据类别
        ///// </summary>
        //public string RecordTypeSecurityHousing { get; set; }

        ///// <summary>
        ///// 住宅类型_保障房  0102048 是否必填
        ///// </summary>
        //public bool? IsRequiredSecurityHousing { get; set; }

        ///// <summary>
        ///// 住宅类型_保障房  0102048 是否公开
        ///// </summary>
        //public bool? IsPublicSecurityHousing { get; set; }
        ///// <summary>
        ///// 住宅类型_商品房  0102049
        ///// </summary>
        //public string CommercialHousing { get; set; }

        ///// <summary>
        ///// 住宅类型_商品房  0102049 数据类别
        ///// </summary>
        //public string RecordTypeCommercialHousing { get; set; }

        ///// <summary>
        ///// 住宅类型_商品房  0102049 是否必填
        ///// </summary>
        //public bool? IsRequiredCommercialHousing { get; set; }

        ///// <summary>
        ///// 住宅类型_商品房  0102049 是否公开
        ///// </summary>
        //public bool? IsPublicCommercialHousing { get; set; }
        ///// <summary>
        ///// 住宅类型_公寓  0102050
        ///// </summary>
        //public string Apartment { get; set; }

        ///// <summary>
        ///// 住宅类型_公寓  0102050 数据类别
        ///// </summary>
        //public string RecordTypeApartment { get; set; }

        ///// <summary>
        ///// 住宅类型_公寓  0102050 是否必填
        ///// </summary>
        //public bool? IsRequiredApartment { get; set; }

        ///// <summary>
        ///// 住宅类型_公寓  0102050 是否公开
        ///// </summary>
        //public bool? IsPublicApartment { get; set; }
        ///// <summary>
        ///// 住宅类型_其他  0102051
        ///// </summary>
        //public string OtherResidentialType { get; set; }

        ///// <summary>
        ///// 住宅类型_其他  0102051 数据类别
        ///// </summary>
        //public string RecordTypeOtherResidentialType { get; set; }

        ///// <summary>
        ///// 住宅类型_其他  0102051 是否必填
        ///// </summary>
        //public bool? IsRequiredOtherResidentialType { get; set; }

        ///// <summary>
        ///// 住宅类型_其他  0102051 是否公开
        ///// </summary>
        //public bool? IsPublicOtherResidentialType { get; set; }
        ///// <summary>
        ///// 保障房_限价商品房  0102052
        ///// </summary>
        //public string CappedPriceHousing { get; set; }

        ///// <summary>
        ///// 保障房_限价商品房  0102052 数据类别
        ///// </summary>
        //public string RecordTypeCappedPriceHousing { get; set; }

        ///// <summary>
        ///// 保障房_限价商品房  0102052 是否必填
        ///// </summary>
        //public bool? IsRequiredCappedPriceHousing { get; set; }

        ///// <summary>
        ///// 保障房_限价商品房  0102052 是否公开
        ///// </summary>
        //public bool? IsPublicCappedPriceHousing { get; set; }
        ///// <summary>
        ///// 保障房_经济适用房  0102053
        ///// </summary>
        //public string AffordableHousing { get; set; }

        ///// <summary>
        ///// 保障房_经济适用房  0102053 数据类别
        ///// </summary>
        //public string RecordTypeAffordableHousing { get; set; }

        ///// <summary>
        ///// 保障房_经济适用房  0102053 是否必填
        ///// </summary>
        //public bool? IsRequiredAffordableHousing { get; set; }

        ///// <summary>
        ///// 保障房_经济适用房  0102053 是否公开
        ///// </summary>
        //public bool? IsPublicAffordableHousing { get; set; }
        ///// <summary>
        ///// 保障房_公租房  0102054
        ///// </summary>
        //public string PRH { get; set; }

        ///// <summary>
        ///// 保障房_公租房  0102054 数据类别
        ///// </summary>
        //public string RecordTypePRH { get; set; }

        ///// <summary>
        ///// 保障房_公租房  0102054 是否必填
        ///// </summary>
        //public bool? IsRequiredPRH { get; set; }

        ///// <summary>
        ///// 保障房_公租房  0102054 是否公开
        ///// </summary>
        //public bool? IsPublicPRH { get; set; }
        ///// <summary>
        ///// 保障房_廉租房  0102055
        ///// </summary>
        //public string LowRentHousing { get; set; }

        ///// <summary>
        ///// 保障房_廉租房  0102055 数据类别
        ///// </summary>
        //public string RecordTypeLowRentHousing { get; set; }

        ///// <summary>
        ///// 保障房_廉租房  0102055 是否必填
        ///// </summary>
        //public bool? IsRequiredLowRentHousing { get; set; }

        ///// <summary>
        ///// 保障房_廉租房  0102055 是否公开
        ///// </summary>
        //public bool? IsPublicLowRentHousing { get; set; }
        ///// <summary>
        ///// 层数特征_1-6层_地上  0102056
        ///// </summary>
        //public string GroundLayer_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_地上  0102056 数据类别
        ///// </summary>
        //public string RecordTypeGroundLayer_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_地上  0102056 是否必填
        ///// </summary>
        //public bool? IsRequiredGroundLayer_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_地上  0102056 是否公开
        ///// </summary>
        //public bool? IsPublicGroundLayer_Less6 { get; set; }
        ///// <summary>
        ///// 层数特征_7-10层_地上  0102057
        ///// </summary>
        //public string GroundLayer_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_地上  0102057 数据类别
        ///// </summary>
        //public string RecordTypeGroundLayer_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_地上  0102057 是否必填
        ///// </summary>
        //public bool? IsRequiredGroundLayer_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_地上  0102057 是否公开
        ///// </summary>
        //public bool? IsPublicGroundLayer_7To10 { get; set; }
        ///// <summary>
        ///// 层数特征_10层以上_地上  0102058
        ///// </summary>
        //public string GroundLayer_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_地上  0102058 数据类别
        ///// </summary>
        //public string RecordTypeGroundLayer_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_地上  0102058 是否必填
        ///// </summary>
        //public bool? IsRequiredGroundLayer_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_地上  0102058 是否公开
        ///// </summary>
        //public bool? IsPublicGroundLayer_Above10 { get; set; }
        ///// <summary>
        ///// 层数特征_1-6层_地下  0102059
        ///// </summary>
        //public string UndergroundLayer_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_地下  0102059 数据类别
        ///// </summary>
        //public string RecordTypeUndergroundLayer_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_地下  0102059 是否必填
        ///// </summary>
        //public bool? IsRequiredUndergroundLayer_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_地下  0102059 是否公开
        ///// </summary>
        //public bool? IsPublicUndergroundLayer_Less6 { get; set; }
        ///// <summary>
        ///// 层数特征_7-10层_地下  0102060
        ///// </summary>
        //public string UndergroundLayer_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_地下  0102060 数据类别
        ///// </summary>
        //public string RecordTypeUndergroundLayer_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_地下  0102060 是否必填
        ///// </summary>
        //public bool? IsRequiredUndergroundLayer_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_地下  0102060 是否公开
        ///// </summary>
        //public bool? IsPublicUndergroundLayer_7To10 { get; set; }
        ///// <summary>
        ///// 层数特征_10层以上_地下  0102061
        ///// </summary>
        //public string UndergroundLayer_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_地下  0102061 数据类别
        ///// </summary>
        //public string RecordTypeUndergroundLayer_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_地下  0102061 是否必填
        ///// </summary>
        //public bool? IsRequiredUndergroundLayer_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_地下  0102061 是否公开
        ///// </summary>
        //public bool? IsPublicUndergroundLayer_Above10 { get; set; }
        ///// <summary>
        ///// 层数特征_1-6层_高度  0102062
        ///// </summary>
        //public string Height_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_高度  0102062 数据类别
        ///// </summary>
        //public string RecordTypeHeight_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_高度  0102062 是否必填
        ///// </summary>
        //public bool? IsRequiredHeight_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_高度  0102062 是否公开
        ///// </summary>
        //public bool? IsPublicHeight_Less6 { get; set; }
        ///// <summary>
        ///// 层数特征_7-10层_高度  0102063
        ///// </summary>
        //public string Height_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_高度  0102063 数据类别
        ///// </summary>
        //public string RecordTypeHeight_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_高度  0102063 是否必填
        ///// </summary>
        //public bool? IsRequiredHeight_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_高度  0102063 是否公开
        ///// </summary>
        //public bool? IsPublicHeight_7To10 { get; set; }
        ///// <summary>
        ///// 层数特征_10层以上_高度  0102064
        ///// </summary>
        //public string Height_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_高度  0102064 数据类别
        ///// </summary>
        //public string RecordTypeHeight_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_高度  0102064 是否必填
        ///// </summary>
        //public bool? IsRequiredHeight_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_高度  0102064 是否公开
        ///// </summary>
        //public bool? IsPublicHeight_Above10 { get; set; }
        ///// <summary>
        ///// 层数特征_1-6层_栋数  0102065
        ///// </summary>
        //public string Count_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_栋数  0102065 数据类别
        ///// </summary>
        //public string RecordTypeCount_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_栋数  0102065 是否必填
        ///// </summary>
        //public bool? IsRequiredCount_Less6 { get; set; }

        ///// <summary>
        ///// 层数特征_1-6层_栋数  0102065 是否公开
        ///// </summary>
        //public bool? IsPublicCount_Less6 { get; set; }
        ///// <summary>
        ///// 层数特征_7-10层_栋数  0102066
        ///// </summary>
        //public string Count_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_栋数  0102066 数据类别
        ///// </summary>
        //public string RecordTypeCount_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_栋数  0102066 是否必填
        ///// </summary>
        //public bool? IsRequiredCount_7To10 { get; set; }

        ///// <summary>
        ///// 层数特征_7-10层_栋数  0102066 是否公开
        ///// </summary>
        //public bool? IsPublicCount_7To10 { get; set; }
        ///// <summary>
        ///// 层数特征_10层以上_栋数  0102067
        ///// </summary>
        //public string Count_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_栋数  0102067 数据类别
        ///// </summary>
        //public string RecordTypeCount_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_栋数  0102067 是否必填
        ///// </summary>
        //public bool? IsRequiredCount_Above10 { get; set; }

        ///// <summary>
        ///// 层数特征_10层以上_栋数  0102067 是否公开
        ///// </summary>
        //public bool? IsPublicCount_Above10 { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0102068
        /// </summary>
        public string ResidentialInfoMemo { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0102068 数据类别
        /// </summary>
        public string RecordTypeResidentialInfoMemo { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0102068 是否必填
        /// </summary>
        public bool? IsRequiredResidentialInfoMemo { get; set; }

        /// <summary>
        /// 居住建筑类补充信息备注  0102068 是否公开
        /// </summary>
        public bool? IsPublicResidentialInfoMemo { get; set; }

        ///// <summary>
        ///// 建筑专业设计主要特点  0102069
        ///// </summary>
        //public string ConstructionFeatures { get; set; }

        ///// <summary>
        ///// 建筑专业设计主要特点  0102069 数据类别
        ///// </summary>
        //public string RecordTypeConstructionFeatures { get; set; }

        ///// <summary>
        ///// 建筑专业设计主要特点  0102069 是否必填
        ///// </summary>
        //public bool? IsRequiredConstructionFeatures { get; set; }

        ///// <summary>
        ///// 建筑专业设计主要特点  0102069 是否公开
        ///// </summary>
        //public bool? IsPublicConstructionFeatures { get; set; }

        /// <summary>
        /// 项目概况  0102070
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0102070 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0102070 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 是否公开项目概况  0102070
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }

        /// <summary>
        /// 技术特色  0102071
        /// </summary>
        public string TechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  0102071 数据类别
        /// </summary>
        public string RecordTypeTechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  0102071 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalFeatures { get; set; }

        /// <summary>
        /// 是否公开技术特色  0102071
        /// </summary>
        public bool? IsPublicTechnicalFeatures { get; set; }
        /// <summary>
        /// 技术成效与深度  0102072
        /// </summary>
        public string TechnicalDepth { get; set; }

        /// <summary>
        /// 技术成效与深度  0102072 数据类别
        /// </summary>
        public string RecordTypeTechnicalDepth { get; set; }

        /// <summary>
        /// 技术成效与深度  0102072 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalDepth { get; set; }

        /// <summary>
        /// 是否公开技术成效与深度  0102072
        /// </summary>

        public bool? IsPublicTechnicalDepth { get; set; }
        /// <summary>
        /// 综合效益  0102073
        /// </summary>
        public string ComprehensiveBenefit { get; set; }

        /// <summary>
        ///  综合效益  0102073 数据类别
        /// </summary>
        public string RecordTypeComprehensiveBenefit { get; set; }

        /// <summary>
        ///  综合效益  0102073 是否必填
        /// </summary>
        public bool? IsRequiredComprehensiveBenefit { get; set; }

        /// <summary>
        /// 是否公开综合效益  0102073
        /// </summary>
        public bool? IsPublicComprehensiveBenefit { get; set; }

    }


    /// <summary>
    /// 公建模板—技术申报内容—结构
    /// </summary>
    [Serializable]
    public class Template_0103 : TemplateBase
    {
        /// <summary>
        /// 结构体系  0103001
        /// </summary>
        public string StructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0103001 数据类别
        /// </summary>
        public string RecordTypeStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0103001 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0103001 是否公开
        /// </summary>
        public bool? IsPublicStructuralSystem { get; set; }
        /// <summary>
        /// 抗震设防烈度  0103002
        /// </summary>
        public string FortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0103002 数据类别
        /// </summary>
        public string RecordTypeFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0103002 是否必填
        /// </summary>
        public bool? IsRequiredFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0103002 是否公开
        /// </summary>
        public bool? IsPublicFortificationIntensity { get; set; }
        /// <summary>
        /// 抗震设防类别  0103003
        /// </summary>
        public string FortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0103003 数据类别
        /// </summary>
        public string RecordTypeFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0103003 是否必填
        /// </summary>
        public bool? IsRequiredFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0103003 是否公开
        /// </summary>
        public bool? IsPublicFortificationCategory { get; set; }
        /// <summary>
        /// 基本地震加速度  0103004
        /// </summary>
        public string BasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0103004 数据类别
        /// </summary>
        public string RecordTypeBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0103004 是否必填
        /// </summary>
        public bool? IsRequiredBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0103004 是否公开
        /// </summary>
        public bool? IsPublicBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 设计地震分组  0103005
        /// </summary>
        public string SeismicGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0103005 数据类别
        /// </summary>
        public string RecordTypeSeismicGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0103005 是否必填
        /// </summary>
        public bool? IsRequiredSeismicGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0103005 是否公开
        /// </summary>
        public bool? IsPublicSeismicGrouping { get; set; }
        /// <summary>
        /// 建筑场地土类别  0103006
        /// </summary>
        public string SiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0103006 数据类别
        /// </summary>
        public string RecordTypeSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0103006 是否必填
        /// </summary>
        public bool? IsRequiredSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0103006 是否公开
        /// </summary>
        public bool? IsPublicSiteSoilType { get; set; }
        /// <summary>
        /// 基础类型  0103007
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 基础类型  0103007 数据类别
        /// </summary>
        public string RecordTypeBaseType { get; set; }

        /// <summary>
        /// 基础类型  0103007 是否必填
        /// </summary>
        public bool? IsRequiredBaseType { get; set; }

        /// <summary>
        /// 基础类型  0103007 是否公开
        /// </summary>
        public bool? IsPublicBaseType { get; set; }
        /// <summary>
        /// 结构安全等级  0103008
        /// </summary>
        public string SafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0103008 数据类别
        /// </summary>
        public string RecordTypeSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0103008 是否必填
        /// </summary>
        public bool? IsRequiredSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0103008 是否公开
        /// </summary>
        public bool? IsPublicSafetyLevel { get; set; }
        /// <summary>
        /// 混凝土总用量  0103009
        /// </summary>
        public string ConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0103009 数据类别
        /// </summary>
        public string RecordTypeConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0103009 是否必填
        /// </summary>
        public bool? IsRequiredConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0103009 是否公开
        /// </summary>
        public bool? IsPublicConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度  0103010
        /// </summary>
        public string PerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0103010 数据类别
        /// </summary>
        public string RecordTypePerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0103010 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0103010 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  0103011
        /// </summary>
        public string SteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0103011 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0103011 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0103011 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  0103012
        /// </summary>
        public string SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0103012 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0103012 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0103012 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  0103013
        /// </summary>
        public string PerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0103013 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0103013 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0103013 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  0103014
        /// </summary>
        public string PerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0103014 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0103014 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0103014 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 振型程序名称  0103015
        /// </summary>
        public string ModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0103015 数据类别
        /// </summary>
        public string RecordTypeModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0103015 是否必填
        /// </summary>
        public bool? IsRequiredModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0103015 是否公开
        /// </summary>
        public bool? IsPublicModeProgramName { get; set; }
        /// <summary>
        /// 振型号1  0103016
        /// </summary>
        public string VibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0103016 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0103016 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0103016 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum1 { get; set; }
        /// <summary>
        /// 周期1  0103017
        /// </summary>
        public string VibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0103017 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0103017 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0103017 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle1 { get; set; }
        /// <summary>
        /// 转角1  0103018
        /// </summary>
        public string VibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0103018 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0103018 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0103018 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle1 { get; set; }
        /// <summary>
        /// 平动系数(x+y)1  0103019
        /// </summary>
        public string TranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0103019 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0103019 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0103019 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient1 { get; set; }
        /// <summary>
        /// 扭转系数1  0103020
        /// </summary>
        public string TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0103020 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0103020 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0103020 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient1 { get; set; }
        /// <summary>
        /// 振型号2  0103021
        /// </summary>
        public string VibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0103021 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0103021 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0103021 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum2 { get; set; }
        /// <summary>
        /// 周期2  0103022
        /// </summary>
        public string VibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0103022 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0103022 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0103022 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle2 { get; set; }
        /// <summary>
        /// 转角2  0103023
        /// </summary>
        public string VibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0103023 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0103023 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0103023 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle2 { get; set; }
        /// <summary>
        /// 平动系数(x+y)2  0103024
        /// </summary>
        public string TranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0103024 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0103024 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0103024 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient2 { get; set; }
        /// <summary>
        /// 扭转系数2  0103025
        /// </summary>
        public string TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0103025 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0103025 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0103025 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient2 { get; set; }
        /// <summary>
        /// 振型号3  0103026
        /// </summary>
        public string VibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0103026 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0103026 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0103026 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum3 { get; set; }
        /// <summary>
        /// 周期3  0103027
        /// </summary>
        public string VibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0103027 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0103027 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0103027 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle3 { get; set; }
        /// <summary>
        /// 转角3  0103028
        /// </summary>
        public string VibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0103028 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0103028 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0103028 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle3 { get; set; }
        /// <summary>
        /// 平动系数(x+y)3  0103029
        /// </summary>
        public string TranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0103029 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0103029 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0103029 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient3 { get; set; }
        /// <summary>
        /// 扭转系数3  0103030
        /// </summary>
        public string TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0103030 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0103030 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0103030 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient3 { get; set; }
        /// <summary>
        /// 振型号4  0103031
        /// </summary>
        public string VibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0103031 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0103031 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0103031 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum4 { get; set; }
        /// <summary>
        /// 周期4  0103032
        /// </summary>
        public string VibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0103032 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0103032 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0103032 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle4 { get; set; }
        /// <summary>
        /// 转角4  0103033
        /// </summary>
        public string VibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0103033 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0103033 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0103033 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle4 { get; set; }
        /// <summary>
        /// 平动系数(x+y)4  0103034
        /// </summary>
        public string TranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0103034 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0103034 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0103034 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient4 { get; set; }
        /// <summary>
        /// 扭转系数4  0103035
        /// </summary>
        public string TorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0103035 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0103035 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0103035 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient4 { get; set; }
        /// <summary>
        /// 振型号5  0103036
        /// </summary>
        public string VibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0103036 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0103036 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0103036 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum5 { get; set; }
        /// <summary>
        /// 周期5  0103037
        /// </summary>
        public string VibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0103037 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0103037 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0103037 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle5 { get; set; }
        /// <summary>
        /// 转角5  0103038
        /// </summary>
        public string VibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0103038 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0103038 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0103038 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle5 { get; set; }
        /// <summary>
        /// 平动系数(x+y)5  0103039
        /// </summary>
        public string TranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0103039 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0103039 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0103039 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient5 { get; set; }
        /// <summary>
        /// 扭转系数5  0103040
        /// </summary>
        public string TorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0103040 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0103040 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0103040 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient5 { get; set; }
        /// <summary>
        /// 振型号6  0103041
        /// </summary>
        public string VibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0103041 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0103041 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0103041 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum6 { get; set; }
        /// <summary>
        /// 周期6  0103042
        /// </summary>
        public string VibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0103042 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0103042 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0103042 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle6 { get; set; }
        /// <summary>
        /// 转角6  0103043
        /// </summary>
        public string VibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0103043 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0103043 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0103043 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle6 { get; set; }
        /// <summary>
        /// 平动系数(x+y)6  0103044
        /// </summary>
        public string TranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0103044 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0103044 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0103044 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient6 { get; set; }
        /// <summary>
        /// 扭转系数6  0103045
        /// </summary>
        public string TorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0103045 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0103045 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0103045 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient6 { get; set; }
        /// <summary>
        /// 振型号7  0103046
        /// </summary>
        public string VibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0103046 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0103046 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0103046 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum7 { get; set; }
        /// <summary>
        /// 周期7  0103047
        /// </summary>
        public string VibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0103047 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0103047 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0103047 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle7 { get; set; }
        /// <summary>
        /// 转角7  0103048
        /// </summary>
        public string VibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0103048 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0103048 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0103048 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle7 { get; set; }
        /// <summary>
        /// 平动系数(x+y)7  0103049
        /// </summary>
        public string TranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0103049 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0103049 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0103049 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient7 { get; set; }
        /// <summary>
        /// 扭转系数7  0103050
        /// </summary>
        public string TorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0103050 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0103050 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0103050 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient7 { get; set; }
        /// <summary>
        /// 振型号8  0103051
        /// </summary>
        public string VibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0103051 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0103051 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0103051 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum8 { get; set; }
        /// <summary>
        /// 周期8  0103052
        /// </summary>
        public string VibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0103052 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0103052 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0103052 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle8 { get; set; }
        /// <summary>
        /// 转角8  0103053
        /// </summary>
        public string VibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0103053 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0103053 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0103053 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle8 { get; set; }
        /// <summary>
        /// 平动系数(x+y)8  0103054
        /// </summary>
        public string TranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0103054 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0103054 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0103054 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient8 { get; set; }
        /// <summary>
        /// 扭转系数8  0103055
        /// </summary>
        public string TorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0103055 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0103055 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0103055 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient8 { get; set; }
        /// <summary>
        /// 振型号9  0103056
        /// </summary>
        public string VibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0103056 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0103056 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0103056 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum9 { get; set; }
        /// <summary>
        /// 周期9  0103057
        /// </summary>
        public string VibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0103057 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0103057 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0103057 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle9 { get; set; }
        /// <summary>
        /// 转角9  0103058
        /// </summary>
        public string VibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0103058 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0103058 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0103058 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle9 { get; set; }
        /// <summary>
        /// 平动系数(x+y)9  0103059
        /// </summary>
        public string TranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0103059 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0103059 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0103059 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient9 { get; set; }
        /// <summary>
        /// 扭转系数9  0103060
        /// </summary>
        public string TorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0103060 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0103060 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0103060 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient9 { get; set; }
        /// <summary>
        /// 是否考虑扭转耦联  0103061
        /// </summary>
        public string IsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0103061 数据类别
        /// </summary>
        public string RecordTypeIsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0103061 是否必填
        /// </summary>
        public bool? IsRequiredIsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0103061 是否公开
        /// </summary>
        public bool? IsPublicIsConsiderCoupling { get; set; }
        /// <summary>
        /// X向基底剪力(kN)  0103062
        /// </summary>
        public string BaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0103062 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0103062 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0103062 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)  0103063
        /// </summary>
        public string BaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0103063 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0103063 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0103063 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y { get; set; }
        /// <summary>
        /// X向基底剪重比  0103064
        /// </summary>
        public string BasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0103064 数据类别
        /// </summary>
        public string RecordTypeBasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0103064 是否必填
        /// </summary>
        public bool? IsRequiredBasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0103064 是否公开
        /// </summary>
        public bool? IsPublicBasalShearRatio_X { get; set; }
        /// <summary>
        /// Y向基底剪重比  0103065
        /// </summary>
        public string BasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0103065 数据类别
        /// </summary>
        public string RecordTypeBasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0103065 是否必填
        /// </summary>
        public bool? IsRequiredBasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0103065 是否公开
        /// </summary>
        public bool? IsPublicBasalShearRatio_Y { get; set; }
        /// <summary>
        /// X向最小剪重比（层号）  0103066
        /// </summary>
        public string MinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0103066 数据类别
        /// </summary>
        public string RecordTypeMinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0103066 是否必填
        /// </summary>
        public bool? IsRequiredMinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0103066 是否公开
        /// </summary>
        public bool? IsPublicMinShearWeightRatio_X { get; set; }
        /// <summary>
        /// Y向最小剪重比（层号）  0103067
        /// </summary>
        public string MinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0103067 数据类别
        /// </summary>
        public string RecordTypeMinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0103067 是否必填
        /// </summary>
        public bool? IsRequiredMinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0103067 是否公开
        /// </summary>
        public bool? IsPublicMinShearWeightRatio_Y { get; set; }
        /// <summary>
        /// X向最大层间位移角  0103068
        /// </summary>
        public string MaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0103068 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0103068 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0103068 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X { get; set; }
        /// <summary>
        /// Y向最大层间位移角  0103069
        /// </summary>
        public string MaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0103069 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0103069 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0103069 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y { get; set; }
        /// <summary>
        /// X向最大位移比（层号）  0103070
        /// </summary>
        public string MaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0103070 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0103070 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0103070 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacementRatio_X { get; set; }
        /// <summary>
        /// Y向最大位移比（层号）  0103071
        /// </summary>
        public string MaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0103071 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0103071 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0103071 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacementRatio_Y { get; set; }
        /// <summary>
        /// 时程分析波名1  0103072
        /// </summary>
        public string TimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0103072 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0103072 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0103072 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName1 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)1  0103073
        /// </summary>
        public string BaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0103073 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0103073 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0103073 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X1 { get; set; }
        /// <summary>
        /// X向最大层间位移角1  0103074
        /// </summary>
        public string MaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0103074 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0103074 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0103074 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X1 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)1  0103075
        /// </summary>
        public string BaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0103075 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0103075 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0103075 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y1 { get; set; }
        /// <summary>
        /// Y向最大层间位移角1  0103076
        /// </summary>
        public string MaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0103076 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0103076 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0103076 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y1 { get; set; }
        /// <summary>
        /// 时程分析波名2  0103077
        /// </summary>
        public string TimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0103077 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0103077 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0103077 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName2 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)2  0103078
        /// </summary>
        public string BaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0103078 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0103078 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0103078 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X2 { get; set; }
        /// <summary>
        /// X向最大层间位移角2  0103079
        /// </summary>
        public string MaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0103079 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0103079 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0103079 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X2 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)2  0103080
        /// </summary>
        public string BaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0103080 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0103080 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0103080 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y2 { get; set; }
        /// <summary>
        /// Y向最大层间位移角2  0103081
        /// </summary>
        public string MaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0103081 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0103081 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0103081 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y2 { get; set; }
        /// <summary>
        /// 时程分析波名3  0103082
        /// </summary>
        public string TimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0103082 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0103082 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0103082 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName3 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)3  0103083
        /// </summary>
        public string BaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0103083 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0103083 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0103083 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X3 { get; set; }
        /// <summary>
        /// X向最大层间位移角3  0103084
        /// </summary>
        public string MaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0103084 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0103084 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0103084 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X3 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)3  0103085
        /// </summary>
        public string BaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0103085 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0103085 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0103085 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y3 { get; set; }
        /// <summary>
        /// Y向最大层间位移角3  0103086
        /// </summary>
        public string MaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0103086 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0103086 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0103086 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y3 { get; set; }
        /// <summary>
        /// 时程分析波名4  0103087
        /// </summary>
        public string TimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0103087 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0103087 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0103087 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName4 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)4  0103088
        /// </summary>
        public string BaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0103088 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0103088 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0103088 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X4 { get; set; }
        /// <summary>
        /// X向最大层间位移角4  0103089
        /// </summary>
        public string MaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0103089 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0103089 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0103089 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X4 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)4  0103090
        /// </summary>
        public string BaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0103090 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0103090 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0103090 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y4 { get; set; }
        /// <summary>
        /// Y向最大层间位移角4  0103091
        /// </summary>
        public string MaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0103091 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0103091 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0103091 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y4 { get; set; }
        /// <summary>
        /// 时程分析波名5  0103092
        /// </summary>
        public string TimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0103092 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0103092 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0103092 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName5 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)5  0103093
        /// </summary>
        public string BaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0103093 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0103093 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0103093 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X5 { get; set; }
        /// <summary>
        /// X向最大层间位移角5  0103094
        /// </summary>
        public string MaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0103094 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0103094 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0103094 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X5 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)5  0103095
        /// </summary>
        public string BaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0103095 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0103095 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0103095 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y5 { get; set; }
        /// <summary>
        /// Y向最大层间位移角5  0103096
        /// </summary>
        public string MaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0103096 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0103096 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0103096 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y5 { get; set; }
        /// <summary>
        /// 时程分析波名6  0103097
        /// </summary>
        public string TimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0103097 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0103097 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0103097 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName6 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)6  0103098
        /// </summary>
        public string BaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0103098 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0103098 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0103098 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X6 { get; set; }
        /// <summary>
        /// X向最大层间位移角6  0103099
        /// </summary>
        public string MaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0103099 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0103099 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0103099 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X6 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)6  0103100
        /// </summary>
        public string BaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0103100 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0103100 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0103100 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y6 { get; set; }
        /// <summary>
        /// Y向最大层间位移角6  0103101
        /// </summary>
        public string MaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0103101 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0103101 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0103101 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y6 { get; set; }
        /// <summary>
        /// 时程分析波名7  0103102
        /// </summary>
        public string TimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0103102 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0103102 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0103102 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName7 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)7  0103103
        /// </summary>
        public string BaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0103103 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0103103 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0103103 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X7 { get; set; }
        /// <summary>
        /// X向最大层间位移角7  0103104
        /// </summary>
        public string MaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0103104 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0103104 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0103104 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X7 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)7  0103105
        /// </summary>
        public string BaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0103105 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0103105 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0103105 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y7 { get; set; }
        /// <summary>
        /// Y向最大层间位移角7  0103106
        /// </summary>
        public string MaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0103106 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0103106 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0103106 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y7 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0103107
        /// </summary>
        public string BaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0103107 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0103107 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0103107 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X_Avg { get; set; }
        /// <summary>
        /// X向最大层间位移角_各波平均值  0103108
        /// </summary>
        public string MaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0103108 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0103108 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0103108 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X_Avg { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0103109
        /// </summary>
        public string BaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0103109 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0103109 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0103109 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y_Avg { get; set; }
        /// <summary>
        /// Y向最大层间位移角_各波平均值  0103110
        /// </summary>
        public string MaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0103110 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0103110 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0103110 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y_Avg { get; set; }
        /// <summary>
        /// 结构专业设计主要特点  0103111
        /// </summary>
        public string StructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0103111 数据类别
        /// </summary>
        public string RecordTypeStructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0103111 是否必填
        /// </summary>
        public bool? IsRequiredStructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0103111 是否公开
        /// </summary>
        public bool? IsPublicStructuralFeatures { get; set; }
        /// <summary>
        /// 建筑用途（性质）  0103112
        /// </summary>
        public string UseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0103112 数据类别
        /// </summary>
        public string RecordTypeUseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0103112 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0103112 是否公开
        /// </summary>
        public bool? IsPublicUseProperty { get; set; }
        /// <summary>
        /// 建筑规模  0103113
        /// </summary>
        public string BuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0103113 数据类别
        /// </summary>
        public string RecordTypeBuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0103113 是否必填
        /// </summary>
        public bool? IsRequiredBuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0103113 是否公开
        /// </summary>
        public bool? IsPublicBuildingScale { get; set; }
        /// <summary>
        /// 总用地面积  0103114
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0103114 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0103114 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0103114 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 代征地面积  0103115
        /// </summary>
        public string ExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0103115 数据类别
        /// </summary>
        public string RecordTypeExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0103115 是否必填
        /// </summary>
        public bool? IsRequiredExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0103115 是否公开
        /// </summary>
        public bool? IsPublicExpropriationArea { get; set; }
        /// <summary>
        /// 建设用地面积  0103116
        /// </summary>
        public string ConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0103116 数据类别
        /// </summary>
        public string RecordTypeConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0103116 是否必填
        /// </summary>
        public bool? IsRequiredConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0103116 是否公开
        /// </summary>
        public bool? IsPublicConstructionArea { get; set; }
        /// <summary>
        /// 总建筑面积  0103117
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0103117 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0103117 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0103117 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 地上面积  0103118
        /// </summary>
        public string OvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0103118 数据类别
        /// </summary>
        public string RecordTypeOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0103118 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0103118 是否公开
        /// </summary>
        public bool? IsPublicOvergroundArea { get; set; }
        /// <summary>
        /// 地下面积  0103119
        /// </summary>
        public string UndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0103119 数据类别
        /// </summary>
        public string RecordTypeUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0103119 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0103119 是否公开
        /// </summary>
        public bool? IsPublicUndergroundArea { get; set; }
        /// <summary>
        /// 建筑基底面积  0103120
        /// </summary>
        public string BuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0103120 数据类别
        /// </summary>
        public string RecordTypeBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0103120 是否必填
        /// </summary>
        public bool? IsRequiredBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0103120 是否公开
        /// </summary>
        public bool? IsPublicBuildingArea { get; set; }
        /// <summary>
        /// 绿地面积  0103121
        /// </summary>
        public string GreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0103121 数据类别
        /// </summary>
        public string RecordTypeGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0103121 是否必填
        /// </summary>
        public bool? IsRequiredGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0103121 是否公开
        /// </summary>
        public bool? IsPublicGreenArea { get; set; }
        /// <summary>
        /// 绿化率  0103122
        /// </summary>
        public string GreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0103122 数据类别
        /// </summary>
        public string RecordTypeGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0103122 是否必填
        /// </summary>
        public bool? IsRequiredGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0103122 是否公开
        /// </summary>
        public bool? IsPublicGreeningRate { get; set; }
        /// <summary>
        /// 容积率  0103123
        /// </summary>
        public string PlotRatio { get; set; }

        /// <summary>
        /// 容积率  0103123 数据类别
        /// </summary>
        public string RecordTypePlotRatio { get; set; }

        /// <summary>
        /// 容积率  0103123 是否必填
        /// </summary>
        public bool? IsRequiredPlotRatio { get; set; }

        /// <summary>
        /// 容积率  0103123 是否公开
        /// </summary>
        public bool? IsPublicPlotRatio { get; set; }
        /// <summary>
        /// 建筑高度  0103124
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0103124 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0103124 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0103124 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑分类（高层建筑）  0103125
        /// </summary>
        public string BuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类（高层建筑）  0103125 数据类别
        /// </summary>
        public string RecordTypeBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类（高层建筑）  0103125 是否必填
        /// </summary>
        public bool? IsRequiredBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类（高层建筑）  0103125 是否公开
        /// </summary>
        public bool? IsPublicBuildingClassification { get; set; }
        /// <summary>
        /// 地上层数  0103126
        /// </summary>
        public string OvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0103126 数据类别
        /// </summary>
        public string RecordTypeOvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0103126 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0103126 是否公开
        /// </summary>
        public bool? IsPublicOvergroundLayerCount { get; set; }
        /// <summary>
        /// 地下层数  0103127
        /// </summary>
        public string UndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0103127 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0103127 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0103127 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayerCount { get; set; }
        /// <summary>
        /// 耐火等级  0103128
        /// </summary>
        public string FireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0103128 数据类别
        /// </summary>
        public string RecordTypeFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0103128 是否必填
        /// </summary>
        public bool? IsRequiredFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0103128 是否公开
        /// </summary>
        public bool? IsPublicFireResistanceRating { get; set; }
        /// <summary>
        /// 主要层高_地上  0103129
        /// </summary>
        public string LayerHeight_Overground { get; set; }

        /// <summary>
        /// 主要层高_地上  0103129 数据类别
        /// </summary>
        public string RecordTypeLayerHeight_Overground { get; set; }

        /// <summary>
        /// 主要层高_地上  0103129 是否必填
        /// </summary>
        public bool? IsRequiredLayerHeight_Overground { get; set; }

        /// <summary>
        /// 主要层高_地上  0103129 是否公开
        /// </summary>
        public bool? IsPublicLayerHeight_Overground { get; set; }
        /// <summary>
        /// 主要层高_地下  0103130
        /// </summary>
        public string LayerHeight_Underground { get; set; }

        /// <summary>
        /// 主要层高_地下  0103130 数据类别
        /// </summary>
        public string RecordTypeLayerHeight_Underground { get; set; }

        /// <summary>
        /// 主要层高_地下  0103130 是否必填
        /// </summary>
        public bool? IsRequiredLayerHeight_Underground { get; set; }

        /// <summary>
        /// 主要层高_地下  0103130 是否公开
        /// </summary>
        public bool? IsPublicLayerHeight_Underground { get; set; }
        /// <summary>
        /// 主楼/裙房电梯数_主楼  0103131
        /// </summary>
        public string ElevatorNumber_MainBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_主楼  0103131 数据类别
        /// </summary>
        public string RecordTypeElevatorNumber_MainBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_主楼  0103131 是否必填
        /// </summary>
        public bool? IsRequiredElevatorNumber_MainBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_主楼  0103131 是否公开
        /// </summary>
        public bool? IsPublicElevatorNumber_MainBuilding { get; set; }
        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0103132
        /// </summary>
        public string ElevatorNumber_PodiumBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0103132 数据类别
        /// </summary>
        public string RecordTypeElevatorNumber_PodiumBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0103132 是否必填
        /// </summary>
        public bool? IsRequiredElevatorNumber_PodiumBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0103132 是否公开
        /// </summary>
        public bool? IsPublicElevatorNumber_PodiumBuilding { get; set; }
        /// <summary>
        /// 机动车停放数量  0103133
        /// </summary>
        public string AutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停放数量  0103133 数据类别
        /// </summary>
        public string RecordTypeAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停放数量  0103133 是否必填
        /// </summary>
        public bool? IsRequiredAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停放数量  0103133 是否公开
        /// </summary>
        public bool? IsPublicAutoParkingCount { get; set; }
        /// <summary>
        /// 地上停车（机动车）  0103134
        /// </summary>
        public string OvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0103134 数据类别
        /// </summary>
        public string RecordTypeOvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0103134 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0103134 是否公开
        /// </summary>
        public bool? IsPublicOvergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 地下停车（机动车）  0103135
        /// </summary>
        public string UndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0103135 数据类别
        /// </summary>
        public string RecordTypeUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0103135 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0103135 是否公开
        /// </summary>
        public bool? IsPublicUndergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 自行车停车数量  0103136
        /// </summary>
        public string BicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车数量  0103136 数据类别
        /// </summary>
        public string RecordTypeBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车数量  0103136 是否必填
        /// </summary>
        public bool? IsRequiredBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车数量  0103136 是否公开
        /// </summary>
        public bool? IsPublicBicycleParkingCount { get; set; }
        /// <summary>
        /// 地上停车（自行车）  0103137
        /// </summary>
        public string OvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0103137 数据类别
        /// </summary>
        public string RecordTypeOvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0103137 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0103137 是否公开
        /// </summary>
        public bool? IsPublicOvergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 地下停车（自行车）  0103138
        /// </summary>
        public string UndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0103138 数据类别
        /// </summary>
        public string RecordTypeUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0103138 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0103138 是否公开
        /// </summary>
        public bool? IsPublicUndergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 周围道路宽度及性质  0103139
        /// </summary>
        public string RoadWidth { get; set; }

        /// <summary>
        /// 周围道路宽度及性质  0103139 数据类别
        /// </summary>
        public string RecordTypeRoadWidth { get; set; }

        /// <summary>
        /// 周围道路宽度及性质  0103139 是否必填
        /// </summary>
        public bool? IsRequiredRoadWidth { get; set; }

        /// <summary>
        /// 周围道路宽度及性质  0103139 是否公开
        /// </summary>
        public bool? IsPublicRoadWidth { get; set; }

    }


    /// <summary>
    /// 公建模板—技术申报内容—设备
    /// </summary>
    [Serializable]
    public class Template_0104 : TemplateBase
    {
        /// <summary>
        /// 供暖方式  0104001
        /// </summary>
        public string HeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0104001 数据类别
        /// </summary>
        public string RecordTypeHeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0104001 是否必填
        /// </summary>
        public bool? IsRequiredHeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0104001 是否公开
        /// </summary>
        public bool? IsPublicHeatingMode { get; set; }
        /// <summary>
        /// 供暖建筑面积  0104002
        /// </summary>
        public string HeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0104002 数据类别
        /// </summary>
        public string RecordTypeHeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0104002 是否必填
        /// </summary>
        public bool? IsRequiredHeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0104002 是否公开
        /// </summary>
        public bool? IsPublicHeatingConstructionArea { get; set; }
        /// <summary>
        /// 供暖热负荷  0104003
        /// </summary>
        public string SpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0104003 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0104003 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0104003 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoad { get; set; }
        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104004
        /// </summary>
        public string SpaceHeatingLoadIndicators_TotalArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104004 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoadIndicators_TotalArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104004 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoadIndicators_TotalArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104004 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoadIndicators_TotalArea { get; set; }
        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104005
        /// </summary>
        public string SpaceHeatingLoadIndicators_AirConArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104005 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoadIndicators_AirConArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104005 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoadIndicators_AirConArea { get; set; }

        /// <summary>
        /// 供暖热负荷指标_总建筑面积  0104005 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoadIndicators_AirConArea { get; set; }
        /// <summary>
        /// 空调系统形式  0104005
        /// </summary>
        public string AirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0104005 数据类别
        /// </summary>
        public string RecordTypeAirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0104005 是否必填
        /// </summary>
        public bool? IsRequiredAirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0104005 是否公开
        /// </summary>
        public bool? IsPublicAirConSysMode { get; set; }
        /// <summary>
        /// 空调建筑面积  0104006
        /// </summary>
        public string AirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0104006 数据类别
        /// </summary>
        public string RecordTypeAirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0104006 是否必填
        /// </summary>
        public bool? IsRequiredAirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0104006 是否公开
        /// </summary>
        public bool? IsPublicAirConBuildingArea { get; set; }
        /// <summary>
        /// 空调冷负荷  0104007
        /// </summary>
        public string AirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0104007 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0104007 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0104007 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingLoad { get; set; }
        /// <summary>
        /// 空调冷指标_总建筑面积  0104008
        /// </summary>
        public string AirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0104008 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0104008 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0104008 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingIndicators_TotalArea { get; set; }
        /// <summary>
        /// 空调冷指标_空调建筑面积  0104009
        /// </summary>
        public string AirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0104009 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0104009 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0104009 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingIndicators_AirConArea { get; set; }
        /// <summary>
        /// 空调热负荷  0104010
        /// </summary>
        public string AirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0104010 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0104010 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0104010 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingLoad { get; set; }
        /// <summary>
        /// 空调热指标_总建筑面积  0104011
        /// </summary>
        public string AirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0104011 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0104011 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0104011 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingIndicators_TotalArea { get; set; }
        /// <summary>
        /// 空调热指标_空调建筑面积  0104012
        /// </summary>
        public string AirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0104012 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0104012 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0104012 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingIndicators_AirConArea { get; set; }
        /// <summary>
        /// 冷水机组类型1  0104013
        /// </summary>
        public string ChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0104013 数据类别
        /// </summary>
        public string RecordTypeChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0104013 是否必填
        /// </summary>
        public bool? IsRequiredChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0104013 是否公开
        /// </summary>
        public bool? IsPublicChillerType1 { get; set; }
        /// <summary>
        /// 单台设计制冷量1  0104014
        /// </summary>
        public string ChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0104014 数据类别
        /// </summary>
        public string RecordTypeChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0104014 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0104014 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput1 { get; set; }
        /// <summary>
        /// 冷水机组台数1  0104015
        /// </summary>
        public string ChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0104015 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0104015 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0104015 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity1 { get; set; }
        /// <summary>
        /// 冷水机组类型2  0104016
        /// </summary>
        public string ChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0104016 数据类别
        /// </summary>
        public string RecordTypeChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0104016 是否必填
        /// </summary>
        public bool? IsRequiredChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0104016 是否公开
        /// </summary>
        public bool? IsPublicChillerType2 { get; set; }
        /// <summary>
        /// 单台设计制冷量2  0104017
        /// </summary>
        public string ChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0104017 数据类别
        /// </summary>
        public string RecordTypeChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0104017 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0104017 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput2 { get; set; }
        /// <summary>
        /// 冷水机组台数2  0104018
        /// </summary>
        public string ChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0104018 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0104018 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0104018 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity2 { get; set; }
        /// <summary>
        /// 冷水机组类型3  0104019
        /// </summary>
        public string ChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0104019 数据类别
        /// </summary>
        public string RecordTypeChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0104019 是否必填
        /// </summary>
        public bool? IsRequiredChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0104019 是否公开
        /// </summary>
        public bool? IsPublicChillerType3 { get; set; }
        /// <summary>
        /// 单台设计制冷量3  0104020
        /// </summary>
        public string ChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0104020 数据类别
        /// </summary>
        public string RecordTypeChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0104020 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0104020 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput3 { get; set; }
        /// <summary>
        /// 冷水机组台数3  0104021
        /// </summary>
        public string ChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0104021 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0104021 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0104021 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity3 { get; set; }
        /// <summary>
        /// 制热设备类型1  0104022
        /// </summary>
        public string HeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0104022 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0104022 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0104022 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType1 { get; set; }
        /// <summary>
        /// 单台设计供热量1  0104023
        /// </summary>
        public string HeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0104023 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0104023 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0104023 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput1 { get; set; }
        /// <summary>
        /// 制热设备台数1  0104024
        /// </summary>
        public string HeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0104024 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0104024 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0104024 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity1 { get; set; }
        /// <summary>
        /// 制热设备类型2  0104025
        /// </summary>
        public string HeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0104025 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0104025 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0104025 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType2 { get; set; }
        /// <summary>
        /// 单台设计供热量2  0104026
        /// </summary>
        public string HeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0104026 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0104026 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0104026 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput2 { get; set; }
        /// <summary>
        /// 制热设备台数2  0104027
        /// </summary>
        public string HeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0104027 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0104027 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0104027 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity2 { get; set; }
        /// <summary>
        /// 制热设备类型3  0104028
        /// </summary>
        public string HeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0104028 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0104028 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0104028 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType3 { get; set; }
        /// <summary>
        /// 单台设计供热量3  0104029
        /// </summary>
        public string HeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0104029 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0104029 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0104029 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput3 { get; set; }
        /// <summary>
        /// 制热设备台数3  0104030
        /// </summary>
        public string HeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0104030 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0104030 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0104030 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity3 { get; set; }
        /// <summary>
        /// 供暖系统制式  0104031
        /// </summary>
        public string HeatingSystem { get; set; }

        /// <summary>
        /// 供暖系统制式  0104031 数据类别
        /// </summary>
        public string RecordTypeHeatingSystem { get; set; }

        /// <summary>
        /// 供暖系统制式  0104031 是否必填
        /// </summary>
        public bool? IsRequiredHeatingSystem { get; set; }

        /// <summary>
        /// 供暖系统制式  0104031 是否公开
        /// </summary>
        public bool? IsPublicHeatingSystem { get; set; }
        /// <summary>
        /// 空调水系统制式  0104032
        /// </summary>
        public string AirConWaterSystem { get; set; }

        /// <summary>
        /// 空调水系统制式  0104032 数据类别
        /// </summary>
        public string RecordTypeAirConWaterSystem { get; set; }

        /// <summary>
        /// 空调水系统制式  0104032 是否必填
        /// </summary>
        public bool? IsRequiredAirConWaterSystem { get; set; }

        /// <summary>
        /// 空调水系统制式  0104032 是否公开
        /// </summary>
        public bool? IsPublicAirConWaterSystem { get; set; }
        /// <summary>
        /// 给水系统形式  0104033
        /// </summary>
        public string WaterSupplySystem { get; set; }

        /// <summary>
        /// 给水系统形式  0104033 数据类别
        /// </summary>
        public string RecordTypeWaterSupplySystem { get; set; }

        /// <summary>
        /// 给水系统形式  0104033 是否必填
        /// </summary>
        public bool? IsRequiredWaterSupplySystem { get; set; }

        /// <summary>
        /// 给水系统形式  0104033 是否公开
        /// </summary>
        public bool? IsPublicWaterSupplySystem { get; set; }
        /// <summary>
        /// 中水系统形式  0104034
        /// </summary>
        public string ReclaimedWaterSystem { get; set; }

        /// <summary>
        /// 中水系统形式  0104034 数据类别
        /// </summary>
        public string RecordTypeReclaimedWaterSystem { get; set; }

        /// <summary>
        /// 中水系统形式  0104034 是否必填
        /// </summary>
        public bool? IsRequiredReclaimedWaterSystem { get; set; }

        /// <summary>
        /// 中水系统形式  0104034 是否公开
        /// </summary>
        public bool? IsPublicReclaimedWaterSystem { get; set; }
        /// <summary>
        /// 雨、污水系统形式  0104035
        /// </summary>
        public string SewageSystem { get; set; }

        /// <summary>
        /// 雨、污水系统形式  0104035 数据类别
        /// </summary>
        public string RecordTypeSewageSystem { get; set; }

        /// <summary>
        /// 雨、污水系统形式  0104035 是否必填
        /// </summary>
        public bool? IsRequiredSewageSystem { get; set; }

        /// <summary>
        /// 雨、污水系统形式  0104035 是否公开
        /// </summary>
        public bool? IsPublicSewageSystem { get; set; }
        /// <summary>
        /// 消防给水系统形式  0104036
        /// </summary>
        public string FireWaterSupplySystem { get; set; }

        /// <summary>
        /// 消防给水系统形式  0104036 数据类别
        /// </summary>
        public string RecordTypeFireWaterSupplySystem { get; set; }

        /// <summary>
        /// 消防给水系统形式  0104036 是否必填
        /// </summary>
        public bool? IsRequiredFireWaterSupplySystem { get; set; }

        /// <summary>
        /// 消防给水系统形式  0104036 是否公开
        /// </summary>
        public bool? IsPublicFireWaterSupplySystem { get; set; }
        /// <summary>
        /// 设计特点_暖通、空调  0104037
        /// </summary>
        public string Features_HVAC { get; set; }

        /// <summary>
        /// 设计特点_暖通、空调  0104037 数据类别
        /// </summary>
        public string RecordTypeFeatures_HVAC { get; set; }

        /// <summary>
        /// 设计特点_暖通、空调  0104037 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_HVAC { get; set; }

        /// <summary>
        /// 设计特点_暖通、空调  0104037 是否公开
        /// </summary>
        public bool? IsPublicFeatures_HVAC { get; set; }
        /// <summary>
        /// 设计特点_动力  0104038
        /// </summary>
        public string Features_Power { get; set; }

        /// <summary>
        /// 设计特点_动力  0104038 数据类别
        /// </summary>
        public string RecordTypeFeatures_Power { get; set; }

        /// <summary>
        /// 设计特点_动力  0104038 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_Power { get; set; }

        /// <summary>
        /// 设计特点_动力  0104038 是否公开
        /// </summary>
        public bool? IsPublicFeatures_Power { get; set; }
        /// <summary>
        /// 设计特点_给排水  0104039
        /// </summary>
        public string Features_WaterSupplyAndDrainage { get; set; }

        /// <summary>
        /// 设计特点_给排水  0104039 数据类别
        /// </summary>
        public string RecordTypeFeatures_WaterSupplyAndDrainage { get; set; }

        /// <summary>
        /// 设计特点_给排水  0104039 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_WaterSupplyAndDrainage { get; set; }

        /// <summary>
        /// 设计特点_给排水  0104039 是否公开
        /// </summary>
        public bool? IsPublicFeatures_WaterSupplyAndDrainage { get; set; }
        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0104040
        /// </summary>
        public string Features_FireFacilities { get; set; }

        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0104040 数据类别
        /// </summary>
        public string RecordTypeFeatures_FireFacilities { get; set; }

        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0104040 是否必填
        /// </summary>
        public bool? IsRequiredFeatures_FireFacilities { get; set; }

        /// <summary>
        /// 设计特点_消防给水及其他灭火设施  0104040 是否公开
        /// </summary>
        public bool? IsPublicFeatures_FireFacilities { get; set; }
        /// <summary>
        /// 结构体系  0104042
        /// </summary>
        public string StructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0104042 数据类别
        /// </summary>
        public string RecordTypeStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0104042 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0104042 是否公开
        /// </summary>
        public bool? IsPublicStructuralSystem { get; set; }
        /// <summary>
        /// 抗震设防烈度  0104043
        /// </summary>
        public string SeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0104043 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0104043 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0104043 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationIntensity { get; set; }
        /// <summary>
        /// 抗震设防类别  0104044
        /// </summary>
        public string SeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0104044 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0104044 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0104044 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationCategory { get; set; }
        /// <summary>
        /// 设计基本地震加速度值  0104045
        /// </summary>
        public string BasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震加速度值  0104045 数据类别
        /// </summary>
        public string RecordTypeBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震加速度值  0104045 是否必填
        /// </summary>
        public bool? IsRequiredBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震加速度值  0104045 是否公开
        /// </summary>
        public bool? IsPublicBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 设计地震分组  0104046
        /// </summary>
        public string EarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0104046 数据类别
        /// </summary>
        public string RecordTypeEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0104046 是否必填
        /// </summary>
        public bool? IsRequiredEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0104046 是否公开
        /// </summary>
        public bool? IsPublicEarthquakeGrouping { get; set; }
        /// <summary>
        /// 场地类别  0104047
        /// </summary>
        public string ConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 场地类别  0104047 数据类别
        /// </summary>
        public string RecordTypeConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 场地类别  0104047 是否必填
        /// </summary>
        public bool? IsRequiredConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 场地类别  0104047 是否公开
        /// </summary>
        public bool? IsPublicConstructionSiteSoilType { get; set; }
        /// <summary>
        /// 基础类型  0104048
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 基础类型  0104048 数据类别
        /// </summary>
        public string RecordTypeBaseType { get; set; }

        /// <summary>
        /// 基础类型  0104048 是否必填
        /// </summary>
        public bool? IsRequiredBaseType { get; set; }

        /// <summary>
        /// 基础类型  0104048 是否公开
        /// </summary>
        public bool? IsPublicBaseType { get; set; }
        /// <summary>
        /// 建筑形体规则性  0104049
        /// </summary>
        public string BuildingShape { get; set; }

        /// <summary>
        /// 建筑形体规则性  0104049 数据类别
        /// </summary>
        public string RecordTypeBuildingShape { get; set; }

        /// <summary>
        /// 建筑形体规则性  0104049 是否必填
        /// </summary>
        public bool? IsRequiredBuildingShape { get; set; }

        /// <summary>
        /// 建筑形体规则性  0104049 是否公开
        /// </summary>
        public bool? IsPublicBuildingShape { get; set; }
        /// <summary>
        /// 混凝土总用量  0104050
        /// </summary>
        public string ConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0104050 数据类别
        /// </summary>
        public string RecordTypeConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0104050 是否必填
        /// </summary>
        public bool? IsRequiredConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0104050 是否公开
        /// </summary>
        public bool? IsPublicConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度  0104051
        /// </summary>
        public string PerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0104051 数据类别
        /// </summary>
        public string RecordTypePerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0104051 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0104051 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  0104052
        /// </summary>
        public string SteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0104052 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0104052 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0104052 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  0104053
        /// </summary>
        public string SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0104053 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0104053 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0104053 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  0104054
        /// </summary>
        public string PerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0104054 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0104054 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0104054 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  0104055
        /// </summary>
        public string PerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0104055 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0104055 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0104055 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 抗震分析程序名  0104056
        /// </summary>
        public string SeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  0104056 数据类别
        /// </summary>
        public string RecordTypeSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  0104056 是否必填
        /// </summary>
        public bool? IsRequiredSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  0104056 是否公开
        /// </summary>
        public bool? IsPublicSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0104057
        /// </summary>
        public string NoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0104057 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0104057 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0104057 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0104058
        /// </summary>
        public string NoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0104058 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0104058 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0104058 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0104059
        /// </summary>
        public string NoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0104059 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0104059 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0104059 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0104060
        /// </summary>
        public string NoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0104060 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0104060 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0104060 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0104061
        /// </summary>
        public string NoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0104061 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0104061 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0104061 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0104062
        /// </summary>
        public string NoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0104062 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0104062 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0104062 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0104063
        /// </summary>
        public string NoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0104063 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0104063 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0104063 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0104064
        /// </summary>
        public string NoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0104064 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0104064 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0104064 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0104065
        /// </summary>
        public string NoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0104065 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0104065 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0104065 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0104066
        /// </summary>
        public string NoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0104066 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0104066 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0104066 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  0104067
        /// </summary>
        public string Coupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  0104067 数据类别
        /// </summary>
        public string RecordTypeCoupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  0104067 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  0104067 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  0104068
        /// </summary>
        public string Coupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  0104068 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  0104068 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  0104068 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0104069
        /// </summary>
        public string Coupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0104069 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0104069 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0104069 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  0104070
        /// </summary>
        public string Coupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  0104070 数据类别
        /// </summary>
        public string RecordTypeCoupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  0104070 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  0104070 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  0104071
        /// </summary>
        public string Coupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  0104071 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  0104071 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  0104071 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0104072
        /// </summary>
        public string Coupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0104072 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0104072 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0104072 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  0104073
        /// </summary>
        public string Coupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  0104073 数据类别
        /// </summary>
        public string RecordTypeCoupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  0104073 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  0104073 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  0104074
        /// </summary>
        public string Coupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  0104074 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  0104074 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  0104074 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0104075
        /// </summary>
        public string Coupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0104075 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0104075 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0104075 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0104076
        /// </summary>
        public string Coupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0104076 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0104076 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0104076 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0104077
        /// </summary>
        public string Coupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0104077 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0104077 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0104077 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0104078
        /// </summary>
        public string Coupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0104078 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0104078 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0104078 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0104079
        /// </summary>
        public string Coupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0104079 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0104079 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0104079 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0104080
        /// </summary>
        public string Coupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0104080 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0104080 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0104080 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0104081
        /// </summary>
        public string Coupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0104081 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0104081 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0104081 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0104082
        /// </summary>
        public string Coupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0104082 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0104082 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0104082 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0104083
        /// </summary>
        public string Coupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0104083 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0104083 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0104083 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_h { get; set; }
        /// <summary>
        /// 地震作用最大方向  0104084
        /// </summary>
        public string MaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  0104084 数据类别
        /// </summary>
        public string RecordTypeMaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  0104084 是否必填
        /// </summary>
        public bool? IsRequiredMaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  0104084 是否公开
        /// </summary>
        public bool? IsPublicMaxActionDirection { get; set; }
        /// <summary>
        /// 时程分析程序名称  0104085
        /// </summary>
        public string TimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  0104085 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  0104085 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  0104085 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程_波名1  0104086
        /// </summary>
        public string TimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  0104086 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  0104086 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  0104086 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  0104087
        /// </summary>
        public string TimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  0104087 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  0104087 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  0104087 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  0104088
        /// </summary>
        public string TimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  0104088 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  0104088 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  0104088 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  0104089
        /// </summary>
        public string TimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  0104089 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  0104089 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  0104089 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_波名2  0104090
        /// </summary>
        public string TimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  0104090 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  0104090 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  0104090 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  0104091
        /// </summary>
        public string TimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  0104091 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  0104091 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  0104091 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  0104092
        /// </summary>
        public string TimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  0104092 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  0104092 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  0104092 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  0104093
        /// </summary>
        public string TimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  0104093 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  0104093 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  0104093 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_波名3  0104094
        /// </summary>
        public string TimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  0104094 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  0104094 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  0104094 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  0104095
        /// </summary>
        public string TimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  0104095 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  0104095 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  0104095 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  0104096
        /// </summary>
        public string TimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  0104096 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  0104096 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  0104096 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  0104097
        /// </summary>
        public string TimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  0104097 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  0104097 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  0104097 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h3 { get; set; }
        /// <summary>
        /// 结构专业设计主要特点  0104098
        /// </summary>
        public string StructureMainFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0104098 数据类别
        /// </summary>
        public string RecordTypeStructureMainFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0104098 是否必填
        /// </summary>
        public bool? IsRequiredStructureMainFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0104098 是否公开
        /// </summary>
        public bool? IsPublicStructureMainFeatures { get; set; }

    }


    /// <summary>
    /// 公建模板—技术申报内容—电气
    /// </summary>
    [Serializable]
    public class Template_0105 : TemplateBase
    {
        /// <summary>
        /// 供电电源设计情况  0105001
        /// </summary>
        public string ElectricitySupplyDesign { get; set; }

        /// <summary>
        /// 供电电源设计情况  0105001 数据类别
        /// </summary>
        public string RecordTypeElectricitySupplyDesign { get; set; }

        /// <summary>
        /// 供电电源设计情况  0105001 是否必填
        /// </summary>
        public bool? IsRequiredElectricitySupplyDesign { get; set; }

        /// <summary>
        /// 供电电源设计情况  0105001 是否公开
        /// </summary>
        public bool? IsPublicElectricitySupplyDesign { get; set; }
        /// <summary>
        /// 用电负荷等级确定情况  0105002
        /// </summary>
        public string ElectricityLoadLevels { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0105002 数据类别
        /// </summary>
        public string RecordTypeElectricityLoadLevels { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0105002 是否必填
        /// </summary>
        public bool? IsRequiredElectricityLoadLevels { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0105002 是否公开
        /// </summary>
        public bool? IsPublicElectricityLoadLevels { get; set; }
        /// <summary>
        /// 防雷设计类别及方式  0105003
        /// </summary>
        public string LightningProtection { get; set; }

        /// <summary>
        /// 防雷设计类别及方式  0105003 数据类别
        /// </summary>
        public string RecordTypeLightningProtection { get; set; }

        /// <summary>
        /// 防雷设计类别及方式  0105003 是否必填
        /// </summary>
        public bool? IsRequiredLightningProtection { get; set; }

        /// <summary>
        /// 防雷设计类别及方式  0105003 是否公开
        /// </summary>
        public bool? IsPublicLightningProtection { get; set; }
        /// <summary>
        /// 强电设计  0105004
        /// </summary>
        public string HighVoltageDesign { get; set; }

        /// <summary>
        /// 强电设计  0105004 数据类别
        /// </summary>
        public string RecordTypeHighVoltageDesign { get; set; }

        /// <summary>
        /// 强电设计  0105004 是否必填
        /// </summary>
        public bool? IsRequiredHighVoltageDesign { get; set; }

        /// <summary>
        /// 强电设计  0105004 是否公开
        /// </summary>
        public bool? IsPublicHighVoltageDesign { get; set; }
        /// <summary>
        /// 弱电设计  0105005
        /// </summary>
        public string LowVoltageDesign { get; set; }

        /// <summary>
        /// 弱电设计  0105005 数据类别
        /// </summary>
        public string RecordTypeLowVoltageDesign { get; set; }

        /// <summary>
        /// 弱电设计  0105005 是否必填
        /// </summary>
        public bool? IsRequiredLowVoltageDesign { get; set; }

        /// <summary>
        /// 弱电设计  0105005 是否公开
        /// </summary>
        public bool? IsPublicLowVoltageDesign { get; set; }
        /// <summary>
        /// 电力总用电负荷  0105006
        /// </summary>
        public string TotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0105006 数据类别
        /// </summary>
        public string RecordTypeTotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0105006 是否必填
        /// </summary>
        public bool? IsRequiredTotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0105006 是否公开
        /// </summary>
        public bool? IsPublicTotalElectricityload { get; set; }
        /// <summary>
        /// 照明总用电负荷  0105007
        /// </summary>
        public string TotalLightingLoad { get; set; }

        /// <summary>
        /// 照明总用电负荷  0105007 数据类别
        /// </summary>
        public string RecordTypeTotalLightingLoad { get; set; }

        /// <summary>
        /// 照明总用电负荷  0105007 是否必填
        /// </summary>
        public bool? IsRequiredTotalLightingLoad { get; set; }

        /// <summary>
        /// 照明总用电负荷  0105007 是否公开
        /// </summary>
        public bool? IsPublicTotalLightingLoad { get; set; }
        /// <summary>
        /// 变压器配置  0105008
        /// </summary>
        public string TransformerConfig { get; set; }

        /// <summary>
        /// 变压器配置  0105008 数据类别
        /// </summary>
        public string RecordTypeTransformerConfig { get; set; }

        /// <summary>
        /// 变压器配置  0105008 是否必填
        /// </summary>
        public bool? IsRequiredTransformerConfig { get; set; }

        /// <summary>
        /// 变压器配置  0105008 是否公开
        /// </summary>
        public bool? IsPublicTransformerConfig { get; set; }
        /// <summary>
        /// 变压器配置单位  0105009
        /// </summary>
        public string TransformerConfigUnit { get; set; }

        /// <summary>
        /// 变压器配置单位  0105009 数据类别
        /// </summary>
        public string RecordTypeTransformerConfigUnit { get; set; }

        /// <summary>
        /// 变压器配置单位  0105009 是否必填
        /// </summary>
        public bool? IsRequiredTransformerConfigUnit { get; set; }

        /// <summary>
        /// 变压器配置单位  0105009 是否公开
        /// </summary>
        public bool? IsPublicTransformerConfigUnit { get; set; }
        /// <summary>
        /// 变压器装机密度  0105010
        /// </summary>
        public string TransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0105010 数据类别
        /// </summary>
        public string RecordTypeTransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0105010 是否必填
        /// </summary>
        public bool? IsRequiredTransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0105010 是否公开
        /// </summary>
        public bool? IsPublicTransformerDensity { get; set; }
        /// <summary>
        /// 备用电源设置情况及总容量  0105011
        /// </summary>
        public string StandbyElectricity { get; set; }

        /// <summary>
        /// 备用电源设置情况及总容量  0105011 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricity { get; set; }

        /// <summary>
        /// 备用电源设置情况及总容量  0105011 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricity { get; set; }

        /// <summary>
        /// 备用电源设置情况及总容量  0105011 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricity { get; set; }
        /// <summary>
        /// 备用电源装机密度  0105012
        /// </summary>
        public string StandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0105012 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0105012 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0105012 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensity { get; set; }
        /// <summary>
        /// 备用电源装机密度单位  0105013
        /// </summary>
        public string StandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0105013 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0105013 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0105013 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensityUnit { get; set; }
        /// <summary>
        /// 用电指标_经济适用房  0105014
        /// </summary>
        public string Indicators_AffordableHousing { get; set; }

        /// <summary>
        /// 用电指标_经济适用房  0105014 数据类别
        /// </summary>
        public string RecordTypeIndicators_AffordableHousing { get; set; }

        /// <summary>
        /// 用电指标_经济适用房  0105014 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_AffordableHousing { get; set; }

        /// <summary>
        /// 用电指标_经济适用房  0105014 是否公开
        /// </summary>
        public bool? IsPublicIndicators_AffordableHousing { get; set; }
        /// <summary>
        /// 用电指标_商品房  0105015
        /// </summary>
        public string Indicators_CommercialHousing { get; set; }

        /// <summary>
        /// 用电指标_商品房  0105015 数据类别
        /// </summary>
        public string RecordTypeIndicators_CommercialHousing { get; set; }

        /// <summary>
        /// 用电指标_商品房  0105015 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_CommercialHousing { get; set; }

        /// <summary>
        /// 用电指标_商品房  0105015 是否公开
        /// </summary>
        public bool? IsPublicIndicators_CommercialHousing { get; set; }
        /// <summary>
        /// 用电指标_公寓  0105016
        /// </summary>
        public string Indicators_Apartment { get; set; }

        /// <summary>
        /// 用电指标_公寓  0105016 数据类别
        /// </summary>
        public string RecordTypeIndicators_Apartment { get; set; }

        /// <summary>
        /// 用电指标_公寓  0105016 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Apartment { get; set; }

        /// <summary>
        /// 用电指标_公寓  0105016 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Apartment { get; set; }
        /// <summary>
        /// 用电指标_其他  0105017
        /// </summary>
        public string Indicators_Other { get; set; }

        /// <summary>
        /// 用电指标_其他  0105017 数据类别
        /// </summary>
        public string RecordTypeIndicators_Other { get; set; }

        /// <summary>
        /// 用电指标_其他  0105017 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Other { get; set; }

        /// <summary>
        /// 用电指标_其他  0105017 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Other { get; set; }
        /// <summary>
        /// 用电备注  0105018
        /// </summary>
        public string ElectricityMemo { get; set; }

        /// <summary>
        /// 用电备注  0105018 数据类别
        /// </summary>
        public string RecordTypeElectricityMemo { get; set; }

        /// <summary>
        /// 用电备注  0105018 是否必填
        /// </summary>
        public bool? IsRequiredElectricityMemo { get; set; }

        /// <summary>
        /// 用电备注  0105018 是否公开
        /// </summary>
        public bool? IsPublicElectricityMemo { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0105019
        /// </summary>
        public string StandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0105019 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0105019 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 是否公开备用电源装机密度KW  0105019
        /// </summary>
        public bool? IsPublicStandbyElectricityDensityKW { get; set; }
        /// <summary>
        /// 主要特点-建筑电气  0105020
        /// </summary>
        public string ElectricityFeatures_Electrical { get; set; }

        /// <summary>
        /// 主要特点-建筑电气  0105020 数据类别
        /// </summary>
        public string RecordTypeElectricityFeatures_Electrical { get; set; }

        /// <summary>
        /// 主要特点-建筑电气  0105020 是否必填
        /// </summary>
        public bool? IsRequiredElectricityFeatures_Electrical { get; set; }

        /// <summary>
        /// 是否公开主要特点-建筑电气  0105020
        /// </summary>
        public bool? IsPublicElectricityFeatures_Electrical { get; set; }
        /// <summary>
        /// 主要特点-建筑智能化  0105021
        /// </summary>
        public string ElectricityFeatures_Intelligence { get; set; }

        /// <summary>
        /// 主要特点-建筑智能化  0105021 数据类别
        /// </summary>
        public string RecordTypeElectricityFeatures_Intelligence { get; set; }

        /// <summary>
        /// 主要特点-建筑智能化  0105021 是否必填
        /// </summary>
        public bool? IsRequiredElectricityFeatures_Intelligence { get; set; }

        /// <summary>
        /// 是否公开主要特点-建筑智能化  0105021
        /// </summary>
        public bool? IsPublicElectricityFeatures_Intelligence { get; set; }
        /// <summary>
        /// 主要特点-绿色节能、环保措施  0105022
        /// </summary>
        public string ElectricityFeatures_Green { get; set; }

        /// <summary>
        /// 主要特点-绿色节能、环保措施  0105022 数据类别
        /// </summary>
        public string RecordTypeElectricityFeatures_Green { get; set; }

        /// <summary>
        /// 主要特点-绿色节能、环保措施  0105022 是否必填
        /// </summary>
        public bool? IsRequiredElectricityFeatures_Green { get; set; }

        /// <summary>
        /// 是否公开主要特点-绿色节能、环保措施  0105022
        /// </summary>
        public bool? IsPublicElectricityFeatures_Green { get; set; }
        /// <summary>
        /// 采暖方式  0105023
        /// </summary>
        public string HeatingMode { get; set; }

        /// <summary>
        /// 采暖方式  0105023 数据类别
        /// </summary>
        public string RecordTypeHeatingMode { get; set; }

        /// <summary>
        /// 采暖方式  0105023 是否必填
        /// </summary>
        public bool? IsRequiredHeatingMode { get; set; }

        /// <summary>
        /// 采暖方式  0105023 是否公开
        /// </summary>
        public bool? IsPublicHeatingMode { get; set; }
        /// <summary>
        /// 采暖/空调总热负荷  0105024
        /// </summary>
        public string SpaceHeatingLoad { get; set; }

        /// <summary>
        /// 采暖/空调总热负荷  0105024 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 采暖/空调总热负荷  0105024 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 采暖/空调总热负荷  0105024 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoad { get; set; }
        /// <summary>
        /// 空调总冷负荷  0105025
        /// </summary>
        public string AirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调总冷负荷  0105025 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调总冷负荷  0105025 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调总冷负荷  0105025 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingLoad { get; set; }
        /// <summary>
        /// 空调通风方式  0105026
        /// </summary>
        public string AirConVentilationMode { get; set; }

        /// <summary>
        /// 空调通风方式  0105026 数据类别
        /// </summary>
        public string RecordTypeAirConVentilationMode { get; set; }

        /// <summary>
        /// 空调通风方式  0105026 是否必填
        /// </summary>
        public bool? IsRequiredAirConVentilationMode { get; set; }

        /// <summary>
        /// 空调通风方式  0105026 是否公开
        /// </summary>
        public bool? IsPublicAirConVentilationMode { get; set; }
        /// <summary>
        /// 空调水系统方式  0105027
        /// </summary>
        public string AirConWaterSystemMode { get; set; }

        /// <summary>
        /// 空调水系统方式  0105027 数据类别
        /// </summary>
        public string RecordTypeAirConWaterSystemMode { get; set; }

        /// <summary>
        /// 空调水系统方式  0105027 是否必填
        /// </summary>
        public bool? IsRequiredAirConWaterSystemMode { get; set; }

        /// <summary>
        /// 空调水系统方式  0105027 是否公开
        /// </summary>
        public bool? IsPublicAirConWaterSystemMode { get; set; }
        /// <summary>
        /// 给水系统方式  0105028
        /// </summary>
        public string WaterSupplySystemMode { get; set; }

        /// <summary>
        /// 给水系统方式  0105028 数据类别
        /// </summary>
        public string RecordTypeWaterSupplySystemMode { get; set; }

        /// <summary>
        /// 给水系统方式  0105028 是否必填
        /// </summary>
        public bool? IsRequiredWaterSupplySystemMode { get; set; }

        /// <summary>
        /// 给水系统方式  0105028 是否公开
        /// </summary>
        public bool? IsPublicWaterSupplySystemMode { get; set; }
        /// <summary>
        /// 中水回收使用方式  0105029
        /// </summary>
        public string ReclaimedWaterRecycling { get; set; }

        /// <summary>
        /// 中水回收使用方式  0105029 数据类别
        /// </summary>
        public string RecordTypeReclaimedWaterRecycling { get; set; }

        /// <summary>
        /// 中水回收使用方式  0105029 是否必填
        /// </summary>
        public bool? IsRequiredReclaimedWaterRecycling { get; set; }

        /// <summary>
        /// 中水回收使用方式  0105029 是否公开
        /// </summary>
        public bool? IsPublicReclaimedWaterRecycling { get; set; }
        /// <summary>
        /// 雨、污水排放方式  0105030
        /// </summary>
        public string SewageDischargeMode { get; set; }

        /// <summary>
        /// 雨、污水排放方式  0105030 数据类别
        /// </summary>
        public string RecordTypeSewageDischargeMode { get; set; }

        /// <summary>
        /// 雨、污水排放方式  0105030 是否必填
        /// </summary>
        public bool? IsRequiredSewageDischargeMode { get; set; }

        /// <summary>
        /// 雨、污水排放方式  0105030 是否公开
        /// </summary>
        public bool? IsPublicSewageDischargeMode { get; set; }
        /// <summary>
        /// 消防给水方式  0105031
        /// </summary>
        public string FireWaterSupplyMode { get; set; }

        /// <summary>
        /// 消防给水方式  0105031 数据类别
        /// </summary>
        public string RecordTypeFireWaterSupplyMode { get; set; }

        /// <summary>
        /// 消防给水方式  0105031 是否必填
        /// </summary>
        public bool? IsRequiredFireWaterSupplyMode { get; set; }

        /// <summary>
        /// 消防给水方式  0105031 是否公开
        /// </summary>
        public bool? IsPublicFireWaterSupplyMode { get; set; }
        /// <summary>
        /// 设备专业设计主要特点  0105032
        /// </summary>
        public string MechanicalMainFeatures { get; set; }

        /// <summary>
        /// 设备专业设计主要特点  0105032 数据类别
        /// </summary>
        public string RecordTypeMechanicalMainFeatures { get; set; }

        /// <summary>
        /// 设备专业设计主要特点  0105032 是否必填
        /// </summary>
        public bool? IsRequiredMechanicalMainFeatures { get; set; }

        /// <summary>
        /// 设备专业设计主要特点  0105032 是否公开
        /// </summary>
        public bool? IsPublicMechanicalMainFeatures { get; set; }


    }


    /// <summary>
    /// 公建模板—技术申报内容—技术经济指标
    /// </summary>
    [Serializable]
    public class Template_0106 : TemplateBase
    {
        /// <summary>
        /// 单位规模建筑面积指标  0106001
        /// </summary>
        public string UnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0106001 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0106001 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0106001 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicators { get; set; }
        /// <summary>
        /// 单位规模建筑面积指标单位  0106002
        /// </summary>
        public string UnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0106002 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0106002 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0106002 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicatorsUnit { get; set; }
        /// <summary>
        /// 使用面积系数  0106003
        /// </summary>
        public string UseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0106003 数据类别
        /// </summary>
        public string RecordTypeUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0106003 是否必填
        /// </summary>
        public bool? IsRequiredUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0106003 是否公开
        /// </summary>
        public bool? IsPublicUseAreaCoefficient { get; set; }
        /// <summary>
        /// 单位建筑面积耗热量指标  0106004
        /// </summary>
        public string UnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0106004 数据类别
        /// </summary>
        public string RecordTypeUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0106004 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0106004 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaHotConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积耗冷量指标  0106005
        /// </summary>
        public string UnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0106005 数据类别
        /// </summary>
        public string RecordTypeUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0106005 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0106005 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaColdConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积变压器装机容量  0106006
        /// </summary>
        public string UnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0106006 数据类别
        /// </summary>
        public string RecordTypeUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0106006 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0106006 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaTransformerCapacity { get; set; }
        /// <summary>
        /// 日供水量  0106007
        /// </summary>
        public string DailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0106007 数据类别
        /// </summary>
        public string RecordTypeDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0106007 是否必填
        /// </summary>
        public bool? IsRequiredDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0106007 是否公开
        /// </summary>
        public bool? IsPublicDailyWaterSupply { get; set; }
        /// <summary>
        /// 概算_总造价_人民币  0106008
        /// </summary>
        public string Estimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0106008 数据类别
        /// </summary>
        public string RecordTypeEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0106008 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0106008 是否公开
        /// </summary>
        public bool? IsPublicEstimate_RMB { get; set; }
        /// <summary>
        /// 概算_总造价_外币  0106009
        /// </summary>
        public string Estimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0106009 数据类别
        /// </summary>
        public string RecordTypeEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0106009 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0106009 是否公开
        /// </summary>
        public bool? IsPublicEstimate_ForeignCurrency { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0106010
        /// </summary>
        public string Estimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0106010 数据类别
        /// </summary>
        public string RecordTypeEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0106010 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0106010 是否公开
        /// </summary>
        public bool? IsPublicEstimate_CivilEngineering { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0106011
        /// </summary>
        public string Estimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0106011 数据类别
        /// </summary>
        public string RecordTypeEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0106011 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0106011 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Install { get; set; }
        /// <summary>
        /// 概算_单位建筑面积造价  0106012
        /// </summary>
        public string Estimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0106012 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0106012 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0106012 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitAreaRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价  0106013
        /// </summary>
        public string Estimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0106013 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0106013 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0106013 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价单位  0106014
        /// </summary>
        public string Estimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0106014 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0106014 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0106014 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 竣工决算_总造价_人民币  0106015
        /// </summary>
        public string Settlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0106015 数据类别
        /// </summary>
        public string RecordTypeSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0106015 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0106015 是否公开
        /// </summary>
        public bool? IsPublicSettlement_RMB { get; set; }
        /// <summary>
        /// 竣工决算_总造价_外币  0106016
        /// </summary>
        public string Settlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0106016 数据类别
        /// </summary>
        public string RecordTypeSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0106016 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0106016 是否公开
        /// </summary>
        public bool? IsPublicSettlement_ForeignCurrency { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0106017
        /// </summary>
        public string Settlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0106017 数据类别
        /// </summary>
        public string RecordTypeSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0106017 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0106017 是否公开
        /// </summary>
        public bool? IsPublicSettlement_CivilEngineering { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0106018
        /// </summary>
        public string Settlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0106018 数据类别
        /// </summary>
        public string RecordTypeSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0106018 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0106018 是否公开
        /// </summary>
        public bool? IsPublicSettlement_Install { get; set; }
        /// <summary>
        /// 竣工决算_单位建筑面积造价  0106019
        /// </summary>
        public string Settlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0106019 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0106019 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0106019 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitAreaRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价  0106020
        /// </summary>
        public string Settlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0106020 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0106020 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0106020 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价单位  0106021
        /// </summary>
        public string Settlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0106021 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0106021 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0106021 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 结算与概算出入的主要原因  0106022
        /// </summary>
        public string Estimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0106022 数据类别
        /// </summary>
        public string RecordTypeEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0106022 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0106022 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Settlement_Difference { get; set; }
        /// <summary>
        /// 经济专业主要特点  0106023
        /// </summary>
        public string EconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0106023 数据类别
        /// </summary>
        public string RecordTypeEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0106023 是否必填
        /// </summary>
        public bool? IsRequiredEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0106023 是否公开
        /// </summary>
        public bool? IsPublicEconomicsFeatures { get; set; }
        /// <summary>
        /// 动力总电负荷  0106024
        /// </summary>
        public string PowerTotalElectricLoad { get; set; }

        /// <summary>
        /// 动力总电负荷  0106024 数据类别
        /// </summary>
        public string RecordTypePowerTotalElectricLoad { get; set; }

        /// <summary>
        /// 动力总电负荷  0106024 是否必填
        /// </summary>
        public bool? IsRequiredPowerTotalElectricLoad { get; set; }

        /// <summary>
        /// 动力总电负荷  0106024 是否公开
        /// </summary>
        public bool? IsPublicPowerTotalElectricLoad { get; set; }
        /// <summary>
        /// 照明总电负荷  0106025
        /// </summary>
        public string LightingTotalElectricLoad { get; set; }

        /// <summary>
        /// 照明总电负荷  0106025 数据类别
        /// </summary>
        public string RecordTypeLightingTotalElectricLoad { get; set; }

        /// <summary>
        /// 照明总电负荷  0106025 是否必填
        /// </summary>
        public bool? IsRequiredLightingTotalElectricLoad { get; set; }

        /// <summary>
        /// 照明总电负荷  0106025 是否公开
        /// </summary>
        public bool? IsPublicLightingTotalElectricLoad { get; set; }
        /// <summary>
        /// 供电电源设计情况  0106026
        /// </summary>
        public string DesignOfPowerSupply { get; set; }

        /// <summary>
        /// 供电电源设计情况  0106026 数据类别
        /// </summary>
        public string RecordTypeDesignOfPowerSupply { get; set; }

        /// <summary>
        /// 供电电源设计情况  0106026 是否必填
        /// </summary>
        public bool? IsRequiredDesignOfPowerSupply { get; set; }

        /// <summary>
        /// 供电电源设计情况  0106026 是否公开
        /// </summary>
        public bool? IsPublicDesignOfPowerSupply { get; set; }
        /// <summary>
        /// 变压器装机台数  0106027
        /// </summary>
        public string TransformerInstalledNumber { get; set; }

        /// <summary>
        /// 变压器装机台数  0106027 数据类别
        /// </summary>
        public string RecordTypeTransformerInstalledNumber { get; set; }

        /// <summary>
        /// 变压器装机台数  0106027 是否必填
        /// </summary>
        public bool? IsRequiredTransformerInstalledNumber { get; set; }

        /// <summary>
        /// 变压器装机台数  0106027 是否公开
        /// </summary>
        public bool? IsPublicTransformerInstalledNumber { get; set; }
        /// <summary>
        /// 变压器装机容量  0106028
        /// </summary>
        public string TransformerInstalledCapacity { get; set; }

        /// <summary>
        /// 变压器装机容量  0106028 数据类别
        /// </summary>
        public string RecordTypeTransformerInstalledCapacity { get; set; }

        /// <summary>
        /// 变压器装机容量  0106028 是否必填
        /// </summary>
        public bool? IsRequiredTransformerInstalledCapacity { get; set; }

        /// <summary>
        /// 变压器装机容量  0106028 是否公开
        /// </summary>
        public bool? IsPublicTransformerInstalledCapacity { get; set; }
        /// <summary>
        /// 防雷设防类别及方式  0106029
        /// </summary>
        public string LightningProtectionClass { get; set; }

        /// <summary>
        /// 防雷设防类别及方式  0106029 数据类别
        /// </summary>
        public string RecordTypeLightningProtectionClass { get; set; }

        /// <summary>
        /// 防雷设防类别及方式  0106029 是否必填
        /// </summary>
        public bool? IsRequiredLightningProtectionClass { get; set; }

        /// <summary>
        /// 防雷设防类别及方式  0106029 是否公开
        /// </summary>
        public bool? IsPublicLightningProtectionClass { get; set; }
        /// <summary>
        /// 动力内容  0106030
        /// </summary>
        public string DynamicContent { get; set; }

        /// <summary>
        /// 动力内容  0106030 数据类别
        /// </summary>
        public string RecordTypeDynamicContent { get; set; }

        /// <summary>
        /// 动力内容  0106030 是否必填
        /// </summary>
        public bool? IsRequiredDynamicContent { get; set; }

        /// <summary>
        /// 动力内容  0106030 是否公开
        /// </summary>
        public bool? IsPublicDynamicContent { get; set; }
        /// <summary>
        /// 弱电设计内容  0106031
        /// </summary>
        public string WeakDesignContent { get; set; }

        /// <summary>
        /// 弱电设计内容  0106031 数据类别
        /// </summary>
        public string RecordTypeWeakDesignContent { get; set; }

        /// <summary>
        /// 弱电设计内容  0106031 是否必填
        /// </summary>
        public bool? IsRequiredWeakDesignContent { get; set; }

        /// <summary>
        /// 弱电设计内容  0106031 是否公开
        /// </summary>
        public bool? IsPublicWeakDesignContent { get; set; }
        /// <summary>
        /// 照明方式节能措施  0106032
        /// </summary>
        public string EnergySavingMeasures { get; set; }

        /// <summary>
        /// 照明方式节能措施  0106032 数据类别
        /// </summary>
        public string RecordTypeEnergySavingMeasures { get; set; }

        /// <summary>
        /// 照明方式节能措施  0106032 是否必填
        /// </summary>
        public bool? IsRequiredEnergySavingMeasures { get; set; }

        /// <summary>
        /// 照明方式节能措施  0106032 是否公开
        /// </summary>
        public bool? IsPublicEnergySavingMeasures { get; set; }
        /// <summary>
        /// 用电负荷等级确定情况  0106033
        /// </summary>
        public string PowerLoadLevel { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0106033 数据类别
        /// </summary>
        public string RecordTypePowerLoadLevel { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0106033 是否必填
        /// </summary>
        public bool? IsRequiredPowerLoadLevel { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0106033 是否公开
        /// </summary>
        public bool? IsPublicPowerLoadLevel { get; set; }
        /// <summary>
        /// 电气专业设计主要特点  0106034
        /// </summary>
        public string ElectricalMainFeatures { get; set; }

        /// <summary>
        /// 电气专业设计主要特点  0106034 数据类别
        /// </summary>
        public string RecordTypeElectricalMainFeatures { get; set; }

        /// <summary>
        /// 电气专业设计主要特点  0106034 是否必填
        /// </summary>
        public bool? IsRequiredElectricalMainFeatures { get; set; }

        /// <summary>
        /// 电气专业设计主要特点  0106034 是否公开
        /// </summary>
        public bool? IsPublicElectricalMainFeatures { get; set; }

    }
    [Serializable]
    public class Template_0107 : TemplateBase
    {
        /// <summary>
        /// 单位规模建筑面积指标  0107001
        /// </summary>
        public string UnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0107001 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0107001 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0107001 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicators { get; set; }
        /// <summary>
        /// 单位规模建筑面积指标单位  0107002
        /// </summary>
        public string UnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0107002 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0107002 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0107002 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicatorsUnit { get; set; }
        /// <summary>
        /// 使用面积系数  0107003
        /// </summary>
        public string UseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0107003 数据类别
        /// </summary>
        public string RecordTypeUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0107003 是否必填
        /// </summary>
        public bool? IsRequiredUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0107003 是否公开
        /// </summary>
        public bool? IsPublicUseAreaCoefficient { get; set; }
        /// <summary>
        /// 单位建筑面积耗热量指标  0107004
        /// </summary>
        public string UnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0107004 数据类别
        /// </summary>
        public string RecordTypeUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0107004 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0107004 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaHotConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积耗冷量指标  0107005
        /// </summary>
        public string UnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0107005 数据类别
        /// </summary>
        public string RecordTypeUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0107005 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0107005 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaColdConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积变压器装机容量  0107006
        /// </summary>
        public string UnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0107006 数据类别
        /// </summary>
        public string RecordTypeUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0107006 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0107006 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaTransformerCapacity { get; set; }
        /// <summary>
        /// 日供水量  0107007
        /// </summary>
        public string DailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0107007 数据类别
        /// </summary>
        public string RecordTypeDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0107007 是否必填
        /// </summary>
        public bool? IsRequiredDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0107007 是否公开
        /// </summary>
        public bool? IsPublicDailyWaterSupply { get; set; }
        /// <summary>
        /// 概算_总造价_人民币  0107008
        /// </summary>
        public string Estimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0107008 数据类别
        /// </summary>
        public string RecordTypeEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0107008 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0107008 是否公开
        /// </summary>
        public bool? IsPublicEstimate_RMB { get; set; }
        /// <summary>
        /// 概算_总造价_外币  0107009
        /// </summary>
        public string Estimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0107009 数据类别
        /// </summary>
        public string RecordTypeEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0107009 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0107009 是否公开
        /// </summary>
        public bool? IsPublicEstimate_ForeignCurrency { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0107010
        /// </summary>
        public string Estimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0107010 数据类别
        /// </summary>
        public string RecordTypeEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0107010 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0107010 是否公开
        /// </summary>
        public bool? IsPublicEstimate_CivilEngineering { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0107011
        /// </summary>
        public string Estimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0107011 数据类别
        /// </summary>
        public string RecordTypeEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0107011 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0107011 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Install { get; set; }
        /// <summary>
        /// 概算_单位建筑面积造价  0107012
        /// </summary>
        public string Estimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0107012 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0107012 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0107012 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitAreaRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价  0107013
        /// </summary>
        public string Estimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0107013 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0107013 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0107013 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价单位  0107014
        /// </summary>
        public string Estimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0107014 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0107014 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0107014 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 概算_绿色建筑增量成本  0107015
        /// </summary>
        public string Estimate_IncrementalCost { get; set; }

        /// <summary>
        /// 概算_绿色建筑增量成本  0107015 数据类别
        /// </summary>
        public string RecordTypeEstimate_IncrementalCost { get; set; }

        /// <summary>
        /// 概算_绿色建筑增量成本  0107015 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_IncrementalCost { get; set; }

        /// <summary>
        /// 概算_绿色建筑增量成本  0107015 是否公开
        /// </summary>
        public bool? IsPublicEstimate_IncrementalCost { get; set; }
        /// <summary>
        /// 竣工决算_总造价_人民币  0107016
        /// </summary>
        public string Settlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0107016 数据类别
        /// </summary>
        public string RecordTypeSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0107016 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0107016 是否公开
        /// </summary>
        public bool? IsPublicSettlement_RMB { get; set; }
        /// <summary>
        /// 竣工决算_总造价_外币  0107017
        /// </summary>
        public string Settlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0107017 数据类别
        /// </summary>
        public string RecordTypeSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0107017 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0107017 是否公开
        /// </summary>
        public bool? IsPublicSettlement_ForeignCurrency { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0107018
        /// </summary>
        public string Settlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0107018 数据类别
        /// </summary>
        public string RecordTypeSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0107018 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0107018 是否公开
        /// </summary>
        public bool? IsPublicSettlement_CivilEngineering { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0107019
        /// </summary>
        public string Settlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0107019 数据类别
        /// </summary>
        public string RecordTypeSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0107019 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0107019 是否公开
        /// </summary>
        public bool? IsPublicSettlement_Install { get; set; }
        /// <summary>
        /// 竣工决算_单位建筑面积造价  0107020
        /// </summary>
        public string Settlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0107020 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0107020 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0107020 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitAreaRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价  0107021
        /// </summary>
        public string Settlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0107021 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0107021 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0107021 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价单位  0107022
        /// </summary>
        public string Settlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0107022 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0107022 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0107022 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0107023
        /// </summary>
        public string Settlement_IncrementalCost { get; set; }

        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0107023 数据类别
        /// </summary>
        public string RecordTypeSettlement_IncrementalCost { get; set; }

        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0107023 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_IncrementalCost { get; set; }

        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0107023 是否公开
        /// </summary>
        public bool? IsPublicSettlement_IncrementalCost { get; set; }
        /// <summary>
        /// 结算与概算出入的主要原因  0107024
        /// </summary>
        public string Estimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0107024 数据类别
        /// </summary>
        public string RecordTypeEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0107024 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0107024 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Settlement_Difference { get; set; }
        /// <summary>
        /// 经济专业主要特点  0107025
        /// </summary>
        public string EconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0107025 数据类别
        /// </summary>
        public string RecordTypeEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0107025 是否必填
        /// </summary>
        public bool? IsRequiredEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0107025 是否公开
        /// </summary>
        public bool? IsPublicEconomicsFeatures { get; set; }
        /// <summary>
        /// 曾获奖项  0107026
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0107026 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0107026 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0107026 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  0107027
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0107027 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0107027 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0107027 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0107028
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0107028 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0107028 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0107028 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }


    }
}