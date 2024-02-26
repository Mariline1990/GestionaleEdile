using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionaleEdile.Models
{
    public class Dipendenti
    {


        public  string Nome { get; set; }

        //[Required(ErrorMessage="Il nome è obbligatorio")]
        public string Cognome { get; set; }

        public string Indirizzo { get; set; }

        [Display(Name = "Codice Fiscale")]
        public string Codice_Fiscale {  get; set; }


       
        public bool Celibe { get; set; }

        public string Mansione { get; set; }

        public int Figli { get; set; }



        Dipendenti(string nome, string cognome, string indirizzo, string codice_Fiscale, bool celibe, int figli, string mansione)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Codice_Fiscale = codice_Fiscale;
            Celibe = celibe;
            Mansione = mansione;
            Figli = figli;
           
        }
    }
}