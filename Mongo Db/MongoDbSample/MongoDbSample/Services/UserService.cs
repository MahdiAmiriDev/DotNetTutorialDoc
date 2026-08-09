using MongoDB.Driver;
using MongoDbSample.Entites;
using MongoDbSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSample.Services
{
    internal class UserService
    {


        private readonly IMongoCollection<User> _user;
        internal UserService(MongoSettings mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var dataBase = client.GetDatabase(mongoSettings.DatabaseName);
            _user = dataBase.GetCollection<User>("Users");
        }

        public void Delete(Guid id)
        {
            _user.DeleteOne(f => f.Id == id);
        }

        public User Get(Guid id)
        {
            return _user.Find(f => f.Id == id).FirstOrDefault();
        }

        public List<User> GetAll() => _user.Find(_ => true).ToList();

        public void Insert(User user)
        {
            _user.InsertOne(user);
        }

        public void Update(User user)
        {
            _user.ReplaceOne(f => f.Id == user.Id, user);
        }
    }
}
