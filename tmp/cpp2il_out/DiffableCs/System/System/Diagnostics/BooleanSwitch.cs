namespace System.Diagnostics;

[SwitchLevel(typeof(bool))]
public class BooleanSwitch : Switch
{

	[CalledBy(Type = typeof(TypeDescriptor), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Switch), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public BooleanSwitch(string displayName, string description) { }

}

