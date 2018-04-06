using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 人防工程专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_10_CivilAirDefence : TemplateBase
    {
        /// <summary>
        /// 人防工程专项奖申报模板—基础信息
        /// </summary>
        public Template_1001 Part_01 { get; set; }

        /// <summary>
        /// 人防工程专项奖申报模板—技术申报内容
        /// </summary>
        public Template_1002 Part_02 { get; set; }

    }

    /// <summary>
    /// 人防工程专项奖申报模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_1001 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  1001001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  1001001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  1001001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  1001001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  1001002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  1001002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  1001002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  1001002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  1001003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1001003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1001003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1001003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  1001004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1001004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1001004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1001004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  1001005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  1001005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  1001005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  1001005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  1001006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1001006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1001006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1001006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  1001007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1001007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1001007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1001007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1001008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1001008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1001008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1001008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  1001009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1001009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1001009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1001009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1001010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1001010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1001010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1001010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  1001011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1001011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1001011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1001011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1001012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1001012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1001012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1001012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1001013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1001013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1001013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1001013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  1001014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1001014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1001014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1001014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1001015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1001015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1001015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1001015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1001016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1001016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1001016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1001016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  1001017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1001017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1001017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1001017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1001018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1001018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1001018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1001018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1001019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1001019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1001019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1001019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  1001020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1001020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1001020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1001020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1001021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1001021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1001021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1001021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1001022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1001022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1001022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1001022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  1001023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1001023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1001023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1001023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  1001024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1001024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1001024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1001024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  1001025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  1001025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  1001025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  1001025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  1001026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1001026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1001026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1001026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  1001027
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1001027 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1001027 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1001027 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  1001028
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  1001028 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  1001028 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  1001028 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  1001029
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  1001029 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  1001029 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  1001029 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  1001030
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1001030 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1001030 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1001030 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  1001031
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1001031 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1001031 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1001031 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  1001032
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1001032 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1001032 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1001032 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  1001033
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1001033 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1001033 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1001033 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  1001034
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1001034 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1001034 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1001034 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  1001035
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1001035 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1001035 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1001035 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 投资来源  1001036
        /// </summary>
        public string InvestSource { get; set; }

        /// <summary>
        /// 投资来源  1001036 数据类别
        /// </summary>
        public string RecordTypeInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1001036 是否必填
        /// </summary>
        public bool? IsRequiredInvestSource { get; set; }

        /// <summary>
        /// 投资来源  1001036 是否公开
        /// </summary>
        public bool? IsPublicInvestSource { get; set; }
        /// <summary>
        /// 申报等级  1001037
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1001037 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1001037 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1001037 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }

        /// <summary>
        /// 专业类别  1001038
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   1001038 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   1001038 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   1001038 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 单位资质  1001039
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  1001039 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  1001039 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  1001039 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }

        /// <summary>
        /// 证书编号  1001040
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        ///  证书编号  1001040 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        ///  证书编号  1001040 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        ///  证书编号  1001040 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }
    }

    /// <summary>
    /// 人防工程专项奖申报模板—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_1002 : TemplateBase
    {
        /// <summary>
        /// 人防工程设计项目特点_项目概况  1002001
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_项目概况  1002001 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_项目概况  1002001 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_项目概况  1002001 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 人防工程设计项目特点_技术特色  1002002
        /// </summary>
        public string TechnologyFeature { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_技术特色  1002002 数据类别
        /// </summary>
        public string RecordTypeTechnologyFeature { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_技术特色  1002002 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyFeature { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_技术特色  1002002 是否公开
        /// </summary>
        public bool? IsPublicTechnologyFeature { get; set; }
        /// <summary>
        /// 人防工程设计项目特点_技术成效与深度  1002003
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_技术成效与深度  1002003 数据类别
        /// </summary>
        public string RecordTypeEffect { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_技术成效与深度  1002003 是否必填
        /// </summary>
        public bool? IsRequiredEffect { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_技术成效与深度  1002003 是否公开
        /// </summary>
        public bool? IsPublicEffect { get; set; }
        /// <summary>
        /// 人防工程设计项目特点_综合效益  1002004
        /// </summary>
        public string Benefit { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_综合效益  1002004 数据类别
        /// </summary>
        public string RecordTypeBenefit { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_综合效益  1002004 是否必填
        /// </summary>
        public bool? IsRequiredBenefit { get; set; }

        /// <summary>
        /// 人防工程设计项目特点_综合效益  1002004 是否公开
        /// </summary>
        public bool? IsPublicBenefit { get; set; }
        /// <summary>
        /// 技术指标及先进性_建筑专业  1002005
        /// </summary>
        public string Indicators_Construct { get; set; }

        /// <summary>
        /// 技术指标及先进性_建筑专业  1002005 数据类别
        /// </summary>
        public string RecordTypeIndicators_Construct { get; set; }

        /// <summary>
        /// 技术指标及先进性_建筑专业  1002005 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Construct { get; set; }

        /// <summary>
        /// 技术指标及先进性_建筑专业  1002005 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Construct { get; set; }
        /// <summary>
        /// 技术指标及先进性_结构专业  1002006
        /// </summary>
        public string Indicators_Structure { get; set; }

        /// <summary>
        /// 技术指标及先进性_结构专业  1002006 数据类别
        /// </summary>
        public string RecordTypeIndicators_Structure { get; set; }

        /// <summary>
        /// 技术指标及先进性_结构专业  1002006 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Structure { get; set; }

        /// <summary>
        /// 技术指标及先进性_结构专业  1002006 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Structure { get; set; }
        /// <summary>
        /// 技术指标及先进性_暖通空调专业  1002007
        /// </summary>
        public string Indicators_HVAC { get; set; }

        /// <summary>
        /// 技术指标及先进性_暖通空调专业  1002007 数据类别
        /// </summary>
        public string RecordTypeIndicators_HVAC { get; set; }

        /// <summary>
        /// 技术指标及先进性_暖通空调专业  1002007 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_HVAC { get; set; }

        /// <summary>
        /// 技术指标及先进性_暖通空调专业  1002007 是否公开
        /// </summary>
        public bool? IsPublicIndicators_HVAC { get; set; }
        /// <summary>
        /// 技术指标及先进性_给排水专业  1002008
        /// </summary>
        public string Indicators_SupplyAndDrainage { get; set; }

        /// <summary>
        /// 技术指标及先进性_给排水专业  1002008 数据类别
        /// </summary>
        public string RecordTypeIndicators_SupplyAndDrainage { get; set; }

        /// <summary>
        /// 技术指标及先进性_给排水专业  1002008 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_SupplyAndDrainage { get; set; }

        /// <summary>
        /// 技术指标及先进性_给排水专业  1002008 是否公开
        /// </summary>
        public bool? IsPublicIndicators_SupplyAndDrainage { get; set; }
        /// <summary>
        /// 技术指标及先进性_电气专业  1002009
        /// </summary>
        public string Indicators_Electric { get; set; }

        /// <summary>
        /// 技术指标及先进性_电气专业  1002009 数据类别
        /// </summary>
        public string RecordTypeIndicators_Electric { get; set; }

        /// <summary>
        /// 技术指标及先进性_电气专业  1002009 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Electric { get; set; }

        /// <summary>
        /// 技术指标及先进性_电气专业  1002009 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Electric { get; set; }
        /// <summary>
        /// 技术指标及先进性_防护和防化专业  1002010
        /// </summary>
        public string Indicators_Antichemical { get; set; }

        /// <summary>
        /// 技术指标及先进性_防护和防化专业  1002010 数据类别
        /// </summary>
        public string RecordTypeIndicators_Antichemical { get; set; }

        /// <summary>
        /// 技术指标及先进性_防护和防化专业  1002010 是否必填
        /// </summary>
        public bool? IsRequiredIndicators_Antichemical { get; set; }

        /// <summary>
        /// 技术指标及先进性_防护和防化专业  1002010 是否公开
        /// </summary>
        public bool? IsPublicIndicators_Antichemical { get; set; }

        /// <summary>
        /// 曾获奖项  1002011
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1002011 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1002011 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1002011 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  1002012
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1002012 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1002012 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1002012 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1002013
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1002013 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1002013 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1002013 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }

}
