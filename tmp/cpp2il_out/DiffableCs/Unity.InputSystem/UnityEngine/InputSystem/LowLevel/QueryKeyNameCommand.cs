namespace UnityEngine.InputSystem.LowLevel;

public struct QueryKeyNameCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	internal const int kMaxNameLength = 256; //Field offset: 0x0
	internal const int kSize = 268; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public int scanOrKeyCode; //Field offset: 0x8
	[FixedBuffer(typeof(byte), 256)]
	public <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0xC

	public static FourCC Type
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
		 get { } //Length: 58
	}

	[CalledBy(Type = typeof(KeyControl), Member = "RefreshConfiguration", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static QueryKeyNameCommand Create(Key key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

	[CalledBy(Type = typeof(KeyControl), Member = "RefreshConfiguration", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringHelpers), Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	public string ReadKeyName() { }

}

