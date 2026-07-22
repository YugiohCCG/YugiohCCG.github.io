namespace UnityEngine.Networking;

public static class UnityWebRequestAssetBundle
{

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CachedAssetBundle), Member = "get_hash", ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(DownloadHandlerAssetBundle), Member = "CreateCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAssetBundle), typeof(string), typeof(string), typeof(Hash128), typeof(uint)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc = 0) { }

}

