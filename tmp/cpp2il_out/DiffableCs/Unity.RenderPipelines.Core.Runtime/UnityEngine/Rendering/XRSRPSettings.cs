namespace UnityEngine.Rendering;

public class XRSRPSettings
{

	public static bool enabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		 get { } //Length: 7
	}

	public static RenderTextureDescriptor eyeTextureDesc
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XRSettings), Member = "get_eyeTextureDesc", ReturnType = typeof(RenderTextureDescriptor))]
		 get { } //Length: 113
	}

	public static int eyeTextureHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSettings), Member = "get_eyeTextureHeight", ReturnType = typeof(int))]
		 get { } //Length: 33
	}

	public static int eyeTextureWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSettings), Member = "get_eyeTextureWidth", ReturnType = typeof(int))]
		 get { } //Length: 33
	}

	public static bool isDeviceActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSettings), Member = "get_isDeviceActive", ReturnType = typeof(bool))]
		 get { } //Length: 31
	}

	public static string loadedDeviceName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSettings), Member = "get_loadedDeviceName", ReturnType = typeof(string))]
		 get { } //Length: 66
	}

	public static int mirrorViewMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSystem), Member = "GetMirrorViewMode", ReturnType = typeof(int))]
		 get { } //Length: 82
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSystem), Member = "SetMirrorViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 88
	}

	public static float occlusionMeshScale
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		 get { } //Length: 145
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderTexture), Member = "get_antiAliasing", ReturnType = typeof(int))]
		[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
		[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
		[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[Calls(Type = typeof(HashFNV1A32), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
		[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
		[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
		[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 72)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 9658
	}

	public static String[] supportedDevices
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRSettings), Member = "get_supportedDevices", ReturnType = typeof(String[]))]
		 get { } //Length: 75
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XRSRPSettings() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	public static bool get_enabled() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSettings), Member = "get_eyeTextureDesc", ReturnType = typeof(RenderTextureDescriptor))]
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSettings), Member = "get_eyeTextureHeight", ReturnType = typeof(int))]
	public static int get_eyeTextureHeight() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSettings), Member = "get_eyeTextureWidth", ReturnType = typeof(int))]
	public static int get_eyeTextureWidth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSettings), Member = "get_isDeviceActive", ReturnType = typeof(bool))]
	public static bool get_isDeviceActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSettings), Member = "get_loadedDeviceName", ReturnType = typeof(string))]
	public static string get_loadedDeviceName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "GetMirrorViewMode", ReturnType = typeof(int))]
	public static int get_mirrorViewMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	public static float get_occlusionMeshScale() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSettings), Member = "get_supportedDevices", ReturnType = typeof(String[]))]
	public static String[] get_supportedDevices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRSystem), Member = "SetMirrorViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public static void set_mirrorViewMode(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeList`1), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRSettings), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T&")]
	[Calls(Type = typeof(ResourcesData), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle)}, ReturnType = typeof(ResourceVersionedData&))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler.ResourceUnversionedData>), Member = "ElementAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ResourceUnversionedData&))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "IsRenderGraphResourceImported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashFNV1A32), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&)}, ReturnType = typeof(TextureResource))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderTexture), Member = "get_antiAliasing", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderGraphResourceRegistry), Member = "GetTextureResourceDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceHandle&), typeof(bool)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 72)]
	[ContainsUnimplementedInstructions]
	public static void set_occlusionMeshScale(float value) { }

}

