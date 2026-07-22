namespace UnityEngine.Experimental.Rendering;

internal class XROcclusionMesh
{
	private static readonly ProfilingSampler k_OcclusionMeshProfilingSampler; //Field offset: 0x0
	private XRPass m_Pass; //Field offset: 0x10
	private Mesh m_CombinedMesh; //Field offset: 0x18
	private Material m_Material; //Field offset: 0x20
	private int m_CombinedMeshHashCode; //Field offset: 0x28

	internal bool hasValidOcclusionMesh
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XROcclusionMesh), Member = "IsOcclusionMeshSupported", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "GetOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 191
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static XROcclusionMesh() { }

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XROcclusionMesh(XRPass xrPass) { }

	[CalledBy(Type = typeof(XROcclusionMesh), Member = "UpdateCombinedMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_indexFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IndexFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "GetIndexCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void CreateOcclusionMeshCombined() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "IsOcclusionMeshSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal bool get_hasValidOcclusionMesh() { }

	[CalledBy(Type = typeof(XROcclusionMesh), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XROcclusionMesh), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XROcclusionMesh), Member = "UpdateCombinedMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRPass), Member = "get_hasValidOcclusionMesh", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private bool IsOcclusionMeshSupported() { }

	[CalledBy(Type = typeof(XRPass), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRPass), Member = "RenderOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "IsOcclusionMeshSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "GetOcclusionMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EnableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "Scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CommandBuffer), Member = "DisableShaderKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "StopSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XRPass), Member = "StartSinglePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	internal void RenderOcclusionMesh(CommandBuffer cmd, float occlusionMeshScale, bool yFlip = false) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetMaterial(Material mat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode) { }

	[CalledBy(Type = typeof(XRLayout), Member = "ReconfigurePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPass), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRLayout), Member = "AddPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XRPass), Member = "UpdateCombinedOcclusionMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XROcclusionMesh), Member = "IsOcclusionMeshSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Experimental.Rendering.XRView>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XRView))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XROcclusionMesh), Member = "CreateOcclusionMeshCombined", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void UpdateCombinedMesh() { }

}

