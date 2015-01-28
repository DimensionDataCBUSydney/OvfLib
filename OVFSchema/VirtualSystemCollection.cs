using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class VirtualSystemCollection : Entity
	{

		private List<Entity> contentField;

		public VirtualSystemCollection()
		{
			this.contentField = new List<Entity>();
		}

		public List<Entity> Content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
			}
		}
	}
}
