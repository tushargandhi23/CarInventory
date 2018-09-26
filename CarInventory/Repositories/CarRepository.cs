using AutoMapper;
using CarInventory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarInventory.Repositories
{
    public class CarRepository: IRepository<CarModel>
    {
        private CarInventoryEntities entities;

        public CarRepository(CarInventoryEntities entities)
        {
            this.entities = entities;
        }

        public void Add(CarModel model)
        {
            var entity = Mapper.Map<tbl_cars>(model);
            entities.Entry(entity).State = EntityState.Added;

        }

        public CarModel Edit(CarModel model)
        {
            var entity = Mapper.Map<tbl_cars>(model);
            entities.Entry(entity).State = EntityState.Modified;
            return model;
        }

        public CarModel Get(int id)
        {
           return GetAll().Where(m => m.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<CarModel> GetAll()
        {
            return Mapper.Map<IList<CarModel>>(entities.tbl_cars.ToList());
        }

        public void Remove(CarModel model)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            entities.SaveChanges();
        }
    }
}