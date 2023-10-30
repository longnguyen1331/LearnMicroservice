using PlatformService.Dtos;

namespace PlatformService.SyncDataServices
{
    public interface IMessageBusClient
    {
        void PublishNewPlatfrom(PlatformPublishedDto platformPublishedDto);
    }
}