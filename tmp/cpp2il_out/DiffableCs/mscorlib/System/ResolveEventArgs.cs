namespace System;

public class ResolveEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Assembly <RequestingAssembly>k__BackingField; //Field offset: 0x18

	[CalledBy(Type = typeof(AppDomain), Member = "DoTypeResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ResolveEventArgs(string name) { }

	[CalledBy(Type = typeof(AppDomain), Member = "DoAssemblyResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly), typeof(bool)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ResolveEventArgs(string name, Assembly requestingAssembly) { }

}

