namespace System;

public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	private static readonly CultureAwareComparer s_invariantCulture; //Field offset: 0x0
	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; //Field offset: 0x8
	private static readonly OrdinalCaseSensitiveComparer s_ordinal; //Field offset: 0x10
	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; //Field offset: 0x18

	public static StringComparer InvariantCultureIgnoreCase
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static StringComparer Ordinal
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public static StringComparer OrdinalIgnoreCase
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureAwareComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static StringComparer() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected StringComparer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override int Compare(object x, object y) { }

	public abstract int Compare(string x, string y) { }

	[CalledBy(Type = "System.Data.DataTable", Member = "SetLocaleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.DataTable", Member = "GetSpecialHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureAwareComparer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool Equals(object x, object y) { }

	public abstract bool Equals(string x, string y) { }

	[CallerCount(Count = 0)]
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	[CallerCount(Count = 0)]
	public static StringComparer get_Ordinal() { }

	[CallerCount(Count = 0)]
	public static StringComparer get_OrdinalIgnoreCase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override int GetHashCode(object obj) { }

	public abstract int GetHashCode(string obj) { }

}

