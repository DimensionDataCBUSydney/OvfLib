using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(VirtualSystemCollection))]
	[System.Xml.Serialization.XmlIncludeAttribute(typeof(VirtualSystem))]
	public abstract class Entity
	{

		private List<Info> infoField;

		private List<Section> sectionField;

		private string idField;

		public Entity()
		{
			this.sectionField = new List<Section>();
			this.infoField = new List<Info>();
		}

		public List<Info> Info
		{
			get
			{
				return this.infoField;
			}
			set
			{
				this.infoField = value;
			}
		}

		public List<Section> Section
		{
			get
			{
				return this.sectionField;
			}
			set
			{
				this.sectionField = value;
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
