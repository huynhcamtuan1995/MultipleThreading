﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProcessThreading
{
    public class ThreadModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public int Sleep { get; set; }

        public ThreadResponse Response { get; set; }

        public bool IsExpire()
        {
            return CreateAt.AddSeconds(30) <= DateTime.Now;
        }
        public AutoResetEvent Event = new AutoResetEvent(false);
    }

    public class ThreadResponse
    {
        public int Status { get; set; }
        public string Message { get; set; }
    }
}