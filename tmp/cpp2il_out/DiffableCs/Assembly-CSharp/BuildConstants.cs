//Type is in global namespace

public static class BuildConstants
{
	internal enum Architecture
	{
		None = 0,
		Android = 1,
		Linux_x64 = 2,
		Windows_x86 = 3,
		Windows_x64 = 4,
		iOS = 5,
		macOS = 6,
	}

	internal enum Distribution
	{
		None = 0,
		Android = 1,
		Linux_x64 = 2,
		iOS = 3,
		Mac_x64 = 4,
	}

	internal enum Platform
	{
		None = 0,
		Android = 1,
		Linux = 2,
		PC = 3,
		iOS = 4,
		macOS = 5,
	}

	internal enum ReleaseType
	{
		None = 0,
		Release = 1,
	}

	public static readonly DateTime buildDate; //Field offset: 0x0
	public const string version = "2.0.233"; //Field offset: 0x0
	public const ReleaseType releaseType = 1; //Field offset: 0x0
	public const Platform platform = 3; //Field offset: 0x0
	public const Architecture architecture = 4; //Field offset: 0x0
	public const Distribution distribution = 0; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	private static BuildConstants() { }

}

