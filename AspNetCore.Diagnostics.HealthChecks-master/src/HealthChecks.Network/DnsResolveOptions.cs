﻿using System.Collections.Generic;

namespace HealthChecks.Network
{
    public class DnsResolveOptions
    {
        internal Dictionary<string, DnsRegistration> ConfigureHosts = new Dictionary<string, DnsRegistration>();
        public void AddHost(string host, DnsRegistration registration)
        {
            ConfigureHosts.Add(host, registration);
        }
    }    
}
