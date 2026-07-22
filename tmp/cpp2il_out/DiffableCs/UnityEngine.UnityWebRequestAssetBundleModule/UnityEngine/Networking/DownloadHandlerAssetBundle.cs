namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(DownloadHandlerAssetBundle handler) { }

	}


	public AssetBundle assetBundle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 282
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CachedAssetBundle), Member = "get_hash", ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(DownloadHandlerAssetBundle), Member = "CreateCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAssetBundle), typeof(string), typeof(string), typeof(Hash128), typeof(uint)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	public DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc) { }

	[CalledBy(Type = typeof(UnityWebRequestAssetBundle), Member = "GetAssetBundle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = typeof(UnityWebRequest))]
	[CalledBy(Type = typeof(DownloadHandlerAssetBundle), Member = "InternalCreateAssetBundleCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Hash128), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DownloadHandlerAssetBundle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CachedAssetBundle), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, ref ManagedSpanWrapper name, in Hash128 hash, uint crc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AssetBundle get_assetBundle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.Updater+<DownloadAssetBundle>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static AssetBundle GetContent(UnityWebRequest www) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected virtual Byte[] GetData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected virtual string GetText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandlerAssetBundle), Member = "CreateCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAssetBundle), typeof(string), typeof(string), typeof(Hash128), typeof(uint)}, ReturnType = typeof(IntPtr))]
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

}

