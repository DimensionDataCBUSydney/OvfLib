using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFSchema
{
	[Serializable]
	public class AnnotationSection : Section
	{
		private List<Info> annotationField;

		public AnnotationSection()
		{
			this.annotationField = new List<Info>();
		}

		public List<Info> Annotation
		{
			get
			{
				return this.annotationField;
			}
			set
			{
				this.annotationField = value;
			}
		}
	}
}
