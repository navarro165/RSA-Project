using System;
using System.Numerics;

namespace P4
{
    class Program
    {  
        static void Main(string[] args) {
            if (args.Length != 6)
                throw new ArgumentException("Program requires 6 input arguments");

            int e =  65537;
            BigInteger d = 0;
            BigInteger cipher = BigInteger.Parse(args[4]);
            BigInteger plaintext = BigInteger.Parse(args[5]);

            // calculating p
            int p_e = int.Parse(args[0]);
            int p_c = int.Parse(args[1]);
            BigInteger p = BigInteger.Subtract(BigInteger.Pow(2, p_e), p_c);

            // calculating q
            int q_e = int.Parse(args[2]);
            int q_c = int.Parse(args[3]);
            BigInteger q = BigInteger.Subtract(BigInteger.Pow(2, q_e), q_c);

            // calculating n
            BigInteger n = BigInteger.Multiply(p, q);

            // calculating phi_n
            BigInteger phi_n = BigInteger.Multiply(p-1, q-1);

            // calculatin d
            for (int k = 1; k <= e; k++) {
                d = BigInteger.Divide(BigInteger.Add(1, BigInteger.Multiply(k, phi_n)), e);

                // when e*d mod phi(n) == 1 we found d 
                if (BigInteger.Multiply(e, d) % phi_n == 1)
                    break;
            }
            
            // encrypt and decrypt
            BigInteger decrypted_text = BigInteger.ModPow(cipher, d, n);
            BigInteger encrypted_cipher = BigInteger.ModPow(plaintext, e, n);
            Console.WriteLine($"{decrypted_text},{encrypted_cipher}"); 
        }
    }
}
