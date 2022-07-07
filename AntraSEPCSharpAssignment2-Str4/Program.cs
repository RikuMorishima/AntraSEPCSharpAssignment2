// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string input = "https://www.apple.com/iphone";
string[] protocolVsOthers = input.Split("://");
string others;
string protocol;
if (protocolVsOthers.Length == 1)
{
    protocol = "";
    others = protocolVsOthers[0];
} else
{
    protocol = protocolVsOthers[0];
    others = protocolVsOthers[1];
}

string[] serverVsResource = others.Split("/");
string server = serverVsResource[0];
StringBuilder resource = new StringBuilder();
for (int i = 1; i < serverVsResource.Length; i++)
{
    resource.Append(serverVsResource[i]);
    if (i != 1)
        resource.Append("/");
}

Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource.ToString()}\"");

