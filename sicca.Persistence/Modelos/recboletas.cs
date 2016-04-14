using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Domain.Modelos
{
    [Table("recboletas")]
    public partial class recboletas
    {
        public recboletas()
        {
        }

        [Key]
        public int id { get; set; }

        [StringLength(1)]
        public string prefijo { get; set; }

        public int folio { get; set; }

        [Required]
        [StringLength(2)]
        public string cultivo { get; set; }

        [Required]
        [StringLength(5)]
        public string ciclo { get; set; }

        [Required]
        [StringLength(5)]
        public string temporada { get; set; }

        public int? numinsta { get; set; }

        public int numtabla { get; set; }

        [Column("numcliente")]
        public int? idnumcliente { get; set; }

        public int? numremision { get; set; }

        public int? variedad { get; set; }

        public int? numgrupo { get; set; }

        public int? tipoprecio { get; set; }

        public int? tipomov { get; set; }

        public int? centroreceptor { get; set; }

        public int? bodegareceptor { get; set; }

        public DateTime? fecha { get; set; }

        public DateTime? fechacaptura { get; set; }

        public System.TimeSpan? horabruto { get; set; }

        public System.TimeSpan? horatara { get; set; }

        public decimal? kgbruto { get; set; }

        public decimal? kgtara { get; set; }

        [StringLength(15)]
        public string placas { get; set; }

        [StringLength(25)]
        public string chofer { get; set; }

        public int? tipovehiculo { get; set; }

        [StringLength(20)]
        public string marcaverhiculo { get; set; }

        [StringLength(25)]
        public string blockprocedencia { get; set; }

        public int? tipodepredio { get; set; }

        public int? claveejido { get; set; }

        public int? bodegainterna { get; set; }

        [StringLength(15)]
        public string usuarioregistra { get; set; }

        public int? liquidada { get; set; }

        public DateTime? fechaliq { get; set; }

        public int? numcorte { get; set; }

        public int? impresa { get; set; }

        public int? cancelada { get; set; }

        public DateTime? fechacanc { get; set; }

        public System.TimeSpan? horacancela { get; set; }

        [StringLength(15)]
        public string usuariocanc { get; set; }

        [StringLength(60)]
        public string motivocanc { get; set; }

        [StringLength(60)]
        public string observaciones { get; set; }

        public int? numticket { get; set; }

        public int? auditada { get; set; }

        public DateTime? fechaauditada { get; set; }

        public System.TimeSpan? horaauditada { get; set; }

        [StringLength(15)]
        public string usuarioaudito { get; set; }

    }

}
