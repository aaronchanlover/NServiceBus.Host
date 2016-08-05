namespace NServiceBus.Hosting.Tests
{
    using System.Threading.Tasks;
    using Transport;

    class FakeQueueCreator : ICreateQueues
    {
        public Task CreateQueueIfNecessary(QueueBindings queueBindings, string identity)
        {
            return Task.FromResult(0);
        }
    }
}