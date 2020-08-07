using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyMVCApplication.Models
{
    public class Parent
    {

        public int parentId { get; set; }
        [Display(Name = "Name")]
        public string ParentName { get; set; }
        public string ParentFirstName { get; set; }
    }

    public class StandardParent
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}