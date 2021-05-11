﻿using FiDeli.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application
{
    public interface INotificationMaker
    {
        public CommissionNotification CreateNotification(Commission commission);

    }
}
