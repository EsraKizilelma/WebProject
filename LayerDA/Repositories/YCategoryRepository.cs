﻿using LayerDA.Abstract;
using LayerDA.Concrate;
using LayerE.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDA.Repositories
{
    public class YCategoryRepository : IYCategoryDal
    {
        Context c= new Context();
        public void CategoryAdd(YCategory category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void CategoryDelete(YCategory category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public List<YCategory> CategoryListAll()
        {
            return c.YCategories.ToList();
        }

        public void CategoryUpdate(YCategory category)
        {
            c.Update(category);
            c.SaveChanges();
        }

        public void Delete(YCategory t)
        {
            throw new NotImplementedException();
        }

        public List<YCategory> GetAllList()
        {
            throw new NotImplementedException();
        }

        public YCategory GetById(int id)
        {
            return c.YCategories.Find(id);
        }

        public void Insert(YCategory t)
        {
            throw new NotImplementedException();
        }

        public void Update(YCategory t)
        {
            throw new NotImplementedException();
        }
    }
}
