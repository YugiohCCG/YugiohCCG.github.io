namespace UnityEngine.InputSystem.LowLevel;

public struct QueryPairedUserAccountCommand : IInputDeviceCommandInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <idBuffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <nameBuffer>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	[Flags]
	internal enum Result
	{
		DevicePairedToUserAccount = 2,
		UserAccountSelectionInProgress = 4,
		UserAccountSelectionComplete = 8,
		UserAccountSelectionCanceled = 16,
	}

	internal const int kMaxNameLength = 256; //Field offset: 0x0
	internal const int kMaxIdLength = 256; //Field offset: 0x0
	internal const int kSize = 1040; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public ulong handle; //Field offset: 0x8
	[FixedBuffer(typeof(byte), 512)]
	internal <nameBuffer>e__FixedBuffer nameBuffer; //Field offset: 0x10
	[FixedBuffer(typeof(byte), 512)]
	internal <idBuffer>e__FixedBuffer idBuffer; //Field offset: 0x210

	public string id
	{
		[CalledBy(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringHelpers), Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		 get { } //Length: 20
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringHelpers), Member = "WriteStringToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		 set { } //Length: 269
	}

	public string name
	{
		[CalledBy(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringHelpers), Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
		 get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringHelpers), Member = "WriteStringToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		 set { } //Length: 266
	}

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

	[CalledBy(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static QueryPairedUserAccountCommand Create() { }

	[CalledBy(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringHelpers), Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	public string get_id() { }

	[CalledBy(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringHelpers), Member = "ReadStringFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(string))]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public static FourCC get_Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FourCC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	public override FourCC get_typeStatic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringHelpers), Member = "WriteStringToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void set_id(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringHelpers), Member = "WriteStringToBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public void set_name(string value) { }

}

