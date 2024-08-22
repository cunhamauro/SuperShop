﻿using Microsoft.EntityFrameworkCore;
using SuperShop.Migrations;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using static System.Net.WebRequestMethods;

namespace SuperShop.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        //[Display(Name = "Image")]
        //public Guid ImageId { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }


        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }

        //public string ImageFullPath => ImageId == Guid.Empty ? $"https://supershopmc.azurewebsites.net/images/noimage.jpg" : $"https://supershopmc.blob.core.windows.net/products/{ImageId}";

        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(ImageUrl))
                {
                    return $"/images/noimage.jpg";
                }
                else
                {
                    return $"{ImageUrl.Substring(1)}";
                }
            } 
        }
    }
}
