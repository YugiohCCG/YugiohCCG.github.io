namespace System;

public struct ValueTuple : IEquatable<ValueTuple`4<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`4<T1, T2, T3, T4>>, IValueTupleInternal, ITuple
{
	public T1 Item1; //Field offset: 0x0
	public T2 Item2; //Field offset: 0x0
	public T3 Item3; //Field offset: 0x0
	public T4 Item4; //Field offset: 0x0

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "CheckFinalStatus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.HttpWebResponse"}, ReturnType = "System.ValueTuple`4<Boolean, Boolean, Task`1<BufferOffsetSize>, WebException>")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ValueTuple`4(T1 item1, T2 item2, T3 item3, T4 item4) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override bool Equals(ValueTuple<T1, T2, T3, T4> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	private override int System.IComparable.CompareTo(object other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

