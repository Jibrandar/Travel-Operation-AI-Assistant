using Microsoft.Extensions.AI;
using OpenAI;
using System.ClientModel;
using TravelOperationsAIAssistant.Services;
using System.Text;


internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        TravelServices service = new();
        string _apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY");
        ApiKeyCredential credential = new(_apiKey);
        OpenAIClient groqClient = new(credential, new() { Endpoint = new("https://api.groq.com/openai/v1") });
        var chatClient = groqClient.GetChatClient("openai/gpt-oss-20b");
        IChatClient client = chatClient.AsIChatClient();

        ChatOptions options = new()
        {
            Tools = [
                AIFunctionFactory.Create(service.SearchPackages),
                AIFunctionFactory.Create(service.GetPackage),
                AIFunctionFactory.Create(service.GetDestinationInfo),
                AIFunctionFactory.Create(service.GetAvailableVehicle)
                ],
            Temperature=0.4f
        };
        client = new ChatClientBuilder(client).UseFunctionInvocation().Build();
        var systemPrompt = @$"You are an Travel Operations Assistant in a travel agency.
        1:Give answer strictly related to travel
        2:Dont invent extra operations use only tools i provided
        3:If a function return null respond with preper response
        4: After response from function dont give suggestions which i dont have a tool for
        
        ";

        List<ChatMessage> history = new List<ChatMessage>();
        history.Add(new(ChatRole.System,systemPrompt));
        Console.WriteLine("======================================================");
        Console.WriteLine();
        Console.WriteLine("Travel Operations AI Assistant");
        Console.WriteLine();
        Console.WriteLine("======================================================");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Please write your query or write exit to quit");

        while (true)
        {
            Console.WriteLine();
            Console.Write("Q : ");
            var question = Console.ReadLine();
            if (question == "exit")
            {
                break;
            }

            List<ChatResponseUpdate> updates = new List<ChatResponseUpdate>();

            history.Add(new(ChatRole.User, question));
            await foreach (var update in client.GetStreamingResponseAsync(history,options))
            {
                Console.Write(update);
                updates.Add(update);


            }
            history.AddMessages(updates);

        }

    }
}
