namespace UnityEngine.InputSystem.LowLevel;

public struct TextEvent : IInputEventTypeInfo
{
	public const int Type = 1413830740; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0
	public int character; //Field offset: 0x14

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(InputSystem), Member = "QueueTextEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(char), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	public static TextEvent Create(int deviceId, char character, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FourCC), typeof(int), typeof(int), typeof(double)}, ReturnType = typeof(void))]
	public static TextEvent Create(int deviceId, int character, double time = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEventPtr), Member = "IsA", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_type", ReturnType = typeof(FourCC))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static TextEvent* From(InputEventPtr eventPtr) { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

}

