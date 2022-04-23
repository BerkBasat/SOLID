using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class RegisterUser
    {
        Logger logger;
        string log;
        public RegisterUser()
        {
            logger = new Logger();
        }


        public bool Register(User user)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(user.Id);
                sb.AppendLine();
                sb.Append(user.UserName);
                sb.AppendLine();
                sb.Append(user.Password);
                sb.AppendLine();
                sb.Append(user.Email);
                sb.AppendLine();
                sb.Append(user.RegisterDate);
                log = logger.BuildLog(sb.ToString());
                logger.LogFile("C:/Users/Huawei/Desktop/User.txt", log);
                return true;

            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Error: ");
                sb.AppendLine();
                sb.Append(ex.Message);
                log = logger.BuildLog(sb.ToString());
                logger.LogFile("C:/Users/Huawei/Desktop/User.txt", log);
                return false;

            }
        }
    }
}
