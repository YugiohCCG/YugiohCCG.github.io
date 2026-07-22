namespace Spine;

public class IkConstraint : IUpdatable
{
	internal IkConstraintData data; //Field offset: 0x10
	internal ExposedList<Bone> bones; //Field offset: 0x18
	internal Bone target; //Field offset: 0x20
	internal int bendDirection; //Field offset: 0x28
	internal bool compress; //Field offset: 0x2C
	internal bool stretch; //Field offset: 0x2D
	internal float mix; //Field offset: 0x30
	internal float softness; //Field offset: 0x34
	internal bool active; //Field offset: 0x38

	public override bool Active
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int BendDirection
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ExposedList<Bone> Bones
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Compress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public IkConstraintData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Mix
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Softness
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool Stretch
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Bone Target
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	public IkConstraint(IkConstraintData data, Skeleton skeleton) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 21)]
	public IkConstraint(IkConstraint constraint, Skeleton skeleton) { }

	[CalledBy(Type = typeof(IkConstraint), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraint), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Bone), typeof(float), typeof(float), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public static void Apply(Bone bone, float targetX, float targetY, bool compress, bool stretch, bool uniform, float alpha) { }

	[CalledBy(Type = typeof(IkConstraint), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IkConstraint), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	public static void Apply(Bone parent, Bone child, float targetX, float targetY, int bendDir, bool stretch, bool uniform, float softness, float alpha) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_Active() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_BendDirection() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<Bone> get_Bones() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Compress() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public IkConstraintData get_Data() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Mix() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Softness() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Stretch() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Bone get_Target() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_BendDirection(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Compress(bool value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Mix(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Softness(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Stretch(bool value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Target(Bone value) { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IkConstraint), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(float), typeof(float), typeof(bool), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IkConstraint), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bone), typeof(Bone), typeof(float), typeof(float), typeof(int), typeof(bool), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override void Update() { }

}

