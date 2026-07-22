namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingAccelerationStructure.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[UsedByNativeCode]
public sealed class ComputeShader : object
{

	public LocalKeywordSpace keywordSpace
	{
		[CalledBy(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 138
	}

	public String[] shaderKeywords
	{
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 134
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private ComputeShader() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "PerformBlending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), "UnityEngine.Rendering.ProbeBrickPool"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = True)]
	public void DisableKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader", Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer", "Unity.Collections.NativeArray`1<GPUInstanceIndex>", "GPUResources&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferGrower", Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GPUResources&"}, ReturnType = "UnityEngine.Rendering.GPUInstanceDataBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchMotionUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchTransformUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<TransformUpdatePacket>", "Unity.Collections.NativeArray`1<float4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchWindDataCopyHistoryCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<GPUInstanceIndex>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("DispatchComputeShader")]
	public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Dispatch_Injected(IntPtr _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "PerformBlending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), "UnityEngine.Rendering.ProbeBrickPool"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "Config&"}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = True)]
	public void EnableKeyword(string keyword) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.OcclusionCullingCommon", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), "UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferGrower+GPUResources", Member = "LoadShaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader+GPUResources", Member = "LoadShaders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceCuller", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerResources", "UnityEngine.Rendering.DebugRendererBatcherStats"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ProbeVolumeDebugPass+<>c", Member = "<Render>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ProbeVolumeDebugPass+WriteApvData", "UnityEngine.Rendering.RenderGraphModule.ComputeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUPrefixSum+SystemResources", Member = "LoadKernels", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateBlackUIntTextureArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.STP", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "Config&"}, ReturnType = "UnityEngine.Rendering.RenderGraphModule.TextureHandle")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickBlendingPool", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickPool", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.TextureXR", Member = "CreateBlackUintTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(ComputeShader)}, ReturnType = typeof(Texture))]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	[RequiredByNativeCode]
	public int FindKernel(string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int FindKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[CalledBy(Type = typeof(LocalKeyword), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public LocalKeywordSpace get_keywordSpace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_keywordSpace_Injected(IntPtr _unity_self, out LocalKeywordSpace ret) { }

	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	private void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer) { }

	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = True)]
	private void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_SetGraphicsBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void set_shaderKeywords(String[] value) { }

	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = True)]
	private void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetConstantComputeBuffer_Injected(IntPtr _unity_self, int nameID, IntPtr buffer, int offset, int size) { }

	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(ColorGamut), "UnityEngine.Rendering.HDROutputUtils+Operation"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferUploader", Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUInstanceDataBuffer", "Unity.Collections.NativeArray`1<GPUInstanceIndex>", "GPUResources&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUInstanceDataBufferGrower", Member = "SubmitToGpu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GPUResources&"}, ReturnType = "UnityEngine.Rendering.GPUInstanceDataBuffer")]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchProbeUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<SphericalHarmonicsL2>", "Unity.Collections.NativeArray`1<Vector4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchMotionUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchTransformUpdateCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), "Unity.Collections.NativeArray`1<InstanceHandle>", "Unity.Collections.NativeArray`1<TransformUpdatePacket>", "Unity.Collections.NativeArray`1<float4>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.InstanceDataSystem", Member = "DispatchWindDataCopyHistoryCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<GPUInstanceIndex>", "UnityEngine.Rendering.RenderersParameters", "UnityEngine.Rendering.GPUInstanceDataBuffer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = True)]
	public void SetInt(int nameID, int val) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetInt_Injected(IntPtr _unity_self, int nameID, int val) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "ComputeShaderScripting::SetArray<int>", HasExplicitThis = True)]
	private void SetIntArray(int nameID, Int32[] values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetIntArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void SetInts(int nameID, Int32[] values) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[FreeFunction("ComputeShaderScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(String[] names) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, String[] names) { }

}

