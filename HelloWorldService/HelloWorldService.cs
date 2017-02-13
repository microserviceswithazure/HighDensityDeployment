using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Data.Collections;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;

namespace HelloWorldService
{
    using System.Configuration;

    using StackExchange.Redis;

    /// <summary>
    /// An instance of this class is created for each service replica by the Service Fabric runtime.
    /// </summary>
    internal sealed class HelloWorldService : StatefulService
    {
        public HelloWorldService(StatefulServiceContext context)
            : base(context)
        { }

        /// <summary>
        /// Optional override to create listeners (e.g., HTTP, Service Remoting, WCF, etc.) for this service replica to handle client or user requests.
        /// </summary>
        /// <remarks>
        /// For more information on service communication, see https://aka.ms/servicefabricservicecommunication
        /// </remarks>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceReplicaListener> CreateServiceReplicaListeners()
        {
            return new ServiceReplicaListener[0];
        }

        /// <summary>
        /// This is the main entry point for your service replica.
        /// This method executes when this replica of your service becomes primary and has write status.
        /// </summary>
        /// <param name="cancellationToken">Canceled when Service Fabric needs to shut down this service replica.</param>
        protected override async Task RunAsync(CancellationToken cancellationToken)
        {
            //ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(ConfigurationManager.AppSettings["connection"]);
            //IDatabase cache = connection.GetDatabase();
            //var rnd = new Random();
            //Thread.Sleep(TimeSpan.FromSeconds(rnd.Next(1, 40)));
            //if (cache.KeyExists("instanceCount"))
            //{
            //    var value = (int)cache.StringGet("instanceCount") + 1;
            //    cache.StringSet("instanceCount", value);
            //}
            //else
            //{
            //    cache.StringSet("instanceCount", 1);
            //}

            cancellationToken.WaitHandle.WaitOne();
        }
    }
}
