using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTabPageDemo.Abstract
{
    public class BaseRepository<T> : IBaseRepository<T> where T : TableData, new()
    {

        SQLiteConnection conn;
        public string statusMessage { get; set; }
        public BaseRepository()
        {
            conn = new SQLiteConnection(Constants.DatabasePath);
            conn.CreateTable<T>();
        }
        public void AddItem(T item)
        {
            int result = 0;
            try
            {
                if(item.Id != 0)
                {
                    result = conn.Update(item);
                    statusMessage = $"{result} rows updated";
                }
                else
                {
                    result = conn.Insert(item);
                    statusMessage = $"{result} rows added";
                }
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public void DeleteItem(T item)
        {
            try
            {
                conn.Delete(item);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<T> GetAll()
        {
            try
            {
                return conn.Table<T>().ToList();
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }

            return null;
        }
    }
}
