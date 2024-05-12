using _01_02_Decorator;
using System.Net;

WebClient webClient = new WebClient();
WebClientDecorator webClientDecorator = new WebClientDecorator(webClient);


string result = webClientDecorator.DownloadString("https://toplearn.com");
string result2 = webClientDecorator.DownloadString("https://barnamenevisan.info");


Console.ReadLine();