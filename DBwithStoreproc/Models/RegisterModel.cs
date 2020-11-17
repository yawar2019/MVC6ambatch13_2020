using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBwithStoreproc.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="UserName is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage ="Pwd and CPwd are Not Matching")]
        public string ConfirmPwd { get; set; }
        [Range(12,50,ErrorMessage ="12-50 are Allowed")]
        [Required(ErrorMessage = "Password is Required")]
        public int age { get; set; }
        //[DataType(DataType.EmailAddress,ErrorMessage ="Invalid EmailId")]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage ="Emailid is Invalid")]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="Max 10 Character")]
        public string Address { get; set; }

    }
}