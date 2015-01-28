using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class File
	{

		private string idField;

		private string hrefField;

		private string sizeField;

		private string estSizeField;

		private string compressionField;

		private long chunkSizeField;

		private bool chunkSizeFieldSpecified;

		public File()
		{
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

		public string href
		{
			get
			{
				return this.hrefField;
			}
			set
			{
				this.hrefField = value;
			}
		}

		public string size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}

		public string estSize
		{
			get
			{
				return this.estSizeField;
			}
			set
			{
				this.estSizeField = value;
			}
		}

		public string compression
		{
			get
			{
				return this.compressionField;
			}
			set
			{
				this.compressionField = value;
			}
		}

		public long chunkSize
		{
			get
			{
				return this.chunkSizeField;
			}
			set
			{
				this.chunkSizeField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool chunkSizeSpecified
		{
			get
			{
				return this.chunkSizeFieldSpecified;
			}
			set
			{
				this.chunkSizeFieldSpecified = value;
			}
		}
	}
}
