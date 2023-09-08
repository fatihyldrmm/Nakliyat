﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IRepositoryManager
    {
        public IUserRepository UserRepository { get; }

        void Save();
    }
}