using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UsgsClient.Common
{
    public interface ISimpleHttp
    {
        Task<TResponseType> GetAsync<TResponseType>(
            Uri uri,
            Dictionary<string, string> headers = null);
    }
}
