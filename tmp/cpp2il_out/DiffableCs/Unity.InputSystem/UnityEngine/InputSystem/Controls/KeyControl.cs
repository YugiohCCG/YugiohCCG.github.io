namespace UnityEngine.InputSystem.Controls;

public class KeyControl : ButtonControl
{
	[CompilerGenerated]
	private Key <keyCode>k__BackingField; //Field offset: 0x148
	private int m_ScanCode; //Field offset: 0x14C

	public Key keyCode
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

	public int scanCode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputControl), Member = "RefreshConfigurationIfNeeded", ReturnType = typeof(void))]
		 get { } //Length: 28
	}

	[CallerCount(Count = 141)]
	[Calls(Type = typeof(ButtonControl), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public KeyControl() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Key get_keyCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "RefreshConfigurationIfNeeded", ReturnType = typeof(void))]
	public int get_scanCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryKeyNameCommand), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(QueryKeyNameCommand))]
	[Calls(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryKeyNameCommand)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QueryKeyNameCommand&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(QueryKeyNameCommand), Member = "ReadKeyName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TextInfo), Member = "ToTitleCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void RefreshConfiguration() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_keyCode(Key value) { }

}

