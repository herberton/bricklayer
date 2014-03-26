using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Pattern
{
    public abstract class ATO<T>
        where T : ATO<T>, new()
    {
        #region Property

        public Int64 ID { get; set; }

        #endregion

        #region Method

        public Boolean HasID()
        {
            return 
                this.ID != null && 
                this.ID != 0;
        }


        public static T Cast<T>(Object object1)
            where T : class, new()
        {
            try
            {
                if (object1 == null)
                {
                    return null;
                }

                T object2 = new T();

                foreach (PropertyInfo property in object1.GetType().GetProperties())
                {
                    if (!property.CanRead)
                    {
                        continue;
                    }

                    try
                    {
                        if (object2.GetType().GetProperty(property.Name) != null)
                        {
                            object2.GetType().GetProperty(property.Name).SetValue(object2, property.GetValue(object1));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                return object2;
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
