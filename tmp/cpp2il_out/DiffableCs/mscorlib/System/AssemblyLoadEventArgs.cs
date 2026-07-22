namespace System;

public class AssemblyLoadEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly Assembly <LoadedAssembly>k__BackingField; //Field offset: 0x10

	[CalledBy(Type = typeof(AppDomain), Member = "DoAssemblyLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AssemblyLoadEventArgs(Assembly loadedAssembly) { }

}

