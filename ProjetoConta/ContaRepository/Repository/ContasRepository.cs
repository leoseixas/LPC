using System.Collections.Generic;
using System.Linq;
using ContaDomain.Entities;
using ContaRepository.Data;
using ContaRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContaRepository.Repository
{
    public class ContasRepository : IContaRepository
    {
        private DataContext context;
        public ContasRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(ContaLuz conta)
        {
            context.ContasLuz.Add(conta);
            context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            context.ContasLuz.Remove(GetById(id));
            context.SaveChanges();
        }

        public IEnumerable<ContaLuz> Getall()
        {
            return context.ContasLuz.Include(x=>x.imovel).ToList();
        }

        public ContaLuz GetById(int id)
        {
            return context.ContasLuz.Include(x=>x.imovel).SingleOrDefault(x=>x.id==id);
        }

        public ContaLuz GetMaiorConsumo()
        {
            var maiorConsumo = Getall();
            if(maiorConsumo.Any()) 
            {
                return maiorConsumo.OrderBy(x => x.KwGasto).Last();
            }
            return null;
        }

        public ContaLuz GetMenorConsumo()
        {
            var menorConsumo = Getall();
            if(menorConsumo.Any())
            {
                return menorConsumo.OrderBy(x => x.KwGasto).First();
            }
            return null;
        }

        public void Update(ContaLuz conta)
        {
            context.Entry(conta).State= EntityState.Modified;
            
            
            context.SaveChanges();
        }
    }
}