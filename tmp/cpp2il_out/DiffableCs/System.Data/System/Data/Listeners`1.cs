namespace System.Data;

internal sealed class Listeners
{
	public sealed class Action : MulticastDelegate
	{

		[CalledBy(Type = typeof(Index), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public Action`4(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	}

	public sealed class Func : MulticastDelegate
	{

		[CallerCount(Count = 408)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public Func`2(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override TResult Invoke(T1 arg1) { }

	}

	private readonly List<TElem> _listeners; //Field offset: 0x0
	private readonly Func<TElem, TElem, Boolean> _filter; //Field offset: 0x0
	private readonly int _objectID; //Field offset: 0x0
	private int _listenerReaderCount; //Field offset: 0x0

	internal bool HasListeners
	{
		[CalledBy(Type = typeof(Index), Member = "FireResetEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "get_DoListChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 30
	}

	[CalledBy(Type = typeof(Index), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(IndexField[]), typeof(System.Comparison`1<System.Data.DataRow>), typeof(DataViewRowState), typeof(IFilter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal Listeners`1(int ObjectID, Func<TElem, TElem, Boolean> notifyFilter) { }

	[CalledBy(Type = typeof(Index), Member = "ListChangedAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal void Add(TElem listener) { }

	[CalledBy(Type = typeof(Index), Member = "FireResetEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "get_DoListChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "OnListChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HasListeners() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Index), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "T"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	internal int IndexOfReference(TElem listener) { }

	[CalledBy(Type = typeof(Index), Member = "MaintainDataView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Listeners`1), Member = "RemoveNullListeners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	internal void Notify(T1 arg1, T2 arg2, T3 arg3, Action<TElem, TElem, T1, T2, T3> action) { }

	[CalledBy(Type = typeof(Index), Member = "ListChangedRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataViewListener)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Index), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "TrimExcess", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void Remove(TElem listener) { }

	[CalledBy(Type = typeof(Listeners`1), Member = "Notify", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3", "System.Data.Listeners`1<TElem>+Action`4<TElem, TElem, T1, T2, T3>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void RemoveNullListeners(int nullIndex) { }

}

