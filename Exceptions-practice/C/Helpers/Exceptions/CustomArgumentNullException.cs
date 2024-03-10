using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_practice.Helpers.Exceptions
{
    public class CustomArgumentNullException:Exception
    {
        public CustomArgumentNullException(string msj):base(msj)
        {  
        }
        public CustomArgumentNullException(string parametr,string msj)
        {
            
        }
    }
}
