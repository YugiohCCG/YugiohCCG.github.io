namespace Spine;

public class Triangulator
{
	private readonly ExposedList<ExposedList`1<Single>> convexPolygons; //Field offset: 0x10
	private readonly ExposedList<ExposedList`1<Int32>> convexPolygonsIndices; //Field offset: 0x18
	private readonly ExposedList<Int32> indicesArray; //Field offset: 0x20
	private readonly ExposedList<Boolean> isConcaveArray; //Field offset: 0x28
	private readonly ExposedList<Int32> triangles; //Field offset: 0x30
	private readonly Pool<ExposedList`1<Single>> polygonPool; //Field offset: 0x38
	private readonly Pool<ExposedList`1<Int32>> polygonIndicesPool; //Field offset: 0x40

	[CalledBy(Type = typeof(SkeletonClipping), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Pool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public Triangulator() { }

	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(ClippingAttachment)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Pool`1), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Pool`1), Member = "Obtain", ReturnType = "T")]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public ExposedList<ExposedList`1<Single>> Decompose(ExposedList<Single> verticesArray, ExposedList<Int32> triangles) { }

	[CalledBy(Type = typeof(Triangulator), Member = "Triangulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(Spine.ExposedList`1<System.Int32>))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool IsConcave(int index, int vertexCount, Single[] vertices, Int32[] indices) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool PositiveArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y) { }

	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(ClippingAttachment)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(Triangulator), Member = "IsConcave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Single[]), typeof(Int32[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExposedList`1), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public ExposedList<Int32> Triangulate(ExposedList<Single> verticesArray) { }

	[CallerCount(Count = 0)]
	private static int Winding(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y) { }

}

