using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using w06a.Validators;

namespace w06a.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {
        [Required(ErrorMessage = "Product name is required.")]
        [ProductNameValidator(3)]
        [DisplayFormat(ApplyFormatInEditMode=true)]
        public object ProductName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public object ProductID { get; set; }

        [ScaffoldColumn(false)]
        public object ReorderLevel { get; set; }

        [ScaffoldColumn(false)]
        public object Discontinued { get; set; }

        [ScaffoldColumn(false)]
        public object QuantityPerUnit { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsOnOrder { get; set; }

        [UIHint("SupplierDropDown")]
        [Display(Name="Supplier")]
        public object SupplierID { get; set; }

        [UIHint("CategoryDropDown")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }
    }
}