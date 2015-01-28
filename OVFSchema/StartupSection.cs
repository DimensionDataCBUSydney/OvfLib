using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class StartupSection : Section
	{

		private List<StartupSectionItem> itemField;

		public StartupSection()
		{
			this.itemField = new List<StartupSectionItem>();
		}

		public List<StartupSectionItem> item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}
}
