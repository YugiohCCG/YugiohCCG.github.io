namespace UnityEngine.InputSystem.LowLevel;

public struct QueryKeyboardLayoutCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	internal const int kMaxNameLength = 256; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	[FixedBuffer(typeof(byte), 256)]
	public <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0x8

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

	[CalledBy(Type = typeof(Keyboard), Member = "RefreshConfiguration", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static QueryKeyboardLayoutCommand Create() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringHelpers), Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public string ReadLayoutName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringHelpers), Member = "WriteStringToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void WriteLayoutName(string name) { }

}

