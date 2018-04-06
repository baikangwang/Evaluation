using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// BIM模板
    /// </summary>
    [Serializable]
    public class Template_05_BIM : TemplateBase
    {
        /// <summary>
        /// BIM模板—基础信息
        /// </summary>
        public Template_0501 Part_01 { get; set; }

        /// <summary>
        /// BIM模板—技术申报内容（建筑专业）
        /// </summary>
        public Template_0502 Part_02 { get; set; }
    }
    /// <summary>
    /// BIM模板—基础信息
    /// </summary>
    [Serializable]
    public class Template_0501 : TemplateBase
    {
        /// <summary>
        /// 项目名称  0501001
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0501001 数据类别
        /// </summary>
        public string RecordTypeDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0501001 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationName { get; set; }

        /// <summary>
        /// 项目名称  0501001 是否公开
        /// </summary>
        public bool? IsPublicDeclarationName { get; set; }
        /// <summary>
        /// 申报单位  0501002
        /// </summary>
        public string DeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0501002 数据类别
        /// </summary>
        public string RecordTypeDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0501002 是否必填
        /// </summary>
        public bool? IsRequiredDeclarationUnit { get; set; }

        /// <summary>
        /// 申报单位  0501002 是否公开
        /// </summary>
        public bool? IsPublicDeclarationUnit { get; set; }
        /// <summary>
        /// 通讯地址  0501003
        /// </summary>
        public string PostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0501003 数据类别
        /// </summary>
        public string RecordTypePostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0501003 是否必填
        /// </summary>
        public bool? IsRequiredPostalAddress { get; set; }

        /// <summary>
        /// 通讯地址  0501003 是否公开
        /// </summary>
        public bool? IsPublicPostalAddress { get; set; }
        /// <summary>
        /// 联系人  0501004
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 联系人  0501004 数据类别
        /// </summary>
        public string RecordTypeLinkman { get; set; }

        /// <summary>
        /// 联系人  0501004 是否必填
        /// </summary>
        public bool? IsRequiredLinkman { get; set; }

        /// <summary>
        /// 联系人  0501004 是否公开
        /// </summary>
        public bool? IsPublicLinkman { get; set; }
        /// <summary>
        /// 手机  0501005
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 手机  0501005 数据类别
        /// </summary>
        public string RecordTypeMobileNumber { get; set; }

        /// <summary>
        /// 手机  0501005 是否必填
        /// </summary>
        public bool? IsRequiredMobileNumber { get; set; }

        /// <summary>
        /// 手机  0501005 是否公开
        /// </summary>
        public bool? IsPublicMobileNumber { get; set; }
        /// <summary>
        /// 电话  0501006
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0501006 数据类别
        /// </summary>
        public string RecordTypeTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0501006 是否必填
        /// </summary>
        public bool? IsRequiredTelephoneNumber { get; set; }

        /// <summary>
        /// 电话  0501006 是否公开
        /// </summary>
        public bool? IsPublicTelephoneNumber { get; set; }
        /// <summary>
        /// 邮政编码  0501007
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 邮政编码  0501007 数据类别
        /// </summary>
        public string RecordTypePostcode { get; set; }

        /// <summary>
        /// 邮政编码  0501007 是否必填
        /// </summary>
        public bool? IsRequiredPostcode { get; set; }

        /// <summary>
        /// 邮政编码  0501007 是否公开
        /// </summary>
        public bool? IsPublicPostcode { get; set; }
        /// <summary>
        /// 传真  0501008
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 传真  0501008 数据类别
        /// </summary>
        public string RecordTypeFaxNumber { get; set; }

        /// <summary>
        /// 传真  0501008 是否必填
        /// </summary>
        public bool? IsRequiredFaxNumber { get; set; }

        /// <summary>
        /// 传真  0501008 是否公开
        /// </summary>
        public bool? IsPublicFaxNumber { get; set; }
        /// <summary>
        /// 电子邮箱  0501009
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0501009 数据类别
        /// </summary>
        public string RecordTypeEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0501009 是否必填
        /// </summary>
        public bool? IsRequiredEmailAddress { get; set; }

        /// <summary>
        /// 电子邮箱  0501009 是否公开
        /// </summary>
        public bool? IsPublicEmailAddress { get; set; }
        /// <summary>
        /// 建设单位  0501010
        /// </summary>
        public string DevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0501010 数据类别
        /// </summary>
        public string RecordTypeDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0501010 是否必填
        /// </summary>
        public bool? IsRequiredDevelopmentOrganization { get; set; }

        /// <summary>
        /// 建设单位  0501010 是否公开
        /// </summary>
        public bool? IsPublicDevelopmentOrganization { get; set; }
        /// <summary>
        /// 施工单位  0501011
        /// </summary>
        public string ConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0501011 数据类别
        /// </summary>
        public string RecordTypeConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0501011 是否必填
        /// </summary>
        public bool? IsRequiredConstructionOrganization { get; set; }

        /// <summary>
        /// 施工单位  0501011 是否公开
        /// </summary>
        public bool? IsPublicConstructionOrganization { get; set; }
        /// <summary>
        /// 建设地点  0501012
        /// </summary>
        public string ConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0501012 数据类别
        /// </summary>
        public string RecordTypeConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0501012 是否必填
        /// </summary>
        public bool? IsRequiredConstructionLocation { get; set; }

        /// <summary>
        /// 建设地点  0501012 是否公开
        /// </summary>
        public bool? IsPublicConstructionLocation { get; set; }
        /// <summary>
        /// 设计类别  0501013
        /// </summary>
        public string DesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0501013 数据类别
        /// </summary>
        public string RecordTypeDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0501013 是否必填
        /// </summary>
        public bool? IsRequiredDesignCategory { get; set; }

        /// <summary>
        /// 设计类别  0501013 是否公开
        /// </summary>
        public bool? IsPublicDesignCategory { get; set; }
        /// <summary>
        /// 设计起止时间_起始时间  0501014
        /// </summary>
        public string DesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0501014 数据类别
        /// </summary>
        public string RecordTypeDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0501014 是否必填
        /// </summary>
        public bool? IsRequiredDesignStartDate { get; set; }

        /// <summary>
        /// 设计起止时间_起始时间  0501014 是否公开
        /// </summary>
        public bool? IsPublicDesignStartDate { get; set; }
        /// <summary>
        /// 设计起止时间_结束时间  0501015
        /// </summary>
        public string DesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0501015 数据类别
        /// </summary>
        public string RecordTypeDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0501015 是否必填
        /// </summary>
        public bool? IsRequiredDesignEndDate { get; set; }

        /// <summary>
        /// 设计起止时间_结束时间  0501015 是否公开
        /// </summary>
        public bool? IsPublicDesignEndDate { get; set; }
        /// <summary>
        /// 建设时间  0501016
        /// </summary>
        public string ConstructionStartDate { get; set; }

        /// <summary>
        /// 建设时间  0501016 数据类别
        /// </summary>
        public string RecordTypeConstructionStartDate { get; set; }

        /// <summary>
        /// 建设时间  0501016 是否必填
        /// </summary>
        public bool? IsRequiredConstructionStartDate { get; set; }

        /// <summary>
        /// 建设时间  0501016 是否公开
        /// </summary>
        public bool? IsPublicConstructionStartDate { get; set; }
        /// <summary>
        /// 交付使用时间  0501017
        /// </summary>
        public string DeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0501017 数据类别
        /// </summary>
        public string RecordTypeDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0501017 是否必填
        /// </summary>
        public bool? IsRequiredDeliveryDate { get; set; }

        /// <summary>
        /// 交付使用时间  0501017 是否公开
        /// </summary>
        public bool? IsPublicDeliveryDate { get; set; }
        /// <summary>
        /// 竣工时间  0501018
        /// </summary>
        public string ConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0501018 数据类别
        /// </summary>
        public string RecordTypeConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0501018 是否必填
        /// </summary>
        public bool? IsRequiredConstructionEndDate { get; set; }

        /// <summary>
        /// 竣工时间  0501018 是否公开
        /// </summary>
        public bool? IsPublicConstructionEndDate { get; set; }
        /// <summary>
        /// 验收时间  0501019
        /// </summary>
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  0501019 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  0501019 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDate { get; set; }

        /// <summary>
        /// 验收时间  0501019 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDate { get; set; }
        /// <summary>
        /// 验收部门  0501020
        /// </summary>
        public string AcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0501020 数据类别
        /// </summary>
        public string RecordTypeAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0501020 是否必填
        /// </summary>
        public bool? IsRequiredAcceptanceDepartment { get; set; }

        /// <summary>
        /// 验收部门  0501020 是否公开
        /// </summary>
        public bool? IsPublicAcceptanceDepartment { get; set; }
        /// <summary>
        /// 建筑规模  0501021
        /// </summary>
        public string BuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0501021 数据类别
        /// </summary>
        public string RecordTypeBuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0501021 是否必填
        /// </summary>
        public bool? IsRequiredBuildingScale { get; set; }

        /// <summary>
        /// 建筑规模  0501021 是否公开
        /// </summary>
        public bool? IsPublicBuildingScale { get; set; }
        /// <summary>
        /// 建筑用途（性质）  0501022
        /// </summary>
        public string UseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0501022 数据类别
        /// </summary>
        public string RecordTypeUseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0501022 是否必填
        /// </summary>
        public bool? IsRequiredUseProperty { get; set; }

        /// <summary>
        /// 建筑用途（性质）  0501022 是否公开
        /// </summary>
        public bool? IsPublicUseProperty { get; set; }
        /// <summary>
        /// 建筑高度  0501023
        /// </summary>
        public string BuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0501023 数据类别
        /// </summary>
        public string RecordTypeBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0501023 是否必填
        /// </summary>
        public bool? IsRequiredBuildingHeight { get; set; }

        /// <summary>
        /// 建筑高度  0501023 是否公开
        /// </summary>
        public bool? IsPublicBuildingHeight { get; set; }
        /// <summary>
        /// 地上层数  0501024
        /// </summary>
        public string Layer_Ground { get; set; }

        /// <summary>
        /// 地上层数  0501024 数据类别
        /// </summary>
        public string RecordTypeLayer_Ground { get; set; }

        /// <summary>
        /// 地上层数  0501024 是否必填
        /// </summary>
        public bool? IsRequiredLayer_Ground { get; set; }

        /// <summary>
        /// 地上层数  0501024 是否公开
        /// </summary>
        public bool? IsPublicLayer_Ground { get; set; }
        /// <summary>
        /// 地下层数  0501025
        /// </summary>
        public string Layer_Underground { get; set; }

        /// <summary>
        /// 地下层数  0501025 数据类别
        /// </summary>
        public string RecordTypeLayer_Underground { get; set; }

        /// <summary>
        /// 地下层数  0501025 是否必填
        /// </summary>
        public bool? IsRequiredLayer_Underground { get; set; }

        /// <summary>
        /// 地下层数  0501025 是否公开
        /// </summary>
        public bool? IsPublicLayer_Underground { get; set; }
        /// <summary>
        /// 合作单位1  0501026
        /// </summary>
        public string CooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0501026 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0501026 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit1 { get; set; }

        /// <summary>
        /// 合作单位1  0501026 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit1 { get; set; }
        /// <summary>
        /// 国内国外1  0501027
        /// </summary>
        public string DomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0501027 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0501027 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord1 { get; set; }

        /// <summary>
        /// 国内国外1  0501027 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord1 { get; set; }
        /// <summary>
        /// 合作设计阶段1  0501028
        /// </summary>
        public string CollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0501028 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0501028 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase1 { get; set; }

        /// <summary>
        /// 合作设计阶段1  0501028 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase1 { get; set; }
        /// <summary>
        /// 合作单位2  0501029
        /// </summary>
        public string CooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0501029 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0501029 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit2 { get; set; }

        /// <summary>
        /// 合作单位2  0501029 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit2 { get; set; }
        /// <summary>
        /// 国内国外2  0501030
        /// </summary>
        public string DomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0501030 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0501030 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord2 { get; set; }

        /// <summary>
        /// 国内国外2  0501030 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord2 { get; set; }
        /// <summary>
        /// 合作设计阶段2  0501031
        /// </summary>
        public string CollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0501031 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0501031 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase2 { get; set; }

        /// <summary>
        /// 合作设计阶段2  0501031 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase2 { get; set; }
        /// <summary>
        /// 合作单位3  0501032
        /// </summary>
        public string CooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0501032 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0501032 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit3 { get; set; }

        /// <summary>
        /// 合作单位3  0501032 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit3 { get; set; }
        /// <summary>
        /// 国内国外3  0501033
        /// </summary>
        public string DomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0501033 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0501033 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord3 { get; set; }

        /// <summary>
        /// 国内国外3  0501033 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord3 { get; set; }
        /// <summary>
        /// 合作设计阶段3  0501034
        /// </summary>
        public string CollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0501034 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0501034 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase3 { get; set; }

        /// <summary>
        /// 合作设计阶段3  0501034 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase3 { get; set; }
        /// <summary>
        /// 合作单位4  0501035
        /// </summary>
        public string CooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0501035 数据类别
        /// </summary>
        public string RecordTypeCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0501035 是否必填
        /// </summary>
        public bool? IsRequiredCooperativeUnit4 { get; set; }

        /// <summary>
        /// 合作单位4  0501035 是否公开
        /// </summary>
        public bool? IsPublicCooperativeUnit4 { get; set; }
        /// <summary>
        /// 国内国外4  0501036
        /// </summary>
        public string DomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0501036 数据类别
        /// </summary>
        public string RecordTypeDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0501036 是否必填
        /// </summary>
        public bool? IsRequiredDomesticOrAbord4 { get; set; }

        /// <summary>
        /// 国内国外4  0501036 是否公开
        /// </summary>
        public bool? IsPublicDomesticOrAbord4 { get; set; }
        /// <summary>
        /// 合作设计阶段4  0501037
        /// </summary>
        public string CollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0501037 数据类别
        /// </summary>
        public string RecordTypeCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0501037 是否必填
        /// </summary>
        public bool? IsRequiredCollaborativePhase4 { get; set; }

        /// <summary>
        /// 合作设计阶段4  0501037 是否公开
        /// </summary>
        public bool? IsPublicCollaborativePhase4 { get; set; }

        /// <summary>
        /// 专业类别  0501038
        /// </summary>
        public string ProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0501038 数据类别
        /// </summary>
        public string RecordTypeProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0501038 是否必填
        /// </summary>
        public bool? IsRequiredProfessionalCategories { get; set; }

        /// <summary>
        /// 专业类别   0501038 是否公开
        /// </summary>
        public bool? IsPublicProfessionalCategories { get; set; }

    }


    /// <summary>
    /// BIM模板—技术申报内容（建筑专业）
    /// </summary>
    [Serializable]
    public class Template_0502 : TemplateBase
    {
        /// <summary>
        /// BIM软件名称  0502001
        /// </summary>
        public string BIMName { get; set; }

        /// <summary>
        /// BIM软件名称  0502001 数据类别
        /// </summary>
        public string RecordTypeBIMName { get; set; }

        /// <summary>
        /// BIM软件名称  0502001 是否必填
        /// </summary>
        public bool? IsRequiredBIMName { get; set; }

        /// <summary>
        /// BIM软件名称  0502001 是否公开
        /// </summary>
        public bool? IsPublicBIMName { get; set; }
        /// <summary>
        /// 建筑_规划方案  0502002
        /// </summary>
        public string Building_PlanningScheme { get; set; }

        /// <summary>
        /// 建筑_规划方案  0502002 数据类别
        /// </summary>
        public string RecordTypeBuilding_PlanningScheme { get; set; }

        /// <summary>
        /// 建筑_规划方案  0502002 是否必填
        /// </summary>
        public bool? IsRequiredBuilding_PlanningScheme { get; set; }

        /// <summary>
        /// 建筑_规划方案  0502002 是否公开
        /// </summary>
        public bool? IsPublicBuilding_PlanningScheme { get; set; }
        /// <summary>
        /// 建筑_初步设计  0502003
        /// </summary>
        public string Building_PreliminaryDesign { get; set; }

        /// <summary>
        /// 建筑_初步设计  0502003 数据类别
        /// </summary>
        public string RecordTypeBuilding_PreliminaryDesign { get; set; }

        /// <summary>
        /// 建筑_初步设计  0502003 是否必填
        /// </summary>
        public bool? IsRequiredBuilding_PreliminaryDesign { get; set; }

        /// <summary>
        /// 建筑_初步设计  0502003 是否公开
        /// </summary>
        public bool? IsPublicBuilding_PreliminaryDesign { get; set; }
        /// <summary>
        /// 建筑_施工图   0502004
        /// </summary>
        public string Building_Construction_Plans { get; set; }

        /// <summary>
        /// 建筑_施工图   0502004 数据类别
        /// </summary>
        public string RecordTypeBuilding_Construction_Plans { get; set; }

        /// <summary>
        /// 建筑_施工图   0502004 是否必填
        /// </summary>
        public bool? IsRequiredBuilding_Construction_Plans { get; set; }

        /// <summary>
        /// 建筑_施工图   0502004 是否公开
        /// </summary>
        public bool? IsPublicBuilding_Construction_Plans { get; set; }
        /// <summary>
        /// 建筑_施工    0502005
        /// </summary>
        public string Building_Construction { get; set; }

        /// <summary>
        /// 建筑_施工    0502005 数据类别
        /// </summary>
        public string RecordTypeBuilding_Construction { get; set; }

        /// <summary>
        /// 建筑_施工    0502005 是否必填
        /// </summary>
        public bool? IsRequiredBuilding_Construction { get; set; }

        /// <summary>
        /// 建筑_施工    0502005 是否公开
        /// </summary>
        public bool? IsPublicBuilding_Construction { get; set; }
        /// <summary>
        /// 建筑_运营维护  0502006
        /// </summary>
        public string Building_Operation { get; set; }

        /// <summary>
        /// 建筑_运营维护  0502006 数据类别
        /// </summary>
        public string RecordTypeBuilding_Operation { get; set; }

        /// <summary>
        /// 建筑_运营维护  0502006 是否必填
        /// </summary>
        public bool? IsRequiredBuilding_Operation { get; set; }

        /// <summary>
        /// 建筑_运营维护  0502006 是否公开
        /// </summary>
        public bool? IsPublicBuilding_Operation { get; set; }
        /// <summary>
        /// 结构_规划方案  0502007
        /// </summary>
        public string Architecture_PlanningScheme { get; set; }

        /// <summary>
        /// 结构_规划方案  0502007 数据类别
        /// </summary>
        public string RecordTypeArchitecture_PlanningScheme { get; set; }

        /// <summary>
        /// 结构_规划方案  0502007 是否必填
        /// </summary>
        public bool? IsRequiredArchitecture_PlanningScheme { get; set; }

        /// <summary>
        /// 结构_规划方案  0502007 是否公开
        /// </summary>
        public bool? IsPublicArchitecture_PlanningScheme { get; set; }
        /// <summary>
        /// 结构_初步设计  0502008
        /// </summary>
        public string Architecture_PreliminaryDesign { get; set; }

        /// <summary>
        /// 结构_初步设计  0502008 数据类别
        /// </summary>
        public string RecordTypeArchitecture_PreliminaryDesign { get; set; }

        /// <summary>
        /// 结构_初步设计  0502008 是否必填
        /// </summary>
        public bool? IsRequiredArchitecture_PreliminaryDesign { get; set; }

        /// <summary>
        /// 结构_初步设计  0502008 是否公开
        /// </summary>
        public bool? IsPublicArchitecture_PreliminaryDesign { get; set; }
        /// <summary>
        /// 结构_施工图   0502009
        /// </summary>
        public string Architecture_Construction_Plans { get; set; }

        /// <summary>
        /// 结构_施工图   0502009 数据类别
        /// </summary>
        public string RecordTypeArchitecture_Construction_Plans { get; set; }

        /// <summary>
        /// 结构_施工图   0502009 是否必填
        /// </summary>
        public bool? IsRequiredArchitecture_Construction_Plans { get; set; }

        /// <summary>
        /// 结构_施工图   0502009 是否公开
        /// </summary>
        public bool? IsPublicArchitecture_Construction_Plans { get; set; }
        /// <summary>
        /// 结构_施工  0502010
        /// </summary>
        public string Architecture_Construction { get; set; }

        /// <summary>
        /// 结构_施工  0502010 数据类别
        /// </summary>
        public string RecordTypeArchitecture_Construction { get; set; }

        /// <summary>
        /// 结构_施工  0502010 是否必填
        /// </summary>
        public bool? IsRequiredArchitecture_Construction { get; set; }

        /// <summary>
        /// 结构_施工  0502010 是否公开
        /// </summary>
        public bool? IsPublicArchitecture_Construction { get; set; }
        /// <summary>
        /// 结构_运营维护  0502011
        /// </summary>
        public string Architecture_Operation { get; set; }

        /// <summary>
        /// 结构_运营维护  0502011 数据类别
        /// </summary>
        public string RecordTypeArchitecture_Operation { get; set; }

        /// <summary>
        /// 结构_运营维护  0502011 是否必填
        /// </summary>
        public bool? IsRequiredArchitecture_Operation { get; set; }

        /// <summary>
        /// 结构_运营维护  0502011 是否公开
        /// </summary>
        public bool? IsPublicArchitecture_Operation { get; set; }
        /// <summary>
        /// 水_规划方案  0502012
        /// </summary>
        public string Water_PlanningScheme { get; set; }

        /// <summary>
        /// 水_规划方案  0502012 数据类别
        /// </summary>
        public string RecordTypeWater_PlanningScheme { get; set; }

        /// <summary>
        /// 水_规划方案  0502012 是否必填
        /// </summary>
        public bool? IsRequiredWater_PlanningScheme { get; set; }

        /// <summary>
        /// 水_规划方案  0502012 是否公开
        /// </summary>
        public bool? IsPublicWater_PlanningScheme { get; set; }
        /// <summary>
        /// 水_初步设计  0502013
        /// </summary>
        public string Water_PreliminaryDesign { get; set; }

        /// <summary>
        /// 水_初步设计  0502013 数据类别
        /// </summary>
        public string RecordTypeWater_PreliminaryDesign { get; set; }

        /// <summary>
        /// 水_初步设计  0502013 是否必填
        /// </summary>
        public bool? IsRequiredWater_PreliminaryDesign { get; set; }

        /// <summary>
        /// 水_初步设计  0502013 是否公开
        /// </summary>
        public bool? IsPublicWater_PreliminaryDesign { get; set; }
        /// <summary>
        /// 水_施工图   0502014
        /// </summary>
        public string Water_Construction_Plans { get; set; }

        /// <summary>
        /// 水_施工图   0502014 数据类别
        /// </summary>
        public string RecordTypeWater_Construction_Plans { get; set; }

        /// <summary>
        /// 水_施工图   0502014 是否必填
        /// </summary>
        public bool? IsRequiredWater_Construction_Plans { get; set; }

        /// <summary>
        /// 水_施工图   0502014 是否公开
        /// </summary>
        public bool? IsPublicWater_Construction_Plans { get; set; }
        /// <summary>
        /// 水_施工    0502015
        /// </summary>
        public string Water_Construction { get; set; }

        /// <summary>
        /// 水_施工    0502015 数据类别
        /// </summary>
        public string RecordTypeWater_Construction { get; set; }

        /// <summary>
        /// 水_施工    0502015 是否必填
        /// </summary>
        public bool? IsRequiredWater_Construction { get; set; }

        /// <summary>
        /// 水_施工    0502015 是否公开
        /// </summary>
        public bool? IsPublicWater_Construction { get; set; }
        /// <summary>
        /// 水_运营维护  0502016
        /// </summary>
        public string Water_Operation { get; set; }

        /// <summary>
        /// 水_运营维护  0502016 数据类别
        /// </summary>
        public string RecordTypeWater_Operation { get; set; }

        /// <summary>
        /// 水_运营维护  0502016 是否必填
        /// </summary>
        public bool? IsRequiredWater_Operation { get; set; }

        /// <summary>
        /// 水_运营维护  0502016 是否公开
        /// </summary>
        public bool? IsPublicWater_Operation { get; set; }
        /// <summary>
        /// 电气_规划方案  0502017
        /// </summary>
        public string Electric_PlanningScheme { get; set; }

        /// <summary>
        /// 电气_规划方案  0502017 数据类别
        /// </summary>
        public string RecordTypeElectric_PlanningScheme { get; set; }

        /// <summary>
        /// 电气_规划方案  0502017 是否必填
        /// </summary>
        public bool? IsRequiredElectric_PlanningScheme { get; set; }

        /// <summary>
        /// 电气_规划方案  0502017 是否公开
        /// </summary>
        public bool? IsPublicElectric_PlanningScheme { get; set; }
        /// <summary>
        /// 电气_初步设计  0502018
        /// </summary>
        public string Electric_PreliminaryDesign { get; set; }

        /// <summary>
        /// 电气_初步设计  0502018 数据类别
        /// </summary>
        public string RecordTypeElectric_PreliminaryDesign { get; set; }

        /// <summary>
        /// 电气_初步设计  0502018 是否必填
        /// </summary>
        public bool? IsRequiredElectric_PreliminaryDesign { get; set; }

        /// <summary>
        /// 电气_初步设计  0502018 是否公开
        /// </summary>
        public bool? IsPublicElectric_PreliminaryDesign { get; set; }
        /// <summary>
        /// 电气_施工图   0502019
        /// </summary>
        public string Electric_Construction_Plans { get; set; }

        /// <summary>
        /// 电气_施工图   0502019 数据类别
        /// </summary>
        public string RecordTypeElectric_Construction_Plans { get; set; }

        /// <summary>
        /// 电气_施工图   0502019 是否必填
        /// </summary>
        public bool? IsRequiredElectric_Construction_Plans { get; set; }

        /// <summary>
        /// 电气_施工图   0502019 是否公开
        /// </summary>
        public bool? IsPublicElectric_Construction_Plans { get; set; }
        /// <summary>
        /// 电气_施工    0502020
        /// </summary>
        public string Electric_Construction { get; set; }

        /// <summary>
        /// 电气_施工    0502020 数据类别
        /// </summary>
        public string RecordTypeElectric_Construction { get; set; }

        /// <summary>
        /// 电气_施工    0502020 是否必填
        /// </summary>
        public bool? IsRequiredElectric_Construction { get; set; }

        /// <summary>
        /// 电气_施工    0502020 是否公开
        /// </summary>
        public bool? IsPublicElectric_Construction { get; set; }
        /// <summary>
        /// 电气_运营维护  0502021
        /// </summary>
        public string Electric_Operation { get; set; }

        /// <summary>
        /// 电气_运营维护  0502021 数据类别
        /// </summary>
        public string RecordTypeElectric_Operation { get; set; }

        /// <summary>
        /// 电气_运营维护  0502021 是否必填
        /// </summary>
        public bool? IsRequiredElectric_Operation { get; set; }

        /// <summary>
        /// 电气_运营维护  0502021 是否公开
        /// </summary>
        public bool? IsPublicElectric_Operation { get; set; }
        /// <summary>
        /// 暖通_规划方案  0502022
        /// </summary>
        public string HVAC_PlanningScheme { get; set; }

        /// <summary>
        /// 暖通_规划方案  0502022 数据类别
        /// </summary>
        public string RecordTypeHVAC_PlanningScheme { get; set; }

        /// <summary>
        /// 暖通_规划方案  0502022 是否必填
        /// </summary>
        public bool? IsRequiredHVAC_PlanningScheme { get; set; }

        /// <summary>
        /// 暖通_规划方案  0502022 是否公开
        /// </summary>
        public bool? IsPublicHVAC_PlanningScheme { get; set; }
        /// <summary>
        /// 暖通_初步设计  0502023
        /// </summary>
        public string HVAC_PreliminaryDesign { get; set; }

        /// <summary>
        /// 暖通_初步设计  0502023 数据类别
        /// </summary>
        public string RecordTypeHVAC_PreliminaryDesign { get; set; }

        /// <summary>
        /// 暖通_初步设计  0502023 是否必填
        /// </summary>
        public bool? IsRequiredHVAC_PreliminaryDesign { get; set; }

        /// <summary>
        /// 暖通_初步设计  0502023 是否公开
        /// </summary>
        public bool? IsPublicHVAC_PreliminaryDesign { get; set; }
        /// <summary>
        /// 暖通_施工图   0502024
        /// </summary>
        public string HVAC_Construction_Plans { get; set; }

        /// <summary>
        /// 暖通_施工图   0502024 数据类别
        /// </summary>
        public string RecordTypeHVAC_Construction_Plans { get; set; }

        /// <summary>
        /// 暖通_施工图   0502024 是否必填
        /// </summary>
        public bool? IsRequiredHVAC_Construction_Plans { get; set; }

        /// <summary>
        /// 暖通_施工图   0502024 是否公开
        /// </summary>
        public bool? IsPublicHVAC_Construction_Plans { get; set; }
        /// <summary>
        /// 暖通_施工    0502025
        /// </summary>
        public string HVAC_Construction { get; set; }

        /// <summary>
        /// 暖通_施工    0502025 数据类别
        /// </summary>
        public string RecordTypeHVAC_Construction { get; set; }

        /// <summary>
        /// 暖通_施工    0502025 是否必填
        /// </summary>
        public bool? IsRequiredHVAC_Construction { get; set; }

        /// <summary>
        /// 暖通_施工    0502025 是否公开
        /// </summary>
        public bool? IsPublicHVAC_Construction { get; set; }
        /// <summary>
        /// 暖通_运营维护  0502026
        /// </summary>
        public string HVAC_Operation { get; set; }

        /// <summary>
        /// 暖通_运营维护  0502026 数据类别
        /// </summary>
        public string RecordTypeHVAC_Operation { get; set; }

        /// <summary>
        /// 暖通_运营维护  0502026 是否必填
        /// </summary>
        public bool? IsRequiredHVAC_Operation { get; set; }

        /// <summary>
        /// 暖通_运营维护  0502026 是否公开
        /// </summary>
        public bool? IsPublicHVAC_Operation { get; set; }
        /// <summary>
        /// 总图_规划方案  0502027
        /// </summary>
        public string GeneralPlan_PlanningScheme { get; set; }

        /// <summary>
        /// 总图_规划方案  0502027 数据类别
        /// </summary>
        public string RecordTypeGeneralPlan_PlanningScheme { get; set; }

        /// <summary>
        /// 总图_规划方案  0502027 是否必填
        /// </summary>
        public bool? IsRequiredGeneralPlan_PlanningScheme { get; set; }

        /// <summary>
        /// 总图_规划方案  0502027 是否公开
        /// </summary>
        public bool? IsPublicGeneralPlan_PlanningScheme { get; set; }
        /// <summary>
        /// 总图_初步设计  0502028
        /// </summary>
        public string GeneralPlan_PreliminaryDesign { get; set; }

        /// <summary>
        /// 总图_初步设计  0502028 数据类别
        /// </summary>
        public string RecordTypeGeneralPlan_PreliminaryDesign { get; set; }

        /// <summary>
        /// 总图_初步设计  0502028 是否必填
        /// </summary>
        public bool? IsRequiredGeneralPlan_PreliminaryDesign { get; set; }

        /// <summary>
        /// 总图_初步设计  0502028 是否公开
        /// </summary>
        public bool? IsPublicGeneralPlan_PreliminaryDesign { get; set; }
        /// <summary>
        /// 总图_施工图   0502029
        /// </summary>
        public string GeneralPlan_Construction_Plans { get; set; }

        /// <summary>
        /// 总图_施工图   0502029 数据类别
        /// </summary>
        public string RecordTypeGeneralPlan_Construction_Plans { get; set; }

        /// <summary>
        /// 总图_施工图   0502029 是否必填
        /// </summary>
        public bool? IsRequiredGeneralPlan_Construction_Plans { get; set; }

        /// <summary>
        /// 总图_施工图   0502029 是否公开
        /// </summary>
        public bool? IsPublicGeneralPlan_Construction_Plans { get; set; }
        /// <summary>
        /// 总图_施工    0502030
        /// </summary>
        public string GeneralPlan_Construction { get; set; }

        /// <summary>
        /// 总图_施工    0502030 数据类别
        /// </summary>
        public string RecordTypeGeneralPlan_Construction { get; set; }

        /// <summary>
        /// 总图_施工    0502030 是否必填
        /// </summary>
        public bool? IsRequiredGeneralPlan_Construction { get; set; }

        /// <summary>
        /// 总图_施工    0502030 是否公开
        /// </summary>
        public bool? IsPublicGeneralPlan_Construction { get; set; }
        /// <summary>
        /// 总图_运营维护  0502031
        /// </summary>
        public string GeneralPlan_Operation { get; set; }

        /// <summary>
        /// 总图_运营维护  0502031 数据类别
        /// </summary>
        public string RecordTypeGeneralPlan_Operation { get; set; }

        /// <summary>
        /// 总图_运营维护  0502031 是否必填
        /// </summary>
        public bool? IsRequiredGeneralPlan_Operation { get; set; }

        /// <summary>
        /// 总图_运营维护  0502031 是否公开
        /// </summary>
        public bool? IsPublicGeneralPlan_Operation { get; set; }
        /// <summary>
        /// 经济_规划方案  0502032
        /// </summary>
        public string Economics_PlanningScheme { get; set; }

        /// <summary>
        /// 经济_规划方案  0502032 数据类别
        /// </summary>
        public string RecordTypeEconomics_PlanningScheme { get; set; }

        /// <summary>
        /// 经济_规划方案  0502032 是否必填
        /// </summary>
        public bool? IsRequiredEconomics_PlanningScheme { get; set; }

        /// <summary>
        /// 经济_规划方案  0502032 是否公开
        /// </summary>
        public bool? IsPublicEconomics_PlanningScheme { get; set; }
        /// <summary>
        /// 经济_初步设计  0502033
        /// </summary>
        public string Economics_PreliminaryDesign { get; set; }

        /// <summary>
        /// 经济_初步设计  0502033 数据类别
        /// </summary>
        public string RecordTypeEconomics_PreliminaryDesign { get; set; }

        /// <summary>
        /// 经济_初步设计  0502033 是否必填
        /// </summary>
        public bool? IsRequiredEconomics_PreliminaryDesign { get; set; }

        /// <summary>
        /// 经济_初步设计  0502033 是否公开
        /// </summary>
        public bool? IsPublicEconomics_PreliminaryDesign { get; set; }
        /// <summary>
        /// 经济_施工图   0502034
        /// </summary>
        public string Economics_Construction_Plans { get; set; }

        /// <summary>
        /// 经济_施工图   0502034 数据类别
        /// </summary>
        public string RecordTypeEconomics_Construction_Plans { get; set; }

        /// <summary>
        /// 经济_施工图   0502034 是否必填
        /// </summary>
        public bool? IsRequiredEconomics_Construction_Plans { get; set; }

        /// <summary>
        /// 经济_施工图   0502034 是否公开
        /// </summary>
        public bool? IsPublicEconomics_Construction_Plans { get; set; }
        /// <summary>
        /// 经济_施工    0502035
        /// </summary>
        public string Economics_Construction { get; set; }

        /// <summary>
        /// 经济_施工    0502035 数据类别
        /// </summary>
        public string RecordTypeEconomics_Construction { get; set; }

        /// <summary>
        /// 经济_施工    0502035 是否必填
        /// </summary>
        public bool? IsRequiredEconomics_Construction { get; set; }

        /// <summary>
        /// 经济_施工    0502035 是否公开
        /// </summary>
        public bool? IsPublicEconomics_Construction { get; set; }
        /// <summary>
        /// 经济_运营维护  0502036
        /// </summary>
        public string Economics_Operation { get; set; }

        /// <summary>
        /// 经济_运营维护  0502036 数据类别
        /// </summary>
        public string RecordTypeEconomics_Operation { get; set; }

        /// <summary>
        /// 经济_运营维护  0502036 是否必填
        /// </summary>
        public bool? IsRequiredEconomics_Operation { get; set; }

        /// <summary>
        /// 经济_运营维护  0502036 是否公开
        /// </summary>
        public bool? IsPublicEconomics_Operation { get; set; }
        /// <summary>
        /// 规划_规划方案  0502037
        /// </summary>
        public string Planning_PlanningScheme { get; set; }

        /// <summary>
        /// 规划_规划方案  0502037 数据类别
        /// </summary>
        public string RecordTypePlanning_PlanningScheme { get; set; }

        /// <summary>
        /// 规划_规划方案  0502037 是否必填
        /// </summary>
        public bool? IsRequiredPlanning_PlanningScheme { get; set; }

        /// <summary>
        /// 规划_规划方案  0502037 是否公开
        /// </summary>
        public bool? IsPublicPlanning_PlanningScheme { get; set; }
        /// <summary>
        /// 规划_初步设计  0502038
        /// </summary>
        public string Planning_PreliminaryDesign { get; set; }

        /// <summary>
        /// 规划_初步设计  0502038 数据类别
        /// </summary>
        public string RecordTypePlanning_PreliminaryDesign { get; set; }

        /// <summary>
        /// 规划_初步设计  0502038 是否必填
        /// </summary>
        public bool? IsRequiredPlanning_PreliminaryDesign { get; set; }

        /// <summary>
        /// 规划_初步设计  0502038 是否公开
        /// </summary>
        public bool? IsPublicPlanning_PreliminaryDesign { get; set; }
        /// <summary>
        /// 规划_施工图   0502039
        /// </summary>
        public string Planning_Construction_Plans { get; set; }

        /// <summary>
        /// 规划_施工图   0502039 数据类别
        /// </summary>
        public string RecordTypePlanning_Construction_Plans { get; set; }

        /// <summary>
        /// 规划_施工图   0502039 是否必填
        /// </summary>
        public bool? IsRequiredPlanning_Construction_Plans { get; set; }

        /// <summary>
        /// 规划_施工图   0502039 是否公开
        /// </summary>
        public bool? IsPublicPlanning_Construction_Plans { get; set; }
        /// <summary>
        /// 规划_施工    0502040
        /// </summary>
        public string Planning_Construction { get; set; }

        /// <summary>
        /// 规划_施工    0502040 数据类别
        /// </summary>
        public string RecordTypePlanning_Construction { get; set; }

        /// <summary>
        /// 规划_施工    0502040 是否必填
        /// </summary>
        public bool? IsRequiredPlanning_Construction { get; set; }

        /// <summary>
        /// 规划_施工    0502040 是否公开
        /// </summary>
        public bool? IsPublicPlanning_Construction { get; set; }
        /// <summary>
        /// 规划_运营维护  0502041
        /// </summary>
        public string Planning_Operation { get; set; }

        /// <summary>
        /// 规划_运营维护  0502041 数据类别
        /// </summary>
        public string RecordTypePlanning_Operation { get; set; }

        /// <summary>
        /// 规划_运营维护  0502041 是否必填
        /// </summary>
        public bool? IsRequiredPlanning_Operation { get; set; }

        /// <summary>
        /// 规划_运营维护  0502041 是否公开
        /// </summary>
        public bool? IsPublicPlanning_Operation { get; set; }
        /// <summary>
        /// 景观_规划方案  0502042
        /// </summary>
        public string Scenery_PlanningScheme { get; set; }

        /// <summary>
        /// 景观_规划方案  0502042 数据类别
        /// </summary>
        public string RecordTypeScenery_PlanningScheme { get; set; }

        /// <summary>
        /// 景观_规划方案  0502042 是否必填
        /// </summary>
        public bool? IsRequiredScenery_PlanningScheme { get; set; }

        /// <summary>
        /// 景观_规划方案  0502042 是否公开
        /// </summary>
        public bool? IsPublicScenery_PlanningScheme { get; set; }
        /// <summary>
        /// 景观_初步设计  0502043
        /// </summary>
        public string Scenery_PreliminaryDesign { get; set; }

        /// <summary>
        /// 景观_初步设计  0502043 数据类别
        /// </summary>
        public string RecordTypeScenery_PreliminaryDesign { get; set; }

        /// <summary>
        /// 景观_初步设计  0502043 是否必填
        /// </summary>
        public bool? IsRequiredScenery_PreliminaryDesign { get; set; }

        /// <summary>
        /// 景观_初步设计  0502043 是否公开
        /// </summary>
        public bool? IsPublicScenery_PreliminaryDesign { get; set; }
        /// <summary>
        /// 景观_施工图   0502044
        /// </summary>
        public string Scenery_Construction_Plans { get; set; }

        /// <summary>
        /// 景观_施工图   0502044 数据类别
        /// </summary>
        public string RecordTypeScenery_Construction_Plans { get; set; }

        /// <summary>
        /// 景观_施工图   0502044 是否必填
        /// </summary>
        public bool? IsRequiredScenery_Construction_Plans { get; set; }

        /// <summary>
        /// 景观_施工图   0502044 是否公开
        /// </summary>
        public bool? IsPublicScenery_Construction_Plans { get; set; }
        /// <summary>
        /// 景观_施工    0502045
        /// </summary>
        public string Scenery_Construction { get; set; }

        /// <summary>
        /// 景观_施工    0502045 数据类别
        /// </summary>
        public string RecordTypeScenery_Construction { get; set; }

        /// <summary>
        /// 景观_施工    0502045 是否必填
        /// </summary>
        public bool? IsRequiredScenery_Construction { get; set; }

        /// <summary>
        /// 景观_施工    0502045 是否公开
        /// </summary>
        public bool? IsPublicScenery_Construction { get; set; }
        /// <summary>
        /// 景观_运营维护  0502046
        /// </summary>
        public string Scenery_Operation { get; set; }

        /// <summary>
        /// 景观_运营维护  0502046 数据类别
        /// </summary>
        public string RecordTypeScenery_Operation { get; set; }

        /// <summary>
        /// 景观_运营维护  0502046 是否必填
        /// </summary>
        public bool? IsRequiredScenery_Operation { get; set; }

        /// <summary>
        /// 景观_运营维护  0502046 是否公开
        /// </summary>
        public bool? IsPublicScenery_Operation { get; set; }
        /// <summary>
        /// 市内_规划方案  0502047
        /// </summary>
        public string Inside_PlanningScheme { get; set; }

        /// <summary>
        /// 市内_规划方案  0502047 数据类别
        /// </summary>
        public string RecordTypeInside_PlanningScheme { get; set; }

        /// <summary>
        /// 市内_规划方案  0502047 是否必填
        /// </summary>
        public bool? IsRequiredInside_PlanningScheme { get; set; }

        /// <summary>
        /// 市内_规划方案  0502047 是否公开
        /// </summary>
        public bool? IsPublicInside_PlanningScheme { get; set; }
        /// <summary>
        /// 市内_初步设计  0502048
        /// </summary>
        public string Inside_PreliminaryDesign { get; set; }

        /// <summary>
        /// 市内_初步设计  0502048 数据类别
        /// </summary>
        public string RecordTypeInside_PreliminaryDesign { get; set; }

        /// <summary>
        /// 市内_初步设计  0502048 是否必填
        /// </summary>
        public bool? IsRequiredInside_PreliminaryDesign { get; set; }

        /// <summary>
        /// 市内_初步设计  0502048 是否公开
        /// </summary>
        public bool? IsPublicInside_PreliminaryDesign { get; set; }
        /// <summary>
        /// 市内_施工图   0502049
        /// </summary>
        public string Inside_Construction_Plans { get; set; }

        /// <summary>
        /// 市内_施工图   0502049 数据类别
        /// </summary>
        public string RecordTypeInside_Construction_Plans { get; set; }

        /// <summary>
        /// 市内_施工图   0502049 是否必填
        /// </summary>
        public bool? IsRequiredInside_Construction_Plans { get; set; }

        /// <summary>
        /// 市内_施工图   0502049 是否公开
        /// </summary>
        public bool? IsPublicInside_Construction_Plans { get; set; }
        /// <summary>
        /// 市内_施工    0502050
        /// </summary>
        public string Inside_Construction { get; set; }

        /// <summary>
        /// 市内_施工    0502050 数据类别
        /// </summary>
        public string RecordTypeInside_Construction { get; set; }

        /// <summary>
        /// 市内_施工    0502050 是否必填
        /// </summary>
        public bool? IsRequiredInside_Construction { get; set; }

        /// <summary>
        /// 市内_施工    0502050 是否公开
        /// </summary>
        public bool? IsPublicInside_Construction { get; set; }
        /// <summary>
        /// 市内_运营维护  0502051
        /// </summary>
        public string Inside_Operation { get; set; }

        /// <summary>
        /// 市内_运营维护  0502051 数据类别
        /// </summary>
        public string RecordTypeInside_Operation { get; set; }

        /// <summary>
        /// 市内_运营维护  0502051 是否必填
        /// </summary>
        public bool? IsRequiredInside_Operation { get; set; }

        /// <summary>
        /// 市内_运营维护  0502051 是否公开
        /// </summary>
        public bool? IsPublicInside_Operation { get; set; }
        /// <summary>
        /// 项目设计中BIM技术的应用  0502052
        /// </summary>
        public string BIM_Technology { get; set; }

        /// <summary>
        /// 项目设计中BIM技术的应用  0502052 数据类别
        /// </summary>
        public string RecordTypeBIM_Technology { get; set; }

        /// <summary>
        /// 项目设计中BIM技术的应用  0502052 是否必填
        /// </summary>
        public bool? IsRequiredBIM_Technology { get; set; }

        /// <summary>
        /// 项目设计中BIM技术的应用  0502052 是否公开
        /// </summary>
        public bool? IsPublicBIM_Technology { get; set; }
        /// <summary>
        /// 项目设计及软件应用中的创新亮点  0502053
        /// </summary>
        public string InnovationHighlights { get; set; }

        /// <summary>
        /// 项目设计及软件应用中的创新亮点  0502053 数据类别
        /// </summary>
        public string RecordTypeInnovationHighlights { get; set; }

        /// <summary>
        /// 项目设计及软件应用中的创新亮点  0502053 是否必填
        /// </summary>
        public bool? IsRequiredInnovationHighlights { get; set; }

        /// <summary>
        /// 项目设计及软件应用中的创新亮点  0502053 是否公开
        /// </summary>
        public bool? IsPublicInnovationHighlights { get; set; }
        /// <summary>
        /// 应用BIM技术的价值  0502054
        /// </summary>
        public string BIM_Technology_Value { get; set; }

        /// <summary>
        /// 应用BIM技术的价值  0502054 数据类别
        /// </summary>
        public string RecordTypeBIM_Technology_Value { get; set; }

        /// <summary>
        /// 应用BIM技术的价值  0502054 是否必填
        /// </summary>
        public bool? IsRequiredBIM_Technology_Value { get; set; }

        /// <summary>
        /// 应用BIM技术的价值  0502054 是否公开
        /// </summary>
        public bool? IsPublicBIM_Technology_Value { get; set; }
        /// <summary>
        /// 应用心得总结  0502055
        /// </summary>
        public string ExperienceSummary { get; set; }

        /// <summary>
        /// 应用心得总结  0502055 数据类别
        /// </summary>
        public string RecordTypeExperienceSummary { get; set; }

        /// <summary>
        /// 应用心得总结  0502055 是否必填
        /// </summary>
        public bool? IsRequiredExperienceSummary { get; set; }

        /// <summary>
        /// 应用心得总结  0502055 是否公开
        /// </summary>
        public bool? IsPublicExperienceSummary { get; set; }
    }
}
