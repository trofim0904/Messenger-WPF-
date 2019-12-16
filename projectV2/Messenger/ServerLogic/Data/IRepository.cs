﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic.Data
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetItemList(); 
        T GetItem(int id); 
        void Create(T item); 
        void Update(T item); 
        void Delete(int id);
        void Save();  
    }
}
