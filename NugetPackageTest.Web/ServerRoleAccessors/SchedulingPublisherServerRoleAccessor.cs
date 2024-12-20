using Umbraco.Cms.Core.Sync;

namespace NugetPackageTest.Web.ServerRoleAccessors
{
	public sealed class SchedulingPublisherServerRoleAccessor : IServerRoleAccessor
	{
		public ServerRole CurrentServerRole => ServerRole.SchedulingPublisher;
	}
}
