using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataComponent
    {
        long ID { get; set; }

        void LoadRecord();
        long SaveRecord();
        void DeleteRecord();

    }
}
