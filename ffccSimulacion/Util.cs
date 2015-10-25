using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ffccSimulacion
{
    public class Util
    {
        static public bool EsAlfabetico(string buffer)
        {
            if (buffer.Length == 0)
            {
                return false;
            }
            Regex reg = new Regex(@"[ -_/\(),.A-Za-zñÑáéíóúÁÉÓÚÍ]*");

            Match match = reg.Match(buffer);

            if (match.Value.Equals(buffer))
            {
                return true;
            }

            return false;
        }

        static public bool EsNumerico(string buffer)
        {
            if (buffer.Length == 0)
            {
                return false;
            }

            Regex reg = new Regex(@"[0-9]*");

            Match match = reg.Match(buffer);

            if (match.Value.Equals(buffer))
            {
                return true;
            }

            return false;
        }

        static public bool EsAlfaNumerico(string buffer)
        {
            if (buffer.Length == 0)
            {
                return false;
            }

            Regex reg = new Regex(@"[ -_/\(),.A-Za-zñÑ0-9áéíóúÁÉÓÚÍ]*");

            Match match = reg.Match(buffer);

            if (match.Value.Equals(buffer))
            {
                return true;
            }

            return false;
        }
    }
}
