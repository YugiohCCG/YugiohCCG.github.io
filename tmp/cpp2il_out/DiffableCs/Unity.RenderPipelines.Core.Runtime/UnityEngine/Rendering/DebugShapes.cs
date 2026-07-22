namespace UnityEngine.Rendering;

public class DebugShapes
{
	private static DebugShapes s_Instance; //Field offset: 0x0
	private Mesh m_sphereMesh; //Field offset: 0x10
	private Mesh m_boxMesh; //Field offset: 0x18
	private Mesh m_coneMesh; //Field offset: 0x20
	private Mesh m_pyramidMesh; //Field offset: 0x28

	public static DebugShapes instance
	{
		[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_debugMesh", ReturnType = typeof(Mesh))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugShapes() { }

	[CalledBy(Type = typeof(DebugShapes), Member = "BuildShapes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void BuildBox(ref Mesh outputMesh, float length, float width, float height) { }

	[CalledBy(Type = typeof(DebugShapes), Member = "BuildShapes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_debugMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	public Mesh BuildCustomSphereMesh(float radius, uint longSubdiv, uint latSubdiv) { }

	[CalledBy(Type = typeof(DebugShapes), Member = "BuildShapes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void BuildShapes() { }

	[CalledBy(Type = typeof(DebugShapes), Member = "BuildShapes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugShapes), Member = "BuildCustomSphereMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(Mesh))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_normals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv) { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "get_debugMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static DebugShapes get_instance() { }

	[CalledBy(Type = typeof(DebugShapes), Member = "RequestSphereMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RequestBoxMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RequestConeMesh", ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(DebugShapes), Member = "RequestPyramidMesh", ReturnType = typeof(Mesh))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildCone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugShapes), Member = "BuildPyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void RebuildResources() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	public Mesh RequestBoxMesh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	public Mesh RequestConeMesh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	public Mesh RequestPyramidMesh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugShapes), Member = "RebuildResources", ReturnType = typeof(void))]
	public Mesh RequestSphereMesh() { }

}

