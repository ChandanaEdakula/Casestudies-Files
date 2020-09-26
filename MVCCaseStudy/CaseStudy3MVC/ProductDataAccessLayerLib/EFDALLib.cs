using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAccessLayerLib
{
    public class EFDALLib
    {
        public List<tbl_category> GetAllCategories()
        {
            CDBEntities dbctx = new CDBEntities();
            var result = dbctx.tbl_category.ToList();
            return result;
        }
        public List<tbl_product> GetAllProducts()
        {
            CDBEntities dbctx = new CDBEntities();
            var result = dbctx.tbl_product.ToList();
            return result;
        }
        public void AddProducts(tbl_product pro)
        {
            CDBEntities dbctx = new CDBEntities();
            dbctx.tbl_product.Add(pro);
            dbctx.SaveChanges();
        }
        public List<string> GetAllCategoryById()
        {
            CDBEntities db = new CDBEntities();
            var result= db.tbl_category.Select(o => o.cid).ToList();
            return result;
        }
        public string ViewCategoryNane(string cid)
        {
            CDBEntities dal = new CDBEntities();
            var record = dal.tbl_category.Where(o => o.cid == cid).Select(o => o.cname).SingleOrDefault();
            return record;
        }
        public tbl_product ViewProduct(int ID)
        {
            CDBEntities dal = new CDBEntities();
            var rec = dal.tbl_product.Where(p => p.pid == ID).SingleOrDefault();
            return rec;
        }
       
    }
}
