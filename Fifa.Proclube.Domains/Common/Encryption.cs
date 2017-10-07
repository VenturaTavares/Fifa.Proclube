using System;
using System.Security.Cryptography;
using System.Text;

namespace Fifa.Proclube.Domains.Common
{
	public class Encryption
	{
		private static readonly string _key = "8BEAB7EFC755BE5FD3A6F4FC63291";

		public static string Encrypt(string toEncrypt)
		{
			byte[] keyArray;
			byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

			var hashmd5 = new MD5CryptoServiceProvider();
			keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_key));
			//Always release the resources and flush data
			// of the Cryptographic service provide. Best Practice

			hashmd5.Clear();

			TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
			//set the secret key for the tripleDES algorithm
			tdes.Key = keyArray;
			//mode of operation. there are other 4 modes.
			//We choose ECB(Electronic code Book)
			tdes.Mode = CipherMode.ECB;
			//padding mode(if any extra byte added)

			tdes.Padding = PaddingMode.PKCS7;

			ICryptoTransform cTransform = tdes.CreateEncryptor();
			//transform the specified region of bytes array to resultArray
			byte[] resultArray =
			  cTransform.TransformFinalBlock(toEncryptArray, 0,
			  toEncryptArray.Length);
			//Release resources held by TripleDes Encryptor
			tdes.Clear();

			hashmd5 = null;
			tdes = null;

			//Return the encrypted data into unreadable string format
			return Convert.ToBase64String(resultArray, 0, resultArray.Length);
		}

		public static string Decrypt(string cipherString)
		{
			byte[] keyArray;
			byte[] resultArray;
			//get the byte code of the string

			try
			{

				byte[] toEncryptArray = Convert.FromBase64String(cipherString);

				//System.Configuration.AppSettingsReader settingsReader =
				//new AppSettingsReader();

				//if hashing was used get the hash code with regards to your key
				MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
				keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_key));
				//release any resource held by the MD5CryptoServiceProvider

				hashmd5.Clear();

				TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
				//set the secret key for the tripleDES algorithm
				tdes.Key = keyArray;
				//mode of operation. there are other 4 modes. 
				//We choose ECB(Electronic code Book)

				tdes.Mode = CipherMode.ECB;
				//padding mode(if any extra byte added)
				tdes.Padding = PaddingMode.PKCS7;

				ICryptoTransform cTransform = tdes.CreateDecryptor();
				resultArray = cTransform.TransformFinalBlock(
									   toEncryptArray, 0, toEncryptArray.Length);
				//Release resources held by TripleDes Encryptor                
				tdes.Clear();

			}
			catch (Exception ex)
			{

				throw ex;
			}
			//return the Clear decrypted TEXT
			return UTF8Encoding.UTF8.GetString(resultArray);
		}
	}
}
