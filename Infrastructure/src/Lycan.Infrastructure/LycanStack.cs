using Amazon.CDK;

namespace Lycan.Infrastructure
{
    public class LycanStack : Stack
    {
        internal LycanStack(Construct scope, string id, S3GeneratorOptions options, IStackProps props = null) : base(scope, id, props)
        {
            var s3 = new S3StaticSiteGenerator(this, options);
        }
    }
}
