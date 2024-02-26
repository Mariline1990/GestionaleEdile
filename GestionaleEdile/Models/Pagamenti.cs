using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionaleEdile.Models
{
    public class Pagamenti
    {
        [Display(Name = "ID Dipendente")]
        public int ID_Dipendente { get; set; }

        [Display(Name = "Periodo lavorativo")]
        public DateTime Periodo_pagamento { get; set; }


        [Display(Name="Stipendio/Parcella")]
        public decimal Ammontare_pagamento { get; set; }
        public bool Acconto { get; set; }

        Pagamenti(int id_Dipendente, DateTime periodo_pagamento, decimal ammontare_pagamento, bool acconto)
        {
            ID_Dipendente = id_Dipendente;
            Periodo_pagamento = periodo_pagamento;
            Ammontare_pagamento = ammontare_pagamento;
            Acconto = acconto;
        }
    }
}