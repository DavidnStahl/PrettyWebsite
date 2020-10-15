using EPiServer.PlugIn;
using EPiServer.Scheduler;
using PrettyWebsite.Repositories.Interfaces;
using System;

namespace PrettyWebsite.ScheduledJobs
{
    [ScheduledPlugIn(DisplayName = "ScheduledJobDeleteBadReview")]
    public class ScheduledJobDeleteBadReview : ScheduledJobBase
    {
        private bool _stopSignaled;

        private readonly IDataStoreRepository _dataStoreRepository;

        public ScheduledJobDeleteBadReview(IDataStoreRepository dataStoreRepository)
        {
            IsStoppable = true;
            _dataStoreRepository = dataStoreRepository;
        }

        /// <summary>
        /// Called when a user clicks on Stop for a manually started job, or when ASP.NET shuts down.
        /// </summary>
        public override void Stop()
        {
            _stopSignaled = true;
        }

        /// <summary>
        /// Called when a scheduled job executes
        /// </summary>
        /// <returns>A status message to be stored in the database log and visible from admin mode</returns>
        public override string Execute()
        {
            //Call OnStatusChanged to periodically notify progress of job for manually started jobs
            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));

            //Add implementation
            var count = _dataStoreRepository.DeleteBadReview();

            //For long running jobs periodically check if stop is signaled and if so stop execution
            if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return $"{count} reviews was deleted";
        }
    }
}
