namespace Spine;

public class SkeletonClipping
{
	internal readonly Triangulator triangulator; //Field offset: 0x10
	internal readonly ExposedList<Single> clippingPolygon; //Field offset: 0x18
	internal readonly ExposedList<Single> clipOutput; //Field offset: 0x20
	internal readonly ExposedList<Single> clippedVertices; //Field offset: 0x28
	internal readonly ExposedList<Int32> clippedTriangles; //Field offset: 0x30
	internal readonly ExposedList<Single> clippedUVs; //Field offset: 0x38
	internal readonly ExposedList<Single> scratch; //Field offset: 0x40
	internal ClippingAttachment clipAttachment; //Field offset: 0x48
	internal ExposedList<ExposedList`1<Single>> clippingPolygons; //Field offset: 0x50

	public ExposedList<Int32> ClippedTriangles
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Single> ClippedUVs
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Single> ClippedVertices
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsClipping
	{
		[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 9
	}

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Triangulator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public SkeletonClipping() { }

	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int), typeof(Int32[]), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool Clip(float x1, float y1, float x2, float y2, float x3, float y3, ExposedList<Single> clippingArea, ExposedList<Single> output) { }

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void ClipEnd(Slot slot) { }

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "Begin", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void ClipEnd() { }

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(int), typeof(int), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "MakeClockwise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Triangulator), Member = "Triangulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(Spine.ExposedList`1<System.Int32>))]
	[Calls(Type = typeof(Triangulator), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>), typeof(Spine.ExposedList`1<System.Int32>)}, ReturnType = typeof(Spine.ExposedList`1<Spine.ExposedList`1<System.Single>>))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public int ClipStart(Slot slot, ClippingAttachment clip) { }

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonClipping), Member = "Clip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Spine.ExposedList`1<System.Single>), typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	public void ClipTriangles(Single[] vertices, int verticesLength, Int32[] triangles, int trianglesLength, Single[] uvs) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public ExposedList<Int32> get_ClippedTriangles() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public ExposedList<Single> get_ClippedUVs() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public ExposedList<Single> get_ClippedVertices() { }

	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsClipping() { }

	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(ClippingAttachment)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void MakeClockwise(ExposedList<Single> polygon) { }

}

