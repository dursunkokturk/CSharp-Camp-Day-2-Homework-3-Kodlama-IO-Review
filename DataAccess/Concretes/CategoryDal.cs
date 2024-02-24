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
        category1.Id = 1;
        category1.CategoryName = "Java";

        Category category2 = new Category();
        category2.Id = 2;
        category2.CategoryName = "Python";

        Category category3 = new Category();
        category3.Id = 3;
        category3.CategoryName = "Programlama";

        categories = new List<Category> { category1, category2, category3 };
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category category)
    {
        categories.Remove(category);
    }
}