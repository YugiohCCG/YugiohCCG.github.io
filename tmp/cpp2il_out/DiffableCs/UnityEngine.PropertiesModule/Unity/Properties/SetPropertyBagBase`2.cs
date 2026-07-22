namespace Unity.Properties;

public class SetPropertyBagBase : PropertyBag<TSet>, ISetPropertyBag<TSet, TElement>, ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, Object>
{
	[CompilerGenerated]
	private sealed class <GetPropertiesEnumerable>d__4 : IEnumerable<IProperty`1<TSet>>, IEnumerable, IEnumerator<IProperty`1<TSet>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private IProperty<TSet> <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private TSet container; //Field offset: 0x0
		public TSet <>3__container; //Field offset: 0x0
		public SetPropertyBagBase<TSet, TElement> <>4__this; //Field offset: 0x0
		private IEnumerator<TElement> <>s__1; //Field offset: 0x0
		private TElement <element>5__2; //Field offset: 0x0

		private override IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 42
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 42
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetPropertiesEnumerable>d__4(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 42)]
		[DeduplicatedMethod]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<IProperty`1<TSet>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private class SetElementProperty : Property<TSet, TElement>, ISetElementProperty
	{
		internal TElement m_Value; //Field offset: 0x0

		public virtual bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public virtual string Name
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			 get { } //Length: 230
		}

		public override object ObjectKey
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 152
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SetElementProperty() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public virtual bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public virtual string get_Name() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public override object get_ObjectKey() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public virtual TElement GetValue(ref TSet container) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public virtual void SetValue(ref TSet container, TElement value) { }

	}

	private readonly SetElementProperty<TSet, TElement> m_Property; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SetPropertyBagBase`2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TSet> GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Properties.PropertyCollection`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<Unity.Properties.IProperty`1<Unity.IL2CPP.Metadata.__Il2CppFullySharedGenericType>>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TSet> GetProperties(ref TSet container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<GetPropertiesEnumerable>d__4))]
	private IEnumerable<IProperty`1<TSet>> GetPropertiesEnumerable(TSet container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public override bool TryGetProperty(ref TSet container, object key, out IProperty<TSet>& property) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, ref TSet container) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, ref TSet container) { }

}

