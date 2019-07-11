using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmTest
{
    public class Config
    {
        public static string ConnectionString = "server=.;uid=sa;pwd=@jhl85661501;database=SqlSugar4XTest";
        public static string ConnectionString2 = "server=.;uid=sa;pwd=@jhl85661501;database=SQLSUGAR4XTEST";
        public static string ConnectionString3 = "server=.;uid=sa;pwd=@jhl85661501;database=sqlsugar4xtest";
        public static string ConnectionStringLocalDb = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=tempdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
