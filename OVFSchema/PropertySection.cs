using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class PropertySection : Section
	{

		private List<PropertySectionProperty> propertyField;

		private string transportField;

		public PropertySection()
		{
			this.propertyField = new List<PropertySectionProperty>();
		}

		public List<PropertySectionProperty> Property
		{
			get
			{
				return this.propertyField;
			}
			set
			{
				this.propertyField = value;
			}
		}

		public string transport
		{
			get
			{
				return this.transportField;
			}
			set
			{
				this.transportField = value;
			}
		}
	}
}
