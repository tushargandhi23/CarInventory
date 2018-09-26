using CarInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInventory.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private CarInventoryEntities entities = null;
        public UnitOfWork()
        {
            entities = new CarInventoryEntities();
        }

        //TODO: Can be improve by creating Generic UnitOfWork
        IRepository<UserModel> userRepository = null;
        IRepository<CarModel> carRepository = null;

        // Add all the repository getters here
        public IRepository<UserModel> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(entities);
                }
                return userRepository;
            }
        }
        public IRepository<CarModel> CarRepository
        {
            get
            {
                if (carRepository == null)
                {
                    carRepository = new CarRepository(entities);
                }
                return carRepository;
            }
        }

        public void SaveChanges()
        {
            entities.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    entities.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}