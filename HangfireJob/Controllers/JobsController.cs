using Hangfire;
using HangfireJob.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HangfireJob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        [HttpGet]
        public void RecurringJobsSendMail()
        {
            RecurringJob.AddOrUpdate(
            "myrecurringjob",
            () => _jobService.RecurringJobsSendMail("yassinedriouich@gmail.com"),
            Cron.Minutely);
        }
        [HttpGet("ScheduleJobs")]
        public void ScheduleJobsSendMail()
        {
            BackgroundJob.Schedule(
                () => _jobService.ScheduleJobsSendMail("ScheduleJob@gmail.com"),
                TimeSpan.FromMinutes(1));
        }
        [HttpGet("EnqueueJob")]
        public void EnqueueJobSendMail()
        {
            BackgroundJob.Enqueue(
            () => _jobService.EnqueueJobsSendMail("EnqueueJob@gmail.com"));
        }
    }
}
