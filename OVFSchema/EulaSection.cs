using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class EulaSection : Section
	{

		private List<Info> licenseField;

		public EulaSection()
		{
			this.licenseField = new List<Info>();
		}

		public List<Info> License
		{
			get
			{
				return this.licenseField;
			}
			set
			{
				this.licenseField = value;
			}
		}
	}
}
