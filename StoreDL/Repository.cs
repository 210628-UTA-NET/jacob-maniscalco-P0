using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace StoreDL 

{
    public class Repository : IRepository
    {

        private const string _filePath = "./../StoreDL/Database/StoreFront.json";
        private string _jsonString;

        public List<StoreModels.StoreFront> getAllStoreFronts()
        { 
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            } 
            catch(System.Exception)
            {
                throw new Exception("File path is not valid.");
            }
            
            return JsonSerializer.Deserialize<List<StoreModels.StoreFront>>(_jsonString);
         }
        public StoreModels.StoreFront getAStoreFront(StoreModels.StoreFront store)
        { throw new System.NotImplementedException(); }

        // Think about changing this to return a boolean instead, which can act as a flag for success
        public Boolean addAStoreFront(StoreModels.StoreFront store)
        {
            Boolean success = false;
            List<StoreModels.StoreFront> stores = this.getAllStoreFronts();
            stores.Add(store);

            _jsonString = JsonSerializer.Serialize(stores, new JsonSerializerOptions {WriteIndented = true});
            
            try {
                File.WriteAllText(_filePath, _jsonString);
                success = true;
            }
            catch(System.Exception)
            {
                Console.WriteLine("Error while writing to json file.");
            }
           
            return success;
         }
    }
}