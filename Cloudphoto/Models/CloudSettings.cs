namespace Cloudphoto.Models
{
    internal class CloudSettings
    {
        public string BucketName { get; set; }
        public string AwsSecretKeyId { get; set; }
        public string AwsSecretAccessKey { get; set; }
        public string Region { get; set; }
        public string EndpointUrl { get; set; }
    }
}