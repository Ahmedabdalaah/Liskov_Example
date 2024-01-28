using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Example
{
    internal class Female : Patient
    {
        public override string CreateFile(FileDatabase file, string id)
        {
            return file.AddFemale(id);
        }
    }
}
