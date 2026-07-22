namespace System.Runtime.CompilerServices;

[AttributeUsage(71)]
[ComVisible(True)]
public class CompilationRelaxationsAttribute : Attribute
{
	private int m_relaxations; //Field offset: 0x10

	public int CompilationRelaxations
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CompilationRelaxationsAttribute(int relaxations) { }

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CompilationRelaxationsAttribute(CompilationRelaxations relaxations) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_CompilationRelaxations() { }

}

