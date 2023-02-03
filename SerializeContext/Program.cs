using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Moq;

try
{
    var context = new Mock<HttpContext>().Object;
    JsonSerializer.Serialize(context);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

Console.ReadLine();

try
{
    var context = new Mock<HubCallerContext>().Object;
    JsonSerializer.Serialize(context);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
