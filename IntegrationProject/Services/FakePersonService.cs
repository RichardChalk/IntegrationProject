using IntegrationProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationProject.Services
{
    public class FakePersonService : IFakePersonService
    {
        public FakePerson Generate()
        {
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://randomuser.me/api/").Result;
                dynamic r = JsonConvert.DeserializeObject<dynamic>(json);

                var result = new FakePerson();
                result.City = r.results[0].location.city;
                result.Country = r.results[0].location.country;
                result.FirstName = r.results[0].name.first;
                result.LastName = r.results[0].name.last;
                result.Username = r.results[0].login.username;
                return result;
            }
        }
    }
}
