﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace Alba
{
    public interface ISystemUnderTest
    {
        // Have it return an IApplicationBuilder. Makes many, many things easier

        // Other things?
        /*
            1.) Url resolution?
            2.) Set up defaults in the StubHttpContext?





*/

        HttpContext CreateContext();


        // Might be smarter to keep a hold of the RequestDelegate
        IFeatureCollection Features { get; }
        IServiceProvider Services { get; }


        Task BeforeEach(HttpContext context);
        Task AfterEach(HttpContext context);
    }
}