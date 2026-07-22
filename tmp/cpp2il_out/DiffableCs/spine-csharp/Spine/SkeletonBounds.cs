namespace Spine;

public class SkeletonBounds
{
	private ExposedList<Polygon> polygonPool; //Field offset: 0x10
	private float minX; //Field offset: 0x18
	private float minY; //Field offset: 0x1C
	private float maxX; //Field offset: 0x20
	private float maxY; //Field offset: 0x24
	[CompilerGenerated]
	private ExposedList<BoundingBoxAttachment> <BoundingBoxes>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ExposedList<Polygon> <Polygons>k__BackingField; //Field offset: 0x30

	public private ExposedList<BoundingBoxAttachment> BoundingBoxes
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public float Height
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
	}

	public float MaxX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MaxY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MinX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MinY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public private ExposedList<Polygon> Polygons
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public float Width
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public SkeletonBounds() { }

	[CalledBy(Type = typeof(SkeletonBounds), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	private void AabbCompute() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool AabbContainsPoint(float x, float y) { }

	[CallerCount(Count = 0)]
	public bool AabbIntersectsSegment(float x1, float y1, float x2, float y2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool AabbIntersectsSkeleton(SkeletonBounds bounds) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public BoundingBoxAttachment ContainsPoint(float x, float y) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool ContainsPoint(Polygon polygon, float x, float y) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ExposedList<BoundingBoxAttachment> get_BoundingBoxes() { }

	[CallerCount(Count = 0)]
	public float get_Height() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MaxX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MaxY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MinX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MinY() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ExposedList<Polygon> get_Polygons() { }

	[CallerCount(Count = 0)]
	public float get_Width() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public Polygon GetPolygon(BoundingBoxAttachment attachment) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonBounds), Member = "IntersectsSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Polygon), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public BoundingBoxAttachment IntersectsSegment(float x1, float y1, float x2, float y2) { }

	[CalledBy(Type = typeof(SkeletonBounds), Member = "IntersectsSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(BoundingBoxAttachment))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IntersectsSegment(Polygon polygon, float x1, float y1, float x2, float y2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_BoundingBoxes(ExposedList<BoundingBoxAttachment> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MaxX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MaxY(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_MinX(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_MinY(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Polygons(ExposedList<Polygon> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Polygon), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBounds), Member = "AabbCompute", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Update(Skeleton skeleton, bool updateAabb) { }

}

