using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P127
{
    internal class NewRoom
    {
        public string? room_name;
        public string? room_type;
        public int capacity;

        public NewRoom(string room_name, string room_type, int capacity)
        {
            this.room_name = room_name;
            this.room_type = room_type;
            this.capacity = capacity;
        }

        //  Add Room
        public static bool AddRoom(string room_name, string room_type, int capacity)
        {
            string query = $"INSERT INTO rooms (room_name, room_type, capacity) VALUES ('{room_name}', '{room_type}', {capacity})";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        //  Update Room
        public static bool UpdateRoom(int room_id, string room_name, string room_type, int capacity)
        {
            string query = $"UPDATE rooms SET room_name = '{room_name}', room_type = '{room_type}', capacity = {capacity} WHERE room_id = {room_id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        //  Delete Room
        public static bool DeleteRoom(int room_id)
        {
            string query = $"DELETE FROM rooms WHERE room_id = {room_id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }
    }
}
