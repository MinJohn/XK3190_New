using System;
using System.Configuration;
using YIEternalMIS.Common;
namespace YIEternalMIS.DBUtility
{
    
    public class PubConstant
    {
        private static string _Connstr;
        private static string _connectionString;

        public static string Connstr
        {
            set { _Connstr = value; }
            get { return _Connstr; }
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
