using System.Collections.Generic;

namespace RestSharpExample.Server.Controllers
{
    public static class Values
    {
        public static IEnumerable<string> GetValues(int count)
        {
            for (int i = 0; i < count; i++)
                yield return i.ToString("X8");
        }
    }
}