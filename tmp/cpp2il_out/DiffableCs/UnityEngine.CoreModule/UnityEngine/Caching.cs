namespace UnityEngine;

[NativeHeader("Runtime/Misc/CachingManager.h")]
[StaticAccessor("GetCachingManager()", StaticAccessorType::Dot (0))]
public sealed class Caching
{

	public static int cacheCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 42
	}

	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache currentCacheForWriting
	{
		[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Updater", Member = "DefineCachePath", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("Caching_SetCurrentCacheByHandle")]
		[NativeThrows]
		 set { } //Length: 51
	}

	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "DefineCachePath", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_streamingAssetsPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileAttributes))]
	[Calls(Type = typeof(Caching), Member = "GetCacheByPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
	[Calls(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Cache))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public static Cache AddCache(string cachePath) { }

	[CalledBy(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("AddCachePath")]
	internal static Cache AddCache(string cachePath, bool isReadonly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void AddCache_Injected(ref ManagedSpanWrapper cachePath, bool isReadonly, out Cache ret) { }

	[CalledBy(Type = typeof(Caching), Member = "ClearOtherCachedVersions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hash128)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ClearCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, in Hash128 hash, bool keepInputVersion) { }

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Caching), Member = "ClearCachedVersions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hash128), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int get_cacheCount() { }

	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cache), Member = "Cache_GetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static void GetAllCachePaths(List<String> cachePaths) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("Caching_GetCacheHandleAt")]
	[NativeThrows]
	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache GetCacheAt(int cacheIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetCacheAt_Injected(int cacheIndex, out Cache ret) { }

	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "DefineCachePath", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Caching), Member = "AddCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Cache))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("Caching_GetCacheHandleByPath")]
	[NativeThrows]
	[StaticAccessor("CachingManagerWrapper", StaticAccessorType::DoubleColon (2))]
	public static Cache GetCacheByPath(string cachePath) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetCacheByPath_Injected(ref ManagedSpanWrapper cachePath, out Cache ret) { }

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Caching), Member = "GetCachedVersions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Hash128>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Hash128>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions) { }

	[CalledBy(Type = typeof(Caching), Member = "GetCachedVersions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.Hash128>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	internal static Hash128[] GetCachedVersions(string assetBundleName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, out BlittableArrayWrapper ret) { }

	[CalledBy(Type = "Manager.Updater+<DoUpdate>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "DefineCachePath", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("Caching_SetCurrentCacheByHandle")]
	[NativeThrows]
	public static void set_currentCacheForWriting(Cache value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_currentCacheForWriting_Injected(in Cache value) { }

}

