using AutoMapper;
using CarInventory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CarInventory.Repositories
{
    public class UserRepository : IRepository<UserModel>
    {
        private CarInventoryEntities entities;

        public UserRepository(CarInventoryEntities entities)
        {
            this.entities = entities;
        }

        /// <summary>
        /// Function to create new User
        /// </summary>
        /// <param name="model"></param>
        public void Add(UserModel model)
        {
            var entity = Mapper.Map<tbl_users>(model);
            entities.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Function to edit User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserModel Edit(UserModel model)
        {
            var entity = Mapper.Map<tbl_users>(model);
            entities.Entry(entity).State = EntityState.Modified;
            return model;
        }

        /// <summary>
        /// Function to delete User
        /// </summary>
        /// <param name="model"></param>
        public void Remove(UserModel model)
        {
            var entity = Mapper.Map<tbl_users>(model);
            entities.Entry(entity).State = EntityState.Modified;
        }

        public UserModel Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Function to get all users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserModel> GetAll()
        {
            return Mapper.Map<IList<UserModel>>(entities.tbl_users.ToList());
        }

        internal void SaveChanges()
        {
            entities.SaveChanges();
        }

    }
}