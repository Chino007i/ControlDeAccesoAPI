namespace ControlAccesoBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permiso_Trabajo_Detalle
    {
        [Key]
        public int id_permiso_trabajo_detalle { get; set; }

        public int id_permiso_trabajo { get; set; }

        public int id_persona { get; set; }
    }
}
