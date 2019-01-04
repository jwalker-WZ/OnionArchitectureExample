using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Bookshelf;
using Domain.Inventory;
using Domain.Inventory.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace HomeServer.Controllers
{
    /*
     * Here are all the controller classes for the different types. Due to
     * the generics most of the functionality is shared and as I don't have
     * more functionality than the basics for this example I've placed them
     * all in the same file. In most cases each class would be in it's own
     * file.
     */
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : HomeServerBaseController<Book>
    {
        public BookController(IService<Book> service) : base(service)
        {
        }
    }

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuoteController : HomeServerBaseController<Quote>
    {
        public QuoteController(IService<Quote> service) : base(service)
        {
        }
    }

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemColorController : HomeServerBaseController<ItemColor>
    {
        public ItemColorController(IService<ItemColor> service) : base(service)
        {

        }
    }

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemTypeController : HomeServerBaseController<ItemType>
    {
        public ItemTypeController(IService<ItemType> service) : base(service)
        {

        }
    }

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventoryController : HomeServerBaseController<InventoryItem>
    {
        public InventoryController(IService<InventoryItem> service) : base(service)
        {

        }
    }
}