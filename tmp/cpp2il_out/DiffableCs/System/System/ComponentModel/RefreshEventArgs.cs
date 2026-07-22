namespace System.ComponentModel;

public class RefreshEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly Type <TypeChanged>k__BackingField; //Field offset: 0x10

	[CalledBy(Type = typeof(TypeDescriptor), Member = "RaiseRefresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RefreshEventArgs(Type typeChanged) { }

}

