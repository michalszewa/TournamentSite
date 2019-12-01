using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurniejMaxow.Models
{
    public interface IResponsesRepository
    {
        IQueryable<FormResponse> Responses { get; }
        void Add(FormResponse respon);
    }
}
