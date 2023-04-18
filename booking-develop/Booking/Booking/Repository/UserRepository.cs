﻿using Booking.Domain.RepositoryInterfaces;
using Booking.Model;
using Booking.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Repository
{
	public class UserRepository : IUserRepository
	{
		private const string FilePath = "../../Resources/Data/users.csv";

		private readonly Serializer<User> _serializer;

		private List<User> _users;

		public UserRepository()
		{
			_serializer = new Serializer<User>();
			_users = _serializer.FromCSV(FilePath);
		}
        public List<User> GetAll()
        {
            return _serializer.FromCSV(FilePath);
        }

		public User GetById(int id)
		{
			return _users.Find(u => u.Id == id);
		}

		public User GetByUsername(string username)
		{
			_users = _serializer.FromCSV(FilePath);
			return _users.FirstOrDefault(u => u.Username == username);
		}

        public void Save(List<User> users) // save kao u tourRepository?
        {
            _serializer.ToCSV(FilePath, users);
        }
    }
}
