using System.ComponentModel;
using HtmlAgilityPack;
using WineApp;

var html = @"https://html-agility-pack.net/from-web";

HtmlWeb web = new HtmlWeb();

var htmlDoc = web.Load(html);

var node = htmlDoc.DocumentNode.SelectSingleNode("//h1");

Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

var vin = new Vineyard();

vin.Name = node.InnerHtml;

;

//*[@id="main-container-z"]/div/div[2]/div/div/div[2]/div/div/div/div[2]/div/pre