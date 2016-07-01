using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IFileInterface
    {

        List<String> ReturnMediaFile(string path);

        void UpdateMediaFile(string[] Media);

    }
}
