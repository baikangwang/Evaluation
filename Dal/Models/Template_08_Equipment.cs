using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 建筑环境与设备专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_08_Equipment : TemplateBase
    {
        /// <summary>
        /// 建筑环境与设备专项奖—基础信息
        /// </summary>
        public Template_0801 Part_01 { get; set; }

        /// <summary>
        /// 建筑环境与设备专项奖—技术申报内容
        /// </summary>
        public Template_0802 Part_02 { get; set; }
    }
    /// <summary>
    /// 建筑环境与设备专项奖—基础信息
    /// </summary>
    [Serializable]
    public class Template_0801 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  0801001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0801001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0801001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0801001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  0801002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0801002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0801002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0801002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  0801003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0801003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0801003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0801003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0801004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0801004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0801004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0801004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0801005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0801005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0801005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0801005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0801006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0801006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0801006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0801006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0801007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0801007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0801007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0801007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0801008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0801008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0801008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0801008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0801009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0801009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0801009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0801009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0801010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0801010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0801010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0801010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0801011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0801011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0801011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0801011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0801012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0801012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0801012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0801012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0801013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0801013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0801013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0801013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0801014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0801014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0801014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0801014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0801015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0801015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0801015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0801015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0801016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0801016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0801016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0801016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0801017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0801017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0801017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0801017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0801018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0801018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0801018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0801018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0801019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0801019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0801019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0801019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0801020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0801020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0801020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0801020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0801021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0801021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0801021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0801021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0801022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0801022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0801022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0801022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  0801023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0801023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0801023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0801023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0801024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0801024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0801024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0801024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  0801025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  0801025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0801025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0801025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  0801026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0801026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0801026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0801026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地上  0801027
        /// </summary>
        public string UseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0801027 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0801027 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0801027 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Overground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  0801028
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0801028 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0801028 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0801028 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  0801029
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  0801029 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  0801029 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  0801029 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  0801030
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0801030 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0801030 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0801030 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总建筑面积  0801031
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0801031 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0801031 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0801031 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 总用地面积  0801032
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0801032 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0801032 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0801032 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 建筑高度  0801033
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0801033 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0801033 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0801033 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑层数  0801034
        /// </summary>
        public string LayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0801034 数据类别
        /// </summary>
        public string RecordTypeLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0801034 是否必填
        /// </summary>
        public bool? IsRequiredLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0801034 是否公开
        /// </summary>
        public bool? IsPublicLayerCount { get; set; }
        /// <summary>
        /// 设计类别  0801035
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0801035 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0801035 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0801035 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0801036
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0801036 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0801036 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0801036 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0801037
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0801037 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0801037 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0801037 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  0801038
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0801038 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0801038 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0801038 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  0801039
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0801039 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0801039 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0801039 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0801040
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0801040 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0801040 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0801040 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  0801041
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0801041 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0801041 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0801041 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  0801042
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0801042 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0801042 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0801042 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  0801043
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0801043 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0801043 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0801043 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }

        /// <summary>
        /// 专业类别  0801044
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0801044 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0801044 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0801044 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 单位资质  0801045
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0801045 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0801045 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0801045 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  0801046
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0801046 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0801046 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  0801046 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }


    }


    /// <summary>
    /// 建筑环境与设备专项奖—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_0802 : TemplateBase
    {
        /// <summary>
        /// 供暖方式  0802001
        /// </summary>
        public string HeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0802001 数据类别
        /// </summary>
        public string RecordTypeHeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0802001 是否必填
        /// </summary>
        public bool? IsRequiredHeatingMode { get; set; }

        /// <summary>
        /// 供暖方式  0802001 是否公开
        /// </summary>
        public bool? IsPublicHeatingMode { get; set; }
        /// <summary>
        /// 供暖建筑面积  0802002
        /// </summary>
        public string HeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0802002 数据类别
        /// </summary>
        public string RecordTypeHeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0802002 是否必填
        /// </summary>
        public bool? IsRequiredHeatingConstructionArea { get; set; }

        /// <summary>
        /// 供暖建筑面积  0802002 是否公开
        /// </summary>
        public bool? IsPublicHeatingConstructionArea { get; set; }
        /// <summary>
        /// 供暖热负荷  0802003
        /// </summary>
        public string SpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0802003 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0802003 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoad { get; set; }

        /// <summary>
        /// 供暖热负荷  0802003 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoad { get; set; }
        /// <summary>
        /// 供暖热负荷指标  0802004
        /// </summary>
        public string SpaceHeatingLoadIndicators { get; set; }

        /// <summary>
        /// 供暖热负荷指标  0802004 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoadIndicators { get; set; }

        /// <summary>
        /// 供暖热负荷指标  0802004 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoadIndicators { get; set; }

        /// <summary>
        /// 供暖热负荷指标  0802004 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoadIndicators { get; set; }
        /// <summary>
        /// 空调系统形式  0802005
        /// </summary>
        public string AirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0802005 数据类别
        /// </summary>
        public string RecordTypeAirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0802005 是否必填
        /// </summary>
        public bool? IsRequiredAirConSysMode { get; set; }

        /// <summary>
        /// 空调系统形式  0802005 是否公开
        /// </summary>
        public bool? IsPublicAirConSysMode { get; set; }
        /// <summary>
        /// 空调建筑面积  0802006
        /// </summary>
        public string AirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0802006 数据类别
        /// </summary>
        public string RecordTypeAirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0802006 是否必填
        /// </summary>
        public bool? IsRequiredAirConBuildingArea { get; set; }

        /// <summary>
        /// 空调建筑面积  0802006 是否公开
        /// </summary>
        public bool? IsPublicAirConBuildingArea { get; set; }
        /// <summary>
        /// 空调冷负荷  0802007
        /// </summary>
        public string AirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0802007 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0802007 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingLoad { get; set; }

        /// <summary>
        /// 空调冷负荷  0802007 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingLoad { get; set; }
        /// <summary>
        /// 空调冷指标_总建筑面积  0802008
        /// </summary>
        public string AirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0802008 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0802008 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调冷指标_总建筑面积  0802008 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingIndicators_TotalArea { get; set; }
        /// <summary>
        /// 空调冷指标_空调建筑面积  0802009
        /// </summary>
        public string AirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0802009 数据类别
        /// </summary>
        public string RecordTypeAirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0802009 是否必填
        /// </summary>
        public bool? IsRequiredAirConCoolingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调冷指标_空调建筑面积  0802009 是否公开
        /// </summary>
        public bool? IsPublicAirConCoolingIndicators_AirConArea { get; set; }
        /// <summary>
        /// 空调热负荷  0802010
        /// </summary>
        public string AirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0802010 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0802010 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingLoad { get; set; }

        /// <summary>
        /// 空调热负荷  0802010 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingLoad { get; set; }
        /// <summary>
        /// 空调热指标_总建筑面积  0802011
        /// </summary>
        public string AirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0802011 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0802011 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingIndicators_TotalArea { get; set; }

        /// <summary>
        /// 空调热指标_总建筑面积  0802011 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingIndicators_TotalArea { get; set; }
        /// <summary>
        /// 空调热指标_空调建筑面积  0802012
        /// </summary>
        public string AirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0802012 数据类别
        /// </summary>
        public string RecordTypeAirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0802012 是否必填
        /// </summary>
        public bool? IsRequiredAirConHeatingIndicators_AirConArea { get; set; }

        /// <summary>
        /// 空调热指标_空调建筑面积  0802012 是否公开
        /// </summary>
        public bool? IsPublicAirConHeatingIndicators_AirConArea { get; set; }
        /// <summary>
        /// 冷水机组类型1  0802013
        /// </summary>
        public string ChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0802013 数据类别
        /// </summary>
        public string RecordTypeChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0802013 是否必填
        /// </summary>
        public bool? IsRequiredChillerType1 { get; set; }

        /// <summary>
        /// 冷水机组类型1  0802013 是否公开
        /// </summary>
        public bool? IsPublicChillerType1 { get; set; }
        /// <summary>
        /// 单台设计制冷量1  0802014
        /// </summary>
        public string ChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0802014 数据类别
        /// </summary>
        public string RecordTypeChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0802014 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput1 { get; set; }

        /// <summary>
        /// 单台设计制冷量1  0802014 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput1 { get; set; }
        /// <summary>
        /// 冷水机组台数1  0802015
        /// </summary>
        public string ChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0802015 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0802015 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity1 { get; set; }

        /// <summary>
        /// 冷水机组台数1  0802015 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity1 { get; set; }
        /// <summary>
        /// 冷水机组类型2  0802016
        /// </summary>
        public string ChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0802016 数据类别
        /// </summary>
        public string RecordTypeChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0802016 是否必填
        /// </summary>
        public bool? IsRequiredChillerType2 { get; set; }

        /// <summary>
        /// 冷水机组类型2  0802016 是否公开
        /// </summary>
        public bool? IsPublicChillerType2 { get; set; }
        /// <summary>
        /// 单台设计制冷量2  0802017
        /// </summary>
        public string ChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0802017 数据类别
        /// </summary>
        public string RecordTypeChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0802017 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput2 { get; set; }

        /// <summary>
        /// 单台设计制冷量2  0802017 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput2 { get; set; }
        /// <summary>
        /// 冷水机组台数2  0802018
        /// </summary>
        public string ChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0802018 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0802018 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity2 { get; set; }

        /// <summary>
        /// 冷水机组台数2  0802018 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity2 { get; set; }
        /// <summary>
        /// 冷水机组类型3  0802019
        /// </summary>
        public string ChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0802019 数据类别
        /// </summary>
        public string RecordTypeChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0802019 是否必填
        /// </summary>
        public bool? IsRequiredChillerType3 { get; set; }

        /// <summary>
        /// 冷水机组类型3  0802019 是否公开
        /// </summary>
        public bool? IsPublicChillerType3 { get; set; }
        /// <summary>
        /// 单台设计制冷量3  0802020
        /// </summary>
        public string ChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0802020 数据类别
        /// </summary>
        public string RecordTypeChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0802020 是否必填
        /// </summary>
        public bool? IsRequiredChillerOutput3 { get; set; }

        /// <summary>
        /// 单台设计制冷量3  0802020 是否公开
        /// </summary>
        public bool? IsPublicChillerOutput3 { get; set; }
        /// <summary>
        /// 冷水机组台数3  0802021
        /// </summary>
        public string ChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0802021 数据类别
        /// </summary>
        public string RecordTypeChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0802021 是否必填
        /// </summary>
        public bool? IsRequiredChillerQuantity3 { get; set; }

        /// <summary>
        /// 冷水机组台数3  0802021 是否公开
        /// </summary>
        public bool? IsPublicChillerQuantity3 { get; set; }
        /// <summary>
        /// 制热设备类型1  0802022
        /// </summary>
        public string HeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0802022 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0802022 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType1 { get; set; }

        /// <summary>
        /// 制热设备类型1  0802022 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType1 { get; set; }
        /// <summary>
        /// 单台设计供热量1  0802023
        /// </summary>
        public string HeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0802023 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0802023 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput1 { get; set; }

        /// <summary>
        /// 单台设计供热量1  0802023 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput1 { get; set; }
        /// <summary>
        /// 制热设备台数1  0802024
        /// </summary>
        public string HeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0802024 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0802024 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity1 { get; set; }

        /// <summary>
        /// 制热设备台数1  0802024 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity1 { get; set; }
        /// <summary>
        /// 制热设备类型2  0802025
        /// </summary>
        public string HeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0802025 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0802025 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType2 { get; set; }

        /// <summary>
        /// 制热设备类型2  0802025 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType2 { get; set; }
        /// <summary>
        /// 单台设计供热量2  0802026
        /// </summary>
        public string HeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0802026 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0802026 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput2 { get; set; }

        /// <summary>
        /// 单台设计供热量2  0802026 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput2 { get; set; }
        /// <summary>
        /// 制热设备台数2  0802027
        /// </summary>
        public string HeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0802027 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0802027 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity2 { get; set; }

        /// <summary>
        /// 制热设备台数2  0802027 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity2 { get; set; }
        /// <summary>
        /// 制热设备类型3  0802028
        /// </summary>
        public string HeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0802028 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0802028 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentType3 { get; set; }

        /// <summary>
        /// 制热设备类型3  0802028 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentType3 { get; set; }
        /// <summary>
        /// 单台设计供热量3  0802029
        /// </summary>
        public string HeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0802029 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0802029 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentOutput3 { get; set; }

        /// <summary>
        /// 单台设计供热量3  0802029 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentOutput3 { get; set; }
        /// <summary>
        /// 制热设备台数3  0802030
        /// </summary>
        public string HeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0802030 数据类别
        /// </summary>
        public string RecordTypeHeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0802030 是否必填
        /// </summary>
        public bool? IsRequiredHeatingEquipmentQuantity3 { get; set; }

        /// <summary>
        /// 制热设备台数3  0802030 是否公开
        /// </summary>
        public bool? IsPublicHeatingEquipmentQuantity3 { get; set; }
        /// <summary>
        /// 项目概况  0802031
        /// </summary>
        public string ProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0802031 数据类别
        /// </summary>
        public string RecordTypeProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0802031 是否必填
        /// </summary>
        public bool? IsRequiredProjectOverview { get; set; }

        /// <summary>
        /// 项目概况  0802031 是否公开
        /// </summary>
        public bool? IsPublicProjectOverview { get; set; }
        /// <summary>
        /// 技术特色  0802032
        /// </summary>
        public string TechnologyFeature { get; set; }

        /// <summary>
        /// 技术特色  0802032 数据类别
        /// </summary>
        public string RecordTypeTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特色  0802032 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特色  0802032 是否公开
        /// </summary>
        public bool? IsPublicTechnologyFeature { get; set; }
        /// <summary>
        /// 技术成效与深度  0802033
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// 技术成效与深度  0802033 数据类别
        /// </summary>
        public string RecordTypeEffect { get; set; }

        /// <summary>
        /// 技术成效与深度  0802033 是否必填
        /// </summary>
        public bool? IsRequiredEffect { get; set; }

        /// <summary>
        /// 技术成效与深度  0802033 是否公开
        /// </summary>
        public bool? IsPublicEffect { get; set; }
        /// <summary>
        /// 综合效益  0802034
        /// </summary>
        public string Benefit { get; set; }

        /// <summary>
        /// 综合效益  0802034 数据类别
        /// </summary>
        public string RecordTypeBenefit { get; set; }

        /// <summary>
        /// 综合效益  0802034 是否必填
        /// </summary>
        public bool? IsRequiredBenefit { get; set; }

        /// <summary>
        /// 综合效益  0802034 是否公开
        /// </summary>
        public bool? IsPublicBenefit { get; set; }

        /// <summary>
        /// 采暖热负荷指标_总建筑面积  0802035
        /// </summary>
        public string SpaceHeatingLoadIndicators_ALL { get; set; }

        /// <summary>
        /// 采暖热负荷指标_总建筑面积  0802035 数据类别
        /// </summary>
        public string RecordTypeSpaceHeatingLoadIndicators_ALL { get; set; }

        /// <summary>
        /// 采暖热负荷指标_总建筑面积  0802035 是否必填
        /// </summary>
        public bool? IsRequiredSpaceHeatingLoadIndicators_ALL { get; set; }

        /// <summary>
        /// 采暖热负荷指标_总建筑面积  0802035 是否公开
        /// </summary>
        public bool? IsPublicSpaceHeatingLoadIndicators_ALL { get; set; }
        /// <summary>
        /// 空调设计冷量  0802036
        /// </summary>
        public string AirConditioning { get; set; }

        /// <summary>
        /// 空调设计冷量  0802036 数据类别
        /// </summary>
        public string RecordTypeAirConditioning { get; set; }

        /// <summary>
        /// 空调设计冷量  0802036 是否必填
        /// </summary>
        public bool? IsRequiredAirConditioning { get; set; }

        /// <summary>
        /// 空调设计冷量  0802036 是否公开
        /// </summary>
        public bool? IsPublicAirConditioning { get; set; }
        /// <summary>
        /// 空调设计热量  0802037
        /// </summary>
        public string AirConditioningHeat { get; set; }

        /// <summary>
        /// 空调设计热量  0802037 数据类别
        /// </summary>
        public string RecordTypeAirConditioningHeat { get; set; }

        /// <summary>
        /// 空调设计热量  0802037 是否必填
        /// </summary>
        public bool? IsRequiredAirConditioningHeat { get; set; }

        /// <summary>
        /// 空调设计热量  0802037 是否公开
        /// </summary>
        public bool? IsPublicAirConditioningHeat { get; set; }
        /// <summary>
        /// 空调通风系统总装机电容量  0802038
        /// </summary>
        public string TotalInstalledCapacity { get; set; }

        /// <summary>
        /// 空调通风系统总装机电容量  0802038 数据类别
        /// </summary>
        public string RecordTypeTotalInstalledCapacity { get; set; }

        /// <summary>
        /// 空调通风系统总装机电容量  0802038 是否必填
        /// </summary>
        public bool? IsRequiredTotalInstalledCapacity { get; set; }

        /// <summary>
        /// 空调通风系统总装机电容量  0802038 是否公开
        /// </summary>
        public bool? IsPublicTotalInstalledCapacity { get; set; }
        /// <summary>
        /// 装机电容量指标  0802039
        /// </summary>
        public string InstalledElectromechanical { get; set; }

        /// <summary>
        /// 装机电容量指标  0802039 数据类别
        /// </summary>
        public string RecordTypeInstalledElectromechanical { get; set; }

        /// <summary>
        /// 装机电容量指标  0802039 是否必填
        /// </summary>
        public bool? IsRequiredInstalledElectromechanical { get; set; }

        /// <summary>
        /// 装机电容量指标  0802039 是否公开
        /// </summary>
        public bool? IsPublicInstalledElectromechanical { get; set; }

        /// <summary>
        /// 曾获奖项  0802040
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0802040 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0802040 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0802040 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  0802041
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0802041 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0802041 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0802041 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0802042
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0802042 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0802042 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0802042 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
