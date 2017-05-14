using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tarea2Registro.Models
{
    public class Medicinas
    {
        [Key]
        public int MedicinaId { get; set; }

        [StringLength(100)]
        [Display(Name = "Nombre Medicina:")]
        [RegularExpression("([a-zA-Z  .&']+)$", ErrorMessage = "Este campo solo es permitido escribir letras")]
        [Required(ErrorMessage = "Debe ingresar Nombre de la Medicina ")]
        public string NombreMedicina { get; set; }

        
        [Display(Name = "Cantidad de Existencia:")]
        [RegularExpression("([0-9.&-]+)$", ErrorMessage = "Este campo solo es permitido escribir numeros")]
        [Required(ErrorMessage = "Ingrese la cantidad de existencia ")]
        //[DataType(DataType.PhoneNumber)]
        public int CantidadExistencia { get; set; }

       
        [Display(Name = "Precio de Compra:")]
        [RegularExpression("([0-9.&-]+)$", ErrorMessage = "Este campo solo es permitido escribir numeros")]
        [Required(ErrorMessage = "Agregar Compra ")]
        public int PrecioCompra { get; set; }

        [Required(ErrorMessage = "Ingrese fecha de vencimiento")]
        [Display(Name = "Fecha Vencimiento:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[RegularExpression("(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\\d\\d", ErrorMessage = "Fecha Invalida")]
        public DateTime FechaVencimiento { get; set; }

    }
}