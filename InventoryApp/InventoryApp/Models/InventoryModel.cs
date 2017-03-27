using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryApp.Models
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
        public DateTime CreatedDate { get; set; }

        public InventoryRepository.InventoryRepository.InventoryModel ToRepositoryModel()
        {
            var repositoryModel = new InventoryRepository.InventoryRepository.InventoryModel
            {
                Name = Name,
                CreatedDate = CreatedDate,
                Price = Price,
                Qty = Qty,
                Id = Id,
                Description = Description,
                System = System,
                Contract = Contract,
            };

            return repositoryModel;
        }

        public static InventoryModel ToModel(InventoryRepository.InventoryRepository.InventoryModel respositoryModel)
        {
            var inventoryModel = new InventoryModel
            {
                Name = respositoryModel.Name,
                CreatedDate = respositoryModel.CreatedDate,
                Price = respositoryModel.Price,
                Qty = respositoryModel.Qty,
                Id = respositoryModel.Id,
                Description = respositoryModel.Description,
                System = respositoryModel.System,
                Contract = respositoryModel.Contract,

            };

            return inventoryModel;
        }
    }
}


