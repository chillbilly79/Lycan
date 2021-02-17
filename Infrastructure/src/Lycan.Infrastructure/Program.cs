using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;
using Lycan.Infrastructure;

namespace Lycan.Infrastructure
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            var stack = new LycanStack(app, "LycanStack");
            app.Synth();
        }
    }
}
