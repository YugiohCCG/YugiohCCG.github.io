namespace Spine;

public abstract class SkeletonLoader
{
	internal class LinkedMesh
	{
		internal string parent; //Field offset: 0x10
		internal string skin; //Field offset: 0x18
		internal int slotIndex; //Field offset: 0x20
		internal MeshAttachment mesh; //Field offset: 0x28
		internal bool inheritDeform; //Field offset: 0x30

		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
		[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(Skin), typeof(int), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public LinkedMesh(MeshAttachment mesh, string skin, int slotIndex, string parent, bool inheritDeform) { }

	}

	protected readonly AttachmentLoader attachmentLoader; //Field offset: 0x10
	protected float scale; //Field offset: 0x18
	protected readonly List<LinkedMesh> linkedMeshes; //Field offset: 0x20

	public float Scale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(AttachmentLoader), typeof(float)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AttachmentLoader), typeof(float)}, ReturnType = typeof(SkeletonData))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 139
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Atlas[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonJson), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Atlas[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AtlasAttachmentLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Atlas[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public SkeletonLoader(Atlas[] atlasArray) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentLoader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonJson), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentLoader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public SkeletonLoader(AttachmentLoader attachmentLoader) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Scale() { }

	public abstract SkeletonData ReadSkeletonData(string path) { }

	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(AttachmentLoader), typeof(float)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AttachmentLoader), typeof(float)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public void set_Scale(float value) { }

}

