using System.Net.Http.Headers;
using System.Text.Json;

// See https://aka.ms/new-console-template for more information

Runner.GetResults();

static class Runner {
    public static async void GetResults()
    {
        try
        {

            var orgName = "ORG_NAME_HERE";      
            var project = "PROJECT_NAME_HERE";
            var runId = "TEST_RUN_ID_HERE";      
            var personalaccesstoken = "PAT_FROM_AZURE_DEVOPS_HERE";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        System.Text.ASCIIEncoding.ASCII.GetBytes(
                            string.Format("{0}:{1}", "", personalaccesstoken))));

                using (HttpResponseMessage response = client.GetAsync(
                            $"https://dev.azure.com/{orgName}/{project}/_apis/test/Runs/{runId}/results?api-version=5.0").Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var results = JsonSerializer.Deserialize<Rootobject>(responseBody);
                    foreach(var result in results.value){
                        Console.WriteLine($"{result.testRun.id},{result.id},{result.url},{result.outcome}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}