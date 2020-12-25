
using NewSparper.Domain.Request.Category;
using NewSparper.Domain.Response.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewSparper.BAL.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Gets();
        Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request);

        Task<UpdateCategoryResult> UpdateCategory(UpdateCategoryRequest request);
        Task<DeleteCategoryResult> DeleteCategory(DeleteCategoryRequest request);
    }
}
