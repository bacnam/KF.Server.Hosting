using System.Text;

namespace Server.Tools
{
    public class MD5Helper
    {
        /// <summary>
        /// 获取字符串的MD5值(HEX编码)
        /// </summary>
        /// <param name="str">输入的字符串</param>
        /// <returns></returns>
        public static string get_md5_string(string str)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
