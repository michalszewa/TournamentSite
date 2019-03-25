using System.Collections.Generic;
namespace TurniejMaxow.Models
{
    public static class Repository
    {
        private static List<FormResponse> responses = new List<FormResponse>();
        public static IEnumerable<FormResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(FormResponse response)
        {
            responses.Add(response);
        }
    }
}