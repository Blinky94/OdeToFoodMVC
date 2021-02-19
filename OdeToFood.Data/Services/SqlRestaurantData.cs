using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;
        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }

        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges(); // Commit
        }

        public void Delete(int id)
        {
            // Pour éviter la concurrence si quelqu'un essai de modifier en même temps la même donnée
            var restaurant = db.Restaurants.Find(id);
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Deleted;
            // Commit
            db.SaveChanges();
            
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return db.Restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant restaurant)
        {
            // Pour éviter la concurrence si quelqu'un essai de modifier en même temps la même donnée
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            // Commit
            db.SaveChanges();
        }
    }
}
