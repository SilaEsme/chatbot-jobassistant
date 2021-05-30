using System.Collections.Generic;

namespace JobAssistant
{
    internal class JobList
    {
        private static JobList _jobList;
        private static List<Job> joblist = new List<Job>();

        protected JobList()
        {
        }

        public static JobList CreateSingle()
        {
            if (_jobList == null)
                _jobList = new JobList();
            return _jobList;
        }

        public void AddToJobList(Job job)
        {
            joblist.Add(job);
        }

        public void DeleteFromJobList(Job job)
        {
            joblist.Remove(job);
        }

        public List<Job> GetList()
        {
            return joblist;
        }

        public Job GetJob(int jobID)
        {
            foreach (var item in joblist)
            {
                if (item.JobID == jobID)
                {
                    return item;
                }
            }
            return new Job();
        }
    }
}