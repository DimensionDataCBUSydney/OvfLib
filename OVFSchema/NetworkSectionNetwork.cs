using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class NetworkSectionNetwork
	{
		private List<Info> descriptionField;

		private string nameField;


		public NetworkSectionNetwork()
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

		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}

}
