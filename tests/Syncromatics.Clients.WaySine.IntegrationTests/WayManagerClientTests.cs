using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Syncromatics.Clients.WaySine.IntegrationTests
{
    public class WayManagerClientTests
    {
        private readonly WayManagerClient _subject;

        public WayManagerClientTests()
        {
            const string wayManagerEnvVar = "WAYMANAGER_ROOT_URL";
            var wayManagerRootUrl = Environment.GetEnvironmentVariable(wayManagerEnvVar);
            wayManagerRootUrl.Should()
                .NotBeNull($"you must specify a root url as environment variable '{wayManagerEnvVar}' to run these tests");

            var clientSettings = new ClientSettings(serverRootUrl: wayManagerRootUrl);
            _subject = new WayManagerClient(clientSettings);
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
            const int signId = 640;
            var singleSign = await _subject.GetSignAsync(signId);

            singleSign.Should().NotBeNull();
            singleSign.ID.Should().Be(signId);
        }
    }
}
