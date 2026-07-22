namespace Spine.Unity;

public class RegionlessAttachmentLoader : AttachmentLoader
{
	private static AtlasRegion emptyRegion; //Field offset: 0x0

	private static AtlasRegion EmptyRegion
	{
		[CalledBy(Type = typeof(RegionlessAttachmentLoader), Member = "NewRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(RegionAttachment))]
		[CalledBy(Type = typeof(RegionlessAttachmentLoader), Member = "NewMeshAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(MeshAttachment))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(AtlasPage), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		private get { } //Length: 469
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RegionlessAttachmentLoader() { }

	[CalledBy(Type = typeof(RegionlessAttachmentLoader), Member = "NewRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(RegionAttachment))]
	[CalledBy(Type = typeof(RegionlessAttachmentLoader), Member = "NewMeshAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(MeshAttachment))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AtlasPage), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static AtlasRegion get_EmptyRegion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoundingBoxAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public override BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClippingAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public override ClippingAttachment NewClippingAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionlessAttachmentLoader), Member = "get_EmptyRegion", ReturnType = typeof(AtlasRegion))]
	[CallsUnknownMethods(Count = 2)]
	public override MeshAttachment NewMeshAttachment(Skin skin, string name, string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PathAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public override PathAttachment NewPathAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override PointAttachment NewPointAttachment(Skin skin, string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegionlessAttachmentLoader), Member = "get_EmptyRegion", ReturnType = typeof(AtlasRegion))]
	[CallsUnknownMethods(Count = 2)]
	public override RegionAttachment NewRegionAttachment(Skin skin, string name, string path) { }

}

