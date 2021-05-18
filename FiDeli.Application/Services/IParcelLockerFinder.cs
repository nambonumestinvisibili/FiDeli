﻿using FiDeli.Domain;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiDeli.Application
{
    public interface IParcelLockerFinder
    {
        ParcelLocker FindCloserParcelLocker(GeoLocation location);
    }
}
