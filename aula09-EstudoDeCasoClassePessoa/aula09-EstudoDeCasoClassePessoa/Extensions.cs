using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aula09_EstudoDeCasoClassePessoa
{
    static class Extensions
    {
        public static bool HasOnlyDigits(this string valor)
        {
            const string digitos = "0123456789";
            foreach (char c in valor)
            {
                if (!digitos.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
