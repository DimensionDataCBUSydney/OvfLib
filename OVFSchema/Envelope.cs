// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>ovf-envelope</NameSpace><Collection>List</Collection><code>CSharp</code><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludeds>False</ExcludeIncludeds><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace OVFSchema
{
    using System;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    [Serializable]
	[XmlRoot(ElementName="Envelope")]
    public class Envelope {
        
        private References referencesField;
        
        private List<Section> sectionField;
        
        private List<Entity> contentField;

        private bool signedField;
        
        private bool signedFieldSpecified;
        
        private bool manifestField;
        
        private bool manifestFieldSpecified;

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public Envelope() {
            this.contentField = new List<Entity>();
            this.sectionField = new List<Section>();
            this.referencesField = new References();
		
			xmlns.Add("", "http://schemas.dmtf.org/ovf/envelope/1");
			xmlns.Add("cim", "http://schemas.dmtf.org/wbem/wscim/1/common");
	        xmlns.Add("ovf", "http://schemas.dmtf.org/ovf/envelope/1");
	        xmlns.Add("rasd", "http://schemas.dmtf.org/wbem/wscim/1/cim-schema/2/CIM_ResourceAllocationSettingData");
	        xmlns.Add("vmw", "http://www.vmware.com/schema/ovf");
	        xmlns.Add("vssd", "http://schemas.dmtf.org/wbem/wscim/1/cim-schema/2/CIM_VirtualSystemSettingData");
        }
        
        public References References {
            get {
                return this.referencesField;
            }
            set {
                this.referencesField = value;
            }
        }
        
        public List<Section> Section {
            get {
                return this.sectionField;
            }
            set {
                this.sectionField = value;
            }
        }
        
        public List<Entity> Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
        
        public bool signed {
            get {
                return this.signedField;
            }
            set {
                this.signedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool signedSpecified {
            get {
                return this.signedFieldSpecified;
            }
            set {
                this.signedFieldSpecified = value;
            }
        }
        
        public bool manifest {
            get {
                return this.manifestField;
            }
            set {
                this.manifestField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manifestSpecified {
            get {
                return this.manifestFieldSpecified;
            }
            set {
                this.manifestFieldSpecified = value;
            }
        }
    }
}
