using Helper.Pattern;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TO.Model.Helper;

namespace TO.Model
{
    [DataContract]
    [Table]
    public class Transaction : ATO<Transaction>
    {

    }
}
