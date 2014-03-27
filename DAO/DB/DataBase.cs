using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Helper.Pattern;

namespace DAO.DB
{
    public static class DataBase
    {
        #region Constant

        public const String CONNECTION = "Data Source=WINT45P;Integrated Security=True";

        #endregion

        #region Variable

        private static EntityDataContext dataContext;

        #endregion

        #region Property

        public static EntityDataContext DataContext
        {
            get
            {
                lock (typeof(EntityDataContext))
                {
                    if (DataBase.dataContext == null)
                    {
                        DataBase.dataContext = new EntityDataContext(DataBase.CONNECTION);

                        if (DataBase.dataContext.DatabaseExists())
                        {
                            DataBase.dataContext.DeleteDatabase();
                        }

                        DataBase.dataContext.CreateDatabase();
                    }
                }

                return DataBase.dataContext;
            }
        }

        #endregion

        #region Method

        public static void SubmitChanges()
        {
            DataBase.DataContext.SubmitChanges();
        }

        public static Table<T> GetTable<T>()
            where T : class, new()
        {
            try
            {
                Type type = typeof(T);

                foreach (PropertyInfo property in DataBase.DataContext.GetType().GetProperties())
                {
                    if (property.Name.Replace("Table", String.Empty).Equals(type.Name))
                    {
                        return (Table<T>)property.GetValue(DataBase.DataContext);
                    }
                }
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
