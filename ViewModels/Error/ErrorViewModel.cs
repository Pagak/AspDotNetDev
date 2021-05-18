using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels.Error
{
    public class ErrorViewModel
    {
        public string StatusClass { get; set; }
        public string Message { get; set; }

        public ErrorViewModel()
        {
            Message = "Une erreur s'est produite lors du traitement de votre demande.";
        }
    }


}