namespace UnityEngine.InputSystem.Utilities;

internal struct PredictiveParser
{
	private int m_Position; //Field offset: 0x0

	[CalledBy(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AcceptInt(ReadOnlySpan<Char> str) { }

	[CalledBy(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	public bool AcceptSingleChar(ReadOnlySpan<Char> str, char c) { }

	[CalledBy(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 8)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public bool AcceptString(ReadOnlySpan<Char> input, out ReadOnlySpan<Char>& output) { }

	[CalledBy(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public int ExpectInt(ReadOnlySpan<Char> str) { }

	[CalledBy(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void ExpectSingleChar(ReadOnlySpan<Char> str, char c) { }

	[CalledBy(Type = typeof(HIDDeviceDescriptor), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HIDDeviceDescriptor))]
	[CallerCount(Count = 15)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public ReadOnlySpan<Char> ExpectString(ReadOnlySpan<Char> str) { }

}

