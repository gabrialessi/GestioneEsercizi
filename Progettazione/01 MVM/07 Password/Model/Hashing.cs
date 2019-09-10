using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_Password.Model
{
    public class Hashing
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        public string Hash { get; set; }

        public string PlainText { get; set; }

        public string Salt { get; set; }
        #endregion

        #region =================== costruttori ================
        public Hashing() : this("", "", "")
        {

        }

        public Hashing(string hash, string plainText, string salt)
        {
            Hash = hash;
            PlainText = plainText;
            Salt = salt;
        }
        #endregion

        #region =================== metodi aiuto ===============
        #endregion

        #region =================== metodi generali ============
        public void ComputeHash()
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] textWithSaltBytes = utf8.GetBytes(string.Concat(PlainText, Salt));
            HashAlgorithm hasher = new SHA1CryptoServiceProvider();
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            Hash = Convert.ToBase64String(hashedBytes);
        }
        #endregion
    }
}
