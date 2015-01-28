using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class InstallSection : Section
	{

		private string transportField;


		public InstallSection()
		{
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
