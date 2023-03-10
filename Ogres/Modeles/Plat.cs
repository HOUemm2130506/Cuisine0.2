using System;
using System.Collections.Generic;

namespace OgresKoffiEmmanuel.Modeles;

public partial class Plat
{
    public int PlatId { get; set; }

    public string NomPlat { get; set; } = null!;

    public int NombreBouchees { get; set; }

    public DateTime DateCreation { get; set; }
}
