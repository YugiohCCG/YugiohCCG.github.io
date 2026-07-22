namespace System.IO.Enumeration;

public class FileSystemEnumerable : IEnumerable<TResult>, IEnumerable
{
	private sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
	{
		private readonly FileSystemEnumerable<TResult> _enumerable; //Field offset: 0x0

		[CalledBy(Type = typeof(FileSystemEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.IO.Enumeration.FileSystemEnumerable`1<TResult>+FindTransform<TResult>", typeof(EnumerationOptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileSystemEnumerable`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<TResult>")]
		[CalledBy(Type = typeof(FileSystemEnumerable`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FileSystemEnumerator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public DelegateEnumerator(FileSystemEnumerable<TResult> enumerable) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		protected virtual TResult TransformEntry(ref FileSystemEntry entry) { }

	}

	internal sealed class FindPredicate : MulticastDelegate
	{

		[CallerCount(Count = 72)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FindPredicate(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool Invoke(ref FileSystemEntry entry) { }

	}

	internal sealed class FindTransform : MulticastDelegate
	{

		[CallerCount(Count = 204)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FindTransform(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override TResult Invoke(ref FileSystemEntry entry) { }

	}

	private DelegateEnumerator<TResult> _enumerator; //Field offset: 0x0
	private readonly FindTransform<TResult> _transform; //Field offset: 0x0
	private readonly EnumerationOptions _options; //Field offset: 0x0
	private readonly string _directory; //Field offset: 0x0
	[CompilerGenerated]
	private FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; //Field offset: 0x0

	public FindPredicate<TResult> ShouldIncludePredicate
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public FindPredicate<TResult> ShouldRecursePredicate
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "UserEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "FileInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileInfo>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "DirectoryInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>))]
	[CalledBy(Type = typeof(FileSystemEnumerableFactory), Member = "FileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(DelegateEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public FileSystemEnumerable`1(string directory, FindTransform<TResult> transform, EnumerationOptions options = null) { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public FindPredicate<TResult> get_ShouldIncludePredicate() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public FindPredicate<TResult> get_ShouldRecursePredicate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegateEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IEnumerator<TResult> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ShouldIncludePredicate(FindPredicate<TResult> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DelegateEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

