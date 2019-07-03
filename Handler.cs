using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
  public class Handler
  {
    public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request)
    {
      var response = new APIGatewayProxyResponse
      {
        StatusCode = (int)HttpStatusCode.OK,
        Body = JsonConvert.SerializeObject("This is... SERVERLESS!"),
        Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
      };

      return response;
    }
  }
}
