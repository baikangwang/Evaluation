using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 建筑结构专项奖申报模板
    /// </summary>
    [Serializable]
    public class Template_06_Architecture : TemplateBase
    {
        /// <summary>
        /// 建筑结构专项奖申报模板—基础信息
        /// </summary>
        public Template_0601 Part_01 { get; set; }

        /// <summary>
        /// 建筑结构专项奖申报模板—技术申报内容
        /// </summary>
        public Template_0602 Part_02 { get; set; }
    }

    /// <summary>
    /// 建筑结构专项奖申报模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_0601 : TemplateBase
    {
        /// <summary>
        /// 项目报优名称  0601001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0601001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0601001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目报优名称  0601001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 立项名称  0601002
        /// </summary>
        public string ApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0601002 数据类别
        /// </summary>
        public string RecordTypeApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0601002 是否必填
        /// </summary>
        public bool? IsRequiredApprovalName { get; set; }

        /// <summary>
        /// 立项名称  0601002 是否公开
        /// </summary>
        public bool? IsPublicApprovalName { get; set; }
        /// <summary>
        /// 申报单位  0601003
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0601003 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0601003 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0601003 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0601004
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0601004 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0601004 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0601004 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0601005
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0601005 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0601005 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0601005 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0601006
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0601006 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0601006 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0601006 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0601007
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0601007 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0601007 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0601007 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0601008
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0601008 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0601008 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0601008 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0601009
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0601009 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0601009 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0601009 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0601010
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0601010 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0601010 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0601010 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 合作单位1  0601011
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0601011 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0601011 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0601011 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0601012
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0601012 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0601012 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0601012 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0601013
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0601013 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0601013 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0601013 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0601014
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0601014 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0601014 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0601014 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0601015
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0601015 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0601015 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0601015 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0601016
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0601016 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0601016 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0601016 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0601017
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0601017 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0601017 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0601017 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0601018
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0601018 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0601018 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0601018 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0601019
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0601019 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0601019 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0601019 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0601020
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0601020 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0601020 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0601020 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0601021
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0601021 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0601021 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0601021 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0601022
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0601022 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0601022 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0601022 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }
        /// <summary>
        /// 建设单位  0601023
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0601023 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0601023 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0601023 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0601024
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0601024 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0601024 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0601024 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 使用单位  0601025
        /// </summary>
        public string UseUnit { get; set; }

        /// <summary>
        /// 使用单位  0601025 数据类别
        /// </summary>
        public string RecordTypeUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0601025 是否必填
        /// </summary>
        public bool? IsRequiredUseUnit { get; set; }

        /// <summary>
        /// 使用单位  0601025 是否公开
        /// </summary>
        public bool? IsPublicUseUnit { get; set; }
        /// <summary>
        /// 建设地点  0601026
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0601026 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0601026 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0601026 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地上  0601027
        /// </summary>
        public string UseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0601027 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0601027 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Overground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地上  0601027 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Overground { get; set; }
        /// <summary>
        /// 建筑功能（使用性质）_地下  0601028
        /// </summary>
        public string UseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0601028 数据类别
        /// </summary>
        public string RecordTypeUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0601028 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty_Underground { get; set; }

        /// <summary>
        /// 建筑功能（使用性质）_地下  0601028 是否公开
        /// </summary>
        public bool? IsPublicUseProperty_Underground { get; set; }
        /// <summary>
        /// 用地性质  0601029
        /// </summary>
        public string LandNature { get; set; }

        /// <summary>
        /// 用地性质  0601029 数据类别
        /// </summary>
        public string RecordTypeLandNature { get; set; }

        /// <summary>
        /// 用地性质  0601029 是否必填
        /// </summary>
        public bool? IsRequiredLandNature { get; set; }

        /// <summary>
        /// 用地性质  0601029 是否公开
        /// </summary>
        public bool? IsPublicLandNature { get; set; }
        /// <summary>
        /// 设计使用年限  0601030
        /// </summary>
        public string DesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0601030 数据类别
        /// </summary>
        public string RecordTypeDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0601030 是否必填
        /// </summary>
        public bool? IsRequiredDesignServiceLife { get; set; }

        /// <summary>
        /// 设计使用年限  0601030 是否公开
        /// </summary>
        public bool? IsPublicDesignServiceLife { get; set; }
        /// <summary>
        /// 总建筑面积  0601031
        /// </summary>
        public string OverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0601031 数据类别
        /// </summary>
        public string RecordTypeOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0601031 是否必填
        /// </summary>
        public bool? IsRequiredOverallFloorage { get; set; }

        /// <summary>
        /// 总建筑面积  0601031 是否公开
        /// </summary>
        public bool? IsPublicOverallFloorage { get; set; }
        /// <summary>
        /// 总用地面积  0601032
        /// </summary>
        public string TotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0601032 数据类别
        /// </summary>
        public string RecordTypeTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0601032 是否必填
        /// </summary>
        public bool? IsRequiredTotalLandArea { get; set; }

        /// <summary>
        /// 总用地面积  0601032 是否公开
        /// </summary>
        public bool? IsPublicTotalLandArea { get; set; }
        /// <summary>
        /// 建筑高度  0601033
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0601033 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0601033 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0601033 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 建筑层数  0601034
        /// </summary>
        public string LayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0601034 数据类别
        /// </summary>
        public string RecordTypeLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0601034 是否必填
        /// </summary>
        public bool? IsRequiredLayerCount { get; set; }

        /// <summary>
        /// 建筑层数  0601034 是否公开
        /// </summary>
        public bool? IsPublicLayerCount { get; set; }
        /// <summary>
        /// 设计类别  0601035
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0601035 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0601035 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0601035 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0601036
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0601036 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0601036 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0601036 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0601037
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0601037 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0601037 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0601037 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 开工时间  0601038
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0601038 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0601038 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 开工时间  0601038 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 竣工时间  0601039
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0601039 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0601039 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0601039 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 竣工验收时间  0601040
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0601040 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0601040 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 竣工验收时间  0601040 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 竣工验收部门  0601041
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0601041 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0601041 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 竣工验收部门  0601041 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 消防备案时间  0601042
        /// </summary>
        public string FireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0601042 数据类别
        /// </summary>
        public string RecordTypeFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0601042 是否必填
        /// </summary>
        public bool? IsRequiredFireControlRecordDate { get; set; }

        /// <summary>
        /// 消防备案时间  0601042 是否公开
        /// </summary>
        public bool? IsPublicFireControlRecordDate { get; set; }
        /// <summary>
        /// 交付使用时间  0601043
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0601043 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0601043 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0601043 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }

        /// <summary>
        /// 专业类别  0601044
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0601044 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0601044 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0601044 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

        /// <summary>
        /// 单位资质  0601045
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 单位资质  0601045 数据类别
        /// </summary>
        public string RecordTypeQualification { get; set; }

        /// <summary>
        /// 单位资质  0601045 是否必填
        /// </summary>
        public bool? IsRequiredQualification { get; set; }

        /// <summary>
        /// 单位资质  0601045 是否公开
        /// </summary>
        public bool? IsPublicQualification { get; set; }

        /// <summary>
        /// 证书编号  0601046
        /// </summary>
        public string CertificateNumber { get; set; }

        /// <summary>
        ///  证书编号  0601046 数据类别
        /// </summary>
        public string RecordTypeCertificateNumber { get; set; }

        /// <summary>
        ///  证书编号  0601046 是否必填
        /// </summary>
        public bool? IsRequiredCertificateNumber { get; set; }

        /// <summary>
        ///  证书编号  0601046 是否公开
        /// </summary>
        public bool? IsPublicCertificateNumber { get; set; }

        /// <summary>
        /// 申报材料目录  0601047
        /// </summary>
        public string FileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0601047 数据类别
        /// </summary>
        public string RecordTypeFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0601047 是否必填
        /// </summary>
        public bool? IsRequiredFileCatalog { get; set; }

        /// <summary>
        /// 申报材料目录  0601047 是否公开
        /// </summary>
        public bool? IsPublicFileCatalog { get; set; }
    }


    /// <summary>
    /// 建筑结构专项奖申报模板—技术申报内容
    /// </summary>
    [Serializable]
    public class Template_0602 : TemplateBase
    {
        /// <summary>
        /// 结构体系  0602001
        /// </summary>
        public string StructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0602001 数据类别
        /// </summary>
        public string RecordTypeStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0602001 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSystem { get; set; }

        /// <summary>
        /// 结构体系  0602001 是否公开
        /// </summary>
        public bool? IsPublicStructuralSystem { get; set; }
        /// <summary>
        /// 抗震设防烈度  0602002
        /// </summary>
        public string SeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0602002 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0602002 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationIntensity { get; set; }

        /// <summary>
        /// 抗震设防烈度  0602002 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationIntensity { get; set; }
        /// <summary>
        /// 抗震设防类别  0602003
        /// </summary>
        public string SeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0602003 数据类别
        /// </summary>
        public string RecordTypeSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0602003 是否必填
        /// </summary>
        public bool? IsRequiredSeismicFortificationCategory { get; set; }

        /// <summary>
        /// 抗震设防类别  0602003 是否公开
        /// </summary>
        public bool? IsPublicSeismicFortificationCategory { get; set; }
        /// <summary>
        /// 基本地震加速度  0602004
        /// </summary>
        public string BasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0602004 数据类别
        /// </summary>
        public string RecordTypeBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0602004 是否必填
        /// </summary>
        public bool? IsRequiredBasicSeismicAcceleration { get; set; }

        /// <summary>
        /// 基本地震加速度  0602004 是否公开
        /// </summary>
        public bool? IsPublicBasicSeismicAcceleration { get; set; }
        /// <summary>
        /// 设计地震分组  0602005
        /// </summary>
        public string EarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0602005 数据类别
        /// </summary>
        public string RecordTypeEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0602005 是否必填
        /// </summary>
        public bool? IsRequiredEarthquakeGrouping { get; set; }

        /// <summary>
        /// 设计地震分组  0602005 是否公开
        /// </summary>
        public bool? IsPublicEarthquakeGrouping { get; set; }
        /// <summary>
        /// 建筑场地土类别  0602006
        /// </summary>
        public string ConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0602006 数据类别
        /// </summary>
        public string RecordTypeConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0602006 是否必填
        /// </summary>
        public bool? IsRequiredConstructionSiteSoilType { get; set; }

        /// <summary>
        /// 建筑场地土类别  0602006 是否公开
        /// </summary>
        public bool? IsPublicConstructionSiteSoilType { get; set; }
        /// <summary>
        /// 基础类型  0602007
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 基础类型  0602007 数据类别
        /// </summary>
        public string RecordTypeBaseType { get; set; }

        /// <summary>
        /// 基础类型  0602007 是否必填
        /// </summary>
        public bool? IsRequiredBaseType { get; set; }

        /// <summary>
        /// 基础类型  0602007 是否公开
        /// </summary>
        public bool? IsPublicBaseType { get; set; }
        /// <summary>
        /// 结构安全等级  0602008
        /// </summary>
        public string StructuralSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0602008 数据类别
        /// </summary>
        public string RecordTypeStructuralSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0602008 是否必填
        /// </summary>
        public bool? IsRequiredStructuralSafetyLevel { get; set; }

        /// <summary>
        /// 结构安全等级  0602008 是否公开
        /// </summary>
        public bool? IsPublicStructuralSafetyLevel { get; set; }
        /// <summary>
        /// 混凝土总用量  0602009
        /// </summary>
        public string ConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0602009 数据类别
        /// </summary>
        public string RecordTypeConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0602009 是否必填
        /// </summary>
        public bool? IsRequiredConcreteAmount { get; set; }

        /// <summary>
        /// 混凝土总用量  0602009 是否公开
        /// </summary>
        public bool? IsPublicConcreteAmount { get; set; }
        /// <summary>
        /// 每平方米混凝土折算厚度  0602010
        /// </summary>
        public string PerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0602010 数据类别
        /// </summary>
        public string RecordTypePerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0602010 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_ConcreteReducedThickness { get; set; }

        /// <summary>
        /// 每平方米混凝土折算厚度  0602010 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_ConcreteReducedThickness { get; set; }
        /// <summary>
        /// 钢材总用量_钢筋  0602011
        /// </summary>
        public string SteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0602011 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0602011 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_rebar { get; set; }

        /// <summary>
        /// 钢材总用量_钢筋  0602011 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_rebar { get; set; }
        /// <summary>
        /// 钢材总用量_型钢  0602012
        /// </summary>
        public string SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0602012 数据类别
        /// </summary>
        public string RecordTypeSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0602012 是否必填
        /// </summary>
        public bool? IsRequiredSteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 钢材总用量_型钢  0602012 是否公开
        /// </summary>
        public bool? IsPublicSteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 每平方米钢材用量_钢筋  0602013
        /// </summary>
        public string PerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0602013 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0602013 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_rebar { get; set; }

        /// <summary>
        /// 每平方米钢材用量_钢筋  0602013 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_rebar { get; set; }
        /// <summary>
        /// 每平方米钢材用量_型钢  0602014
        /// </summary>
        public string PerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0602014 数据类别
        /// </summary>
        public string RecordTypePerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0602014 是否必填
        /// </summary>
        public bool? IsRequiredPerSqM_SteelAmount_SectionSteel { get; set; }

        /// <summary>
        /// 每平方米钢材用量_型钢  0602014 是否公开
        /// </summary>
        public bool? IsPublicPerSqM_SteelAmount_SectionSteel { get; set; }
        /// <summary>
        /// 振型程序名称  0602015
        /// </summary>
        public string ModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0602015 数据类别
        /// </summary>
        public string RecordTypeModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0602015 是否必填
        /// </summary>
        public bool? IsRequiredModeProgramName { get; set; }

        /// <summary>
        /// 振型程序名称  0602015 是否公开
        /// </summary>
        public bool? IsPublicModeProgramName { get; set; }
        /// <summary>
        /// 振型号1  0602016
        /// </summary>
        public string VibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0602016 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0602016 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum1 { get; set; }

        /// <summary>
        /// 振型号1  0602016 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum1 { get; set; }
        /// <summary>
        /// 周期1  0602017
        /// </summary>
        public string VibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0602017 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0602017 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle1 { get; set; }

        /// <summary>
        /// 周期1  0602017 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle1 { get; set; }
        /// <summary>
        /// 转角1  0602018
        /// </summary>
        public string VibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0602018 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0602018 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle1 { get; set; }

        /// <summary>
        /// 转角1  0602018 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle1 { get; set; }
        /// <summary>
        /// 平动系数(x+y)1  0602019
        /// </summary>
        public string TranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0602019 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0602019 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient1 { get; set; }

        /// <summary>
        /// 平动系数(x+y)1  0602019 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient1 { get; set; }
        /// <summary>
        /// 扭转系数1  0602020
        /// </summary>
        public string TorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0602020 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0602020 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient1 { get; set; }

        /// <summary>
        /// 扭转系数1  0602020 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient1 { get; set; }
        /// <summary>
        /// 振型号2  0602021
        /// </summary>
        public string VibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0602021 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0602021 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum2 { get; set; }

        /// <summary>
        /// 振型号2  0602021 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum2 { get; set; }
        /// <summary>
        /// 周期2  0602022
        /// </summary>
        public string VibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0602022 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0602022 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle2 { get; set; }

        /// <summary>
        /// 周期2  0602022 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle2 { get; set; }
        /// <summary>
        /// 转角2  0602023
        /// </summary>
        public string VibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0602023 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0602023 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle2 { get; set; }

        /// <summary>
        /// 转角2  0602023 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle2 { get; set; }
        /// <summary>
        /// 平动系数(x+y)2  0602024
        /// </summary>
        public string TranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0602024 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0602024 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient2 { get; set; }

        /// <summary>
        /// 平动系数(x+y)2  0602024 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient2 { get; set; }
        /// <summary>
        /// 扭转系数2  0602025
        /// </summary>
        public string TorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0602025 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0602025 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient2 { get; set; }

        /// <summary>
        /// 扭转系数2  0602025 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient2 { get; set; }
        /// <summary>
        /// 振型号3  0602026
        /// </summary>
        public string VibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0602026 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0602026 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum3 { get; set; }

        /// <summary>
        /// 振型号3  0602026 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum3 { get; set; }
        /// <summary>
        /// 周期3  0602027
        /// </summary>
        public string VibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0602027 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0602027 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle3 { get; set; }

        /// <summary>
        /// 周期3  0602027 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle3 { get; set; }
        /// <summary>
        /// 转角3  0602028
        /// </summary>
        public string VibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0602028 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0602028 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle3 { get; set; }

        /// <summary>
        /// 转角3  0602028 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle3 { get; set; }
        /// <summary>
        /// 平动系数(x+y)3  0602029
        /// </summary>
        public string TranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0602029 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0602029 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient3 { get; set; }

        /// <summary>
        /// 平动系数(x+y)3  0602029 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient3 { get; set; }
        /// <summary>
        /// 扭转系数3  0602030
        /// </summary>
        public string TorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0602030 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0602030 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient3 { get; set; }

        /// <summary>
        /// 扭转系数3  0602030 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient3 { get; set; }
        /// <summary>
        /// 振型号4  0602031
        /// </summary>
        public string VibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0602031 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0602031 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum4 { get; set; }

        /// <summary>
        /// 振型号4  0602031 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum4 { get; set; }
        /// <summary>
        /// 周期4  0602032
        /// </summary>
        public string VibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0602032 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0602032 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle4 { get; set; }

        /// <summary>
        /// 周期4  0602032 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle4 { get; set; }
        /// <summary>
        /// 转角4  0602033
        /// </summary>
        public string VibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0602033 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0602033 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle4 { get; set; }

        /// <summary>
        /// 转角4  0602033 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle4 { get; set; }
        /// <summary>
        /// 平动系数(x+y)4  0602034
        /// </summary>
        public string TranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0602034 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0602034 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient4 { get; set; }

        /// <summary>
        /// 平动系数(x+y)4  0602034 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient4 { get; set; }
        /// <summary>
        /// 扭转系数4  0602035
        /// </summary>
        public string TorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0602035 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0602035 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient4 { get; set; }

        /// <summary>
        /// 扭转系数4  0602035 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient4 { get; set; }
        /// <summary>
        /// 振型号5  0602036
        /// </summary>
        public string VibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0602036 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0602036 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum5 { get; set; }

        /// <summary>
        /// 振型号5  0602036 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum5 { get; set; }
        /// <summary>
        /// 周期5  0602037
        /// </summary>
        public string VibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0602037 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0602037 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle5 { get; set; }

        /// <summary>
        /// 周期5  0602037 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle5 { get; set; }
        /// <summary>
        /// 转角5  0602038
        /// </summary>
        public string VibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0602038 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0602038 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle5 { get; set; }

        /// <summary>
        /// 转角5  0602038 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle5 { get; set; }
        /// <summary>
        /// 平动系数(x+y)5  0602039
        /// </summary>
        public string TranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0602039 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0602039 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient5 { get; set; }

        /// <summary>
        /// 平动系数(x+y)5  0602039 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient5 { get; set; }
        /// <summary>
        /// 扭转系数5  0602040
        /// </summary>
        public string TorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0602040 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0602040 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient5 { get; set; }

        /// <summary>
        /// 扭转系数5  0602040 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient5 { get; set; }
        /// <summary>
        /// 振型号6  0602041
        /// </summary>
        public string VibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0602041 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0602041 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum6 { get; set; }

        /// <summary>
        /// 振型号6  0602041 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum6 { get; set; }
        /// <summary>
        /// 周期6  0602042
        /// </summary>
        public string VibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0602042 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0602042 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle6 { get; set; }

        /// <summary>
        /// 周期6  0602042 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle6 { get; set; }
        /// <summary>
        /// 转角6  0602043
        /// </summary>
        public string VibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0602043 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0602043 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle6 { get; set; }

        /// <summary>
        /// 转角6  0602043 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle6 { get; set; }
        /// <summary>
        /// 平动系数(x+y)6  0602044
        /// </summary>
        public string TranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0602044 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0602044 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient6 { get; set; }

        /// <summary>
        /// 平动系数(x+y)6  0602044 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient6 { get; set; }
        /// <summary>
        /// 扭转系数6  0602045
        /// </summary>
        public string TorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0602045 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0602045 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient6 { get; set; }

        /// <summary>
        /// 扭转系数6  0602045 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient6 { get; set; }
        /// <summary>
        /// 振型号7  0602046
        /// </summary>
        public string VibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0602046 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0602046 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum7 { get; set; }

        /// <summary>
        /// 振型号7  0602046 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum7 { get; set; }
        /// <summary>
        /// 周期7  0602047
        /// </summary>
        public string VibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0602047 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0602047 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle7 { get; set; }

        /// <summary>
        /// 周期7  0602047 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle7 { get; set; }
        /// <summary>
        /// 转角7  0602048
        /// </summary>
        public string VibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0602048 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0602048 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle7 { get; set; }

        /// <summary>
        /// 转角7  0602048 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle7 { get; set; }
        /// <summary>
        /// 平动系数(x+y)7  0602049
        /// </summary>
        public string TranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0602049 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0602049 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient7 { get; set; }

        /// <summary>
        /// 平动系数(x+y)7  0602049 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient7 { get; set; }
        /// <summary>
        /// 扭转系数7  0602050
        /// </summary>
        public string TorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0602050 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0602050 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient7 { get; set; }

        /// <summary>
        /// 扭转系数7  0602050 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient7 { get; set; }
        /// <summary>
        /// 振型号8  0602051
        /// </summary>
        public string VibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0602051 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0602051 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum8 { get; set; }

        /// <summary>
        /// 振型号8  0602051 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum8 { get; set; }
        /// <summary>
        /// 周期8  0602052
        /// </summary>
        public string VibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0602052 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0602052 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle8 { get; set; }

        /// <summary>
        /// 周期8  0602052 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle8 { get; set; }
        /// <summary>
        /// 转角8  0602053
        /// </summary>
        public string VibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0602053 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0602053 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle8 { get; set; }

        /// <summary>
        /// 转角8  0602053 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle8 { get; set; }
        /// <summary>
        /// 平动系数(x+y)8  0602054
        /// </summary>
        public string TranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0602054 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0602054 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient8 { get; set; }

        /// <summary>
        /// 平动系数(x+y)8  0602054 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient8 { get; set; }
        /// <summary>
        /// 扭转系数8  0602055
        /// </summary>
        public string TorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0602055 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0602055 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient8 { get; set; }

        /// <summary>
        /// 扭转系数8  0602055 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient8 { get; set; }
        /// <summary>
        /// 振型号9  0602056
        /// </summary>
        public string VibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0602056 数据类别
        /// </summary>
        public string RecordTypeVibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0602056 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeNum9 { get; set; }

        /// <summary>
        /// 振型号9  0602056 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeNum9 { get; set; }
        /// <summary>
        /// 周期9  0602057
        /// </summary>
        public string VibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0602057 数据类别
        /// </summary>
        public string RecordTypeVibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0602057 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeCycle9 { get; set; }

        /// <summary>
        /// 周期9  0602057 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeCycle9 { get; set; }
        /// <summary>
        /// 转角9  0602058
        /// </summary>
        public string VibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0602058 数据类别
        /// </summary>
        public string RecordTypeVibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0602058 是否必填
        /// </summary>
        public bool? IsRequiredVibrationModeAngle9 { get; set; }

        /// <summary>
        /// 转角9  0602058 是否公开
        /// </summary>
        public bool? IsPublicVibrationModeAngle9 { get; set; }
        /// <summary>
        /// 平动系数(x+y)9  0602059
        /// </summary>
        public string TranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0602059 数据类别
        /// </summary>
        public string RecordTypeTranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0602059 是否必填
        /// </summary>
        public bool? IsRequiredTranslationalCoefficient9 { get; set; }

        /// <summary>
        /// 平动系数(x+y)9  0602059 是否公开
        /// </summary>
        public bool? IsPublicTranslationalCoefficient9 { get; set; }
        /// <summary>
        /// 扭转系数9  0602060
        /// </summary>
        public string TorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0602060 数据类别
        /// </summary>
        public string RecordTypeTorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0602060 是否必填
        /// </summary>
        public bool? IsRequiredTorsionCoefficient9 { get; set; }

        /// <summary>
        /// 扭转系数9  0602060 是否公开
        /// </summary>
        public bool? IsPublicTorsionCoefficient9 { get; set; }
        /// <summary>
        /// 是否考虑扭转耦联  0602061
        /// </summary>
        public string IsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0602061 数据类别
        /// </summary>
        public string RecordTypeIsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0602061 是否必填
        /// </summary>
        public bool? IsRequiredIsConsiderCoupling { get; set; }

        /// <summary>
        /// 是否考虑扭转耦联  0602061 是否公开
        /// </summary>
        public bool? IsPublicIsConsiderCoupling { get; set; }
        /// <summary>
        /// X向基底剪力(kN)  0602062
        /// </summary>
        public string BaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0602062 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0602062 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X { get; set; }

        /// <summary>
        /// X向基底剪力(kN)  0602062 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)  0602063
        /// </summary>
        public string BaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0602063 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0602063 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)  0602063 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y { get; set; }
        /// <summary>
        /// X向基底剪重比  0602064
        /// </summary>
        public string BasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0602064 数据类别
        /// </summary>
        public string RecordTypeBasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0602064 是否必填
        /// </summary>
        public bool? IsRequiredBasalShearRatio_X { get; set; }

        /// <summary>
        /// X向基底剪重比  0602064 是否公开
        /// </summary>
        public bool? IsPublicBasalShearRatio_X { get; set; }
        /// <summary>
        /// Y向基底剪重比  0602065
        /// </summary>
        public string BasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0602065 数据类别
        /// </summary>
        public string RecordTypeBasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0602065 是否必填
        /// </summary>
        public bool? IsRequiredBasalShearRatio_Y { get; set; }

        /// <summary>
        /// Y向基底剪重比  0602065 是否公开
        /// </summary>
        public bool? IsPublicBasalShearRatio_Y { get; set; }
        /// <summary>
        /// X向最小剪重比（层号）  0602066
        /// </summary>
        public string MinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0602066 数据类别
        /// </summary>
        public string RecordTypeMinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0602066 是否必填
        /// </summary>
        public bool? IsRequiredMinShearWeightRatio_X { get; set; }

        /// <summary>
        /// X向最小剪重比（层号）  0602066 是否公开
        /// </summary>
        public bool? IsPublicMinShearWeightRatio_X { get; set; }
        /// <summary>
        /// Y向最小剪重比（层号）  0602067
        /// </summary>
        public string MinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0602067 数据类别
        /// </summary>
        public string RecordTypeMinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0602067 是否必填
        /// </summary>
        public bool? IsRequiredMinShearWeightRatio_Y { get; set; }

        /// <summary>
        /// Y向最小剪重比（层号）  0602067 是否公开
        /// </summary>
        public bool? IsPublicMinShearWeightRatio_Y { get; set; }
        /// <summary>
        /// X向最大层间位移角  0602068
        /// </summary>
        public string MaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0602068 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0602068 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X { get; set; }

        /// <summary>
        /// X向最大层间位移角  0602068 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X { get; set; }
        /// <summary>
        /// Y向最大层间位移角  0602069
        /// </summary>
        public string MaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0602069 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0602069 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y { get; set; }

        /// <summary>
        /// Y向最大层间位移角  0602069 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y { get; set; }
        /// <summary>
        /// X向最大位移比（层号）  0602070
        /// </summary>
        public string MaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0602070 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0602070 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacementRatio_X { get; set; }

        /// <summary>
        /// X向最大位移比（层号）  0602070 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacementRatio_X { get; set; }
        /// <summary>
        /// Y向最大位移比（层号）  0602071
        /// </summary>
        public string MaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0602071 数据类别
        /// </summary>
        public string RecordTypeMaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0602071 是否必填
        /// </summary>
        public bool? IsRequiredMaxDisplacementRatio_Y { get; set; }

        /// <summary>
        /// Y向最大位移比（层号）  0602071 是否公开
        /// </summary>
        public bool? IsPublicMaxDisplacementRatio_Y { get; set; }
        /// <summary>
        /// 时程分析波名1  0602072
        /// </summary>
        public string TimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0602072 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0602072 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName1 { get; set; }

        /// <summary>
        /// 时程分析波名1  0602072 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName1 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)1  0602073
        /// </summary>
        public string BaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0602073 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0602073 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X1 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)1  0602073 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X1 { get; set; }
        /// <summary>
        /// X向最大层间位移角1  0602074
        /// </summary>
        public string MaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0602074 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0602074 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X1 { get; set; }

        /// <summary>
        /// X向最大层间位移角1  0602074 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X1 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)1  0602075
        /// </summary>
        public string BaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0602075 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0602075 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y1 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)1  0602075 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y1 { get; set; }
        /// <summary>
        /// Y向最大层间位移角1  0602076
        /// </summary>
        public string MaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0602076 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0602076 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y1 { get; set; }

        /// <summary>
        /// Y向最大层间位移角1  0602076 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y1 { get; set; }
        /// <summary>
        /// 时程分析波名2  0602077
        /// </summary>
        public string TimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0602077 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0602077 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName2 { get; set; }

        /// <summary>
        /// 时程分析波名2  0602077 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName2 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)2  0602078
        /// </summary>
        public string BaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0602078 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0602078 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X2 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)2  0602078 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X2 { get; set; }
        /// <summary>
        /// X向最大层间位移角2  0602079
        /// </summary>
        public string MaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0602079 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0602079 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X2 { get; set; }

        /// <summary>
        /// X向最大层间位移角2  0602079 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X2 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)2  0602080
        /// </summary>
        public string BaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0602080 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0602080 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y2 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)2  0602080 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y2 { get; set; }
        /// <summary>
        /// Y向最大层间位移角2  0602081
        /// </summary>
        public string MaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0602081 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0602081 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y2 { get; set; }

        /// <summary>
        /// Y向最大层间位移角2  0602081 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y2 { get; set; }
        /// <summary>
        /// 时程分析波名3  0602082
        /// </summary>
        public string TimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0602082 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0602082 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName3 { get; set; }

        /// <summary>
        /// 时程分析波名3  0602082 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName3 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)3  0602083
        /// </summary>
        public string BaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0602083 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0602083 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X3 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)3  0602083 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X3 { get; set; }
        /// <summary>
        /// X向最大层间位移角3  0602084
        /// </summary>
        public string MaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0602084 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0602084 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X3 { get; set; }

        /// <summary>
        /// X向最大层间位移角3  0602084 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X3 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)3  0602085
        /// </summary>
        public string BaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0602085 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0602085 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y3 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)3  0602085 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y3 { get; set; }
        /// <summary>
        /// Y向最大层间位移角3  0602086
        /// </summary>
        public string MaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0602086 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0602086 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y3 { get; set; }

        /// <summary>
        /// Y向最大层间位移角3  0602086 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y3 { get; set; }
        /// <summary>
        /// 时程分析波名4  0602087
        /// </summary>
        public string TimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0602087 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0602087 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName4 { get; set; }

        /// <summary>
        /// 时程分析波名4  0602087 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName4 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)4  0602088
        /// </summary>
        public string BaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0602088 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0602088 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X4 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)4  0602088 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X4 { get; set; }
        /// <summary>
        /// X向最大层间位移角4  0602089
        /// </summary>
        public string MaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0602089 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0602089 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X4 { get; set; }

        /// <summary>
        /// X向最大层间位移角4  0602089 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X4 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)4  0602090
        /// </summary>
        public string BaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0602090 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0602090 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y4 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)4  0602090 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y4 { get; set; }
        /// <summary>
        /// Y向最大层间位移角4  0602091
        /// </summary>
        public string MaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0602091 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0602091 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y4 { get; set; }

        /// <summary>
        /// Y向最大层间位移角4  0602091 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y4 { get; set; }
        /// <summary>
        /// 时程分析波名5  0602092
        /// </summary>
        public string TimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0602092 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0602092 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName5 { get; set; }

        /// <summary>
        /// 时程分析波名5  0602092 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName5 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)5  0602093
        /// </summary>
        public string BaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0602093 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0602093 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X5 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)5  0602093 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X5 { get; set; }
        /// <summary>
        /// X向最大层间位移角5  0602094
        /// </summary>
        public string MaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0602094 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0602094 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X5 { get; set; }

        /// <summary>
        /// X向最大层间位移角5  0602094 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X5 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)5  0602095
        /// </summary>
        public string BaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0602095 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0602095 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y5 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)5  0602095 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y5 { get; set; }
        /// <summary>
        /// Y向最大层间位移角5  0602096
        /// </summary>
        public string MaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0602096 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0602096 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y5 { get; set; }

        /// <summary>
        /// Y向最大层间位移角5  0602096 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y5 { get; set; }
        /// <summary>
        /// 时程分析波名6  0602097
        /// </summary>
        public string TimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0602097 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0602097 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName6 { get; set; }

        /// <summary>
        /// 时程分析波名6  0602097 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName6 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)6  0602098
        /// </summary>
        public string BaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0602098 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0602098 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X6 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)6  0602098 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X6 { get; set; }
        /// <summary>
        /// X向最大层间位移角6  0602099
        /// </summary>
        public string MaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0602099 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0602099 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X6 { get; set; }

        /// <summary>
        /// X向最大层间位移角6  0602099 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X6 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)6  0602100
        /// </summary>
        public string BaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0602100 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0602100 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y6 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)6  0602100 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y6 { get; set; }
        /// <summary>
        /// Y向最大层间位移角6  0602101
        /// </summary>
        public string MaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0602101 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0602101 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y6 { get; set; }

        /// <summary>
        /// Y向最大层间位移角6  0602101 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y6 { get; set; }
        /// <summary>
        /// 时程分析波名7  0602102
        /// </summary>
        public string TimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0602102 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0602102 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisName7 { get; set; }

        /// <summary>
        /// 时程分析波名7  0602102 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisName7 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)7  0602103
        /// </summary>
        public string BaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0602103 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0602103 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X7 { get; set; }

        /// <summary>
        /// X向基底剪力(kN)7  0602103 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X7 { get; set; }
        /// <summary>
        /// X向最大层间位移角7  0602104
        /// </summary>
        public string MaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0602104 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0602104 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X7 { get; set; }

        /// <summary>
        /// X向最大层间位移角7  0602104 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X7 { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)7  0602105
        /// </summary>
        public string BaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0602105 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0602105 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y7 { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)7  0602105 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y7 { get; set; }
        /// <summary>
        /// Y向最大层间位移角7  0602106
        /// </summary>
        public string MaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0602106 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0602106 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y7 { get; set; }

        /// <summary>
        /// Y向最大层间位移角7  0602106 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y7 { get; set; }
        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0602107
        /// </summary>
        public string BaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0602107 数据类别
        /// </summary>
        public string RecordTypeBaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0602107 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_X_Avg { get; set; }

        /// <summary>
        /// X向基底剪力(kN)_各波平均值  0602107 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_X_Avg { get; set; }
        /// <summary>
        /// X向最大层间位移角_各波平均值  0602108
        /// </summary>
        public string MaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0602108 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0602108 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_X_Avg { get; set; }

        /// <summary>
        /// X向最大层间位移角_各波平均值  0602108 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_X_Avg { get; set; }
        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0602109
        /// </summary>
        public string BaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0602109 数据类别
        /// </summary>
        public string RecordTypeBaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0602109 是否必填
        /// </summary>
        public bool? IsRequiredBaseShear_Y_Avg { get; set; }

        /// <summary>
        /// Y向基底剪力(kN)_各波平均值  0602109 是否公开
        /// </summary>
        public bool? IsPublicBaseShear_Y_Avg { get; set; }
        /// <summary>
        /// Y向最大层间位移角_各波平均值  0602110
        /// </summary>
        public string MaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0602110 数据类别
        /// </summary>
        public string RecordTypeMaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0602110 是否必填
        /// </summary>
        public bool? IsRequiredMaxStoreyDriftAngle_Y_Avg { get; set; }

        /// <summary>
        /// Y向最大层间位移角_各波平均值  0602110 是否公开
        /// </summary>
        public bool? IsPublicMaxStoreyDriftAngle_Y_Avg { get; set; }
        /// <summary>
        /// 结构专业设计主要特点  0602111
        /// </summary>
        public string StructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0602111 数据类别
        /// </summary>
        public string RecordTypeStructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0602111 是否必填
        /// </summary>
        public bool? IsRequiredStructuralFeatures { get; set; }

        /// <summary>
        /// 结构专业设计主要特点  0602111 是否公开
        /// </summary>
        public bool? IsPublicStructuralFeatures { get; set; }

        /// <summary>
        /// 抗震分析程序名  0602112
        /// </summary>
        public string SeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 抗震分析程序名  0602112 数据类别
        /// </summary>
        public string RecordTypeSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 抗震分析程序名  0602112 是否必填
        /// </summary>
        public bool? IsRequiredSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 抗震分析程序名  0602112 是否公开
        /// </summary>
        public bool? IsPublicSeismicAnalysisProgramName { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0602113
        /// </summary>
        public string NoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0602113 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0602113 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_T1(s)  0602113 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0602114
        /// </summary>
        public string NoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0602114 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0602114 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_T1(s)  0602114 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_T1 { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0602115
        /// </summary>
        public string NoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0602115 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0602115 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK(kN)  0602115 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0602116
        /// </summary>
        public string NoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0602116 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0602116 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK(kN)  0602116 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0602117
        /// </summary>
        public string NoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0602117 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0602117 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_FEK/Geq  0602117 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0602118
        /// </summary>
        public string NoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0602118 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0602118 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_FEK/Geq  0602118 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0602119
        /// </summary>
        public string NoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0602119 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0602119 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu (mm)  0602119 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0602120
        /// </summary>
        public string NoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0602120 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0602120 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu (mm)  0602120 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_mm { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0602121
        /// </summary>
        public string NoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0602121 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0602121 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_横向_△Uu/h  0602121 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_H_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0602122
        /// </summary>
        public string NoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0602122 数据类别
        /// </summary>
        public string RecordTypeNoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0602122 是否必填
        /// </summary>
        public bool? IsRequiredNoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 不考虑耦扭联转_纵向_△Uu/h  0602122 是否公开
        /// </summary>
        public bool? IsPublicNoCoupling_V_Uu_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  0602123
        /// </summary>
        public string Coupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  0602123 数据类别
        /// </summary>
        public string RecordTypeCoupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  0602123 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)1  0602123 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  0602124
        /// </summary>
        public string Coupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  0602124 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  0602124 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角1  0602124 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0602125
        /// </summary>
        public string Coupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0602125 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0602125 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数1  0602125 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient1 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  0602126
        /// </summary>
        public string Coupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  0602126 数据类别
        /// </summary>
        public string RecordTypeCoupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  0602126 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)2  0602126 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  0602127
        /// </summary>
        public string Coupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  0602127 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  0602127 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角2  0602127 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0602128
        /// </summary>
        public string Coupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0602128 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0602128 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数2  0602128 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient2 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  0602129
        /// </summary>
        public string Coupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  0602129 数据类别
        /// </summary>
        public string RecordTypeCoupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  0602129 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_T(s)3  0602129 是否公开
        /// </summary>
        public bool? IsPublicCoupling_T3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  0602130
        /// </summary>
        public string Coupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  0602130 数据类别
        /// </summary>
        public string RecordTypeCoupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  0602130 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_转角3  0602130 是否公开
        /// </summary>
        public bool? IsPublicCoupling_Corner3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0602131
        /// </summary>
        public string Coupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0602131 数据类别
        /// </summary>
        public string RecordTypeCoupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0602131 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_扭转系数3  0602131 是否公开
        /// </summary>
        public bool? IsPublicCoupling_TorsionCoefficient3 { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0602132
        /// </summary>
        public string Coupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0602132 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0602132 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK(kN)  0602132 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0602133
        /// </summary>
        public string Coupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0602133 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0602133 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK(kN)  0602133 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_kN { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0602134
        /// </summary>
        public string Coupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0602134 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0602134 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_FEK/Geq  0602134 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0602135
        /// </summary>
        public string Coupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0602135 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0602135 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_FEK/Geq  0602135 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Fek_Geq { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0602136
        /// </summary>
        public string Coupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0602136 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0602136 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu (mm)  0602136 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0602137
        /// </summary>
        public string Coupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0602137 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0602137 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu (mm)  0602137 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_mm { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0602138
        /// </summary>
        public string Coupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0602138 数据类别
        /// </summary>
        public string RecordTypeCoupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0602138 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_横向_△Uu/h  0602138 是否公开
        /// </summary>
        public bool? IsPublicCoupling_H_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0602139
        /// </summary>
        public string Coupling_V_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0602139 数据类别
        /// </summary>
        public string RecordTypeCoupling_V_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0602139 是否必填
        /// </summary>
        public bool? IsRequiredCoupling_V_Ue_h { get; set; }
        /// <summary>
        /// 考虑耦扭联转_纵向_△Uu/h  0602139 是否公开
        /// </summary>
        public bool? IsPublicCoupling_V_Ue_h { get; set; }
        /// <summary>
        /// 地震作用最大方向  0602140
        /// </summary>
        public string MaxActionDirection { get; set; }
        /// <summary>
        /// 地震作用最大方向  0602140 数据类别
        /// </summary>
        public string RecordTypeMaxActionDirection { get; set; }
        /// <summary>
        /// 地震作用最大方向  0602140 是否必填
        /// </summary>
        public bool? IsRequiredMaxActionDirection { get; set; }
        /// <summary>
        /// 地震作用最大方向  0602140 是否公开
        /// </summary>
        public bool? IsPublicMaxActionDirection { get; set; }
        /// <summary>
        /// 时程分析程序名称  0602141
        /// </summary>
        public string TimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程分析程序名称  0602141 数据类别
        /// </summary>
        public string RecordTypeTimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程分析程序名称  0602141 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程分析程序名称  0602141 是否公开
        /// </summary>
        public bool? IsPublicTimeHistoryAnalysisProgramName { get; set; }
        /// <summary>
        /// 时程_波名1  0602142
        /// </summary>
        public string TimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_波名1  0602142 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_波名1  0602142 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_波名1  0602142 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  0602143
        /// </summary>
        public string TimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  0602143 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  0602143 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)1  0602143 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  0602144
        /// </summary>
        public string TimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  0602144 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  0602144 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq1  0602144 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  0602145
        /// </summary>
        public string TimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  0602145 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  0602145 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_△U/h1  0602145 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h1 { get; set; }
        /// <summary>
        /// 时程_波名2  0602146
        /// </summary>
        public string TimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_波名2  0602146 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_波名2  0602146 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_波名2  0602146 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  0602147
        /// </summary>
        public string TimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  0602147 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  0602147 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)2  0602147 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  0602148
        /// </summary>
        public string TimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  0602148 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  0602148 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq2  0602148 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  0602149
        /// </summary>
        public string TimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  0602149 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  0602149 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_△U/h2  0602149 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h2 { get; set; }
        /// <summary>
        /// 时程_波名3  0602150
        /// </summary>
        public string TimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_波名3  0602150 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_波名3  0602150 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_波名3  0602150 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_WaveName3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  0602151
        /// </summary>
        public string TimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  0602151 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  0602151 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK(kN)3  0602151 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_kN3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  0602152
        /// </summary>
        public string TimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  0602152 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  0602152 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_FEK/Geq3  0602152 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_Fek_Geq3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  0602153
        /// </summary>
        public string TimeHistory_U_h3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  0602153 数据类别
        /// </summary>
        public string RecordTypeTimeHistory_U_h3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  0602153 是否必填
        /// </summary>
        public bool? IsRequiredTimeHistory_U_h3 { get; set; }
        /// <summary>
        /// 时程_△U/h3  0602153 是否公开
        /// </summary>
        public bool? IsPublicTimeHistory_U_h3 { get; set; }

        /// <summary>
        /// 曾获奖项  0602154
        /// </summary>
        public string Awards { get; set; }

        /// <summary>
        /// 曾获奖项  0602154 数据类别
        /// </summary>
        public string RecordTypeAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0602154 是否必填
        /// </summary>
        public bool? IsRequiredAwards { get; set; }

        /// <summary>
        /// 曾获奖项  0602154 是否公开
        /// </summary>
        public bool? IsPublicAwards { get; set; }
        /// <summary>
        /// 申报单位意见  0602155
        /// </summary>
        public string UnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0602155 数据类别
        /// </summary>
        public string RecordTypeUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0602155 是否必填
        /// </summary>
        public bool? IsRequiredUnitOpinion { get; set; }

        /// <summary>
        /// 申报单位意见  0602155 是否公开
        /// </summary>
        public bool? IsPublicUnitOpinion { get; set; }
        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0602156
        /// </summary>
        public string RecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0602156 数据类别
        /// </summary>
        public string RecordTypeRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0602156 是否必填
        /// </summary>
        public bool? IsRequiredRecommendOpinion { get; set; }

        /// <summary>
        /// 地方、部门勘察设计同业协会推荐意见  0602156 是否公开
        /// </summary>
        public bool? IsPublicRecommendOpinion { get; set; }

    }

}