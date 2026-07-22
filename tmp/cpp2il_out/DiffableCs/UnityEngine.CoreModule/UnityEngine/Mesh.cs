namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr; //Field offset: 0x0

	}


	public Bounds bounds
	{
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 148
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "get_debugMesh", ReturnType = typeof(Mesh))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	internal bool canAccess
	{
		[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
		[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
		[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int), typeof(VertexAttributeFormat)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("CanAccessFromScript")]
		internal get { } //Length: 118
	}

	public Color[] colors
	{
		[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public Color32[] colors32
	{
		[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
		 get { } //Length: 80
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 105
	}

	public IndexFormat indexFormat
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateSphereMesh", ReturnType = typeof(Mesh))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateHemisphereMesh", ReturnType = typeof(Mesh))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public Vector3[] normals
	{
		[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
		 get { } //Length: 62
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public int subMeshCount
	{
		[CalledBy(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod(Name = "GetSubMeshCount")]
		 get { } //Length: 118
		[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
		 set { } //Length: 131
	}

	public Vector4[] tangents
	{
		[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
		 get { } //Length: 62
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public Int32[] triangles
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateHemisphereMesh", ReturnType = typeof(Mesh))]
		[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "CreateCubeMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Mesh))]
		[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateSphereMesh", ReturnType = typeof(Mesh))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessIndices", ReturnType = typeof(void))]
		[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 5)]
		 set { } //Length: 348
	}

	public Vector2[] uv
	{
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public Vector2[] uv2
	{
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public Vector2[] uv3
	{
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 86
	}

	public int vertexCount
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetVertexCount")]
		 get { } //Length: 118
	}

	public Vector3[] vertices
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
		 get { } //Length: 59
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
		 set { } //Length: 83
	}

	[CallerCount(Count = 33)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	public Mesh() { }

	[CalledBy(Type = typeof(Mesh), Member = "CheckCanAccessSubmeshIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessIndices", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	[CalledBy(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTrianglesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndexFormat), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshRendererBuffers+SmartMesh", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.MeshAttachment", "Spine.SkeletonData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.RegionAttachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshRendererBuffers", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Bounds get_bounds() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int), typeof(VertexAttributeFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("CanAccessFromScript")]
	internal bool get_canAccess() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_canAccess_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
	public Color32[] get_colors32() { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	public Vector3[] get_normals() { }

	[CalledBy(Type = typeof(Graphics), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock), typeof(ShadowCastingMode), typeof(bool), typeof(int), typeof(Camera), typeof(LightProbeUsage), typeof(LightProbeProxyVolume)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstanced", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(Matrix4x4[]), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedProcedural", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(ComputeBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "DrawMeshInstancedIndirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(Material), typeof(int), typeof(GraphicsBuffer), typeof(int), typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "GetSubMeshCount")]
	public int get_subMeshCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_subMeshCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	public Vector4[] get_tangents() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetVertexCount")]
	public int get_vertexCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_vertexCount_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	public Vector3[] get_vertices() { }

	[CalledBy(Type = typeof(Mesh), Member = "get_colors32", ReturnType = typeof(Color32[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannelImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[CalledBy(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
	[CalledBy(Type = typeof(Mesh), Member = "get_normals", ReturnType = typeof(Vector3[]))]
	[CalledBy(Type = typeof(Mesh), Member = "get_tangents", ReturnType = typeof(Vector4[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannelImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = typeof(Array))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int), typeof(VertexAttributeFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public uint GetIndexCount(int submesh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	private uint GetIndexCountImpl(int submesh) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetIndexCountImpl_Injected(IntPtr _unity_self, int submesh) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "GetIndicesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	[ExcludeFromDocs]
	public Int32[] GetIndices(int submesh) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "GetIndicesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, out BlittableArrayWrapper ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "EnsureListElemCount", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "GetArrayFromChannelImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "EnsureListElemCount", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "GetArrayFromChannelImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	[CalledBy(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	public void GetUVs(int channel, List<Vector4> uvs) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "GetUVChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VertexAttribute))]
	[Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "EnsureListElemCount", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "GetArrayFromChannelImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int), typeof(VertexAttributeFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create(Mesh mono) { }

	[CalledBy(Type = "Spine.Unity.MeshRendererBuffers+SmartMesh", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineMesh", Member = "NewSkeletonMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void MarkDynamic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MarkDynamicImpl_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = "T[]")]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int), typeof(VertexAttributeFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch) { }

	[CalledBy(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	private void PrintErrorCantAccessIndices() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.MeshAttachment", "Spine.SkeletonData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.RegionAttachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformMultipleRenderers", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformSingleRenderer", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "MatchRectTransformWithBounds", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateGeometry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateGeometry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public void RecalculateBounds() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void RecalculateNormals(MeshUpdateFlags flags) { }

	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public void RecalculateNormals() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("RecalculateNormals")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RecalculateNormalsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "get_debugMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "TryCreateDebugRenderData", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_bounds(Bounds value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_bounds_Injected(IntPtr _unity_self, in Bounds value) { }

	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_colors(Color[] value) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_colors32(Color32[] value) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateSphereMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateHemisphereMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_indexFormat(IndexFormat value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_indexFormat_Injected(IntPtr _unity_self, IndexFormat value) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_normals(Vector3[] value) { }

	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	public void set_subMeshCount(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_subMeshCount_Injected(IntPtr _unity_self, int value) { }

	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_tangents(Vector4[] value) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateSphereMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.CoreUtils", Member = "CreateCubeMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateFullscreenMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MeshInfo", Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "CreateHemisphereMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessIndices", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void set_triangles(Int32[] value) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugShapes", Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Blitter", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader), typeof(Shader)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Mesh), typeof(Material&), typeof(float)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_uv(Vector2[] value) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_uv2(Vector2[] value) { }

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_uv3(Vector2[] value) { }

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void set_vertices(Vector3[] value) { }

	[CalledBy(Type = typeof(Mesh), Member = "set_colors32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }

	[CalledBy(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_tangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_uv3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_colors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetColors(List<Color32> inColors, int start, int length) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.RegionAttachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.MeshAttachment", "Spine.SkeletonData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetColors(List<Color32> inColors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetColors(List<Color> inColors, int start, int length) { }

	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetColors(List<Color> inColors) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XROcclusionMesh", Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "get_fullscreenMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[CalledBy(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetNormals(List<Vector3> inNormals) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[CalledBy(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUvsImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 28)]
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetTangents(List<Vector4> inTangents) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetTrianglesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndexFormat), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "SetTrianglesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndexFormat), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetTrianglesImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IndexFormat), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.RegionAttachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.MeshAttachment", "Spine.SkeletonData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "get_fullscreenMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.RegionAttachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.MeshAttachment", "Spine.SkeletonData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetUVs(int channel, List<Vector2> uvs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	[CalledBy(Type = "TMPro.TMP_SpriteAnimator+<DoSpriteAnimationInternal>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void SetUVs(int channel, Vector4[] uvs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Mesh), Member = "GetUVChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VertexAttribute))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Material), typeof(MeshTopology), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.MeshGizmo", Member = "RenderWireframe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(CompareFunction), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "get_fullscreenMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.BaseMeshEffect", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.RegionAttachment"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "FillMeshLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), "Spine.MeshAttachment", "Spine.SkeletonData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	public void SetVertices(List<Vector3> inVertices) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "get_fullscreenMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void UploadMeshData(bool markNoLongerReadable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("UploadMeshData")]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UploadMeshDataImpl_Injected(IntPtr _unity_self, bool markNoLongerReadable) { }

}

