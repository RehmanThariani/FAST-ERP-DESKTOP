﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Desktop_Application.DbOperations
{
    class LoginDb
    {

        public string[] GetRolesForUserName(string Email)
        {
            List<UserRole> AllUserRoles = new List<UserRole>();
            String[] Roles;
            string newemail = Email.Replace('.', '-');
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44380/api/");
                //HTTP GET
                var responseTask = client.GetAsync("NucesJobAccount/GetRolesbyUserName/" + newemail);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<UserRole[]>();
                    readTask.Wait();

                    var allopenings = readTask.Result;
                    foreach (var item in allopenings)
                    {
                        AllUserRoles.Add(item);
                    }
                    Roles = new string[AllUserRoles.Count];

                    int count = 0;
                    foreach (var users in AllUserRoles)
                    {
                        Roles[count] = users.Role;
                        count++;
                    }
                    return Roles;
                }
            }
            return null;
        }

    }
}
