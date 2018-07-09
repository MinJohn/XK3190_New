using System;
using System.Configuration;
namespace YIEternalMIS.Common
{
    
    public class PubConstant
    {
        private static string _SqliteConnstr;
        private static string _connectionString;

        public static string SqliteConnstr
        {
            set { _SqliteConnstr = value; }
            get { return _SqliteConnstr; }
        }
        
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>

        public static string ConnectionString
        {
            set { _connectionString = value; }
            get 
            {
                return _connectionString; 
            }

        }



        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
