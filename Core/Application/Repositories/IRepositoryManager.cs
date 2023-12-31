﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IRepositoryManager
    {
        public ICustomerRepository CustomerRepository { get; }
        public ITasimaTalebiRepository TasimaTalebiRepository { get; }
        public IEkipRepository EkipRepository { get; }
        void Save();
    }
}
