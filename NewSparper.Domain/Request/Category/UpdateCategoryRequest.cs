using System;
using System.Collections.Generic;
using System.Text;

namespace NewSparper.Domain.Request.Category
{
   public class UpdateCategoryRequest
    {
        public int CategoryId { set; get; }
        public string CategoryName { get; set; }
    }
}
