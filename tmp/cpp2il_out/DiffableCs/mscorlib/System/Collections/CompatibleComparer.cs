namespace System.Collections;

internal sealed class CompatibleComparer : IEqualityComparer
{
	private readonly IHashCodeProvider _hcp; //Field offset: 0x10
	private readonly IComparer _comparer; //Field offset: 0x18

	internal IComparer Comparer
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal IHashCodeProvider HashCodeProvider
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal CompatibleComparer(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public int Compare(object a, object b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(object a, object b) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal IComparer get_Comparer() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal IHashCodeProvider get_HashCodeProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override int GetHashCode(object obj) { }

}

