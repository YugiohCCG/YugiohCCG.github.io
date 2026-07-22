namespace System.ComponentModel;

internal sealed class WeakHashtable : Hashtable
{
	private class WeakKeyComparer : IEqualityComparer
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public WeakKeyComparer() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		private override bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	}

	private static IEqualityComparer _comparer; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static WeakHashtable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	internal WeakHashtable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = "Clear", ReturnType = typeof(void))]
	public virtual void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	public virtual void Remove(object key) { }

}

