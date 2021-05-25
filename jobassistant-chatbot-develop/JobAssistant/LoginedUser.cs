using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAssistant
{
    public class LoginedUser
    {
        private static LoginedUser loginedUser;
        private Employee employee = new Employee();
        public Employee Employee
        {
            get => employee;
            set => employee = value;
        }
        protected LoginedUser()
        {

        }
        public static LoginedUser Instance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }
    }
}
