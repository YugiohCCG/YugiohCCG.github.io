namespace Spine;

public class TransformConstraint : IUpdatable
{
	internal TransformConstraintData data; //Field offset: 0x10
	internal ExposedList<Bone> bones; //Field offset: 0x18
	internal Bone target; //Field offset: 0x20
	internal float mixRotate; //Field offset: 0x28
	internal float mixX; //Field offset: 0x2C
	internal float mixY; //Field offset: 0x30
	internal float mixScaleX; //Field offset: 0x34
	internal float mixScaleY; //Field offset: 0x38
	internal float mixShearY; //Field offset: 0x3C
	internal bool active; //Field offset: 0x40

	public override bool Active
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Bone> Bones
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public TransformConstraintData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float MixRotate
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixScaleY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixShearY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
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
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Skeleton), Member = "FindBone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Bone))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public TransformConstraint(TransformConstraintData data, Skeleton skeleton) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public TransformConstraint(TransformConstraint constraint, Skeleton skeleton) { }

	[CalledBy(Type = typeof(TransformConstraint), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void ApplyAbsoluteLocal() { }

	[CalledBy(Type = typeof(TransformConstraint), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Cos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Sin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Bone), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Bone), Member = "UpdateAppliedTransform", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private void ApplyAbsoluteWorld() { }

	[CalledBy(Type = typeof(TransformConstraint), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bone), Member = "UpdateWorldTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyRelativeLocal() { }

	[CalledBy(Type = typeof(TransformConstraint), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MathUtils), Member = "Atan2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Cos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "Sin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Bone), Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Bone), Member = "UpdateAppliedTransform", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void ApplyRelativeWorld() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override bool get_Active() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<Bone> get_Bones() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public TransformConstraintData get_Data() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_MixRotate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixScaleX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixScaleY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixShearY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixY() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Bone get_Target() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixRotate(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixScaleX(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_MixScaleY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixShearY(float value) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_MixX(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_MixY(float value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Target(Bone value) { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteWorld", ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformConstraint), Member = "ApplyRelativeWorld", ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformConstraint), Member = "ApplyAbsoluteLocal", ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformConstraint), Member = "ApplyRelativeLocal", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Update() { }

}

