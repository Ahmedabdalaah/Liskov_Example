using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Example
{
    internal class FileDatabase
    {
        public string Add(string id)
        {
            return $"The patient number {id} file is created in normal room  ";

        }
        public string AddMale(string id)
        {
            return $"The patient number {id} file is created in special room for men "; 

        }
        public string AddFemale (string id)
        {
            return $"The patient number {id} file is created in special room for women  ";
        }
    }
}
