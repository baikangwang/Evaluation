using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 优秀工程勘察奖申报模板
    /// </summary>
    [Serializable]
    public class Template_14_Survey : TemplateBase
    {
        /// <summary>
        /// 优秀工程勘察奖—基础信息
        /// </summary>
        public Template_1401 Part_01 { get; set; }

        /// <summary>
        /// 优秀工程勘察奖—技术申报内容
        /// </summary>
        public Template_1402 Part_02 { get; set; }

        /// <summary>
        /// 优秀工程勘察奖—审核意见
        /// </summary>
        public Template_1403 Part_03 { get; set; }
    }

    /// <summary>
    /// 优秀工程勘察奖—基础信息
    /// </summary>
    [Serializable]
    public class Template_1401 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1401001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1401001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1401001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1401001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 申报奖项种类  1401002
        /// </summary>
        public string DeclarationPrize { get; set; }

        /// <summary>
        /// 申报奖项种类  1401002 数据类别
        /// </summary>
        public string RecordTypeDeclarationPrize { get; set; }

        /// <summary>
        /// 申报奖项种类  1401002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationPrize { get; set; }

        /// <summary>
        /// 申报奖项种类  1401002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationPrize { get; set; }
        /// <summary>
        /// 项目主要技术经济指标水平  1401003
        /// </summary>
        public string TechnicalEconomicIndicators { get; set; }

        /// <summary>
        /// 项目主要技术经济指标水平  1401003 数据类别
        /// </summary>
        public string RecordTypeTechnicalEconomicIndicators { get; set; }

        /// <summary>
        /// 项目主要技术经济指标水平  1401003 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalEconomicIndicators { get; set; }

        /// <summary>
        /// 项目主要技术经济指标水平  1401003 是否公开
        /// </summary>
        public bool? IsPublicTechnicalEconomicIndicators { get; set; }
        /// <summary>
        /// 申报单位  1401004
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1401004 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1401004 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1401004 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 合作单位1  1401005
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1401005 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1401005 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1401005 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1401006
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1401006 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1401006 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1401006 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1401007
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1401007 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1401007 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1401007 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  1401008
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1401008 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1401008 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1401008 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1401009
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1401009 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1401009 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1401009 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1401010
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1401010 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1401010 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1401010 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  1401011
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1401011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1401011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1401011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1401012
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1401012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1401012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1401012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1401013
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1401013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1401013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1401013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  1401014
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1401014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1401014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1401014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1401015
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1401015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1401015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1401015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1401016
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1401016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1401016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1401016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 通讯地址  1401017
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1401017 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1401017 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1401017 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  1401018
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  1401018 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  1401018 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  1401018 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 传真  1401019
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1401019 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1401019 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1401019 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电话  1401020
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1401020 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1401020 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1401020 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1401021
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1401021 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1401021 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1401021 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 手机  1401022
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1401022 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1401022 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1401022 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1401023
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1401023 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1401023 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1401023 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 项目申报单位资质证书名称  1401024
        /// </summary>
        public string CertificateName { get; set; }

        /// <summary>
        /// 项目申报单位资质证书名称  1401024 数据类别
        /// </summary>
        public string RecordTypeCertificateName { get; set; }

        /// <summary>
        /// 项目申报单位资质证书名称  1401024 是否必填
        /// </summary>
        public bool? IsRequiredCertificateName { get; set; }

        /// <summary>
        /// 项目申报单位资质证书名称  1401024 是否公开
        /// </summary>
        public bool? IsPublicCertificateName { get; set; }
        /// <summary>
        /// 项目申报单位资质证书编号  1401025
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 项目申报单位资质证书编号  1401025 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 项目申报单位资质证书编号  1401025 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 项目申报单位资质证书编号  1401025 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }
        /// <summary>
        /// 建设单位  1401026
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1401026 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1401026 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1401026 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 项目开始时间  1401027
        /// </summary>
        public string ProjectStartDate { get; set; }

        /// <summary>
        /// 项目开始时间  1401027 数据类别
        /// </summary>
        public string RecordTypeProjectStartDate { get; set; }

        /// <summary>
        /// 项目开始时间  1401027 是否必填
        /// </summary>
        public bool? IsRequiredProjectStartDate { get; set; }

        /// <summary>
        /// 项目开始时间  1401027 是否公开
        /// </summary>
        public bool? IsPublicProjectStartDate { get; set; }
        /// <summary>
        /// 项目结束时间  1401028
        /// </summary>
        public string ProjectEndDate { get; set; }

        /// <summary>
        /// 项目结束时间  1401028 数据类别
        /// </summary>
        public string RecordTypeProjectEndDate { get; set; }

        /// <summary>
        /// 项目结束时间  1401028 是否必填
        /// </summary>
        public bool? IsRequiredProjectEndDate { get; set; }

        /// <summary>
        /// 项目结束时间  1401028 是否公开
        /// </summary>
        public bool? IsPublicProjectEndDate { get; set; }
        /// <summary>
        /// 项目建成/完成时间  1401029
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 项目建成/完成时间  1401029 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 项目建成/完成时间  1401029 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 项目建成/完成时间  1401029 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 验收部门  1401030
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1401030 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1401030 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1401030 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 验收时间  1401031
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  1401031 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  1401031 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  1401031 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 申报等级  1401032
        /// </summary>
        public string DeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1401032 数据类别
        /// </summary>
        public string RecordTypeDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1401032 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationLevel { get; set; }

        /// <summary>
        /// 申报等级  1401032 是否公开
        /// </summary>
        public bool? IsPublicDeclarationLevel { get; set; }
        /// <summary>
        /// 曾获奖项  1401033
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1401033 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1401033 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1401033 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
    }

    /// <summary>
    /// 优秀工程勘察奖—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_1402 : TemplateBase
    {
        /// <summary>
        /// 项目概况、规模、影响程度  1402001
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况、规模、影响程度  1402001 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况、规模、影响程度  1402001 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况、规模、影响程度  1402001 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 技术特色，主要技术成果指标水平  1402002
        /// </summary>
        public string TechnicalFeature { get; set; }

        /// <summary>
        /// 技术特色，主要技术成果指标水平  1402002 数据类别
        /// </summary>
        public string RecordTypeTechnicalFeature { get; set; }

        /// <summary>
        /// 技术特色，主要技术成果指标水平  1402002 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalFeature { get; set; }

        /// <summary>
        /// 技术特色，主要技术成果指标水平  1402002 是否公开
        /// </summary>
        public bool? IsPublicTechnicalFeature { get; set; }
        /// <summary>
        /// 解决技术难题、工程问题的成效与深度  1402003
        /// </summary>
        public string Effectiveness { get; set; }

        /// <summary>
        /// 解决技术难题、工程问题的成效与深度  1402003 数据类别
        /// </summary>
        public string RecordTypeEffectiveness { get; set; }

        /// <summary>
        /// 解决技术难题、工程问题的成效与深度  1402003 是否必填
        /// </summary>
        public bool? IsRequiredEffectiveness { get; set; }

        /// <summary>
        /// 解决技术难题、工程问题的成效与深度  1402003 是否公开
        /// </summary>
        public bool? IsPublicEffectiveness { get; set; }
        /// <summary>
        /// 经济、社会、环境效益  1402004
        /// </summary>
        public string Benefits { get; set; }

        /// <summary>
        /// 经济、社会、环境效益  1402004 数据类别
        /// </summary>
        public string RecordTypeBenefits { get; set; }

        /// <summary>
        /// 经济、社会、环境效益  1402004 是否必填
        /// </summary>
        public bool? IsRequiredBenefits { get; set; }

        /// <summary>
        /// 经济、社会、环境效益  1402004 是否公开
        /// </summary>
        public bool? IsPublicBenefits { get; set; }
    }

    /// <summary>
    /// 优秀工程勘察奖—审核意见
    /// </summary>
    [Serializable]
    public class Template_1403 : TemplateBase
    {
        /// <summary>
        /// 曾获奖项  1403001
        /// </summary>
        public string Award { get; set; }

        /// <summary>
        /// 曾获奖项  1403001 数据类别
        /// </summary>
        public string RecordTypeAward { get; set; }

        /// <summary>
        /// 曾获奖项  1403001 是否必填
        /// </summary>
        public bool? IsRequiredAward { get; set; }

        /// <summary>
        /// 是否公开曾获奖项  1403001
        /// </summary>
        public bool? IsPublicAward { get; set; }

        /// <summary>
        /// 申报单位意见  1403002
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1403002 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1403002 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 是否公开申报单位意见  1403002
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 申报单位意见填写时间  1403003
        /// </summary>
        public string UnitOpinionTime { get; set; }

        /// <summary>
        ///  申报单位意见填写时间  1403003 数据类别
        /// </summary>
        public string RecordTypeUnitOpinionTime { get; set; }

        /// <summary>
        ///  申报单位意见填写时间  1403003 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinionTime { get; set; }

        /// <summary>
        /// 是否公开申报单位意见填写时间  1403003
        /// </summary>
        public bool? IsPublicUnitOpinionTime { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1403004
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        ///  地方、部门勘察设计同业协会推荐意见  1403004 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1403004 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 是否公开地方、部门勘察设计同业协会推荐意见  1403004
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见填写时间  1403005
        /// </summary>
        public string RecommendOpinionTime { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见填写时间  1403005 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinionTime { get; set; }

        /// <summary>
        ///地方、部门勘察设计同业协会推荐意见填写时间  1403005 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinionTime { get; set; }

        /// <summary>
        /// 是否公开地方、部门勘察设计同业协会推荐意见填写时间  1403005
        /// </summary>
        public bool? IsPublicRecommendOpinionTime { get; set; }

    }
}
