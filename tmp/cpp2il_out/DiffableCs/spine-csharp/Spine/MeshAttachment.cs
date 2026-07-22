namespace Spine;

public class MeshAttachment : VertexAttachment, IHasRendererObject
{
	internal float regionOffsetX; //Field offset: 0x40
	internal float regionOffsetY; //Field offset: 0x44
	internal float regionWidth; //Field offset: 0x48
	internal float regionHeight; //Field offset: 0x4C
	internal float regionOriginalWidth; //Field offset: 0x50
	internal float regionOriginalHeight; //Field offset: 0x54
	private MeshAttachment parentMesh; //Field offset: 0x58
	internal Single[] uvs; //Field offset: 0x60
	internal Single[] regionUVs; //Field offset: 0x68
	internal Int32[] triangles; //Field offset: 0x70
	internal float r; //Field offset: 0x78
	internal float g; //Field offset: 0x7C
	internal float b; //Field offset: 0x80
	internal float a; //Field offset: 0x84
	internal int hulllength; //Field offset: 0x88
	[CompilerGenerated]
	private string <Path>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private object <RendererObject>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private float <RegionU>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private float <RegionV>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private float <RegionU2>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <RegionV2>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private int <RegionDegrees>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private Int32[] <Edges>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private float <Width>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private float <Height>k__BackingField; //Field offset: 0xC4

	public float A
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public float B
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public Int32[] Edges
	{
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public int HullLength
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public MeshAttachment ParentMesh
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 185
	}

	public string Path
	{
		[CallerCount(Count = 57)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
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

	public int RegionDegrees
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public float RegionHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOffsetX
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOffsetY
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOriginalHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionOriginalWidth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float RegionU
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public float RegionU2
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public Single[] RegionUVs
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float RegionV
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public float RegionV2
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 9
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public Int32[] Triangles
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Single[] UVs
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float Width
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	[CalledBy(Type = typeof(AtlasAttachmentLoader), Member = "NewMeshAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(MeshAttachment))]
	[CalledBy(Type = typeof(MeshAttachment), Member = "Copy", ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(MeshAttachment), Member = "NewLinkedMesh", ReturnType = typeof(MeshAttachment))]
	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "NewMeshAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string), typeof(string)}, ReturnType = typeof(MeshAttachment))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public MeshAttachment(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsInvalidInstructions]
	public virtual Attachment Copy() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_A() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_B() { }

	[CallerCount(Count = 17)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Int32[] get_Edges() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_Height() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_HullLength() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public MeshAttachment get_ParentMesh() { }

	[CallerCount(Count = 57)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Path() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_R() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_RegionDegrees() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionHeight() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_RegionOffsetX() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_RegionOffsetY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionOriginalHeight() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionOriginalWidth() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_RegionU() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_RegionU2() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public Single[] get_RegionUVs() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_RegionV() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_RegionV2() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RegionWidth() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override object get_RendererObject() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public Int32[] get_Triangles() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public Single[] get_UVs() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_Width() { }

	[CalledBy(Type = typeof(Skin), Member = "CopySkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedAttachments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<Attachment>", "System.Collections.Generic.List`1<Attachment>", "UnityEngine.Shader", "UnityEngine.Material&", "UnityEngine.Texture2D&", typeof(int), typeof(int), "UnityEngine.TextureFormat", typeof(bool), typeof(string), "UnityEngine.Material", typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(Attachment))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MeshAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshAttachment), Member = "UpdateUVs", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public MeshAttachment NewLinkedMesh() { }

	[CallerCount(Count = 0)]
	public void set_A(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_B(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Edges(Int32[] value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_G(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_Height(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_HullLength(int value) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void set_ParentMesh(MeshAttachment value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Path(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_R(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RegionDegrees(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionHeight(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionOffsetX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionOffsetY(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_RegionOriginalHeight(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionOriginalWidth(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RegionU(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RegionU2(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_RegionUVs(Single[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RegionV(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_RegionV2(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RegionWidth(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override void set_RendererObject(object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Triangles(Int32[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_UVs(Single[] value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Width(float value) { }

	[CalledBy(Type = typeof(MeshAttachment), Member = "NewLinkedMesh", ReturnType = typeof(MeshAttachment))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(Skin), typeof(int), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool), typeof(bool), typeof(float)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "SetRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshAttachment), typeof(AtlasRegion), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateUVs() { }

}

