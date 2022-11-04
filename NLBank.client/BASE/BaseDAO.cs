using NLBank.client.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.BASE
{
    public interface BaseDAO<T>
    {
        T GetById(string id);
        List<T> GetAll();
        bool Delete(string id);
        bool Update(T item);
        T Create(T item); 
    }
}
