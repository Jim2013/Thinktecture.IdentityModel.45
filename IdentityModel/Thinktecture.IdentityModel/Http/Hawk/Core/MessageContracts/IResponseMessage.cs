﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityModel.Http.Hawk.Core.MessageContracts
{
    /// <summary>
    /// Represents an HTTP response message applicable to Hawk authentication.
    /// </summary>
    public interface IResponseMessage : IMessage
    {
        /// <summary>
        /// Status code
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// WwwAuthenticate header value
        /// </summary>
        AuthenticationHeaderValue WwwAuthenticate { get; }

        /// <summary>
        /// Adds a header to response message
        /// </summary>
        /// <param name="name">header name</param>
        /// <param name="value">header value</param>
        void AddHeader(string name, string value);
    }
}
