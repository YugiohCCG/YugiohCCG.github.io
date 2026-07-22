namespace Spine;

public abstract class VertexAttachment : Attachment
{
	private static int nextID; //Field offset: 0x0
	private static readonly object nextIdLock; //Field offset: 0x8
	internal readonly int id; //Field offset: 0x18
	internal Int32[] bones; //Field offset: 0x20
	internal Single[] vertices; //Field offset: 0x28
	internal int worldVerticesLength; //Field offset: 0x30
	internal VertexAttachment deformAttachment; //Field offset: 0x38

	public Int32[] Bones
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public VertexAttachment DeformAttachment
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int Id
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Single[] Vertices
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int WorldVerticesLength
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static VertexAttachment() { }

	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewBoundingBoxAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string)}, ReturnType = typeof(BoundingBoxAttachment))]
	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewPathAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string)}, ReturnType = typeof(PathAttachment))]
	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewClippingAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string)}, ReturnType = typeof(ClippingAttachment))]
	[CalledBy(Type = typeof(BoundingBoxAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoundingBoxAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(ClippingAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClippingAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(MeshAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public VertexAttachment(string name) { }

	[CalledBy(Type = typeof(SkeletonBounds), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "BuildMeshWithArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetLocalVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment), typeof(Slot), "UnityEngine.Vector2[]"}, ReturnType = "UnityEngine.Vector2[]")]
	[CalledBy(Type = "Spine.Unity.SkeletonExtensions", Member = "GetWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment), typeof(Slot), "UnityEngine.Vector2[]"}, ReturnType = "UnityEngine.Vector2[]")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(int), typeof(int), typeof(Single[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public void ComputeWorldVertices(Slot slot, Single[] worldVertices) { }

	[CalledBy(Type = typeof(VertexAttachment), Member = "ComputeWorldVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(Single[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = "ComputeWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathAttachment), typeof(int), typeof(bool)}, ReturnType = typeof(Single[]))]
	[CalledBy(Type = typeof(Skeleton), Member = "GetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Single&), typeof(Single&), typeof(Single&), typeof(Single[]&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(ClippingAttachment)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	public void ComputeWorldVertices(Slot slot, int start, int count, Single[] worldVertices, int offset, int stride = 2) { }

	[CalledBy(Type = typeof(BoundingBoxAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(ClippingAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(MeshAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(PathAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal void CopyTo(VertexAttachment attachment) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Int32[] get_Bones() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public VertexAttachment get_DeformAttachment() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Id() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Single[] get_Vertices() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_WorldVerticesLength() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Bones(Int32[] value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DeformAttachment(VertexAttachment value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Vertices(Single[] value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_WorldVerticesLength(int value) { }

}

