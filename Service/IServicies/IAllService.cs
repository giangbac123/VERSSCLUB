﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServicies
{
    internal interface IAllService<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetByID(dynamic id);
        public bool CreateObj(T obj);
        public bool UpdateObj(T obj);
        public bool DeleteObj(T obj);

    }
}
