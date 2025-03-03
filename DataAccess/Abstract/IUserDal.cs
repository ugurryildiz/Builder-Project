﻿using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        User GetUserDetail(int Id);
    }
}

