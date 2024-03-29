﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace atm_api_net_core.Models
{
    public class TarjetaRequest
    {

        public abstract class TarjetaBase
        {
            [Required(ErrorMessage = "El campo Pin es obligatorio")]
            [MaxLength(4, ErrorMessage = "El pin de la tarjeta tiene que ser 4 digitos")]
            [MinLength(4, ErrorMessage = "El pin de la tarjeta tiene que ser 4 digitos")]
            [RegularExpression(@"^[0-9]{4,4}$", ErrorMessage = "El pin de la tarjeta tienen que ser 4 digitos numericos")]
            public string Pin { get; set; }
        }

        public sealed class Create : TarjetaBase
        {

            [Required(ErrorMessage = "El campo Numero es obligatorio")]
            [MaxLength(16, ErrorMessage = "El numero de la tarjeta tiene que ser de 16 digitos")]
            [MinLength(16, ErrorMessage = "El numero de la tarjeta tiene que ser de 16 digitos")]
            [RegularExpression(@"^[0-9]{16,16}$", ErrorMessage = "El numero de la tarjeta no tiene el formato correcto. Tienen que ser una cadena de numeros")]
            public string Numero { get; set; }

        }

        public sealed class Update : TarjetaBase
        {

            //[Required(ErrorMessage = "El campo Pin es obligatorio")]
            //[MaxLength(4, ErrorMessage = "El pin de la tarjeta tiene que ser 4 digitos")]
            //[MinLength(4, ErrorMessage = "El pin de la tarjeta tiene que ser 4 digitos")]
            //[RegularExpression(@"^[0-9]{4,4}$", ErrorMessage = "El pin de la tarjeta tienen que ser 4 digitos numericos")]
            //public string Pin { get; set; }

        }

        public sealed class ValidarNumero
        {

            [Required(ErrorMessage = "El campo Numero es obligatorio")]
            [MaxLength(16, ErrorMessage = "El numero de la tarjeta tiene que ser de 16 digitos")]
            [MinLength(16, ErrorMessage = "El numero de la tarjeta tiene que ser de 16 digitos")]
            [RegularExpression(@"^[0-9]{16,16}$", ErrorMessage = "El numero de la tarjeta no tiene el formato correcto. Tienen que ser una cadena de numeros")]
            public string Numero { get; set; }

        }

    }
}
