using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class Info
	{
		private string langField;

		private string valueField;

		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}
}
