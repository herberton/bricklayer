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

        public const String CONNECTION = "Data Source=WINT45P;Initial Catalog=Exercise;Integrated Security=True";

        #endregion

        #region Variable

        private static DataContext dataContext;

        #endregion

        #region Property

        public static DataContext DataContext
        {
            get
            {
                lock (typeof(DataBase))
                {
                    if (DataBase.dataContext == null)
                    {
                        DataBase.dataContext = new DataContext(DataBase.CONNECTION);
                    }
                }

                return DataBase.dataContext;
            }
        }

        public static EntityMapping EntityMapping { get { return Singleton<EntityMapping>.Instance; } }

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

                foreach (PropertyInfo property in DataBase.EntityMapping.GetType().GetProperties())
                {
                    if (property.Name.Replace("Table", String.Empty).Equals(type.Name))
                    {
                        return (Table<T>)property.GetValue(DataBase.EntityMapping);
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
