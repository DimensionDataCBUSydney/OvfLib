using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class StartupSectionItem
	{
		private string idField;

		private int orderField;

		private bool orderFieldSpecified;

		private int startDelayField;

		private bool startDelayFieldSpecified;

		private bool waitingForGuestField;

		private bool waitingForGuestFieldSpecified;

		private int stopDelayField;

		private bool stopDelayFieldSpecified;

		private string startActionField;

		private string stopActionField;

		private List<System.Xml.XmlAttribute> anyAttrField;

		public StartupSectionItem()
		{
			this.anyAttrField = new List<System.Xml.XmlAttribute>();
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

		public int order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool orderSpecified
		{
			get
			{
				return this.orderFieldSpecified;
			}
			set
			{
				this.orderFieldSpecified = value;
			}
		}

		public int startDelay
		{
			get
			{
				return this.startDelayField;
			}
			set
			{
				this.startDelayField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool startDelaySpecified
		{
			get
			{
				return this.startDelayFieldSpecified;
			}
			set
			{
				this.startDelayFieldSpecified = value;
			}
		}

		public bool waitingForGuest
		{
			get
			{
				return this.waitingForGuestField;
			}
			set
			{
				this.waitingForGuestField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool waitingForGuestSpecified
		{
			get
			{
				return this.waitingForGuestFieldSpecified;
			}
			set
			{
				this.waitingForGuestFieldSpecified = value;
			}
		}

		public int stopDelay
		{
			get
			{
				return this.stopDelayField;
			}
			set
			{
				this.stopDelayField = value;
			}
		}

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool stopDelaySpecified
		{
			get
			{
				return this.stopDelayFieldSpecified;
			}
			set
			{
				this.stopDelayFieldSpecified = value;
			}
		}

		public string startAction
		{
			get
			{
				return this.startActionField;
			}
			set
			{
				this.startActionField = value;
			}
		}

		public string stopAction
		{
			get
			{
				return this.stopActionField;
			}
			set
			{
				this.stopActionField = value;
			}
		}

		[System.Xml.Serialization.XmlAnyAttributeAttribute()]
		public List<System.Xml.XmlAttribute> AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}
	}

}
