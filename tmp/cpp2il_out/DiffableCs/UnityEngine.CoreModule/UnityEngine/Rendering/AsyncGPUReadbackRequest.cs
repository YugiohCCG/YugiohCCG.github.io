namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest
{
	internal IntPtr m_Ptr; //Field offset: 0x0
	internal int m_Version; //Field offset: 0x8

	public bool done
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 51
	}

	public bool hasError
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 51
	}

	public int layerCount
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 51
	}

	public int layerDataSize
	{
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 51
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_done() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool get_hasError() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int get_layerCount() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int get_layerDataSize() { }

	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "BufferReadComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncGPUReadbackRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceOcclusionEventDebugArray", Member = "MoveToDebugStatsAndClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "GetDataRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public NativeArray<T> GetData(int layer = 0) { }

	[CalledBy(Type = typeof(AsyncGPUReadbackRequest), Member = "GetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private IntPtr GetDataRaw(int layer) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetLayerCount() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetLayerDataSize() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private bool HasError() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private bool IsDone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "SetShaderDebugPrintBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager", Member = "PrintImmediate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceOcclusionEventDebugArray", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void WaitForCompletion() { }

}

