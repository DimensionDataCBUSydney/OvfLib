using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class VirtualDiskDesc
	{
		private string diskIdField;

		private string fileRefField;

		private string capacityField;

		private string formatField;

		private long populatedSizeField;

		private bool populatedSizeFieldSpecified;

		private string parentRefField;

		public string diskId
		{
			get
			{
				return this.diskIdField;
			}
			set
			{
				this.diskIdField = value;
			}
		}

		public string fileRef
		{
			get
			{
				return this.fileRefField;
			}
			set
			{
				this.fileRefField = value;
			}
		}

		public string capacity
		{
			get
			{
				return this.capacityField;
			}
			set
			{
				this.capacityField = value;
			}
		}

		public string format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		public long populatedSize
		{
			get
			{
				return this.populatedSizeField;
			}
			set
			{
				this.populatedSizeField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool populatedSizeSpecified
		{
			get
			{
				return this.populatedSizeFieldSpecified;
			}
			set
			{
				this.populatedSizeFieldSpecified = value;
			}
		}

		public string parentRef
		{
			get
			{
				return this.parentRefField;
			}
			set
			{
				this.parentRefField = value;
			}
		}
	}
}
