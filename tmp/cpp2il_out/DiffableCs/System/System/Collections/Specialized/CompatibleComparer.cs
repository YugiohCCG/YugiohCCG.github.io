namespace System.Collections.Specialized;

internal class CompatibleComparer : IEqualityComparer
{
	private static IComparer defaultComparer; //Field offset: 0x0
	private static IHashCodeProvider defaultHashProvider; //Field offset: 0x8
	private IComparer _comparer; //Field offset: 0x10
	private IHashCodeProvider _hcp; //Field offset: 0x18

	public IComparer Comparer
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static IComparer DefaultComparer
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CaseInsensitiveComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 229
	}

	public static IHashCodeProvider DefaultHashCodeProvider
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 236
	}

	public IHashCodeProvider HashCodeProvider
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(object a, object b) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public IComparer get_Comparer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CaseInsensitiveComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IComparer get_DefaultComparer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public IHashCodeProvider get_HashCodeProvider() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override int GetHashCode(object obj) { }

}

