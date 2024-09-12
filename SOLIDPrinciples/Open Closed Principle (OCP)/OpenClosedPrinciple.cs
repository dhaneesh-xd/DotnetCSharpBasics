using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Closed_Principle__OCP_
{
    public interface IStatusReport
    {
        string Status();
    }
    public class SuccessStatus : IStatusReport
    {
        public string Status()
        {
            return "Success";
        }
    }
    public class FailedStatus : IStatusReport
    {
        public string Status()
        {
            return "Failed";
        }
    }
    public class Report
    {
        private readonly IStatusReport _statusReport;
        public Report(IStatusReport statusReport)
        {
            _statusReport = statusReport;
        }
        public string Status()
        {
            return _statusReport.Status();
        }
    }

}
