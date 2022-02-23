namespace HangfireJob.Services
{
    public interface IJobService
    {
        void RecurringJobsSendMail(string email);
        void ScheduleJobsSendMail(string email);
        void EnqueueJobsSendMail(string email);

    }
}
