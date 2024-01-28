using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface IRepository<T>
    {
        public bool Create(T entity);
        public T GetById(int obgjId);
        public bool Update(T entity);
        public bool Delete(int id);
    }
}
