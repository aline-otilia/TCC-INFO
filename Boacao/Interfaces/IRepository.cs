using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boacao.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetALL();

        T GetById(int? id);

        void Add(T model);

        void Update(T model);

        void Delete(int? id);
    }
}