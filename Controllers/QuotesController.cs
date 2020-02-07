using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotesApi.Controllers{
    public class QuotesController : ApiController{
        List<Models.Quote> QuoteList = new List<Models.Quote>() {
           new Models.Quote() {Id=0,Title="Musk Quote",Author="Elon Musk", Description="If you want to be successfull work like there is no tommorow"},
           new Models.Quote() {Id=1,Title="Newton Quote",Author="Isaac Newton", Description="When one body exerts a force on a second body, the second body simultaneously exerts a force equal in magnitude and opposite in direction on the first body."},
           new Models.Quote() {Id=2,Title="Philips Quote",Author="Emo Philips", Description="A computer once beat me at chess, but it was no match for me at kick boxing."},
           new Models.Quote() {Id=3,Title="Turing Quote",Author="Alan Turing", Description="Those who can imagine anything, can create the impossible."},
        };

        public IEnumerable<Models.Quote> Get(){
            return QuoteList;
        }

        public void Post([FromBody]Models.Quote quote){
            QuoteList.Add(quote);
        }
        public void Put(int Id, [FromBody]Models.Quote quote)
        {
            QuoteList[Id]=quote;
        }

    }
}
