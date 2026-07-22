namespace UnityEngine.Rendering;

public sealed class ShaderDebugPrintManager
{
	private enum DebugValueType
	{
		TypeUint = 1,
		TypeInt = 2,
		TypeFloat = 3,
		TypeUint2 = 4,
		TypeInt2 = 5,
		TypeFloat2 = 6,
		TypeUint3 = 7,
		TypeInt3 = 8,
		TypeFloat3 = 9,
		TypeUint4 = 10,
		TypeInt4 = 11,
		TypeFloat4 = 12,
		TypeBool = 13,
	}

	private static class Profiling
	{
		public static readonly ProfilingSampler BufferReadComplete; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CustomSampler), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CustomSampler))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Sampler), Member = "GetRecorder", ReturnType = typeof(Recorder))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private static Profiling() { }

	}

	private static readonly ShaderDebugPrintManager s_Instance; //Field offset: 0x0
	private const int k_FramesInFlight = 4; //Field offset: 0x0
	private const int k_MaxBufferElements = 16384; //Field offset: 0x0
	private const uint k_TypeHasTag = 128; //Field offset: 0x0
	private static readonly int m_ShaderPropertyIDInputMouse; //Field offset: 0x8
	private static readonly int m_ShaderPropertyIDInputFrame; //Field offset: 0xC
	private static readonly int m_shaderDebugOutputData; //Field offset: 0x10
	private List<GraphicsBuffer> m_OutputBuffers; //Field offset: 0x10
	private List<AsyncGPUReadbackRequest> m_ReadbackRequests; //Field offset: 0x18
	private Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction; //Field offset: 0x20
	private int m_FrameCounter; //Field offset: 0x28
	private bool m_FrameCleared; //Field offset: 0x2C
	private string m_OutputLine; //Field offset: 0x30
	private Action<String> m_OutputAction; //Field offset: 0x38

	public static ShaderDebugPrintManager instance
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	public Action<String> outputAction
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string outputLine
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderDebugPrintManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private static ShaderDebugPrintManager() { }

	[CalledBy(Type = typeof(ShaderDebugPrintManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GraphicsBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Target), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private ShaderDebugPrintManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "GetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ShaderDebugPrintManager), Member = "DebugValueTypeToElemSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugValueType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 69)]
	private void BufferReadComplete(AsyncGPUReadbackRequest request) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ClearShaderDebugPrintBuffer() { }

	[CalledBy(Type = typeof(ShaderDebugPrintManager), Member = "BufferReadComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncGPUReadbackRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	private int DebugValueTypeToElemSize(DebugValueType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public void DefaultOutput(string line) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncGPUReadback), Member = "Request", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(AsyncGPUReadbackRequest))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void EndFrame() { }

	[CallerCount(Count = 0)]
	public static ShaderDebugPrintManager get_instance() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_outputLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncGPUReadback), Member = "Request", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(System.Action`1<UnityEngine.Rendering.AsyncGPUReadbackRequest>)}, ReturnType = typeof(AsyncGPUReadbackRequest))]
	[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "WaitForCompletion", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void PrintImmediate() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_outputAction(Action<String> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(AsyncGPUReadbackRequest), Member = "WaitForCompletion", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsBuffer), Member = "SetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void SetShaderDebugPrintBindings(CommandBuffer cmd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input) { }

}

