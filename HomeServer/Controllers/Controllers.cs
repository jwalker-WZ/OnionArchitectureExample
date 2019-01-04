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