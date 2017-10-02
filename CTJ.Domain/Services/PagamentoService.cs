using System;
using CTJ.Domain.Entities;
using CTJ.Domain.Interfaces.Repositories;
using CTJ.Domain.Interfaces.Services;

namespace CTJ.Domain.Services
{
	public class PagamentoService : ServiceBase<Pagamento>, IPagamentoService
	{
		private readonly IPagamentoRepository _pagamentoRepository;

		public PagamentoService(IPagamentoRepository pagamentoRepository)
			: base(pagamentoRepository)
		{
			_pagamentoRepository = pagamentoRepository;
		}
	}
}
