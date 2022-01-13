using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Laba06_Lipinskiy
{
    class PassWordGen
    {
        readonly string passWord;
        readonly int myLength;
        const int myIterations = 1000; 
        byte[] salt0 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }; 
        byte[] _result;
        public PassWordGen(string usageText, string usageLen) 
        {
            passWord = usageText;
            myLength = int.Parse(usageLen);
        }
        public byte[] Result
        {
            get 
            {
                this._result = calculations(this.passWord, this.myLength);
                return this._result;
            }
            set 
            {
            }
        }
        private byte[] calculations(string passWord, int len)
        {
            
            Rfc2898DeriveBytes k0 = new Rfc2898DeriveBytes(passWord, salt0); 

            byte[] key = k0.GetBytes(len);
            return key;
        }
    }
}
