using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 抗震防灾专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_11_AntiSeismic : TemplateBase
    {
        /// <summary>
        /// 抗震防灾专项奖申报模板—基础信息
        /// </summary>
        public Template_1101 Part_01 { get; set; }

        /// <summary>
        /// 抗震—技术申报内容—隔震
        /// </summary>
        public Template_1102 Part_02 { get; set; }

        /// <summary>
        /// 抗震—技术—消能减震
        /// </summary>
        public Template_1103 Part_03 { get; set; }

        /// <summary>
        /// 抗震—技术—技术特点
        /// </summary>
        public Template_1104 Part_04 { get; set; }
    }

    /// <summary>
    /// 抗震防灾专项奖申报模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_1101 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  1101001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  1101001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  1101001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  1101001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  1101002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  1101002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  1101002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  1101002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  1101003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1101003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1101003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  1101003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  1101004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1101004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1101004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  1101004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  1101005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  1101005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  1101005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  1101005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  1101006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  1101006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  1101006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  1101006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  1101007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1101007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1101007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  1101007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  1101008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  1101008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  1101008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  1101008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  1101009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  1101009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  1101009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  1101009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  1101010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1101010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1101010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  1101010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  1101011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1101011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1101011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  1101011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  1101012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1101012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1101012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  1101012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  1101013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1101013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1101013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  1101013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  1101014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1101014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1101014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  1101014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  1101015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1101015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1101015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  1101015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  1101016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1101016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1101016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  1101016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  1101017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1101017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1101017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  1101017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  1101018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1101018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1101018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  1101018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  1101019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1101019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1101019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  1101019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  1101020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1101020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1101020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  1101020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  1101021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1101021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1101021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  1101021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  1101022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1101022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1101022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  1101022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  1101023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1101023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1101023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1101023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  1101024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1101024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1101024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1101024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  1101025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  1101025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  1101025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  1101025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  1101026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1101026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1101026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  1101026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地上  1101027
        /// </summary>
        public string UseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  1101027 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  1101027 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  1101027 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Overground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  1101028
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  1101028 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  1101028 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  1101028 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  1101029
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  1101029 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  1101029 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  1101029 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  1101030
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  1101030 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  1101030 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  1101030 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总建筑面积  1101031
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  1101031 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  1101031 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  1101031 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 总用地面积  1101032
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  1101032 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  1101032 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  1101032 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 建筑高度  1101033
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  1101033 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  1101033 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  1101033 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑层数  1101034
        /// </summary>
        public string LayerCount { get; set; }

        /// <summary>
        /// 建筑层数  1101034 数据类别
        /// </summary>
        public string RecordTypeLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  1101034 是否必填
        /// </summary>
        public bool? IsRequiredLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  1101034 是否公开
        /// </summary>
        public bool? IsPublicLayerCount { get; set; }
        /// <summary>
        /// 设计类别  1101035
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1101035 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1101035 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  1101035 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  1101036
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  1101036 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  1101036 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  1101036 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  1101037
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  1101037 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  1101037 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  1101037 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  1101038
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1101038 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1101038 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  1101038 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  1101039
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1101039 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1101039 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  1101039 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  1101040
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1101040 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1101040 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  1101040 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  1101041
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1101041 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1101041 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  1101041 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  1101042
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1101042 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1101042 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  1101042 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  1101043
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1101043 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1101043 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  1101043 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }

        /// <summary>
        /// 专业类别  1101044
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   1101044 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   1101044 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   1101044 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 单位资质  1101045
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  1101045 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  1101045 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  1101045 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }
        /// <summary>
        /// 证书编号  1101046
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1101046 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1101046 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        /// 证书编号  1101046 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

    }


    /// <summary>
    /// 抗震—技术申报内容—隔震
    /// </summary>
    [Serializable]
    public class Template_1102 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1102001
        /// </summary>
        public string ShockProjectName { get; set; }

        /// <summary>
        /// 项目名称  1102001 数据类别
        /// </summary>
        public string RecordTypeShockProjectName { get; set; }

        /// <summary>
        /// 项目名称  1102001 是否必填
        /// </summary>
        public bool? IsRequiredShockProjectName { get; set; }

        /// <summary>
        /// 项目名称  1102001 是否公开
        /// </summary>
        public bool? IsPublicShockProjectName { get; set; }
        /// <summary>
        /// 用途  1102002
        /// </summary>
        public string ShockPurpose { get; set; }

        /// <summary>
        /// 用途  1102002 数据类别
        /// </summary>
        public string RecordTypeShockPurpose { get; set; }

        /// <summary>
        /// 用途  1102002 是否必填
        /// </summary>
        public bool? IsRequiredShockPurpose { get; set; }

        /// <summary>
        /// 用途  1102002 是否公开
        /// </summary>
        public bool? IsPublicShockPurpose { get; set; }
        /// <summary>
        /// 建设地点  1102003
        /// </summary>
        public string ShockConstructionSite { get; set; }

        /// <summary>
        /// 建设地点  1102003 数据类别
        /// </summary>
        public string RecordTypeShockConstructionSite { get; set; }

        /// <summary>
        /// 建设地点  1102003 是否必填
        /// </summary>
        public bool? IsRequiredShockConstructionSite { get; set; }

        /// <summary>
        /// 建设地点  1102003 是否公开
        /// </summary>
        public bool? IsPublicShockConstructionSite { get; set; }
        /// <summary>
        /// 建设时间  1102004
        /// </summary>
        public string ShockConstructionTime { get; set; }

        /// <summary>
        /// 建设时间  1102004 数据类别
        /// </summary>
        public string RecordTypeShockConstructionTime { get; set; }

        /// <summary>
        /// 建设时间  1102004 是否必填
        /// </summary>
        public bool? IsRequiredShockConstructionTime { get; set; }

        /// <summary>
        /// 建设时间  1102004 是否公开
        /// </summary>
        public bool? IsPublicShockConstructionTime { get; set; }
        /// <summary>
        /// 总高度(m)  1102005
        /// </summary>
        public string ShockTotalHeight { get; set; }

        /// <summary>
        /// 总高度(m)  1102005 数据类别
        /// </summary>
        public string RecordTypeShockTotalHeight { get; set; }

        /// <summary>
        /// 总高度(m)  1102005 是否必填
        /// </summary>
        public bool? IsRequiredShockTotalHeight { get; set; }

        /// <summary>
        /// 总高度(m)  1102005 是否公开
        /// </summary>
        public bool? IsPublicShockTotalHeight { get; set; }
        /// <summary>
        /// 占地面积(㎡)  1102006
        /// </summary>
        public string ShockCoveredArea { get; set; }

        /// <summary>
        /// 占地面积(㎡)  1102006 数据类别
        /// </summary>
        public string RecordTypeShockCoveredArea { get; set; }

        /// <summary>
        /// 占地面积(㎡)  1102006 是否必填
        /// </summary>
        public bool? IsRequiredShockCoveredArea { get; set; }

        /// <summary>
        /// 占地面积(㎡)  1102006 是否公开
        /// </summary>
        public bool? IsPublicShockCoveredArea { get; set; }
        /// <summary>
        /// 建筑面积(㎡)  1102007
        /// </summary>
        public string ShockConstructionArea { get; set; }

        /// <summary>
        /// 建筑面积(㎡)  1102007 数据类别
        /// </summary>
        public string RecordTypeShockConstructionArea { get; set; }

        /// <summary>
        /// 建筑面积(㎡)  1102007 是否必填
        /// </summary>
        public bool? IsRequiredShockConstructionArea { get; set; }

        /// <summary>
        /// 建筑面积(㎡)  1102007 是否公开
        /// </summary>
        public bool? IsPublicShockConstructionArea { get; set; }
        /// <summary>
        /// 隔震层面积(㎡)  1102008
        /// </summary>
        public string IsolationLayerArea { get; set; }

        /// <summary>
        /// 隔震层面积(㎡)  1102008 数据类别
        /// </summary>
        public string RecordTypeIsolationLayerArea { get; set; }

        /// <summary>
        /// 隔震层面积(㎡)  1102008 是否必填
        /// </summary>
        public bool? IsRequiredIsolationLayerArea { get; set; }

        /// <summary>
        /// 隔震层面积(㎡)  1102008 是否公开
        /// </summary>
        public bool? IsPublicIsolationLayerArea { get; set; }
        /// <summary>
        /// 高宽比  1102009
        /// </summary>
        public string ShockHighAspectRatio { get; set; }

        /// <summary>
        /// 高宽比  1102009 数据类别
        /// </summary>
        public string RecordTypeShockHighAspectRatio { get; set; }

        /// <summary>
        /// 高宽比  1102009 是否必填
        /// </summary>
        public bool? IsRequiredShockHighAspectRatio { get; set; }

        /// <summary>
        /// 高宽比  1102009 是否公开
        /// </summary>
        public bool? IsPublicShockHighAspectRatio { get; set; }
        /// <summary>
        /// 层数_地上  1102010
        /// </summary>
        public string ShockLayer_Ground { get; set; }

        /// <summary>
        /// 层数_地上  1102010 数据类别
        /// </summary>
        public string RecordTypeShockLayer_Ground { get; set; }

        /// <summary>
        /// 层数_地上  1102010 是否必填
        /// </summary>
        public bool? IsRequiredShockLayer_Ground { get; set; }

        /// <summary>
        /// 层数_地上  1102010 是否公开
        /// </summary>
        public bool? IsPublicShockLayer_Ground { get; set; }
        /// <summary>
        /// 层数_地下  1102011
        /// </summary>
        public string ShockLayer_Underground { get; set; }

        /// <summary>
        /// 层数_地下  1102011 数据类别
        /// </summary>
        public string RecordTypeShockLayer_Underground { get; set; }

        /// <summary>
        /// 层数_地下  1102011 是否必填
        /// </summary>
        public bool? IsRequiredShockLayer_Underground { get; set; }

        /// <summary>
        /// 层数_地下  1102011 是否公开
        /// </summary>
        public bool? IsPublicShockLayer_Underground { get; set; }
        /// <summary>
        /// 首层层高(m)  1102012
        /// </summary>
        public string ShockFirstStoreyHeight { get; set; }

        /// <summary>
        /// 首层层高(m)  1102012 数据类别
        /// </summary>
        public string RecordTypeShockFirstStoreyHeight { get; set; }

        /// <summary>
        /// 首层层高(m)  1102012 是否必填
        /// </summary>
        public bool? IsRequiredShockFirstStoreyHeight { get; set; }

        /// <summary>
        /// 首层层高(m)  1102012 是否公开
        /// </summary>
        public bool? IsPublicShockFirstStoreyHeight { get; set; }
        /// <summary>
        /// 标准层高(m)  1102013
        /// </summary>
        public string ShockStandardHeight { get; set; }

        /// <summary>
        /// 标准层高(m)  1102013 数据类别
        /// </summary>
        public string RecordTypeShockStandardHeight { get; set; }

        /// <summary>
        /// 标准层高(m)  1102013 是否必填
        /// </summary>
        public bool? IsRequiredShockStandardHeight { get; set; }

        /// <summary>
        /// 标准层高(m)  1102013 是否公开
        /// </summary>
        public bool? IsPublicShockStandardHeight { get; set; }
        /// <summary>
        /// 建设单位  1102014
        /// </summary>
        public string TechnologyDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1102014 数据类别
        /// </summary>
        public string RecordTypeTechnologyDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1102014 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1102014 是否公开
        /// </summary>
        public bool? IsPublicTechnologyDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  1102015
        /// </summary>
        public string TechnologyConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1102015 数据类别
        /// </summary>
        public string RecordTypeTechnologyConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1102015 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1102015 是否公开
        /// </summary>
        public bool? IsPublicTechnologyConstructionOrganization { get; set; }
        /// <summary>
        /// 设计单位  1102016
        /// </summary>
        public string ShockDesignOrganization { get; set; }

        /// <summary>
        /// 设计单位  1102016 数据类别
        /// </summary>
        public string RecordTypeShockDesignOrganization { get; set; }

        /// <summary>
        /// 设计单位  1102016 是否必填
        /// </summary>
        public bool? IsRequiredShockDesignOrganization { get; set; }

        /// <summary>
        /// 设计单位  1102016 是否公开
        /// </summary>
        public bool? IsPublicShockDesignOrganization { get; set; }
        /// <summary>
        /// 施工图审查机构  1102017
        /// </summary>
        public string ShockConstructionPlansCensorship { get; set; }

        /// <summary>
        /// 施工图审查机构  1102017 数据类别
        /// </summary>
        public string RecordTypeShockConstructionPlansCensorship { get; set; }

        /// <summary>
        /// 施工图审查机构  1102017 是否必填
        /// </summary>
        public bool? IsRequiredShockConstructionPlansCensorship { get; set; }

        /// <summary>
        /// 施工图审查机构  1102017 是否公开
        /// </summary>
        public bool? IsPublicShockConstructionPlansCensorship { get; set; }
        /// <summary>
        /// 混凝土总用量(m3)  1102018
        /// </summary>
        public string ShockConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量(m3)  1102018 数据类别
        /// </summary>
        public string RecordTypeShockConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量(m3)  1102018 是否必填
        /// </summary>
        public bool? IsRequiredShockConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量(m3)  1102018 是否公开
        /// </summary>
        public bool? IsPublicShockConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1102019
        /// </summary>
        public string ShockPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1102019 数据类别
        /// </summary>
        public string RecordTypeShockPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1102019 是否必填
        /// </summary>
        public bool? IsRequiredShockPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1102019 是否公开
        /// </summary>
        public bool? IsPublicShockPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  1102020
        /// </summary>
        public string ShockSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  1102020 数据类别
        /// </summary>
        public string RecordTypeShockSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  1102020 是否必填
        /// </summary>
        public bool? IsRequiredShockSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  1102020 是否公开
        /// </summary>
        public bool? IsPublicShockSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  1102021
        /// </summary>
        public string ShockSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  1102021 数据类别
        /// </summary>
        public string RecordTypeShockSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  1102021 是否必填
        /// </summary>
        public bool? IsRequiredShockSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  1102021 是否公开
        /// </summary>
        public bool? IsPublicShockSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  1102022
        /// </summary>
        public string ShockPerSqM_SteelAmount_Rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  1102022 数据类别
        /// </summary>
        public string RecordTypeShockPerSqM_SteelAmount_Rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  1102022 是否必填
        /// </summary>
        public bool? IsRequiredShockPerSqM_SteelAmount_Rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  1102022 是否公开
        /// </summary>
        public bool? IsPublicShockPerSqM_SteelAmount_Rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  1102023
        /// </summary>
        public string ShockPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  1102023 数据类别
        /// </summary>
        public string RecordTypeShockPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  1102023 是否必填
        /// </summary>
        public bool? IsRequiredShockPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  1102023 是否公开
        /// </summary>
        public bool? IsPublicShockPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1102024
        /// </summary>
        public string ShockSeismicAccelerationParameter { get; set; }

        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1102024 数据类别
        /// </summary>
        public string RecordTypeShockSeismicAccelerationParameter { get; set; }

        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1102024 是否必填
        /// </summary>
        public bool? IsRequiredShockSeismicAccelerationParameter { get; set; }

        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1102024 是否公开
        /// </summary>
        public bool? IsPublicShockSeismicAccelerationParameter { get; set; }
        /// <summary>
        /// 设计基本地震动加速度(g)  1102025
        /// </summary>
        public string ShockBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震动加速度(g)  1102025 数据类别
        /// </summary>
        public string RecordTypeShockBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震动加速度(g)  1102025 是否必填
        /// </summary>
        public bool? IsRequiredShockBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震动加速度(g)  1102025 是否公开
        /// </summary>
        public bool? IsPublicShockBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 场地类别  1102026
        /// </summary>
        public string ShockSiteType { get; set; }

        /// <summary>
        /// 场地类别  1102026 数据类别
        /// </summary>
        public string RecordTypeShockSiteType { get; set; }

        /// <summary>
        /// 场地类别  1102026 是否必填
        /// </summary>
        public bool? IsRequiredShockSiteType { get; set; }

        /// <summary>
        /// 场地类别  1102026 是否公开
        /// </summary>
        public bool? IsPublicShockSiteType { get; set; }
        /// <summary>
        /// 特征周期(s)  1102027
        /// </summary>
        public string ShockEigenperiod { get; set; }

        /// <summary>
        /// 特征周期(s)  1102027 数据类别
        /// </summary>
        public string RecordTypeShockEigenperiod { get; set; }

        /// <summary>
        /// 特征周期(s)  1102027 是否必填
        /// </summary>
        public bool? IsRequiredShockEigenperiod { get; set; }

        /// <summary>
        /// 特征周期(s)  1102027 是否公开
        /// </summary>
        public bool? IsPublicShockEigenperiod { get; set; }
        /// <summary>
        /// 抗震设防类别  1102028
        /// </summary>
        public string ShockFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  1102028 数据类别
        /// </summary>
        public string RecordTypeShockFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  1102028 是否必填
        /// </summary>
        public bool? IsRequiredShockFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  1102028 是否公开
        /// </summary>
        public bool? IsPublicShockFortificationCategory { get; set; }
        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1102029
        /// </summary>
        public string ShockTimeHistoryAnalysis { get; set; }

        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1102029 数据类别
        /// </summary>
        public string RecordTypeShockTimeHistoryAnalysis { get; set; }

        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1102029 是否必填
        /// </summary>
        public bool? IsRequiredShockTimeHistoryAnalysis { get; set; }

        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1102029 是否公开
        /// </summary>
        public bool? IsPublicShockTimeHistoryAnalysis { get; set; }
        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1102030
        /// </summary>
        public string ShockAdverseFactorsMmeasures { get; set; }

        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1102030 数据类别
        /// </summary>
        public string RecordTypeShockAdverseFactorsMmeasures { get; set; }

        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1102030 是否必填
        /// </summary>
        public bool? IsRequiredShockAdverseFactorsMmeasures { get; set; }

        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1102030 是否公开
        /// </summary>
        public bool? IsPublicShockAdverseFactorsMmeasures { get; set; }
        /// <summary>
        /// 基础形式  1102031
        /// </summary>
        public string ShockBaseType { get; set; }

        /// <summary>
        /// 基础形式  1102031 数据类别
        /// </summary>
        public string RecordTypeShockBaseType { get; set; }

        /// <summary>
        /// 基础形式  1102031 是否必填
        /// </summary>
        public bool? IsRequiredShockBaseType { get; set; }

        /// <summary>
        /// 基础形式  1102031 是否公开
        /// </summary>
        public bool? IsPublicShockBaseType { get; set; }
        /// <summary>
        /// 上部结构形式  1102032
        /// </summary>
        public string ShockUpperStructureForm { get; set; }

        /// <summary>
        /// 上部结构形式  1102032 数据类别
        /// </summary>
        public string RecordTypeShockUpperStructureForm { get; set; }

        /// <summary>
        /// 上部结构形式  1102032 是否必填
        /// </summary>
        public bool? IsRequiredShockUpperStructureForm { get; set; }

        /// <summary>
        /// 上部结构形式  1102032 是否公开
        /// </summary>
        public bool? IsPublicShockUpperStructureForm { get; set; }
        /// <summary>
        /// 地下室结构形式  1102033
        /// </summary>
        public string ShockBasementStructuralForm { get; set; }

        /// <summary>
        /// 地下室结构形式  1102033 数据类别
        /// </summary>
        public string RecordTypeShockBasementStructuralForm { get; set; }

        /// <summary>
        /// 地下室结构形式  1102033 是否必填
        /// </summary>
        public bool? IsRequiredShockBasementStructuralForm { get; set; }

        /// <summary>
        /// 地下室结构形式  1102033 是否公开
        /// </summary>
        public bool? IsPublicShockBasementStructuralForm { get; set; }
        /// <summary>
        /// 隔震层位置（标高和层）  1102034
        /// </summary>
        public string ShockIsolationLayerLocation { get; set; }

        /// <summary>
        /// 隔震层位置（标高和层）  1102034 数据类别
        /// </summary>
        public string RecordTypeShockIsolationLayerLocation { get; set; }

        /// <summary>
        /// 隔震层位置（标高和层）  1102034 是否必填
        /// </summary>
        public bool? IsRequiredShockIsolationLayerLocation { get; set; }

        /// <summary>
        /// 隔震层位置（标高和层）  1102034 是否公开
        /// </summary>
        public bool? IsPublicShockIsolationLayerLocation { get; set; }
        /// <summary>
        /// 水平向减震系数  1102035
        /// </summary>
        public string ShockHorizontalDampingCoefficient { get; set; }

        /// <summary>
        /// 水平向减震系数  1102035 数据类别
        /// </summary>
        public string RecordTypeShockHorizontalDampingCoefficient { get; set; }

        /// <summary>
        /// 水平向减震系数  1102035 是否必填
        /// </summary>
        public bool? IsRequiredShockHorizontalDampingCoefficient { get; set; }

        /// <summary>
        /// 水平向减震系数  1102035 是否公开
        /// </summary>
        public bool? IsPublicShockHorizontalDampingCoefficient { get; set; }
        /// <summary>
        /// 隔震设计基本周期(s)  1102036
        /// </summary>
        public string IsolationDesignBasePeriod { get; set; }

        /// <summary>
        /// 隔震设计基本周期(s)  1102036 数据类别
        /// </summary>
        public string RecordTypeIsolationDesignBasePeriod { get; set; }

        /// <summary>
        /// 隔震设计基本周期(s)  1102036 是否必填
        /// </summary>
        public bool? IsRequiredIsolationDesignBasePeriod { get; set; }

        /// <summary>
        /// 隔震设计基本周期(s)  1102036 是否公开
        /// </summary>
        public bool? IsPublicIsolationDesignBasePeriod { get; set; }
        /// <summary>
        /// 上部结构基本周期(s)  1102037
        /// </summary>
        public string UpperStructureBasePeriod { get; set; }

        /// <summary>
        /// 上部结构基本周期(s)  1102037 数据类别
        /// </summary>
        public string RecordTypeUpperStructureBasePeriod { get; set; }

        /// <summary>
        /// 上部结构基本周期(s)  1102037 是否必填
        /// </summary>
        public bool? IsRequiredUpperStructureBasePeriod { get; set; }

        /// <summary>
        /// 上部结构基本周期(s)  1102037 是否公开
        /// </summary>
        public bool? IsPublicUpperStructureBasePeriod { get; set; }
        /// <summary>
        /// 隔震支座实际使用平均面压最大最小面压(MPa)  1102038
        /// </summary>
        public string SurfacePressure { get; set; }

        /// <summary>
        /// 隔震支座实际使用平均面压最大最小面压(MPa)  1102038 数据类别
        /// </summary>
        public string RecordTypeSurfacePressure { get; set; }

        /// <summary>
        /// 隔震支座实际使用平均面压最大最小面压(MPa)  1102038 是否必填
        /// </summary>
        public bool? IsRequiredSurfacePressure { get; set; }

        /// <summary>
        /// 隔震支座实际使用平均面压最大最小面压(MPa)  1102038 是否公开
        /// </summary>
        public bool? IsPublicSurfacePressure { get; set; }
        /// <summary>
        /// 隔震支座设计最大位移(cm)  1102039
        /// </summary>
        public string MaxDisplacement { get; set; }

        /// <summary>
        /// 隔震支座设计最大位移(cm)  1102039 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacement { get; set; }

        /// <summary>
        /// 隔震支座设计最大位移(cm)  1102039 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacement { get; set; }

        /// <summary>
        /// 隔震支座设计最大位移(cm)  1102039 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacement { get; set; }
        /// <summary>
        /// 隔震层顶板体系  1102040
        /// </summary>
        public string RoofSystem { get; set; }

        /// <summary>
        /// 隔震层顶板体系  1102040 数据类别
        /// </summary>
        public string RecordTypeRoofSystem { get; set; }

        /// <summary>
        /// 隔震层顶板体系  1102040 是否必填
        /// </summary>
        public bool? IsRequiredRoofSystem { get; set; }

        /// <summary>
        /// 隔震层顶板体系  1102040 是否公开
        /// </summary>
        public bool? IsPublicRoofSystem { get; set; }
        /// <summary>
        /// 隔震层下支墩（柱）主要断面  1102041
        /// </summary>
        public string MainSection { get; set; }

        /// <summary>
        /// 隔震层下支墩（柱）主要断面  1102041 数据类别
        /// </summary>
        public string RecordTypeMainSection { get; set; }

        /// <summary>
        /// 隔震层下支墩（柱）主要断面  1102041 是否必填
        /// </summary>
        public bool? IsRequiredMainSection { get; set; }

        /// <summary>
        /// 隔震层下支墩（柱）主要断面  1102041 是否公开
        /// </summary>
        public bool? IsPublicMainSection { get; set; }
        /// <summary>
        /// 总质量（t）  1102042
        /// </summary>
        public string TotalMass { get; set; }

        /// <summary>
        /// 总质量（t）  1102042 数据类别
        /// </summary>
        public string RecordTypeTotalMass { get; set; }

        /// <summary>
        /// 总质量（t）  1102042 是否必填
        /// </summary>
        public bool? IsRequiredTotalMass { get; set; }

        /// <summary>
        /// 总质量（t）  1102042 是否公开
        /// </summary>
        public bool? IsPublicTotalMass { get; set; }
        /// <summary>
        /// 阻尼比(%)  1102043
        /// </summary>
        public string DampingRatio { get; set; }

        /// <summary>
        /// 阻尼比(%)  1102043 数据类别
        /// </summary>
        public string RecordTypeDampingRatio { get; set; }

        /// <summary>
        /// 阻尼比(%)  1102043 是否必填
        /// </summary>
        public bool? IsRequiredDampingRatio { get; set; }

        /// <summary>
        /// 阻尼比(%)  1102043 是否公开
        /// </summary>
        public bool? IsPublicDampingRatio { get; set; }
        /// <summary>
        /// 抗震分析程序名称  1102044
        /// </summary>
        public string DampingSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名称  1102044 数据类别
        /// </summary>
        public string RecordTypeDampingSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名称  1102044 是否必填
        /// </summary>
        public bool? IsRequiredDampingSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名称  1102044 是否公开
        /// </summary>
        public bool? IsPublicDampingSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 隔震器最大变形_中震_横向 (mm)  1102045
        /// </summary>
        public string Isolation_M_H { get; set; }

        /// <summary>
        /// 隔震器最大变形_中震_横向 (mm)  1102045 数据类别
        /// </summary>
        public string RecordTypeIsolation_M_H { get; set; }

        /// <summary>
        /// 隔震器最大变形_中震_横向 (mm)  1102045 是否必填
        /// </summary>
        public bool? IsRequiredIsolation_M_H { get; set; }

        /// <summary>
        /// 隔震器最大变形_中震_横向 (mm)  1102045 是否公开
        /// </summary>
        public bool? IsPublicIsolation_M_H { get; set; }
        /// <summary>
        /// 隔震器最大变形_中震_纵向 (mm)  1102046
        /// </summary>
        public string Isolation_M_V { get; set; }

        /// <summary>
        /// 隔震器最大变形_中震_纵向 (mm)  1102046 数据类别
        /// </summary>
        public string RecordTypeIsolation_M_V { get; set; }

        /// <summary>
        /// 隔震器最大变形_中震_纵向 (mm)  1102046 是否必填
        /// </summary>
        public bool? IsRequiredIsolation_M_V { get; set; }

        /// <summary>
        /// 隔震器最大变形_中震_纵向 (mm)  1102046 是否公开
        /// </summary>
        public bool? IsPublicIsolation_M_V { get; set; }
        /// <summary>
        /// 隔震器最大变形_大震_横向 (mm)  1102047
        /// </summary>
        public string Isolation_L_H { get; set; }

        /// <summary>
        /// 隔震器最大变形_大震_横向 (mm)  1102047 数据类别
        /// </summary>
        public string RecordTypeIsolation_L_H { get; set; }

        /// <summary>
        /// 隔震器最大变形_大震_横向 (mm)  1102047 是否必填
        /// </summary>
        public bool? IsRequiredIsolation_L_H { get; set; }

        /// <summary>
        /// 隔震器最大变形_大震_横向 (mm)  1102047 是否公开
        /// </summary>
        public bool? IsPublicIsolation_L_H { get; set; }
        /// <summary>
        /// 隔震器最大变形_大震_纵向 (mm)  1102048
        /// </summary>
        public string Isolation_L_V { get; set; }

        /// <summary>
        /// 隔震器最大变形_大震_纵向 (mm)  1102048 数据类别
        /// </summary>
        public string RecordTypeIsolation_L_V { get; set; }

        /// <summary>
        /// 隔震器最大变形_大震_纵向 (mm)  1102048 是否必填
        /// </summary>
        public bool? IsRequiredIsolation_L_V { get; set; }

        /// <summary>
        /// 隔震器最大变形_大震_纵向 (mm)  1102048 是否公开
        /// </summary>
        public bool? IsPublicIsolation_L_V { get; set; }
        /// <summary>
        /// 基底最大剪力_中震_横向 (kN）  1102049
        /// </summary>
        public string BaseShear_M_H { get; set; }

        /// <summary>
        /// 基底最大剪力_中震_横向 (kN）  1102049 数据类别
        /// </summary>
        public string RecordTypeBaseShear_M_H { get; set; }

        /// <summary>
        /// 基底最大剪力_中震_横向 (kN）  1102049 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_M_H { get; set; }

        /// <summary>
        /// 基底最大剪力_中震_横向 (kN）  1102049 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_M_H { get; set; }
        /// <summary>
        /// 基底最大剪力_中震_纵向 (kN）  1102050
        /// </summary>
        public string BaseShear_M_V { get; set; }

        /// <summary>
        /// 基底最大剪力_中震_纵向 (kN）  1102050 数据类别
        /// </summary>
        public string RecordTypeBaseShear_M_V { get; set; }

        /// <summary>
        /// 基底最大剪力_中震_纵向 (kN）  1102050 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_M_V { get; set; }

        /// <summary>
        /// 基底最大剪力_中震_纵向 (kN）  1102050 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_M_V { get; set; }
        /// <summary>
        /// 基底最大剪力_大震_横向 (kN）  1102051
        /// </summary>
        public string BaseShear_L_H { get; set; }

        /// <summary>
        /// 基底最大剪力_大震_横向 (kN）  1102051 数据类别
        /// </summary>
        public string RecordTypeBaseShear_L_H { get; set; }

        /// <summary>
        /// 基底最大剪力_大震_横向 (kN）  1102051 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_L_H { get; set; }

        /// <summary>
        /// 基底最大剪力_大震_横向 (kN）  1102051 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_L_H { get; set; }
        /// <summary>
        /// 基底最大剪力_大震_纵向 (kN）  1102052
        /// </summary>
        public string BaseShear_L_V { get; set; }

        /// <summary>
        /// 基底最大剪力_大震_纵向 (kN）  1102052 数据类别
        /// </summary>
        public string RecordTypeBaseShear_L_V { get; set; }

        /// <summary>
        /// 基底最大剪力_大震_纵向 (kN）  1102052 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_L_V { get; set; }

        /// <summary>
        /// 基底最大剪力_大震_纵向 (kN）  1102052 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_L_V { get; set; }
        /// <summary>
        /// 屋顶最大相对位移_中震_横向 (mm)  1102053
        /// </summary>
        public string RoofDrift_M_H { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_中震_横向 (mm)  1102053 数据类别
        /// </summary>
        public string RecordTypeRoofDrift_M_H { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_中震_横向 (mm)  1102053 是否必填
        /// </summary>
        public bool? IsRequiredRoofDrift_M_H { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_中震_横向 (mm)  1102053 是否公开
        /// </summary>
        public bool? IsPublicRoofDrift_M_H { get; set; }
        /// <summary>
        /// 屋顶最大相对位移_中震_纵向 (mm)  1102054
        /// </summary>
        public string RoofDrift_M_V { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_中震_纵向 (mm)  1102054 数据类别
        /// </summary>
        public string RecordTypeRoofDrift_M_V { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_中震_纵向 (mm)  1102054 是否必填
        /// </summary>
        public bool? IsRequiredRoofDrift_M_V { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_中震_纵向 (mm)  1102054 是否公开
        /// </summary>
        public bool? IsPublicRoofDrift_M_V { get; set; }
        /// <summary>
        /// 屋顶最大相对位移_大震_横向 (mm)  1102055
        /// </summary>
        public string RoofDrift_L_H { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_大震_横向 (mm)  1102055 数据类别
        /// </summary>
        public string RecordTypeRoofDrift_L_H { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_大震_横向 (mm)  1102055 是否必填
        /// </summary>
        public bool? IsRequiredRoofDrift_L_H { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_大震_横向 (mm)  1102055 是否公开
        /// </summary>
        public bool? IsPublicRoofDrift_L_H { get; set; }
        /// <summary>
        /// 屋顶最大相对位移_大震_纵向 (mm)  1102056
        /// </summary>
        public string RoofDrift_L_V { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_大震_纵向 (mm)  1102056 数据类别
        /// </summary>
        public string RecordTypeRoofDrift_L_V { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_大震_纵向 (mm)  1102056 是否必填
        /// </summary>
        public bool? IsRequiredRoofDrift_L_V { get; set; }

        /// <summary>
        /// 屋顶最大相对位移_大震_纵向 (mm)  1102056 是否公开
        /// </summary>
        public bool? IsPublicRoofDrift_L_V { get; set; }
        /// <summary>
        /// 最大层间相对位移_中震_横向 (mm)  1102057
        /// </summary>
        public string StoreyDrift_M_H { get; set; }

        /// <summary>
        /// 最大层间相对位移_中震_横向 (mm)  1102057 数据类别
        /// </summary>
        public string RecordTypeStoreyDrift_M_H { get; set; }

        /// <summary>
        /// 最大层间相对位移_中震_横向 (mm)  1102057 是否必填
        /// </summary>
        public bool? IsRequiredStoreyDrift_M_H { get; set; }

        /// <summary>
        /// 最大层间相对位移_中震_横向 (mm)  1102057 是否公开
        /// </summary>
        public bool? IsPublicStoreyDrift_M_H { get; set; }
        /// <summary>
        /// 最大层间相对位移_中震_纵向 (mm)  1102058
        /// </summary>
        public string StoreyDrift_M_V { get; set; }

        /// <summary>
        /// 最大层间相对位移_中震_纵向 (mm)  1102058 数据类别
        /// </summary>
        public string RecordTypeStoreyDrift_M_V { get; set; }

        /// <summary>
        /// 最大层间相对位移_中震_纵向 (mm)  1102058 是否必填
        /// </summary>
        public bool? IsRequiredStoreyDrift_M_V { get; set; }

        /// <summary>
        /// 最大层间相对位移_中震_纵向 (mm)  1102058 是否公开
        /// </summary>
        public bool? IsPublicStoreyDrift_M_V { get; set; }
        /// <summary>
        /// 最大层间相对位移_大震_横向 (mm)  1102059
        /// </summary>
        public string StoreyDrift_L_H { get; set; }

        /// <summary>
        /// 最大层间相对位移_大震_横向 (mm)  1102059 数据类别
        /// </summary>
        public string RecordTypeStoreyDrift_L_H { get; set; }

        /// <summary>
        /// 最大层间相对位移_大震_横向 (mm)  1102059 是否必填
        /// </summary>
        public bool? IsRequiredStoreyDrift_L_H { get; set; }

        /// <summary>
        /// 最大层间相对位移_大震_横向 (mm)  1102059 是否公开
        /// </summary>
        public bool? IsPublicStoreyDrift_L_H { get; set; }
        /// <summary>
        /// 最大层间相对位移_大震_纵向 (mm)  1102060
        /// </summary>
        public string StoreyDrift_L_V { get; set; }

        /// <summary>
        /// 最大层间相对位移_大震_纵向 (mm)  1102060 数据类别
        /// </summary>
        public string RecordTypeStoreyDrift_L_V { get; set; }

        /// <summary>
        /// 最大层间相对位移_大震_纵向 (mm)  1102060 是否必填
        /// </summary>
        public bool? IsRequiredStoreyDrift_L_V { get; set; }

        /// <summary>
        /// 最大层间相对位移_大震_纵向 (mm)  1102060 是否公开
        /// </summary>
        public bool? IsPublicStoreyDrift_L_V { get; set; }
        /// <summary>
        /// 最大层间位移角_中震_横向  1102061
        /// </summary>
        public string StoryDriftRatio_M_H { get; set; }

        /// <summary>
        /// 最大层间位移角_中震_横向  1102061 数据类别
        /// </summary>
        public string RecordTypeStoryDriftRatio_M_H { get; set; }

        /// <summary>
        /// 最大层间位移角_中震_横向  1102061 是否必填
        /// </summary>
        public bool? IsRequiredStoryDriftRatio_M_H { get; set; }

        /// <summary>
        /// 最大层间位移角_中震_横向  1102061 是否公开
        /// </summary>
        public bool? IsPublicStoryDriftRatio_M_H { get; set; }
        /// <summary>
        /// 最大层间位移角_中震_纵向  1102062
        /// </summary>
        public string StoryDriftRatio_M_V { get; set; }

        /// <summary>
        /// 最大层间位移角_中震_纵向  1102062 数据类别
        /// </summary>
        public string RecordTypeStoryDriftRatio_M_V { get; set; }

        /// <summary>
        /// 最大层间位移角_中震_纵向  1102062 是否必填
        /// </summary>
        public bool? IsRequiredStoryDriftRatio_M_V { get; set; }

        /// <summary>
        /// 最大层间位移角_中震_纵向  1102062 是否公开
        /// </summary>
        public bool? IsPublicStoryDriftRatio_M_V { get; set; }
        /// <summary>
        /// 最大层间位移角_大震_横向  1102063
        /// </summary>
        public string StoryDriftRatio_L_H { get; set; }

        /// <summary>
        /// 最大层间位移角_大震_横向  1102063 数据类别
        /// </summary>
        public string RecordTypeStoryDriftRatio_L_H { get; set; }

        /// <summary>
        /// 最大层间位移角_大震_横向  1102063 是否必填
        /// </summary>
        public bool? IsRequiredStoryDriftRatio_L_H { get; set; }

        /// <summary>
        /// 最大层间位移角_大震_横向  1102063 是否公开
        /// </summary>
        public bool? IsPublicStoryDriftRatio_L_H { get; set; }
        /// <summary>
        /// 最大层间位移角_大震_纵向  1102064
        /// </summary>
        public string StoryDriftRatio_L_V { get; set; }

        /// <summary>
        /// 最大层间位移角_大震_纵向  1102064 数据类别
        /// </summary>
        public string RecordTypeStoryDriftRatio_L_V { get; set; }

        /// <summary>
        /// 最大层间位移角_大震_纵向  1102064 是否必填
        /// </summary>
        public bool? IsRequiredStoryDriftRatio_L_V { get; set; }

        /// <summary>
        /// 最大层间位移角_大震_纵向  1102064 是否公开
        /// </summary>
        public bool? IsPublicStoryDriftRatio_L_V { get; set; }
        /// <summary>
        /// 最大反应加速度_中震_横向 (g)  1102065
        /// </summary>
        public string Acceleration_M_H { get; set; }

        /// <summary>
        /// 最大反应加速度_中震_横向 (g)  1102065 数据类别
        /// </summary>
        public string RecordTypeAcceleration_M_H { get; set; }

        /// <summary>
        /// 最大反应加速度_中震_横向 (g)  1102065 是否必填
        /// </summary>
        public bool? IsRequiredAcceleration_M_H { get; set; }

        /// <summary>
        /// 最大反应加速度_中震_横向 (g)  1102065 是否公开
        /// </summary>
        public bool? IsPublicAcceleration_M_H { get; set; }
        /// <summary>
        /// 最大反应加速度_中震_纵向 (g)  1102066
        /// </summary>
        public string Acceleration_M_V { get; set; }

        /// <summary>
        /// 最大反应加速度_中震_纵向 (g)  1102066 数据类别
        /// </summary>
        public string RecordTypeAcceleration_M_V { get; set; }

        /// <summary>
        /// 最大反应加速度_中震_纵向 (g)  1102066 是否必填
        /// </summary>
        public bool? IsRequiredAcceleration_M_V { get; set; }

        /// <summary>
        /// 最大反应加速度_中震_纵向 (g)  1102066 是否公开
        /// </summary>
        public bool? IsPublicAcceleration_M_V { get; set; }
        /// <summary>
        /// 最大反应加速度_大震_横向 (g)  1102067
        /// </summary>
        public string Acceleration_L_H { get; set; }

        /// <summary>
        /// 最大反应加速度_大震_横向 (g)  1102067 数据类别
        /// </summary>
        public string RecordTypeAcceleration_L_H { get; set; }

        /// <summary>
        /// 最大反应加速度_大震_横向 (g)  1102067 是否必填
        /// </summary>
        public bool? IsRequiredAcceleration_L_H { get; set; }

        /// <summary>
        /// 最大反应加速度_大震_横向 (g)  1102067 是否公开
        /// </summary>
        public bool? IsPublicAcceleration_L_H { get; set; }
        /// <summary>
        /// 最大反应加速度_大震_纵向 (g)  1102068
        /// </summary>
        public string Acceleration_L_V { get; set; }

        /// <summary>
        /// 最大反应加速度_大震_纵向 (g)  1102068 数据类别
        /// </summary>
        public string RecordTypeAcceleration_L_V { get; set; }

        /// <summary>
        /// 最大反应加速度_大震_纵向 (g)  1102068 是否必填
        /// </summary>
        public bool? IsRequiredAcceleration_L_V { get; set; }

        /// <summary>
        /// 最大反应加速度_大震_纵向 (g)  1102068 是否公开
        /// </summary>
        public bool? IsPublicAcceleration_L_V { get; set; }
        /// <summary>
        /// 生产企业_隔震支座  1102069
        /// </summary>
        public string Manufacturer_IsolationBearing { get; set; }

        /// <summary>
        /// 生产企业_隔震支座  1102069 数据类别
        /// </summary>
        public string RecordTypeManufacturer_IsolationBearing { get; set; }

        /// <summary>
        /// 生产企业_隔震支座  1102069 是否必填
        /// </summary>
        public bool? IsRequiredManufacturer_IsolationBearing { get; set; }

        /// <summary>
        /// 生产企业_隔震支座  1102069 是否公开
        /// </summary>
        public bool? IsPublicManufacturer_IsolationBearing { get; set; }
        /// <summary>
        /// 生产企业_阻尼器  1102070
        /// </summary>
        public string Manufacturer_Damper { get; set; }

        /// <summary>
        /// 生产企业_阻尼器  1102070 数据类别
        /// </summary>
        public string RecordTypeManufacturer_Damper { get; set; }

        /// <summary>
        /// 生产企业_阻尼器  1102070 是否必填
        /// </summary>
        public bool? IsRequiredManufacturer_Damper { get; set; }

        /// <summary>
        /// 生产企业_阻尼器  1102070 是否公开
        /// </summary>
        public bool? IsPublicManufacturer_Damper { get; set; }
        /// <summary>
        /// 隔震支座_型号1  1102071
        /// </summary>
        public string Bearing_Model1 { get; set; }

        /// <summary>
        /// 隔震支座_型号1  1102071 数据类别
        /// </summary>
        public string RecordTypeBearing_Model1 { get; set; }

        /// <summary>
        /// 隔震支座_型号1  1102071 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Model1 { get; set; }

        /// <summary>
        /// 隔震支座_型号1  1102071 是否公开
        /// </summary>
        public bool? IsPublicBearing_Model1 { get; set; }
        /// <summary>
        /// 隔震支座_个数1  1102072
        /// </summary>
        public string Bearing_Number1 { get; set; }

        /// <summary>
        /// 隔震支座_个数1  1102072 数据类别
        /// </summary>
        public string RecordTypeBearing_Number1 { get; set; }

        /// <summary>
        /// 隔震支座_个数1  1102072 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Number1 { get; set; }

        /// <summary>
        /// 隔震支座_个数1  1102072 是否公开
        /// </summary>
        public bool? IsPublicBearing_Number1 { get; set; }
        /// <summary>
        /// 隔震支座_有效直径(mm)1  1102073
        /// </summary>
        public string Bearing_EffectiveDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)1  1102073 数据类别
        /// </summary>
        public string RecordTypeBearing_EffectiveDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)1  1102073 是否必填
        /// </summary>
        public bool? IsRequiredBearing_EffectiveDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)1  1102073 是否公开
        /// </summary>
        public bool? IsPublicBearing_EffectiveDiameter1 { get; set; }
        /// <summary>
        /// 隔震支座_铅芯直径(mm)1  1102074
        /// </summary>
        public string Bearing_LeadDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)1  1102074 数据类别
        /// </summary>
        public string RecordTypeBearing_LeadDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)1  1102074 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LeadDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)1  1102074 是否公开
        /// </summary>
        public bool? IsPublicBearing_LeadDiameter1 { get; set; }
        /// <summary>
        /// 隔震支座_产品外径(mm)1  1102075
        /// </summary>
        public string Bearing_OutsideDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)1  1102075 数据类别
        /// </summary>
        public string RecordTypeBearing_OutsideDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)1  1102075 是否必填
        /// </summary>
        public bool? IsRequiredBearing_OutsideDiameter1 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)1  1102075 是否公开
        /// </summary>
        public bool? IsPublicBearing_OutsideDiameter1 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)1  1102076
        /// </summary>
        public string Bearing_RubberThickness1 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)1  1102076 数据类别
        /// </summary>
        public string RecordTypeBearing_RubberThickness1 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)1  1102076 是否必填
        /// </summary>
        public bool? IsRequiredBearing_RubberThickness1 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)1  1102076 是否公开
        /// </summary>
        public bool? IsPublicBearing_RubberThickness1 { get; set; }
        /// <summary>
        /// 隔震支座_一次形状系数1  1102077
        /// </summary>
        public string Bearing_LinearShapeFactor1 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数1  1102077 数据类别
        /// </summary>
        public string RecordTypeBearing_LinearShapeFactor1 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数1  1102077 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LinearShapeFactor1 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数1  1102077 是否公开
        /// </summary>
        public bool? IsPublicBearing_LinearShapeFactor1 { get; set; }
        /// <summary>
        /// 隔震支座_二次形状系数1  1102078
        /// </summary>
        public string Bearing_QuadraticShapeFactor1 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数1  1102078 数据类别
        /// </summary>
        public string RecordTypeBearing_QuadraticShapeFactor1 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数1  1102078 是否必填
        /// </summary>
        public bool? IsRequiredBearing_QuadraticShapeFactor1 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数1  1102078 是否公开
        /// </summary>
        public bool? IsPublicBearing_QuadraticShapeFactor1 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)1  1102079
        /// </summary>
        public string Bearing_ShearModulus1 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)1  1102079 数据类别
        /// </summary>
        public string RecordTypeBearing_ShearModulus1 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)1  1102079 是否必填
        /// </summary>
        public bool? IsRequiredBearing_ShearModulus1 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)1  1102079 是否公开
        /// </summary>
        public bool? IsPublicBearing_ShearModulus1 { get; set; }
        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)1  1102080
        /// </summary>
        public string Bearing_VerticalStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)1  1102080 数据类别
        /// </summary>
        public string RecordTypeBearing_VerticalStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)1  1102080 是否必填
        /// </summary>
        public bool? IsRequiredBearing_VerticalStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)1  1102080 是否公开
        /// </summary>
        public bool? IsPublicBearing_VerticalStiffness1 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)1  1102081
        /// </summary>
        public string Bearing_HorizontalStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)1  1102081 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)1  1102081 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)1  1102081 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness1 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)1  1102082
        /// </summary>
        public string Bearing_HorizontalStiffness_Times1 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)1  1102082 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness_Times1 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)1  1102082 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness_Times1 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)1  1102082 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness_Times1 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)1  1102083
        /// </summary>
        public string Bearing_DampingRatio1 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)1  1102083 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio1 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)1  1102083 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio1 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)1  1102083 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio1 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)1  1102084
        /// </summary>
        public string Bearing_DampingRatio_Times1 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)1  1102084 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio_Times1 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)1  1102084 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio_Times1 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)1  1102084 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio_Times1 { get; set; }
        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)1  1102085
        /// </summary>
        public string Bearing_YieldStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)1  1102085 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)1  1102085 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStiffness1 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)1  1102085 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStiffness1 { get; set; }
        /// <summary>
        /// 隔震支座_屈服力Qd(kN)1  1102086
        /// </summary>
        public string Bearing_YieldStress1 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)1  1102086 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStress1 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)1  1102086 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStress1 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)1  1102086 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStress1 { get; set; }
        /// <summary>
        /// 隔震支座_型号2  1102087
        /// </summary>
        public string Bearing_Model2 { get; set; }

        /// <summary>
        /// 隔震支座_型号2  1102087 数据类别
        /// </summary>
        public string RecordTypeBearing_Model2 { get; set; }

        /// <summary>
        /// 隔震支座_型号2  1102087 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Model2 { get; set; }

        /// <summary>
        /// 隔震支座_型号2  1102087 是否公开
        /// </summary>
        public bool? IsPublicBearing_Model2 { get; set; }
        /// <summary>
        /// 隔震支座_个数2  1102088
        /// </summary>
        public string Bearing_Number2 { get; set; }

        /// <summary>
        /// 隔震支座_个数2  1102088 数据类别
        /// </summary>
        public string RecordTypeBearing_Number2 { get; set; }

        /// <summary>
        /// 隔震支座_个数2  1102088 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Number2 { get; set; }

        /// <summary>
        /// 隔震支座_个数2  1102088 是否公开
        /// </summary>
        public bool? IsPublicBearing_Number2 { get; set; }
        /// <summary>
        /// 隔震支座_有效直径(mm)2  1102089
        /// </summary>
        public string Bearing_EffectiveDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)2  1102089 数据类别
        /// </summary>
        public string RecordTypeBearing_EffectiveDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)2  1102089 是否必填
        /// </summary>
        public bool? IsRequiredBearing_EffectiveDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)2  1102089 是否公开
        /// </summary>
        public bool? IsPublicBearing_EffectiveDiameter2 { get; set; }
        /// <summary>
        /// 隔震支座_铅芯直径(mm)2  1102090
        /// </summary>
        public string Bearing_LeadDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)2  1102090 数据类别
        /// </summary>
        public string RecordTypeBearing_LeadDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)2  1102090 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LeadDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)2  1102090 是否公开
        /// </summary>
        public bool? IsPublicBearing_LeadDiameter2 { get; set; }
        /// <summary>
        /// 隔震支座_产品外径(mm)2  1102091
        /// </summary>
        public string Bearing_OutsideDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)2  1102091 数据类别
        /// </summary>
        public string RecordTypeBearing_OutsideDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)2  1102091 是否必填
        /// </summary>
        public bool? IsRequiredBearing_OutsideDiameter2 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)2  1102091 是否公开
        /// </summary>
        public bool? IsPublicBearing_OutsideDiameter2 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)2  1102092
        /// </summary>
        public string Bearing_RubberThickness2 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)2  1102092 数据类别
        /// </summary>
        public string RecordTypeBearing_RubberThickness2 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)2  1102092 是否必填
        /// </summary>
        public bool? IsRequiredBearing_RubberThickness2 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)2  1102092 是否公开
        /// </summary>
        public bool? IsPublicBearing_RubberThickness2 { get; set; }
        /// <summary>
        /// 隔震支座_一次形状系数2  1102093
        /// </summary>
        public string Bearing_LinearShapeFactor2 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数2  1102093 数据类别
        /// </summary>
        public string RecordTypeBearing_LinearShapeFactor2 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数2  1102093 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LinearShapeFactor2 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数2  1102093 是否公开
        /// </summary>
        public bool? IsPublicBearing_LinearShapeFactor2 { get; set; }
        /// <summary>
        /// 隔震支座_二次形状系数2  1102094
        /// </summary>
        public string Bearing_QuadraticShapeFactor2 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数2  1102094 数据类别
        /// </summary>
        public string RecordTypeBearing_QuadraticShapeFactor2 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数2  1102094 是否必填
        /// </summary>
        public bool? IsRequiredBearing_QuadraticShapeFactor2 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数2  1102094 是否公开
        /// </summary>
        public bool? IsPublicBearing_QuadraticShapeFactor2 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)2  1102095
        /// </summary>
        public string Bearing_ShearModulus2 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)2  1102095 数据类别
        /// </summary>
        public string RecordTypeBearing_ShearModulus2 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)2  1102095 是否必填
        /// </summary>
        public bool? IsRequiredBearing_ShearModulus2 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)2  1102095 是否公开
        /// </summary>
        public bool? IsPublicBearing_ShearModulus2 { get; set; }
        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)2  1102096
        /// </summary>
        public string Bearing_VerticalStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)2  1102096 数据类别
        /// </summary>
        public string RecordTypeBearing_VerticalStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)2  1102096 是否必填
        /// </summary>
        public bool? IsRequiredBearing_VerticalStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)2  1102096 是否公开
        /// </summary>
        public bool? IsPublicBearing_VerticalStiffness2 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)2  1102097
        /// </summary>
        public string Bearing_HorizontalStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)2  1102097 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)2  1102097 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)2  1102097 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness2 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)2  1102098
        /// </summary>
        public string Bearing_HorizontalStiffness_Times2 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)2  1102098 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness_Times2 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)2  1102098 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness_Times2 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)2  1102098 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness_Times2 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)2  1102099
        /// </summary>
        public string Bearing_DampingRatio2 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)2  1102099 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio2 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)2  1102099 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio2 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)2  1102099 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio2 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)2  1102100
        /// </summary>
        public string Bearing_DampingRatio_Times2 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)2  1102100 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio_Times2 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)2  1102100 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio_Times2 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)2  1102100 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio_Times2 { get; set; }
        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)2  1102101
        /// </summary>
        public string Bearing_YieldStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)2  1102101 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)2  1102101 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStiffness2 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)2  1102101 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStiffness2 { get; set; }
        /// <summary>
        /// 隔震支座_屈服力Qd(kN)2  1102102
        /// </summary>
        public string Bearing_YieldStress2 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)2  1102102 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStress2 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)2  1102102 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStress2 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)2  1102102 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStress2 { get; set; }
        /// <summary>
        /// 隔震支座_型号3  1102103
        /// </summary>
        public string Bearing_Model3 { get; set; }

        /// <summary>
        /// 隔震支座_型号3  1102103 数据类别
        /// </summary>
        public string RecordTypeBearing_Model3 { get; set; }

        /// <summary>
        /// 隔震支座_型号3  1102103 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Model3 { get; set; }

        /// <summary>
        /// 隔震支座_型号3  1102103 是否公开
        /// </summary>
        public bool? IsPublicBearing_Model3 { get; set; }
        /// <summary>
        /// 隔震支座_个数3  1102104
        /// </summary>
        public string Bearing_Number3 { get; set; }

        /// <summary>
        /// 隔震支座_个数3  1102104 数据类别
        /// </summary>
        public string RecordTypeBearing_Number3 { get; set; }

        /// <summary>
        /// 隔震支座_个数3  1102104 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Number3 { get; set; }

        /// <summary>
        /// 隔震支座_个数3  1102104 是否公开
        /// </summary>
        public bool? IsPublicBearing_Number3 { get; set; }
        /// <summary>
        /// 隔震支座_有效直径(mm)3  1102105
        /// </summary>
        public string Bearing_EffectiveDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)3  1102105 数据类别
        /// </summary>
        public string RecordTypeBearing_EffectiveDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)3  1102105 是否必填
        /// </summary>
        public bool? IsRequiredBearing_EffectiveDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)3  1102105 是否公开
        /// </summary>
        public bool? IsPublicBearing_EffectiveDiameter3 { get; set; }
        /// <summary>
        /// 隔震支座_铅芯直径(mm)3  1102106
        /// </summary>
        public string Bearing_LeadDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)3  1102106 数据类别
        /// </summary>
        public string RecordTypeBearing_LeadDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)3  1102106 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LeadDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)3  1102106 是否公开
        /// </summary>
        public bool? IsPublicBearing_LeadDiameter3 { get; set; }
        /// <summary>
        /// 隔震支座_产品外径(mm)3  1102107
        /// </summary>
        public string Bearing_OutsideDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)3  1102107 数据类别
        /// </summary>
        public string RecordTypeBearing_OutsideDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)3  1102107 是否必填
        /// </summary>
        public bool? IsRequiredBearing_OutsideDiameter3 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)3  1102107 是否公开
        /// </summary>
        public bool? IsPublicBearing_OutsideDiameter3 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)3  1102108
        /// </summary>
        public string Bearing_RubberThickness3 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)3  1102108 数据类别
        /// </summary>
        public string RecordTypeBearing_RubberThickness3 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)3  1102108 是否必填
        /// </summary>
        public bool? IsRequiredBearing_RubberThickness3 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)3  1102108 是否公开
        /// </summary>
        public bool? IsPublicBearing_RubberThickness3 { get; set; }
        /// <summary>
        /// 隔震支座_一次形状系数3  1102109
        /// </summary>
        public string Bearing_LinearShapeFactor3 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数3  1102109 数据类别
        /// </summary>
        public string RecordTypeBearing_LinearShapeFactor3 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数3  1102109 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LinearShapeFactor3 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数3  1102109 是否公开
        /// </summary>
        public bool? IsPublicBearing_LinearShapeFactor3 { get; set; }
        /// <summary>
        /// 隔震支座_二次形状系数3  1102110
        /// </summary>
        public string Bearing_QuadraticShapeFactor3 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数3  1102110 数据类别
        /// </summary>
        public string RecordTypeBearing_QuadraticShapeFactor3 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数3  1102110 是否必填
        /// </summary>
        public bool? IsRequiredBearing_QuadraticShapeFactor3 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数3  1102110 是否公开
        /// </summary>
        public bool? IsPublicBearing_QuadraticShapeFactor3 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)3  1102111
        /// </summary>
        public string Bearing_ShearModulus3 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)3  1102111 数据类别
        /// </summary>
        public string RecordTypeBearing_ShearModulus3 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)3  1102111 是否必填
        /// </summary>
        public bool? IsRequiredBearing_ShearModulus3 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)3  1102111 是否公开
        /// </summary>
        public bool? IsPublicBearing_ShearModulus3 { get; set; }
        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)3  1102112
        /// </summary>
        public string Bearing_VerticalStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)3  1102112 数据类别
        /// </summary>
        public string RecordTypeBearing_VerticalStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)3  1102112 是否必填
        /// </summary>
        public bool? IsRequiredBearing_VerticalStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)3  1102112 是否公开
        /// </summary>
        public bool? IsPublicBearing_VerticalStiffness3 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)3  1102113
        /// </summary>
        public string Bearing_HorizontalStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)3  1102113 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)3  1102113 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)3  1102113 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness3 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)3  1102114
        /// </summary>
        public string Bearing_HorizontalStiffness_Times3 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)3  1102114 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness_Times3 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)3  1102114 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness_Times3 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)3  1102114 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness_Times3 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)3  1102115
        /// </summary>
        public string Bearing_DampingRatio3 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)3  1102115 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio3 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)3  1102115 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio3 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)3  1102115 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio3 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)3  1102116
        /// </summary>
        public string Bearing_DampingRatio_Times3 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)3  1102116 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio_Times3 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)3  1102116 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio_Times3 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)3  1102116 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio_Times3 { get; set; }
        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)3  1102117
        /// </summary>
        public string Bearing_YieldStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)3  1102117 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)3  1102117 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStiffness3 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)3  1102117 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStiffness3 { get; set; }
        /// <summary>
        /// 隔震支座_屈服力Qd(kN)3  1102118
        /// </summary>
        public string Bearing_YieldStress3 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)3  1102118 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStress3 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)3  1102118 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStress3 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)3  1102118 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStress3 { get; set; }
        /// <summary>
        /// 隔震支座_型号4  1102119
        /// </summary>
        public string Bearing_Model4 { get; set; }

        /// <summary>
        /// 隔震支座_型号4  1102119 数据类别
        /// </summary>
        public string RecordTypeBearing_Model4 { get; set; }

        /// <summary>
        /// 隔震支座_型号4  1102119 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Model4 { get; set; }

        /// <summary>
        /// 隔震支座_型号4  1102119 是否公开
        /// </summary>
        public bool? IsPublicBearing_Model4 { get; set; }
        /// <summary>
        /// 隔震支座_个数4  1102120
        /// </summary>
        public string Bearing_Number4 { get; set; }

        /// <summary>
        /// 隔震支座_个数4  1102120 数据类别
        /// </summary>
        public string RecordTypeBearing_Number4 { get; set; }

        /// <summary>
        /// 隔震支座_个数4  1102120 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Number4 { get; set; }

        /// <summary>
        /// 隔震支座_个数4  1102120 是否公开
        /// </summary>
        public bool? IsPublicBearing_Number4 { get; set; }
        /// <summary>
        /// 隔震支座_有效直径(mm)4  1102121
        /// </summary>
        public string Bearing_EffectiveDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)4  1102121 数据类别
        /// </summary>
        public string RecordTypeBearing_EffectiveDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)4  1102121 是否必填
        /// </summary>
        public bool? IsRequiredBearing_EffectiveDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)4  1102121 是否公开
        /// </summary>
        public bool? IsPublicBearing_EffectiveDiameter4 { get; set; }
        /// <summary>
        /// 隔震支座_铅芯直径(mm)4  1102122
        /// </summary>
        public string Bearing_LeadDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)4  1102122 数据类别
        /// </summary>
        public string RecordTypeBearing_LeadDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)4  1102122 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LeadDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)4  1102122 是否公开
        /// </summary>
        public bool? IsPublicBearing_LeadDiameter4 { get; set; }
        /// <summary>
        /// 隔震支座_产品外径(mm)4  1102123
        /// </summary>
        public string Bearing_OutsideDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)4  1102123 数据类别
        /// </summary>
        public string RecordTypeBearing_OutsideDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)4  1102123 是否必填
        /// </summary>
        public bool? IsRequiredBearing_OutsideDiameter4 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)4  1102123 是否公开
        /// </summary>
        public bool? IsPublicBearing_OutsideDiameter4 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)4  1102124
        /// </summary>
        public string Bearing_RubberThickness4 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)4  1102124 数据类别
        /// </summary>
        public string RecordTypeBearing_RubberThickness4 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)4  1102124 是否必填
        /// </summary>
        public bool? IsRequiredBearing_RubberThickness4 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)4  1102124 是否公开
        /// </summary>
        public bool? IsPublicBearing_RubberThickness4 { get; set; }
        /// <summary>
        /// 隔震支座_一次形状系数4  1102125
        /// </summary>
        public string Bearing_LinearShapeFactor4 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数4  1102125 数据类别
        /// </summary>
        public string RecordTypeBearing_LinearShapeFactor4 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数4  1102125 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LinearShapeFactor4 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数4  1102125 是否公开
        /// </summary>
        public bool? IsPublicBearing_LinearShapeFactor4 { get; set; }
        /// <summary>
        /// 隔震支座_二次形状系数4  1102126
        /// </summary>
        public string Bearing_QuadraticShapeFactor4 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数4  1102126 数据类别
        /// </summary>
        public string RecordTypeBearing_QuadraticShapeFactor4 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数4  1102126 是否必填
        /// </summary>
        public bool? IsRequiredBearing_QuadraticShapeFactor4 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数4  1102126 是否公开
        /// </summary>
        public bool? IsPublicBearing_QuadraticShapeFactor4 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)4  1102127
        /// </summary>
        public string Bearing_ShearModulus4 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)4  1102127 数据类别
        /// </summary>
        public string RecordTypeBearing_ShearModulus4 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)4  1102127 是否必填
        /// </summary>
        public bool? IsRequiredBearing_ShearModulus4 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)4  1102127 是否公开
        /// </summary>
        public bool? IsPublicBearing_ShearModulus4 { get; set; }
        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)4  1102128
        /// </summary>
        public string Bearing_VerticalStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)4  1102128 数据类别
        /// </summary>
        public string RecordTypeBearing_VerticalStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)4  1102128 是否必填
        /// </summary>
        public bool? IsRequiredBearing_VerticalStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)4  1102128 是否公开
        /// </summary>
        public bool? IsPublicBearing_VerticalStiffness4 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)4  1102129
        /// </summary>
        public string Bearing_HorizontalStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)4  1102129 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)4  1102129 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)4  1102129 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness4 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)4  1102130
        /// </summary>
        public string Bearing_HorizontalStiffness_Times4 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)4  1102130 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness_Times4 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)4  1102130 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness_Times4 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)4  1102130 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness_Times4 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)4  1102131
        /// </summary>
        public string Bearing_DampingRatio4 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)4  1102131 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio4 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)4  1102131 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio4 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)4  1102131 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio4 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)4  1102132
        /// </summary>
        public string Bearing_DampingRatio_Times4 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)4  1102132 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio_Times4 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)4  1102132 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio_Times4 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)4  1102132 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio_Times4 { get; set; }
        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)4  1102133
        /// </summary>
        public string Bearing_YieldStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)4  1102133 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)4  1102133 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStiffness4 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)4  1102133 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStiffness4 { get; set; }
        /// <summary>
        /// 隔震支座_屈服力Qd(kN)4  1102134
        /// </summary>
        public string Bearing_YieldStress4 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)4  1102134 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStress4 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)4  1102134 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStress4 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)4  1102134 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStress4 { get; set; }
        /// <summary>
        /// 隔震支座_型号5  1102135
        /// </summary>
        public string Bearing_Model5 { get; set; }

        /// <summary>
        /// 隔震支座_型号5  1102135 数据类别
        /// </summary>
        public string RecordTypeBearing_Model5 { get; set; }

        /// <summary>
        /// 隔震支座_型号5  1102135 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Model5 { get; set; }

        /// <summary>
        /// 隔震支座_型号5  1102135 是否公开
        /// </summary>
        public bool? IsPublicBearing_Model5 { get; set; }
        /// <summary>
        /// 隔震支座_个数5  1102136
        /// </summary>
        public string Bearing_Number5 { get; set; }

        /// <summary>
        /// 隔震支座_个数5  1102136 数据类别
        /// </summary>
        public string RecordTypeBearing_Number5 { get; set; }

        /// <summary>
        /// 隔震支座_个数5  1102136 是否必填
        /// </summary>
        public bool? IsRequiredBearing_Number5 { get; set; }

        /// <summary>
        /// 隔震支座_个数5  1102136 是否公开
        /// </summary>
        public bool? IsPublicBearing_Number5 { get; set; }
        /// <summary>
        /// 隔震支座_有效直径(mm)5  1102137
        /// </summary>
        public string Bearing_EffectiveDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)5  1102137 数据类别
        /// </summary>
        public string RecordTypeBearing_EffectiveDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)5  1102137 是否必填
        /// </summary>
        public bool? IsRequiredBearing_EffectiveDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_有效直径(mm)5  1102137 是否公开
        /// </summary>
        public bool? IsPublicBearing_EffectiveDiameter5 { get; set; }
        /// <summary>
        /// 隔震支座_铅芯直径(mm)5  1102138
        /// </summary>
        public string Bearing_LeadDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)5  1102138 数据类别
        /// </summary>
        public string RecordTypeBearing_LeadDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)5  1102138 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LeadDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_铅芯直径(mm)5  1102138 是否公开
        /// </summary>
        public bool? IsPublicBearing_LeadDiameter5 { get; set; }
        /// <summary>
        /// 隔震支座_产品外径(mm)5  1102139
        /// </summary>
        public string Bearing_OutsideDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)5  1102139 数据类别
        /// </summary>
        public string RecordTypeBearing_OutsideDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)5  1102139 是否必填
        /// </summary>
        public bool? IsRequiredBearing_OutsideDiameter5 { get; set; }

        /// <summary>
        /// 隔震支座_产品外径(mm)5  1102139 是否公开
        /// </summary>
        public bool? IsPublicBearing_OutsideDiameter5 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)5  1102140
        /// </summary>
        public string Bearing_RubberThickness5 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)5  1102140 数据类别
        /// </summary>
        public string RecordTypeBearing_RubberThickness5 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)5  1102140 是否必填
        /// </summary>
        public bool? IsRequiredBearing_RubberThickness5 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶层总厚度(mm)5  1102140 是否公开
        /// </summary>
        public bool? IsPublicBearing_RubberThickness5 { get; set; }
        /// <summary>
        /// 隔震支座_一次形状系数5  1102141
        /// </summary>
        public string Bearing_LinearShapeFactor5 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数5  1102141 数据类别
        /// </summary>
        public string RecordTypeBearing_LinearShapeFactor5 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数5  1102141 是否必填
        /// </summary>
        public bool? IsRequiredBearing_LinearShapeFactor5 { get; set; }

        /// <summary>
        /// 隔震支座_一次形状系数5  1102141 是否公开
        /// </summary>
        public bool? IsPublicBearing_LinearShapeFactor5 { get; set; }
        /// <summary>
        /// 隔震支座_二次形状系数5  1102142
        /// </summary>
        public string Bearing_QuadraticShapeFactor5 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数5  1102142 数据类别
        /// </summary>
        public string RecordTypeBearing_QuadraticShapeFactor5 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数5  1102142 是否必填
        /// </summary>
        public bool? IsRequiredBearing_QuadraticShapeFactor5 { get; set; }

        /// <summary>
        /// 隔震支座_二次形状系数5  1102142 是否公开
        /// </summary>
        public bool? IsPublicBearing_QuadraticShapeFactor5 { get; set; }
        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)5  1102143
        /// </summary>
        public string Bearing_ShearModulus5 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)5  1102143 数据类别
        /// </summary>
        public string RecordTypeBearing_ShearModulus5 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)5  1102143 是否必填
        /// </summary>
        public bool? IsRequiredBearing_ShearModulus5 { get; set; }

        /// <summary>
        /// 隔震支座_橡胶剪切弹性模量 (N/m㎡)5  1102143 是否公开
        /// </summary>
        public bool? IsPublicBearing_ShearModulus5 { get; set; }
        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)5  1102144
        /// </summary>
        public string Bearing_VerticalStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)5  1102144 数据类别
        /// </summary>
        public string RecordTypeBearing_VerticalStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)5  1102144 是否必填
        /// </summary>
        public bool? IsRequiredBearing_VerticalStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_竖向刚度 (kN/mm)5  1102144 是否公开
        /// </summary>
        public bool? IsPublicBearing_VerticalStiffness5 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)5  1102145
        /// </summary>
        public string Bearing_HorizontalStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)5  1102145 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)5  1102145 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_100%水平性能(kN/mm)5  1102145 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness5 { get; set; }
        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)5  1102146
        /// </summary>
        public string Bearing_HorizontalStiffness_Times5 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)5  1102146 数据类别
        /// </summary>
        public string RecordTypeBearing_HorizontalStiffness_Times5 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)5  1102146 是否必填
        /// </summary>
        public bool? IsRequiredBearing_HorizontalStiffness_Times5 { get; set; }

        /// <summary>
        /// 隔震支座_等效水平刚度_250%水平性能(kN/mm)5  1102146 是否公开
        /// </summary>
        public bool? IsPublicBearing_HorizontalStiffness_Times5 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)5  1102147
        /// </summary>
        public string Bearing_DampingRatio5 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)5  1102147 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio5 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)5  1102147 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio5 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_100%水平性能 (%)5  1102147 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio5 { get; set; }
        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)5  1102148
        /// </summary>
        public string Bearing_DampingRatio_Times5 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)5  1102148 数据类别
        /// </summary>
        public string RecordTypeBearing_DampingRatio_Times5 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)5  1102148 是否必填
        /// </summary>
        public bool? IsRequiredBearing_DampingRatio_Times5 { get; set; }

        /// <summary>
        /// 隔震支座_等效阻尼比_250%水平性能 (%)5  1102148 是否公开
        /// </summary>
        public bool? IsPublicBearing_DampingRatio_Times5 { get; set; }
        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)5  1102149
        /// </summary>
        public string Bearing_YieldStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)5  1102149 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)5  1102149 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStiffness5 { get; set; }

        /// <summary>
        /// 隔震支座_屈服后刚度Kd(kN/m)5  1102149 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStiffness5 { get; set; }
        /// <summary>
        /// 隔震支座_屈服力Qd(kN)5  1102150
        /// </summary>
        public string Bearing_YieldStress5 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)5  1102150 数据类别
        /// </summary>
        public string RecordTypeBearing_YieldStress5 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)5  1102150 是否必填
        /// </summary>
        public bool? IsRequiredBearing_YieldStress5 { get; set; }

        /// <summary>
        /// 隔震支座_屈服力Qd(kN)5  1102150 是否公开
        /// </summary>
        public bool? IsPublicBearing_YieldStress5 { get; set; }
        /// <summary>
        /// 阻尼器_型号1  1102151
        /// </summary>
        public string Damper_Model1 { get; set; }

        /// <summary>
        /// 阻尼器_型号1  1102151 数据类别
        /// </summary>
        public string RecordTypeDamper_Model1 { get; set; }

        /// <summary>
        /// 阻尼器_型号1  1102151 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Model1 { get; set; }

        /// <summary>
        /// 阻尼器_型号1  1102151 是否公开
        /// </summary>
        public bool? IsPublicDamper_Model1 { get; set; }
        /// <summary>
        /// 阻尼器_个数1  1102152
        /// </summary>
        public string Damper_Number1 { get; set; }

        /// <summary>
        /// 阻尼器_个数1  1102152 数据类别
        /// </summary>
        public string RecordTypeDamper_Number1 { get; set; }

        /// <summary>
        /// 阻尼器_个数1  1102152 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Number1 { get; set; }

        /// <summary>
        /// 阻尼器_个数1  1102152 是否公开
        /// </summary>
        public bool? IsPublicDamper_Number1 { get; set; }
        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)1  1102153
        /// </summary>
        public string Damper_MaxCapacity1 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)1  1102153 数据类别
        /// </summary>
        public string RecordTypeDamper_MaxCapacity1 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)1  1102153 是否必填
        /// </summary>
        public bool? IsRequiredDamper_MaxCapacity1 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)1  1102153 是否公开
        /// </summary>
        public bool? IsPublicDamper_MaxCapacity1 { get; set; }
        /// <summary>
        /// 阻尼器_阻尼系数C1  1102154
        /// </summary>
        public string Damper_Coefficient1 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C1  1102154 数据类别
        /// </summary>
        public string RecordTypeDamper_Coefficient1 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C1  1102154 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Coefficient1 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C1  1102154 是否公开
        /// </summary>
        public bool? IsPublicDamper_Coefficient1 { get; set; }
        /// <summary>
        /// 阻尼器_速度指数α1  1102155
        /// </summary>
        public string Damper_VelocityIndex1 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α1  1102155 数据类别
        /// </summary>
        public string RecordTypeDamper_VelocityIndex1 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α1  1102155 是否必填
        /// </summary>
        public bool? IsRequiredDamper_VelocityIndex1 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α1  1102155 是否公开
        /// </summary>
        public bool? IsPublicDamper_VelocityIndex1 { get; set; }
        /// <summary>
        /// 阻尼器_型号2  1102156
        /// </summary>
        public string Damper_Model2 { get; set; }

        /// <summary>
        /// 阻尼器_型号2  1102156 数据类别
        /// </summary>
        public string RecordTypeDamper_Model2 { get; set; }

        /// <summary>
        /// 阻尼器_型号2  1102156 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Model2 { get; set; }

        /// <summary>
        /// 阻尼器_型号2  1102156 是否公开
        /// </summary>
        public bool? IsPublicDamper_Model2 { get; set; }
        /// <summary>
        /// 阻尼器_个数2  1102157
        /// </summary>
        public string Damper_Number2 { get; set; }

        /// <summary>
        /// 阻尼器_个数2  1102157 数据类别
        /// </summary>
        public string RecordTypeDamper_Number2 { get; set; }

        /// <summary>
        /// 阻尼器_个数2  1102157 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Number2 { get; set; }

        /// <summary>
        /// 阻尼器_个数2  1102157 是否公开
        /// </summary>
        public bool? IsPublicDamper_Number2 { get; set; }
        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)2  1102158
        /// </summary>
        public string Damper_MaxCapacity2 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)2  1102158 数据类别
        /// </summary>
        public string RecordTypeDamper_MaxCapacity2 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)2  1102158 是否必填
        /// </summary>
        public bool? IsRequiredDamper_MaxCapacity2 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)2  1102158 是否公开
        /// </summary>
        public bool? IsPublicDamper_MaxCapacity2 { get; set; }
        /// <summary>
        /// 阻尼器_阻尼系数C2  1102159
        /// </summary>
        public string Damper_Coefficient2 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C2  1102159 数据类别
        /// </summary>
        public string RecordTypeDamper_Coefficient2 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C2  1102159 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Coefficient2 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C2  1102159 是否公开
        /// </summary>
        public bool? IsPublicDamper_Coefficient2 { get; set; }
        /// <summary>
        /// 阻尼器_速度指数α2  1102160
        /// </summary>
        public string Damper_VelocityIndex2 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α2  1102160 数据类别
        /// </summary>
        public string RecordTypeDamper_VelocityIndex2 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α2  1102160 是否必填
        /// </summary>
        public bool? IsRequiredDamper_VelocityIndex2 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α2  1102160 是否公开
        /// </summary>
        public bool? IsPublicDamper_VelocityIndex2 { get; set; }
        /// <summary>
        /// 阻尼器_型号3  1102161
        /// </summary>
        public string Damper_Model3 { get; set; }

        /// <summary>
        /// 阻尼器_型号3  1102161 数据类别
        /// </summary>
        public string RecordTypeDamper_Model3 { get; set; }

        /// <summary>
        /// 阻尼器_型号3  1102161 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Model3 { get; set; }

        /// <summary>
        /// 阻尼器_型号3  1102161 是否公开
        /// </summary>
        public bool? IsPublicDamper_Model3 { get; set; }
        /// <summary>
        /// 阻尼器_个数3  1102162
        /// </summary>
        public string Damper_Number3 { get; set; }

        /// <summary>
        /// 阻尼器_个数3  1102162 数据类别
        /// </summary>
        public string RecordTypeDamper_Number3 { get; set; }

        /// <summary>
        /// 阻尼器_个数3  1102162 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Number3 { get; set; }

        /// <summary>
        /// 阻尼器_个数3  1102162 是否公开
        /// </summary>
        public bool? IsPublicDamper_Number3 { get; set; }
        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)3  1102163
        /// </summary>
        public string Damper_MaxCapacity3 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)3  1102163 数据类别
        /// </summary>
        public string RecordTypeDamper_MaxCapacity3 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)3  1102163 是否必填
        /// </summary>
        public bool? IsRequiredDamper_MaxCapacity3 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)3  1102163 是否公开
        /// </summary>
        public bool? IsPublicDamper_MaxCapacity3 { get; set; }
        /// <summary>
        /// 阻尼器_阻尼系数C3  1102164
        /// </summary>
        public string Damper_Coefficient3 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C3  1102164 数据类别
        /// </summary>
        public string RecordTypeDamper_Coefficient3 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C3  1102164 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Coefficient3 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C3  1102164 是否公开
        /// </summary>
        public bool? IsPublicDamper_Coefficient3 { get; set; }
        /// <summary>
        /// 阻尼器_速度指数α3  1102165
        /// </summary>
        public string Damper_VelocityIndex3 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α3  1102165 数据类别
        /// </summary>
        public string RecordTypeDamper_VelocityIndex3 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α3  1102165 是否必填
        /// </summary>
        public bool? IsRequiredDamper_VelocityIndex3 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α3  1102165 是否公开
        /// </summary>
        public bool? IsPublicDamper_VelocityIndex3 { get; set; }
        /// <summary>
        /// 阻尼器_型号4  1102166
        /// </summary>
        public string Damper_Model4 { get; set; }

        /// <summary>
        /// 阻尼器_型号4  1102166 数据类别
        /// </summary>
        public string RecordTypeDamper_Model4 { get; set; }

        /// <summary>
        /// 阻尼器_型号4  1102166 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Model4 { get; set; }

        /// <summary>
        /// 阻尼器_型号4  1102166 是否公开
        /// </summary>
        public bool? IsPublicDamper_Model4 { get; set; }
        /// <summary>
        /// 阻尼器_个数4  1102167
        /// </summary>
        public string Damper_Number4 { get; set; }

        /// <summary>
        /// 阻尼器_个数4  1102167 数据类别
        /// </summary>
        public string RecordTypeDamper_Number4 { get; set; }

        /// <summary>
        /// 阻尼器_个数4  1102167 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Number4 { get; set; }

        /// <summary>
        /// 阻尼器_个数4  1102167 是否公开
        /// </summary>
        public bool? IsPublicDamper_Number4 { get; set; }
        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)4  1102168
        /// </summary>
        public string Damper_MaxCapacity4 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)4  1102168 数据类别
        /// </summary>
        public string RecordTypeDamper_MaxCapacity4 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)4  1102168 是否必填
        /// </summary>
        public bool? IsRequiredDamper_MaxCapacity4 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)4  1102168 是否公开
        /// </summary>
        public bool? IsPublicDamper_MaxCapacity4 { get; set; }
        /// <summary>
        /// 阻尼器_阻尼系数C4  1102169
        /// </summary>
        public string Damper_Coefficient4 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C4  1102169 数据类别
        /// </summary>
        public string RecordTypeDamper_Coefficient4 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C4  1102169 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Coefficient4 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C4  1102169 是否公开
        /// </summary>
        public bool? IsPublicDamper_Coefficient4 { get; set; }
        /// <summary>
        /// 阻尼器_速度指数α4  1102170
        /// </summary>
        public string Damper_VelocityIndex4 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α4  1102170 数据类别
        /// </summary>
        public string RecordTypeDamper_VelocityIndex4 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α4  1102170 是否必填
        /// </summary>
        public bool? IsRequiredDamper_VelocityIndex4 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α4  1102170 是否公开
        /// </summary>
        public bool? IsPublicDamper_VelocityIndex4 { get; set; }
        /// <summary>
        /// 阻尼器_型号5  1102171
        /// </summary>
        public string Damper_Model5 { get; set; }

        /// <summary>
        /// 阻尼器_型号5  1102171 数据类别
        /// </summary>
        public string RecordTypeDamper_Model5 { get; set; }

        /// <summary>
        /// 阻尼器_型号5  1102171 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Model5 { get; set; }

        /// <summary>
        /// 阻尼器_型号5  1102171 是否公开
        /// </summary>
        public bool? IsPublicDamper_Model5 { get; set; }
        /// <summary>
        /// 阻尼器_个数5  1102172
        /// </summary>
        public string Damper_Number5 { get; set; }

        /// <summary>
        /// 阻尼器_个数5  1102172 数据类别
        /// </summary>
        public string RecordTypeDamper_Number5 { get; set; }

        /// <summary>
        /// 阻尼器_个数5  1102172 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Number5 { get; set; }

        /// <summary>
        /// 阻尼器_个数5  1102172 是否公开
        /// </summary>
        public bool? IsPublicDamper_Number5 { get; set; }
        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)5  1102173
        /// </summary>
        public string Damper_MaxCapacity5 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)5  1102173 数据类别
        /// </summary>
        public string RecordTypeDamper_MaxCapacity5 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)5  1102173 是否必填
        /// </summary>
        public bool? IsRequiredDamper_MaxCapacity5 { get; set; }

        /// <summary>
        /// 阻尼器_最大阻尼出力 (t)5  1102173 是否公开
        /// </summary>
        public bool? IsPublicDamper_MaxCapacity5 { get; set; }
        /// <summary>
        /// 阻尼器_阻尼系数C5  1102174
        /// </summary>
        public string Damper_Coefficient5 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C5  1102174 数据类别
        /// </summary>
        public string RecordTypeDamper_Coefficient5 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C5  1102174 是否必填
        /// </summary>
        public bool? IsRequiredDamper_Coefficient5 { get; set; }

        /// <summary>
        /// 阻尼器_阻尼系数C5  1102174 是否公开
        /// </summary>
        public bool? IsPublicDamper_Coefficient5 { get; set; }
        /// <summary>
        /// 阻尼器_速度指数α5  1102175
        /// </summary>
        public string Damper_VelocityIndex5 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α5  1102175 数据类别
        /// </summary>
        public string RecordTypeDamper_VelocityIndex5 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α5  1102175 是否必填
        /// </summary>
        public bool? IsRequiredDamper_VelocityIndex5 { get; set; }

        /// <summary>
        /// 阻尼器_速度指数α5  1102175 是否公开
        /// </summary>
        public bool? IsPublicDamper_VelocityIndex5 { get; set; }
    }


    /// <summary>
    /// 抗震—技术—消能减震
    /// </summary>
    [Serializable]
    public class Template_1103 : TemplateBase
    {
        /// <summary>
        /// 项目名称  1103001
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目名称  1103001 数据类别
        /// </summary>
        public string RecordTypeProjectName { get; set; }

        /// <summary>
        /// 项目名称  1103001 是否必填
        /// </summary>
        public bool? IsRequiredProjectName { get; set; }

        /// <summary>
        /// 项目名称  1103001 是否公开
        /// </summary>
        public bool? IsPublicProjectName { get; set; }
        /// <summary>
        /// 用途  1103002
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// 用途  1103002 数据类别
        /// </summary>
        public string RecordTypePurpose { get; set; }

        /// <summary>
        /// 用途  1103002 是否必填
        /// </summary>
        public bool? IsRequiredPurpose { get; set; }

        /// <summary>
        /// 用途  1103002 是否公开
        /// </summary>
        public bool? IsPublicPurpose { get; set; }
        /// <summary>
        /// 建设地点  1103003
        /// </summary>
        public string ConstructionSite { get; set; }

        /// <summary>
        /// 建设地点  1103003 数据类别
        /// </summary>
        public string RecordTypeConstructionSite { get; set; }

        /// <summary>
        /// 建设地点  1103003 是否必填
        /// </summary>
        public bool? IsRequiredConstructionSite { get; set; }

        /// <summary>
        /// 建设地点  1103003 是否公开
        /// </summary>
        public bool? IsPublicConstructionSite { get; set; }
        /// <summary>
        /// 建设时间  1103004
        /// </summary>
        public string ConstructionTime { get; set; }

        /// <summary>
        /// 建设时间  1103004 数据类别
        /// </summary>
        public string RecordTypeConstructionTime { get; set; }

        /// <summary>
        /// 建设时间  1103004 是否必填
        /// </summary>
        public bool? IsRequiredConstructionTime { get; set; }

        /// <summary>
        /// 建设时间  1103004 是否公开
        /// </summary>
        public bool? IsPublicConstructionTime { get; set; }
        /// <summary>
        /// 总高度(m)  1103005
        /// </summary>
        public string TotalHeight { get; set; }

        /// <summary>
        /// 总高度(m)  1103005 数据类别
        /// </summary>
        public string RecordTypeTotalHeight { get; set; }

        /// <summary>
        /// 总高度(m)  1103005 是否必填
        /// </summary>
        public bool? IsRequiredTotalHeight { get; set; }

        /// <summary>
        /// 总高度(m)  1103005 是否公开
        /// </summary>
        public bool? IsPublicTotalHeight { get; set; }
        /// <summary>
        /// 占地面积(㎡)  1103006
        /// </summary>
        public string CoveredArea { get; set; }

        /// <summary>
        /// 占地面积(㎡)  1103006 数据类别
        /// </summary>
        public string RecordTypeCoveredArea { get; set; }

        /// <summary>
        /// 占地面积(㎡)  1103006 是否必填
        /// </summary>
        public bool? IsRequiredCoveredArea { get; set; }

        /// <summary>
        /// 占地面积(㎡)  1103006 是否公开
        /// </summary>
        public bool? IsPublicCoveredArea { get; set; }
        /// <summary>
        /// 建筑面积(㎡)  1103007
        /// </summary>
        public string ConstructionArea { get; set; }

        /// <summary>
        /// 建筑面积(㎡)  1103007 数据类别
        /// </summary>
        public string RecordTypeConstructionArea { get; set; }

        /// <summary>
        /// 建筑面积(㎡)  1103007 是否必填
        /// </summary>
        public bool? IsRequiredConstructionArea { get; set; }

        /// <summary>
        /// 建筑面积(㎡)  1103007 是否公开
        /// </summary>
        public bool? IsPublicConstructionArea { get; set; }
        /// <summary>
        /// 高宽比  1103008
        /// </summary>
        public string HighAspectRatio { get; set; }

        /// <summary>
        /// 高宽比  1103008 数据类别
        /// </summary>
        public string RecordTypeHighAspectRatio { get; set; }

        /// <summary>
        /// 高宽比  1103008 是否必填
        /// </summary>
        public bool? IsRequiredHighAspectRatio { get; set; }

        /// <summary>
        /// 高宽比  1103008 是否公开
        /// </summary>
        public bool? IsPublicHighAspectRatio { get; set; }
        /// <summary>
        /// 层数_地上  1103009
        /// </summary>
        public string Layer_Ground { get; set; }

        /// <summary>
        /// 层数_地上  1103009 数据类别
        /// </summary>
        public string RecordTypeLayer_Ground { get; set; }

        /// <summary>
        /// 层数_地上  1103009 是否必填
        /// </summary>
        public bool? IsRequiredLayer_Ground { get; set; }

        /// <summary>
        /// 层数_地上  1103009 是否公开
        /// </summary>
        public bool? IsPublicLayer_Ground { get; set; }
        /// <summary>
        /// 层数_地下  1103010
        /// </summary>
        public string Layer_Underground { get; set; }

        /// <summary>
        /// 层数_地下  1103010 数据类别
        /// </summary>
        public string RecordTypeLayer_Underground { get; set; }

        /// <summary>
        /// 层数_地下  1103010 是否必填
        /// </summary>
        public bool? IsRequiredLayer_Underground { get; set; }

        /// <summary>
        /// 层数_地下  1103010 是否公开
        /// </summary>
        public bool? IsPublicLayer_Underground { get; set; }
        /// <summary>
        /// 首层层高(m)  1103011
        /// </summary>
        public string FirstStoreyHeight { get; set; }

        /// <summary>
        /// 首层层高(m)  1103011 数据类别
        /// </summary>
        public string RecordTypeFirstStoreyHeight { get; set; }

        /// <summary>
        /// 首层层高(m)  1103011 是否必填
        /// </summary>
        public bool? IsRequiredFirstStoreyHeight { get; set; }

        /// <summary>
        /// 首层层高(m)  1103011 是否公开
        /// </summary>
        public bool? IsPublicFirstStoreyHeight { get; set; }
        /// <summary>
        /// 标准层高(m)  1103012
        /// </summary>
        public string StandardHeight { get; set; }

        /// <summary>
        /// 标准层高(m)  1103012 数据类别
        /// </summary>
        public string RecordTypeStandardHeight { get; set; }

        /// <summary>
        /// 标准层高(m)  1103012 是否必填
        /// </summary>
        public bool? IsRequiredStandardHeight { get; set; }

        /// <summary>
        /// 标准层高(m)  1103012 是否公开
        /// </summary>
        public bool? IsPublicStandardHeight { get; set; }
        /// <summary>
        /// 建设单位  1103013
        /// </summary>
        public string DampingDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1103013 数据类别
        /// </summary>
        public string RecordTypeDampingDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1103013 是否必填
        /// </summary>
        public bool? IsRequiredDampingDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  1103013 是否公开
        /// </summary>
        public bool? IsPublicDampingDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  1103014
        /// </summary>
        public string DampingConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1103014 数据类别
        /// </summary>
        public string RecordTypeDampingConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1103014 是否必填
        /// </summary>
        public bool? IsRequiredDampingConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  1103014 是否公开
        /// </summary>
        public bool? IsPublicDampingConstructionOrganization { get; set; }
        /// <summary>
        /// 设计单位  1103015
        /// </summary>
        public string DampingDesignOrganization { get; set; }

        /// <summary>
        /// 设计单位  1103015 数据类别
        /// </summary>
        public string RecordTypeDampingDesignOrganization { get; set; }

        /// <summary>
        /// 设计单位  1103015 是否必填
        /// </summary>
        public bool? IsRequiredDampingDesignOrganization { get; set; }

        /// <summary>
        /// 设计单位  1103015 是否公开
        /// </summary>
        public bool? IsPublicDampingDesignOrganization { get; set; }
        /// <summary>
        /// 施工图审查机构  1103016
        /// </summary>
        public string DampingConstructionPlansCensorship { get; set; }

        /// <summary>
        /// 施工图审查机构  1103016 数据类别
        /// </summary>
        public string RecordTypeDampingConstructionPlansCensorship { get; set; }

        /// <summary>
        /// 施工图审查机构  1103016 是否必填
        /// </summary>
        public bool? IsRequiredDampingConstructionPlansCensorship { get; set; }

        /// <summary>
        /// 施工图审查机构  1103016 是否公开
        /// </summary>
        public bool? IsPublicDampingConstructionPlansCensorship { get; set; }
        /// <summary>
        /// 混凝土总用量(m3)  1103017
        /// </summary>
        public string DampingConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量(m3)  1103017 数据类别
        /// </summary>
        public string RecordTypeDampingConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量(m3)  1103017 是否必填
        /// </summary>
        public bool? IsRequiredDampingConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量(m3)  1103017 是否公开
        /// </summary>
        public bool? IsPublicDampingConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1103018
        /// </summary>
        public string DampingPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1103018 数据类别
        /// </summary>
        public string RecordTypeDampingPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1103018 是否必填
        /// </summary>
        public bool? IsRequiredDampingPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度(cm/㎡)  1103018 是否公开
        /// </summary>
        public bool? IsPublicDampingPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  1103019
        /// </summary>
        public string DampingSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  1103019 数据类别
        /// </summary>
        public string RecordTypeDampingSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  1103019 是否必填
        /// </summary>
        public bool? IsRequiredDampingSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  1103019 是否公开
        /// </summary>
        public bool? IsPublicDampingSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  1103020
        /// </summary>
        public string DampingSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  1103020 数据类别
        /// </summary>
        public string RecordTypeDampingSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  1103020 是否必填
        /// </summary>
        public bool? IsRequiredDampingSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  1103020 是否公开
        /// </summary>
        public bool? IsPublicDampingSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  1103021
        /// </summary>
        public string DampingPerSqM_SteelAmount_Rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  1103021 数据类别
        /// </summary>
        public string RecordTypeDampingPerSqM_SteelAmount_Rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  1103021 是否必填
        /// </summary>
        public bool? IsRequiredDampingPerSqM_SteelAmount_Rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  1103021 是否公开
        /// </summary>
        public bool? IsPublicDampingPerSqM_SteelAmount_Rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  1103022
        /// </summary>
        public string DampingPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  1103022 数据类别
        /// </summary>
        public string RecordTypeDampingPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  1103022 是否必填
        /// </summary>
        public bool? IsRequiredDampingPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  1103022 是否公开
        /// </summary>
        public bool? IsPublicDampingPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1103023
        /// </summary>
        public string SeismicAccelerationParameter { get; set; }

        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1103023 数据类别
        /// </summary>
        public string RecordTypeSeismicAccelerationParameter { get; set; }

        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1103023 是否必填
        /// </summary>
        public bool? IsRequiredSeismicAccelerationParameter { get; set; }

        /// <summary>
        /// 所在地区设防地震加速度参数(g)  1103023 是否公开
        /// </summary>
        public bool? IsPublicSeismicAccelerationParameter { get; set; }
        /// <summary>
        /// 设计基本地震动加速度(g)  1103024
        /// </summary>
        public string BasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震动加速度(g)  1103024 数据类别
        /// </summary>
        public string RecordTypeBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震动加速度(g)  1103024 是否必填
        /// </summary>
        public bool? IsRequiredBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 设计基本地震动加速度(g)  1103024 是否公开
        /// </summary>
        public bool? IsPublicBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 场地类别  1103025
        /// </summary>
        public string SiteType { get; set; }

        /// <summary>
        /// 场地类别  1103025 数据类别
        /// </summary>
        public string RecordTypeSiteType { get; set; }

        /// <summary>
        /// 场地类别  1103025 是否必填
        /// </summary>
        public bool? IsRequiredSiteType { get; set; }

        /// <summary>
        /// 场地类别  1103025 是否公开
        /// </summary>
        public bool? IsPublicSiteType { get; set; }
        /// <summary>
        /// 特征周期(s)  1103026
        /// </summary>
        public string Eigenperiod { get; set; }

        /// <summary>
        /// 特征周期(s)  1103026 数据类别
        /// </summary>
        public string RecordTypeEigenperiod { get; set; }

        /// <summary>
        /// 特征周期(s)  1103026 是否必填
        /// </summary>
        public bool? IsRequiredEigenperiod { get; set; }

        /// <summary>
        /// 特征周期(s)  1103026 是否公开
        /// </summary>
        public bool? IsPublicEigenperiod { get; set; }
        /// <summary>
        /// 抗震设防类别  1103027
        /// </summary>
        public string FortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  1103027 数据类别
        /// </summary>
        public string RecordTypeFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  1103027 是否必填
        /// </summary>
        public bool? IsRequiredFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  1103027 是否公开
        /// </summary>
        public bool? IsPublicFortificationCategory { get; set; }
        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1103028
        /// </summary>
        public string TimeHistoryAnalysis { get; set; }

        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1103028 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysis { get; set; }

        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1103028 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysis { get; set; }

        /// <summary>
        /// 时程分析用地震波（名称/调幅值(gal)/特征周期（s））  1103028 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysis { get; set; }
        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1103029
        /// </summary>
        public string AdverseFactorsMmeasures { get; set; }

        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1103029 数据类别
        /// </summary>
        public string RecordTypeAdverseFactorsMmeasures { get; set; }

        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1103029 是否必填
        /// </summary>
        public bool? IsRequiredAdverseFactorsMmeasures { get; set; }

        /// <summary>
        /// 液化、震陷、断裂等不利场地因素措施  1103029 是否公开
        /// </summary>
        public bool? IsPublicAdverseFactorsMmeasures { get; set; }
        /// <summary>
        /// 基础形式  1103030
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 基础形式  1103030 数据类别
        /// </summary>
        public string RecordTypeBaseType { get; set; }

        /// <summary>
        /// 基础形式  1103030 是否必填
        /// </summary>
        public bool? IsRequiredBaseType { get; set; }

        /// <summary>
        /// 基础形式  1103030 是否公开
        /// </summary>
        public bool? IsPublicBaseType { get; set; }
        /// <summary>
        /// 上部结构形式  1103031
        /// </summary>
        public string UpperStructureForm { get; set; }

        /// <summary>
        /// 上部结构形式  1103031 数据类别
        /// </summary>
        public string RecordTypeUpperStructureForm { get; set; }

        /// <summary>
        /// 上部结构形式  1103031 是否必填
        /// </summary>
        public bool? IsRequiredUpperStructureForm { get; set; }

        /// <summary>
        /// 上部结构形式  1103031 是否公开
        /// </summary>
        public bool? IsPublicUpperStructureForm { get; set; }
        /// <summary>
        /// 地下室结构形式  1103032
        /// </summary>
        public string BasementStructuralForm { get; set; }

        /// <summary>
        /// 地下室结构形式  1103032 数据类别
        /// </summary>
        public string RecordTypeBasementStructuralForm { get; set; }

        /// <summary>
        /// 地下室结构形式  1103032 是否必填
        /// </summary>
        public bool? IsRequiredBasementStructuralForm { get; set; }

        /// <summary>
        /// 地下室结构形式  1103032 是否公开
        /// </summary>
        public bool? IsPublicBasementStructuralForm { get; set; }
        /// <summary>
        /// 隔震层位置（标高和层）  1103033
        /// </summary>
        public string IsolationLayerLocation { get; set; }

        /// <summary>
        /// 隔震层位置（标高和层）  1103033 数据类别
        /// </summary>
        public string RecordTypeIsolationLayerLocation { get; set; }

        /// <summary>
        /// 隔震层位置（标高和层）  1103033 是否必填
        /// </summary>
        public bool? IsRequiredIsolationLayerLocation { get; set; }

        /// <summary>
        /// 隔震层位置（标高和层）  1103033 是否公开
        /// </summary>
        public bool? IsPublicIsolationLayerLocation { get; set; }
        /// <summary>
        /// 水平向减震系数  1103034
        /// </summary>
        public string HorizontalDampingCoefficient { get; set; }

        /// <summary>
        /// 水平向减震系数  1103034 数据类别
        /// </summary>
        public string RecordTypeHorizontalDampingCoefficient { get; set; }

        /// <summary>
        /// 水平向减震系数  1103034 是否必填
        /// </summary>
        public bool? IsRequiredHorizontalDampingCoefficient { get; set; }

        /// <summary>
        /// 水平向减震系数  1103034 是否公开
        /// </summary>
        public bool? IsPublicHorizontalDampingCoefficient { get; set; }
        /// <summary>
        /// 主体结构阻尼比  1103035
        /// </summary>
        public string MainBodyDampingRatio { get; set; }

        /// <summary>
        /// 主体结构阻尼比  1103035 数据类别
        /// </summary>
        public string RecordTypeMainBodyDampingRatio { get; set; }

        /// <summary>
        /// 主体结构阻尼比  1103035 是否必填
        /// </summary>
        public bool? IsRequiredMainBodyDampingRatio { get; set; }

        /// <summary>
        /// 主体结构阻尼比  1103035 是否公开
        /// </summary>
        public bool? IsPublicMainBodyDampingRatio { get; set; }
        /// <summary>
        /// 结构附加有效阻尼比  1103036
        /// </summary>
        public string AdditionalEffectiveDampingRatio { get; set; }

        /// <summary>
        /// 结构附加有效阻尼比  1103036 数据类别
        /// </summary>
        public string RecordTypeAdditionalEffectiveDampingRatio { get; set; }

        /// <summary>
        /// 结构附加有效阻尼比  1103036 是否必填
        /// </summary>
        public bool? IsRequiredAdditionalEffectiveDampingRatio { get; set; }

        /// <summary>
        /// 结构附加有效阻尼比  1103036 是否公开
        /// </summary>
        public bool? IsPublicAdditionalEffectiveDampingRatio { get; set; }
        /// <summary>
        /// 结构前6阶周期 (s)  1103037
        /// </summary>
        public string Cyc { get; set; }

        /// <summary>
        /// 结构前6阶周期 (s)  1103037 数据类别
        /// </summary>
        public string RecordTypeCyc { get; set; }

        /// <summary>
        /// 结构前6阶周期 (s)  1103037 是否必填
        /// </summary>
        public bool? IsRequiredCyc { get; set; }

        /// <summary>
        /// 结构前6阶周期 (s)  1103037 是否公开
        /// </summary>
        public bool? IsPublicCyc { get; set; }
        /// <summary>
        /// 抗震分析程序名  1103038
        /// </summary>
        public string SeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  1103038 数据类别
        /// </summary>
        public string RecordTypeSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  1103038 是否必填
        /// </summary>
        public bool? IsRequiredSeismicAnalysisProgramName { get; set; }

        /// <summary>
        /// 抗震分析程序名  1103038 是否公开
        /// </summary>
        public bool? IsPublicSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  1103039
        /// </summary>
        public string NoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  1103039 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  1103039 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  1103039 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  1103040
        /// </summary>
        public string NoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  1103040 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  1103040 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_T1 { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  1103040 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  1103041
        /// </summary>
        public string NoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  1103041 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  1103041 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  1103041 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  1103042
        /// </summary>
        public string NoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  1103042 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  1103042 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  1103042 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  1103043
        /// </summary>
        public string NoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  1103043 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  1103043 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  1103043 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  1103044
        /// </summary>
        public string NoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  1103044 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  1103044 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  1103044 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  1103045
        /// </summary>
        public string NoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  1103045 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  1103045 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  1103045 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  1103046
        /// </summary>
        public string NoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  1103046 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  1103046 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_mm { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  1103046 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  1103047
        /// </summary>
        public string NoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  1103047 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  1103047 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  1103047 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  1103048
        /// </summary>
        public string NoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  1103048 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  1103048 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_h { get; set; }

        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  1103048 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  1103049
        /// </summary>
        public string Coupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  1103049 数据类别
        /// </summary>
        public string RecordTypeCoupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  1103049 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)1  1103049 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  1103050
        /// </summary>
        public string Coupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  1103050 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  1103050 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角1  1103050 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  1103051
        /// </summary>
        public string Coupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  1103051 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  1103051 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数1  1103051 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  1103052
        /// </summary>
        public string Coupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  1103052 数据类别
        /// </summary>
        public string RecordTypeCoupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  1103052 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)2  1103052 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  1103053
        /// </summary>
        public string Coupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  1103053 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  1103053 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角2  1103053 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  1103054
        /// </summary>
        public string Coupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  1103054 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  1103054 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数2  1103054 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  1103055
        /// </summary>
        public string Coupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  1103055 数据类别
        /// </summary>
        public string RecordTypeCoupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  1103055 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_T(s)3  1103055 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  1103056
        /// </summary>
        public string Coupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  1103056 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  1103056 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_转角3  1103056 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  1103057
        /// </summary>
        public string Coupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  1103057 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  1103057 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 考虑耦扭联转_扭转系数3  1103057 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  1103058
        /// </summary>
        public string Coupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  1103058 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  1103058 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  1103058 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  1103059
        /// </summary>
        public string Coupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  1103059 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  1103059 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_kN { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  1103059 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  1103060
        /// </summary>
        public string Coupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  1103060 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  1103060 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  1103060 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  1103061
        /// </summary>
        public string Coupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  1103061 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  1103061 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_Geq { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  1103061 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  1103062
        /// </summary>
        public string Coupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  1103062 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  1103062 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  1103062 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  1103063
        /// </summary>
        public string Coupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  1103063 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  1103063 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_mm { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  1103063 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  1103064
        /// </summary>
        public string Coupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  1103064 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  1103064 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  1103064 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  1103065
        /// </summary>
        public string Coupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  1103065 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  1103065 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_h { get; set; }

        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  1103065 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_h { get; set; }
        /// <summary>
        /// 地震作用最大方向  1103066
        /// </summary>
        public string MaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  1103066 数据类别
        /// </summary>
        public string RecordTypeMaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  1103066 是否必填
        /// </summary>
        public bool? IsRequiredMaxActionDirection { get; set; }

        /// <summary>
        /// 地震作用最大方向  1103066 是否公开
        /// </summary>
        public bool? IsPublicMaxActionDirection { get; set; }
        /// <summary>
        /// 时程分析程序名称  1103067
        /// </summary>
        public string TimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  1103067 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  1103067 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisProgramName { get; set; }

        /// <summary>
        /// 时程分析程序名称  1103067 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程_波名1  1103068
        /// </summary>
        public string TimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  1103068 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  1103068 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName1 { get; set; }

        /// <summary>
        /// 时程_波名1  1103068 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  1103069
        /// </summary>
        public string TimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  1103069 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  1103069 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN1 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)1  1103069 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  1103070
        /// </summary>
        public string TimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  1103070 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  1103070 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq1 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq1  1103070 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  1103071
        /// </summary>
        public string TimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  1103071 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  1103071 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h1 { get; set; }

        /// <summary>
        /// 时程_△U/h1  1103071 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_波名2  1103072
        /// </summary>
        public string TimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  1103072 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  1103072 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName2 { get; set; }

        /// <summary>
        /// 时程_波名2  1103072 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  1103073
        /// </summary>
        public string TimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  1103073 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  1103073 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN2 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)2  1103073 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  1103074
        /// </summary>
        public string TimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  1103074 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  1103074 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq2 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq2  1103074 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  1103075
        /// </summary>
        public string TimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  1103075 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  1103075 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h2 { get; set; }

        /// <summary>
        /// 时程_△U/h2  1103075 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_波名3  1103076
        /// </summary>
        public string TimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  1103076 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  1103076 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName3 { get; set; }

        /// <summary>
        /// 时程_波名3  1103076 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  1103077
        /// </summary>
        public string TimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  1103077 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  1103077 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN3 { get; set; }

        /// <summary>
        /// 时程_FEK(kN)3  1103077 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  1103078
        /// </summary>
        public string TimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  1103078 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  1103078 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq3 { get; set; }

        /// <summary>
        /// 时程_FEK/Geq3  1103078 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  1103079
        /// </summary>
        public string TimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  1103079 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  1103079 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 时程_△U/h3  1103079 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h3 { get; set; }
        /// <summary>
        /// 生产企业_黏滞阻尼器  1103080
        /// </summary>
        public string Manufacturer_ViscousDamper { get; set; }

        /// <summary>
        /// 生产企业_黏滞阻尼器  1103080 数据类别
        /// </summary>
        public string RecordTypeManufacturer_ViscousDamper { get; set; }

        /// <summary>
        /// 生产企业_黏滞阻尼器  1103080 是否必填
        /// </summary>
        public bool? IsRequiredManufacturer_ViscousDamper { get; set; }

        /// <summary>
        /// 生产企业_黏滞阻尼器  1103080 是否公开
        /// </summary>
        public bool? IsPublicManufacturer_ViscousDamper { get; set; }
        /// <summary>
        /// 生产企业_金属阻尼器  1103081
        /// </summary>
        public string Manufacturer_MetallicDamper { get; set; }

        /// <summary>
        /// 生产企业_金属阻尼器  1103081 数据类别
        /// </summary>
        public string RecordTypeManufacturer_MetallicDamper { get; set; }

        /// <summary>
        /// 生产企业_金属阻尼器  1103081 是否必填
        /// </summary>
        public bool? IsRequiredManufacturer_MetallicDamper { get; set; }

        /// <summary>
        /// 生产企业_金属阻尼器  1103081 是否公开
        /// </summary>
        public bool? IsPublicManufacturer_MetallicDamper { get; set; }
        /// <summary>
        /// 生产企业_屈曲约束支撑  1103082
        /// </summary>
        public string Manufacturer_BrB { get; set; }

        /// <summary>
        /// 生产企业_屈曲约束支撑  1103082 数据类别
        /// </summary>
        public string RecordTypeManufacturer_BrB { get; set; }

        /// <summary>
        /// 生产企业_屈曲约束支撑  1103082 是否必填
        /// </summary>
        public bool? IsRequiredManufacturer_BrB { get; set; }

        /// <summary>
        /// 生产企业_屈曲约束支撑  1103082 是否公开
        /// </summary>
        public bool? IsPublicManufacturer_BrB { get; set; }
        /// <summary>
        /// 生产企业_其他  1103083
        /// </summary>
        public string Manufacturer_Other { get; set; }

        /// <summary>
        /// 生产企业_其他  1103083 数据类别
        /// </summary>
        public string RecordTypeManufacturer_Other { get; set; }

        /// <summary>
        /// 生产企业_其他  1103083 是否必填
        /// </summary>
        public bool? IsRequiredManufacturer_Other { get; set; }

        /// <summary>
        /// 生产企业_其他  1103083 是否公开
        /// </summary>
        public bool? IsPublicManufacturer_Other { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号1  1103084
        /// </summary>
        public string ViscousDamper_Model1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号1  1103084 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号1  1103084 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号1  1103084 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model1 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数1  1103085
        /// </summary>
        public string ViscousDamper_Number1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数1  1103085 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数1  1103085 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数1  1103085 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number1 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)1  1103086
        /// </summary>
        public string ViscousDamper_LimitDrift1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)1  1103086 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)1  1103086 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)1  1103086 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift1 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)1  1103087
        /// </summary>
        public string ViscousDamper_MaxCapacity1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)1  1103087 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)1  1103087 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)1  1103087 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity1 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C1  1103088
        /// </summary>
        public string ViscousDamper_Coefficient1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C1  1103088 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C1  1103088 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C1  1103088 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient1 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α1  1103089
        /// </summary>
        public string ViscousDamper_VelocityIndex1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α1  1103089 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α1  1103089 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex1 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α1  1103089 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex1 { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号2  1103090
        /// </summary>
        public string ViscousDamper_Model2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号2  1103090 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号2  1103090 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号2  1103090 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model2 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数2  1103091
        /// </summary>
        public string ViscousDamper_Number2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数2  1103091 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数2  1103091 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数2  1103091 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number2 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)2  1103092
        /// </summary>
        public string ViscousDamper_LimitDrift2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)2  1103092 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)2  1103092 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)2  1103092 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift2 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)2  1103093
        /// </summary>
        public string ViscousDamper_MaxCapacity2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)2  1103093 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)2  1103093 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)2  1103093 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity2 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C2  1103094
        /// </summary>
        public string ViscousDamper_Coefficient2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C2  1103094 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C2  1103094 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C2  1103094 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient2 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α2  1103095
        /// </summary>
        public string ViscousDamper_VelocityIndex2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α2  1103095 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α2  1103095 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex2 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α2  1103095 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex2 { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号3  1103096
        /// </summary>
        public string ViscousDamper_Model3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号3  1103096 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号3  1103096 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号3  1103096 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model3 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数3  1103097
        /// </summary>
        public string ViscousDamper_Number3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数3  1103097 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数3  1103097 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数3  1103097 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number3 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)3  1103098
        /// </summary>
        public string ViscousDamper_LimitDrift3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)3  1103098 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)3  1103098 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)3  1103098 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift3 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)3  1103099
        /// </summary>
        public string ViscousDamper_MaxCapacity3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)3  1103099 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)3  1103099 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)3  1103099 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity3 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C3  1103100
        /// </summary>
        public string ViscousDamper_Coefficient3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C3  1103100 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C3  1103100 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C3  1103100 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient3 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α3  1103101
        /// </summary>
        public string ViscousDamper_VelocityIndex3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α3  1103101 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α3  1103101 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex3 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α3  1103101 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex3 { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号4  1103102
        /// </summary>
        public string ViscousDamper_Model4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号4  1103102 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号4  1103102 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号4  1103102 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model4 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数4  1103103
        /// </summary>
        public string ViscousDamper_Number4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数4  1103103 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数4  1103103 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数4  1103103 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number4 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)4  1103104
        /// </summary>
        public string ViscousDamper_LimitDrift4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)4  1103104 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)4  1103104 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)4  1103104 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift4 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)4  1103105
        /// </summary>
        public string ViscousDamper_MaxCapacity4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)4  1103105 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)4  1103105 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)4  1103105 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity4 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C4  1103106
        /// </summary>
        public string ViscousDamper_Coefficient4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C4  1103106 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C4  1103106 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C4  1103106 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient4 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α4  1103107
        /// </summary>
        public string ViscousDamper_VelocityIndex4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α4  1103107 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α4  1103107 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex4 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α4  1103107 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex4 { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号5  1103108
        /// </summary>
        public string ViscousDamper_Model5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号5  1103108 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号5  1103108 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号5  1103108 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model5 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数5  1103109
        /// </summary>
        public string ViscousDamper_Number5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数5  1103109 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数5  1103109 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数5  1103109 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number5 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)5  1103110
        /// </summary>
        public string ViscousDamper_LimitDrift5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)5  1103110 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)5  1103110 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)5  1103110 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift5 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)5  1103111
        /// </summary>
        public string ViscousDamper_MaxCapacity5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)5  1103111 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)5  1103111 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)5  1103111 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity5 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C5  1103112
        /// </summary>
        public string ViscousDamper_Coefficient5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C5  1103112 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C5  1103112 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C5  1103112 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient5 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α5  1103113
        /// </summary>
        public string ViscousDamper_VelocityIndex5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α5  1103113 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α5  1103113 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex5 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α5  1103113 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex5 { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号6  1103114
        /// </summary>
        public string ViscousDamper_Model6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号6  1103114 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号6  1103114 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号6  1103114 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model6 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数6  1103115
        /// </summary>
        public string ViscousDamper_Number6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数6  1103115 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数6  1103115 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数6  1103115 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number6 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)6  1103116
        /// </summary>
        public string ViscousDamper_LimitDrift6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)6  1103116 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)6  1103116 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)6  1103116 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift6 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)6  1103117
        /// </summary>
        public string ViscousDamper_MaxCapacity6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)6  1103117 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)6  1103117 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)6  1103117 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity6 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C6  1103118
        /// </summary>
        public string ViscousDamper_Coefficient6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C6  1103118 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C6  1103118 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C6  1103118 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient6 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α6  1103119
        /// </summary>
        public string ViscousDamper_VelocityIndex6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α6  1103119 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α6  1103119 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex6 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α6  1103119 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex6 { get; set; }
        /// <summary>
        /// 黏滞阻尼器型号7  1103120
        /// </summary>
        public string ViscousDamper_Model7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号7  1103120 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Model7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号7  1103120 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Model7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器型号7  1103120 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Model7 { get; set; }
        /// <summary>
        /// 黏滞阻尼器个数7  1103121
        /// </summary>
        public string ViscousDamper_Number7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数7  1103121 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Number7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数7  1103121 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Number7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器个数7  1103121 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Number7 { get; set; }
        /// <summary>
        /// 黏滞阻尼器极限位移(mm)7  1103122
        /// </summary>
        public string ViscousDamper_LimitDrift7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)7  1103122 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_LimitDrift7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)7  1103122 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_LimitDrift7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器极限位移(mm)7  1103122 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_LimitDrift7 { get; set; }
        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)7  1103123
        /// </summary>
        public string ViscousDamper_MaxCapacity7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)7  1103123 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_MaxCapacity7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)7  1103123 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_MaxCapacity7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器最大阻尼出力 (t)7  1103123 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_MaxCapacity7 { get; set; }
        /// <summary>
        /// 黏滞阻尼器阻尼系数C7  1103124
        /// </summary>
        public string ViscousDamper_Coefficient7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C7  1103124 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_Coefficient7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C7  1103124 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_Coefficient7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器阻尼系数C7  1103124 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_Coefficient7 { get; set; }
        /// <summary>
        /// 黏滞阻尼器速度指数α7  1103125
        /// </summary>
        public string ViscousDamper_VelocityIndex7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α7  1103125 数据类别
        /// </summary>
        public string RecordTypeViscousDamper_VelocityIndex7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α7  1103125 是否必填
        /// </summary>
        public bool? IsRequiredViscousDamper_VelocityIndex7 { get; set; }

        /// <summary>
        /// 黏滞阻尼器速度指数α7  1103125 是否公开
        /// </summary>
        public bool? IsPublicViscousDamper_VelocityIndex7 { get; set; }
        /// <summary>
        /// 金属阻尼器型号1  1103126
        /// </summary>
        public string MetallicDamper_Model1 { get; set; }

        /// <summary>
        /// 金属阻尼器型号1  1103126 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model1 { get; set; }

        /// <summary>
        /// 金属阻尼器型号1  1103126 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model1 { get; set; }

        /// <summary>
        /// 金属阻尼器型号1  1103126 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model1 { get; set; }
        /// <summary>
        /// 金属阻尼器个数1  1103127
        /// </summary>
        public string MetallicDamper_Number1 { get; set; }

        /// <summary>
        /// 金属阻尼器个数1  1103127 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number1 { get; set; }

        /// <summary>
        /// 金属阻尼器个数1  1103127 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number1 { get; set; }

        /// <summary>
        /// 金属阻尼器个数1  1103127 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number1 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)1  1103128
        /// </summary>
        public string MetallicDamper_YieldDrift1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)1  1103128 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)1  1103128 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)1  1103128 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift1 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)1  1103129
        /// </summary>
        public string MetallicDamper_YieldLoad1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)1  1103129 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)1  1103129 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)1  1103129 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad1 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)1  1103130
        /// </summary>
        public string MetallicDamper_YieldStiffness1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)1  1103130 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)1  1103130 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness1 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)1  1103130 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness1 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)1  1103131
        /// </summary>
        public string MetallicDamper_LimitLoad1 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)1  1103131 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad1 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)1  1103131 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad1 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)1  1103131 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad1 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)1  1103132
        /// </summary>
        public string MetallicDamper_LimitStiffness1 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)1  1103132 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness1 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)1  1103132 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness1 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)1  1103132 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness1 { get; set; }
        /// <summary>
        /// 金属阻尼器型号2  1103133
        /// </summary>
        public string MetallicDamper_Model2 { get; set; }

        /// <summary>
        /// 金属阻尼器型号2  1103133 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model2 { get; set; }

        /// <summary>
        /// 金属阻尼器型号2  1103133 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model2 { get; set; }

        /// <summary>
        /// 金属阻尼器型号2  1103133 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model2 { get; set; }
        /// <summary>
        /// 金属阻尼器个数2  1103134
        /// </summary>
        public string MetallicDamper_Number2 { get; set; }

        /// <summary>
        /// 金属阻尼器个数2  1103134 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number2 { get; set; }

        /// <summary>
        /// 金属阻尼器个数2  1103134 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number2 { get; set; }

        /// <summary>
        /// 金属阻尼器个数2  1103134 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number2 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)2  1103135
        /// </summary>
        public string MetallicDamper_YieldDrift2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)2  1103135 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)2  1103135 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)2  1103135 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift2 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)2  1103136
        /// </summary>
        public string MetallicDamper_YieldLoad2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)2  1103136 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)2  1103136 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)2  1103136 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad2 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)2  1103137
        /// </summary>
        public string MetallicDamper_YieldStiffness2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)2  1103137 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)2  1103137 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness2 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)2  1103137 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness2 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)2  1103138
        /// </summary>
        public string MetallicDamper_LimitLoad2 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)2  1103138 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad2 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)2  1103138 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad2 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)2  1103138 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad2 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)2  1103139
        /// </summary>
        public string MetallicDamper_LimitStiffness2 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)2  1103139 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness2 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)2  1103139 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness2 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)2  1103139 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness2 { get; set; }
        /// <summary>
        /// 金属阻尼器型号3  1103140
        /// </summary>
        public string MetallicDamper_Model3 { get; set; }

        /// <summary>
        /// 金属阻尼器型号3  1103140 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model3 { get; set; }

        /// <summary>
        /// 金属阻尼器型号3  1103140 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model3 { get; set; }

        /// <summary>
        /// 金属阻尼器型号3  1103140 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model3 { get; set; }
        /// <summary>
        /// 金属阻尼器个数3  1103141
        /// </summary>
        public string MetallicDamper_Number3 { get; set; }

        /// <summary>
        /// 金属阻尼器个数3  1103141 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number3 { get; set; }

        /// <summary>
        /// 金属阻尼器个数3  1103141 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number3 { get; set; }

        /// <summary>
        /// 金属阻尼器个数3  1103141 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number3 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)3  1103142
        /// </summary>
        public string MetallicDamper_YieldDrift3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)3  1103142 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)3  1103142 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)3  1103142 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift3 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)3  1103143
        /// </summary>
        public string MetallicDamper_YieldLoad3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)3  1103143 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)3  1103143 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)3  1103143 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad3 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)3  1103144
        /// </summary>
        public string MetallicDamper_YieldStiffness3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)3  1103144 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)3  1103144 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness3 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)3  1103144 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness3 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)3  1103145
        /// </summary>
        public string MetallicDamper_LimitLoad3 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)3  1103145 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad3 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)3  1103145 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad3 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)3  1103145 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad3 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)3  1103146
        /// </summary>
        public string MetallicDamper_LimitStiffness3 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)3  1103146 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness3 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)3  1103146 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness3 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)3  1103146 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness3 { get; set; }
        /// <summary>
        /// 金属阻尼器型号4  1103147
        /// </summary>
        public string MetallicDamper_Model4 { get; set; }

        /// <summary>
        /// 金属阻尼器型号4  1103147 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model4 { get; set; }

        /// <summary>
        /// 金属阻尼器型号4  1103147 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model4 { get; set; }

        /// <summary>
        /// 金属阻尼器型号4  1103147 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model4 { get; set; }
        /// <summary>
        /// 金属阻尼器个数4  1103148
        /// </summary>
        public string MetallicDamper_Number4 { get; set; }

        /// <summary>
        /// 金属阻尼器个数4  1103148 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number4 { get; set; }

        /// <summary>
        /// 金属阻尼器个数4  1103148 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number4 { get; set; }

        /// <summary>
        /// 金属阻尼器个数4  1103148 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number4 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)4  1103149
        /// </summary>
        public string MetallicDamper_YieldDrift4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)4  1103149 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)4  1103149 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)4  1103149 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift4 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)4  1103150
        /// </summary>
        public string MetallicDamper_YieldLoad4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)4  1103150 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)4  1103150 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)4  1103150 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad4 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)4  1103151
        /// </summary>
        public string MetallicDamper_YieldStiffness4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)4  1103151 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)4  1103151 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness4 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)4  1103151 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness4 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)4  1103152
        /// </summary>
        public string MetallicDamper_LimitLoad4 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)4  1103152 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad4 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)4  1103152 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad4 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)4  1103152 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad4 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)4  1103153
        /// </summary>
        public string MetallicDamper_LimitStiffness4 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)4  1103153 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness4 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)4  1103153 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness4 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)4  1103153 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness4 { get; set; }
        /// <summary>
        /// 金属阻尼器型号5  1103154
        /// </summary>
        public string MetallicDamper_Model5 { get; set; }

        /// <summary>
        /// 金属阻尼器型号5  1103154 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model5 { get; set; }

        /// <summary>
        /// 金属阻尼器型号5  1103154 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model5 { get; set; }

        /// <summary>
        /// 金属阻尼器型号5  1103154 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model5 { get; set; }
        /// <summary>
        /// 金属阻尼器个数5  1103155
        /// </summary>
        public string MetallicDamper_Number5 { get; set; }

        /// <summary>
        /// 金属阻尼器个数5  1103155 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number5 { get; set; }

        /// <summary>
        /// 金属阻尼器个数5  1103155 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number5 { get; set; }

        /// <summary>
        /// 金属阻尼器个数5  1103155 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number5 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)5  1103156
        /// </summary>
        public string MetallicDamper_YieldDrift5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)5  1103156 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)5  1103156 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)5  1103156 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift5 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)5  1103157
        /// </summary>
        public string MetallicDamper_YieldLoad5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)5  1103157 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)5  1103157 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)5  1103157 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad5 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)5  1103158
        /// </summary>
        public string MetallicDamper_YieldStiffness5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)5  1103158 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)5  1103158 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness5 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)5  1103158 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness5 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)5  1103159
        /// </summary>
        public string MetallicDamper_LimitLoad5 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)5  1103159 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad5 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)5  1103159 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad5 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)5  1103159 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad5 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)5  1103160
        /// </summary>
        public string MetallicDamper_LimitStiffness5 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)5  1103160 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness5 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)5  1103160 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness5 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)5  1103160 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness5 { get; set; }
        /// <summary>
        /// 金属阻尼器型号6  1103161
        /// </summary>
        public string MetallicDamper_Model6 { get; set; }

        /// <summary>
        /// 金属阻尼器型号6  1103161 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model6 { get; set; }

        /// <summary>
        /// 金属阻尼器型号6  1103161 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model6 { get; set; }

        /// <summary>
        /// 金属阻尼器型号6  1103161 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model6 { get; set; }
        /// <summary>
        /// 金属阻尼器个数6  1103162
        /// </summary>
        public string MetallicDamper_Number6 { get; set; }

        /// <summary>
        /// 金属阻尼器个数6  1103162 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number6 { get; set; }

        /// <summary>
        /// 金属阻尼器个数6  1103162 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number6 { get; set; }

        /// <summary>
        /// 金属阻尼器个数6  1103162 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number6 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)6  1103163
        /// </summary>
        public string MetallicDamper_YieldDrift6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)6  1103163 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)6  1103163 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)6  1103163 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift6 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)6  1103164
        /// </summary>
        public string MetallicDamper_YieldLoad6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)6  1103164 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)6  1103164 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)6  1103164 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad6 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)6  1103165
        /// </summary>
        public string MetallicDamper_YieldStiffness6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)6  1103165 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)6  1103165 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness6 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)6  1103165 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness6 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)6  1103166
        /// </summary>
        public string MetallicDamper_LimitLoad6 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)6  1103166 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad6 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)6  1103166 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad6 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)6  1103166 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad6 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)6  1103167
        /// </summary>
        public string MetallicDamper_LimitStiffness6 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)6  1103167 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness6 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)6  1103167 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness6 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)6  1103167 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness6 { get; set; }
        /// <summary>
        /// 金属阻尼器型号7  1103168
        /// </summary>
        public string MetallicDamper_Model7 { get; set; }

        /// <summary>
        /// 金属阻尼器型号7  1103168 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Model7 { get; set; }

        /// <summary>
        /// 金属阻尼器型号7  1103168 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Model7 { get; set; }

        /// <summary>
        /// 金属阻尼器型号7  1103168 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Model7 { get; set; }
        /// <summary>
        /// 金属阻尼器个数7  1103169
        /// </summary>
        public string MetallicDamper_Number7 { get; set; }

        /// <summary>
        /// 金属阻尼器个数7  1103169 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_Number7 { get; set; }

        /// <summary>
        /// 金属阻尼器个数7  1103169 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_Number7 { get; set; }

        /// <summary>
        /// 金属阻尼器个数7  1103169 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_Number7 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服位移(mm)7  1103170
        /// </summary>
        public string MetallicDamper_YieldDrift7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)7  1103170 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldDrift7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)7  1103170 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldDrift7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服位移(mm)7  1103170 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldDrift7 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服荷载 (t)7  1103171
        /// </summary>
        public string MetallicDamper_YieldLoad7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)7  1103171 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldLoad7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)7  1103171 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldLoad7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服荷载 (t)7  1103171 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldLoad7 { get; set; }
        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)7  1103172
        /// </summary>
        public string MetallicDamper_YieldStiffness7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)7  1103172 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_YieldStiffness7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)7  1103172 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_YieldStiffness7 { get; set; }

        /// <summary>
        /// 金属阻尼器屈服后刚度 (t/cm)7  1103172 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_YieldStiffness7 { get; set; }
        /// <summary>
        /// 金属阻尼器极限荷载 (t)7  1103173
        /// </summary>
        public string MetallicDamper_LimitLoad7 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)7  1103173 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitLoad7 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)7  1103173 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitLoad7 { get; set; }

        /// <summary>
        /// 金属阻尼器极限荷载 (t)7  1103173 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitLoad7 { get; set; }
        /// <summary>
        /// 金属阻尼器极限位移(mm)7  1103174
        /// </summary>
        public string MetallicDamper_LimitStiffness7 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)7  1103174 数据类别
        /// </summary>
        public string RecordTypeMetallicDamper_LimitStiffness7 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)7  1103174 是否必填
        /// </summary>
        public bool? IsRequiredMetallicDamper_LimitStiffness7 { get; set; }

        /// <summary>
        /// 金属阻尼器极限位移(mm)7  1103174 是否公开
        /// </summary>
        public bool? IsPublicMetallicDamper_LimitStiffness7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号1  1103175
        /// </summary>
        public string BrB_Model1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号1  1103175 数据类别
        /// </summary>
        public string RecordTypeBrB_Model1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号1  1103175 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号1  1103175 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数1  1103176
        /// </summary>
        public string BrB_Number1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数1  1103176 数据类别
        /// </summary>
        public string RecordTypeBrB_Number1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数1  1103176 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数1  1103176 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)1  1103177
        /// </summary>
        public string BrB_YieldDrift1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)1  1103177 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)1  1103177 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)1  1103177 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)1  1103178
        /// </summary>
        public string BrB_YieldLoad1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)1  1103178 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)1  1103178 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)1  1103178 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)1  1103179
        /// </summary>
        public string BrB_YieldStiffness1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)1  1103179 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)1  1103179 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)1  1103179 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)1  1103180
        /// </summary>
        public string BrB_LimitLoad1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)1  1103180 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)1  1103180 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)1  1103180 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)1  1103181
        /// </summary>
        public string BrB_LimitStiffness1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)1  1103181 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)1  1103181 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness1 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)1  1103181 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness1 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号2  1103182
        /// </summary>
        public string BrB_Model2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号2  1103182 数据类别
        /// </summary>
        public string RecordTypeBrB_Model2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号2  1103182 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号2  1103182 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数2  1103183
        /// </summary>
        public string BrB_Number2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数2  1103183 数据类别
        /// </summary>
        public string RecordTypeBrB_Number2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数2  1103183 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数2  1103183 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)2  1103184
        /// </summary>
        public string BrB_YieldDrift2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)2  1103184 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)2  1103184 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)2  1103184 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)2  1103185
        /// </summary>
        public string BrB_YieldLoad2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)2  1103185 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)2  1103185 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)2  1103185 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)2  1103186
        /// </summary>
        public string BrB_YieldStiffness2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)2  1103186 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)2  1103186 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)2  1103186 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)2  1103187
        /// </summary>
        public string BrB_LimitLoad2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)2  1103187 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)2  1103187 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)2  1103187 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)2  1103188
        /// </summary>
        public string BrB_LimitStiffness2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)2  1103188 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)2  1103188 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness2 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)2  1103188 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness2 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号3  1103189
        /// </summary>
        public string BrB_Model3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号3  1103189 数据类别
        /// </summary>
        public string RecordTypeBrB_Model3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号3  1103189 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号3  1103189 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数3  1103190
        /// </summary>
        public string BrB_Number3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数3  1103190 数据类别
        /// </summary>
        public string RecordTypeBrB_Number3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数3  1103190 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数3  1103190 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)3  1103191
        /// </summary>
        public string BrB_YieldDrift3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)3  1103191 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)3  1103191 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)3  1103191 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)3  1103192
        /// </summary>
        public string BrB_YieldLoad3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)3  1103192 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)3  1103192 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)3  1103192 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)3  1103193
        /// </summary>
        public string BrB_YieldStiffness3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)3  1103193 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)3  1103193 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)3  1103193 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)3  1103194
        /// </summary>
        public string BrB_LimitLoad3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)3  1103194 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)3  1103194 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)3  1103194 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)3  1103195
        /// </summary>
        public string BrB_LimitStiffness3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)3  1103195 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)3  1103195 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness3 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)3  1103195 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness3 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号4  1103196
        /// </summary>
        public string BrB_Model4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号4  1103196 数据类别
        /// </summary>
        public string RecordTypeBrB_Model4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号4  1103196 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号4  1103196 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数4  1103197
        /// </summary>
        public string BrB_Number4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数4  1103197 数据类别
        /// </summary>
        public string RecordTypeBrB_Number4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数4  1103197 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数4  1103197 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)4  1103198
        /// </summary>
        public string BrB_YieldDrift4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)4  1103198 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)4  1103198 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)4  1103198 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)4  1103199
        /// </summary>
        public string BrB_YieldLoad4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)4  1103199 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)4  1103199 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)4  1103199 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)4  1103200
        /// </summary>
        public string BrB_YieldStiffness4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)4  1103200 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)4  1103200 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)4  1103200 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)4  1103201
        /// </summary>
        public string BrB_LimitLoad4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)4  1103201 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)4  1103201 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)4  1103201 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)4  1103202
        /// </summary>
        public string BrB_LimitStiffness4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)4  1103202 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)4  1103202 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness4 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)4  1103202 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness4 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号5  1103203
        /// </summary>
        public string BrB_Model5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号5  1103203 数据类别
        /// </summary>
        public string RecordTypeBrB_Model5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号5  1103203 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号5  1103203 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数5  1103204
        /// </summary>
        public string BrB_Number5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数5  1103204 数据类别
        /// </summary>
        public string RecordTypeBrB_Number5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数5  1103204 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数5  1103204 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)5  1103205
        /// </summary>
        public string BrB_YieldDrift5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)5  1103205 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)5  1103205 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)5  1103205 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)5  1103206
        /// </summary>
        public string BrB_YieldLoad5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)5  1103206 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)5  1103206 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)5  1103206 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)5  1103207
        /// </summary>
        public string BrB_YieldStiffness5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)5  1103207 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)5  1103207 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)5  1103207 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)5  1103208
        /// </summary>
        public string BrB_LimitLoad5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)5  1103208 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)5  1103208 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)5  1103208 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)5  1103209
        /// </summary>
        public string BrB_LimitStiffness5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)5  1103209 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)5  1103209 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness5 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)5  1103209 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness5 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号6  1103210
        /// </summary>
        public string BrB_Model6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号6  1103210 数据类别
        /// </summary>
        public string RecordTypeBrB_Model6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号6  1103210 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号6  1103210 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数6  1103211
        /// </summary>
        public string BrB_Number6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数6  1103211 数据类别
        /// </summary>
        public string RecordTypeBrB_Number6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数6  1103211 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数6  1103211 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)6  1103212
        /// </summary>
        public string BrB_YieldDrift6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)6  1103212 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)6  1103212 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)6  1103212 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)6  1103213
        /// </summary>
        public string BrB_YieldLoad6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)6  1103213 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)6  1103213 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)6  1103213 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)6  1103214
        /// </summary>
        public string BrB_YieldStiffness6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)6  1103214 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)6  1103214 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)6  1103214 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)6  1103215
        /// </summary>
        public string BrB_LimitLoad6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)6  1103215 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)6  1103215 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)6  1103215 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)6  1103216
        /// </summary>
        public string BrB_LimitStiffness6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)6  1103216 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)6  1103216 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness6 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)6  1103216 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness6 { get; set; }
        /// <summary>
        /// 屈曲约束支撑型号7  1103217
        /// </summary>
        public string BrB_Model7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号7  1103217 数据类别
        /// </summary>
        public string RecordTypeBrB_Model7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号7  1103217 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Model7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑型号7  1103217 是否公开
        /// </summary>
        public bool? IsPublicBrB_Model7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑个数7  1103218
        /// </summary>
        public string BrB_Number7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数7  1103218 数据类别
        /// </summary>
        public string RecordTypeBrB_Number7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数7  1103218 是否必填
        /// </summary>
        public bool? IsRequiredBrB_Number7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑个数7  1103218 是否公开
        /// </summary>
        public bool? IsPublicBrB_Number7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)7  1103219
        /// </summary>
        public string BrB_YieldDrift7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)7  1103219 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldDrift7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)7  1103219 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldDrift7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服位移(mm)7  1103219 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldDrift7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)7  1103220
        /// </summary>
        public string BrB_YieldLoad7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)7  1103220 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldLoad7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)7  1103220 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldLoad7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服荷载 (t)7  1103220 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldLoad7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)7  1103221
        /// </summary>
        public string BrB_YieldStiffness7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)7  1103221 数据类别
        /// </summary>
        public string RecordTypeBrB_YieldStiffness7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)7  1103221 是否必填
        /// </summary>
        public bool? IsRequiredBrB_YieldStiffness7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑屈服后刚度 (t/cm)7  1103221 是否公开
        /// </summary>
        public bool? IsPublicBrB_YieldStiffness7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)7  1103222
        /// </summary>
        public string BrB_LimitLoad7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)7  1103222 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitLoad7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)7  1103222 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitLoad7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限荷载 (t)7  1103222 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitLoad7 { get; set; }
        /// <summary>
        /// 屈曲约束支撑极限位移(mm)7  1103223
        /// </summary>
        public string BrB_LimitStiffness7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)7  1103223 数据类别
        /// </summary>
        public string RecordTypeBrB_LimitStiffness7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)7  1103223 是否必填
        /// </summary>
        public bool? IsRequiredBrB_LimitStiffness7 { get; set; }

        /// <summary>
        /// 屈曲约束支撑极限位移(mm)7  1103223 是否公开
        /// </summary>
        public bool? IsPublicBrB_LimitStiffness7 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号1  1103224
        /// </summary>
        public string Other_Model1 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号1  1103224 数据类别
        /// </summary>
        public string RecordTypeOther_Model1 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号1  1103224 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model1 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号1  1103224 是否公开
        /// </summary>
        public bool? IsPublicOther_Model1 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数1  1103225
        /// </summary>
        public string Other_Number1 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数1  1103225 数据类别
        /// </summary>
        public string RecordTypeOther_Number1 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数1  1103225 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number1 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数1  1103225 是否公开
        /// </summary>
        public bool? IsPublicOther_Number1 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号2  1103226
        /// </summary>
        public string Other_Model2 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号2  1103226 数据类别
        /// </summary>
        public string RecordTypeOther_Model2 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号2  1103226 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model2 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号2  1103226 是否公开
        /// </summary>
        public bool? IsPublicOther_Model2 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数2  1103227
        /// </summary>
        public string Other_Number2 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数2  1103227 数据类别
        /// </summary>
        public string RecordTypeOther_Number2 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数2  1103227 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number2 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数2  1103227 是否公开
        /// </summary>
        public bool? IsPublicOther_Number2 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号3  1103228
        /// </summary>
        public string Other_Model3 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号3  1103228 数据类别
        /// </summary>
        public string RecordTypeOther_Model3 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号3  1103228 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model3 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号3  1103228 是否公开
        /// </summary>
        public bool? IsPublicOther_Model3 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数3  1103229
        /// </summary>
        public string Other_Number3 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数3  1103229 数据类别
        /// </summary>
        public string RecordTypeOther_Number3 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数3  1103229 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number3 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数3  1103229 是否公开
        /// </summary>
        public bool? IsPublicOther_Number3 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号4  1103230
        /// </summary>
        public string Other_Model4 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号4  1103230 数据类别
        /// </summary>
        public string RecordTypeOther_Model4 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号4  1103230 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model4 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号4  1103230 是否公开
        /// </summary>
        public bool? IsPublicOther_Model4 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数4  1103231
        /// </summary>
        public string Other_Number4 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数4  1103231 数据类别
        /// </summary>
        public string RecordTypeOther_Number4 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数4  1103231 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number4 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数4  1103231 是否公开
        /// </summary>
        public bool? IsPublicOther_Number4 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号5  1103232
        /// </summary>
        public string Other_Model5 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号5  1103232 数据类别
        /// </summary>
        public string RecordTypeOther_Model5 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号5  1103232 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model5 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号5  1103232 是否公开
        /// </summary>
        public bool? IsPublicOther_Model5 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数5  1103233
        /// </summary>
        public string Other_Number5 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数5  1103233 数据类别
        /// </summary>
        public string RecordTypeOther_Number5 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数5  1103233 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number5 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数5  1103233 是否公开
        /// </summary>
        public bool? IsPublicOther_Number5 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号6  1103234
        /// </summary>
        public string Other_Model6 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号6  1103234 数据类别
        /// </summary>
        public string RecordTypeOther_Model6 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号6  1103234 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model6 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号6  1103234 是否公开
        /// </summary>
        public bool? IsPublicOther_Model6 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数6  1103235
        /// </summary>
        public string Other_Number6 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数6  1103235 数据类别
        /// </summary>
        public string RecordTypeOther_Number6 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数6  1103235 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number6 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数6  1103235 是否公开
        /// </summary>
        public bool? IsPublicOther_Number6 { get; set; }
        /// <summary>
        /// 其它类型阻尼器型号7  1103236
        /// </summary>
        public string Other_Model7 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号7  1103236 数据类别
        /// </summary>
        public string RecordTypeOther_Model7 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号7  1103236 是否必填
        /// </summary>
        public bool? IsRequiredOther_Model7 { get; set; }

        /// <summary>
        /// 其它类型阻尼器型号7  1103236 是否公开
        /// </summary>
        public bool? IsPublicOther_Model7 { get; set; }
        /// <summary>
        /// 其它类型阻尼器个数7  1103237
        /// </summary>
        public string Other_Number7 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数7  1103237 数据类别
        /// </summary>
        public string RecordTypeOther_Number7 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数7  1103237 是否必填
        /// </summary>
        public bool? IsRequiredOther_Number7 { get; set; }

        /// <summary>
        /// 其它类型阻尼器个数7  1103237 是否公开
        /// </summary>
        public bool? IsPublicOther_Number7 { get; set; }
    }


    /// <summary>
    /// 抗震—技术—技术特点
    /// </summary>
    [Serializable]
    public class Template_1104 : TemplateBase
    {
        /// <summary>
        /// 技术特点  1104001
        /// </summary>
        public string TechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  1104001 数据类别
        /// </summary>
        public string RecordTypeTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  1104001 是否必填
        /// </summary>
        public bool? IsRequiredTechnologyFeature { get; set; }

        /// <summary>
        /// 技术特点  1104001 是否公开
        /// </summary>
        public bool? IsPublicTechnologyFeature { get; set; }
        /// <summary>
        /// 曾获奖项  1104002
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  1104002 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1104002 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  1104002 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  1104003
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1104003 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1104003 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  1104003 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1104004
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1104004 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1104004 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  1104004 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }
}
