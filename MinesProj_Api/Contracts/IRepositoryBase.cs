﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryBase<T> 
        where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T?> Get(int id);

        Task<T> Add(T entity);

        Task<T?> Update(T entity);

        Task<T?> Delete(int id);
    }
}
