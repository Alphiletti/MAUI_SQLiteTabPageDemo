using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTabPageDemo.Abstract
{
    public interface IBaseRepository<T> : IDisposable where T : TableData, new()
    {
        List<T> GetAll();
        void AddItem(T item);
        void DeleteItem(T item);
    }
}
