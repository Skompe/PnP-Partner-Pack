﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace OfficeDevPnP.PartnerPack.SiteProvisioning.Models {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch", IsNullable=false)]
    public partial class batches {
        
        private siteCollectionBatch[] siteCollectionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("siteCollection")]
        public siteCollectionBatch[] siteCollection {
            get {
                return this.siteCollectionField;
            }
            set {
                this.siteCollectionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch")]
    public partial class siteCollectionBatch : baseSiteSettings {
        
        private string primarySiteCollectionAdminField;
        
        private string secondarySiteCollectionAdminField;
        
        private int storageMaximulLevelField;
        
        private int storageWarningLevelField;
        
        private bool externalSharingEnabledField;
        
        private bool partnerPackExtensionsEnabledField;
        
        private bool responsiveDesignEnabledField;
        
        private siteCollectionBatchManagedPath managedPathField;
        
        private string relativeUrlField;
        
        public siteCollectionBatch() {
            this.storageMaximulLevelField = 1000;
            this.storageWarningLevelField = 900;
            this.externalSharingEnabledField = false;
            this.partnerPackExtensionsEnabledField = true;
            this.responsiveDesignEnabledField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string primarySiteCollectionAdmin {
            get {
                return this.primarySiteCollectionAdminField;
            }
            set {
                this.primarySiteCollectionAdminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string secondarySiteCollectionAdmin {
            get {
                return this.secondarySiteCollectionAdminField;
            }
            set {
                this.secondarySiteCollectionAdminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(1000)]
        public int storageMaximulLevel {
            get {
                return this.storageMaximulLevelField;
            }
            set {
                this.storageMaximulLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(900)]
        public int storageWarningLevel {
            get {
                return this.storageWarningLevelField;
            }
            set {
                this.storageWarningLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool externalSharingEnabled {
            get {
                return this.externalSharingEnabledField;
            }
            set {
                this.externalSharingEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool partnerPackExtensionsEnabled {
            get {
                return this.partnerPackExtensionsEnabledField;
            }
            set {
                this.partnerPackExtensionsEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool responsiveDesignEnabled {
            get {
                return this.responsiveDesignEnabledField;
            }
            set {
                this.responsiveDesignEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public siteCollectionBatchManagedPath managedPath {
            get {
                return this.managedPathField;
            }
            set {
                this.managedPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relativeUrl {
            get {
                return this.relativeUrlField;
            }
            set {
                this.relativeUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch")]
    public enum siteCollectionBatchManagedPath {
        
        /// <remarks/>
        sites,
        
        /// <remarks/>
        teams,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(siteCollectionBatch))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch")]
    public partial class baseSiteSettings {
        
        private baseSiteSettingsParameter[] templateParametersField;
        
        private string titleField;
        
        private string descriptionField;
        
        private baseSiteSettingsSitePolicy sitePolicyField;
        
        private string languageField;
        
        private int timeZoneField;
        
        private string initialTemplateField;
        
        private string templateUrlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable=false)]
        public baseSiteSettingsParameter[] templateParameters {
            get {
                return this.templateParametersField;
            }
            set {
                this.templateParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public baseSiteSettingsSitePolicy sitePolicy {
            get {
                return this.sitePolicyField;
            }
            set {
                this.sitePolicyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int timeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string initialTemplate {
            get {
                return this.initialTemplateField;
            }
            set {
                this.initialTemplateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string templateUrl {
            get {
                return this.templateUrlField;
            }
            set {
                this.templateUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch")]
    public partial class baseSiteSettingsParameter {
        
        private string keyField;
        
        private bool requiredField;
        
        private string[] textField;
        
        public baseSiteSettingsParameter() {
            this.requiredField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2016/08/PnPPartnerPackBatch")]
    public enum baseSiteSettingsSitePolicy {
        
        /// <remarks/>
        LBI,
        
        /// <remarks/>
        MBI,
        
        /// <remarks/>
        HBI,
    }
}
