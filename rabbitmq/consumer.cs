  public void StartProcessV2()
        {

            string exchange = "xxxx";
            string rt = "xxxx";
            string queue = "xxxx";

            ConnectionFactory factory = new ConnectionFactory
            {
                HostName = "xxxxx",
                UserName = "xxxxxx",
                Password = "xxxxx",
                VirtualHost = "/",
            };
            using (IConnection connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(exchange: exchange, type: "topic", durable: true);
                    string queueName = channel.QueueDeclare(queue, true, false, false, null);
                    channel.QueueBind(queueName, exchange, rt);

                    LogWriter.WriteToFile("AGUARDANDO NOVAS MENSAGENS(SUBSCRIBER).");

                    QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);

                    channel.BasicConsume(queueName, true, consumer);

                    while (true)
                    {
                        BasicDeliverEventArgs e = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                        GetMessageQueue(e.Body);
                    }
                }
            }
        }
