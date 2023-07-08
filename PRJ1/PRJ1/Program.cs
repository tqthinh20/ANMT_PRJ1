using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

public class PRJ1_module
{
    public class AES
    {
        private static byte[] Ks;
        private static byte[] iv = new byte[16];
        private static int blocksize = 128;
        private static int keysize = 256;

        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        public static string GenerateKey()
        {
            byte[] salt = GenerateRandomSalt();
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes("ThisisapasswordforAES");

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);

            byte[] Ks = key.GetBytes(32);

            return Convert.ToBase64String(Ks);
        }

        public static void FileEncrypt(string inputFile, string ks)
        {   
            //create output file name
            FileStream fsCrypt = new FileStream(inputFile + ".metadata", FileMode.Create);            

            //Set Rijndael symmetric encryption algorithm
            RijndaelManaged AES = new RijndaelManaged();
            
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            AES.Key = Convert.FromBase64String(ks);
            AES.IV = new byte[16];

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        public static void FileDecrypt(string inputFile, string outputFile, string ks)
        {            
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged AES = new RijndaelManaged();

            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            AES.Key = Convert.FromBase64String(ks);
            AES.IV = new byte[16];

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
    }

    public class RSA
    {
        public static Tuple<string, string> GenerateKey()
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            string Kpublic = csp.ToXmlString(false);
            string Kprivate = csp.ToXmlString(true);

            return Tuple.Create(Kpublic, Kprivate);
        }

        public static void exportKey(string key)
        {
            string path = "C:\\Users\\tqthinh16\\Downloads\\kprivate.txt";
            TextWriter writer = new StreamWriter(path);

            writer.Write(key);
            writer.Close();
        }

        public static string Encrypt(string plain, string kpublic)
        {
            byte[] data = Encoding.Unicode.GetBytes(plain);

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(kpublic);

            return Convert.ToBase64String(csp.Encrypt(data, false));
        }

        public static string Decrypt(string cipher, string kprivate)
        {
            byte[] data = Convert.FromBase64String(cipher);

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(kprivate);

            return Encoding.Unicode.GetString(csp.Decrypt(data, false));
        }
    }

    public class HASH
    {
        public static byte[] HashSHA256(string text)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(text));
        }

        public static byte[] HashSHA1(string text)
        {
            using (HashAlgorithm algorithm = SHA1.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(text));
        }

        public static string hashString(byte[] hash)
        {
            return Convert.ToBase64String(hash);
        }
    }
}

namespace PRJ1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }
    }
}
