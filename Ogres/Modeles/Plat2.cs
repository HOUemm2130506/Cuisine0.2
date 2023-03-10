using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgresKoffiEmmanuel.Modeles
{
    public partial class Plat
    {
        public override string ToString()
        {
            return $"******** L'Identifiant du  Plat: #{PlatId}************\n" +
                $" ********Le Nom  du  Plat: #{NomPlat}*******************\n" +
                $" ********La Date de creation  du  Plat: #{DateCreation}********\n";
        }

    }
}
