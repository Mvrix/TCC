using System;
using System.Security.Cryptography;
using System.Text;

namespace TCC_Hidracom
{
    public class CompareMD5
    {
        public string RetornarMD5(string Senha)
        {
            using (var md5Hash = MD5.Create())
            {
                return RetonarHash(md5Hash, Senha);
            }
        }

        public bool ComparaMD5(string senhacrua, string Senha_MD5)
        {
            using (var md5Hash = MD5.Create())
            {
                var senha = RetornarMD5(senhacrua);
                if (VerificarHash(md5Hash, Senha_MD5, senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private string RetonarHash(MD5 md5Hash, string input)
        {
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (var i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private bool VerificarHash(MD5 md5Hash, string input, string hash)
        {
            var compara = StringComparer.OrdinalIgnoreCase;

            if (0 == compara.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        var md5 = new CriarMD5();

    //        var senhabanco = "827ccb0eea8a706c4c34a16891f84e7b";
    //        var Senha = "12345";

    //        var ComparaSenha = md5.ComparaMD5(Senha, senhabanco);

    //        Console.WriteLine(ComparaSenha.ToString());
    //    }
    //}
}
