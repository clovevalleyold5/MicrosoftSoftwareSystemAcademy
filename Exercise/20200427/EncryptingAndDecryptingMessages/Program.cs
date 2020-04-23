using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;
using System.Collections.Specialized;
using System.Linq;

namespace EncryptingAndDecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaintext = Util.GetPlainText();
            string singlekey = Util.GetSingleKey();
            string multikey = Util.GetMultiKey();
            Console.WriteLine();

            Console.WriteLine("plain text is: " + plaintext);
            Console.WriteLine("single key is: " + singlekey);
            Console.WriteLine("multi key is: " + multikey);
            Console.WriteLine();

            int[] cleanplaintext = Util.Clean(plaintext);
            int[] cleansinglekey = Util.Clean(singlekey);
            int[] cleanmultikey = Util.Clean(multikey);

            string encryptsingle = Util.SingleEncrypt(cleanplaintext, cleansinglekey);
            string encryptmulti = Util.MultiEncrypt(cleanplaintext, cleanmultikey);
            string encryptcontinuous = Util.ContinuousEncrypt(cleanplaintext, cleanmultikey);

            Console.WriteLine("encrypt with single is: " + encryptsingle);
            Console.WriteLine("encrypt with multi is: " + encryptmulti);
            Console.WriteLine("encrypt with continuous is: " + encryptcontinuous);
            Console.WriteLine();

            string decryptsingle = Util.SingleDecrypt(encryptsingle, cleansinglekey);
            string decryptmulti = Util.MultiDecrypt(encryptmulti, cleanmultikey);
            string decryptcontinuous = Util.ContinuousDecrypt(encryptcontinuous, cleanmultikey);

            Console.WriteLine("decrypt with single is: " + decryptsingle);
            Console.WriteLine("decrypt with multi is: " + decryptmulti);
            Console.WriteLine("decrypt with continuous is: " + decryptcontinuous);
        }
    }

    internal class Util
    {
        internal static int[] Clean(string textneedstobecleaned)
        {
            Encoding ascii = Encoding.ASCII;
            char[] charstotrim = { ' ', ',', '.', ';' };
            string trimmed = textneedstobecleaned.Trim(charstotrim);
            string uppercasedtrimmed = trimmed.ToUpper();
            byte[] encodedbyte = ascii.GetBytes(uppercasedtrimmed);
            int[] encodedint = encodedbyte.Select(b => (int)b).ToArray();
            return encodedint;
        }

        internal static string ContinuousDecrypt(string encryptcontinuous, int[] cleanmultikey)
        {
            Encoding ascii = Encoding.ASCII;
            byte[] encodedbyte = ascii.GetBytes(encryptcontinuous);
            int[] encodedint = encodedbyte.Select(x => (int)x).ToArray();
            int[] key = cleanmultikey.Select(x => x - 64).ToArray();
            int[] decryptedkey = new int[encryptcontinuous.Length];
            int[] decryptedint = new int[encryptcontinuous.Length];
            for (int i = 0; i < key.Length; i++)
            {
                decryptedkey[i] = key[i];
            }
            for (int i = 0; i < encryptcontinuous.Length; i++)
            {
                decryptedint[i] = encodedint[i] - decryptedkey[i];

                if (decryptedint[i] < 65)
                {
                    decryptedint[i] = decryptedint[i] + 26;
                }
                if (i + key.Length < decryptedkey.Length)
                {
                    decryptedkey[i + key.Length] = decryptedint[i] - 64;
                }
            }
            byte[] decryptedbyte = decryptedint.Select(x => (byte)x).ToArray();
            string decryptedstring = ascii.GetString(decryptedbyte);
            return decryptedstring;
        }

        internal static string ContinuousEncrypt(int[] cleanplaintext, int[] cleanmultikey)
        {
            Encoding ascii = Encoding.ASCII;
            int[] textkey = cleanplaintext.Select(x => x - 64).ToArray();
            int[] keykey = cleanmultikey.Select(x => x - 64).ToArray();
            int[] mixkey = new int[textkey.Length + keykey.Length];
            Array.Copy(keykey, mixkey, keykey.Length);
            Array.Copy(textkey, 0, mixkey, keykey.Length, textkey.Length);
            int[] encryptedint = new int[cleanplaintext.Length];
            for (int i = 0; i < cleanplaintext.Length; i++)
            {
                encryptedint[i] = cleanplaintext[i] + mixkey[i];
                if (encryptedint[i] > 90)
                {
                    encryptedint[i] = encryptedint[i] - 26;
                }
            }
            byte[] encryptedbyte = encryptedint.Select(x => (byte)x).ToArray();
            string encryptedstring = ascii.GetString(encryptedbyte);
            return encryptedstring;
        }

        internal static string GetMultiKey()
        {
            Console.Write("multi key as: ");
            string multikey = Console.ReadLine();
            return multikey;
        }

        internal static string GetPlainText()
        {
            Console.Write("plain text as: ");
            string plaintext = Console.ReadLine();
            return plaintext;
        }

        internal static string GetSingleKey()
        {
            Console.Write("single key as: ");
            string singlekey = Console.ReadLine();
            return singlekey;
        }

        internal static string MultiDecrypt(string encryptmulti, int[] cleanmultikey)
        {
            Encoding ascii = Encoding.ASCII;
            byte[] encodedbyte = ascii.GetBytes(encryptmulti);
            int[] encodedint = encodedbyte.Select(x => (int)x).ToArray();
            int[] key = cleanmultikey.Select(x => x - 64).ToArray();
            int[] decryptedint = new int[encryptmulti.Length];
            for (int i = 0; i < encryptmulti.Length; i++)
            {
                decryptedint[i] = encodedint[i] - key[i % key.Length];
                if (decryptedint[i] < 65)
                {
                    decryptedint[i] = decryptedint[i] + 26;
                }
            }
            byte[] decryptedbyte = decryptedint.Select(x => (byte)x).ToArray();
            string decryptedstring = ascii.GetString(decryptedbyte);
            return decryptedstring;
        }

        internal static string MultiEncrypt(int[] cleanplaintext, int[] cleanmultikey)
        {
            Encoding ascii = Encoding.ASCII;
            int[] key = cleanmultikey.Select(x => x - 64).ToArray();
            int[] encryptedint = new int[cleanplaintext.Length];
            for (int i = 0; i < cleanplaintext.Length; i++)
            {
                encryptedint[i] = cleanplaintext[i] + key[i % key.Length];
                if (encryptedint[i] > 90)
                {
                    encryptedint[i] = encryptedint[i] - 26;
                }
            }
            byte[] encryptedbyte = encryptedint.Select(x => (byte)x).ToArray();
            string encryptedstring = ascii.GetString(encryptedbyte);
            return encryptedstring;
        }

        internal static string SingleDecrypt(string encryptsingle, int[] cleansinglekey)
        {
            Encoding ascii = Encoding.ASCII;
            byte[] encodedbyte = ascii.GetBytes(encryptsingle);
            int[] encodedint = encodedbyte.Select(x => (int)x).ToArray();
            int key = cleansinglekey[0] - 64;
            int[] decryptedint = encodedint.Select(x => x - key).ToArray();
            for (int i = 0; i < decryptedint.Length; i++)
            {
                if (decryptedint[i] < 65)
                {
                    decryptedint[i] = decryptedint[i] + 26;
                }
            }
            byte[] decryptedbyte = decryptedint.Select(x => (byte)x).ToArray();
            string decryptedstring = ascii.GetString(decryptedbyte);
            return decryptedstring;
        }

        internal static string SingleEncrypt(int[] cleanplaintext, int[] cleansinglekey)
        {
            Encoding ascii = Encoding.ASCII;
            int key = cleansinglekey[0] - 64;
            int[] encryptedint = cleanplaintext.Select(x => x + key).ToArray();
            for (int i = 0; i < encryptedint.Length; i++)
            {
                if (encryptedint[i] > 90)
                {
                    encryptedint[i] = encryptedint[i] - 26;
                }
            }
            byte[] encryptedbyte = encryptedint.Select(x => (byte)x).ToArray();
            string encryptedstring = ascii.GetString(encryptedbyte);
            return encryptedstring;
        }
    }
}
