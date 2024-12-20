using Umbraco.Cms.Core.Sync;

namespace NugetPackageTest.Web.ServerRoleAccessors
{
	public sealed class SingleServerRoleAccessor : IServerRoleAccessor
	{
		public ServerRole CurrentServerRole => ServerRole.Single;
	}
}
