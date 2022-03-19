﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using RestSharp;

var sw = new Stopwatch();

sw.Start();
var client = new RestClient();
var request = new RestRequest("https://localhost:7023/WeatherForecast");
var response = await client.GetAsync(request);

System.Console.WriteLine(response.Content);
sw.Stop();
System.Console.WriteLine($"RestSharp used {sw.ElapsedMilliseconds} ms!!");

sw.Reset();
sw.Start();

var client1 = new HttpClient();
var response1 = await client1.GetAsync("https://localhost:7023/WeatherForecast");
System.Console.WriteLine(await response1.Content.ReadAsStringAsync());
sw.Stop();

System.Console.WriteLine($"HttpClient used {sw.ElapsedMilliseconds} ms!!");
