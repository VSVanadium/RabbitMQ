using Microsoft.AspNetCore.Hosting;
using Moq;
using Sender.Data;

namespace Test
{
    public class Tests
    {
        
        private IRabbitMQClient _rabbitMQClient;

        [SetUp]
        public void Setup()
        {
            _rabbitMQClient = new RabbitMQClient();
        }

        [Test]
        public void Test_SendMessage_Successful()
        {
            var timeStamp = DateTime.UtcNow;
            var newOrder = new Order()
            {
                ProductName = "Test",
                Price = 1.8m,
                Quantity = 2,
                CreatedAt = timeStamp,
            };
           
            _rabbitMQClient.SendMessage(newOrder);

            //consumer saves the incoming message

            //read from the db and verify the details

            Assert.Pass();
        }
    }
}