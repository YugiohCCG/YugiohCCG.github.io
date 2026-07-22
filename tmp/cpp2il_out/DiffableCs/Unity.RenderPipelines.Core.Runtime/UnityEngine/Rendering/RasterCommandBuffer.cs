namespace UnityEngine.Rendering;

public class RasterCommandBuffer : BaseCommandBuffer, IRasterCommandBuffer, IBaseCommandBuffer
{

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetExecutionFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBufferExecutionFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal RasterCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void BeginSample(ProfilerMarker marker) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void BeginSample(CustomSampler sampler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void BeginSample(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(Color), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth, uint stencil) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTClearFlags), typeof(Color), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "ClearRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTClearFlags), typeof(Color[]), typeof(float), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth, uint stencil) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "ConfigureFoveatedRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void ConfigureFoveatedRendering(IntPtr platformData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableScissorRect", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DisableScissorRect() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DisableShaderKeyword(string keyword) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMultipleMeshes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4[]), typeof(Mesh[]), typeof(Int32[]), typeof(int), typeof(Material), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawProceduralIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(int), typeof(MeshTopology), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Renderer), typeof(Material)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawRenderer(Renderer renderer, Material material) { }

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawRendererList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RendererList)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void DrawRendererList(RendererList rendererList) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableScissorRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EnableScissorRect(Rect scissor) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EnableShaderKeyword(string keyword) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void EndSample(ProfilerMarker marker) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndSample(CustomSampler sampler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndSample(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "IncrementUpdateCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "InvokeOnRenderObjectCallbacks", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void InvokeOnRenderObjectCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "IssuePluginCustomBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(uint), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "IssuePluginCustomTextureUpdateV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Texture), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "IssuePluginEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void IssuePluginEvent(IntPtr callback, int eventID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "IssuePluginEventAndData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "MarkLateLatchMatrixShaderPropertyID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetFoveatedRenderingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FoveatedRenderingMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GraphicsBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalColor(string name, Color value) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalColor(int nameID, Color value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalConstantBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsBuffer), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalDepthBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalDepthBias(float bias, float slopeBias) { }

	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalFloat(int nameID, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalFloat(string name, float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalFloatArray(int nameID, Single[] values) { }

	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalInt(int nameID, int value) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalInt(string name, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalInteger(string name, int value) { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalInteger(int nameID, int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Matrix4x4>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetGlobalTexture(string name, TextureHandle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetGlobalTexture(int nameID, TextureHandle value, RenderTextureSubElement element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier), typeof(RenderTextureSubElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetGlobalTexture(string name, TextureHandle value, RenderTextureSubElement element) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugHandler", Member = "UpdateShaderGlobalPropertiesForFinalValidationPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), "UnityEngine.Rendering.Universal.DebugHandler+DebugFinalValidationPassData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetGlobalTexture(int nameID, TextureHandle value) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalVector(string name, Vector4 value) { }

	[CallerCount(Count = 70)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalVector(int nameID, Vector4 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetInstanceMultiplier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetInstanceMultiplier(uint multiplier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetInvertCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetInvertCulling(bool invertCulling) { }

	[CallerCount(Count = 109)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetLateLatchProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetShadowSamplingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(ShadowSamplingMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetupCameraProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetupCameraProperties(Camera camera) { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetViewport(Rect pixelRect) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetViewProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void SetWireframe(bool enable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(in GlobalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(Material material, in LocalKeyword keyword) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(in GlobalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(Material material, in LocalKeyword keyword) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 109)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(in GlobalKeyword keyword, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(LocalKeyword&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CommandBuffer), Member = "UnmarkLateLatchMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraLateLatchMatrixType)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

}

