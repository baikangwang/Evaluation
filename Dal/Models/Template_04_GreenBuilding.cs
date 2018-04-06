using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 绿色建筑模板
    /// </summary>
    [Serializable]
    public class Template_04_GreenBuilding : TemplateBase
    {
        /// <summary>
        /// 绿色建筑模板—基础信息
        /// </summary>
        public Template_0401 Part_01 { get; set; }

        /// <summary>
        /// 绿色建筑模板—工程勘察设计项目特点
        /// </summary>
        public Template_0402 Part_02 { get; set; }

        /// <summary>
        /// 绿色建筑模板—专业技术指标（建筑专业）
        /// </summary>
        public Template_0403 Part_03 { get; set; }

        /// <summary>
        /// 绿色建筑模板—专业技术指标（结构专业）
        /// </summary>
        public Template_0404 Part_04 { get; set; }

        /// <summary>
        /// 绿色建筑模板—专业技术指标（设备专业）
        /// </summary>
        public Template_0405 Part_05 { get; set; }

        /// <summary>
        /// 绿建—专业技术指标（电气专业）
        /// </summary>
        public Template_0406 Part_06 { get; set; }

        /// <summary>
        /// 绿建—专业技术指标（技术经济指标）
        /// </summary>
        public Template_0407 Part_07 { get; set; }

        /// <summary>
        /// 绿建—审核意见
        /// </summary>
        public Template_0408 Part_08 { get; set; }
    }

    /// <summary>
    /// 绿色建筑模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_0401 : TemplateBase
    {
        /// <summary>
        /// 项目名称  0401001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0401001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0401001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0401001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 主要设计单位  0401002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 主要设计单位  0401002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 主要设计单位  0401002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 主要设计单位  0401002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 合作单位1  0401003
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0401003 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0401003 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0401003 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0401004
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0401004 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0401004 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0401004 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0401005
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0401005 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0401005 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0401005 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0401006
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0401006 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0401006 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0401006 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0401007
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0401007 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0401007 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0401007 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0401008
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0401008 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0401008 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0401008 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0401009
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0401009 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0401009 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0401009 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0401010
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0401010 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0401010 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0401010 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0401011
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0401011 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0401011 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0401011 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0401012
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0401012 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0401012 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0401012 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0401013
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0401013 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0401013 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0401013 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0401014
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0401014 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0401014 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0401014 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 绿建咨询单位  0401015
        /// </summary>
        public string AdvisoryUnit { get; set; }

        /// <summary>
        /// 绿建咨询单位  0401015 数据类别
        /// </summary>
        public string RecordTypeAdvisoryUnit { get; set; }

        /// <summary>
        /// 绿建咨询单位  0401015 是否必填
        /// </summary>
        public bool? IsRequiredAdvisoryUnit { get; set; }

        /// <summary>
        /// 绿建咨询单位  0401015 是否公开
        /// </summary>
        public bool? IsPublicAdvisoryUnit { get; set; }
        /// <summary>
        /// 工程设计起止时间_开始时间  0401016
        /// </summary>
        public string ProjectStartDate { get; set; }

        /// <summary>
        /// 工程设计起止时间_开始时间  0401016 数据类别
        /// </summary>
        public string RecordTypeProjectStartDate { get; set; }

        /// <summary>
        /// 工程设计起止时间_开始时间  0401016 是否必填
        /// </summary>
        public bool? IsRequiredProjectStartDate { get; set; }

        /// <summary>
        /// 工程设计起止时间_开始时间  0401016 是否公开
        /// </summary>
        public bool? IsPublicProjectStartDate { get; set; }
        /// <summary>
        /// 工程设计起止时间_终止时间  0401017
        /// </summary>
        public string ProjectEndDate { get; set; }

        /// <summary>
        /// 工程设计起止时间_终止时间  0401017 数据类别
        /// </summary>
        public string RecordTypeProjectEndDate { get; set; }

        /// <summary>
        /// 工程设计起止时间_终止时间  0401017 是否必填
        /// </summary>
        public bool? IsRequiredProjectEndDate { get; set; }

        /// <summary>
        /// 工程设计起止时间_终止时间  0401017 是否公开
        /// </summary>
        public bool? IsPublicProjectEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0401018
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0401018 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0401018 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0401018 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 验收部门  0401019
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0401019 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0401019 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0401019 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 申报单位通讯地址  0401020
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  0401020 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  0401020 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  0401020 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 单位资质  0401021
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0401021 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0401021 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0401021 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  0401022
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0401022 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0401022 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0401022 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }
        /// <summary>
        /// 申报单位联系人  0401023
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 申报单位联系人  0401023 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  0401023 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  0401023 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0401024
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0401024 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0401024 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0401024 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0401025
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0401025 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0401025 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0401025 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0401026
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0401026 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0401026 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0401026 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0401027
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0401027 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0401027 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0401027 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0401028
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0401028 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0401028 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0401028 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 曾获奖项  0401029
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0401029  数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0401029  是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0401029  是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }

        /// <summary>
        /// 专业类别  0401030
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0401030 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0401030 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0401030 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 申报材料目录  0401031
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0401031 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0401031 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0401031 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }
    }


    /// <summary>
    /// 绿色建筑模板—工程勘察设计项目特点
    /// </summary>
    [Serializable]
    public class Template_0402 : TemplateBase
    {
        /// <summary>
        /// 项目概况  0402001
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0402001 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0402001 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0402001 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 关键绿色策略与技术  0402002
        /// </summary>
        public string KeyTechnology { get; set; }

        /// <summary>
        /// 关键绿色策略与技术  0402002 数据类别
        /// </summary>
        public string RecordTypeKeyTechnology { get; set; }

        /// <summary>
        /// 关键绿色策略与技术  0402002 是否必填
        /// </summary>
        public bool? IsRequiredKeyTechnology { get; set; }

        /// <summary>
        /// 关键绿色策略与技术  0402002 是否公开
        /// </summary>
        public bool? IsPublicKeyTechnology { get; set; }
        /// <summary>
        /// 技术成效与深度  0402003
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// 技术成效与深度  0402003 数据类别
        /// </summary>
        public string RecordTypeEffect { get; set; }

        /// <summary>
        /// 技术成效与深度  0402003 是否必填
        /// </summary>
        public bool? IsRequiredEffect { get; set; }

        /// <summary>
        /// 技术成效与深度  0402003 是否公开
        /// </summary>
        public bool? IsPublicEffect { get; set; }
        /// <summary>
        /// 综合效益  0402004
        /// </summary>
        public string Benefit { get; set; }

        /// <summary>
        /// 综合效益  0402004 数据类别
        /// </summary>
        public string RecordTypeBenefit { get; set; }

        /// <summary>
        /// 综合效益  0402004 是否必填
        /// </summary>
        public bool? IsRequiredBenefit { get; set; }

        /// <summary>
        /// 综合效益  0402004 是否公开
        /// </summary>
        public bool? IsPublicBenefit { get; set; }
    }


    /// <summary>
    /// 绿色建筑模板—专业技术指标（建筑专业）
    /// </summary>
    [Serializable]
    public class Template_0403 : TemplateBase
    {
        /// <summary>
        /// 建筑用途（性质）  0403001
        /// </summary>
        public string UseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0403001 数据类别
        /// </summary>
        public string RecordTypeUseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0403001 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0403001 是否公开
        /// </summary>
        public bool? IsPublicUseProperty { get; set; }
        /// <summary>
        /// 建筑规模  0403002
        /// </summary>
        public string BuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0403002 数据类别
        /// </summary>
        public string RecordTypeBuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0403002 是否必填
        /// </summary>
        public bool? IsRequiredBuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0403002 是否公开
        /// </summary>
        public bool? IsPublicBuildingScale { get; set; }
        /// <summary>
        /// 总用地面积  0403003
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0403003 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0403003 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0403003 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 代征地面积  0403004
        /// </summary>
        public string ExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0403004 数据类别
        /// </summary>
        public string RecordTypeExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0403004 是否必填
        /// </summary>
        public bool? IsRequiredExpropriationArea { get; set; }

        /// <summary>
        /// 代征地面积  0403004 是否公开
        /// </summary>
        public bool? IsPublicExpropriationArea { get; set; }
        /// <summary>
        /// 建设用地面积  0403005
        /// </summary>
        public string ConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0403005 数据类别
        /// </summary>
        public string RecordTypeConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0403005 是否必填
        /// </summary>
        public bool? IsRequiredConstructionArea { get; set; }

        /// <summary>
        /// 建设用地面积  0403005 是否公开
        /// </summary>
        public bool? IsPublicConstructionArea { get; set; }
        /// <summary>
        /// 总建筑面积  0403006
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0403006 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0403006 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0403006 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 地上面积  0403007
        /// </summary>
        public string OvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0403007 数据类别
        /// </summary>
        public string RecordTypeOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0403007 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundArea { get; set; }

        /// <summary>
        /// 地上面积  0403007 是否公开
        /// </summary>
        public bool? IsPublicOvergroundArea { get; set; }
        /// <summary>
        /// 地下面积  0403008
        /// </summary>
        public string UndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0403008 数据类别
        /// </summary>
        public string RecordTypeUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0403008 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundArea { get; set; }

        /// <summary>
        /// 地下面积  0403008 是否公开
        /// </summary>
        public bool? IsPublicUndergroundArea { get; set; }
        /// <summary>
        /// 建筑基底面积  0403009
        /// </summary>
        public string BuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0403009 数据类别
        /// </summary>
        public string RecordTypeBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0403009 是否必填
        /// </summary>
        public bool? IsRequiredBuildingArea { get; set; }

        /// <summary>
        /// 建筑基底面积  0403009 是否公开
        /// </summary>
        public bool? IsPublicBuildingArea { get; set; }
        /// <summary>
        /// 绿地面积  0403010
        /// </summary>
        public string GreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0403010 数据类别
        /// </summary>
        public string RecordTypeGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0403010 是否必填
        /// </summary>
        public bool? IsRequiredGreenArea { get; set; }

        /// <summary>
        /// 绿地面积  0403010 是否公开
        /// </summary>
        public bool? IsPublicGreenArea { get; set; }
        /// <summary>
        /// 绿化率  0403011
        /// </summary>
        public string GreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0403011 数据类别
        /// </summary>
        public string RecordTypeGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0403011 是否必填
        /// </summary>
        public bool? IsRequiredGreeningRate { get; set; }

        /// <summary>
        /// 绿化率  0403011 是否公开
        /// </summary>
        public bool? IsPublicGreeningRate { get; set; }
        /// <summary>
        /// 容积率  0403012
        /// </summary>
        public string PlotRatio { get; set; }

        /// <summary>
        /// 容积率  0403012 数据类别
        /// </summary>
        public string RecordTypePlotRatio { get; set; }

        /// <summary>
        /// 容积率  0403012 是否必填
        /// </summary>
        public bool? IsRequiredPlotRatio { get; set; }

        /// <summary>
        /// 容积率  0403012 是否公开
        /// </summary>
        public bool? IsPublicPlotRatio { get; set; }
        /// <summary>
        /// 建筑高度  0403013
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0403013 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0403013 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0403013 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑分类（高层建筑）  0403014
        /// </summary>
        public string BuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类（高层建筑）  0403014 数据类别
        /// </summary>
        public string RecordTypeBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类（高层建筑）  0403014 是否必填
        /// </summary>
        public bool? IsRequiredBuildingClassification { get; set; }

        /// <summary>
        /// 建筑分类（高层建筑）  0403014 是否公开
        /// </summary>
        public bool? IsPublicBuildingClassification { get; set; }
        /// <summary>
        /// 地上层数  0403015
        /// </summary>
        public string OvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0403015 数据类别
        /// </summary>
        public string RecordTypeOvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0403015 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundLayerCount { get; set; }

        /// <summary>
        /// 地上层数  0403015 是否公开
        /// </summary>
        public bool? IsPublicOvergroundLayerCount { get; set; }
        /// <summary>
        /// 地下层数  0403016
        /// </summary>
        public string UndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0403016 数据类别
        /// </summary>
        public string RecordTypeUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0403016 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundLayerCount { get; set; }

        /// <summary>
        /// 地下层数  0403016 是否公开
        /// </summary>
        public bool? IsPublicUndergroundLayerCount { get; set; }
        /// <summary>
        /// 耐火等级  0403017
        /// </summary>
        public string FireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0403017 数据类别
        /// </summary>
        public string RecordTypeFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0403017 是否必填
        /// </summary>
        public bool? IsRequiredFireResistanceRating { get; set; }

        /// <summary>
        /// 耐火等级  0403017 是否公开
        /// </summary>
        public bool? IsPublicFireResistanceRating { get; set; }
        /// <summary>
        /// 主要层高_地上  0403018
        /// </summary>
        public string LayerHeight_Overground { get; set; }

        /// <summary>
        /// 主要层高_地上  0403018 数据类别
        /// </summary>
        public string RecordTypeLayerHeight_Overground { get; set; }

        /// <summary>
        /// 主要层高_地上  0403018 是否必填
        /// </summary>
        public bool? IsRequiredLayerHeight_Overground { get; set; }

        /// <summary>
        /// 主要层高_地上  0403018 是否公开
        /// </summary>
        public bool? IsPublicLayerHeight_Overground { get; set; }
        /// <summary>
        /// 主要层高_地下  0403019
        /// </summary>
        public string LayerHeight_Underground { get; set; }

        /// <summary>
        /// 主要层高_地下  0403019 数据类别
        /// </summary>
        public string RecordTypeLayerHeight_Underground { get; set; }

        /// <summary>
        /// 主要层高_地下  0403019 是否必填
        /// </summary>
        public bool? IsRequiredLayerHeight_Underground { get; set; }

        /// <summary>
        /// 主要层高_地下  0403019 是否公开
        /// </summary>
        public bool? IsPublicLayerHeight_Underground { get; set; }
        /// <summary>
        /// 主楼/裙房电梯数_主楼  0403020
        /// </summary>
        public string ElevatorNumber_MainBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_主楼  0403020 数据类别
        /// </summary>
        public string RecordTypeElevatorNumber_MainBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_主楼  0403020 是否必填
        /// </summary>
        public bool? IsRequiredElevatorNumber_MainBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_主楼  0403020 是否公开
        /// </summary>
        public bool? IsPublicElevatorNumber_MainBuilding { get; set; }
        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0403021
        /// </summary>
        public string ElevatorNumber_PodiumBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0403021 数据类别
        /// </summary>
        public string RecordTypeElevatorNumber_PodiumBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0403021 是否必填
        /// </summary>
        public bool? IsRequiredElevatorNumber_PodiumBuilding { get; set; }

        /// <summary>
        /// 主楼/裙房电梯数_裙楼  0403021 是否公开
        /// </summary>
        public bool? IsPublicElevatorNumber_PodiumBuilding { get; set; }
        /// <summary>
        /// 住宅类型（居住建筑）  0403022
        /// </summary>
        public string HousingType { get; set; }

        /// <summary>
        /// 住宅类型（居住建筑）  0403022 数据类别
        /// </summary>
        public string RecordTypeHousingType { get; set; }

        /// <summary>
        /// 住宅类型（居住建筑）  0403022 是否必填
        /// </summary>
        public bool? IsRequiredHousingType { get; set; }

        /// <summary>
        /// 住宅类型（居住建筑）  0403022 是否公开
        /// </summary>
        public bool? IsPublicHousingType { get; set; }
        /// <summary>
        /// 住宅平均每套建筑面积（居住建筑）  0403023
        /// </summary>
        public string UnitConstructionArea { get; set; }

        /// <summary>
        /// 住宅平均每套建筑面积（居住建筑）  0403023 数据类别
        /// </summary>
        public string RecordTypeUnitConstructionArea { get; set; }

        /// <summary>
        /// 住宅平均每套建筑面积（居住建筑）  0403023 是否必填
        /// </summary>
        public bool? IsRequiredUnitConstructionArea { get; set; }

        /// <summary>
        /// 住宅平均每套建筑面积（居住建筑）  0403023 是否公开
        /// </summary>
        public bool? IsPublicUnitConstructionArea { get; set; }
        /// <summary>
        /// 总居住户数（居住建筑）  0403024
        /// </summary>
        public string TotalFamilies { get; set; }

        /// <summary>
        /// 总居住户数（居住建筑）  0403024 数据类别
        /// </summary>
        public string RecordTypeTotalFamilies { get; set; }

        /// <summary>
        /// 总居住户数（居住建筑）  0403024 是否必填
        /// </summary>
        public bool? IsRequiredTotalFamilies { get; set; }

        /// <summary>
        /// 总居住户数（居住建筑）  0403024 是否公开
        /// </summary>
        public bool? IsPublicTotalFamilies { get; set; }
        /// <summary>
        /// 总居住人数（居住建筑）  0403025
        /// </summary>
        public string TotalPerson { get; set; }

        /// <summary>
        /// 总居住人数（居住建筑）  0403025 数据类别
        /// </summary>
        public string RecordTypeTotalPerson { get; set; }

        /// <summary>
        /// 总居住人数（居住建筑）  0403025 是否必填
        /// </summary>
        public bool? IsRequiredTotalPerson { get; set; }

        /// <summary>
        /// 总居住人数（居住建筑）  0403025 是否公开
        /// </summary>
        public bool? IsPublicTotalPerson { get; set; }
        /// <summary>
        /// 机动车停放数量  0403026
        /// </summary>
        public string AutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停放数量  0403026 数据类别
        /// </summary>
        public string RecordTypeAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停放数量  0403026 是否必填
        /// </summary>
        public bool? IsRequiredAutoParkingCount { get; set; }

        /// <summary>
        /// 机动车停放数量  0403026 是否公开
        /// </summary>
        public bool? IsPublicAutoParkingCount { get; set; }
        /// <summary>
        /// 地上停车（机动车）  0403027
        /// </summary>
        public string OvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0403027 数据类别
        /// </summary>
        public string RecordTypeOvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0403027 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地上停车（机动车）  0403027 是否公开
        /// </summary>
        public bool? IsPublicOvergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 地下停车（机动车）  0403028
        /// </summary>
        public string UndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0403028 数据类别
        /// </summary>
        public string RecordTypeUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0403028 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundAutoParkingCount { get; set; }

        /// <summary>
        /// 地下停车（机动车）  0403028 是否公开
        /// </summary>
        public bool? IsPublicUndergroundAutoParkingCount { get; set; }
        /// <summary>
        /// 自行车停车数量  0403029
        /// </summary>
        public string BicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车数量  0403029 数据类别
        /// </summary>
        public string RecordTypeBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车数量  0403029 是否必填
        /// </summary>
        public bool? IsRequiredBicycleParkingCount { get; set; }

        /// <summary>
        /// 自行车停车数量  0403029 是否公开
        /// </summary>
        public bool? IsPublicBicycleParkingCount { get; set; }
        /// <summary>
        /// 地上停车（自行车）  0403030
        /// </summary>
        public string OvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0403030 数据类别
        /// </summary>
        public string RecordTypeOvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0403030 是否必填
        /// </summary>
        public bool? IsRequiredOvergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地上停车（自行车）  0403030 是否公开
        /// </summary>
        public bool? IsPublicOvergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 地下停车（自行车）  0403031
        /// </summary>
        public string UndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0403031 数据类别
        /// </summary>
        public string RecordTypeUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0403031 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundBicycleParkingCount { get; set; }

        /// <summary>
        /// 地下停车（自行车）  0403031 是否公开
        /// </summary>
        public bool? IsPublicUndergroundBicycleParkingCount { get; set; }
        /// <summary>
        /// 周围道路宽度及性质  0403032
        /// </summary>
        public string RoadWidth { get; set; }

        /// <summary>
        /// 周围道路宽度及性质  0403032 数据类别
        /// </summary>
        public string RecordTypeRoadWidth { get; set; }

        /// <summary>
        /// 周围道路宽度及性质  0403032 是否必填
        /// </summary>
        public bool? IsRequiredRoadWidth { get; set; }

        /// <summary>
        /// 周围道路宽度及性质  0403032 是否公开
        /// </summary>
        public bool? IsPublicRoadWidth { get; set; }
        /// <summary>
        /// 地下建筑面积与总用地面积比（公共建筑）  0403033
        /// </summary>
        public string UndergroundAreaTotalAreaRatio { get; set; }

        /// <summary>
        /// 地下建筑面积与总用地面积比（公共建筑）  0403033 数据类别
        /// </summary>
        public string RecordTypeUndergroundAreaTotalAreaRatio { get; set; }

        /// <summary>
        /// 地下建筑面积与总用地面积比（公共建筑）  0403033 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundAreaTotalAreaRatio { get; set; }

        /// <summary>
        /// 地下建筑面积与总用地面积比（公共建筑）  0403033 是否公开
        /// </summary>
        public bool? IsPublicUndergroundAreaTotalAreaRatio { get; set; }
        /// <summary>
        /// 地下建筑面积与地上建筑面积比（居住建筑）  0403034
        /// </summary>
        public string UndergroundAreaOvergroundAreaRatio { get; set; }

        /// <summary>
        /// 地下建筑面积与地上建筑面积比（居住建筑）  0403034 数据类别
        /// </summary>
        public string RecordTypeUndergroundAreaOvergroundAreaRatio { get; set; }

        /// <summary>
        /// 地下建筑面积与地上建筑面积比（居住建筑）  0403034 是否必填
        /// </summary>
        public bool? IsRequiredUndergroundAreaOvergroundAreaRatio { get; set; }

        /// <summary>
        /// 地下建筑面积与地上建筑面积比（居住建筑）  0403034 是否公开
        /// </summary>
        public bool? IsPublicUndergroundAreaOvergroundAreaRatio { get; set; }
        /// <summary>
        /// 人均居住用地指标（居住建筑）  0403035
        /// </summary>
        public string AvgPersonLandIndication { get; set; }

        /// <summary>
        /// 人均居住用地指标（居住建筑）  0403035 数据类别
        /// </summary>
        public string RecordTypeAvgPersonLandIndication { get; set; }

        /// <summary>
        /// 人均居住用地指标（居住建筑）  0403035 是否必填
        /// </summary>
        public bool? IsRequiredAvgPersonLandIndication { get; set; }

        /// <summary>
        /// 人均居住用地指标（居住建筑）  0403035 是否公开
        /// </summary>
        public bool? IsPublicAvgPersonLandIndication { get; set; }
        /// <summary>
        /// 下凹式绿地率  0403036
        /// </summary>
        public string LowerConcaveGreenSpaceRatio { get; set; }

        /// <summary>
        /// 下凹式绿地率  0403036 数据类别
        /// </summary>
        public string RecordTypeLowerConcaveGreenSpaceRatio { get; set; }

        /// <summary>
        /// 下凹式绿地率  0403036 是否必填
        /// </summary>
        public bool? IsRequiredLowerConcaveGreenSpaceRatio { get; set; }

        /// <summary>
        /// 下凹式绿地率  0403036 是否公开
        /// </summary>
        public bool? IsPublicLowerConcaveGreenSpaceRatio { get; set; }
        /// <summary>
        /// 硬质铺装地面中透水铺装面积比例  0403037
        /// </summary>
        public string PermeablePavementRatio { get; set; }

        /// <summary>
        /// 硬质铺装地面中透水铺装面积比例  0403037 数据类别
        /// </summary>
        public string RecordTypePermeablePavementRatio { get; set; }

        /// <summary>
        /// 硬质铺装地面中透水铺装面积比例  0403037 是否必填
        /// </summary>
        public bool? IsRequiredPermeablePavementRatio { get; set; }

        /// <summary>
        /// 硬质铺装地面中透水铺装面积比例  0403037 是否公开
        /// </summary>
        public bool? IsPublicPermeablePavementRatio { get; set; }
        /// <summary>
        /// 屋顶绿化率  0403038
        /// </summary>
        public string RoofGreeningRate { get; set; }

        /// <summary>
        /// 屋顶绿化率  0403038 数据类别
        /// </summary>
        public string RecordTypeRoofGreeningRate { get; set; }

        /// <summary>
        /// 屋顶绿化率  0403038 是否必填
        /// </summary>
        public bool? IsRequiredRoofGreeningRate { get; set; }

        /// <summary>
        /// 屋顶绿化率  0403038 是否公开
        /// </summary>
        public bool? IsPublicRoofGreeningRate { get; set; }
        /// <summary>
        /// 外窗可开启面积比例  0403039
        /// </summary>
        public string ExternalWindowOpenableAreaRatio { get; set; }

        /// <summary>
        /// 外窗可开启面积比例  0403039 数据类别
        /// </summary>
        public string RecordTypeExternalWindowOpenableAreaRatio { get; set; }

        /// <summary>
        /// 外窗可开启面积比例  0403039 是否必填
        /// </summary>
        public bool? IsRequiredExternalWindowOpenableAreaRatio { get; set; }

        /// <summary>
        /// 外窗可开启面积比例  0403039 是否公开
        /// </summary>
        public bool? IsPublicExternalWindowOpenableAreaRatio { get; set; }
        /// <summary>
        /// 玻璃幕墙透明部分可开启面积比例  0403040
        /// </summary>
        public string TransparentPartOpenableAreaRatio { get; set; }

        /// <summary>
        /// 玻璃幕墙透明部分可开启面积比例  0403040 数据类别
        /// </summary>
        public string RecordTypeTransparentPartOpenableAreaRatio { get; set; }

        /// <summary>
        /// 玻璃幕墙透明部分可开启面积比例  0403040 是否必填
        /// </summary>
        public bool? IsRequiredTransparentPartOpenableAreaRatio { get; set; }

        /// <summary>
        /// 玻璃幕墙透明部分可开启面积比例  0403040 是否公开
        /// </summary>
        public bool? IsPublicTransparentPartOpenableAreaRatio { get; set; }
        /// <summary>
        /// 围护结构热工性能比国家现行节能标准提高比例  0403041
        /// </summary>
        public string IncreaseRatio { get; set; }

        /// <summary>
        /// 围护结构热工性能比国家现行节能标准提高比例  0403041 数据类别
        /// </summary>
        public string RecordTypeIncreaseRatio { get; set; }

        /// <summary>
        /// 围护结构热工性能比国家现行节能标准提高比例  0403041 是否必填
        /// </summary>
        public bool? IsRequiredIncreaseRatio { get; set; }

        /// <summary>
        /// 围护结构热工性能比国家现行节能标准提高比例  0403041 是否公开
        /// </summary>
        public bool? IsPublicIncreaseRatio { get; set; }
        /// <summary>
        /// 建筑节能率  0403042
        /// </summary>
        public string EnergyEfficiency { get; set; }

        /// <summary>
        /// 建筑节能率  0403042 数据类别
        /// </summary>
        public string RecordTypeEnergyEfficiency { get; set; }

        /// <summary>
        /// 建筑节能率  0403042 是否必填
        /// </summary>
        public bool? IsRequiredEnergyEfficiency { get; set; }

        /// <summary>
        /// 建筑节能率  0403042 是否公开
        /// </summary>
        public bool? IsPublicEnergyEfficiency { get; set; }
        /// <summary>
        /// 主要功能房间室内噪声级指标是否满足标准  0403043
        /// </summary>
        public string IsNoiseLevelQualified { get; set; }

        /// <summary>
        /// 主要功能房间室内噪声级指标是否满足标准  0403043 数据类别
        /// </summary>
        public string RecordTypeIsNoiseLevelQualified { get; set; }

        /// <summary>
        /// 主要功能房间室内噪声级指标是否满足标准  0403043 是否必填
        /// </summary>
        public bool? IsRequiredIsNoiseLevelQualified { get; set; }

        /// <summary>
        /// 主要功能房间室内噪声级指标是否满足标准  0403043 是否公开
        /// </summary>
        public bool? IsPublicIsNoiseLevelQualified { get; set; }
        /// <summary>
        /// 主要功能房间构造隔声性能要求低限标准（满足标准）/高要求标准  0403044
        /// </summary>
        public string SoundInsulation { get; set; }

        /// <summary>
        /// 主要功能房间构造隔声性能要求低限标准（满足标准）/高要求标准  0403044 数据类别
        /// </summary>
        public string RecordTypeSoundInsulation { get; set; }

        /// <summary>
        /// 主要功能房间构造隔声性能要求低限标准（满足标准）/高要求标准  0403044 是否必填
        /// </summary>
        public bool? IsRequiredSoundInsulation { get; set; }

        /// <summary>
        /// 主要功能房间构造隔声性能要求低限标准（满足标准）/高要求标准  0403044 是否公开
        /// </summary>
        public bool? IsPublicSoundInsulation { get; set; }
        /// <summary>
        /// 主要功能房间采光系数达标面积比例（公共建筑）  0403045
        /// </summary>
        public string DaylightFactor { get; set; }

        /// <summary>
        /// 主要功能房间采光系数达标面积比例（公共建筑）  0403045 数据类别
        /// </summary>
        public string RecordTypeDaylightFactor { get; set; }

        /// <summary>
        /// 主要功能房间采光系数达标面积比例（公共建筑）  0403045 是否必填
        /// </summary>
        public bool? IsRequiredDaylightFactor { get; set; }

        /// <summary>
        /// 主要功能房间采光系数达标面积比例（公共建筑）  0403045 是否公开
        /// </summary>
        public bool? IsPublicDaylightFactor { get; set; }
        /// <summary>
        /// 卧室、起居室的窗地面积比（居住建筑）  0403046
        /// </summary>
        public string WindowToGroundAreaRatio { get; set; }

        /// <summary>
        /// 卧室、起居室的窗地面积比（居住建筑）  0403046 数据类别
        /// </summary>
        public string RecordTypeWindowToGroundAreaRatio { get; set; }

        /// <summary>
        /// 卧室、起居室的窗地面积比（居住建筑）  0403046 是否必填
        /// </summary>
        public bool? IsRequiredWindowToGroundAreaRatio { get; set; }

        /// <summary>
        /// 卧室、起居室的窗地面积比（居住建筑）  0403046 是否公开
        /// </summary>
        public bool? IsPublicWindowToGroundAreaRatio { get; set; }
        /// <summary>
        /// 主要功能房间平均自然通风换气次数不小于2次/h的面积比例（公共建筑）  0403047
        /// </summary>
        public string NaturalVentilationAreaRatio { get; set; }

        /// <summary>
        /// 主要功能房间平均自然通风换气次数不小于2次/h的面积比例（公共建筑）  0403047 数据类别
        /// </summary>
        public string RecordTypeNaturalVentilationAreaRatio { get; set; }

        /// <summary>
        /// 主要功能房间平均自然通风换气次数不小于2次/h的面积比例（公共建筑）  0403047 是否必填
        /// </summary>
        public bool? IsRequiredNaturalVentilationAreaRatio { get; set; }

        /// <summary>
        /// 主要功能房间平均自然通风换气次数不小于2次/h的面积比例（公共建筑）  0403047 是否公开
        /// </summary>
        public bool? IsPublicNaturalVentilationAreaRatio { get; set; }
        /// <summary>
        /// 通风开口面积占房间地板面积的比例（居住建筑）  0403048
        /// </summary>
        public string VentilationOpeningAreaRatio { get; set; }

        /// <summary>
        /// 通风开口面积占房间地板面积的比例（居住建筑）  0403048 数据类别
        /// </summary>
        public string RecordTypeVentilationOpeningAreaRatio { get; set; }

        /// <summary>
        /// 通风开口面积占房间地板面积的比例（居住建筑）  0403048 是否必填
        /// </summary>
        public bool? IsRequiredVentilationOpeningAreaRatio { get; set; }

        /// <summary>
        /// 通风开口面积占房间地板面积的比例（居住建筑）  0403048 是否公开
        /// </summary>
        public bool? IsPublicVentilationOpeningAreaRatio { get; set; }
        /// <summary>
        /// 设有可控遮阳部分占外窗及玻璃幕墙面积的比例  0403049
        /// </summary>
        public string ShadingAreaRatio { get; set; }

        /// <summary>
        /// 设有可控遮阳部分占外窗及玻璃幕墙面积的比例  0403049 数据类别
        /// </summary>
        public string RecordTypeShadingAreaRatio { get; set; }

        /// <summary>
        /// 设有可控遮阳部分占外窗及玻璃幕墙面积的比例  0403049 是否必填
        /// </summary>
        public bool? IsRequiredShadingAreaRatio { get; set; }

        /// <summary>
        /// 设有可控遮阳部分占外窗及玻璃幕墙面积的比例  0403049 是否公开
        /// </summary>
        public bool? IsPublicShadingAreaRatio { get; set; }
        /// <summary>
        /// 可再利用材料和可再循环材料用量比例  0403050
        /// </summary>
        public string RecycledMaterialsRatio { get; set; }

        /// <summary>
        /// 可再利用材料和可再循环材料用量比例  0403050 数据类别
        /// </summary>
        public string RecordTypeRecycledMaterialsRatio { get; set; }

        /// <summary>
        /// 可再利用材料和可再循环材料用量比例  0403050 是否必填
        /// </summary>
        public bool? IsRequiredRecycledMaterialsRatio { get; set; }

        /// <summary>
        /// 可再利用材料和可再循环材料用量比例  0403050 是否公开
        /// </summary>
        public bool? IsPublicRecycledMaterialsRatio { get; set; }
        /// <summary>
        /// 装饰性构建造价占工程总建安造价的比例  0403051
        /// </summary>
        public string DecorativeRatio { get; set; }

        /// <summary>
        /// 装饰性构建造价占工程总建安造价的比例  0403051 数据类别
        /// </summary>
        public string RecordTypeDecorativeRatio { get; set; }

        /// <summary>
        /// 装饰性构建造价占工程总建安造价的比例  0403051 是否必填
        /// </summary>
        public bool? IsRequiredDecorativeRatio { get; set; }

        /// <summary>
        /// 装饰性构建造价占工程总建安造价的比例  0403051 是否公开
        /// </summary>
        public bool? IsPublicDecorativeRatio { get; set; }
        /// <summary>
        /// 可重复使用隔断（墙）比例  0403052
        /// </summary>
        public string ReusableWallRatio { get; set; }

        /// <summary>
        /// 可重复使用隔断（墙）比例  0403052 数据类别
        /// </summary>
        public string RecordTypeReusableWallRatio { get; set; }

        /// <summary>
        /// 可重复使用隔断（墙）比例  0403052 是否必填
        /// </summary>
        public bool? IsRequiredReusableWallRatio { get; set; }

        /// <summary>
        /// 可重复使用隔断（墙）比例  0403052 是否公开
        /// </summary>
        public bool? IsPublicReusableWallRatio { get; set; }
        /// <summary>
        /// 工业化生产预制构件用量比例  0403053
        /// </summary>
        public string PrefabricatedRatio { get; set; }

        /// <summary>
        /// 工业化生产预制构件用量比例  0403053 数据类别
        /// </summary>
        public string RecordTypePrefabricatedRatio { get; set; }

        /// <summary>
        /// 工业化生产预制构件用量比例  0403053 是否必填
        /// </summary>
        public bool? IsRequiredPrefabricatedRatio { get; set; }

        /// <summary>
        /// 工业化生产预制构件用量比例  0403053 是否公开
        /// </summary>
        public bool? IsPublicPrefabricatedRatio { get; set; }
        /// <summary>
        /// 本地生产的建筑材料比例  0403054
        /// </summary>
        public string LocallyMaterialsRatio { get; set; }

        /// <summary>
        /// 本地生产的建筑材料比例  0403054 数据类别
        /// </summary>
        public string RecordTypeLocallyMaterialsRatio { get; set; }

        /// <summary>
        /// 本地生产的建筑材料比例  0403054 是否必填
        /// </summary>
        public bool? IsRequiredLocallyMaterialsRatio { get; set; }

        /// <summary>
        /// 本地生产的建筑材料比例  0403054 是否公开
        /// </summary>
        public bool? IsPublicLocallyMaterialsRatio { get; set; }
        /// <summary>
        /// 利废建材的种类  0403055
        /// </summary>
        public string WasteMaterialsKinds { get; set; }

        /// <summary>
        /// 利废建材的种类  0403055 数据类别
        /// </summary>
        public string RecordTypeWasteMaterialsKinds { get; set; }

        /// <summary>
        /// 利废建材的种类  0403055 是否必填
        /// </summary>
        public bool? IsRequiredWasteMaterialsKinds { get; set; }

        /// <summary>
        /// 利废建材的种类  0403055 是否公开
        /// </summary>
        public bool? IsPublicWasteMaterialsKinds { get; set; }
        /// <summary>
        /// 利废建材占同类建材用量的比例  0403056
        /// </summary>
        public string WasteMaterialsRatio { get; set; }

        /// <summary>
        /// 利废建材占同类建材用量的比例  0403056 数据类别
        /// </summary>
        public string RecordTypeWasteMaterialsRatio { get; set; }

        /// <summary>
        /// 利废建材占同类建材用量的比例  0403056 是否必填
        /// </summary>
        public bool? IsRequiredWasteMaterialsRatio { get; set; }

        /// <summary>
        /// 利废建材占同类建材用量的比例  0403056 是否公开
        /// </summary>
        public bool? IsPublicWasteMaterialsRatio { get; set; }
        /// <summary>
        /// 土建工程与装修工程一体化设计（是/否）  0403057
        /// </summary>
        public string IsIntegratedDesign { get; set; }

        /// <summary>
        /// 土建工程与装修工程一体化设计（是/否）  0403057 数据类别
        /// </summary>
        public string RecordTypeIsIntegratedDesign { get; set; }

        /// <summary>
        /// 土建工程与装修工程一体化设计（是/否）  0403057 是否必填
        /// </summary>
        public bool? IsRequiredIsIntegratedDesign { get; set; }

        /// <summary>
        /// 土建工程与装修工程一体化设计（是/否）  0403057 是否公开
        /// </summary>
        public bool? IsPublicIsIntegratedDesign { get; set; }
        /// <summary>
        /// 建筑专业设计主要特点  0403058
        /// </summary>
        public string ArchitectureMainFeatures { get; set; }

        /// <summary>
        /// 建筑专业设计主要特点  0403058 数据类别
        /// </summary>
        public string RecordTypeArchitectureMainFeatures { get; set; }

        /// <summary>
        /// 建筑专业设计主要特点  0403058 是否必填
        /// </summary>
        public bool? IsRequiredArchitectureMainFeatures { get; set; }

        /// <summary>
        /// 建筑专业设计主要特点  0403058 是否公开
        /// </summary>
        public bool? IsPublicArchitectureMainFeatures { get; set; }
    }


    /// <summary>
    /// 绿色建筑模板—专业技术指标（结构专业）
    /// </summary>
    [Serializable]
    public class Template_0404 : TemplateBase
    {
        /// <summary>
        /// 结构体系  0404001
        /// </summary>
        public string StructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0404001 数据类别
        /// </summary>
        public string RecordTypeStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0404001 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0404001 是否公开
        /// </summary>
        public bool? IsPublicStructuralSystem { get; set; }
        /// <summary>
        /// 抗震设防烈度  0404002
        /// </summary>
        public string SeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0404002 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0404002 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0404002 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationIntensity { get; set; }
        /// <summary>
        /// 抗震设防类别  0404003
        /// </summary>
        public string SeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0404003 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0404003 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0404003 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationCategory { get; set; }
        /// <summary>
        /// 设计基本地震加速度值  0404004
        /// </summary>
        public string BasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震加速度值  0404004 数据类别
        /// </summary>
        public string RecordTypeBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震加速度值  0404004 是否必填
        /// </summary>
        public bool? IsRequiredBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震加速度值  0404004 是否公开
        /// </summary>
        public bool? IsPublicBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 设计地震分组  0404005
        /// </summary>
        public string EarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0404005 数据类别
        /// </summary>
        public string RecordTypeEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0404005 是否必填
        /// </summary>
        public bool? IsRequiredEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0404005 是否公开
        /// </summary>
        public bool? IsPublicEarthquakeGrouping { get; set; }
        /// <summary>
        /// 场地类别  0404006
        /// </summary>
        public string ConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 场地类别  0404006 数据类别
        /// </summary>
        public string RecordTypeConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 场地类别  0404006 是否必填
        /// </summary>
        public bool? IsRequiredConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 场地类别  0404006 是否公开
        /// </summary>
        public bool? IsPublicConstructionSiteSoilType { get; set; }
        /// <summary>
        /// 基础类型  0404007
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 基础类型  0404007 数据类别
        /// </summary>
        public string RecordTypeBaseType { get; set; }

        /// <summary>
        /// 基础类型  0404007 是否必填
        /// </summary>
        public bool? IsRequiredBaseType { get; set; }

        /// <summary>
        /// 基础类型  0404007 是否公开
        /// </summary>
        public bool? IsPublicBaseType { get; set; }
        /// <summary>
        /// 建筑形体规则性  0404008
        /// </summary>
        public string BuildingShape { get; set; }

        /// <summary>
        /// 建筑形体规则性  0404008 数据类别
        /// </summary>
        public string RecordTypeBuildingShape { get; set; }

        /// <summary>
        /// 建筑形体规则性  0404008 是否必填
        /// </summary>
        public bool? IsRequiredBuildingShape { get; set; }

        /// <summary>
        /// 建筑形体规则性  0404008 是否公开
        /// </summary>
        public bool? IsPublicBuildingShape { get; set; }
        /// <summary>
        /// 混凝土总用量  0404009
        /// </summary>
        public string ConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0404009 数据类别
        /// </summary>
        public string RecordTypeConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0404009 是否必填
        /// </summary>
        public bool? IsRequiredConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0404009 是否公开
        /// </summary>
        public bool? IsPublicConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度  0404010
        /// </summary>
        public string PerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0404010 数据类别
        /// </summary>
        public string RecordTypePerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0404010 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0404010 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  0404011
        /// </summary>
        public string SteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0404011 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0404011 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0404011 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  0404012
        /// </summary>
        public string SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0404012 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0404012 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0404012 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  0404013
        /// </summary>
        public string PerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0404013 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0404013 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0404013 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  0404014
        /// </summary>
        public string PerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0404014 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0404014 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0404014 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 抗震分析程序名  0404015
        /// </summary>
        public string SeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  0404015 数据类别
        /// </summary>
        public string RecordTypeSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  0404015 是否必填
        /// </summary>
        public bool? IsRequiredSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  0404015 是否公开
        /// </summary>
        public bool? IsPublicSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0404016
        /// </summary>
        public string NoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0404016 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0404016 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0404016 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0404017
        /// </summary>
        public string NoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0404017 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0404017 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0404017 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0404018
        /// </summary>
        public string NoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0404018 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0404018 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0404018 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0404019
        /// </summary>
        public string NoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0404019 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0404019 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0404019 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0404020
        /// </summary>
        public string NoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0404020 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0404020 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0404020 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0404021
        /// </summary>
        public string NoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0404021 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0404021 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0404021 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0404022
        /// </summary>
        public string NoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0404022 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0404022 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0404022 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0404023
        /// </summary>
        public string NoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0404023 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0404023 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0404023 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0404024
        /// </summary>
        public string NoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0404024 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0404024 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0404024 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0404025
        /// </summary>
        public string NoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0404025 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0404025 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0404025 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  0404026
        /// </summary>
        public string Coupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  0404026 数据类别
        /// </summary>
        public string RecordTypeCoupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  0404026 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  0404026 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  0404027
        /// </summary>
        public string Coupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  0404027 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  0404027 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  0404027 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0404028
        /// </summary>
        public string Coupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0404028 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0404028 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0404028 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  0404029
        /// </summary>
        public string Coupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  0404029 数据类别
        /// </summary>
        public string RecordTypeCoupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  0404029 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  0404029 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  0404030
        /// </summary>
        public string Coupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  0404030 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  0404030 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  0404030 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0404031
        /// </summary>
        public string Coupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0404031 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0404031 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0404031 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  0404032
        /// </summary>
        public string Coupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  0404032 数据类别
        /// </summary>
        public string RecordTypeCoupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  0404032 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  0404032 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  0404033
        /// </summary>
        public string Coupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  0404033 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  0404033 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  0404033 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0404034
        /// </summary>
        public string Coupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0404034 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0404034 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0404034 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0404035
        /// </summary>
        public string Coupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0404035 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0404035 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0404035 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0404036
        /// </summary>
        public string Coupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0404036 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0404036 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0404036 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0404037
        /// </summary>
        public string Coupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0404037 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0404037 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0404037 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0404038
        /// </summary>
        public string Coupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0404038 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0404038 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0404038 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0404039
        /// </summary>
        public string Coupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0404039 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0404039 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0404039 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0404040
        /// </summary>
        public string Coupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0404040 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0404040 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0404040 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0404041
        /// </summary>
        public string Coupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0404041 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0404041 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0404041 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0404042
        /// </summary>
        public string Coupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0404042 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0404042 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0404042 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_h { get; set; }
        /// <summary>
        /// 地震作用最大方向  0404043
        /// </summary>
        public string MaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  0404043 数据类别
        /// </summary>
        public string RecordTypeMaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  0404043 是否必填
        /// </summary>
        public bool? IsRequiredMaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  0404043 是否公开
        /// </summary>
        public bool? IsPublicMaxActionDirection { get; set; }
        /// <summary>
        /// 时程分析程序名称  0404044
        /// </summary>
        public string TimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  0404044 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  0404044 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  0404044 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程_波名1  0404045
        /// </summary>
        public string TimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  0404045 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  0404045 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  0404045 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  0404046
        /// </summary>
        public string TimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  0404046 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  0404046 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  0404046 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  0404047
        /// </summary>
        public string TimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  0404047 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  0404047 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  0404047 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  0404048
        /// </summary>
        public string TimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  0404048 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  0404048 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  0404048 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_波名2  0404049
        /// </summary>
        public string TimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  0404049 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  0404049 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  0404049 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  0404050
        /// </summary>
        public string TimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  0404050 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  0404050 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  0404050 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  0404051
        /// </summary>
        public string TimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  0404051 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  0404051 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  0404051 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  0404052
        /// </summary>
        public string TimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  0404052 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  0404052 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  0404052 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_波名3  0404053
        /// </summary>
        public string TimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  0404053 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  0404053 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  0404053 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  0404054
        /// </summary>
        public string TimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  0404054 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  0404054 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  0404054 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  0404055
        /// </summary>
        public string TimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  0404055 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  0404055 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  0404055 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  0404056
        /// </summary>
        public string TimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  0404056 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  0404056 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  0404056 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h3 { get; set; }
        /// <summary>
        /// 现浇混凝土采用预拌混凝土(是否)  0404057
        /// </summary>
        public string ISReadyMixedConcrete { get; set; }

        /// <summary>
        /// 现浇混凝土采用预拌混凝土(是否)  0404057 数据类别
        /// </summary>
        public string RecordTypeISReadyMixedConcrete { get; set; }

        /// <summary>
        /// 现浇混凝土采用预拌混凝土(是否)  0404057 是否必填
        /// </summary>
        public bool? IsRequiredISReadyMixedConcrete { get; set; }

        /// <summary>
        /// 现浇混凝土采用预拌混凝土(是否)  0404057 是否公开
        /// </summary>
        public bool? IsPublicISReadyMixedConcrete { get; set; }
        /// <summary>
        /// 采用预拌砂浆比例  0404058
        /// </summary>
        public string ReadyMixedMortarRatio { get; set; }

        /// <summary>
        /// 采用预拌砂浆比例  0404058 数据类别
        /// </summary>
        public string RecordTypeReadyMixedMortarRatio { get; set; }

        /// <summary>
        /// 采用预拌砂浆比例  0404058 是否必填
        /// </summary>
        public bool? IsRequiredReadyMixedMortarRatio { get; set; }

        /// <summary>
        /// 采用预拌砂浆比例  0404058 是否公开
        /// </summary>
        public bool? IsPublicReadyMixedMortarRatio { get; set; }
        /// <summary>
        /// 400Mpa级及以上受力普通钢筋比例  0404059
        /// </summary>
        public string NormalSteelRatio { get; set; }

        /// <summary>
        /// 400Mpa级及以上受力普通钢筋比例  0404059 数据类别
        /// </summary>
        public string RecordTypeNormalSteelRatio { get; set; }

        /// <summary>
        /// 400Mpa级及以上受力普通钢筋比例  0404059 是否必填
        /// </summary>
        public bool? IsRequiredNormalSteelRatio { get; set; }

        /// <summary>
        /// 400Mpa级及以上受力普通钢筋比例  0404059 是否公开
        /// </summary>
        public bool? IsPublicNormalSteelRatio { get; set; }
        /// <summary>
        /// C50混凝土用量占竖向承重结构中混凝土总量的比例  0404060
        /// </summary>
        public string C50ConcreteRatio { get; set; }

        /// <summary>
        /// C50混凝土用量占竖向承重结构中混凝土总量的比例  0404060 数据类别
        /// </summary>
        public string RecordTypeC50ConcreteRatio { get; set; }

        /// <summary>
        /// C50混凝土用量占竖向承重结构中混凝土总量的比例  0404060 是否必填
        /// </summary>
        public bool? IsRequiredC50ConcreteRatio { get; set; }

        /// <summary>
        /// C50混凝土用量占竖向承重结构中混凝土总量的比例  0404060 是否公开
        /// </summary>
        public bool? IsPublicC50ConcreteRatio { get; set; }
        /// <summary>
        /// 高耐久性混凝土占混凝土总量的比例  0404061
        /// </summary>
        public string HighDurabilityConcreteRatio { get; set; }

        /// <summary>
        /// 高耐久性混凝土占混凝土总量的比例  0404061 数据类别
        /// </summary>
        public string RecordTypeHighDurabilityConcreteRatio { get; set; }

        /// <summary>
        /// 高耐久性混凝土占混凝土总量的比例  0404061 是否必填
        /// </summary>
        public bool? IsRequiredHighDurabilityConcreteRatio { get; set; }

        /// <summary>
        /// 高耐久性混凝土占混凝土总量的比例  0404061 是否公开
        /// </summary>
        public bool? IsPublicHighDurabilityConcreteRatio { get; set; }
        /// <summary>
        /// Q235及以上高强钢材用量占钢材总量的比例  0404062
        /// </summary>
        public string Q235SteelRatio { get; set; }

        /// <summary>
        /// Q235及以上高强钢材用量占钢材总量的比例  0404062 数据类别
        /// </summary>
        public string RecordTypeQ235SteelRatio { get; set; }

        /// <summary>
        /// Q235及以上高强钢材用量占钢材总量的比例  0404062 是否必填
        /// </summary>
        public bool? IsRequiredQ235SteelRatio { get; set; }

        /// <summary>
        /// Q235及以上高强钢材用量占钢材总量的比例  0404062 是否公开
        /// </summary>
        public bool? IsPublicQ235SteelRatio { get; set; }
        /// <summary>
        /// 结构专业设计主要特点  0404063
        /// </summary>
        public string StructureMainFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0404063 数据类别
        /// </summary>
        public string RecordTypeStructureMainFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0404063 是否必填
        /// </summary>
        public bool? IsRequiredStructureMainFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0404063 是否公开
        /// </summary>
        public bool? IsPublicStructureMainFeatures { get; set; }
    }


    /// <summary>
    /// 绿色建筑模板—专业技术指标（设备专业）
    /// </summary>
    [Serializable]
    public class Template_0405 : TemplateBase
    {
        /// <summary>
        /// 采暖方式  0405001
        /// </summary>
        public string HeatingMode { get; set; }

        /// <summary>
        /// 采暖方式  0405001 数据类别
        /// </summary>
        public string RecordTypeHeatingMode { get; set; }

        /// <summary>
        /// 采暖方式  0405001 是否必填
        /// </summary>
        public bool? IsRequiredHeatingMode { get; set; }

        /// <summary>
        /// 采暖方式  0405001 是否公开
        /// </summary>
        public bool? IsPublicHeatingMode { get; set; }
        /// <summary>
        /// 采暖/空调总热负荷  0405002
        /// </summary>
        public string SpaceHeatingLoad { get; set; }

        /// <summary>
        /// 采暖/空调总热负荷  0405002 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 采暖/空调总热负荷  0405002 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 采暖/空调总热负荷  0405002 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoad { get; set; }
        /// <summary>
        /// 空调总冷负荷  0405003
        /// </summary>
        public string AirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调总冷负荷  0405003 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调总冷负荷  0405003 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调总冷负荷  0405003 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingLoad { get; set; }
        /// <summary>
        /// 空调通风方式  0405004
        /// </summary>
        public string AirConVentilationMode { get; set; }

        /// <summary>
        /// 空调通风方式  0405004 数据类别
        /// </summary>
        public string RecordTypeAirConVentilationMode { get; set; }

        /// <summary>
        /// 空调通风方式  0405004 是否必填
        /// </summary>
        public bool? IsRequiredAirConVentilationMode { get; set; }

        /// <summary>
        /// 空调通风方式  0405004 是否公开
        /// </summary>
        public bool? IsPublicAirConVentilationMode { get; set; }
        /// <summary>
        /// 空调水系统方式  0405005
        /// </summary>
        public string AirConWaterSystemMode { get; set; }

        /// <summary>
        /// 空调水系统方式  0405005 数据类别
        /// </summary>
        public string RecordTypeAirConWaterSystemMode { get; set; }

        /// <summary>
        /// 空调水系统方式  0405005 是否必填
        /// </summary>
        public bool? IsRequiredAirConWaterSystemMode { get; set; }

        /// <summary>
        /// 空调水系统方式  0405005 是否公开
        /// </summary>
        public bool? IsPublicAirConWaterSystemMode { get; set; }
        /// <summary>
        /// 给水系统方式  0405006
        /// </summary>
        public string WaterSupplySystemMode { get; set; }

        /// <summary>
        /// 给水系统方式  0405006 数据类别
        /// </summary>
        public string RecordTypeWaterSupplySystemMode { get; set; }

        /// <summary>
        /// 给水系统方式  0405006 是否必填
        /// </summary>
        public bool? IsRequiredWaterSupplySystemMode { get; set; }

        /// <summary>
        /// 给水系统方式  0405006 是否公开
        /// </summary>
        public bool? IsPublicWaterSupplySystemMode { get; set; }
        /// <summary>
        /// 中水回收使用方式  0405007
        /// </summary>
        public string ReclaimedWaterRecycling { get; set; }

        /// <summary>
        /// 中水回收使用方式  0405007 数据类别
        /// </summary>
        public string RecordTypeReclaimedWaterRecycling { get; set; }

        /// <summary>
        /// 中水回收使用方式  0405007 是否必填
        /// </summary>
        public bool? IsRequiredReclaimedWaterRecycling { get; set; }

        /// <summary>
        /// 中水回收使用方式  0405007 是否公开
        /// </summary>
        public bool? IsPublicReclaimedWaterRecycling { get; set; }
        /// <summary>
        /// 雨、污水排放方式  0405008
        /// </summary>
        public string SewageDischargeMode { get; set; }

        /// <summary>
        /// 雨、污水排放方式  0405008 数据类别
        /// </summary>
        public string RecordTypeSewageDischargeMode { get; set; }

        /// <summary>
        /// 雨、污水排放方式  0405008 是否必填
        /// </summary>
        public bool? IsRequiredSewageDischargeMode { get; set; }

        /// <summary>
        /// 雨、污水排放方式  0405008 是否公开
        /// </summary>
        public bool? IsPublicSewageDischargeMode { get; set; }
        /// <summary>
        /// 消防给水方式  0405009
        /// </summary>
        public string FireWaterSupplyMode { get; set; }

        /// <summary>
        /// 消防给水方式  0405009 数据类别
        /// </summary>
        public string RecordTypeFireWaterSupplyMode { get; set; }

        /// <summary>
        /// 消防给水方式  0405009 是否必填
        /// </summary>
        public bool? IsRequiredFireWaterSupplyMode { get; set; }

        /// <summary>
        /// 消防给水方式  0405009 是否公开
        /// </summary>
        public bool? IsPublicFireWaterSupplyMode { get; set; }
        /// <summary>
        /// 供暖、空调末端装置可独立启停的主要功能房间数量比例  0405010
        /// </summary>
        public string IndependentRatio { get; set; }

        /// <summary>
        /// 供暖、空调末端装置可独立启停的主要功能房间数量比例  0405010 数据类别
        /// </summary>
        public string RecordTypeIndependentRatio { get; set; }

        /// <summary>
        /// 供暖、空调末端装置可独立启停的主要功能房间数量比例  0405010 是否必填
        /// </summary>
        public bool? IsRequiredIndependentRatio { get; set; }

        /// <summary>
        /// 供暖、空调末端装置可独立启停的主要功能房间数量比例  0405010 是否公开
        /// </summary>
        public bool? IsPublicIndependentRatio { get; set; }
        /// <summary>
        /// 冷、热源机组能效指标比现行国家标准提高或降低幅度  0405011
        /// </summary>
        public string EnergyEfficiencyIndex { get; set; }

        /// <summary>
        /// 冷、热源机组能效指标比现行国家标准提高或降低幅度  0405011 数据类别
        /// </summary>
        public string RecordTypeEnergyEfficiencyIndex { get; set; }

        /// <summary>
        /// 冷、热源机组能效指标比现行国家标准提高或降低幅度  0405011 是否必填
        /// </summary>
        public bool? IsRequiredEnergyEfficiencyIndex { get; set; }

        /// <summary>
        /// 冷、热源机组能效指标比现行国家标准提高或降低幅度  0405011 是否公开
        /// </summary>
        public bool? IsPublicEnergyEfficiencyIndex { get; set; }
        /// <summary>
        /// 供暖、通风与空调系统能耗降低幅度  0405012
        /// </summary>
        public string EnergyConsumptionReductionRange { get; set; }

        /// <summary>
        /// 供暖、通风与空调系统能耗降低幅度  0405012 数据类别
        /// </summary>
        public string RecordTypeEnergyConsumptionReductionRange { get; set; }

        /// <summary>
        /// 供暖、通风与空调系统能耗降低幅度  0405012 是否必填
        /// </summary>
        public bool? IsRequiredEnergyConsumptionReductionRange { get; set; }

        /// <summary>
        /// 供暖、通风与空调系统能耗降低幅度  0405012 是否公开
        /// </summary>
        public bool? IsPublicEnergyConsumptionReductionRange { get; set; }
        /// <summary>
        /// 由可再生能源提供的空调用冷量和热量比例  0405013
        /// </summary>
        public string RenewableEnergyForAirConRatio { get; set; }

        /// <summary>
        /// 由可再生能源提供的空调用冷量和热量比例  0405013 数据类别
        /// </summary>
        public string RecordTypeRenewableEnergyForAirConRatio { get; set; }

        /// <summary>
        /// 由可再生能源提供的空调用冷量和热量比例  0405013 是否必填
        /// </summary>
        public bool? IsRequiredRenewableEnergyForAirConRatio { get; set; }

        /// <summary>
        /// 由可再生能源提供的空调用冷量和热量比例  0405013 是否公开
        /// </summary>
        public bool? IsPublicRenewableEnergyForAirConRatio { get; set; }
        /// <summary>
        /// 采用蓄冷蓄热系统（是/否）  0405014
        /// </summary>
        public string IsUsingStorageSystem { get; set; }

        /// <summary>
        /// 采用蓄冷蓄热系统（是/否）  0405014 数据类别
        /// </summary>
        public string RecordTypeIsUsingStorageSystem { get; set; }

        /// <summary>
        /// 采用蓄冷蓄热系统（是/否）  0405014 是否必填
        /// </summary>
        public bool? IsRequiredIsUsingStorageSystem { get; set; }

        /// <summary>
        /// 采用蓄冷蓄热系统（是/否）  0405014 是否公开
        /// </summary>
        public bool? IsPublicIsUsingStorageSystem { get; set; }
        /// <summary>
        /// 利用余热废热供给建筑蒸汽、供暖或生活热水需求（是/否）  0405015
        /// </summary>
        public string IsUsingWasteHeat { get; set; }

        /// <summary>
        /// 利用余热废热供给建筑蒸汽、供暖或生活热水需求（是/否）  0405015 数据类别
        /// </summary>
        public string RecordTypeIsUsingWasteHeat { get; set; }

        /// <summary>
        /// 利用余热废热供给建筑蒸汽、供暖或生活热水需求（是/否）  0405015 是否必填
        /// </summary>
        public bool? IsRequiredIsUsingWasteHeat { get; set; }

        /// <summary>
        /// 利用余热废热供给建筑蒸汽、供暖或生活热水需求（是/否）  0405015 是否公开
        /// </summary>
        public bool? IsPublicIsUsingWasteHeat { get; set; }
        /// <summary>
        /// 集中供暖系统热水循环泵的耗电输热比和通风空调系统风机的单位风量耗功率符合相关国家标准（是/否）  0405016
        /// </summary>
        public string IsStandard { get; set; }

        /// <summary>
        /// 集中供暖系统热水循环泵的耗电输热比和通风空调系统风机的单位风量耗功率符合相关国家标准（是/否）  0405016 数据类别
        /// </summary>
        public string RecordTypeIsStandard { get; set; }

        /// <summary>
        /// 集中供暖系统热水循环泵的耗电输热比和通风空调系统风机的单位风量耗功率符合相关国家标准（是/否）  0405016 是否必填
        /// </summary>
        public bool? IsRequiredIsStandard { get; set; }

        /// <summary>
        /// 集中供暖系统热水循环泵的耗电输热比和通风空调系统风机的单位风量耗功率符合相关国家标准（是/否）  0405016 是否公开
        /// </summary>
        public bool? IsPublicIsStandard { get; set; }
        /// <summary>
        /// 空调冷热水系统循环水泵的耗电输冷（热）比  0405017
        /// </summary>
        public string ConsumptionRatio { get; set; }

        /// <summary>
        /// 空调冷热水系统循环水泵的耗电输冷（热）比  0405017 数据类别
        /// </summary>
        public string RecordTypeConsumptionRatio { get; set; }

        /// <summary>
        /// 空调冷热水系统循环水泵的耗电输冷（热）比  0405017 是否必填
        /// </summary>
        public bool? IsRequiredConsumptionRatio { get; set; }

        /// <summary>
        /// 空调冷热水系统循环水泵的耗电输冷（热）比  0405017 是否公开
        /// </summary>
        public bool? IsPublicConsumptionRatio { get; set; }
        /// <summary>
        /// 比现行国家标准规定值降低的比率  0405018
        /// </summary>
        public string LowerThanStandardValueRatio { get; set; }

        /// <summary>
        /// 比现行国家标准规定值降低的比率  0405018 数据类别
        /// </summary>
        public string RecordTypeLowerThanStandardValueRatio { get; set; }

        /// <summary>
        /// 比现行国家标准规定值降低的比率  0405018 是否必填
        /// </summary>
        public bool? IsRequiredLowerThanStandardValueRatio { get; set; }

        /// <summary>
        /// 比现行国家标准规定值降低的比率  0405018 是否公开
        /// </summary>
        public bool? IsPublicLowerThanStandardValueRatio { get; set; }
        /// <summary>
        /// 场地年径流总量控制率  0405019
        /// </summary>
        public string RunoffControlRate { get; set; }

        /// <summary>
        /// 场地年径流总量控制率  0405019 数据类别
        /// </summary>
        public string RecordTypeRunoffControlRate { get; set; }

        /// <summary>
        /// 场地年径流总量控制率  0405019 是否必填
        /// </summary>
        public bool? IsRequiredRunoffControlRate { get; set; }

        /// <summary>
        /// 场地年径流总量控制率  0405019 是否公开
        /// </summary>
        public bool? IsPublicRunoffControlRate { get; set; }
        /// <summary>
        /// 非传统水源利用率  0405020
        /// </summary>
        public string NonTraditionalWaterUseRatio { get; set; }

        /// <summary>
        /// 非传统水源利用率  0405020 数据类别
        /// </summary>
        public string RecordTypeNonTraditionalWaterUseRatio { get; set; }

        /// <summary>
        /// 非传统水源利用率  0405020 是否必填
        /// </summary>
        public bool? IsRequiredNonTraditionalWaterUseRatio { get; set; }

        /// <summary>
        /// 非传统水源利用率  0405020 是否公开
        /// </summary>
        public bool? IsPublicNonTraditionalWaterUseRatio { get; set; }
        /// <summary>
        /// 平均日用水量  0405021
        /// </summary>
        public string DailyWaterConsumption { get; set; }

        /// <summary>
        /// 平均日用水量  0405021 数据类别
        /// </summary>
        public string RecordTypeDailyWaterConsumption { get; set; }

        /// <summary>
        /// 平均日用水量  0405021 是否必填
        /// </summary>
        public bool? IsRequiredDailyWaterConsumption { get; set; }

        /// <summary>
        /// 平均日用水量  0405021 是否公开
        /// </summary>
        public bool? IsPublicDailyWaterConsumption { get; set; }
        /// <summary>
        /// 用水点供水压力  0405022
        /// </summary>
        public string WaterSupplyPressure { get; set; }

        /// <summary>
        /// 用水点供水压力  0405022 数据类别
        /// </summary>
        public string RecordTypeWaterSupplyPressure { get; set; }

        /// <summary>
        /// 用水点供水压力  0405022 是否必填
        /// </summary>
        public bool? IsRequiredWaterSupplyPressure { get; set; }

        /// <summary>
        /// 用水点供水压力  0405022 是否公开
        /// </summary>
        public bool? IsPublicWaterSupplyPressure { get; set; }
        /// <summary>
        /// 卫生器具用水效率等级  0405023
        /// </summary>
        public string WaterEfficiencyRatingForSanitary { get; set; }

        /// <summary>
        /// 卫生器具用水效率等级  0405023 数据类别
        /// </summary>
        public string RecordTypeWaterEfficiencyRatingForSanitary { get; set; }

        /// <summary>
        /// 卫生器具用水效率等级  0405023 是否必填
        /// </summary>
        public bool? IsRequiredWaterEfficiencyRatingForSanitary { get; set; }

        /// <summary>
        /// 卫生器具用水效率等级  0405023 是否公开
        /// </summary>
        public bool? IsPublicWaterEfficiencyRatingForSanitary { get; set; }
        /// <summary>
        /// 分类设置用水计量装置（是/否）  0405024
        /// </summary>
        public string IsClassifyMeterage { get; set; }

        /// <summary>
        /// 分类设置用水计量装置（是/否）  0405024 数据类别
        /// </summary>
        public string RecordTypeIsClassifyMeterage { get; set; }

        /// <summary>
        /// 分类设置用水计量装置（是/否）  0405024 是否必填
        /// </summary>
        public bool? IsRequiredIsClassifyMeterage { get; set; }

        /// <summary>
        /// 分类设置用水计量装置（是/否）  0405024 是否公开
        /// </summary>
        public bool? IsPublicIsClassifyMeterage { get; set; }
        /// <summary>
        /// 绿化灌溉系统类别  0405025
        /// </summary>
        public string GreeningIrrigationSystemType { get; set; }

        /// <summary>
        /// 绿化灌溉系统类别  0405025 数据类别
        /// </summary>
        public string RecordTypeGreeningIrrigationSystemType { get; set; }

        /// <summary>
        /// 绿化灌溉系统类别  0405025 是否必填
        /// </summary>
        public bool? IsRequiredGreeningIrrigationSystemType { get; set; }

        /// <summary>
        /// 绿化灌溉系统类别  0405025 是否公开
        /// </summary>
        public bool? IsPublicGreeningIrrigationSystemType { get; set; }
        /// <summary>
        /// 由可再生能源提供的生活用热水比例  0405026
        /// </summary>
        public string RenewableEnergyForLivingHotWater { get; set; }

        /// <summary>
        /// 由可再生能源提供的生活用热水比例  0405026 数据类别
        /// </summary>
        public string RecordTypeRenewableEnergyForLivingHotWater { get; set; }

        /// <summary>
        /// 由可再生能源提供的生活用热水比例  0405026 是否必填
        /// </summary>
        public bool? IsRequiredRenewableEnergyForLivingHotWater { get; set; }

        /// <summary>
        /// 由可再生能源提供的生活用热水比例  0405026 是否公开
        /// </summary>
        public bool? IsPublicRenewableEnergyForLivingHotWater { get; set; }
        /// <summary>
        /// 相关节水技术或措施  0405027
        /// </summary>
        public string WaterSavingTechnology { get; set; }

        /// <summary>
        /// 相关节水技术或措施  0405027 数据类别
        /// </summary>
        public string RecordTypeWaterSavingTechnology { get; set; }

        /// <summary>
        /// 相关节水技术或措施  0405027 是否必填
        /// </summary>
        public bool? IsRequiredWaterSavingTechnology { get; set; }

        /// <summary>
        /// 相关节水技术或措施  0405027 是否公开
        /// </summary>
        public bool? IsPublicWaterSavingTechnology { get; set; }
        /// <summary>
        /// 设备专业设计主要特点  0405028
        /// </summary>
        public string MechanicalMainFeatures { get; set; }

        /// <summary>
        /// 设备专业设计主要特点  0405028 数据类别
        /// </summary>
        public string RecordTypeMechanicalMainFeatures { get; set; }

        /// <summary>
        /// 设备专业设计主要特点  0405028 是否必填
        /// </summary>
        public bool? IsRequiredMechanicalMainFeatures { get; set; }

        /// <summary>
        /// 设备专业设计主要特点  0405028 是否公开
        /// </summary>
        public bool? IsPublicMechanicalMainFeatures { get; set; }
    }


    /// <summary>
    /// 绿建—专业技术指标（电气专业）
    /// </summary>
    [Serializable]
    public class Template_0406 : TemplateBase
    {
        /// <summary>
        /// 动力总电负荷  0406001
        /// </summary>
        public string PowerTotalElectricLoad { get; set; }

        /// <summary>
        /// 动力总电负荷  0406001 数据类别
        /// </summary>
        public string RecordTypePowerTotalElectricLoad { get; set; }

        /// <summary>
        /// 动力总电负荷  0406001 是否必填
        /// </summary>
        public bool? IsRequiredPowerTotalElectricLoad { get; set; }

        /// <summary>
        /// 动力总电负荷  0406001 是否公开
        /// </summary>
        public bool? IsPublicPowerTotalElectricLoad { get; set; }
        /// <summary>
        /// 照明总电负荷  0406002
        /// </summary>
        public string LightingTotalElectricLoad { get; set; }

        /// <summary>
        /// 照明总电负荷  0406002 数据类别
        /// </summary>
        public string RecordTypeLightingTotalElectricLoad { get; set; }

        /// <summary>
        /// 照明总电负荷  0406002 是否必填
        /// </summary>
        public bool? IsRequiredLightingTotalElectricLoad { get; set; }

        /// <summary>
        /// 照明总电负荷  0406002 是否公开
        /// </summary>
        public bool? IsPublicLightingTotalElectricLoad { get; set; }
        /// <summary>
        /// 供电电源设计情况  0406003
        /// </summary>
        public string DesignOfPowerSupply { get; set; }

        /// <summary>
        /// 供电电源设计情况  0406003 数据类别
        /// </summary>
        public string RecordTypeDesignOfPowerSupply { get; set; }

        /// <summary>
        /// 供电电源设计情况  0406003 是否必填
        /// </summary>
        public bool? IsRequiredDesignOfPowerSupply { get; set; }

        /// <summary>
        /// 供电电源设计情况  0406003 是否公开
        /// </summary>
        public bool? IsPublicDesignOfPowerSupply { get; set; }
        /// <summary>
        /// 变压器装机台数  0406004
        /// </summary>
        public string TransformerInstalledNumber { get; set; }

        /// <summary>
        /// 变压器装机台数  0406004 数据类别
        /// </summary>
        public string RecordTypeTransformerInstalledNumber { get; set; }

        /// <summary>
        /// 变压器装机台数  0406004 是否必填
        /// </summary>
        public bool? IsRequiredTransformerInstalledNumber { get; set; }

        /// <summary>
        /// 变压器装机台数  0406004 是否公开
        /// </summary>
        public bool? IsPublicTransformerInstalledNumber { get; set; }
        /// <summary>
        /// 变压器装机容量  0406005
        /// </summary>
        public string TransformerInstalledCapacity { get; set; }

        /// <summary>
        /// 变压器装机容量  0406005 数据类别
        /// </summary>
        public string RecordTypeTransformerInstalledCapacity { get; set; }

        /// <summary>
        /// 变压器装机容量  0406005 是否必填
        /// </summary>
        public bool? IsRequiredTransformerInstalledCapacity { get; set; }

        /// <summary>
        /// 变压器装机容量  0406005 是否公开
        /// </summary>
        public bool? IsPublicTransformerInstalledCapacity { get; set; }
        /// <summary>
        /// 用电负荷等级确定情况  0406006
        /// </summary>
        public string PowerLoadLevel { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0406006 数据类别
        /// </summary>
        public string RecordTypePowerLoadLevel { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0406006 是否必填
        /// </summary>
        public bool? IsRequiredPowerLoadLevel { get; set; }

        /// <summary>
        /// 用电负荷等级确定情况  0406006 是否公开
        /// </summary>
        public bool? IsPublicPowerLoadLevel { get; set; }
        /// <summary>
        /// 变压器装置指标  0406007
        /// </summary>
        public string TransformerIndex { get; set; }

        /// <summary>
        /// 变压器装置指标  0406007 数据类别
        /// </summary>
        public string RecordTypeTransformerIndex { get; set; }

        /// <summary>
        /// 变压器装置指标  0406007 是否必填
        /// </summary>
        public bool? IsRequiredTransformerIndex { get; set; }

        /// <summary>
        /// 变压器装置指标  0406007 是否公开
        /// </summary>
        public bool? IsPublicTransformerIndex { get; set; }
        /// <summary>
        /// 三相配电变压器能效等级  0406008
        /// </summary>
        public string TransformerEnergyEfficiencyRating { get; set; }

        /// <summary>
        /// 三相配电变压器能效等级  0406008 数据类别
        /// </summary>
        public string RecordTypeTransformerEnergyEfficiencyRating { get; set; }

        /// <summary>
        /// 三相配电变压器能效等级  0406008 是否必填
        /// </summary>
        public bool? IsRequiredTransformerEnergyEfficiencyRating { get; set; }

        /// <summary>
        /// 三相配电变压器能效等级  0406008 是否公开
        /// </summary>
        public bool? IsPublicTransformerEnergyEfficiencyRating { get; set; }
        /// <summary>
        /// 主要谐波源  0406009
        /// </summary>
        public string HarmonicSource { get; set; }

        /// <summary>
        /// 主要谐波源  0406009 数据类别
        /// </summary>
        public string RecordTypeHarmonicSource { get; set; }

        /// <summary>
        /// 主要谐波源  0406009 是否必填
        /// </summary>
        public bool? IsRequiredHarmonicSource { get; set; }

        /// <summary>
        /// 主要谐波源  0406009 是否公开
        /// </summary>
        public bool? IsPublicHarmonicSource { get; set; }
        /// <summary>
        /// 低压供电半径  0406010
        /// </summary>
        public string LowVoltagePowerSupplyRadius { get; set; }

        /// <summary>
        /// 低压供电半径  0406010 数据类别
        /// </summary>
        public string RecordTypeLowVoltagePowerSupplyRadius { get; set; }

        /// <summary>
        /// 低压供电半径  0406010 是否必填
        /// </summary>
        public bool? IsRequiredLowVoltagePowerSupplyRadius { get; set; }

        /// <summary>
        /// 低压供电半径  0406010 是否公开
        /// </summary>
        public bool? IsPublicLowVoltagePowerSupplyRadius { get; set; }
        /// <summary>
        /// 电源侧功率因数  0406011
        /// </summary>
        public string PowerFactor { get; set; }

        /// <summary>
        /// 电源侧功率因数  0406011 数据类别
        /// </summary>
        public string RecordTypePowerFactor { get; set; }

        /// <summary>
        /// 电源侧功率因数  0406011 是否必填
        /// </summary>
        public bool? IsRequiredPowerFactor { get; set; }

        /// <summary>
        /// 电源侧功率因数  0406011 是否公开
        /// </summary>
        public bool? IsPublicPowerFactor { get; set; }
        /// <summary>
        /// 谐波治理措施  0406012
        /// </summary>
        public string HarmonicControl { get; set; }

        /// <summary>
        /// 谐波治理措施  0406012 数据类别
        /// </summary>
        public string RecordTypeHarmonicControl { get; set; }

        /// <summary>
        /// 谐波治理措施  0406012 是否必填
        /// </summary>
        public bool? IsRequiredHarmonicControl { get; set; }

        /// <summary>
        /// 谐波治理措施  0406012 是否公开
        /// </summary>
        public bool? IsPublicHarmonicControl { get; set; }
        /// <summary>
        /// 照明方式节能措施  0406013
        /// </summary>
        public string EnergySavingMeasures { get; set; }

        /// <summary>
        /// 照明方式节能措施  0406013 数据类别
        /// </summary>
        public string RecordTypeEnergySavingMeasures { get; set; }

        /// <summary>
        /// 照明方式节能措施  0406013 是否必填
        /// </summary>
        public bool? IsRequiredEnergySavingMeasures { get; set; }

        /// <summary>
        /// 照明方式节能措施  0406013 是否公开
        /// </summary>
        public bool? IsPublicEnergySavingMeasures { get; set; }
        /// <summary>
        /// 所有区域均达到现行值(是/否)  0406014
        /// </summary>
        public string IsAllAreasReachCurrentValue { get; set; }

        /// <summary>
        /// 所有区域均达到现行值(是/否)  0406014 数据类别
        /// </summary>
        public string RecordTypeIsAllAreasReachCurrentValue { get; set; }

        /// <summary>
        /// 所有区域均达到现行值(是/否)  0406014 是否必填
        /// </summary>
        public bool? IsRequiredIsAllAreasReachCurrentValue { get; set; }

        /// <summary>
        /// 所有区域均达到现行值(是/否)  0406014 是否公开
        /// </summary>
        public bool? IsPublicIsAllAreasReachCurrentValue { get; set; }
        /// <summary>
        /// 主要功能房间达到目标值(是/否)  0406015
        /// </summary>
        public string IsMainRoomAchieveTargetValue { get; set; }

        /// <summary>
        /// 主要功能房间达到目标值(是/否)  0406015 数据类别
        /// </summary>
        public string RecordTypeIsMainRoomAchieveTargetValue { get; set; }

        /// <summary>
        /// 主要功能房间达到目标值(是/否)  0406015 是否必填
        /// </summary>
        public bool? IsRequiredIsMainRoomAchieveTargetValue { get; set; }

        /// <summary>
        /// 主要功能房间达到目标值(是/否)  0406015 是否公开
        /// </summary>
        public bool? IsPublicIsMainRoomAchieveTargetValue { get; set; }
        /// <summary>
        /// 所有区域均达到目标值(是/否)  0406016
        /// </summary>
        public string IsAllAreasAchieveTargetValue { get; set; }

        /// <summary>
        /// 所有区域均达到目标值(是/否)  0406016 数据类别
        /// </summary>
        public string RecordTypeIsAllAreasAchieveTargetValue { get; set; }

        /// <summary>
        /// 所有区域均达到目标值(是/否)  0406016 是否必填
        /// </summary>
        public bool? IsRequiredIsAllAreasAchieveTargetValue { get; set; }

        /// <summary>
        /// 所有区域均达到目标值(是/否)  0406016 是否公开
        /// </summary>
        public bool? IsPublicIsAllAreasAchieveTargetValue { get; set; }
        /// <summary>
        /// 灯具名称1  0406017
        /// </summary>
        public string LampName1 { get; set; }

        /// <summary>
        /// 灯具名称1  0406017 数据类别
        /// </summary>
        public string RecordTypeLampName1 { get; set; }

        /// <summary>
        /// 灯具名称1  0406017 是否必填
        /// </summary>
        public bool? IsRequiredLampName1 { get; set; }

        /// <summary>
        /// 灯具名称1  0406017 是否公开
        /// </summary>
        public bool? IsPublicLampName1 { get; set; }
        /// <summary>
        /// 灯具效率1  0406018
        /// </summary>
        public string LampEfficiency1 { get; set; }

        /// <summary>
        /// 灯具效率1  0406018 数据类别
        /// </summary>
        public string RecordTypeLampEfficiency1 { get; set; }

        /// <summary>
        /// 灯具效率1  0406018 是否必填
        /// </summary>
        public bool? IsRequiredLampEfficiency1 { get; set; }

        /// <summary>
        /// 灯具效率1  0406018 是否公开
        /// </summary>
        public bool? IsPublicLampEfficiency1 { get; set; }
        /// <summary>
        /// 灯具名称2  0406019
        /// </summary>
        public string LampName2 { get; set; }

        /// <summary>
        /// 灯具名称2  0406019 数据类别
        /// </summary>
        public string RecordTypeLampName2 { get; set; }

        /// <summary>
        /// 灯具名称2  0406019 是否必填
        /// </summary>
        public bool? IsRequiredLampName2 { get; set; }

        /// <summary>
        /// 灯具名称2  0406019 是否公开
        /// </summary>
        public bool? IsPublicLampName2 { get; set; }
        /// <summary>
        /// 灯具效率2  0406020
        /// </summary>
        public string LampEfficiency2 { get; set; }

        /// <summary>
        /// 灯具效率2  0406020 数据类别
        /// </summary>
        public string RecordTypeLampEfficiency2 { get; set; }

        /// <summary>
        /// 灯具效率2  0406020 是否必填
        /// </summary>
        public bool? IsRequiredLampEfficiency2 { get; set; }

        /// <summary>
        /// 灯具效率2  0406020 是否公开
        /// </summary>
        public bool? IsPublicLampEfficiency2 { get; set; }
        /// <summary>
        /// 灯具名称3  0406021
        /// </summary>
        public string LampName3 { get; set; }

        /// <summary>
        /// 灯具名称3  0406021 数据类别
        /// </summary>
        public string RecordTypeLampName3 { get; set; }

        /// <summary>
        /// 灯具名称3  0406021 是否必填
        /// </summary>
        public bool? IsRequiredLampName3 { get; set; }

        /// <summary>
        /// 灯具名称3  0406021 是否公开
        /// </summary>
        public bool? IsPublicLampName3 { get; set; }
        /// <summary>
        /// 灯具效率3  0406022
        /// </summary>
        public string LampEfficiency3 { get; set; }

        /// <summary>
        /// 灯具效率3  0406022 数据类别
        /// </summary>
        public string RecordTypeLampEfficiency3 { get; set; }

        /// <summary>
        /// 灯具效率3  0406022 是否必填
        /// </summary>
        public bool? IsRequiredLampEfficiency3 { get; set; }

        /// <summary>
        /// 灯具效率3  0406022 是否公开
        /// </summary>
        public bool? IsPublicLampEfficiency3 { get; set; }
        /// <summary>
        /// 显色指数是否全部达标  0406023
        /// </summary>
        public string IsColorRenderingIndexUpToStandard { get; set; }

        /// <summary>
        /// 显色指数是否全部达标  0406023 数据类别
        /// </summary>
        public string RecordTypeIsColorRenderingIndexUpToStandard { get; set; }

        /// <summary>
        /// 显色指数是否全部达标  0406023 是否必填
        /// </summary>
        public bool? IsRequiredIsColorRenderingIndexUpToStandard { get; set; }

        /// <summary>
        /// 显色指数是否全部达标  0406023 是否公开
        /// </summary>
        public bool? IsPublicIsColorRenderingIndexUpToStandard { get; set; }
        /// <summary>
        /// 眩光值是否全部达标  0406024
        /// </summary>
        public string IsGlareValueUpToStandard { get; set; }

        /// <summary>
        /// 眩光值是否全部达标  0406024 数据类别
        /// </summary>
        public string RecordTypeIsGlareValueUpToStandard { get; set; }

        /// <summary>
        /// 眩光值是否全部达标  0406024 是否必填
        /// </summary>
        public bool? IsRequiredIsGlareValueUpToStandard { get; set; }

        /// <summary>
        /// 眩光值是否全部达标  0406024 是否公开
        /// </summary>
        public bool? IsPublicIsGlareValueUpToStandard { get; set; }
        /// <summary>
        /// 动力内容  0406025
        /// </summary>
        public string DynamicContent { get; set; }

        /// <summary>
        /// 动力内容  0406025 数据类别
        /// </summary>
        public string RecordTypeDynamicContent { get; set; }

        /// <summary>
        /// 动力内容  0406025 是否必填
        /// </summary>
        public bool? IsRequiredDynamicContent { get; set; }

        /// <summary>
        /// 动力内容  0406025 是否公开
        /// </summary>
        public bool? IsPublicDynamicContent { get; set; }
        /// <summary>
        /// 采用独立分项计量  0406026
        /// </summary>
        public string IndependentComponentMeasurement { get; set; }

        /// <summary>
        /// 采用独立分项计量  0406026 数据类别
        /// </summary>
        public string RecordTypeIndependentComponentMeasurement { get; set; }

        /// <summary>
        /// 采用独立分项计量  0406026 是否必填
        /// </summary>
        public bool? IsRequiredIndependentComponentMeasurement { get; set; }

        /// <summary>
        /// 采用独立分项计量  0406026 是否公开
        /// </summary>
        public bool? IsPublicIndependentComponentMeasurement { get; set; }
        /// <summary>
        /// 弱电设计内容  0406027
        /// </summary>
        public string WeakDesignContent { get; set; }

        /// <summary>
        /// 弱电设计内容  0406027 数据类别
        /// </summary>
        public string RecordTypeWeakDesignContent { get; set; }

        /// <summary>
        /// 弱电设计内容  0406027 是否必填
        /// </summary>
        public bool? IsRequiredWeakDesignContent { get; set; }

        /// <summary>
        /// 弱电设计内容  0406027 是否公开
        /// </summary>
        public bool? IsPublicWeakDesignContent { get; set; }
        /// <summary>
        /// 室内空气质量监控系统方式  0406028
        /// </summary>
        public string IndoorAirQualityMonitoringSystem { get; set; }

        /// <summary>
        /// 室内空气质量监控系统方式  0406028 数据类别
        /// </summary>
        public string RecordTypeIndoorAirQualityMonitoringSystem { get; set; }

        /// <summary>
        /// 室内空气质量监控系统方式  0406028 是否必填
        /// </summary>
        public bool? IsRequiredIndoorAirQualityMonitoringSystem { get; set; }

        /// <summary>
        /// 室内空气质量监控系统方式  0406028 是否公开
        /// </summary>
        public bool? IsPublicIndoorAirQualityMonitoringSystem { get; set; }
        /// <summary>
        /// 由可再生能源提供的电量比例  0406029
        /// </summary>
        public string RenewableEnergySourcesRatio { get; set; }

        /// <summary>
        /// 由可再生能源提供的电量比例  0406029 数据类别
        /// </summary>
        public string RecordTypeRenewableEnergySourcesRatio { get; set; }

        /// <summary>
        /// 由可再生能源提供的电量比例  0406029 是否必填
        /// </summary>
        public bool? IsRequiredRenewableEnergySourcesRatio { get; set; }

        /// <summary>
        /// 由可再生能源提供的电量比例  0406029 是否公开
        /// </summary>
        public bool? IsPublicRenewableEnergySourcesRatio { get; set; }
        /// <summary>
        /// 防雷设防类别及方式  0406030
        /// </summary>
        public string LightningProtectionClass { get; set; }

        /// <summary>
        /// 防雷设防类别及方式  0406030 数据类别
        /// </summary>
        public string RecordTypeLightningProtectionClass { get; set; }

        /// <summary>
        /// 防雷设防类别及方式  0406030 是否必填
        /// </summary>
        public bool? IsRequiredLightningProtectionClass { get; set; }

        /// <summary>
        /// 防雷设防类别及方式  0406030 是否公开
        /// </summary>
        public bool? IsPublicLightningProtectionClass { get; set; }
        /// <summary>
        /// 电气专业设计主要特点  0406031
        /// </summary>
        public string ElectricalMainFeatures { get; set; }

        /// <summary>
        /// 电气专业设计主要特点  0406031 数据类别
        /// </summary>
        public string RecordTypeElectricalMainFeatures { get; set; }

        /// <summary>
        /// 电气专业设计主要特点  0406031 是否必填
        /// </summary>
        public bool? IsRequiredElectricalMainFeatures { get; set; }

        /// <summary>
        /// 电气专业设计主要特点  0406031 是否公开
        /// </summary>
        public bool? IsPublicElectricalMainFeatures { get; set; }
    }


    /// <summary>
    /// 绿建—专业技术指标（技术经济指标）
    /// </summary>
    [Serializable]
    public class Template_0407 : TemplateBase
    {
        /// <summary>
        /// 单位规模建筑面积指标  0407001
        /// </summary>
        public string UnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0407001 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0407001 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicators { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标  0407001 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicators { get; set; }
        /// <summary>
        /// 单位规模建筑面积指标单位  0407002
        /// </summary>
        public string UnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0407002 数据类别
        /// </summary>
        public string RecordTypeUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0407002 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaIndicatorsUnit { get; set; }

        /// <summary>
        /// 单位规模建筑面积指标单位  0407002 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaIndicatorsUnit { get; set; }
        /// <summary>
        /// 使用面积系数  0407003
        /// </summary>
        public string UseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0407003 数据类别
        /// </summary>
        public string RecordTypeUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0407003 是否必填
        /// </summary>
        public bool? IsRequiredUseAreaCoefficient { get; set; }

        /// <summary>
        /// 使用面积系数  0407003 是否公开
        /// </summary>
        public bool? IsPublicUseAreaCoefficient { get; set; }
        /// <summary>
        /// 单位建筑面积耗热量指标  0407004
        /// </summary>
        public string UnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0407004 数据类别
        /// </summary>
        public string RecordTypeUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0407004 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaHotConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗热量指标  0407004 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaHotConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积耗冷量指标  0407005
        /// </summary>
        public string UnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0407005 数据类别
        /// </summary>
        public string RecordTypeUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0407005 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaColdConsumption { get; set; }

        /// <summary>
        /// 单位建筑面积耗冷量指标  0407005 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaColdConsumption { get; set; }
        /// <summary>
        /// 单位建筑面积变压器装机容量  0407006
        /// </summary>
        public string UnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0407006 数据类别
        /// </summary>
        public string RecordTypeUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0407006 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaTransformerCapacity { get; set; }

        /// <summary>
        /// 单位建筑面积变压器装机容量  0407006 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaTransformerCapacity { get; set; }
        /// <summary>
        /// 日供水量  0407007
        /// </summary>
        public string DailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0407007 数据类别
        /// </summary>
        public string RecordTypeDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0407007 是否必填
        /// </summary>
        public bool? IsRequiredDailyWaterSupply { get; set; }

        /// <summary>
        /// 日供水量  0407007 是否公开
        /// </summary>
        public bool? IsPublicDailyWaterSupply { get; set; }
        /// <summary>
        /// 建筑总能耗  0407008
        /// </summary>
        public string ConstructionTotalEnergyConsumption { get; set; }

        /// <summary>
        /// 建筑总能耗  0407008 数据类别
        /// </summary>
        public string RecordTypeConstructionTotalEnergyConsumption { get; set; }

        /// <summary>
        /// 建筑总能耗  0407008 是否必填
        /// </summary>
        public bool? IsRequiredConstructionTotalEnergyConsumption { get; set; }

        /// <summary>
        /// 建筑总能耗  0407008 是否公开
        /// </summary>
        public bool? IsPublicConstructionTotalEnergyConsumption { get; set; }
        /// <summary>
        /// 单位面积能耗  0407009
        /// </summary>
        public string UnitAreaEnergyConsumption { get; set; }

        /// <summary>
        /// 单位面积能耗  0407009 数据类别
        /// </summary>
        public string RecordTypeUnitAreaEnergyConsumption { get; set; }

        /// <summary>
        /// 单位面积能耗  0407009 是否必填
        /// </summary>
        public bool? IsRequiredUnitAreaEnergyConsumption { get; set; }

        /// <summary>
        /// 单位面积能耗  0407009 是否公开
        /// </summary>
        public bool? IsPublicUnitAreaEnergyConsumption { get; set; }
        /// <summary>
        /// 年用水总量  0407010
        /// </summary>
        public string PerYearTotalWaterConsumption { get; set; }

        /// <summary>
        /// 年用水总量  0407010 数据类别
        /// </summary>
        public string RecordTypePerYearTotalWaterConsumption { get; set; }

        /// <summary>
        /// 年用水总量  0407010 是否必填
        /// </summary>
        public bool? IsRequiredPerYearTotalWaterConsumption { get; set; }

        /// <summary>
        /// 年用水总量  0407010 是否公开
        /// </summary>
        public bool? IsPublicPerYearTotalWaterConsumption { get; set; }
        /// <summary>
        /// 年节电量  0407011
        /// </summary>
        public string PerYearPowerSaving { get; set; }

        /// <summary>
        /// 年节电量  0407011 数据类别
        /// </summary>
        public string RecordTypePerYearPowerSaving { get; set; }

        /// <summary>
        /// 年节电量  0407011 是否必填
        /// </summary>
        public bool? IsRequiredPerYearPowerSaving { get; set; }

        /// <summary>
        /// 年节电量  0407011 是否公开
        /// </summary>
        public bool? IsPublicPerYearPowerSaving { get; set; }
        /// <summary>
        /// 年节水量  0407012
        /// </summary>
        public string PerYearWaterSaving { get; set; }

        /// <summary>
        /// 年节水量  0407012 数据类别
        /// </summary>
        public string RecordTypePerYearWaterSaving { get; set; }

        /// <summary>
        /// 年节水量  0407012 是否必填
        /// </summary>
        public bool? IsRequiredPerYearWaterSaving { get; set; }

        /// <summary>
        /// 年节水量  0407012 是否公开
        /// </summary>
        public bool? IsPublicPerYearWaterSaving { get; set; }
        /// <summary>
        /// 年节煤量  0407013
        /// </summary>
        public string PerYearCoalSaving { get; set; }

        /// <summary>
        /// 年节煤量  0407013 数据类别
        /// </summary>
        public string RecordTypePerYearCoalSaving { get; set; }

        /// <summary>
        /// 年节煤量  0407013 是否必填
        /// </summary>
        public bool? IsRequiredPerYearCoalSaving { get; set; }

        /// <summary>
        /// 年节煤量  0407013 是否公开
        /// </summary>
        public bool? IsPublicPerYearCoalSaving { get; set; }
        /// <summary>
        /// 每年减排二氧化碳  0407014
        /// </summary>
        public string PerYaerCarbonEmissionReduction { get; set; }

        /// <summary>
        /// 每年减排二氧化碳  0407014 数据类别
        /// </summary>
        public string RecordTypePerYaerCarbonEmissionReduction { get; set; }

        /// <summary>
        /// 每年减排二氧化碳  0407014 是否必填
        /// </summary>
        public bool? IsRequiredPerYaerCarbonEmissionReduction { get; set; }

        /// <summary>
        /// 每年减排二氧化碳  0407014 是否公开
        /// </summary>
        public bool? IsPublicPerYaerCarbonEmissionReduction { get; set; }
        /// <summary>
        /// 概算_总造价_人民币  0407015
        /// </summary>
        public string Estimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0407015 数据类别
        /// </summary>
        public string RecordTypeEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0407015 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_RMB { get; set; }

        /// <summary>
        /// 概算_总造价_人民币  0407015 是否公开
        /// </summary>
        public bool? IsPublicEstimate_RMB { get; set; }
        /// <summary>
        /// 概算_总造价_外币  0407016
        /// </summary>
        public string Estimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0407016 数据类别
        /// </summary>
        public string RecordTypeEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0407016 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_ForeignCurrency { get; set; }

        /// <summary>
        /// 概算_总造价_外币  0407016 是否公开
        /// </summary>
        public bool? IsPublicEstimate_ForeignCurrency { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0407017
        /// </summary>
        public string Estimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0407017 数据类别
        /// </summary>
        public string RecordTypeEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0407017 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_CivilEngineering { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_土建  0407017 是否公开
        /// </summary>
        public bool? IsPublicEstimate_CivilEngineering { get; set; }
        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0407018
        /// </summary>
        public string Estimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0407018 数据类别
        /// </summary>
        public string RecordTypeEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0407018 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Install { get; set; }

        /// <summary>
        /// 概算_土建与安装工程的比例_安装  0407018 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Install { get; set; }
        /// <summary>
        /// 概算_单位建筑面积造价  0407019
        /// </summary>
        public string Estimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0407019 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0407019 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitAreaRMB { get; set; }

        /// <summary>
        /// 概算_单位建筑面积造价  0407019 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitAreaRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价  0407020
        /// </summary>
        public string Estimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0407020 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0407020 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMB { get; set; }

        /// <summary>
        /// 概算_单位规模造价  0407020 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMB { get; set; }
        /// <summary>
        /// 概算_单位规模造价单位  0407021
        /// </summary>
        public string Estimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0407021 数据类别
        /// </summary>
        public string RecordTypeEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0407021 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_PerUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 概算_单位规模造价单位  0407021 是否公开
        /// </summary>
        public bool? IsPublicEstimate_PerUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 概算_绿色建筑增量成本  0407022
        /// </summary>
        public string Estimate_IncrementalCost { get; set; }

        /// <summary>
        /// 概算_绿色建筑增量成本  0407022 数据类别
        /// </summary>
        public string RecordTypeEstimate_IncrementalCost { get; set; }

        /// <summary>
        /// 概算_绿色建筑增量成本  0407022 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_IncrementalCost { get; set; }

        /// <summary>
        /// 概算_绿色建筑增量成本  0407022 是否公开
        /// </summary>
        public bool? IsPublicEstimate_IncrementalCost { get; set; }
        /// <summary>
        /// 竣工决算_总造价_人民币  0407023
        /// </summary>
        public string Settlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0407023 数据类别
        /// </summary>
        public string RecordTypeSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0407023 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_RMB { get; set; }

        /// <summary>
        /// 竣工决算_总造价_人民币  0407023 是否公开
        /// </summary>
        public bool? IsPublicSettlement_RMB { get; set; }
        /// <summary>
        /// 竣工决算_总造价_外币  0407024
        /// </summary>
        public string Settlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0407024 数据类别
        /// </summary>
        public string RecordTypeSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0407024 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_ForeignCurrency { get; set; }

        /// <summary>
        /// 竣工决算_总造价_外币  0407024 是否公开
        /// </summary>
        public bool? IsPublicSettlement_ForeignCurrency { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0407025
        /// </summary>
        public string Settlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0407025 数据类别
        /// </summary>
        public string RecordTypeSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0407025 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_CivilEngineering { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_土建  0407025 是否公开
        /// </summary>
        public bool? IsPublicSettlement_CivilEngineering { get; set; }
        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0407026
        /// </summary>
        public string Settlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0407026 数据类别
        /// </summary>
        public string RecordTypeSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0407026 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_Install { get; set; }

        /// <summary>
        /// 竣工决算_土建与安装工程的比例_安装  0407026 是否公开
        /// </summary>
        public bool? IsPublicSettlement_Install { get; set; }
        /// <summary>
        /// 竣工决算_单位建筑面积造价  0407027
        /// </summary>
        public string Settlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0407027 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0407027 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitAreaRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位建筑面积造价  0407027 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitAreaRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价  0407028
        /// </summary>
        public string Settlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0407028 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0407028 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMB { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价  0407028 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMB { get; set; }
        /// <summary>
        /// 竣工决算_单位规模造价单位  0407029
        /// </summary>
        public string Settlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0407029 数据类别
        /// </summary>
        public string RecordTypeSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0407029 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_OneUnitScaleRMBUnit { get; set; }

        /// <summary>
        /// 竣工决算_单位规模造价单位  0407029 是否公开
        /// </summary>
        public bool? IsPublicSettlement_OneUnitScaleRMBUnit { get; set; }
        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0407030
        /// </summary>
        public string Settlement_IncrementalCost { get; set; }

        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0407030 数据类别
        /// </summary>
        public string RecordTypeSettlement_IncrementalCost { get; set; }

        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0407030 是否必填
        /// </summary>
        public bool? IsRequiredSettlement_IncrementalCost { get; set; }

        /// <summary>
        /// 竣工决算_绿色建筑增量成本  0407030 是否公开
        /// </summary>
        public bool? IsPublicSettlement_IncrementalCost { get; set; }
        /// <summary>
        /// 结算与概算出入的主要原因  0407031
        /// </summary>
        public string Estimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0407031 数据类别
        /// </summary>
        public string RecordTypeEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0407031 是否必填
        /// </summary>
        public bool? IsRequiredEstimate_Settlement_Difference { get; set; }

        /// <summary>
        /// 结算与概算出入的主要原因  0407031 是否公开
        /// </summary>
        public bool? IsPublicEstimate_Settlement_Difference { get; set; }
        /// <summary>
        /// 经济专业主要特点  0407032
        /// </summary>
        public string EconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0407032 数据类别
        /// </summary>
        public string RecordTypeEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0407032 是否必填
        /// </summary>
        public bool? IsRequiredEconomicsFeatures { get; set; }

        /// <summary>
        /// 经济专业主要特点  0407032 是否公开
        /// </summary>
        public bool? IsPublicEconomicsFeatures { get; set; }
    }


    /// <summary>
    /// 绿建—审核意见
    /// </summary>
    [Serializable]
    public class Template_0408 : TemplateBase
    {
        /// <summary>
        /// 曾获奖项  0408001
        /// </summary>
        public string Award { get; set; }

        /// <summary>
        /// 曾获奖项  0408001 数据类别
        /// </summary>
        public string RecordTypeAward { get; set; }

        /// <summary>
        /// 曾获奖项  0408001 是否必填
        /// </summary>
        public bool? IsRequiredAward { get; set; }

        /// <summary>
        /// 曾获奖项  0408001 是否公开
        /// </summary>
        public bool? IsPublicAward { get; set; }
        /// <summary>
        /// 申报单位意见  0408002
        /// </summary>
        public string CompanyOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0408002 数据类别
        /// </summary>
        public string RecordTypeCompanyOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0408002 是否必填
        /// </summary>
        public bool? IsRequiredCompanyOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0408002 是否公开
        /// </summary>
        public bool? IsPublicCompanyOpinion { get; set; }
        /// <summary>
        /// 申报单位填写时间  0408003
        /// </summary>
        public string CompanyOpinionDate { get; set; }

        /// <summary>
        /// 申报单位填写时间  0408003 数据类别
        /// </summary>
        public string RecordTypeCompanyOpinionDate { get; set; }

        /// <summary>
        /// 申报单位填写时间  0408003 是否必填
        /// </summary>
        public bool? IsRequiredCompanyOpinionDate { get; set; }

        /// <summary>
        /// 申报单位填写时间  0408003 是否公开
        /// </summary>
        public bool? IsPublicCompanyOpinionDate { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0408004
        /// </summary>
        public string AssociationOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0408004 数据类别
        /// </summary>
        public string RecordTypeAssociationOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0408004 是否必填
        /// </summary>
        public bool? IsRequiredAssociationOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0408004 是否公开
        /// </summary>
        public bool? IsPublicAssociationOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见填写时间  0408005
        /// </summary>
        public string AssociationOpinionDate { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见填写时间  0408005 数据类别
        /// </summary>
        public string RecordTypeAssociationOpinionDate { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见填写时间  0408005 是否必填
        /// </summary>
        public bool? IsRequiredAssociationOpinionDate { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见填写时间  0408005 是否公开
        /// </summary>
        public bool? IsPublicAssociationOpinionDate { get; set; }
    }

}