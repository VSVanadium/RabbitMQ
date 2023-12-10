namespace Sender.Data
{
    public interface IRabbitMQClient
    {
        void SendMessage(Object message);
    }
}
