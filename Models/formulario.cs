using System;
using System.ComponentModel.DataAnnotations;


namespace practica1.Models
{

    [Table("t_formulario")]
    public class formulario
    {   
        
        public String nombre { get; set; }


        
        public String apellido { get; set; }

        public String distrito { get; set; }

        public String banco { get; set; }

        public int edad { get; set; }

        public String genero { get; set; }

        public String autor { get ; set ; }

        

    }
}