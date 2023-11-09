using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Laboratorna3.Models
{
    public class ProtocolContext2 : DbContext
    {
        public DbSet<Protocol> Protocols { get; set; }
    }

}