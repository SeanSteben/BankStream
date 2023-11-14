using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
/**
 * 
 * LSFR Algorithm from Information Security by Mark Stamp
 * Modified and implemented by Sean Steben
 * 
 **/
namespace BankStream
{
    public static class LFSR
    {
        //initialize the LSFR with the key
        private static void InitializeLFSR(ref int[] lfsr, int[] key)
        {
            if (lfsr.Length < key.Length)
            {
                Array.Resize(ref lfsr, key.Length);
            }
            Array.Copy(key, lfsr, key.Length);
        }

        //shift the LSFR and output the next bit
        private static int ShiftLFSR(ref int[] lfsr, int tap)
        {
            int output = lfsr[lfsr.Length - 1];

            for (int i = lfsr.Length - 1; i > 0; i--)
            {
                lfsr[i] = lfsr[i - 1];
            }

            lfsr[0] = output ^ lfsr[tap];

            return output;
        }

        //generate a keystream of the specified length
        public static byte[] GenerateKeystream(byte[] data, byte[] key)
        {
            int[] lfsr = new int[16];
            int[] keyBits = new int[key.Length * 8];
            byte[] keystream = new byte[data.Length];

            //convert the key to an array of bits
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    keyBits[i * 8 + j] = (key[i] >> j) & 1;
                }
            }

            //initialize the LSFR with the key
            InitializeLFSR(ref lfsr, keyBits);

            //generate keystream
            for (int i = 0; i < data.Length; i++)
            {
                int keystreamByte = 0;

                for (int j = 0; j < 8; j++)
                {
                    int bit = ShiftLFSR(ref lfsr, 0);
                    keystreamByte |= bit << (7 - j);
                }

                keystream[i] = (byte)(keystreamByte ^ data[i]);
            }

            return keystream;
        }

        //encrypt the plaintext using LSFR stream cipher
        public static byte[] Encrypt(byte[] plaintext, byte[] key)
        {
            return GenerateKeystream(plaintext, key);
        }

        //decrypt the ciphertext using LSFR stream cipher
        public static byte[] Decrypt(byte[] ciphertext, byte[] key)
        {
            return GenerateKeystream(ciphertext, key);
        }
    }


}

