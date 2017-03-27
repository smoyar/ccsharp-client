using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDB;

namespace InventoryRepository
{
    public class InventoryRepository
    {
        public class InventoryModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string System { get; set; }
            public decimal Price { get; set; }
            public int Qty { get; set; }
            public string Contract { get; set; }
            public string Description { get; set; }
            public System.DateTime CreatedDate { get; set; }

        }
        public InventoryModel Add(InventoryModel inventoryModel)
        {
            var inventoryDb = ToDbModel(inventoryModel);

            DataBaseManager.Instance.Items.Add(inventoryDb);
            DataBaseManager.Instance.SaveChanges();

            inventoryModel = new InventoryModel
            {
                Id = inventoryDb.ItemId ,
                Name = inventoryDb.ItemName,
                System = inventoryDb.ItemSystem,
                Price = inventoryDb.ItemPrice,
                Qty = inventoryDb.ItemQty,
                Contract = inventoryDb.ItemContract,
                Description = inventoryDb.ItemDescription,
                CreatedDate = inventoryDb.ItemCreatedDate ,

            };
            return inventoryModel;
        }
        public List<InventoryModel> GetAll()
        {
            // Use .Select() to map the database contacts to ContactModel
            var items = DataBaseManager.Instance.Items
              .Select(t => new InventoryModel
              {
                  Id = t.ItemId,
                  Name = t.ItemName,
                  System = t.ItemSystem,
                  Price = t.ItemPrice,
                  Qty = t.ItemQty,
                  Contract = t.ItemContract,
                  Description = t.ItemDescription,
                  CreatedDate = t.ItemCreatedDate,
              }).ToList();

            return items;
        }

        public bool Update(InventoryModel inventoryModel)
        {
            var original = DataBaseManager.Instance.Items.Find(inventoryModel.Id);

            if (original != null)
            {
                DataBaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(inventoryModel));
                DataBaseManager.Instance.SaveChanges();
            }

            return false;
        }

        public bool Remove(int itemId)
        {
            var items = DataBaseManager.Instance.Items
                                .Where(t => t.ItemId == itemId);

            if (items.Count() == 0)
            {
                return false;
            }

            DataBaseManager.Instance.Items.Remove(items.First());
            DataBaseManager.Instance.SaveChanges();

            return true;
        }

        private Item ToDbModel(InventoryModel inventoryModel)
        {
            var inventoryDb = new Item
            {
                ItemName = inventoryModel.Name,
                ItemPrice = inventoryModel.Price,
                ItemContract = inventoryModel.Contract,
                ItemCreatedDate = inventoryModel.CreatedDate,
                ItemDescription = inventoryModel.Description,
                ItemId = inventoryModel.Id,
                ItemQty = inventoryModel.Qty,
                ItemSystem = inventoryModel.System              
            };
            return inventoryDb;
        }
    }
}
