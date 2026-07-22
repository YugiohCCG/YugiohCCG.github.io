namespace Spine;

public class AtlasAttachmentLoader : AttachmentLoader
{
	private Atlas[] atlasArray; //Field offset: 0x10

	[CalledBy(Type = typeof(SkeletonLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Atlas[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public AtlasAttachmentLoader(Atlas[] atlasArray) { }

	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(RegionAttachment))]
	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewMeshAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(MeshAttachment))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public AtlasRegion FindRegion(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public override BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public override ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasAttachmentLoader), Member = "FindRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(MeshAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override MeshAttachment NewMeshAttachment(Skin skin, string name, string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public override PathAttachment NewPathAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override PointAttachment NewPointAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AtlasAttachmentLoader), Member = "FindRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AtlasRegion))]
	[Calls(Type = typeof(RegionAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public override RegionAttachment NewRegionAttachment(Skin skin, string name, string path) { }

}

