namespace System;

public struct ValueTuple : IEquatable<ValueTuple`5<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`5<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple
{
	public T1 Item1; //Field offset: 0x0
	public T2 Item2; //Field offset: 0x0
	public T3 Item3; //Field offset: 0x0
	public T4 Item4; //Field offset: 0x0
	public T5 Item5; //Field offset: 0x0

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	[CalledBy(Type = typeof(Path), Member = "JoinInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ValueTuple`5(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }

	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.IComparable.CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.IntPtr>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.IntPtr>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Int32>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Int32>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`5), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`5<T1, T2, T3, T4, T5>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(ValueTuple`5), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public override bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.Collections.IStructuralEquatable.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`5), Member = "System.IValueTupleInternal.GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 29)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 21)]
	[DeduplicatedMethod]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`5), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`5), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ValueTuple`5<T1, T2, T3, T4, T5>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	private override int System.IComparable.CompareTo(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple`5), Member = "GetHashCodeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

