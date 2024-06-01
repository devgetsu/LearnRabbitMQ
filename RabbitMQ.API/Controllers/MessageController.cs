using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitMQ.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IModel _channel;

        public MessageController(IModel channel)
        {
            _channel = channel;
        }

        [HttpPost("publish")]
        public IActionResult Publish([FromBody] string message)
        {
            var body = Encoding.UTF8.GetBytes(message);

            _channel.BasicPublish(
                exchange: "",
                routingKey: "MyQueue",
                basicProperties: null,
                body: body);

            return Ok(new { status = "Message published" });
        }

        [HttpGet("consume")]
        public IActionResult Consume()
        {
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($"Received message: {message}");
            };

            _channel.BasicConsume(queue: "MyQueue", autoAck: true, consumer: consumer);

            return Ok(new { status = "Started consuming messages" });
        }
    }
}
