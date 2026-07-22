namespace Spine;

public class SkeletonBinary : SkeletonLoader
{
	public class SkeletonInput
	{
		private Byte[] chars; //Field offset: 0x10
		private Byte[] bytesBigEndian; //Field offset: 0x18
		internal String[] strings; //Field offset: 0x20
		private Stream input; //Field offset: 0x28

		[CalledBy(Type = typeof(SkeletonBinary), Member = "GetVersionString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public SkeletonInput(Stream input) { }

		[CalledBy(Type = typeof(SkeletonBinary), Member = "GetVersionString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadLong", ReturnType = typeof(long))]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SkeletonInput), Member = "GetVersionStringOld3X", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 14)]
		public string GetVersionString() { }

		[CalledBy(Type = typeof(SkeletonInput), Member = "GetVersionString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		public string GetVersionStringOld3X() { }

		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public int Read() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool ReadBoolean() { }

		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public byte ReadByte() { }

		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int)}, ReturnType = typeof(Vertices))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int), typeof(float)}, ReturnType = typeof(Single[]))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline), typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 130)]
		[Calls(Type = typeof(BitConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(float))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public float ReadFloat() { }

		[CalledBy(Type = typeof(SkeletonInput), Member = "ReadString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public void ReadFully(Byte[] buffer, int offset, int length) { }

		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public int ReadInt() { }

		[CalledBy(Type = typeof(SkeletonInput), Member = "ReadString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonInput), Member = "ReadStringRef", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonInput), Member = "GetVersionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonInput), Member = "GetVersionStringOld3X", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int)}, ReturnType = typeof(Vertices))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadShortArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput)}, ReturnType = typeof(Int32[]))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CallerCount(Count = 105)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		public int ReadInt(bool optimizePositive) { }

		[CalledBy(Type = typeof(SkeletonInput), Member = "GetVersionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public long ReadLong() { }

		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(EndOfStreamException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public sbyte ReadSByte() { }

		[CalledBy(Type = typeof(SkeletonInput), Member = "GetVersionString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadFully", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public string ReadString() { }

		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		public string ReadStringRef() { }

	}

	public class Vertices
	{
		public Int32[] bones; //Field offset: 0x10
		public Single[] vertices; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Vertices() { }

	}

	public const int BONE_ROTATE = 0; //Field offset: 0x0
	public const int CURVE_STEPPED = 1; //Field offset: 0x0
	public const int CURVE_LINEAR = 0; //Field offset: 0x0
	public const int PATH_MIX = 2; //Field offset: 0x0
	public const int PATH_SPACING = 1; //Field offset: 0x0
	public const int PATH_POSITION = 0; //Field offset: 0x0
	public const int SLOT_ALPHA = 5; //Field offset: 0x0
	public const int SLOT_RGB2 = 4; //Field offset: 0x0
	public const int SLOT_RGBA2 = 3; //Field offset: 0x0
	public const int SLOT_RGB = 2; //Field offset: 0x0
	public const int CURVE_BEZIER = 2; //Field offset: 0x0
	public const int SLOT_RGBA = 1; //Field offset: 0x0
	public const int BONE_SHEARY = 9; //Field offset: 0x0
	public const int BONE_SHEARX = 8; //Field offset: 0x0
	public const int BONE_SHEAR = 7; //Field offset: 0x0
	public const int BONE_SCALEY = 6; //Field offset: 0x0
	public const int BONE_SCALEX = 5; //Field offset: 0x0
	public const int BONE_SCALE = 4; //Field offset: 0x0
	public const int BONE_TRANSLATEY = 3; //Field offset: 0x0
	public const int BONE_TRANSLATEX = 2; //Field offset: 0x0
	public const int BONE_TRANSLATE = 1; //Field offset: 0x0
	public const int SLOT_ATTACHMENT = 0; //Field offset: 0x0
	public static readonly TransformMode[] TransformModeValues; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static SkeletonBinary() { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SkeletonLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentLoader)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SkeletonBinary(AttachmentLoader attachmentLoader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonLoader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Atlas[])}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public SkeletonBinary(Atlas[] atlasArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonInput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "GetVersionString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string GetVersionString(Stream file) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScaleXTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShearXTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShearYTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IkConstraintTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadSByte", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(IkConstraintTimeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TransformConstraintTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PathConstraintMixTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Timeline), Member = "get_FrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(PathConstraintSpacingTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(PathConstraintPositionTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeformTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(VertexAttachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeformTimeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawOrderTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DrawOrderTimeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(EventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(EventTimeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Timeline), Member = "get_Duration", ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Animation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Spine.ExposedList`1<Spine.Timeline>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShearTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleYTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttachmentTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadStringRef", ReturnType = typeof(string))]
	[Calls(Type = typeof(AttachmentTimeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBATimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBATimeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CurveTimeline), Member = "SetStepped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline), typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBA2Timeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGBA2Timeline), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RGB2Timeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AlphaTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CurveTimeline1), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotateTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
	[Calls(Type = typeof(TranslateTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
	[Calls(Type = typeof(TranslateXTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TranslateYTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 62)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private Animation ReadAnimation(string name, SkeletonInput input, SkeletonData skeletonData) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadStringRef", ReturnType = typeof(string))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", ReturnType = typeof(int))]
	[Calls(Type = typeof(RegionAttachment), Member = "UpdateOffset", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int)}, ReturnType = typeof(Vertices))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int), typeof(float)}, ReturnType = typeof(Single[]))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadShortArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(MeshAttachment), Member = "UpdateUVs", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedMesh), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshAttachment), typeof(string), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	[ContainsUnimplementedInstructions]
	private Attachment ReadAttachment(SkeletonInput input, SkeletonData skeletonData, Skin skin, int slotIndex, string attachmentName, bool nonessential) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int)}, ReturnType = typeof(Vertices))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Single[] ReadFloatArray(SkeletonInput input, int n, float scale) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] ReadShortArray(SkeletonInput input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	public virtual SkeletonData ReadSkeletonData(string path) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(AttachmentLoader), typeof(float)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadSByte", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonData), Member = "FindSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Skin))]
	[Calls(Type = typeof(MeshAttachment), Member = "set_ParentMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshAttachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PathConstraintData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshAttachment), Member = "UpdateUVs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(TransformConstraintData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IkConstraintData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadStringRef", ReturnType = typeof(string))]
	[Calls(Type = typeof(SlotData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(BoneData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", ReturnType = typeof(int))]
	[Calls(Type = typeof(BoneData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(BoneData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadLong", ReturnType = typeof(long))]
	[Calls(Type = typeof(SkeletonInput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 85)]
	[ContainsUnimplementedInstructions]
	public SkeletonData ReadSkeletonData(Stream file) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Skin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Spine.ExposedList`1<System.Object>))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadStringRef", ReturnType = typeof(string))]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Skin), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private Skin ReadSkin(SkeletonInput input, SkeletonData skeletonData, bool defaultSkin, bool nonessential) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(Timeline), Member = "get_FrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CurveTimeline1), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CurveTimeline), Member = "SetStepped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CurveTimeline), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Timeline ReadTimeline(SkeletonInput input, CurveTimeline1 timeline, float scale) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(Timeline), Member = "get_FrameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CurveTimeline2), Member = "SetFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CurveTimeline), Member = "SetStepped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CurveTimeline), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Timeline ReadTimeline(SkeletonInput input, CurveTimeline2 timeline, float scale) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(Skin), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(Attachment))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Single>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(SkeletonBinary), Member = "ReadFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int), typeof(float)}, ReturnType = typeof(Single[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private Vertices ReadVertices(SkeletonInput input, int vertexCount) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(SkeletonInput), Member = "ReadFloat", ReturnType = typeof(float))]
	[Calls(Type = typeof(CurveTimeline), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetBezier(SkeletonInput input, CurveTimeline timeline, int bezier, int frame, int value, float time1, float time2, float value1, float value2, float scale) { }

}

