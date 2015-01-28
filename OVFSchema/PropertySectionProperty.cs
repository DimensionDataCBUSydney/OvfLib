using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class PropertySectionProperty
	{

		private List<Info> descriptionField;

		private string keyField;

		private string Field;

		private bool configurableByUserField;

		private bool configurableByUserFieldSpecified;

		private bool configurableAtRuntimeField;

		private bool configurableAtRuntimeFieldSpecified;

		private string defaultValueField;

		public PropertySectionProperty()
		{
			this.descriptionField = new List<Info>();
		}

		public List<Info> Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
			}
		}

		public string Type
		{
			get
			{
				return this.Field;
			}
			set
			{
				this.Field = value;
			}
		}

		public bool configurableByUser
		{
			get
			{
				return this.configurableByUserField;
			}
			set
			{
				this.configurableByUserField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool configurableByUserSpecified
		{
			get
			{
				return this.configurableByUserFieldSpecified;
			}
			set
			{
				this.configurableByUserFieldSpecified = value;
			}
		}

		public bool configurableAtRuntime
		{
			get
			{
				return this.configurableAtRuntimeField;
			}
			set
			{
				this.configurableAtRuntimeField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool configurableAtRuntimeSpecified
		{
			get
			{
				return this.configurableAtRuntimeFieldSpecified;
			}
			set
			{
				this.configurableAtRuntimeFieldSpecified = value;
			}
		}

		public string defaultValue
		{
			get
			{
				return this.defaultValueField;
			}
			set
			{
				this.defaultValueField = value;
			}
		}
	}
}
