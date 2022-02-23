namespace HangfireJob.Services
{
    public class JobService : IJobService
    {
        public void EnqueueJobsSendMail(string email)
        {
            Console.WriteLine("Enqueue Job");
        }

        public void RecurringJobsSendMail(string email)
        {
            Console.WriteLine("Mail Sent");
        }

        public void ScheduleJobsSendMail(string email)
        {
            Console.WriteLine("Schedule Jobs");
        }
    }
}
