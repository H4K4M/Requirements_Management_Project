/*
  Author: Muhammed Suwaneh
  Software Engineer & Student
  Eskişehir Osmangazi University
  May 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReqApp.helpers
{
    public static class Encryption
    {
        private static readonly Random _random = new Random();

        public static string Encrypt(string password)
        {
            string str = "";
            MD5 md5 = MD5.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(passwordBytes);
            for (int i = 0; i < hashBytes.Length; i++)
            {
                str += hashBytes[i];
            }
            return str;
        }

        public static string generateUserId()
        {
            var IdBuilder = new StringBuilder();

            IdBuilder.Append(randomString());

            IdBuilder.Append(randomNumber(1000, 9999));

            return IdBuilder.ToString();
        }

        private static int randomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private static string randomString()
        {
            var builder = new StringBuilder(50); // built string with 50 characters

            char offset = 'a';
            const int lettersOffset = 26;

            for (int i = 0; i < 50; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return builder.ToString();
        }
    }
}
