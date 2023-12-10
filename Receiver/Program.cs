using Receiver;

var queueName = "orders";
var consumer = new RabbitMQConsumer(queueName);
consumer.StartConsuming();