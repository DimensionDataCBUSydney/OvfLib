using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFGenerator
{
	using System.IO;
	using System.Net.Mime;
	using System.Reflection;
	using System.Security.Cryptography;
	using System.Xml.Serialization;

	class Program
	{
		private static void Main(string[] args)
		{
			FileInfo file = new FileInfo(args[0]);
			string directoryPath, vmdskFileName;

			if (!file.Exists)
			{
				Console.WriteLine("Please provide the path of vmdk file");
				return;
			}

			if (file.Extension.ToLower() != ".vmdk")
			{
				Console.WriteLine("Please provide a valid vmdk file");
				return;
			}

			vmdskFileName = file.Name.Substring(0, file.Name.IndexOf(file.Extension));

			if (file.DirectoryName.EndsWith(@"\")) 
				directoryPath = file.DirectoryName;
			else
				directoryPath = string.Format("{0}\\", file.DirectoryName);

			Console.WriteLine("Generating OVF and Manifest files ...");
				
			OVFGenerator ovfGenerator = new OVFGenerator(file.Name, file.Length, string.Empty);

			ovfGenerator.GenerateEnvelope();
			ovfGenerator.StoreEnvelope(string.Format("{0}{1}.ovf", directoryPath, vmdskFileName));

			ManifestGenerator manifestGenerator = new ManifestGenerator(string.Format("{0}{1}.ovf", directoryPath, vmdskFileName), file.FullName);
			manifestGenerator.GenerateManifest(string.Format("{0}{1}.mf", directoryPath, vmdskFileName));
			
			Console.WriteLine("Finished");
			Console.ReadKey();
		}
	}
}
