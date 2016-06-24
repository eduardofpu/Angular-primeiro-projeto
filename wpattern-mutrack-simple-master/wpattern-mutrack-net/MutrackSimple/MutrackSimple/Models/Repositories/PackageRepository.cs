﻿using MutrackSimple.Models.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MutrackSimple.Models.Repositories
{
    public interface PackageRepository : GenericRepository<PackageEntity, int>
    {
    }
}