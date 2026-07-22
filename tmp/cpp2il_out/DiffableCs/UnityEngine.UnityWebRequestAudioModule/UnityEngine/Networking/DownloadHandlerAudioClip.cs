namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
public sealed class DownloadHandlerAudioClip : DownloadHandler
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(DownloadHandlerAudioClip handler) { }

	}

	private NativeArray<Byte> m_NativeData; //Field offset: 0x18

	[NativeThrows]
	public AudioClip audioClip
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 282
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAudioClip), typeof(string), typeof(AudioType)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	public DownloadHandlerAudioClip(string url, AudioType audioType) { }

	[CalledBy(Type = typeof(DownloadHandlerAudioClip), Member = "InternalCreateAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DownloadHandlerAudioClip), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityWebRequestMultimedia), Member = "GetAudioClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AudioType)}, ReturnType = typeof(UnityWebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create_Injected(DownloadHandlerAudioClip obj, ref ManagedSpanWrapper url, AudioType audioType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "DisposeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DownloadHandler), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AudioClip get_audioClip() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_audioClip_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DownloadHandler), Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "T")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static AudioClip GetContent(UnityWebRequest www) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "InternalGetNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler), typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[DeduplicatedMethod]
	protected virtual NativeArray<Byte> GetNativeData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected virtual string GetText() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAudioClip), typeof(string), typeof(AudioType)}, ReturnType = typeof(IntPtr))]
	private void InternalCreateAudioClip(string url, AudioType audioType) { }

}

