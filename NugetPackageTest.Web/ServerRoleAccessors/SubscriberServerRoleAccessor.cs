using Umbraco.Cms.Core.Sync;

namespace NugetPackageTest.Web.ServerRoleAccessors
{
	public sealed class SubscriberServerRoleAccessor : IServerRoleAccessor
	{
		public ServerRole CurrentServerRole => ServerRole.Subscriber;
	}
}
