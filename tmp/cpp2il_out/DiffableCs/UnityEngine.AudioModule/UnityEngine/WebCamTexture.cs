namespace UnityEngine;

[NativeHeader("AudioScriptingClasses.h")]
[NativeHeader("Runtime/Video/BaseWebCamTexture.h")]
[NativeHeader("Runtime/Video/ScriptBindings/WebCamTexture.bindings.h")]
public sealed class WebCamTexture : Texture
{

	public static WebCamDevice[] devices
	{
		[CalledBy(Type = "Data.QRCode", Member = "get_HasWebCam", ReturnType = typeof(bool))]
		[CalledBy(Type = "Data.QRCode", Member = "ReadQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<String>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[NativeName("Internal_GetDevices")]
		[StaticAccessor("WebCamTextureBindings", StaticAccessorType::DoubleColon (2))]
		 get { } //Length: 42
	}

	public bool didUpdateThisFrame
	{
		[CalledBy(Type = "Data.QRCode", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("DidUpdateThisFrame")]
		 get { } //Length: 118
	}

	public bool isPlaying
	{
		[CalledBy(Type = "Data.QRCode", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsInvalidInstructions]
		[NativeName("IsPlaying")]
		 get { } //Length: 200
	}

	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebCamTexture), Member = "Internal_CreateWebCamTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebCamTexture), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public WebCamTexture(int requestedWidth, int requestedHeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WebCamTexture), Member = "Internal_CreateWebCamTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebCamTexture), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public WebCamTexture() { }

	[CalledBy(Type = "Data.QRCode", Member = "get_HasWebCam", ReturnType = typeof(bool))]
	[CalledBy(Type = "Data.QRCode", Member = "ReadQR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<String>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeName("Internal_GetDevices")]
	[StaticAccessor("WebCamTextureBindings", StaticAccessorType::DoubleColon (2))]
	public static WebCamDevice[] get_devices() { }

	[CalledBy(Type = "Data.QRCode", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("DidUpdateThisFrame")]
	public bool get_didUpdateThisFrame() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_didUpdateThisFrame_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Data.QRCode", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsInvalidInstructions]
	[NativeName("IsPlaying")]
	public bool get_isPlaying() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Data.QRCode", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public Color32[] GetPixels32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("WebCamTextureBindings::Internal_GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	public Color32[] GetPixels32(Color32[] colors) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Color32[] GetPixels32_Injected(IntPtr _unity_self, Color32[] colors) { }

	[CalledBy(Type = typeof(WebCamTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebCamTexture), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[StaticAccessor("WebCamTextureBindings", StaticAccessorType::DoubleColon (2))]
	private static void Internal_CreateWebCamTexture(WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_CreateWebCamTexture_Injected(WebCamTexture self, ref ManagedSpanWrapper scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate) { }

	[CalledBy(Type = "Data.QRCode", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Play() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Play_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Data.QRCode", Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Stop() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Stop_Injected(IntPtr _unity_self) { }

}

