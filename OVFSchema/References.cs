using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class References
	{
		private List<File> fileField;

		public References()
		{
			this.fileField = new List<File>();
		}

		public List<File> File
		{
			get
			{
				return this.fileField;
			}
			set
			{
				this.fileField = value;
			}
		}
	}
}
