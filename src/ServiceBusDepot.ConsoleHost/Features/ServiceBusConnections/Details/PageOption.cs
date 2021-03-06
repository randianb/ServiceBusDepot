﻿namespace ServiceBusDepot.ConsoleHost.Features.ServiceBusConnections.Details
{
    public class PageOption : Features.PageOption
    {
        public PageOption(string key, int id, string description) : base(
            key, 
            string.Format("Select \"{0}\"", description), 
            new ServiceBusConnections.Details.Request(id))
        {
        }

        public PageOption(string key, int id) : base(key, "Service Bus Connection Details", new ServiceBusConnections.Details.Request(id))
        {
        }
    }
}
