namespace UnityEngine.Rendering;

public class BufferedRTHandleSystem : IDisposable
{
	[CompilerGenerated]
	private struct <>c__DisplayClass12_0
	{
		public BufferedRTHandleSystem <>4__this; //Field offset: 0x0
		public GraphicsFormat format; //Field offset: 0x8

	}

	private Dictionary<Int32, RTHandle[]> m_RTHandles; //Field offset: 0x10
	private RTHandleSystem m_RTHandleSystem; //Field offset: 0x18
	private bool m_DisposedValue; //Field offset: 0x20

	public int maxHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public int maxWidth
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 26
	}

	public RTHandleProperties rtHandleProperties
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 49
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraHistory", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public BufferedRTHandleSystem() { }

	[CalledBy(Type = typeof(BufferedRTHandleSystem), Member = "AllocBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_enableRandomWrite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useMipMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_autoGenerateMips", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_bindMS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScale", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "get_useDynamicScaleExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(int), typeof(FilterMode), typeof(TextureWrapMode), typeof(TextureDimension), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(int), typeof(float), typeof(MSAASamples), typeof(bool), typeof(bool), typeof(bool), typeof(RenderTextureMemoryless), typeof(VRTextureUsage), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private RTHandle <AllocBuffer>g__Alloc|12_0(ref RenderTextureDescriptor d, FilterMode fMode, TextureWrapMode wMode, bool isShadow, int aniso, float mipBias, string n, ref <>c__DisplayClass12_0 unnamed_param_7) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = "SwitchResizeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ResizeMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void AllocBuffer(int bufferId, Func<RTHandleSystem, Int32, RTHandle> allocator, int bufferCount) { }

	[CalledBy(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "GetFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "<AllocBuffer>g__Alloc|12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string), typeof(<>c__DisplayClass12_0&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RTHandleSystem), Member = "SwitchResizeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ResizeMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void AllocBuffer(int bufferId, int bufferCount, ref RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandleSystem), Member = "CalculateRatioAgainstMaxSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int&)}, ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(ClearFlag), typeof(Color), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ClearBuffers(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "ReleaseAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "ReleaseAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_maxHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int get_maxWidth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public RTHandleProperties get_rtHandleProperties() { }

	[CalledBy(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(CameraHistoryItem), Member = "GetPreviousFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "GetPreviousTexture", ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "IsAllocated", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 2)]
	public RTHandle GetFrameRT(int bufferId, int frameIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumFramesAllocated(int bufferId) { }

	[CalledBy(Type = typeof(BufferedRTHandleSystem), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BufferedRTHandleSystem), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraHistory", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void ReleaseAll() { }

	[CalledBy(Type = typeof(CameraHistoryItem), Member = "ReleaseHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void ReleaseBuffer(int bufferId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTHandleSystem), Member = "ResetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ResetReferenceSize(int width, int height) { }

	[CalledBy(Type = typeof(BufferedRTHandleSystem), Member = "SwapAndSetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleSystem), Member = "SwitchResizeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(ResizeMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	private void Swap() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraHistory", Member = "SwapAndSetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "UpdateCameraHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "Swap", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleSystem), Member = "SetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void SwapAndSetReferenceSize(int width, int height) { }

}

