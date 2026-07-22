namespace Spine;

public class RegionAttachment : Attachment, IHasRendererObject
{
	public const int BLX = 0; //Field offset: 0x0
	public const int BLY = 1; //Field offset: 0x0
	public const int ULX = 2; //Field offset: 0x0
	public const int ULY = 3; //Field offset: 0x0
	public const int URX = 4; //Field offset: 0x0
	public const int URY = 5; //Field offset: 0x0
	public const int BRX = 6; //Field offset: 0x0
	public const int BRY = 7; //Field offset: 0x0
	internal float x; //Field offset: 0x18
	internal float y; //Field offset: 0x1C
	internal float rotation; //Field offset: 0x20
	internal float scaleX; //Field offset: 0x24
	internal float scaleY; //Field offset: 0x28
	internal float width; //Field offset: 0x2C
	internal float height; //Field offset: 0x30
	internal float regionOffsetX; //Field offset: 0x34
	internal float regionOffsetY; //Field offset: 0x38
	internal float regionWidth; //Field offset: 0x3C
	internal float regionHeight; //Field offset: 0x40
	internal float regionOriginalWidth; //Field offset: 0x44
	internal float regionOriginalHeight; //Field offset: 0x48
	internal Single[] offset; //Field offset: 0x50
	internal Single[] uvs; //Field offset: 0x58
	internal float r; //Field offset: 0x60
	internal float g; //Field offset: 0x64
	internal float b; //Field offset: 0x68
	internal float a; //Field offset: 0x6C
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private object <RendererObject>k__BackingField; //Field offset: 0x78

	public float A
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float B
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float G
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Height
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Single[] Offset
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Path
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float R
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionHeight
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOffsetX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOffsetY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOriginalHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOriginalWidth
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public override object RendererObject
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float Rotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ScaleY
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Single[] UVs
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Width
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
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

	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(RegionAttachment))]
	[CalledBy(Type = typeof(RegionAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "NewRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(RegionAttachment))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public RegionAttachment(string name) { }

	[CalledBy(Type = typeof(Skeleton), Member = "GetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Single&), typeof(Single&), typeof(Single&), typeof(Single[]&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "AddSubmesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SubmeshInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "BuildMeshWithArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void ComputeWorldVertices(Bone bone, Single[] worldVertices, int offset, int stride = 2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual Attachment Copy() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_A() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_B() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Height() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public Single[] get_Offset() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Path() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_R() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_RegionHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionOffsetX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionOffsetY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionOriginalHeight() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_RegionOriginalWidth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionWidth() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override object get_RendererObject() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Rotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_ScaleX() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_ScaleY() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public Single[] get_UVs() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Width() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_A(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_B(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_G(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Height(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Path(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_R(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionHeight(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionOffsetX(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_RegionOffsetY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionOriginalHeight(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionOriginalWidth(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionWidth(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_RendererObject(object value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Rotation(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ScaleX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ScaleY(float value) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_Width(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_X(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Y(float value) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegionAttachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void SetUVs(float u, float v, float u2, float v2, int degrees) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(Skin), typeof(int), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegionAttachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AtlasRegion), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(RegionAttachment))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void UpdateOffset() { }

}

