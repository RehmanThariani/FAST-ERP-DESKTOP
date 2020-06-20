using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Desktop_Application.DbOperations
{
    public class EcandidateApplicationDb
    {
        public List<EcandidateApplication> GetAllApplications()
        {
            List<EcandidateApplication> Allapplication = new List<EcandidateApplication>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                //HTTP GET
                var responseTask = client.GetAsync("EcandidateApplication/GetAllEcandidateApplication");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<EcandidateApplication[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        
                        Allapplication.Add(item);
                    }
                }
            }
            return Allapplication;
        }

        public int AddEcandidateApplication(EcandidateApplication can)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["QualifiedStatus"] = "Not Set";
            data["JobID"] = can.JobID;
            data["ApplyDate"] = DateTime.Now.ToString("yyyy-MM-dd");
            data["TestDate"] = "";
            data["ECandidateID"] =can.EcandidateID;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.PostAsJsonAsync("Ecandidateapplication/AddEcandidateApplication", data);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.StatusCode == HttpStatusCode.Created)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
