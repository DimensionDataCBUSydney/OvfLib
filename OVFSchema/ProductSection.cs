using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public partial class ProductSection : Section
	{

		private List<Info> productField;

		private List<Info> vendorField;

		private string versionField;

		private string fullversionField;

		private string productUrlField;

		private string vendorUrlField;

		private string appUrlField;

		public ProductSection()
		{
			this.vendorField = new List<Info>();
			this.productField = new List<Info>();
		}

		public List<Info> Product
		{
			get
			{
				return this.productField;
			}
			set
			{
				this.productField = value;
			}
		}

		public List<Info> Vendor
		{
			get
			{
				return this.vendorField;
			}
			set
			{
				this.vendorField = value;
			}
		}

		public string Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		public string Fullversion
		{
			get
			{
				return this.fullversionField;
			}
			set
			{
				this.fullversionField = value;
			}
		}

		public string ProductUrl
		{
			get
			{
				return this.productUrlField;
			}
			set
			{
				this.productUrlField = value;
			}
		}

		public string VendorUrl
		{
			get
			{
				return this.vendorUrlField;
			}
			set
			{
				this.vendorUrlField = value;
			}
		}

		public string AppUrl
		{
			get
			{
				return this.appUrlField;
			}
			set
			{
				this.appUrlField = value;
			}
		}
	}
}
