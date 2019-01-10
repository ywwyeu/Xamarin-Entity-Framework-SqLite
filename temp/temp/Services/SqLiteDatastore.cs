using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using temp.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace temp.Services
{
    public class SqLiteDataStore : IDataStore<Item>
    {


        //TODO : Fill in the string to the 'TestSqLite.db' database in the temp folder
        //for example  
        //public string dbFolder = "C:\\Users\\....\\Source\\repos\\temp\\temp\\temp\\";
        public string dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public string fileName = "TestSqLite.db";

        public SqLiteDataStore()
        {

        }


        public async Task<bool> AddItemAsync(Item item)
        {

            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {

            try
            {
                using (var db = new Models.MyContext(Path.Combine(dbFolder, fileName)))
                {

                    List<Item> list1 = new List<Item>();

                    list1 = await db.Item.ToListAsync();
                    return list1;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
