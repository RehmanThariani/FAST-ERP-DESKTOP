using IPT_Desktop_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Desktop_Application.DbOperations
{
    class JobOpeningDb
    {
        public List<JobOpenings> GetAllJobs()
        {

            List<JobOpenings> AllJobOpenings = new List<JobOpenings>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                //HTTP GET
                var responseTask = client.GetAsync("NucesJob/GetAllOpenings");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<JobOpenings[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        item.Designation = GetDesignationByID(item.DesignationID);
                        item.Department = GetDepartmentByID(item.DepartmentID);
                        AllJobOpenings.Add(item);
                    }
                }
            }
            return AllJobOpenings;
        }

        public int AddJob(JobOpenings job)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["MinExperience"] = job.MinExperience;
            data["JobDescription"] = job.JobDescription;
            data["DatePosted"] = DateTime.Now.ToString("yyyy-MM-dd");
            data["ExpectedStartDate"] = job.ExpectedStartDate;
            data["DesignationID"] = GetDesignationIdbyTitle(job.Designation);
            data["DepartmentID"] = GetDepartmentIdbyTitle(job.Department);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.PostAsJsonAsync("NucesJob/AddJobOpening", data);
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

        public int UpdateJob(JobOpenings job)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["JobID"] = job.JobID;
            data["MinExperience"] = job.MinExperience;
            data["JobDescription"] = job.JobDescription;
            //data["DatePosted"] = DateTime.Now.ToString("yyyy-MM-dd");
            data["ExpectedStartDate"] = job.ExpectedStartDate;
            data["DesignationID"] = GetDesignationIdbyTitle(job.Designation);
            data["DepartmentID"] = GetDepartmentIdbyTitle(job.Department);


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.PostAsJsonAsync("NucesJob/UpdateJobOpening", data);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        public JobOpenings GetJobById(int id)
        {
            List<JobOpenings> AllJobOpenings = new List<JobOpenings>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.GetAsync("NucesJob/GetOpeningsById/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<JobOpenings[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        item.Designation = GetDesignationByID(item.DesignationID);
                        item.Department = GetDepartmentByID(item.DepartmentID);
                        AllJobOpenings.Add(item);
                    }
                }
            }
            JobOpenings SingleJob = AllJobOpenings[0];
            return SingleJob;
        }

        public int DeleteJob(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.DeleteAsync("NucesJob/DeleteJobOpening/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<Designation> GetAllDesignations()
        {
            List<Designation> AllDesignations = new List<Designation>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                //HTTP GET
                var responseTask = client.GetAsync("NucesJob/GetAllDesignations");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Designation[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        AllDesignations.Add(item);
                    }
                }
            }
            return AllDesignations;
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> AllDepartments = new List<Department>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                //HTTP GET
                var responseTask = client.GetAsync("NucesJob/GetAllDepartments");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Department[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        AllDepartments.Add(item);
                    }
                }
            }
            return AllDepartments;
        }

        public string GetDesignationByID(int id)
        {
            List<Designation> AllDesignations = new List<Designation>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.GetAsync("NucesJob/GetDesignationById/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Designation[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        AllDesignations.Add(item);
                    }
                }
            }
            string Designation = AllDesignations[0].DesignationTitle;
            return Designation;
        }

        public string GetDepartmentByID(int id)
        {
            List<Department> AllDepartments = new List<Department>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                var responseTask = client.GetAsync("NucesJob/GetDepartmentById/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Department[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;

                    foreach (var item in allopenings)
                    {
                        AllDepartments.Add(item);
                    }
                }
            }
            string Department = AllDepartments[0].DepartmentName;
            return Department;
        }

        public int GetDesignationIdbyTitle(string title)
        {
            int result = 0;
            List<Designation> AllDesignations = GetAllDesignations();
            foreach (Designation item in AllDesignations)
            {
                if (item.DesignationTitle == title)
                {
                    result = item.DesignationID;
                }
            }
            return result;
        }

        public int GetDepartmentIdbyTitle(string title)
        {
            int result = 0;
            List<Department> AllDepartments = GetAllDepartments();
            foreach (Department item in AllDepartments)
            {
                if (item.DepartmentName == title)
                {
                    result = item.DepartmentID;
                }
            }
            return result;
        }
    }
}
