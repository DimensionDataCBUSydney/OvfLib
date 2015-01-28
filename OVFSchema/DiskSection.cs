using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class DiskSection : Section
	{

		private List<VirtualDiskDesc> diskField;

		public DiskSection()
		{
			this.diskField = new List<VirtualDiskDesc>();
		}

		public List<VirtualDiskDesc> Disk
		{
			get
			{
				return this.diskField;
			}
			set
			{
				this.diskField = value;
			}
		}
	}
}
