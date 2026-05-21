using System.Threading.Tasks;
using Xunit;
using RSSFeedReader.Api.Services;
using RSSFeedReader.Api.Models;
using System.Linq;

namespace RSSFeedReader.Api.Tests
{
    public class SubscriptionTests
    {
        [Fact]
        public async Task AddAndListSubscriptions()
        {
            var repo = new SubscriptionRepository();
            var s1 = new Subscription { Id = System.Guid.NewGuid(), Url = "https://example.com/feed1" };
            var s2 = new Subscription { Id = System.Guid.NewGuid(), Url = "https://example.com/feed2" };

            await repo.AddAsync(s1);
            await repo.AddAsync(s2);

            var all = await repo.GetAllAsync();
            Assert.Contains(all, x => x.Url == s1.Url);
            Assert.Contains(all, x => x.Url == s2.Url);
            Assert.Equal(2, all.Count);
        }
    }
}
