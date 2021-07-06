using System;
using System.Text;
using System.Security.Cryptography;


public class Program
{
	public static byte[] MD5Hash(string value)
	{
		MD5 m = new MD5CryptoServiceProvider();
		return m.ComputeHash(Encoding.ASCII.GetBytes(value));
	}
		
	public  static string enc(string stringInput, string key)
	{
		TripleDESCryptoServiceProvider d = new TripleDESCryptoServiceProvider();

		d.Key = MD5Hash(key);				
		d.Mode = CipherMode.ECB;
		
		byte[] bytes = Encoding.ASCII.GetBytes(stringInput);		
		string s = Convert.ToBase64String(d.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
	
		return s;
	}
		
	public static void Main()
	{
		Console.Write("Masukkan string bebas: ");
		string s = Console.ReadLine();
		string serial_code = enc(s, "wtMd3x6ucb16w9P9BBPj5qoHKPCq0MIy");		
		Console.WriteLine("Keygen:");
		Console.Write("Username: " + s);
		Console.WriteLine();
		Console.Write("Serial: " + serial_code);
	}
		
}