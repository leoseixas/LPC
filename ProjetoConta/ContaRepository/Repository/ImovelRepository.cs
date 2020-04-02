using System.Collections.Generic;
using System.Linq;
using ContaDomain.Entities;
using ContaRepository.Data;
using ContaRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContaRepository.Repository
{
    public class ImovelRepository : IImovelRepository
    {
        private DataContext context;
        public ImovelRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Imovel imovel)
        {
            context.Imoveis.Add(imovel);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Imoveis.Remove(GetById(id));   
            context.SaveChanges();
        }

        public IEnumerable<Imovel> Getall()
        {
            return context.Imoveis.ToList().OrderBy(x=>x.id);
        }
        public Imovel GetById(int id)
        {
            return context.Imoveis.SingleOrDefault(x=>x.id ==id);
        }

        public void Update(Imovel imovel)
        {
            context.Entry(imovel).State= EntityState.Modified;
            context.SaveChanges();
        }


    }
}