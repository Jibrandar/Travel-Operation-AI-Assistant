# Travel Operations AI Assistant

A small C#/.NET AI project I built to practice integrating AI into a normal application.

The idea is simple: instead of making the AI responsible for everything, I gave it access to a few travel-related functions. It can search tour packages, get package details, check available vehicles, and provide information about destinations.

The project uses **Groq** with an OpenAI-compatible endpoint and **Microsoft.Extensions.AI**.

## What can it do?

The assistant can:

* Search available tour packages
* Get details about a specific package
* Check vehicles based on passenger requirements
* Get information about a destination
* Maintain chat history
* Stream AI responses
* Use function calling to get information from the application's services

For example, you can ask:

> Show me Kashmir packages for 5 days.

or:

> Do you have a vehicle for 10 passengers?

The AI decides when it needs to call one of the available functions and uses the returned information to answer.

## Technologies Used

* C#
* .NET
* Microsoft.Extensions.AI
* Groq API
* OpenAI-compatible API
* Function Calling
* Chat History
* Streaming Responses

## Project Structure

```text
TravelOperationsAIAssistant/
│
├── Models/
│   ├── TourPackage.cs
│   ├── Vehicle.cs
│   └── Destination.cs
│
├── Data/
│   ├── TourPackageData.cs
│   ├── VehicleData.cs
│   └── DestinationData.cs
│
├── Services/
│   └── TravelServices.cs
│
├── Tools/
│   └── TravelTools.cs
│
└── Program.cs
```

### Models

Contains the classes used to represent the application's data.

For example:

* `TourPackage`
* `Vehicle`
* `Destination`

### Data

Contains sample in-memory data used by the application.

There is no database in this project. I kept the data in lists because the main purpose of this project was to practice AI integration and function calling.

### Services

`TravelServices` contains the actual travel-related operations.

For example:

```text
SearchTourPackages()
GetTourPackageDetails()
GetAvailableVehicles()
GetDestinationInfo()
```

These methods don't depend on the AI. They are normal C# methods that work with the application's data.

### Tools

This layer exposes selected service methods to the AI.

The AI doesn't directly access the data. It can only use the functions that I provide to it.

## How the AI Flow Works

The basic flow looks like this:

```text
User
  ↓
AI Assistant
  ↓
Does the AI need travel information?
  ↓
Function Calling
  ↓
TravelTools
  ↓
TravelServices
  ↓
Sample Data
  ↓
Result returned to AI
  ↓
Final response
```

For example, if I ask:

> Find me an available vehicle for 8 passengers.

The AI can decide to call the vehicle-related function. The function gets the information from `TravelServices`, and the result is then used by the AI to generate the response.

## Chat History

The application keeps the conversation history so that follow-up questions make sense.

For example:

```text
User: Show me honeymoon packages.

AI: Here are some honeymoon packages...

User: What about the cheapest one?

AI: ...
```

The previous messages are kept in the chat history, allowing the AI to understand the context.

## Streaming

Instead of waiting for the complete response, the application displays the AI response as it is generated.

This was also part of my practice with `Microsoft.Extensions.AI` and `IChatClient`.

## Setup

### 1. Clone the repository

```bash
git clone <your-repository-url>
cd TravelOperationsAIAssistant
```

### 2. Add your Groq API key

Create an environment variable:

```text
GROQ_API_KEY
```

The API key is not stored directly in the source code.

### 3. Restore packages

```bash
dotnet restore
```

### 4. Run the application

```bash
dotnet run
```

## Important Note

This is a **practice/learning project**.

It does not connect to a real travel booking system, payment system, or database. The packages, vehicles, and destinations are sample data stored in memory.

The main purpose of building this was to understand how AI can be integrated into a C# application and how an AI model can use functions provided by the application.

## What I Practiced

While building this project, I practiced:

* Working with `IChatClient`
* Chat history
* Streaming responses
* Function calling
* `AIFunctionFactory`
* `ChatOptions`
* Configuring chat options
* Connecting a C# application to an OpenAI-compatible API
* Separating AI logic from normal application services

## Future Improvements

If I continue developing this project, some things I could add are:

* Database integration
* Real travel package management
* Booking functionality
* Web API
* Authentication
* More advanced AI features such as RAG

For now, I kept the project small so I could focus on understanding the AI integration rather than building a complete travel management system.
