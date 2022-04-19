using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLab.Common
{
    public static class StringConstants
    {
        public static string DbConnectionString { get; } = @"Server=(localdb)\mssqllocaldb;Database=EFCoreLab;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;";
    }
}
