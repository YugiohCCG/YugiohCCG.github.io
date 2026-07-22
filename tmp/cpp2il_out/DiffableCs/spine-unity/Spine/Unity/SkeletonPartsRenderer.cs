namespace Spine.Unity;

[HelpURL("http://esotericsoftware.com/spine-unity#SkeletonRenderSeparator")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class SkeletonPartsRenderer : MonoBehaviour
{
	internal sealed class SkeletonPartsRendererDelegate : MulticastDelegate
	{

		[CallerCount(Count = 60)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public SkeletonPartsRendererDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(SkeletonPartsRenderer skeletonPartsRenderer, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(SkeletonPartsRenderer skeletonPartsRenderer) { }

	}

	private MeshGenerator meshGenerator; //Field offset: 0x20
	private MeshRenderer meshRenderer; //Field offset: 0x28
	private MeshFilter meshFilter; //Field offset: 0x30
	[CompilerGenerated]
	private SkeletonPartsRendererDelegate OnMeshAndMaterialsUpdated; //Field offset: 0x38
	private MeshRendererBuffers buffers; //Field offset: 0x40
	private SkeletonRendererInstruction currentInstructions; //Field offset: 0x48

	public event SkeletonPartsRendererDelegate OnMeshAndMaterialsUpdated
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	public MeshFilter MeshFilter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public MeshGenerator MeshGenerator
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public MeshRenderer MeshRenderer
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SkeletonPartsRenderer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void add_OnMeshAndMaterialsUpdated(SkeletonPartsRendererDelegate value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearMesh() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	public MeshFilter get_MeshFilter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	public MeshGenerator get_MeshGenerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	public MeshRenderer get_MeshRenderer() { }

	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "get_MeshGenerator", ReturnType = typeof(MeshGenerator))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "HandleRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(SkeletonPartsRenderer))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "AddToSkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(SkeletonRenderSeparator))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "NewPartsRendererGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(string), typeof(int)}, ReturnType = typeof(SkeletonPartsRenderer))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "ClearMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "get_MeshFilter", ReturnType = typeof(MeshFilter))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "get_MeshRenderer", ReturnType = typeof(MeshRenderer))]
	[CalledBy(Type = typeof(SkeletonPartsRenderer), Member = "SetPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	private void LazyIntialize() { }

	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "AddToSkeletonRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRenderer), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(SkeletonRenderSeparator))]
	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "AddPartsRenderer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(SkeletonPartsRenderer))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform parent, string name, int sortingOrder = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public void remove_OnMeshAndMaterialsUpdated(SkeletonPartsRendererDelegate value) { }

	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "HandleRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillLateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_subMeshCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "GetUpdatedSharedMaterialsArray", ReturnType = typeof(Material[]))]
	[Calls(Type = typeof(MeshGenerator), Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubmeshInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "FillVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshRendererBuffers), Member = "UpdateSharedMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "BuildMeshWithArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "Begin", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "GeometryNotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction), typeof(SkeletonRendererInstruction)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonRendererInstruction), Member = "SetWithSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Unity.SubmeshInstruction>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DoubleBuffered`1), Member = "GetNext", ReturnType = "T")]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void RenderParts(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh) { }

	[CalledBy(Type = typeof(SkeletonRenderSeparator), Member = "HandleRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonRendererInstruction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonPartsRenderer), Member = "LazyIntialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetPropertyBlock(MaterialPropertyBlock block) { }

}

