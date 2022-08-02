using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureID{get;set;}
        public string Post1Title {get;set;}
        public string Post1Description {get;set;}
        public string Post1Image {get;set;}
        public bool Status {get;set;}
    }
}