using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Getteway
{
	public class ProductGetteway
	{
		AplicationDbContext db = new AplicationDbContext();

		public bool Add(Product product)
		{
			db.Products.Add(product);

			int rowAdd = db.SaveChanges();

			if (rowAdd > 0) return true;

			return false;
		}
	}
}
