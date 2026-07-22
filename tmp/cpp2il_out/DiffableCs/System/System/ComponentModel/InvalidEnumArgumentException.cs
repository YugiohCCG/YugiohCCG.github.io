namespace System.ComponentModel;

public class InvalidEnumArgumentException : ArgumentException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidEnumArgumentException() { }

	[CalledBy(Type = "System.Data.ExceptionBuilder", Member = "_InvalidEnumArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public InvalidEnumArgumentException(string message) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Gamepad", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.LowLevel.GamepadButton"}, ReturnType = "UnityEngine.InputSystem.Controls.ButtonControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.Pen", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.PenButton"}, ReturnType = "UnityEngine.InputSystem.Controls.ButtonControl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context) { }

}

