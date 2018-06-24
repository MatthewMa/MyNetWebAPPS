using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvite.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            // we could do other things here while we are waiting
            // for the HTTP request to complete
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
