using System.ComponentModel.DataAnnotations;

namespace VitaForgeWeb.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El peso es obligatorio.")]
        [Range(30.0, 180.0, ErrorMessage = "El peso debe estar entre 30 y 180 kg.")]
        public double? Peso { get; set; }

        [Required(ErrorMessage = "La altura es obligatoria.")]
        [Range(100.0, 250.0, ErrorMessage = "La altura debe estar entre 100 y 250 cm.")]
        public double? Altura { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(12, 120, ErrorMessage = "La edad debe estar entre 12 y 120 años.")]
        public int? Edad { get; set; }

        [Required(ErrorMessage = "Debe seleccionar su sexo.")]
        public string Sexo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar su objetivo.")]
        public string Objetivo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar su estilo de vida.")]
        public string EstiloVida { get; set; } = string.Empty;
    }
}
