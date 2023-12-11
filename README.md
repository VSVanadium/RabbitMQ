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
Go to the browser and http://localhost:15672
In Visual studio 2022, install nuget packet: rabbitmq.client

## Project
This solution conatins two projects:
- Sender project, which is web api two two enpoints, one post to send message and get to get to read all the message in the queue
- Receiver project, which reads the messages from the queue

  Run both the projects
  ![Image Alt Text](images/2023-12-11 14_40_23-Sender - Microsoft Visual Studio.png)
