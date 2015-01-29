﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Web.Mvc;
using Copiosis_Application.DB_Data;

namespace Copiosis_Application.Models
{
    public class AddClassModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "SuggestedGateway is required")]
        [Display(Name = "Suggested Gateway")]
        public int suggestedGateway { get; set; }

        [Required(ErrorMessage = "Cpdb is required")]
        [Display(Name = "Cpdb")]
        public float cPdb { get; set; }

        [Required(ErrorMessage = "A is required")]
        [Display(Name = "Resource abundance")]
        public float a { get; set; }

        [Required(ErrorMessage = "Amax is required")]
        [Display(Name = "Max resources")]
        public int aMax { get; set; }

        [Required(ErrorMessage = "D is required")]
        [Display(Name = "Consumer demand")]
        public int d { get; set; }

        [Required(ErrorMessage = "Aprime is required")]
        [Display(Name = "Producer population")]
        public int aPrime { get; set; }

        [Required(ErrorMessage = "Ccb is required")]
        [Display(Name = "Ccb")]
        public float cCb { get; set; }

        [Required(ErrorMessage = "M1 is required")]
        [Display(Name = "M1")]
        public float m1 { get; set; }

        [Required(ErrorMessage = "P0 is required")]
        [Display(Name = "Consumer objective benefit")]
        public int p0 { get; set; }

        [Required(ErrorMessage = "M2 is required")]
        [Display(Name = "M2")]
        public float m2 { get; set; }

        [Required(ErrorMessage = "Ceb is required")]
        [Display(Name = "Ceb")]
        public float cEb { get; set; }

        [Required(ErrorMessage = "S is required")]
        [Display(Name = "Social benefit")]
        public int s { get; set; }

        [Required(ErrorMessage = "M3 is required")]
        [Display(Name = "M3")]
        public float m3 { get; set; }

        [Required(ErrorMessage = "Se is required")]
        [Display(Name = "Environmental impact")]
        public short sE { get; set; }

        [Required(ErrorMessage = "M4 is required")]
        [Display(Name = "M4")]
        public float m4 { get; set; }

        [Required(ErrorMessage = "Sh is required")]
        [Display(Name = "Human impact")]
        public short sH { get; set; }

        [Required(ErrorMessage = "M5 is required")]
        [Display(Name = "M5")]
        public float m5 { get; set; }

        public string message { get; set; }
    }

    public class RejectedModel
    {
        public List<RejectedTransactionModel> rejected { get; set; }
    }

    public class RejectedTransactionModel
    {
        public Guid transactionID { get; set; }
        public string name { get; set; }
        public int gateway { get; set; }
        public DateTime? dateRejected { get; set; }
        public string producer { get; set; }
        public string consumer { get; set; }
    }

    public class ClassOverviewModel
    {
        public List<ClassModel> products { get; set; }
        public List<ClassModel> productsDefault { get; set; }
        //public Dictionary<string, int> ItemClassTemplates { get; set; }
        public List<SelectListItem> ItemClassTemplates { get; set; }
    }

    public class ClassModel
    {
        public int classID { get; set; }
        public string className { get; set; }
        public string productName { get; set; }
        public string productDesc { get; set; }
        public Guid productGuid { get; set; }
        public string productOwner { get; set; }
    }

}
