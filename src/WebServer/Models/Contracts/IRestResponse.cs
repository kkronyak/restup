﻿using Devkoes.Restup.WebServer.Models.Schemas;

namespace Devkoes.Restup.WebServer.Models.Contracts
{
    public interface IRestResponse
    {
        int StatusCode { get; }
        string Data { get; }
    }
}
