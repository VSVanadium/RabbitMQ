using RabbitMQ.Client;
using System.Text;

namespace Sender.Data
{
    public class RabbitMQClient: IRabbitMQClient
    {

        public IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.UserName = "guest";
            factory.Password = "guest";
            factory.Port = 5672;
            factory.HostName = "localhost";
            factory.VirtualHost = "/";
            return factory.CreateConnection();
        }

        public void SendMessage(Object message)
        {
            try
            {
                IModel channel = GetConnection().CreateModel();

                //declare exchange
                channel.ExchangeDeclare("messageexchange", ExchangeType.Direct);

                //decalre queue
                channel.QueueDeclare("orders", true, false, false, null);

                //bind queue to exchange
                channel.QueueBind("orders", "messageexchange", "orders", null);

                var msg = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(message));

                //publish
                channel.BasicPublish("messageexchange", "orders", null, msg);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }
    }
}
