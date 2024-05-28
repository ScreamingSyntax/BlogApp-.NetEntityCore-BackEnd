﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BisleriumBlog
{
    public interface IEmailCustomSender
    {
        Task SendEmailAsync(string to, string subject, string message);
    }
}
