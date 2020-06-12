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
        public static void Reply(string replyToken, IEnumerable<IMessageObject> messages,
            bool notificationDisabled = false)
        {
            var accessToken = Environment.GetEnvironmentVariable("LINE_CHANNEL_ACCESS_TOKEN");
            var client = new ServiceCollection().AddHttpClient().BuildServiceProvider().GetService<IHttpClientFactory>()
                .CreateClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var requestItem = new ResponseMessage(replyToken, messages)
            {
                NotificationDisabled = notificationDisabled
            };
            var bodyJson = JsonConvert.SerializeObject(requestItem, Formatting.None,
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});

            Console.WriteLine(bodyJson);

            var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");
            var resultTask = client.PostAsync("https://api.line.me/v2/bot/message/reply", content);

            resultTask.Wait();
            if (resultTask.Result.IsSuccessStatusCode) return;

            var errorBodyTask = resultTask.Result.Content.ReadAsStringAsync();
            errorBodyTask.Wait();
            throw new Exception(errorBodyTask.Result);
        }

        public static async Task<ProfileInformation?> Profile(string userId)
        {
            var accessToken = Environment.GetEnvironmentVariable("LINE_CHANNEL_ACCESS_TOKEN");
            var client = new ServiceCollection().AddHttpClient().BuildServiceProvider().GetService<IHttpClientFactory>()
                .CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var response = await client.GetAsync($"https://api.line.me/v2/bot/profile/{userId}");
            if (!response.IsSuccessStatusCode) return null;
            var resultJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProfileInformation>(resultJson);
        }

        public static async Task<GroupInformation?> GroupSummary(string groupId)
        {
            var accessToken = Environment.GetEnvironmentVariable("LINE_CHANNEL_ACCESS_TOKEN");
            var client = new ServiceCollection().AddHttpClient().BuildServiceProvider().GetService<IHttpClientFactory>()
                .CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var response = await client.GetAsync($"https://api.line.me/v2/bot/group/{groupId}/summary");
            if (!response.IsSuccessStatusCode) return null;

            var resultJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GroupInformation>(resultJson);
        }

        public static async Task Push(string to, IEnumerable<IMessageObject> messages)
        {
            var accessToken = Environment.GetEnvironmentVariable("LINE_CHANNEL_ACCESS_TOKEN");
            var client = new ServiceCollection().AddHttpClient().BuildServiceProvider().GetService<IHttpClientFactory>()
                .CreateClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            var requestItem = new PushMessage(to, messages);
            var bodyJson = JsonConvert.SerializeObject(requestItem, Formatting.None,
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});

            var content = new StringContent(bodyJson, Encoding.UTF8, "application/json");
            var result = await client.PostAsync("https://api.line.me/v2/bot/message/push", content);

            if (result.IsSuccessStatusCode) return;

            var errorBodyTask = result.Content.ReadAsStringAsync();
            errorBodyTask.Wait();
            throw new Exception(errorBodyTask.Result);
        }
    }
}