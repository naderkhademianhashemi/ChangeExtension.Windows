using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeExtension.Windows.Util
{

    public static class Extens
    {
        public static void NewExtCopy(string path,string suffix)
        {
            var newPath = Path.ChangeExtension(path, suffix);
            File.Copy(path, newPath, true);
        }

        

    }
}
