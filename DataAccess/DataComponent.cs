using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;

namespace DataAccess
{
    public abstract class DataComponent : IDataComponent

    {
        public long ID { get; set; }

        public void DeleteRecord()
        {
            throw new NotImplementedException();
        }

        public void LoadRecord()
        {
            throw new NotImplementedException();
        }

        public long SaveRecord()
        {
            throw new NotImplementedException();
        }
    }
}
