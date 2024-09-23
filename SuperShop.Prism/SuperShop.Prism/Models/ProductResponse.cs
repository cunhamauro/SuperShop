using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace SuperShop.Prism.Models
{
    public class ProductResponse
    {
        private string Url = @"https://dp6s0q71-44396.uks1.devtunnels.ms";

        public int Id {  get; set; }

        public string Name { get; set; }

        public float Price {  get; set; }

        public string ImageUrl { get; set; }

        public object LastPurchase {  get; set; }

        public object LastSale { get; set; }

        public bool IsAvailable {  get; set; }

        public float Stock {  get; set; }
        public UserResponse User { get; set; }

        public string ImageFullPath
        {
            get
            {
                // TODO meter a ir buscar o URL
                if (string.IsNullOrEmpty(ImageUrl))
                {
                    return $"{Url}/images/noimage.jpg";
                }
                else
                {
                    return $"{Url}{ImageUrl.Substring(1)}";
                }
            }
        }
    }
}
