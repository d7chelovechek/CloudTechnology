using Amazon.S3;

namespace Cloudphoto.Models
{
    internal class ClientData : IDisposable
    {
        public IAmazonS3 Client { get; set; }
        public CloudSettings CloudSettings { get; set; }

        public void Dispose()
        {
            Client?.Dispose();
        }
    }
}