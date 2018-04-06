using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{    /// <summary>
    /// 水系统工程项目奖申报模板
    /// </summary>
    [Serializable]
    public class Template_18_WaterSystem : TemplateBase
    {
        /// <summary>
        /// 水系统工程项目—基础信息
        /// </summary>
        public Template_1801 part_01 { get; set; }

        /// <summary>
        /// 水系统工程项目—项目特点
        /// </summary>
        public Template_1802 part_02 { get; set; }
        /// <summary>
        /// 水系统工程项目—建设内容
        /// </summary>
        public Template_1803 part_03 { get; set; }
        /// <summary>
        /// 水系统工程项目—项目特点
        /// </summary>
        public Template_1804 part_04 { get; set; }
        /// <summary>
        /// 水系统工程项目—使用单位反馈意见
        /// </summary>
        public Template_1805 part_05 { get; set; }
        /// <summary>
        /// 水系统工程项目—施工单位反馈意见
        /// </summary>
        public Template_1806 part_06 { get; set; }
    }
    /// <summary>
    /// 水系统工程项目—基础信息
    /// </summary>
    [Serializable]
    public class Template_1801 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1801001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1801001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1801001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  1801001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 项目类别  1801002
        /// </summary>
        public string DeclarationCategory { get; set; }

        /// <summary>
        /// 项目类别  1801002 数据类别
        /// </summary>
        public string RecordTypeDeclarationCategory { get; set; }

        /// <summary>
        /// 项目类别  1801002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationCategory { get; set; }

        /// <summary>
        /// 项目类别  1801002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationCategory { get; set; }
        /// <summary>
        /// 申报单位  1801003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1801003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1801003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1801003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 合作单位1  1801004
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1801004 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1801004 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1801004 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 承担工作1  1801005
        /// </summary>
        public string UndertakeWork1 { get; set; }

        /// <summary>
        /// 承担工作1  1801005 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork1 { get; set; }

        /// <summary>
        /// 承担工作1  1801005 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork1 { get; set; }

        /// <summary>
        /// 承担工作1  1801005 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork1 { get; set; }
        /// <summary>
        /// 参编单位2  1801006
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 参编单位2  1801006 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 参编单位2  1801006 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 参编单位2  1801006 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 合作工作2  1801007
        /// </summary>
        public string UndertakeWork2 { get; set; }

        /// <summary>
        /// 合作工作2  1801007 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork2 { get; set; }

        /// <summary>
        /// 合作工作2  1801007 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork2 { get; set; }

        /// <summary>
        /// 合作工作2  1801007 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork2 { get; set; }
        /// <summary>
        /// 参编单位3  1801008
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 参编单位3  1801008 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 参编单位3  1801008 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 参编单位3  1801008 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 合作工作3  1801009
        /// </summary>
        public string UndertakeWork3 { get; set; }

        /// <summary>
        /// 合作工作3  1801009 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork3 { get; set; }

        /// <summary>
        /// 合作工作3  1801009 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork3 { get; set; }

        /// <summary>
        /// 合作工作3  1801009 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork3 { get; set; }
        /// <summary>
        /// 参编单位4  1801010
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 参编单位4  1801010 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 参编单位4  1801010 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 参编单位4  1801010 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 合作工作4  1801011
        /// </summary>
        public string UndertakeWork4 { get; set; }

        /// <summary>
        /// 合作工作4  1801011 数据类别
        /// </summary>
        public string RecordTypeUndertakeWork4 { get; set; }

        /// <summary>
        /// 合作工作4  1801011 是否必填
        /// </summary>
        public bool? IsRequiredUndertakeWork4 { get; set; }

        /// <summary>
        /// 合作工作4  1801011 是否公开
        /// </summary>
        public bool? IsPublicUndertakeWork4 { get; set; }
        /// <summary>
        /// 设计单位  1801012
        /// </summary>
        public string DesignUnit { get; set; }

        /// <summary>
        /// 设计单位  1801012 数据类别
        /// </summary>
        public string RecordTypeDesignUnit { get; set; }

        /// <summary>
        /// 设计单位  1801012 是否必填
        /// </summary>
        public bool? IsRequiredDesignUnit { get; set; }

        /// <summary>
        /// 设计单位  1801012 是否公开
        /// </summary>
        public bool? IsPublicDesignUnit { get; set; }
        /// <summary>
        /// 施工单位  1801013
        /// </summary>
        public string ConstructionUnit { get; set; }

        /// <summary>
        /// 施工单位  1801013 数据类别
        /// </summary>
        public string RecordTypeConstructionUnit { get; set; }

        /// <summary>
        /// 施工单位  1801013 是否必填
        /// </summary>
        public bool? IsRequiredConstructionUnit { get; set; }

        /// <summary>
        /// 施工单位  1801013 是否公开
        /// </summary>
        public bool? IsPublicConstructionUnit { get; set; }
        /// <summary>
        /// 工程开始时间  1801014
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 工程开始时间  1801014 数据类别
        /// </summary>
        public string RecordTypeStartDate { get; set; }

        /// <summary>
        /// 工程开始时间  1801014 是否必填
        /// </summary>
        public bool? IsRequiredStartDate { get; set; }

        /// <summary>
        /// 工程开始时间  1801014 是否公开
        /// </summary>
        public bool? IsPublicStartDate { get; set; }
        /// <summary>
        /// 工程终止时间  1801015
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 工程终止时间  1801015 数据类别
        /// </summary>
        public string RecordTypeEndDate { get; set; }

        /// <summary>
        /// 工程终止时间  1801015 是否必填
        /// </summary>
        public bool? IsRequiredEndDate { get; set; }

        /// <summary>
        /// 工程终止时间  1801015 是否公开
        /// </summary>
        public bool? IsPublicEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  1801016
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1801016 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1801016 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1801016 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 验收部门  1801017
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1801017 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1801017 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  1801017 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 申报单位通讯地址  1801018
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1801018 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1801018 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 申报单位通讯地址  1801018 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 单位资质  1801019
        /// </summary>
        public string UnitQualification { get; set; }

        /// <summary>
        /// 单位资质  1801019 数据类别
        /// </summary>
        public string RecordTypeUnitQualification { get; set; }

        /// <summary>
        /// 单位资质  1801019 是否必填
        /// </summary>
        public bool? IsRequiredUnitQualification { get; set; }

        /// <summary>
        /// 单位资质  1801019 是否公开
        /// </summary>
        public bool? IsPublicUnitQualification { get; set; }
        /// <summary>
        /// 证书编号  1801020
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1801020 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1801020 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1801020 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }
        /// <summary>
        /// 申报单位联系人  1801021
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1801021 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1801021 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 申报单位联系人  1801021 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机号码  1801022
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机号码  1801022 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机号码  1801022 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机号码  1801022 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话号码  1801023
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话号码  1801023 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话号码  1801023 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话号码  1801023 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 传真号码  1801024
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真号码  1801024 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真号码  1801024 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真号码  1801024 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 邮政编码  1801025
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1801025 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1801025 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1801025 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 电子邮箱  1801026
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1801026 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1801026 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1801026 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
    }


    /// <summary>
    /// 水系统工程项目—项目特点
    /// </summary>
    [Serializable]
    public class Template_1802 : TemplateBase
    {
        /// <summary>
        /// 项目概况  1802001
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  1802001 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  1802001 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  1802001 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 技术特色  1802002
        /// </summary>
        public string TechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  1802002 数据类别
        /// </summary>
        public string RecordTypeTechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  1802002 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalFeatures { get; set; }

        /// <summary>
        /// 技术特色  1802002 是否公开
        /// </summary>
        public bool? IsPublicTechnicalFeatures { get; set; }
        /// <summary>
        /// 技术成效与深度  1802003
        /// </summary>
        public string TechnicalEffectiveness { get; set; }

        /// <summary>
        /// 技术成效与深度  1802003 数据类别
        /// </summary>
        public string RecordTypeTechnicalEffectiveness { get; set; }

        /// <summary>
        /// 技术成效与深度  1802003 是否必填
        /// </summary>
        public bool? IsRequiredTechnicalEffectiveness { get; set; }

        /// <summary>
        /// 技术成效与深度  1802003 是否公开
        /// </summary>
        public bool? IsPublicTechnicalEffectiveness { get; set; }
        /// <summary>
        /// 综合效益  1802004
        /// </summary>
        public string ComprehensiveBenefit { get; set; }

        /// <summary>
        /// 综合效益  1802004 数据类别
        /// </summary>
        public string RecordTypeComprehensiveBenefit { get; set; }

        /// <summary>
        /// 综合效益  1802004 是否必填
        /// </summary>
        public bool? IsRequiredComprehensiveBenefit { get; set; }

        /// <summary>
        /// 综合效益  1802004 是否公开
        /// </summary>
        public bool? IsPublicComprehensiveBenefit { get; set; }
    }



    /// <summary>
    /// 水系统工程项目—建设内容
    /// </summary>
    [Serializable]
    public class Template_1803 : TemplateBase
    {
        /// <summary>
        /// 系统类别或分项内容1  1803001
        /// </summary>
        public string SystemBreakdown1 { get; set; }

        /// <summary>
        /// 系统类别或分项内容1  1803001 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown1 { get; set; }

        /// <summary>
        /// 系统类别或分项内容1  1803001 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown1 { get; set; }

        /// <summary>
        /// 系统类别或分项内容1  1803001 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown1 { get; set; }
        /// <summary>
        /// 系统类别或分项内容2  1803002
        /// </summary>
        public string SystemBreakdown2 { get; set; }

        /// <summary>
        /// 系统类别或分项内容2  1803002 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown2 { get; set; }

        /// <summary>
        /// 系统类别或分项内容2  1803002 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown2 { get; set; }

        /// <summary>
        /// 系统类别或分项内容2  1803002 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown2 { get; set; }
        /// <summary>
        /// 系统类别或分项内容3  1803003
        /// </summary>
        public string SystemBreakdown3 { get; set; }

        /// <summary>
        /// 系统类别或分项内容3  1803003 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown3 { get; set; }

        /// <summary>
        /// 系统类别或分项内容3  1803003 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown3 { get; set; }

        /// <summary>
        /// 系统类别或分项内容3  1803003 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown3 { get; set; }
        /// <summary>
        /// 系统类别或分项内容4  1803004
        /// </summary>
        public string SystemBreakdown4 { get; set; }

        /// <summary>
        /// 系统类别或分项内容4  1803004 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown4 { get; set; }

        /// <summary>
        /// 系统类别或分项内容4  1803004 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown4 { get; set; }

        /// <summary>
        /// 系统类别或分项内容4  1803004 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown4 { get; set; }
        /// <summary>
        /// 系统类别或分项内容5  1803005
        /// </summary>
        public string SystemBreakdown5 { get; set; }

        /// <summary>
        /// 系统类别或分项内容5  1803005 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown5 { get; set; }

        /// <summary>
        /// 系统类别或分项内容5  1803005 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown5 { get; set; }

        /// <summary>
        /// 系统类别或分项内容5  1803005 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown5 { get; set; }
        /// <summary>
        /// 系统类别或分项内容6  1803006
        /// </summary>
        public string SystemBreakdown6 { get; set; }

        /// <summary>
        /// 系统类别或分项内容6  1803006 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown6 { get; set; }

        /// <summary>
        /// 系统类别或分项内容6  1803006 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown6 { get; set; }

        /// <summary>
        /// 系统类别或分项内容6  1803006 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown6 { get; set; }
        /// <summary>
        /// 系统类别或分项内容7  1803007
        /// </summary>
        public string SystemBreakdown7 { get; set; }

        /// <summary>
        /// 系统类别或分项内容7  1803007 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown7 { get; set; }

        /// <summary>
        /// 系统类别或分项内容7  1803007 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown7 { get; set; }

        /// <summary>
        /// 系统类别或分项内容7  1803007 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown7 { get; set; }
        /// <summary>
        /// 系统类别或分项内容8  1803008
        /// </summary>
        public string SystemBreakdown8 { get; set; }

        /// <summary>
        /// 系统类别或分项内容8  1803008 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown8 { get; set; }

        /// <summary>
        /// 系统类别或分项内容8  1803008 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown8 { get; set; }

        /// <summary>
        /// 系统类别或分项内容8  1803008 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown8 { get; set; }
        /// <summary>
        /// 系统类别或分项内容9  1803009
        /// </summary>
        public string SystemBreakdown9 { get; set; }

        /// <summary>
        /// 系统类别或分项内容9  1803009 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown9 { get; set; }

        /// <summary>
        /// 系统类别或分项内容9  1803009 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown9 { get; set; }

        /// <summary>
        /// 系统类别或分项内容9  1803009 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown9 { get; set; }
        /// <summary>
        /// 系统类别或分项内容10  1803010
        /// </summary>
        public string SystemBreakdown10 { get; set; }

        /// <summary>
        /// 系统类别或分项内容10  1803010 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown10 { get; set; }

        /// <summary>
        /// 系统类别或分项内容10  1803010 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown10 { get; set; }

        /// <summary>
        /// 系统类别或分项内容10  1803010 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown10 { get; set; }
        /// <summary>
        /// 系统类别或分项内容11  1803011
        /// </summary>
        public string SystemBreakdown11 { get; set; }

        /// <summary>
        /// 系统类别或分项内容11  1803011 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown11 { get; set; }

        /// <summary>
        /// 系统类别或分项内容11  1803011 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown11 { get; set; }

        /// <summary>
        /// 系统类别或分项内容11  1803011 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown11 { get; set; }
        /// <summary>
        /// 系统类别或分项内容12  1803012
        /// </summary>
        public string SystemBreakdown12 { get; set; }

        /// <summary>
        /// 系统类别或分项内容12  1803012 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown12 { get; set; }

        /// <summary>
        /// 系统类别或分项内容12  1803012 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown12 { get; set; }

        /// <summary>
        /// 系统类别或分项内容12  1803012 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown12 { get; set; }
        /// <summary>
        /// 系统类别或分项内容13  1803013
        /// </summary>
        public string SystemBreakdown13 { get; set; }

        /// <summary>
        /// 系统类别或分项内容13  1803013 数据类别
        /// </summary>
        public string RecordTypeSystemBreakdown13 { get; set; }

        /// <summary>
        /// 系统类别或分项内容13  1803013 是否必填
        /// </summary>
        public bool? IsRequiredSystemBreakdown13 { get; set; }

        /// <summary>
        /// 系统类别或分项内容13  1803013 是否公开
        /// </summary>
        public bool? IsPublicSystemBreakdown13 { get; set; }
        /// <summary>
        /// 形式及设置范围1  1803014
        /// </summary>
        public string FormAndScope1 { get; set; }

        /// <summary>
        /// 形式及设置范围1  1803014 数据类别
        /// </summary>
        public string RecordTypeFormAndScope1 { get; set; }

        /// <summary>
        /// 形式及设置范围1  1803014 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope1 { get; set; }

        /// <summary>
        /// 形式及设置范围1  1803014 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope1 { get; set; }
        /// <summary>
        /// 形式及设置范围2  1803015
        /// </summary>
        public string FormAndScope2 { get; set; }

        /// <summary>
        /// 形式及设置范围2  1803015 数据类别
        /// </summary>
        public string RecordTypeFormAndScope2 { get; set; }

        /// <summary>
        /// 形式及设置范围2  1803015 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope2 { get; set; }

        /// <summary>
        /// 形式及设置范围2  1803015 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope2 { get; set; }
        /// <summary>
        /// 形式及设置范围3  1803016
        /// </summary>
        public string FormAndScope3 { get; set; }

        /// <summary>
        /// 形式及设置范围3  1803016 数据类别
        /// </summary>
        public string RecordTypeFormAndScope3 { get; set; }

        /// <summary>
        /// 形式及设置范围3  1803016 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope3 { get; set; }

        /// <summary>
        /// 形式及设置范围3  1803016 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope3 { get; set; }
        /// <summary>
        /// 形式及设置范围4  1803017
        /// </summary>
        public string FormAndScope4 { get; set; }

        /// <summary>
        /// 形式及设置范围4  1803017 数据类别
        /// </summary>
        public string RecordTypeFormAndScope4 { get; set; }

        /// <summary>
        /// 形式及设置范围4  1803017 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope4 { get; set; }

        /// <summary>
        /// 形式及设置范围4  1803017 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope4 { get; set; }
        /// <summary>
        /// 形式及设置范围5  1803018
        /// </summary>
        public string FormAndScope5 { get; set; }

        /// <summary>
        /// 形式及设置范围5  1803018 数据类别
        /// </summary>
        public string RecordTypeFormAndScope5 { get; set; }

        /// <summary>
        /// 形式及设置范围5  1803018 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope5 { get; set; }

        /// <summary>
        /// 形式及设置范围5  1803018 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope5 { get; set; }
        /// <summary>
        /// 形式及设置范围6  1803019
        /// </summary>
        public string FormAndScope6 { get; set; }

        /// <summary>
        /// 形式及设置范围6  1803019 数据类别
        /// </summary>
        public string RecordTypeFormAndScope6 { get; set; }

        /// <summary>
        /// 形式及设置范围6  1803019 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope6 { get; set; }

        /// <summary>
        /// 形式及设置范围6  1803019 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope6 { get; set; }
        /// <summary>
        /// 形式及设置范围7  1803020
        /// </summary>
        public string FormAndScope7 { get; set; }

        /// <summary>
        /// 形式及设置范围7  1803020 数据类别
        /// </summary>
        public string RecordTypeFormAndScope7 { get; set; }

        /// <summary>
        /// 形式及设置范围7  1803020 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope7 { get; set; }

        /// <summary>
        /// 形式及设置范围7  1803020 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope7 { get; set; }
        /// <summary>
        /// 形式及设置范围8  1803021
        /// </summary>
        public string FormAndScope8 { get; set; }

        /// <summary>
        /// 形式及设置范围8  1803021 数据类别
        /// </summary>
        public string RecordTypeFormAndScope8 { get; set; }

        /// <summary>
        /// 形式及设置范围8  1803021 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope8 { get; set; }

        /// <summary>
        /// 形式及设置范围8  1803021 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope8 { get; set; }
        /// <summary>
        /// 形式及设置范围9  1803022
        /// </summary>
        public string FormAndScope9 { get; set; }

        /// <summary>
        /// 形式及设置范围9  1803022 数据类别
        /// </summary>
        public string RecordTypeFormAndScope9 { get; set; }

        /// <summary>
        /// 形式及设置范围9  1803022 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope9 { get; set; }

        /// <summary>
        /// 形式及设置范围9  1803022 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope9 { get; set; }
        /// <summary>
        /// 形式及设置范围10  1803023
        /// </summary>
        public string FormAndScope10 { get; set; }

        /// <summary>
        /// 形式及设置范围10  1803023 数据类别
        /// </summary>
        public string RecordTypeFormAndScope10 { get; set; }

        /// <summary>
        /// 形式及设置范围10  1803023 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope10 { get; set; }

        /// <summary>
        /// 形式及设置范围10  1803023 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope10 { get; set; }
        /// <summary>
        /// 形式及设置范围11  1803024
        /// </summary>
        public string FormAndScope11 { get; set; }

        /// <summary>
        /// 形式及设置范围11  1803024 数据类别
        /// </summary>
        public string RecordTypeFormAndScope11 { get; set; }

        /// <summary>
        /// 形式及设置范围11  1803024 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope11 { get; set; }

        /// <summary>
        /// 形式及设置范围11  1803024 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope11 { get; set; }
        /// <summary>
        /// 形式及设置范围12  1803025
        /// </summary>
        public string FormAndScope12 { get; set; }

        /// <summary>
        /// 形式及设置范围12  1803025 数据类别
        /// </summary>
        public string RecordTypeFormAndScope12 { get; set; }

        /// <summary>
        /// 形式及设置范围12  1803025 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope12 { get; set; }

        /// <summary>
        /// 形式及设置范围12  1803025 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope12 { get; set; }
        /// <summary>
        /// 形式及设置范围13  1803026
        /// </summary>
        public string FormAndScope13 { get; set; }

        /// <summary>
        /// 形式及设置范围13  1803026 数据类别
        /// </summary>
        public string RecordTypeFormAndScope13 { get; set; }

        /// <summary>
        /// 形式及设置范围13  1803026 是否必填
        /// </summary>
        public bool? IsRequiredFormAndScope13 { get; set; }

        /// <summary>
        /// 形式及设置范围13  1803026 是否公开
        /// </summary>
        public bool? IsPublicFormAndScope13 { get; set; }
        /// <summary>
        /// 特点1  1803027
        /// </summary>
        public string ConstructionCharacteristics1 { get; set; }

        /// <summary>
        /// 特点1  1803027 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics1 { get; set; }

        /// <summary>
        /// 特点1  1803027 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics1 { get; set; }

        /// <summary>
        /// 特点1  1803027 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics1 { get; set; }
        /// <summary>
        /// 特点2  1803028
        /// </summary>
        public string ConstructionCharacteristics2 { get; set; }

        /// <summary>
        /// 特点2  1803028 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics2 { get; set; }

        /// <summary>
        /// 特点2  1803028 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics2 { get; set; }

        /// <summary>
        /// 特点2  1803028 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics2 { get; set; }
        /// <summary>
        /// 特点3  1803029
        /// </summary>
        public string ConstructionCharacteristics3 { get; set; }

        /// <summary>
        /// 特点3  1803029 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics3 { get; set; }

        /// <summary>
        /// 特点3  1803029 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics3 { get; set; }

        /// <summary>
        /// 特点3  1803029 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics3 { get; set; }
        /// <summary>
        /// 特点4  1803030
        /// </summary>
        public string ConstructionCharacteristics4 { get; set; }

        /// <summary>
        /// 特点4  1803030 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics4 { get; set; }

        /// <summary>
        /// 特点4  1803030 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics4 { get; set; }

        /// <summary>
        /// 特点4  1803030 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics4 { get; set; }
        /// <summary>
        /// 特点5  1803031
        /// </summary>
        public string ConstructionCharacteristics5 { get; set; }

        /// <summary>
        /// 特点5  1803031 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics5 { get; set; }

        /// <summary>
        /// 特点5  1803031 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics5 { get; set; }

        /// <summary>
        /// 特点5  1803031 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics5 { get; set; }
        /// <summary>
        /// 特点6  1803032
        /// </summary>
        public string ConstructionCharacteristics6 { get; set; }

        /// <summary>
        /// 特点6  1803032 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics6 { get; set; }

        /// <summary>
        /// 特点6  1803032 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics6 { get; set; }

        /// <summary>
        /// 特点6  1803032 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics6 { get; set; }
        /// <summary>
        /// 特点7  1803033
        /// </summary>
        public string ConstructionCharacteristics7 { get; set; }

        /// <summary>
        /// 特点7  1803033 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics7 { get; set; }

        /// <summary>
        /// 特点7  1803033 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics7 { get; set; }

        /// <summary>
        /// 特点7  1803033 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics7 { get; set; }
        /// <summary>
        /// 特点8  1803034
        /// </summary>
        public string ConstructionCharacteristics8 { get; set; }

        /// <summary>
        /// 特点8  1803034 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics8 { get; set; }

        /// <summary>
        /// 特点8  1803034 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics8 { get; set; }

        /// <summary>
        /// 特点8  1803034 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics8 { get; set; }
        /// <summary>
        /// 特点9  1803035
        /// </summary>
        public string ConstructionCharacteristics9 { get; set; }

        /// <summary>
        /// 特点9  1803035 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics9 { get; set; }

        /// <summary>
        /// 特点9  1803035 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics9 { get; set; }

        /// <summary>
        /// 特点9  1803035 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics9 { get; set; }
        /// <summary>
        /// 特点10  1803036
        /// </summary>
        public string ConstructionCharacteristics10 { get; set; }

        /// <summary>
        /// 特点10  1803036 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics10 { get; set; }

        /// <summary>
        /// 特点10  1803036 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics10 { get; set; }

        /// <summary>
        /// 特点10  1803036 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics10 { get; set; }
        /// <summary>
        /// 特点11  1803037
        /// </summary>
        public string ConstructionCharacteristics11 { get; set; }

        /// <summary>
        /// 特点11  1803037 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics11 { get; set; }

        /// <summary>
        /// 特点11  1803037 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics11 { get; set; }

        /// <summary>
        /// 特点11  1803037 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics11 { get; set; }
        /// <summary>
        /// 特点12  1803038
        /// </summary>
        public string ConstructionCharacteristics12 { get; set; }

        /// <summary>
        /// 特点12  1803038 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics12 { get; set; }

        /// <summary>
        /// 特点12  1803038 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics12 { get; set; }

        /// <summary>
        /// 特点12  1803038 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics12 { get; set; }
        /// <summary>
        /// 特点13  1803039
        /// </summary>
        public string ConstructionCharacteristics13 { get; set; }

        /// <summary>
        /// 特点13  1803039 数据类别
        /// </summary>
        public string RecordTypeConstructionCharacteristics13 { get; set; }

        /// <summary>
        /// 特点13  1803039 是否必填
        /// </summary>
        public bool? IsRequiredConstructionCharacteristics13 { get; set; }

        /// <summary>
        /// 特点13  1803039 是否公开
        /// </summary>
        public bool? IsPublicConstructionCharacteristics13 { get; set; }
    }


    /// <summary>
    /// 水系统工程项目—项目特点
    /// </summary>
    [Serializable]
    public class Template_1804 : TemplateBase
    {
        /// <summary>
        /// 曾获奖项  1804001
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1804001 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1804001 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1804001 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  1804002
        /// </summary>
        public string DeclarationUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1804002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1804002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1804002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnitOpinion { get; set; }
        /// <summary>
        /// 地方部门勘察设计同业协会推荐意见  1804003
        /// </summary>
        public string Recommendation { get; set; }

        /// <summary>
        /// 地方部门勘察设计同业协会推荐意见  1804003 数据类别
        /// </summary>
        public string RecordTypeRecommendation { get; set; }

        /// <summary>
        /// 地方部门勘察设计同业协会推荐意见  1804003 是否必填
        /// </summary>
        public bool? IsRequiredRecommendation { get; set; }

        /// <summary>
        /// 地方部门勘察设计同业协会推荐意见  1804003 是否公开
        /// </summary>
        public bool? IsPublicRecommendation { get; set; }
    }


    /// <summary>
    /// 水系统工程项目—使用单位反馈意见
    /// </summary>
    [Serializable]
    public class Template_1805 : TemplateBase
    {
        /// <summary>
        /// 使用单位  1805001
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  1805001 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  1805001 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  1805001 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 使用单位通讯地址  1805002
        /// </summary>
        public string UseUnitAddress { get; set; }

        /// <summary>
        /// 使用单位通讯地址  1805002 数据类别
        /// </summary>
        public string RecordTypeUseUnitAddress { get; set; }

        /// <summary>
        /// 使用单位通讯地址  1805002 是否必填
        /// </summary>
        public bool? IsRequiredUseUnitAddress { get; set; }

        /// <summary>
        /// 使用单位通讯地址  1805002 是否公开
        /// </summary>
        public bool? IsPublicUseUnitAddress { get; set; }
        /// <summary>
        /// 开始使用时间  1805003
        /// </summary>
        public string UseStartDate { get; set; }

        /// <summary>
        /// 开始使用时间  1805003 数据类别
        /// </summary>
        public string RecordTypeUseStartDate { get; set; }

        /// <summary>
        /// 开始使用时间  1805003 是否必填
        /// </summary>
        public bool? IsRequiredUseStartDate { get; set; }

        /// <summary>
        /// 开始使用时间  1805003 是否公开
        /// </summary>
        public bool? IsPublicUseStartDate { get; set; }
        /// <summary>
        /// 使用单位反馈意见  1805004
        /// </summary>
        public string UsingUnitFeedback { get; set; }

        /// <summary>
        /// 使用单位反馈意见  1805004 数据类别
        /// </summary>
        public string RecordTypeUsingUnitFeedback { get; set; }

        /// <summary>
        /// 使用单位反馈意见  1805004 是否必填
        /// </summary>
        public bool? IsRequiredUsingUnitFeedback { get; set; }

        /// <summary>
        /// 使用单位反馈意见  1805004 是否公开
        /// </summary>
        public bool? IsPublicUsingUnitFeedback { get; set; }
    }

    /// <summary>
    /// 水系统工程项目—施工单位反馈意见
    /// </summary>
    [Serializable]
    public class Template_1806 : TemplateBase
    {
        /// <summary>
        /// 施工单位  1806001
        /// </summary>
        public string NewConstructionUnit { get; set; }

        /// <summary>
        /// 施工单位  1806001 数据类别
        /// </summary>
        public string RecordTypeNewConstructionUnit { get; set; }

        /// <summary>
        /// 施工单位  1806001 是否必填
        /// </summary>
        public bool? IsRequiredNewConstructionUnit { get; set; }

        /// <summary>
        /// 施工单位  1806001 是否公开
        /// </summary>
        public bool? IsPublicNewConstructionUnit { get; set; }
        /// <summary>
        /// 施工单位通讯地址  1806002
        /// </summary>
        public string ConstructionUnitAddress { get; set; }

        /// <summary>
        /// 施工单位通讯地址  1806002 数据类别
        /// </summary>
        public string RecordTypeConstructionUnitAddress { get; set; }

        /// <summary>
        /// 施工单位通讯地址  1806002 是否必填
        /// </summary>
        public bool? IsRequiredConstructionUnitAddress { get; set; }

        /// <summary>
        /// 施工单位通讯地址  1806002 是否公开
        /// </summary>
        public bool? IsPublicConstructionUnitAddress { get; set; }
        /// <summary>
        /// 施工开始时间  1806003
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 施工开始时间  1806003 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 施工开始时间  1806003 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 施工开始时间  1806003 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 施工停止时间  1806004
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 施工停止时间  1806004 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 施工停止时间  1806004 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 施工停止时间  1806004 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 使用单位反馈意见  1806005
        /// </summary>
        public string ConstructionUnitFeedback { get; set; }

        /// <summary>
        /// 使用单位反馈意见  1806005 数据类别
        /// </summary>
        public string RecordTypeConstructionUnitFeedback { get; set; }

        /// <summary>
        /// 使用单位反馈意见  1806005 是否必填
        /// </summary>
        public bool? IsRequiredConstructionUnitFeedback { get; set; }

        /// <summary>
        /// 使用单位反馈意见  1806005 是否公开
        /// </summary>
        public bool? IsPublicConstructionUnitFeedback { get; set; }
    }
}
