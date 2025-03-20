using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P127
{
    internal class NewConsumables
    {
        public string? item_name;

        public NewConsumables(string item_name)
        {
            this.item_name = item_name;
        }

        // Add Consumable
        public static bool AddConsumable(string item_name)
        {
            string query = $"INSERT INTO consumables (item_name) VALUES ('{item_name}')";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Update Consumable
        public static bool UpdateConsumable(int consumable_id, string item_name)
        {
            string query = $"UPDATE consumables SET item_name = '{item_name}' WHERE consumable_id = {consumable_id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Delete Consumable
        public static bool DeleteConsumable(int consumable_id)
        {
            string query = $"DELETE FROM consumables WHERE consumable_id = {consumable_id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }
    }
}
