// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Create new HttpClient
HttpClient client = new HttpClient();


//kanye URL (endpoint)
string kanyeUrl = "https://api.kanye.rest";

//GET request
var kanyeResponse = client.GetAsync(kanyeUrl).Result;

//Parse object
var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

//ron URL (endpoint)
string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

//GET request
var ronResponse = client.GetAsync(ronUrl).Result;

//Parse object 
