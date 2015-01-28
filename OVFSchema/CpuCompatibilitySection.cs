using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public partial class CpuCompatibilitySection : Section
	{

		private List<CpuCompatibilitySectionLevel> levelField;

		private string vendorField;

		public CpuCompatibilitySection()
		{
			this.levelField = new List<CpuCompatibilitySectionLevel>();
		}

		public List<CpuCompatibilitySectionLevel> Level
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

		public string Vendor
		{
			get
			{
				return this.vendorField;
			}
			set
			{
				this.vendorField = value;
			}
		}
	}
}
