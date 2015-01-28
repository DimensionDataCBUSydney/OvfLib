using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class NetworkSection : Section
	{

		private List<NetworkSectionNetwork> networkField;

		public NetworkSection()
		{
			this.networkField = new List<NetworkSectionNetwork>();
		}

		public List<NetworkSectionNetwork> Network
		{
			get
			{
				return this.networkField;
			}
			set
			{
				this.networkField = value;
			}
		}

	}
}
