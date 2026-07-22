namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
public struct LocalKeyword : IEquatable<LocalKeyword>
{
	internal readonly LocalKeywordSpace m_SpaceInfo; //Field offset: 0x0
	internal readonly string m_Name; //Field offset: 0x8
	internal readonly uint m_Index; //Field offset: 0x10

	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "get_keywordSpace", ReturnType = typeof(LocalKeywordSpace))]
	[Calls(Type = typeof(LocalKeyword), Member = "GetShaderKeywordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public LocalKeyword(Shader shader, string name) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUSort", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUSort+SystemResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "AddOcclusionCullingDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OcclusionCullingSettings&", "UnityEngine.Rendering.InstanceOcclusionTestSubviewSettings&", "UnityEngine.Rendering.IndirectBufferContextHandles&", "UnityEngine.Rendering.OccluderHandles&", "UnityEngine.Rendering.RenderersBatchersContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OccluderContext", Member = "CreateFarDepthPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ComputeCommandBuffer", "UnityEngine.Rendering.OccluderParameters&", "System.ReadOnlySpan`1<OccluderSubviewUpdate>", "UnityEngine.Rendering.OccluderHandles&", "Unity.Collections.NativeArray`1<Plane>", typeof(ComputeShader), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionTestComputeShader", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "get_keywordSpace", ReturnType = typeof(LocalKeywordSpace))]
	[Calls(Type = typeof(LocalKeyword), Member = "GetComputeShaderKeywordIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public LocalKeyword(ComputeShader shader, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(LocalKeyword rhs) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ShaderScripting::GetKeywordCount")]
	private static uint GetComputeShaderKeywordCount(ComputeShader shader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetComputeShaderKeywordCount_Injected(IntPtr shader) { }

	[CalledBy(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	private static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetComputeShaderKeywordIndex_Injected(IntPtr shader, ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ShaderScripting::GetKeywordCount")]
	private static uint GetShaderKeywordCount(Shader shader) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetShaderKeywordCount_Injected(IntPtr shader) { }

	[CalledBy(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	private static uint GetShaderKeywordIndex(Shader shader, string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetShaderKeywordIndex_Injected(IntPtr shader, ref ManagedSpanWrapper keyword) { }

	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

