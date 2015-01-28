using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFGenerator
{
	using System.IO;
	using System.Xml.Serialization;

	using OVFSchema;

	public class OVFGenerator
	{
		private string manifestPath;

		private string vmdskFileName;

		private long vmdskfileSize;

		private Envelope ovfEnvelope;

		public OVFGenerator(string VmdskfileName, long VmdskFileSize, string ManifestPath)
		{
			vmdskFileName = VmdskfileName;
			vmdskfileSize = VmdskFileSize;
			manifestPath = ManifestPath;
		}

		public Envelope OVFEnvelope
		{
			get
			{
				return ovfEnvelope;
			}
		}

		public bool GenerateEnvelope()
		{
			ovfEnvelope = new Envelope();

			ovfEnvelope.References.File.Add(new OVFSchema.File { href = vmdskFileName, id = "file1", size = vmdskfileSize.ToString() });

			ovfEnvelope.Section.Add(
				new DiskSection
				{
					Info = new List<Info> { new Info { Value = "Virtual disk information" } },
					Disk =
						new List<VirtualDiskDesc>
								{
									new VirtualDiskDesc
										{
											capacity = "50",
											fileRef = "file1",
											diskId = vmdskFileName,
											format = @"http://www.vmware.com/interfaces/specifications/vmdk.html#streamOptimized",
											populatedSize = 16760569856
										}
								}
				});

			return true;
		}

		/// <summary>
		/// The store ovf envelope.
		/// </summary>
		/// <param name="path">
		/// The path to store file.
		/// </param>
		public void StoreEnvelope(string path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Envelope));

			using (StreamWriter writer = new StreamWriter(path))
			{
				serializer.Serialize(writer, ovfEnvelope);
				writer.Close();
			}
		}
	}
}
