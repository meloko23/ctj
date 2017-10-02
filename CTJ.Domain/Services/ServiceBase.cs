using System;
using System.Collections.Generic;
using CTJ.Domain.Entities;
using CTJ.Domain.Interfaces.Repositories;
using CTJ.Domain.Interfaces.Services;

namespace CTJ.Domain.Services
{
	public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : EntityBase
	{
		private readonly IRepositoryBase<TEntity> _repository;

		public ServiceBase(IRepositoryBase<TEntity> repository)
		{
			_repository = repository;
		}

		public void Add(TEntity e)
		{
			_repository.Add(e);
		}

		public TEntity GetById(int id)
		{
			return _repository.GetById(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _repository.GetAll();
		}

		public void Update(TEntity e)
		{
			_repository.Update(e);
		}

		public void Remove(TEntity e)
		{
			_repository.Remove(e);
		}

		public void Dispose()
		{
			_repository.Dispose();
		}
	}
}
