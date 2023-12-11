# RabbitMQ
Sending and receiving messages using RabbitMQ C#

## prerequisites
 - RabbitMQ requires Erlang to be installed on your machine. You can download it from the official Erlang website
 - Download and Install RabbitMQ
   
Open a command prompt and navigate to the RabbitMQ sbin directory.
Run the following command to enable the management plugin:
```cmd
rabbitmq-plugins enable rabbitmq_management
```
## start the service
![Image Alt Text](/Images/2023-12-11%2014_40_23-Sender%20-%20Microsoft%20Visual%20Studio.png)
In windows type rabbitMQ and click to start the service

Go to the browser and http://localhost:15672

In Visual studio 2022, install nuget packet: rabbitmq.client

## Project
This solution conatins two projects:
- Sender project, which is web api two two enpoints, one post to send message and get to get to read all the message in the queue
- Receiver project, which reads the messages from the queue

Run both the projects, the sender project looks like this:
![Image Alt Text](/Images/2023-12-11%2014_42_16-Swagger%20UI.png)

Send a sample message using api
![Image Alt Text](/Images/2023-12-11%2014_42_49-.png)

It appear in the RabbitMQ management
![Image Alt Text](/Images/2023-12-11%2014_43_20-RabbitMQ%20Management.png)

call Get endpoint to see the messages
![Image Alt Text](/Images/2023-12-11%2014_43_36-Swagger%20UI.png)
