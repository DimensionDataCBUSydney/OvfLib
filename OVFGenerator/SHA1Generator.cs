using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVFGenerator
{
	using System.IO;
	using System.Security.Cryptography;

	public static class SHA1Generator
	{
		/// <summary>
		/// The get sha1 hash for file.
		/// </summary>
		/// <param name="path">
		/// The path.
		/// </param>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		public static string GetSHA1HashForFile(string path)
		{
			using (FileStream stream = new FileStream(path, FileMode.Open))
			{
				using (BufferedStream bufferedStream = new BufferedStream(stream))
				{
					using (SHA1Managed sha1 = new SHA1Managed())
					{
						byte[] hash = sha1.ComputeHash(bufferedStream);
						StringBuilder result = new StringBuilder(2 * hash.Length);

						foreach (byte b in hash)
						{
							result.AppendFormat("{0:X2}", b);
						}

						return result.ToString();
					}
				}
			}
		}
	}
}
