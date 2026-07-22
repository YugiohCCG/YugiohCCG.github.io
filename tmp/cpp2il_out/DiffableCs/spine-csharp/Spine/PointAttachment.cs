namespace Spine;

public class PointAttachment : Attachment
{
	internal float x; //Field offset: 0x18
	internal float y; //Field offset: 0x1C
	internal float rotation; //Field offset: 0x20

	public float Rotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public PointAttachment(string name) { }

	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetWorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAttachment), typeof(Slot), "UnityEngine.Transform"}, ReturnType = "UnityEngine.Vector3")]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetWorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointAttachment), typeof(Bone), "UnityEngine.Transform"}, ReturnType = "UnityEngine.Vector3")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void ComputeWorldPosition(Bone bone, out float ox, out float oy) { }

	[CalledBy(Type = "Spine.Unity.PointFollower", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public float ComputeWorldRotation(Bone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public virtual Attachment Copy() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Rotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Rotation(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_X(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Y(float value) { }

}

