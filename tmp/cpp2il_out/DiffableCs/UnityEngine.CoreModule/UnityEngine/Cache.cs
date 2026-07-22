namespace UnityEngine;

[NativeHeader("Runtime/Misc/Cache.h")]
[StaticAccessor("CacheWrapper", StaticAccessorType::DoubleColon (2))]
public struct Cache : IEquatable<Cache>
{
	private int m_Handle; //Field offset: 0x0

	internal int handle
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public string path
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Cache), Member = "Cache_GetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		 get { } //Length: 11
	}

	public bool valid
	{
		[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater", Member = "DefineCachePath", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 49
	}

	[CalledBy(Type = typeof(Cache), Member = "get_path", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Caching), Member = "GetAllCachePaths", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[NativeThrows]
	internal static string Cache_GetPath(int handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Cache_GetPath_Injected(int handle, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool Cache_IsValid(int handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Cache other) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	internal int get_handle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cache), Member = "Cache_GetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	public string get_path() { }

	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "DefineCachePath", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_valid() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

