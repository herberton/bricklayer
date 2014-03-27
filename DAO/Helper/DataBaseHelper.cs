using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Helper.Pattern;
using DAO.DB;

namespace DAO.Helper
{
    public static class DataBaseHelper
    {
        #region Variable

        private static HerbertonDataBase dataBase;

        #endregion

        #region Property

        public static HerbertonDataBase DataBase
        {
            get
            {
                lock (typeof(HerbertonDataBase))
                {
                    if (DataBaseHelper.dataBase == null)
                    {
                        DataBaseHelper.dataBase = new HerbertonDataBase();
                    }
                }

                return DataBaseHelper.dataBase;
            }
        }

        #endregion

        #region Method

        public static void SubmitChanges()
        {
            DataBaseHelper.DataBase.SubmitChanges();
        }

        public static Table<T> GetTable<T>()
            where T : class, new()
        {
            try
            {
                Type type = typeof(T);

                foreach (PropertyInfo property in DataBaseHelper.DataBase.GetType().GetProperties())
                {
                    if (property.Name.Replace("Table", String.Empty).Equals(type.Name))
                    {
                        return (Table<T>)property.GetValue(DataBaseHelper.DataBase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public static void DropAndCreateDataBase()
        {
            try
            {
                if (DataBaseHelper.DataBase.DatabaseExists())
                {
                    DataBaseHelper.DataBase.DeleteDatabase();
                }

                DataBaseHelper.DataBase.CreateDatabase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
