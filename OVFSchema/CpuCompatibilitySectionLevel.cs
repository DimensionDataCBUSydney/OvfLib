using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class CpuCompatibilitySectionLevel
	{

		private int levelField;

		private bool levelFieldSpecified;

		private string eaxField;

		private string ebxField;

		private string ecxField;

		private string edxField;

		public int level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool levelSpecified
		{
			get
			{
				return this.levelFieldSpecified;
			}
			set
			{
				this.levelFieldSpecified = value;
			}
		}

		public string eax
		{
			get
			{
				return this.eaxField;
			}
			set
			{
				this.eaxField = value;
			}
		}

		public string ebx
		{
			get
			{
				return this.ebxField;
			}
			set
			{
				this.ebxField = value;
			}
		}

		public string ecx
		{
			get
			{
				return this.ecxField;
			}
			set
			{
				this.ecxField = value;
			}
		}

		public string edx
		{
			get
			{
				return this.edxField;
			}
			set
			{
				this.edxField = value;
			}
		}
	}
}
