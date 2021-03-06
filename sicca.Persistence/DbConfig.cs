﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace sicca.Persistence
{
    public class DbConfig : DbConfiguration
    {
        public DbConfig()
        {
            var provider = "Npgsql";
            SetProviderFactory(provider, NpgsqlFactory.Instance);
            SetProviderServices(provider, NpgsqlServices.Instance);
            SetDefaultConnectionFactory(new NpgsqlConnectionFactory());
        }
    }
}
