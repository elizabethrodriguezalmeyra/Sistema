using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Sistema.Entidades.Almacen
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage =
            "El nombre no debe tener mas de 50 caracteres")]
        public string nombre { get; set; }
        [StringLength (256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

    }
}
