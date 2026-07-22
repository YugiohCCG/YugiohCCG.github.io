namespace UnityEngine.UI;

public class VertexHelper : IDisposable
{
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x0
	private static readonly Vector3 s_DefaultNormal; //Field offset: 0x10
	private List<Vector3> m_Positions; //Field offset: 0x10
	private List<Color32> m_Colors; //Field offset: 0x18
	private List<Vector4> m_Uv0S; //Field offset: 0x20
	private List<Vector4> m_Uv1S; //Field offset: 0x28
	private List<Vector4> m_Uv2S; //Field offset: 0x30
	private List<Vector4> m_Uv3S; //Field offset: 0x38
	private List<Vector3> m_Normals; //Field offset: 0x40
	private List<Vector4> m_Tangents; //Field offset: 0x48
	private List<Int32> m_Indices; //Field offset: 0x50
	private bool m_ListsInitalized; //Field offset: 0x58

	public int currentIndexCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 65
	}

	public int currentVertCount
	{
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		 get { } //Length: 65
	}

	[CallerCount(Count = 0)]
	private static VertexHelper() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public VertexHelper() { }

	[CalledBy(Type = typeof(BaseMeshEffect), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_colors32", ReturnType = typeof(Color32[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "GetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_normals", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Mesh), Member = "get_tangents", ReturnType = typeof(Vector4[]))]
	[Calls(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public VertexHelper(Mesh m) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddUIVertexQuad(UIVertex[] verts) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddUIVertexStream(List<UIVertex> verts, List<Int32> indices) { }

	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SplitUIVertexStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	public void AddVert(UIVertex v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.NonDrawingGraphic", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonSubmeshGraphic", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public override void Dispose() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UnityEngine.UI.IMeshModifier.ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void FillMesh(Mesh mesh) { }

	[CallerCount(Count = 0)]
	public int get_currentIndexCount() { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	public int get_currentVertCount() { }

	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public void GetUIVertexStream(List<UIVertex> stream) { }

	[CalledBy(Type = typeof(VertexHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "PopulateUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexTriangleStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "GetUIVertexStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseMeshEffect), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[CallsUnknownMethods(Count = 9)]
	private void InitializeListIfRequired() { }

	[CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	[CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void SetUIVertex(UIVertex vertex, int i) { }

}

