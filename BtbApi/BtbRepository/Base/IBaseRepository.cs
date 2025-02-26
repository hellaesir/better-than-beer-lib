﻿using BtbDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbRepository.Base
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity, ActiveUserDTO activeUser);
        Task Update(T entity, ActiveUserDTO activeUser);
        Task<T> GetById(int id);
        Task<List<T>> GetList(int pageIndex, int pageSize);
        Task<int> Count();
    }
}
