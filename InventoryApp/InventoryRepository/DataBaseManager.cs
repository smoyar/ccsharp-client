using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDB;

namespace InventoryRepository
{
    class DataBaseManager
    {
        private static readonly InventoryEntities entities;

        //Initialize and open the database connection
        static DataBaseManager()
        {
            entities = new InventoryEntities();
            entities.Database.Connection.Open();
        }

        //Provides and accessor to the database
        public static InventoryEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
