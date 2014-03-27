using DAO.DB;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO.Model.Helper;

namespace DAO.Helper
{
    public abstract class ADAO<T>
        where T : ATO<T>, new()
    {
        #region Property

        public Table<T> Table { get { return DataBase.GetTable<T>(); } }

        #endregion

        #region Abstract

        public T Insert(T to)
        {
            try
            {
                this.Table.InsertOnSubmit(to);
                return to;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public T Update(T to)
        {
            try
            {
                this.Select(to.ID).Merge(to);
                return to;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public void Delete(T to)
        {
            try
            {
                if (to == null)
                {
                    return;
                }

                if (!to.HasID())
                {
                    return;
                }

                this.Table.DeleteOnSubmit(this.Select(to.ID));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IList<T> SelectList(T to)
        {
            try
            {
                if (to == null)
                {
                    to = new T();
                }

                IQueryable<T> query =
                    from entity
                    in this.Table
                    where !to.HasID() || entity.ID == to.ID
                    select entity;

                return query.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new List<T>();
        }

        public T Select(Int64 id)
        {
            try
            {
                if (id == 0)
                {
                    return null;
                }

                IQueryable<T> query =
                    from entity
                    in this.Table
                    where entity.ID == id
                    select entity;

                if (query.Count() <= 0)
                {
                    return null;
                }

                return query.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        #endregion
    }
}
