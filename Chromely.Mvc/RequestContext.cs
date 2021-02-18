using System.Collections.Generic;
using System.Net.Http;
using Chromely.Core.Network;

namespace Chromely.Mvc
{
    public class RequestContext
    {
        public HttpMethod Method { get; set; }
        public string Url { get; set; }
        public IEnumerable<KeyValuePair<string, string>> QueryParameters { get; set; }
        public object PostData { get; set; }
        public string RequestId { get; set; }
    }
}