using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LineApi.ResponseObjects;
using LineApi.ResponseObjects.MessageObject;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace LineApi
{
    public static class LineManager
    {
        public static void Reply(string replyToken, IEnumerable<IMessageObject> messages)
        {
            var accessToken = Environment.GetEnvironmentVariable("LINE_CHANNEL_ACCESS_TOKEN");
            var client = new ServiceCollection().AddHttpClient().BuildServiceProvider().GetService<IHttpClientFactory>()
                .CreateClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var requestItem = new ResponseMessage(replyToken, messages);
            var bodyJson = JsonConvert.SerializeObject(requestItem);

            var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");
            var resultTask = client.PostAsync("https://api.line.me/v2/bot/message/reply", content);

            resultTask.Wait();
            if (resultTask.Result.IsSuccessStatusCode) return;

            var errorBodyTask = resultTask.Result.Content.ReadAsStringAsync();
            errorBodyTask.Wait();
            throw new Exception(errorBodyTask.Result);
        }

        public static async Task<Dictionary<string, string>?> Profile(string userId)
        {
            var accessToken = Environment.GetEnvironmentVariable("LINE_CHANNEL_ACCESS_TOKEN");
            var client = new ServiceCollection().AddHttpClient().BuildServiceProvider().GetService<IHttpClientFactory>()
                .CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var response = await client.GetAsync($"https://api.line.me/v2/bot/profile/{userId}");
            if (!response.IsSuccessStatusCode) return null;
            var resultJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(resultJson);
        }
    }
}