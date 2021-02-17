using Amazon.CDK;
using Amazon.CDK.AWS.S3;
using Amazon.CDK.AWS.S3.Deployment;

namespace Lycan.Infrastructure
{
    public class S3StaticSiteGenerator
    {
        public S3StaticSiteGenerator(Construct scope)
        {
            var lycanBucket = new Bucket(scope, "LycanWebsiteBucket", new BucketProps()
            {
                WebsiteIndexDocument = "index.html",
                PublicReadAccess = true
            });

            new BucketDeployment(scope, "DeployLycanWebsite", new BucketDeploymentProps()
             {
                 Sources = new []{ Source.Asset("../src/Lycan.Web/publish")},
                 DestinationBucket = lycanBucket,
                 DestinationKeyPrefix = "web/static"
             });
            
            new CfnOutput(scope, "BucketDomain", new CfnOutputProps(){
                Value = lycanBucket.BucketWebsiteDomainName
            });

        }
    }
}