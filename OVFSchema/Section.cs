using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(InstallSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(StartupSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(EulaSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatingSystemSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(CpuCompatibilitySection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(DiskSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertySection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductSection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(AnnotationSection))]
	public abstract class Section
	{

		private List<Info> infoField;

		private bool requiredField;

		private bool requiredFieldSpecified;
		
		public Section()
		{
			this.infoField = new List<Info>();
		}

		public List<Info> Info
		{
			get
			{
				return this.infoField;
			}
			set
			{
				this.infoField = value;
			}
		}

		public bool required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool requiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
			}
		}
	}
}
