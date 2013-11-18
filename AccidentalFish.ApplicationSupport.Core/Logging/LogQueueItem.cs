﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentalFish.ApplicationSupport.Core.Logging
{
    public class LogQueueItem
    {
        public string Source { get; set; }

        public string Message { get; set; }

        public string ExceptionName { get; set; }

        public string StackTrace { get; set; }

        public string InnerExceptionName { get; set; }

        public LogLevelEnum Level { get; set; }

        public DateTimeOffset LoggedAt { get; set; }
    }
}
