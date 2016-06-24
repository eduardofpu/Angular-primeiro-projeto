﻿using MutrackSimple.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MutrackSimple.Models.Repositories
{
    public interface UserRepository : GenericRepository<UserEntity, int>
    {
    }
}