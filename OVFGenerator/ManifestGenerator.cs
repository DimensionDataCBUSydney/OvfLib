using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFGenerator
{
	using System.IO;
	using System.Security.Cryptography;

	public class ManifestGenerator
	{
		private readonly string ovfPath;

		private string vmdskPath;

		public ManifestGenerator(string OvfPath, string VmdskPath)
		{
			ovfPath = OvfPath;
			vmdskPath = VmdskPath;
		}

		public bool GenerateManifest(string path)
		{
			var ovfHash = SHA1Generator.GetSHA1HashForFile(ovfPath);
			var vmdskHash = SHA1Generator.GetSHA1HashForFile(vmdskPath);

			try
			{
				using (StreamWriter writer = new StreamWriter(path))
				{
					var fileInfo = new FileInfo(ovfPath);
					writer.WriteLine("SHA1({0})={1}", fileInfo.Name, ovfHash);

					fileInfo = new FileInfo(vmdskPath);
					writer.WriteLine("SHA1({0})={1}", fileInfo.Name, vmdskHash);

					writer.Close();
				}

				return true;
			}
			catch (Exception)
			{
				throw;
			}			
		}
	}
}
