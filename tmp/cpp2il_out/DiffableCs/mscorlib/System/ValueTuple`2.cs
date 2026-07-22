namespace System;

public struct ValueTuple : IEquatable<ValueTuple`2<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple`2<T1, T2>>, IValueTupleInternal, ITuple
{
	public T1 Item1; //Field offset: 0x0
	public T2 Item2; //Field offset: 0x0

	private override int System.Runtime.CompilerServices.ITuple.Length
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		private get { } //Length: 6
	}

	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.IntegerTime.DiscreteTime"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "ReadCurrentNavigationMoveVector", ReturnType = "System.ValueTuple`2<Vector2, Boolean>")]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.IntegerTime.DiscreteTime"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadCurrentNavigationMoveVector", ReturnType = "System.ValueTuple`2<Vector2, Boolean>")]
	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ValueTuple`2(T1 item1, T2 item2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<Unity.Collections.NativeList`1<System.Int32>>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<Unity.Collections.NativeList`1<System.Int32>>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int CompareTo(ValueTuple<T1, T2> other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override bool Equals(ValueTuple<T1, T2> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTuple), Member = "CombineHashCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private int GetHashCodeCore(IEqualityComparer comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
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
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override string System.IValueTupleInternal.ToStringEnd() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	private override int System.Runtime.CompilerServices.ITuple.get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

