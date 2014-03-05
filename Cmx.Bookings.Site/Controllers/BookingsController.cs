using System;
using System.Linq;
using System.Web.Http;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Cmx.Bookings.DataAccess;
using Cmx.Bookings.Entities;
using Newtonsoft.Json.Linq;

namespace Cmx.Bookings.Site.Controllers
{
    [BreezeController]
    public class BookingsController : ApiController
    {
        private readonly EFContextProvider<BookingsContext> _contextProvider;

        public BookingsController()
            : this(new EFContextProvider<BookingsContext>("BookingsDatabase"))
        {
        }

        public BookingsController(EFContextProvider<BookingsContext> contextProvider)
        {
            if (contextProvider == null) throw new ArgumentNullException("contextProvider");
            _contextProvider = contextProvider;
        }

        [HttpGet]
        public String Metadata()
        {
            return _contextProvider.Metadata();
        }
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<Customer> Accounts()
        {
            return _contextProvider.Context.Customers;
        }

    }
}