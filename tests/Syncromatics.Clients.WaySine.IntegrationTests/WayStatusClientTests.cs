using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Syncromatics.Clients.WaySine.IntegrationTests
{
    public class WayStatusClientTests
    {
        private readonly WayStatusClient _subject;

        public WayStatusClientTests()
        {
            const string envVar = "WAYSTATUS_ROOT_URL";
            var rootUrl = Environment.GetEnvironmentVariable(envVar);
            rootUrl.Should()
                .NotBeNull($"you must specify a root url as environment variable '{envVar}' to run these tests");

            var clientSettings = new ClientSettings(serverRootUrl: rootUrl);
            _subject = new WayStatusClient(clientSettings);
        }

        [Fact]
        public async Task Can_get_all_signs()
        {
            var allSigns = await _subject.GetAllSignsAsync();

            allSigns.Should().NotBeNull();
            allSigns.Count.Should().BeGreaterThan(0);
        }

        [Fact]
        public async Task Can_get_single_sign()
        {
            const int signId = 592;
            var singleSign = await _subject.GetSignAsync(signId);

            singleSign.Should().NotBeNull();
            singleSign.SignId.Should().Be(signId);
        }
    }
}
