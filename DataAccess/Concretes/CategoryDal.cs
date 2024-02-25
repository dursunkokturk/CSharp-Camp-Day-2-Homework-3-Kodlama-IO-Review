using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CategoryDal:ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        Category category1 = new Category();
        category1.CategoryId = 1;
        category1.CategoryName = "Java";

        Category category2 = new Category();
        category2.CategoryId = 2;
        category2.CategoryName = "Python";

        Category category3 = new Category();
        category3.CategoryId = 3;
        category3.CategoryName = "Programlama";

        categories = new List<Category> { category1, category2, category3 };
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void AddCategory(Category category)
    {
        categories.Add(category);
    }

    public void UpdateCategory(Category category)
    {
        Course updatedCategory = category.FirstOrDefault(ctg => ctg.CategoryId == category.CategoryId);
        updatedCategory.CategoryName = category.CategoryName;
        updatedCategory.CourseDescription = category.CourseDescription;
    }

    public void DeleteCategory(Category category)
    {
        categories.Remove(category);
    }
}