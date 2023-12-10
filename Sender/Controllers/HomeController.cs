using Microsoft.AspNetCore.Mvc;
using Sender.Data;

namespace Sender.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {

        private readonly IRabbitMQClient _messagePublisher;

        public MessageController(IRabbitMQClient messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            _messagePublisher.SendMessage(order);

            using (var context = new ApplicationDbContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }

            return Ok("Message sent");
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            using (var context = new ApplicationDbContext())
            {
                return Ok(context.Orders.ToList());
            }
        }

    }
}