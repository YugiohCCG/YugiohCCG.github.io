namespace Unity.Collections;

[AttributeUsage(236, AllowMultiple = True)]
public class GenerateTestsForBurstCompatibilityAttribute : Attribute
{
	internal enum BurstCompatibleCompileTarget
	{
		Player = 0,
		Editor = 1,
		PlayerAndEditor = 2,
	}

	[CompilerGenerated]
	private Type[] <GenericTypeArguments>k__BackingField; //Field offset: 0x10
	public string RequiredUnityDefine; //Field offset: 0x18
	public BurstCompatibleCompileTarget CompileTarget; //Field offset: 0x20

	public Type[] GenericTypeArguments
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public GenerateTestsForBurstCompatibilityAttribute() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type[] get_GenericTypeArguments() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_GenericTypeArguments(Type[] value) { }

}

