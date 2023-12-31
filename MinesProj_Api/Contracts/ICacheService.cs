﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts;

public interface ICacheService
{
    T GetData<T>(string key);

    bool SetData<T>(string key, T value, DateTimeOffset expirationTime);
    
    bool RemoveData(string key);
}

