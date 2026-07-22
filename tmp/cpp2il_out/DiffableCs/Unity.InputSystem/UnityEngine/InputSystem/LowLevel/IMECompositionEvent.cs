namespace UnityEngine.InputSystem.LowLevel;

public struct IMECompositionEvent : IInputEventTypeInfo
{
	internal const int kIMECharBufferSize = 64; //Field offset: 0x0
	public const int Type = 1229800787; //Field offset: 0x0
	public InputEvent baseEvent; //Field offset: 0x0
	public IMECompositionString compositionString; //Field offset: 0x14

	public override FourCC typeStatic
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static IMECompositionEvent Create(int deviceId, string compositionString, double time) { }

	[CallerCount(Count = 0)]
	public override FourCC get_typeStatic() { }

}

