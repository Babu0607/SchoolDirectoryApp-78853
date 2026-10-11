using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services
{
    public class SchoolService
    {
        private readonly HttpClient _httpClient;

        public SchoolService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<School>?> GetSchoolsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<School>>("https://edutots.net/api/school");
            }
            catch
            {
                return null;
            }
        }
    }
}