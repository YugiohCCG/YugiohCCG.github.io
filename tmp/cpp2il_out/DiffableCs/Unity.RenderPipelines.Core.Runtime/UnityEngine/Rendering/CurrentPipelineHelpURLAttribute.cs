namespace UnityEngine.Rendering;

[AttributeUsage(20, AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class CurrentPipelineHelpURLAttribute : HelpURLAttribute
{
	[CompilerGenerated]
	private readonly string <pageName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <pageHash>k__BackingField; //Field offset: 0x30

	private string pageHash
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private string pageName
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public virtual string URL
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HelpURLAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public CurrentPipelineHelpURLAttribute(string pageName, string pageHash = "") { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private string get_pageHash() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private string get_pageName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_URL() { }

}

