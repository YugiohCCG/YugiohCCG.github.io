namespace Spine;

public class PathConstraint : IUpdatable
{
	private const int NONE = -1; //Field offset: 0x0
	private const int BEFORE = -2; //Field offset: 0x0
	private const int AFTER = -3; //Field offset: 0x0
	private const float Epsilon = 1E-05; //Field offset: 0x0
	internal PathConstraintData data; //Field offset: 0x10
	internal ExposedList<Bone> bones; //Field offset: 0x18
	internal Slot target; //Field offset: 0x20
	internal float position; //Field offset: 0x28
	internal float spacing; //Field offset: 0x2C
	internal float mixRotate; //Field offset: 0x30
	internal float mixX; //Field offset: 0x34
	internal float mixY; //Field offset: 0x38
	internal bool active; //Field offset: 0x3C
	internal ExposedList<Single> spaces; //Field offset: 0x40
	internal ExposedList<Single> positions; //Field offset: 0x48
	internal ExposedList<Single> world; //Field offset: 0x50
	internal ExposedList<Single> curves; //Field offset: 0x58
	internal ExposedList<Single> lengths; //Field offset: 0x60
	internal Single[] segments; //Field offset: 0x68

	public override bool Active
	{
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Bone> Bones
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public PathConstraintData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float MixRotate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Position
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Spacing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Slot Target
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 29)]
	public PathConstraint(PathConstraintData data, Skeleton skeleton) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 26)]
	public PathConstraint(PathConstraint constraint, Skeleton skeleton) { }

	[CalledBy(Type = typeof(PathConstraint), Member = "ComputeWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathAttachment), typeof(int), typeof(bool)}, ReturnType = typeof(Single[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void AddAfterPosition(float p, Single[] temp, int i, Single[] output, int o) { }

	[CalledBy(Type = typeof(PathConstraint), Member = "ComputeWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathAttachment), typeof(int), typeof(bool)}, ReturnType = typeof(Single[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void AddBeforePosition(float p, Single[] temp, int i, Single[] output, int o) { }

	[CalledBy(Type = typeof(PathConstraint), Member = "ComputeWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathAttachment), typeof(int), typeof(bool)}, ReturnType = typeof(Single[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, Single[] output, int o, bool tangents) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ArraysFill(Single[] a, int fromIndex, int toIndex, float val) { }

	[CalledBy(Type = typeof(PathConstraint), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(int), typeof(int), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PathConstraint), Member = "AddAfterPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single[]), typeof(int), typeof(Single[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PathConstraint), Member = "AddBeforePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single[]), typeof(int), typeof(Single[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PathConstraint), Member = "AddCurvePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Single[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	private Single[] ComputeWorldPositions(PathAttachment path, int spacesCount, bool tangents) { }

	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	public override bool get_Active() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<Bone> get_Bones() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public PathConstraintData get_Data() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixRotate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixY() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_Position() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Spacing() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Slot get_Target() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_MixRotate(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixX(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_MixY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Position(float value) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_Spacing(float value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Target(Slot value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Spine.ExposedList`1<T>")]
	[Calls(Type = typeof(PathConstraint), Member = "ComputeWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathAttachment), typeof(int), typeof(bool)}, ReturnType = typeof(Single[]))]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Cos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Sin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Bone), Member = "UpdateAppliedTransform", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public override void Update() { }

}

