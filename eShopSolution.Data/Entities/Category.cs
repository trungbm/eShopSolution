using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int SortOder { get; set; }
        public bool IsShowOnHow { get; set; }
        public int? PrarentId { get; set; }
        public Status Status { get; set; }
       

    }
}
