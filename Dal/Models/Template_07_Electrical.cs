using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 建筑电气专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_07_Electrical : TemplateBase
    {
        /// <summary>
        /// 建筑电气专项奖申报模板—基础信息
        /// </summary>
        public Template_0701 Part_01 { get; set; }

        /// <summary>
        /// 建筑电气专项奖申报模板—技术申报内容
        /// </summary>
        public Template_0702 Part_02 { get; set; }
    }
    /// <summary>
    /// 建筑电气专项奖申报模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_0701 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  0701001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0701001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0701001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0701001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  0701002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0701002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0701002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0701002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  0701003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0701003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0701003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0701003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0701004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0701004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0701004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0701004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0701005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0701005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0701005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0701005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0701006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0701006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0701006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0701006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0701007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0701007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0701007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0701007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0701008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0701008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0701008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0701008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0701009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0701009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0701009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0701009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0701010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0701010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0701010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0701010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0701011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0701011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0701011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0701011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0701012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0701012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0701012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0701012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0701013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0701013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0701013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0701013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0701014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0701014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0701014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0701014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0701015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0701015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0701015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0701015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0701016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0701016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0701016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0701016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0701017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0701017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0701017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0701017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0701018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0701018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0701018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0701018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0701019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0701019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0701019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0701019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0701020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0701020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0701020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0701020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0701021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0701021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0701021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0701021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0701022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0701022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0701022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0701022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  0701023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0701023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0701023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0701023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0701024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0701024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0701024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0701024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  0701025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  0701025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0701025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0701025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  0701026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0701026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0701026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0701026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地上  0701027
        /// </summary>
        public string UseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0701027 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0701027 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0701027 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Overground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  0701028
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0701028 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0701028 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0701028 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  0701029
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  0701029 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  0701029 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  0701029 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  0701030
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0701030 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0701030 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0701030 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总建筑面积  0701031
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0701031 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0701031 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0701031 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 总用地面积  0701032
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0701032 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0701032 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0701032 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 建筑高度  0701033
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0701033 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0701033 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0701033 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑层数  0701034
        /// </summary>
        public string LayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0701034 数据类别
        /// </summary>
        public string RecordTypeLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0701034 是否必填
        /// </summary>
        public bool? IsRequiredLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0701034 是否公开
        /// </summary>
        public bool? IsPublicLayerCount { get; set; }
        /// <summary>
        /// 设计类别  0701035
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0701035 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0701035 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0701035 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0701036
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0701036 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0701036 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0701036 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0701037
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0701037 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0701037 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0701037 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  0701038
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0701038 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0701038 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0701038 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  0701039
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0701039 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0701039 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0701039 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0701040
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0701040 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0701040 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0701040 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  0701041
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0701041 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0701041 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0701041 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  0701042
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0701042 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0701042 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0701042 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  0701043
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0701043 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0701043 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0701043 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }

        /// <summary>
        /// 专业类别  0701044
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0701044 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0701044 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0701044 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 单位资质  0701045
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0701045 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0701045 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0701045 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  0701046
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0701046 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0701046 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0701046 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

    }


    /// <summary>
    /// 建筑电气专项奖申报模板—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_0702 : TemplateBase
    {
        /// <summary>
        /// 项目概况  0702001
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0702001 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0702001 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0702001 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 技术特点  0702002
        /// </summary>
        public string TechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  0702002 数据类别
        /// </summary>
        public string RecordTypeTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  0702002 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  0702002 是否公开
        /// </summary>
        public bool? IsPublicTechnologyFeature { get; set; }
        /// <summary>
        /// 电力总用电负荷  0702003
        /// </summary>
        public string TotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0702003 数据类别
        /// </summary>
        public string RecordTypeTotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0702003 是否必填
        /// </summary>
        public bool? IsRequiredTotalElectricityload { get; set; }

        /// <summary>
        /// 电力总用电负荷  0702003 是否公开
        /// </summary>
        public bool? IsPublicTotalElectricityload { get; set; }
        /// <summary>
        /// 变压器装机密度  0702004
        /// </summary>
        public string TransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0702004 数据类别
        /// </summary>
        public string RecordTypeTransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0702004 是否必填
        /// </summary>
        public bool? IsRequiredTransformerDensity { get; set; }

        /// <summary>
        /// 变压器装机密度  0702004 是否公开
        /// </summary>
        public bool? IsPublicTransformerDensity { get; set; }
        /// <summary>
        /// 备用电源装机密度  0702005
        /// </summary>
        public string StandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0702005 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0702005 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensity { get; set; }

        /// <summary>
        /// 备用电源装机密度  0702005 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensity { get; set; }
        /// <summary>
        /// 备用电源装机密度单位  0702006
        /// </summary>
        public string StandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0702006 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0702006 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensityUnit { get; set; }

        /// <summary>
        /// 备用电源装机密度单位  0702006 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensityUnit { get; set; }
        /// <summary>
        /// 供配电系统特点  0702007
        /// </summary>
        public string PowerSupplySystemTrait { get; set; }

        /// <summary>
        /// 供配电系统特点  0702007 数据类别
        /// </summary>
        public string RecordTypePowerSupplySystemTrait { get; set; }

        /// <summary>
        /// 供配电系统特点  0702007 是否必填
        /// </summary>
        public bool? IsRequiredPowerSupplySystemTrait { get; set; }

        /// <summary>
        /// 供配电系统特点  0702007 是否公开
        /// </summary>
        public bool? IsPublicPowerSupplySystemTrait { get; set; }
        /// <summary>
        /// 配变电所_规模  0702008
        /// </summary>
        public string Substation_Scale { get; set; }

        /// <summary>
        /// 配变电所_规模  0702008 数据类别
        /// </summary>
        public string RecordTypeSubstation_Scale { get; set; }

        /// <summary>
        /// 配变电所_规模  0702008 是否必填
        /// </summary>
        public bool? IsRequiredSubstation_Scale { get; set; }

        /// <summary>
        /// 配变电所_规模  0702008 是否公开
        /// </summary>
        public bool? IsPublicSubstation_Scale { get; set; }
        /// <summary>
        /// 配变电所_特点  0702009
        /// </summary>
        public string Substation_Trait { get; set; }

        /// <summary>
        /// 配变电所_特点  0702009 数据类别
        /// </summary>
        public string RecordTypeSubstation_Trait { get; set; }

        /// <summary>
        /// 配变电所_特点  0702009 是否必填
        /// </summary>
        public bool? IsRequiredSubstation_Trait { get; set; }

        /// <summary>
        /// 配变电所_特点  0702009 是否公开
        /// </summary>
        public bool? IsPublicSubstation_Trait { get; set; }
        /// <summary>
        /// 自备应急电源_规模  0702010
        /// </summary>
        public string EmergencyPowerSupply_Scale { get; set; }

        /// <summary>
        /// 自备应急电源_规模  0702010 数据类别
        /// </summary>
        public string RecordTypeEmergencyPowerSupply_Scale { get; set; }

        /// <summary>
        /// 自备应急电源_规模  0702010 是否必填
        /// </summary>
        public bool? IsRequiredEmergencyPowerSupply_Scale { get; set; }

        /// <summary>
        /// 自备应急电源_规模  0702010 是否公开
        /// </summary>
        public bool? IsPublicEmergencyPowerSupply_Scale { get; set; }
        /// <summary>
        /// 自备应急电源_特点  0702011
        /// </summary>
        public string EmergencyPowerSupply_Trait { get; set; }

        /// <summary>
        /// 自备应急电源_特点  0702011 数据类别
        /// </summary>
        public string RecordTypeEmergencyPowerSupply_Trait { get; set; }

        /// <summary>
        /// 自备应急电源_特点  0702011 是否必填
        /// </summary>
        public bool? IsRequiredEmergencyPowerSupply_Trait { get; set; }

        /// <summary>
        /// 自备应急电源_特点  0702011 是否公开
        /// </summary>
        public bool? IsPublicEmergencyPowerSupply_Trait { get; set; }
        /// <summary>
        /// 低压配电系统_规模  0702012
        /// </summary>
        public string LowVoltageDistributionSystem_Scale { get; set; }

        /// <summary>
        /// 低压配电系统_规模  0702012 数据类别
        /// </summary>
        public string RecordTypeLowVoltageDistributionSystem_Scale { get; set; }

        /// <summary>
        /// 低压配电系统_规模  0702012 是否必填
        /// </summary>
        public bool? IsRequiredLowVoltageDistributionSystem_Scale { get; set; }

        /// <summary>
        /// 低压配电系统_规模  0702012 是否公开
        /// </summary>
        public bool? IsPublicLowVoltageDistributionSystem_Scale { get; set; }
        /// <summary>
        /// 低压配电系统_特点  0702013
        /// </summary>
        public string LowVoltageDistributionSystem_Trait { get; set; }

        /// <summary>
        /// 低压配电系统_特点  0702013 数据类别
        /// </summary>
        public string RecordTypeLowVoltageDistributionSystem_Trait { get; set; }

        /// <summary>
        /// 低压配电系统_特点  0702013 是否必填
        /// </summary>
        public bool? IsRequiredLowVoltageDistributionSystem_Trait { get; set; }

        /// <summary>
        /// 低压配电系统_特点  0702013 是否公开
        /// </summary>
        public bool? IsPublicLowVoltageDistributionSystem_Trait { get; set; }
        /// <summary>
        /// 配电线路布线系统_规模  0702014
        /// </summary>
        public string WiringSystem_Scale { get; set; }

        /// <summary>
        /// 配电线路布线系统_规模  0702014 数据类别
        /// </summary>
        public string RecordTypeWiringSystem_Scale { get; set; }

        /// <summary>
        /// 配电线路布线系统_规模  0702014 是否必填
        /// </summary>
        public bool? IsRequiredWiringSystem_Scale { get; set; }

        /// <summary>
        /// 配电线路布线系统_规模  0702014 是否公开
        /// </summary>
        public bool? IsPublicWiringSystem_Scale { get; set; }
        /// <summary>
        /// 配电线路布线系统_特点  0702015
        /// </summary>
        public string WiringSystem_Trait { get; set; }

        /// <summary>
        /// 配电线路布线系统_特点  0702015 数据类别
        /// </summary>
        public string RecordTypeWiringSystem_Trait { get; set; }

        /// <summary>
        /// 配电线路布线系统_特点  0702015 是否必填
        /// </summary>
        public bool? IsRequiredWiringSystem_Trait { get; set; }

        /// <summary>
        /// 配电线路布线系统_特点  0702015 是否公开
        /// </summary>
        public bool? IsPublicWiringSystem_Trait { get; set; }
        /// <summary>
        /// 电气照明系统_规模  0702016
        /// </summary>
        public string Lighting_Scale { get; set; }

        /// <summary>
        /// 电气照明系统_规模  0702016 数据类别
        /// </summary>
        public string RecordTypeLighting_Scale { get; set; }

        /// <summary>
        /// 电气照明系统_规模  0702016 是否必填
        /// </summary>
        public bool? IsRequiredLighting_Scale { get; set; }

        /// <summary>
        /// 电气照明系统_规模  0702016 是否公开
        /// </summary>
        public bool? IsPublicLighting_Scale { get; set; }
        /// <summary>
        /// 电气照明系统_特点  0702017
        /// </summary>
        public string Lighting_Trait { get; set; }

        /// <summary>
        /// 电气照明系统_特点  0702017 数据类别
        /// </summary>
        public string RecordTypeLighting_Trait { get; set; }

        /// <summary>
        /// 电气照明系统_特点  0702017 是否必填
        /// </summary>
        public bool? IsRequiredLighting_Trait { get; set; }

        /// <summary>
        /// 电气照明系统_特点  0702017 是否公开
        /// </summary>
        public bool? IsPublicLighting_Trait { get; set; }
        /// <summary>
        /// 建筑物防雷及接地系统_规模  0702018
        /// </summary>
        public string Grounding_Scale { get; set; }

        /// <summary>
        /// 建筑物防雷及接地系统_规模  0702018 数据类别
        /// </summary>
        public string RecordTypeGrounding_Scale { get; set; }

        /// <summary>
        /// 建筑物防雷及接地系统_规模  0702018 是否必填
        /// </summary>
        public bool? IsRequiredGrounding_Scale { get; set; }

        /// <summary>
        /// 建筑物防雷及接地系统_规模  0702018 是否公开
        /// </summary>
        public bool? IsPublicGrounding_Scale { get; set; }
        /// <summary>
        /// 建筑物防雷及接地系统_特点  0702019
        /// </summary>
        public string Grounding_Trait { get; set; }

        /// <summary>
        /// 建筑物防雷及接地系统_特点  0702019 数据类别
        /// </summary>
        public string RecordTypeGrounding_Trait { get; set; }

        /// <summary>
        /// 建筑物防雷及接地系统_特点  0702019 是否必填
        /// </summary>
        public bool? IsRequiredGrounding_Trait { get; set; }

        /// <summary>
        /// 建筑物防雷及接地系统_特点  0702019 是否公开
        /// </summary>
        public bool? IsPublicGrounding_Trait { get; set; }
        /// <summary>
        /// 电气消防系统_规模  0702020
        /// </summary>
        public string FireFightingSystem_Scale { get; set; }

        /// <summary>
        /// 电气消防系统_规模  0702020 数据类别
        /// </summary>
        public string RecordTypeFireFightingSystem_Scale { get; set; }

        /// <summary>
        /// 电气消防系统_规模  0702020 是否必填
        /// </summary>
        public bool? IsRequiredFireFightingSystem_Scale { get; set; }

        /// <summary>
        /// 电气消防系统_规模  0702020 是否公开
        /// </summary>
        public bool? IsPublicFireFightingSystem_Scale { get; set; }
        /// <summary>
        /// 电气消防系统_特点  0702021
        /// </summary>
        public string FireFightingSystem_Trait { get; set; }

        /// <summary>
        /// 电气消防系统_特点  0702021 数据类别
        /// </summary>
        public string RecordTypeFireFightingSystem_Trait { get; set; }

        /// <summary>
        /// 电气消防系统_特点  0702021 是否必填
        /// </summary>
        public bool? IsRequiredFireFightingSystem_Trait { get; set; }

        /// <summary>
        /// 电气消防系统_特点  0702021 是否公开
        /// </summary>
        public bool? IsPublicFireFightingSystem_Trait { get; set; }
        /// <summary>
        /// 其他相关电气系统_规模  0702022
        /// </summary>
        public string OtherElectricalSystems_Scale { get; set; }

        /// <summary>
        /// 其他相关电气系统_规模  0702022 数据类别
        /// </summary>
        public string RecordTypeOtherElectricalSystems_Scale { get; set; }

        /// <summary>
        /// 其他相关电气系统_规模  0702022 是否必填
        /// </summary>
        public bool? IsRequiredOtherElectricalSystems_Scale { get; set; }

        /// <summary>
        /// 其他相关电气系统_规模  0702022 是否公开
        /// </summary>
        public bool? IsPublicOtherElectricalSystems_Scale { get; set; }
        /// <summary>
        /// 其他相关电气系统_特点  0702023
        /// </summary>
        public string OtherElectricalSystems_Trait { get; set; }

        /// <summary>
        /// 其他相关电气系统_特点  0702023 数据类别
        /// </summary>
        public string RecordTypeOtherElectricalSystems_Trait { get; set; }

        /// <summary>
        /// 其他相关电气系统_特点  0702023 是否必填
        /// </summary>
        public bool? IsRequiredOtherElectricalSystems_Trait { get; set; }

        /// <summary>
        /// 其他相关电气系统_特点  0702023 是否公开
        /// </summary>
        public bool? IsPublicOtherElectricalSystems_Trait { get; set; }
        /// <summary>
        /// 综合效益  0702024
        /// </summary>
        public string ComprehensiveBenefit { get; set; }

        /// <summary>
        /// 综合效益  0702024 数据类别
        /// </summary>
        public string RecordTypeComprehensiveBenefit { get; set; }

        /// <summary>
        /// 综合效益  0702024 是否必填
        /// </summary>
        public bool? IsRequiredComprehensiveBenefit { get; set; }

        /// <summary>
        /// 综合效益  0702024 是否公开
        /// </summary>
        public bool? IsPublicComprehensiveBenefit { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0702025
        /// </summary>
        public string StandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0702025 数据类别
        /// </summary>
        public string RecordTypeStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0702025 是否必填
        /// </summary>
        public bool? IsRequiredStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 备用电源装机密度KW  0702025 是否公开
        /// </summary>
        public bool? IsPublicStandbyElectricityDensityKW { get; set; }

        /// <summary>
        /// 供配电系统_规模  0702026
        /// </summary>
        public string PowerSupplySystemTrait_Scale { get; set; }

        /// <summary>
        /// 供配电系统_规模  0702026 数据类别
        /// </summary>
        public string RecordTypePowerSupplySystemTrait_Scale { get; set; }

        /// <summary>
        /// 供配电系统_规模  0702026 是否必填
        /// </summary>
        public bool? IsRequiredPowerSupplySystemTrait_Scale { get; set; }

        /// <summary>
        /// 供配电系统_规模  0702026 是否公开
        /// </summary>
        public bool? IsPublicPowerSupplySystemTrait_Scale { get; set; }
        /// <summary>
        /// 曾获奖项  0702027
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0702027 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0702027 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0702027 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  0702028
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0702028 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0702028 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0702028 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0702029
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0702029 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0702029 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0702029 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
