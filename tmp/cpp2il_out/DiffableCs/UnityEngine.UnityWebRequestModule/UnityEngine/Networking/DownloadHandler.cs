namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(DownloadHandler handler) { }

	}

	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10

	public Byte[] data
	{
		[CallerCount(Count = 82)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public string text
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[VisibleToOtherModules]
	internal DownloadHandler() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	protected override void CompleteContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	internal static void CreateNativeArrayForNativeData(ref NativeArray<Byte>& data, Byte* bytes, int length) { }

	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule"})]
	internal static void DisposeNativeArray(ref NativeArray<Byte>& data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 82)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Byte[] get_data() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAssetBundle", Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "UnityEngine.AssetBundle")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = "UnityEngine.AudioClip")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	protected static T GetCheckedDownloader(UnityWebRequest www) { }

	[CalledBy(Type = typeof(DownloadHandler), Member = "GetTextEncoder", ReturnType = typeof(Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	private string GetContentType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetContentType_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected override Byte[] GetData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override NativeArray<Byte> GetNativeData() { }

	[CallerCount(Count = 0)]
	[RequiredByNativeCode]
	protected override float GetProgress() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "GetTextEncoder", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override string GetText() { }

	[CalledBy(Type = typeof(DownloadHandler), Member = "GetText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DownloadHandler), Member = "GetContentType", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Encoding GetTextEncoder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	[VisibleToOtherModules]
	internal static Byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static Byte[] InternalGetByteArray(DownloadHandler dh) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte* InternalGetByteArray_Injected(IntPtr dh, out int length) { }

	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerAudioClip", Member = "GetNativeData", ReturnType = "Unity.Collections.NativeArray`1<Byte>")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandlerTexture", Member = "GetNativeData", ReturnType = "Unity.Collections.NativeArray`1<Byte>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule"})]
	internal static NativeArray<Byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<Byte>& nativeArray) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[Obsolete("Use ReceiveContentLengthHeader")]
	protected override void ReceiveContentLength(int contentLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	protected override void ReceiveContentLengthHeader(ulong contentLength) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	protected override bool ReceiveData(Byte[] data, int dataLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True)]
	private void ReleaseFromScripting() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

}

