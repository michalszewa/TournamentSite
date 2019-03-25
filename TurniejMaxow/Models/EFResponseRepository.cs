using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurniejMaxow.Models
{
    public class EFResponseRepository : IResponsesRepository
    {
        private ApplicationDbContext context;
        public EFResponseRepository(ApplicationDbContext ctx) => context = ctx;
        public IQueryable<FormResponse> Responses => context.Responses;

        public void Add(FormResponse respon)
        {
            context.Responses.Add(respon);
            context.SaveChanges();
        }
    }
}
