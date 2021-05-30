using System.Collections.Generic;

namespace JobAssistant
{
    public class LoginedUser
    {
        private static LoginedUser _loginedUser;

        private Employee employee = new Employee();
        private List<Job> properJobs = new List<Job>();

        public Employee Employee
        {
            get => employee;
            set => employee = value;
        }

        public List<Job> ProperJobs
        {
            get => properJobs;
        }

        protected LoginedUser()
        {
            // Constructor
        }

        public static LoginedUser Instance()
        {
            if (_loginedUser == null)
            {
                _loginedUser = new LoginedUser();
            }
            return _loginedUser;
        }

        public void AddProperJob(Job job)
        {
            properJobs.Add(job);
        }

        public bool IsContains(Job job)
        {
            foreach (var item in properJobs)
            {
                if (item == job)
                {
                    return true;
                }
            }
            return false;
        }
    }
}