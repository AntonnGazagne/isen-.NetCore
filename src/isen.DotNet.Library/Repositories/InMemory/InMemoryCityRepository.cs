using System;
using System.Collections.Generic;
using System.Linq;
using isen.DotNet.Library.Models;

namespace isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryCityRepository
    {
        private List<City> _modelCollection;
        public IQueryable<City> ModelCollection
        {
            get
            {
                if(_modelCollection != null) return _modelCollection.AsQueryable();
                _modelCollection = new List<City>()
                {
                    new City() { Id = 1, Name = "Toulon", ZipCode = "83000"},
                    new City() { Id = 2, Name = "Marseille", ZipCode = "13000"},
                    new City() { Id = 3, Name = "Nice", ZipCode = "06000"},
                    new City() { Id = 4, Name = "Paris", ZipCode = "75000"},
                    new City() { Id = 5, Name = "Lyon", ZipCode = "69000"},
                };
                return _modelCollection.AsQueryable();
            }
        }

        public City Single(int id)=>
            ModelCollection.SingleOrDefault(c => c.Id == id);//Lambda expression
        public City Single(string name)=>
            ModelCollection.FirstOrDefault(c => c.Name.Equals(name));//Lambda expression
    }
}