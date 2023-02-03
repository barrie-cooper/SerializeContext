using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Moq;
using System.Text.Json;

try
{
    Console.WriteLine();
    Console.WriteLine("Enter to test HubCallerContext serialize");
    Console.ReadLine();
    var context = new Mock<HubCallerContext>().Object;
    JsonSerializer.Serialize(context);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

try
{
    Console.WriteLine();
    Console.WriteLine("Enter to test HttpContext serialize");
    Console.ReadLine();
    var context = new Mock<HttpContext>().Object;
    JsonSerializer.Serialize(context);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
