using MCCAppsAPI.Context;
using MCCAppsAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MCCAppsAPI.Controllers
{
    public class SuppliersController : ApiController
    {
        MyContext myContext = new MyContext();

        [HttpGet]
        public Supplier Get(int id)
        {
            return myContext.Suppliers.Find(id);
            //return myContext.Suppliers.where(x => x.Id.Equals(id) && x.Name.Equals("Naufal")).SingleOrDefault();
            //return myContext.Suppliers.SingleOrDefault(x => x.Id.Equals(id) && x.Name.Equals("Naufal"))
        }

        [HttpGet]
        public List<Supplier> Get()
        {
            return myContext.Suppliers.ToList();
        }

        [HttpPost]
        public bool Post(Supplier supplier)
        {
            if (supplier.Equals(null))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(supplier.Id.ToString()) || string.IsNullOrWhiteSpace(supplier.Name))
            {
                return false;
            }
            else
            {
                myContext.Suppliers.Add(supplier);
                var result = myContext.SaveChanges();
                return result > 0;
            }
        }

        [HttpPut]
        public bool Put(Supplier supplier)
        {
            if (supplier.Equals(null))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(supplier.Id.ToString()) || string.IsNullOrWhiteSpace(supplier.Name))
            {
                return false;
            }
            else
            {
                myContext.Entry(supplier).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return result > 0;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            Supplier supplier = myContext.Suppliers.Find(id);
            if (supplier.Equals(null))
            {
                return false;
            }
            else
            {
                myContext.Suppliers.Remove(supplier);
                var result = myContext.SaveChanges();
                return result > 0;
            }
        }
    }
}
