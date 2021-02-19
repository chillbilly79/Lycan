using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;
using Lycan.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Lycan.Infrastructure
{
    sealed class Program
    {
        public static IConfiguration Configuration { get; set; }
        public static void Main(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            
            var options = new S3GeneratorOptions()
            {
                S3BucketName = Configuration.GetSection("S3GeneratorOptions:S3BucketName").Value
            };
            
            var app = new App();
            var stack = new LycanStack(app, "LycanStack", options);
            app.Synth();
        }
    }
}
