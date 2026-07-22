namespace UnityEngine;

[UsedByNativeCode]
public struct CachedAssetBundle
{
	private string m_Name; //Field offset: 0x0
	private Hash128 m_Hash; //Field offset: 0x8

	public Hash128 hash
	{
		[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestAssetBundle", Member = "GetAssetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = "UnityEngine.Networking.UnityWebRequest")]
		[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAssetBundle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 11
	}

	public string name
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public CachedAssetBundle(string name, Hash128 hash) { }

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.UnityWebRequestAssetBundle", Member = "GetAssetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = "UnityEngine.Networking.UnityWebRequest")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAssetBundle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public Hash128 get_hash() { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public string get_name() { }

}

