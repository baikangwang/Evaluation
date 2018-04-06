using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 建筑智能化专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_09_IntelligentBuilding : TemplateBase
    {
        /// <summary>
        /// 建筑智能化专项奖—基础信息
        /// </summary>
        public Template_0901 Part_01 { get; set; }

        /// <summary>
        /// 建筑环境与设备专项奖—技术申报内容
        /// </summary>
        public Template_0902 Part_02 { get; set; }
    }

    /// <summary>
    /// 建筑智能化专项奖—基础信息
    /// </summary>
    [Serializable]
    public class Template_0901 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  0901001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0901001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0901001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0901001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  0901002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0901002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0901002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0901002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  0901003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0901003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0901003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0901003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0901004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0901004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0901004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0901004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0901005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0901005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0901005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0901005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0901006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0901006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0901006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0901006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0901007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0901007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0901007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0901007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0901008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0901008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0901008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0901008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0901009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0901009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0901009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0901009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0901010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0901010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0901010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0901010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0901011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0901011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0901011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0901011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0901012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0901012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0901012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0901012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0901013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0901013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0901013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0901013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0901014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0901014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0901014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0901014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0901015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0901015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0901015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0901015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0901016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0901016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0901016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0901016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0901017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0901017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0901017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0901017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0901018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0901018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0901018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0901018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0901019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0901019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0901019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0901019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0901020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0901020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0901020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0901020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0901021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0901021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0901021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0901021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0901022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0901022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0901022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0901022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  0901023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0901023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0901023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0901023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0901024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0901024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0901024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0901024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  0901025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  0901025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0901025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0901025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  0901026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0901026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0901026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0901026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地上  0901027
        /// </summary>
        public string UseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0901027 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0901027 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0901027 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Overground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  0901028
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0901028 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0901028 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0901028 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  0901029
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  0901029 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  0901029 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  0901029 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  0901030
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0901030 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0901030 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0901030 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总建筑面积  0901031
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0901031 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0901031 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0901031 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 总用地面积  0901032
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0901032 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0901032 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0901032 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 建筑高度  0901033
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0901033 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0901033 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0901033 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑层数  0901034
        /// </summary>
        public string LayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0901034 数据类别
        /// </summary>
        public string RecordTypeLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0901034 是否必填
        /// </summary>
        public bool? IsRequiredLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0901034 是否公开
        /// </summary>
        public bool? IsPublicLayerCount { get; set; }
        /// <summary>
        /// 设计类别  0901035
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0901035 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0901035 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0901035 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0901036
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0901036 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0901036 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0901036 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0901037
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0901037 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0901037 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0901037 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  0901038
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0901038 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0901038 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0901038 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  0901039
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0901039 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0901039 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0901039 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0901040
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0901040 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0901040 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0901040 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  0901041
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0901041 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0901041 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0901041 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  0901042
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0901042 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0901042 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0901042 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  0901043
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0901043 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0901043 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0901043 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }

        /// <summary>
        /// 专业类别  0901044
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0901044 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0901044 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0901044 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 单位资质  0901045
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0901045 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0901045 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0901045 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  0901046
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0901046 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0901046 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0901046 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

        /// <summary>
        /// 申报材料目录  0901047
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0901047 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0901047 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0901047 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }
    }


    /// <summary>
    /// 建筑环境与设备专项奖—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_0902 : TemplateBase
    {
        /// <summary>
        /// 项目概况  0902001
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0902001 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0902001 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0902001 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 技术特点  0902002
        /// </summary>
        public string TechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  0902002 数据类别
        /// </summary>
        public string RecordTypeTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  0902002 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  0902002 是否公开
        /// </summary>
        public bool? IsPublicTechnologyFeature { get; set; }
        /// <summary>
        /// 综合效益  0902003
        /// </summary>
        public string Benefit { get; set; }

        /// <summary>
        /// 综合效益  0902003 数据类别
        /// </summary>
        public string RecordTypeBenefit { get; set; }

        /// <summary>
        /// 综合效益  0902003 是否必填
        /// </summary>
        public bool? IsRequiredBenefit { get; set; }

        /// <summary>
        /// 综合效益  0902003 是否公开
        /// </summary>
        public bool? IsPublicBenefit { get; set; }
        /// <summary>
        /// 综合布线系统_规模  0902004
        /// </summary>
        public string PDS_Scale { get; set; }

        /// <summary>
        /// 综合布线系统_规模  0902004 数据类别
        /// </summary>
        public string RecordTypePDS_Scale { get; set; }

        /// <summary>
        /// 综合布线系统_规模  0902004 是否必填
        /// </summary>
        public bool? IsRequiredPDS_Scale { get; set; }

        /// <summary>
        /// 综合布线系统_规模  0902004 是否公开
        /// </summary>
        public bool? IsPublicPDS_Scale { get; set; }
        /// <summary>
        /// 综合布线系统_特点  0902005
        /// </summary>
        public string PDS_Feature { get; set; }

        /// <summary>
        /// 综合布线系统_特点  0902005 数据类别
        /// </summary>
        public string RecordTypePDS_Feature { get; set; }

        /// <summary>
        /// 综合布线系统_特点  0902005 是否必填
        /// </summary>
        public bool? IsRequiredPDS_Feature { get; set; }

        /// <summary>
        /// 综合布线系统_特点  0902005 是否公开
        /// </summary>
        public bool? IsPublicPDS_Feature { get; set; }
        /// <summary>
        /// 通信网络系统_规模  0902006
        /// </summary>
        public string Network_Scale { get; set; }

        /// <summary>
        /// 通信网络系统_规模  0902006 数据类别
        /// </summary>
        public string RecordTypeNetwork_Scale { get; set; }

        /// <summary>
        /// 通信网络系统_规模  0902006 是否必填
        /// </summary>
        public bool? IsRequiredNetwork_Scale { get; set; }

        /// <summary>
        /// 通信网络系统_规模  0902006 是否公开
        /// </summary>
        public bool? IsPublicNetwork_Scale { get; set; }
        /// <summary>
        /// 通信网络系统_特点  0902007
        /// </summary>
        public string Network_Feature { get; set; }

        /// <summary>
        /// 通信网络系统_特点  0902007 数据类别
        /// </summary>
        public string RecordTypeNetwork_Feature { get; set; }

        /// <summary>
        /// 通信网络系统_特点  0902007 是否必填
        /// </summary>
        public bool? IsRequiredNetwork_Feature { get; set; }

        /// <summary>
        /// 通信网络系统_特点  0902007 是否公开
        /// </summary>
        public bool? IsPublicNetwork_Feature { get; set; }
        /// <summary>
        /// 建筑设备监控系统_规模  0902008
        /// </summary>
        public string Monitoring_Scale { get; set; }

        /// <summary>
        /// 建筑设备监控系统_规模  0902008 数据类别
        /// </summary>
        public string RecordTypeMonitoring_Scale { get; set; }

        /// <summary>
        /// 建筑设备监控系统_规模  0902008 是否必填
        /// </summary>
        public bool? IsRequiredMonitoring_Scale { get; set; }

        /// <summary>
        /// 建筑设备监控系统_规模  0902008 是否公开
        /// </summary>
        public bool? IsPublicMonitoring_Scale { get; set; }
        /// <summary>
        /// 建筑设备监控系统_特点  0902009
        /// </summary>
        public string Monitoring_Feature { get; set; }

        /// <summary>
        /// 建筑设备监控系统_特点  0902009 数据类别
        /// </summary>
        public string RecordTypeMonitoring_Feature { get; set; }

        /// <summary>
        /// 建筑设备监控系统_特点  0902009 是否必填
        /// </summary>
        public bool? IsRequiredMonitoring_Feature { get; set; }

        /// <summary>
        /// 建筑设备监控系统_特点  0902009 是否公开
        /// </summary>
        public bool? IsPublicMonitoring_Feature { get; set; }
        /// <summary>
        /// 火灾自动报警系统_规模  0902010
        /// </summary>
        public string Alarm_Scale { get; set; }

        /// <summary>
        /// 火灾自动报警系统_规模  0902010 数据类别
        /// </summary>
        public string RecordTypeAlarm_Scale { get; set; }

        /// <summary>
        /// 火灾自动报警系统_规模  0902010 是否必填
        /// </summary>
        public bool? IsRequiredAlarm_Scale { get; set; }

        /// <summary>
        /// 火灾自动报警系统_规模  0902010 是否公开
        /// </summary>
        public bool? IsPublicAlarm_Scale { get; set; }
        /// <summary>
        /// 火灾自动报警系统_特点  0902011
        /// </summary>
        public string Alarm_Feature { get; set; }

        /// <summary>
        /// 火灾自动报警系统_特点  0902011 数据类别
        /// </summary>
        public string RecordTypeAlarm_Feature { get; set; }

        /// <summary>
        /// 火灾自动报警系统_特点  0902011 是否必填
        /// </summary>
        public bool? IsRequiredAlarm_Feature { get; set; }

        /// <summary>
        /// 火灾自动报警系统_特点  0902011 是否公开
        /// </summary>
        public bool? IsPublicAlarm_Feature { get; set; }
        /// <summary>
        /// 安全防范系统_规模  0902012
        /// </summary>
        public string Security_Scale { get; set; }

        /// <summary>
        /// 安全防范系统_规模  0902012 数据类别
        /// </summary>
        public string RecordTypeSecurity_Scale { get; set; }

        /// <summary>
        /// 安全防范系统_规模  0902012 是否必填
        /// </summary>
        public bool? IsRequiredSecurity_Scale { get; set; }

        /// <summary>
        /// 安全防范系统_规模  0902012 是否公开
        /// </summary>
        public bool? IsPublicSecurity_Scale { get; set; }
        /// <summary>
        /// 安全防范系统_特点  0902013
        /// </summary>
        public string Security_Feature { get; set; }

        /// <summary>
        /// 安全防范系统_特点  0902013 数据类别
        /// </summary>
        public string RecordTypeSecurity_Feature { get; set; }

        /// <summary>
        /// 安全防范系统_特点  0902013 是否必填
        /// </summary>
        public bool? IsRequiredSecurity_Feature { get; set; }

        /// <summary>
        /// 安全防范系统_特点  0902013 是否公开
        /// </summary>
        public bool? IsPublicSecurity_Feature { get; set; }
        /// <summary>
        /// 电子会议系统_规模  0902014
        /// </summary>
        public string Meeting_Scale { get; set; }

        /// <summary>
        /// 电子会议系统_规模  0902014 数据类别
        /// </summary>
        public string RecordTypeMeeting_Scale { get; set; }

        /// <summary>
        /// 电子会议系统_规模  0902014 是否必填
        /// </summary>
        public bool? IsRequiredMeeting_Scale { get; set; }

        /// <summary>
        /// 电子会议系统_规模  0902014 是否公开
        /// </summary>
        public bool? IsPublicMeeting_Scale { get; set; }
        /// <summary>
        /// 电子会议系统_特点  0902015
        /// </summary>
        public string Meeting_Feature { get; set; }

        /// <summary>
        /// 电子会议系统_特点  0902015 数据类别
        /// </summary>
        public string RecordTypeMeeting_Feature { get; set; }

        /// <summary>
        /// 电子会议系统_特点  0902015 是否必填
        /// </summary>
        public bool? IsRequiredMeeting_Feature { get; set; }

        /// <summary>
        /// 电子会议系统_特点  0902015 是否公开
        /// </summary>
        public bool? IsPublicMeeting_Feature { get; set; }
        /// <summary>
        /// 背景音乐及广播系统_规模  0902016
        /// </summary>
        public string Radio_Scale { get; set; }

        /// <summary>
        /// 背景音乐及广播系统_规模  0902016 数据类别
        /// </summary>
        public string RecordTypeRadio_Scale { get; set; }

        /// <summary>
        /// 背景音乐及广播系统_规模  0902016 是否必填
        /// </summary>
        public bool? IsRequiredRadio_Scale { get; set; }

        /// <summary>
        /// 背景音乐及广播系统_规模  0902016 是否公开
        /// </summary>
        public bool? IsPublicRadio_Scale { get; set; }
        /// <summary>
        /// 背景音乐及广播系统_特点  0902017
        /// </summary>
        public string Radio_Feature { get; set; }

        /// <summary>
        /// 背景音乐及广播系统_特点  0902017 数据类别
        /// </summary>
        public string RecordTypeRadio_Feature { get; set; }

        /// <summary>
        /// 背景音乐及广播系统_特点  0902017 是否必填
        /// </summary>
        public bool? IsRequiredRadio_Feature { get; set; }

        /// <summary>
        /// 背景音乐及广播系统_特点  0902017 是否公开
        /// </summary>
        public bool? IsPublicRadio_Feature { get; set; }
        /// <summary>
        /// 集成管理系统_规模  0902018
        /// </summary>
        public string Integration_Scale { get; set; }

        /// <summary>
        /// 集成管理系统_规模  0902018 数据类别
        /// </summary>
        public string RecordTypeIntegration_Scale { get; set; }

        /// <summary>
        /// 集成管理系统_规模  0902018 是否必填
        /// </summary>
        public bool? IsRequiredIntegration_Scale { get; set; }

        /// <summary>
        /// 集成管理系统_规模  0902018 是否公开
        /// </summary>
        public bool? IsPublicIntegration_Scale { get; set; }
        /// <summary>
        /// 集成管理系统_特点  0902019
        /// </summary>
        public string Integration_Feature { get; set; }

        /// <summary>
        /// 集成管理系统_特点  0902019 数据类别
        /// </summary>
        public string RecordTypeIntegration_Feature { get; set; }

        /// <summary>
        /// 集成管理系统_特点  0902019 是否必填
        /// </summary>
        public bool? IsRequiredIntegration_Feature { get; set; }

        /// <summary>
        /// 集成管理系统_特点  0902019 是否公开
        /// </summary>
        public bool? IsPublicIntegration_Feature { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_规模  0902020
        /// </summary>
        public string IndoorCoverage_Scale { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_规模  0902020 数据类别
        /// </summary>
        public string RecordTypeIndoorCoverage_Scale { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_规模  0902020 是否必填
        /// </summary>
        public bool? IsRequiredIndoorCoverage_Scale { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_规模  0902020 是否公开
        /// </summary>
        public bool? IsPublicIndoorCoverage_Scale { get; set; }
        /// <summary>
        /// 移动通信室内信号覆盖系统_特点  0902021
        /// </summary>
        public string IndoorCoverage_Feature { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_特点  0902021 数据类别
        /// </summary>
        public string RecordTypeIndoorCoverage_Feature { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_特点  0902021 是否必填
        /// </summary>
        public bool? IsRequiredIndoorCoverage_Feature { get; set; }

        /// <summary>
        /// 移动通信室内信号覆盖系统_特点  0902021 是否公开
        /// </summary>
        public bool? IsPublicIndoorCoverage_Feature { get; set; }
        /// <summary>
        /// 卫星电视及有线电视系统_规模  0902022
        /// </summary>
        public string SatelliteTV_Scale { get; set; }

        /// <summary>
        /// 卫星电视及有线电视系统_规模  0902022 数据类别
        /// </summary>
        public string RecordTypeSatelliteTV_Scale { get; set; }

        /// <summary>
        /// 卫星电视及有线电视系统_规模  0902022 是否必填
        /// </summary>
        public bool? IsRequiredSatelliteTV_Scale { get; set; }

        /// <summary>
        /// 卫星电视及有线电视系统_规模  0902022 是否公开
        /// </summary>
        public bool? IsPublicSatelliteTV_Scale { get; set; }
        /// <summary>
        /// 卫星电视及有线电视系统_特点  0902023
        /// </summary>
        public string SatelliteTV_Feature { get; set; }

        /// <summary>
        /// 卫星电视及有线电视系统_特点  0902023 数据类别
        /// </summary>
        public string RecordTypeSatelliteTV_Feature { get; set; }

        /// <summary>
        /// 卫星电视及有线电视系统_特点  0902023 是否必填
        /// </summary>
        public bool? IsRequiredSatelliteTV_Feature { get; set; }

        /// <summary>
        /// 卫星电视及有线电视系统_特点  0902023 是否公开
        /// </summary>
        public bool? IsPublicSatelliteTV_Feature { get; set; }
        /// <summary>
        /// 无线对讲系统_规模  0902024
        /// </summary>
        public string WirelessIntercom_Scale { get; set; }

        /// <summary>
        /// 无线对讲系统_规模  0902024 数据类别
        /// </summary>
        public string RecordTypeWirelessIntercom_Scale { get; set; }

        /// <summary>
        /// 无线对讲系统_规模  0902024 是否必填
        /// </summary>
        public bool? IsRequiredWirelessIntercom_Scale { get; set; }

        /// <summary>
        /// 无线对讲系统_规模  0902024 是否公开
        /// </summary>
        public bool? IsPublicWirelessIntercom_Scale { get; set; }
        /// <summary>
        /// 无线对讲系统_特点  0902025
        /// </summary>
        public string WirelessIntercom_Feature { get; set; }

        /// <summary>
        /// 无线对讲系统_特点  0902025 数据类别
        /// </summary>
        public string RecordTypeWirelessIntercom_Feature { get; set; }

        /// <summary>
        /// 无线对讲系统_特点  0902025 是否必填
        /// </summary>
        public bool? IsRequiredWirelessIntercom_Feature { get; set; }

        /// <summary>
        /// 无线对讲系统_特点  0902025 是否公开
        /// </summary>
        public bool? IsPublicWirelessIntercom_Feature { get; set; }
        /// <summary>
        /// 建筑能效监管系统_规模  0902026
        /// </summary>
        public string BuildingEnergy_Scale { get; set; }

        /// <summary>
        /// 建筑能效监管系统_规模  0902026 数据类别
        /// </summary>
        public string RecordTypeBuildingEnergy_Scale { get; set; }

        /// <summary>
        /// 建筑能效监管系统_规模  0902026 是否必填
        /// </summary>
        public bool? IsRequiredBuildingEnergy_Scale { get; set; }

        /// <summary>
        /// 建筑能效监管系统_规模  0902026 是否公开
        /// </summary>
        public bool? IsPublicBuildingEnergy_Scale { get; set; }
        /// <summary>
        /// 建筑能效监管系统_特点  0902027
        /// </summary>
        public string BuildingEnergy_Feature { get; set; }

        /// <summary>
        /// 建筑能效监管系统_特点  0902027 数据类别
        /// </summary>
        public string RecordTypeBuildingEnergy_Feature { get; set; }

        /// <summary>
        /// 建筑能效监管系统_特点  0902027 是否必填
        /// </summary>
        public bool? IsRequiredBuildingEnergy_Feature { get; set; }

        /// <summary>
        /// 建筑能效监管系统_特点  0902027 是否公开
        /// </summary>
        public bool? IsPublicBuildingEnergy_Feature { get; set; }
        /// <summary>
        /// 信息引导及发布系统_规模  0902028
        /// </summary>
        public string InformationGuidance_Scale { get; set; }

        /// <summary>
        /// 信息引导及发布系统_规模  0902028 数据类别
        /// </summary>
        public string RecordTypeInformationGuidance_Scale { get; set; }

        /// <summary>
        /// 信息引导及发布系统_规模  0902028 是否必填
        /// </summary>
        public bool? IsRequiredInformationGuidance_Scale { get; set; }

        /// <summary>
        /// 信息引导及发布系统_规模  0902028 是否公开
        /// </summary>
        public bool? IsPublicInformationGuidance_Scale { get; set; }
        /// <summary>
        /// 信息引导及发布系统_特点  0902029
        /// </summary>
        public string InformationGuidance_Feature { get; set; }

        /// <summary>
        /// 信息引导及发布系统_特点  0902029 数据类别
        /// </summary>
        public string RecordTypeInformationGuidance_Feature { get; set; }

        /// <summary>
        /// 信息引导及发布系统_特点  0902029 是否必填
        /// </summary>
        public bool? IsRequiredInformationGuidance_Feature { get; set; }

        /// <summary>
        /// 信息引导及发布系统_特点  0902029 是否公开
        /// </summary>
        public bool? IsPublicInformationGuidance_Feature { get; set; }
        /// <summary>
        /// 机房工程_规模  0902030
        /// </summary>
        public string ComputerRoom_Scale { get; set; }

        /// <summary>
        /// 机房工程_规模  0902030 数据类别
        /// </summary>
        public string RecordTypeComputerRoom_Scale { get; set; }

        /// <summary>
        /// 机房工程_规模  0902030 是否必填
        /// </summary>
        public bool? IsRequiredComputerRoom_Scale { get; set; }

        /// <summary>
        /// 机房工程_规模  0902030 是否公开
        /// </summary>
        public bool? IsPublicComputerRoom_Scale { get; set; }
        /// <summary>
        /// 机房工程_特点  0902031
        /// </summary>
        public string ComputerRoom_Feature { get; set; }

        /// <summary>
        /// 机房工程_特点  0902031 数据类别
        /// </summary>
        public string RecordTypeComputerRoom_Feature { get; set; }

        /// <summary>
        /// 机房工程_特点  0902031 是否必填
        /// </summary>
        public bool? IsRequiredComputerRoom_Feature { get; set; }

        /// <summary>
        /// 机房工程_特点  0902031 是否公开
        /// </summary>
        public bool? IsPublicComputerRoom_Feature { get; set; }
        /// <summary>
        /// 曾获奖项  0902032
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0902032 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0902032 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0902032 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  0902033
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0902033 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0902033 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0902033 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0902034
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0902034 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0902034 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0902034 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
