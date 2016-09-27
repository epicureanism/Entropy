﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace Mvc.LocalizationSample.Web.Models
{
    public class Product
    {
        [Required(ErrorMessage = "ProductName")]
        public string ProductName { get; set; }

        [MinLengthSix(ErrorMessage = "MinLengthSix")]
        public string ProductDescription { get; set; }
    }
}
