using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class CollectionHelper
    {
        #region Method

        public static IList<T> ToList<T>(T[] array)
        {
            try
            {
                if (array == null)
                {
                    return new List<T>();
                }

                return new List<T>(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new List<T>();
        }

        #endregion
    }
}
