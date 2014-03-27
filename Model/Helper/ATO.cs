using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace TO.Model.Helper
{
    public abstract class ATO<T>
        where T : ATO<T>, new()
    {
        #region Property

        [Column(IsPrimaryKey = true)]
        public Int64 ID { get; set; }

        #endregion

        #region Method

        public Boolean HasID()
        {
            return
                this.ID != 0;
        }

        public void Merge(T to)
        {
            try
            {
                ATO<T>.Merge((T)this, to);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void Merge(T to1, T to2)
        {
            try
            {
                if (to1 == null)
                {
                    return;
                }

                if (to2 == null)
                {
                    return;
                }

                foreach (PropertyInfo property2 in to2.GetType().GetProperties())
                {
                    if (!property2.CanRead)
                    {
                        continue;
                    }

                    try
                    {
                        PropertyInfo property1 = to1.GetType().GetProperty(property2.Name);
                        if (property1 != null && property1.CanWrite)
                        {
                            property1.SetValue(to1, property2.GetValue(to2));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static T Cast(Object object1)
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
