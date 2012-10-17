using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public class InventoryMgr : ADatabaseInteractor
    {

        public IQueryable<inventory> getInventoryItems()
        {
            return from inv in Context.inventories
                       where inv.itryActive == true
                       select inv;
        }

        public IQueryable<inventory> getInventoryItems(int catID)
        {
            return from inv in Context.inventories
                   where inv.itryActive == true && inv.catID == catID
                   select inv;
        }

        /// <summary>
        /// Get items with name simity to parameter
        /// </summary>
        /// <param name="name">Item constains this string</param>
        /// <returns>List of names matching query</returns>
        public IQueryable<inventory> getItemWithNameLike(String name)
        {
            return from inv in Context.inventories
                   where inv.itryName.Contains(name)
                   select inv;
        }

        /// <summary>
        /// Get items with name simity to parameter
        /// </summary>
        /// <param name="name">Item constains this string</param>
        /// <param name="catID">Category to constraint search too</param>
        /// <returns>List of names matching query</returns>
        public IQueryable<inventory> getItemWithNameLike(String name, int catID)
        {
            return from inv in Context.inventories
                   where inv.itryName.Contains(name) && inv.catID == catID
                   select inv;
        }

        public IQueryable<inventory> getItemWithDescLike(String desc)
        {
            return from inv in Context.inventories
                   where inv.itryDesc.StartsWith(desc)
                   select inv;
        }

        public IQueryable<inventory> getItemWithDescLike(String desc, int catID)
        {
            return from inv in Context.inventories
                   where inv.itryDesc.StartsWith(desc) && inv.catID == catID
                   select inv;
        }

        public inventory getItemByID(int itryID, int catID = -1, bool showNonActive = false)
        {
            inventory item = null;
            IQueryable<Database.inventory> query;

            if(!showNonActive)
            {
                query = from inv in Context.inventories
                    where inv.itryID == itryID && inv.itryActive == true
                    select inv;
            }
            else
            {
                query = from inv in Context.inventories
                    where inv.itryID == itryID
                    select inv;
            }

            if (catID != -1)
            {
                query = from inv in query
                        where inv.catID == catID
                        select inv;
            }


            if(query.Count() > 0)
            {
                item = query.First();
            }

            return item;
        }

        public void insertNewItem(String name, String desc, decimal cost, int markup,
            decimal selling, int stock, int catID)
        {
            inventory item = new inventory();
            item.itryName = name;
            item.itryDesc = desc;
            item.itryCost = cost;
            item.itryMarkup = markup;
            item.itrySellingPrive = selling;
            item.itryStock = stock;
            item.catID = catID;
            item.itryActive = true;
            Context.AddToinventories(item);
            saveChanges();
        }

        public void updateItem(String name, String desc, decimal cost, int markup,
            decimal selling, int stock, int catID, inventory item)
        {
            item.catID = catID;
            item.itryName = name;
            item.itryDesc = desc;
            item.itryCost = cost;
            item.itryMarkup = markup;
            item.itrySellingPrive = selling;
            item.itryStock = stock;
            saveChanges();
        }

        public void softDeleteItem(int itryID)
        {
            getItemByID(itryID).itryActive = false;
            saveChanges();
        }

        public void softDeleteItem(inventory item)
        {
            item.itryActive = false;
            saveChanges();
        }

        public void deleteItem(int itryID)
        {
            inventory item = getItemByID(itryID);
            Context.inventories.DeleteObject(item);
            saveChanges();
        }

        public void deleteItem(inventory item)
        {
            Context.inventories.DeleteObject(item);
            saveChanges();
        }

        public int insertNewCategory(String catDesc)
        {
            category cat = new category();
            cat.catDesc = catDesc;
            Context.AddTocategories(cat);
            saveChanges();
            return cat.catID;
        }

        public void removeCategory(int catID)
        {
            // Need to remove the categories from items that may
            // be using it in the database
            var query = from itry in Context.inventories
                        where itry.catID == catID
                        select itry;
            foreach (var item in query)
            {
                item.catID = null;
            }

            // Now find the category and delete it
            var catQuery = from cat in Context.categories
                    where cat.catID == catID
                    select cat;

            if(catQuery.Count() > 0)
            {
                Context.categories.DeleteObject(catQuery.First());
            }
            saveChanges();
        }

        public IQueryable<category> getCategories()
        {
            return Context.categories;
        }
    }
}
