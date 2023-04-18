﻿using Booking.Model;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Booking.Domain.RepositoryInterfaces
{
	public interface ITourRepository : IRepository<Tour>
	{
		int NextId();
		Tour Add(Tour tour);
		void Delete(Tour tour);
		Tour GetByName(string name);
		Tour Update(Tour tour);
		List<Tour> GetValidTours();
	}
}
