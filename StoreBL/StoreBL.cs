using System;
using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public class StoreBL : IStoreBL
    {

        private StoreDL.IRepository _repo;
        public StoreBL(StoreDL.IRepository p_repo)
        {
            _repo = p_repo;
        }
        public List<StoreFront> GetAllStoreFronts()
        {
            return _repo.getAllStoreFronts();
        }
    }
}