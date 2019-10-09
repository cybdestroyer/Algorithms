using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Common
{
    public class Dialogue
    {
        public string MainMenuOptions
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("\t(1) bubble-sort\n");
                sb.Append("\t(2) merge-sort\n");
                sb.Append("\t(3) tim-sort\n");
                sb.Append("\t(0) exit\n");

                return sb.ToString();
            }
        }

        public static Dialogue Build()
        {
            return new Dialogue();
        }
    }
}
