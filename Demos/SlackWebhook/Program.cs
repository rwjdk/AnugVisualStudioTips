using Newtonsoft.Json;
using Slack.NetStandard.EventsApi;
using Slack.NetStandard.EventsApi.CallbackEvents;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello ANUG");

app.MapPost("/webhook", async (HttpRequest request) =>
{
    var json = await new StreamReader(request.Body).ReadToEndAsync();
    var slackEvent = JsonConvert.DeserializeObject<Event>(json);
    switch (slackEvent)
    {
        case EventCallback callback:
            if (callback.Event is MessageCallbackEvent addMessageEvent)
            {
                var data = $"{addMessageEvent.Text} was added to channel {addMessageEvent.Channel.ID}";
                Console.WriteLine(data);
            }

            break;
        case UrlVerification urlVerification:
            return TypedResults.Ok(urlVerification.Challenge);
    }
    return TypedResults.Ok(string.Empty);
});

app.Run();