﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Account
    {
        public int ID { get; set; }


        [DisplayName("Email"), MinLength(5), StringLength(30)]
        public string AccountEmail { get; set; }


        [DisplayName("Password"), MinLength(5), StringLength(30)]
        public string AccountPassword { get; set; }


        [DisplayName("Account Level")]
        public int AccountLevel { get; set; }
    }
}
