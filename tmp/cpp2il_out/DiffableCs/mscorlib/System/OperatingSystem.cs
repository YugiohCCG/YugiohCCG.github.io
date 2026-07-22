namespace System;

public sealed class OperatingSystem : ISerializable, ICloneable
{
	private readonly Version _version; //Field offset: 0x10
	private readonly PlatformID _platform; //Field offset: 0x18
	private readonly string _servicePack; //Field offset: 0x20
	private string _versionString; //Field offset: 0x28

	public PlatformID Platform
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Version Version
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string VersionString
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 180
	}

	[CalledBy(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version), typeof(string)}, ReturnType = typeof(void))]
	public OperatingSystem(PlatformID platform, Version version) { }

	[CalledBy(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OperatingSystem), Member = "Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	internal OperatingSystem(PlatformID platform, Version version, string servicePack) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version), typeof(string)}, ReturnType = typeof(void))]
	public override object Clone() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public PlatformID get_Platform() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Version get_Version() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	public string get_VersionString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

