using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Observador //motor
    {
        void update(); // actualizar cuando el sujeto lo notifique o dispare un evento
    }
}
