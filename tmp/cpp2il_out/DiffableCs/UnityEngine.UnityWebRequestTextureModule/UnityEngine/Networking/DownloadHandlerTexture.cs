namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
public sealed class DownloadHandlerTexture : DownloadHandler
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(DownloadHandlerTexture handler) { }

	}

	private NativeArray<Byte> m_NativeData; //Field offset: 0x18

	public Texture2D texture
	{
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 282
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public DownloadHandlerTexture(bool readable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create(DownloadHandlerTexture obj, DownloadedTextureParams parameters) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create_Injected(DownloadHandlerTexture obj, in DownloadedTextureParams parameters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "DisposeNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DownloadHandler), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void Dispose() { }

	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public Texture2D get_texture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DownloadHandler), Member = "InternalGetNativeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandler), typeof(NativeArray`1<Byte>&)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[DeduplicatedMethod]
	protected virtual NativeArray<Byte> GetNativeData() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalCreateTexture(DownloadedTextureParams parameters) { }

	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[NativeThrows]
	private Texture2D InternalGetTextureNative() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr InternalGetTextureNative_Injected(IntPtr _unity_self) { }

}

