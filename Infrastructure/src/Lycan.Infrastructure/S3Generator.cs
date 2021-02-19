using Amazon.CDK;
using Amazon.CDK.AWS.S3;
using Amazon.CDK.AWS.S3.Deployment;

namespace Lycan.Infrastructure
{
    public class S3StaticSiteGenerator
    {
        public S3StaticSiteGenerator(Construct scope, S3GeneratorOptions options)
        {
            var lycanBucket = new Bucket(scope, "LycanWebsiteBucket", new BucketProps()
            {
                WebsiteIndexDocument = "index.html",
                PublicReadAccess = true,
                BucketName = options.S3BucketName
            });

            new CfnOutput(scope, "BucketDomain", new CfnOutputProps(){
                Value = lycanBucket.BucketWebsiteDomainName
            });

        }
    }
}