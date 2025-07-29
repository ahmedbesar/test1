using System;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Extensions.Logging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;

namespace test1.Orders.Jobs;

  //  [Queue("alpha")]
    public class CreateOrderLogJob : AsyncBackgroundJob<CreateOrderLogArgs>, ITransientDependency
    {
        private readonly ILogger<CreateOrderLogJob> _logger;

        public CreateOrderLogJob(ILogger<CreateOrderLogJob> logger)
        {
            _logger = logger;
        }

        public override Task ExecuteAsync(CreateOrderLogArgs args)
        {
            try
            {
                _logger.LogInformation(args.LogMessage);
                return Task.CompletedTask;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }
    }
