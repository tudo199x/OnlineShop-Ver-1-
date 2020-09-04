using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel
    {
        private OnlineShopDbContext context = null;
        public CategoryModel()
        {
            context = new OnlineShopDbContext();
        }
        public List<Category> LissAll()
        {
            var liss = context.Database.SqlQuery<Category>("Sp_Category_LissAll").ToList();
            return liss;
        }
    }
}
