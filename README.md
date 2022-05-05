# RSA-Project
### Custom Implementation of the RSA Encryption Algorithm

To encrypt with RSA, you need a message m and the values e and n. To decrypt, you need the
encrypted message and the values d and n. This simple program performs both encryption and decryption in order to demonstrate the inner worklings of the RSA algorithm.

The program expects the following command line arguments:
1) p_e in base 10
2) p_c in base 10
3) q_e in base 10
4) q_c in base 10
5) Ciphertext in base 10
6) Plaintext message in base 10

The program will then output two values as a comma-separated pair, with the decrypted plaintext first and encrypted ciphertext second.

```
➜  P4 dotnet run 254 1223 251 1339 66536047120374145538916787981868004206438539248910734713495276883724693574434582104900978079701174539167102706725422582788481727619546235440508214694579 1756026041 

1756026041,66536047120374145538916787981868004206438539248910734713495276883724693574434582104900978079701174539167102706725422582788481727619546235440508214694579
```
