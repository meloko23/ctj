using System.Collections.Generic;
using CTJ.Domain.Entities;

namespace CTJ.Domain.Interfaces.Services
{
	public interface IServiceBase<TEntity> where TEntity : EntityBase
	{
		void Add(TEntity e);
		TEntity GetById(int id);
		IEnumerable<TEntity> GetAll();
		void Update(TEntity e);
		void Remove(TEntity e);
		void Dispose();
	}
}
