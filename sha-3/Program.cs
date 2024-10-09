using System.Security.Cryptography;

if (SHA3_256.IsSupported) //garante que a plataforma suporta
{
    var valor = "criptografia SHA3";
    byte[] data = Convert.FromBase64String(valor);

    byte[] hashsha3 = SHA3_256.HashData(data);
    string hash = Convert.ToBase64String(hashsha3);

    Console.WriteLine($"valor {valor}");
    Console.WriteLine($"hash {hash}");
}