using System.Linq;
using System.Threading.Tasks;
using Xunit;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Tests
{
    public class SubscriptionRepositoryTests
    {
        [Fact]
        public async Task AddAndList_Workflow()
        {
            var repo = new SubscriptionRepository();
            await repo.AddAsync(new Subscription { Id = System.Guid.NewGuid(), Url = "https://example.com/feed" });
            var all = (await repo.GetAllAsync()).ToList();
            Assert.Single(all);
        }
    }
}
