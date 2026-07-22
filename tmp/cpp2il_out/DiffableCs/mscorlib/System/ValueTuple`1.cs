namespace System;

public struct ValueTuple : IEquatable<ValueTuple`1<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`1<T1>>, IValueTupleInternal, ITuple
{
	public T1 Item1; //Field offset: 0x0

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ValueTuple`1(T1 item1) { }

	[CalledBy(Type = typeof(GenericComparer`1), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override int CompareTo(ValueTuple<T1> other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool Equals(ValueTuple<T1> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	private override int System.IComparable.CompareTo(object other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[CalledBy(Type = typeof(ValueTuple`8), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`8), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

