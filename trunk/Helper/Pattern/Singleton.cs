using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Pattern
{
    public static class Singleton<T>
        where T : class, new()
    {
        #region Variable

        private static T instance;

        #endregion

        #region Property

        public static T Instance
        {
            get
            {
                lock (typeof(T))
                {
                    if (Singleton<T>.instance == null)
                    {
                        Singleton<T>.instance = new T();
                    }
                }

                return Singleton<T>.instance;
            }
        }

        #endregion
    }
}
