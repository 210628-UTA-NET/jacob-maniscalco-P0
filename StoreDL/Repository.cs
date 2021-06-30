using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using StoreModels;
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

        public StoreModels.StoreFront addAStoreFront(StoreModels.StoreFront store)
        { throw new System.NotImplementedException(); }
    }
}