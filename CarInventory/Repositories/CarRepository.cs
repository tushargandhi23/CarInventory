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

        /// <summary>
        /// Function to add car
        /// </summary>
        /// <param name="model"></param>
        public void Add(CarModel model)
        {
            var entity = Mapper.Map<tbl_cars>(model);
            entities.Entry(entity).State = EntityState.Added;

        }

        /// <summary>
        /// Function to edit car
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public CarModel Edit(CarModel model)
        {
            var entity = Mapper.Map<tbl_cars>(model);
            entities.Entry(entity).State = EntityState.Modified;
            return model;
        }

        /// <summary>
        /// Function to get car by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CarModel Get(int id)
        {
           return GetAll().Where(m => m.Id.Equals(id)).FirstOrDefault();
        }

        /// <summary>
        /// Function to get all cars
        /// </summary>
        /// <returns></returns>
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