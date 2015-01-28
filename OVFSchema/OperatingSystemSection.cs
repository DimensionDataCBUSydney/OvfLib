using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class OperatingSystemSection : Section
	{

		private List<Info> descriptionField;

		private string idField;

		public OperatingSystemSection()
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

		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

	}
}
