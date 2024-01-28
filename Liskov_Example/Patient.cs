using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Example
{
    internal class Patient
    {
        public string id { get; set; }
        public string name { get; set; }
        public virtual string CreateFile (FileDatabase  file , string id )
        {
            return file.Add(id);
        }
    }
}
