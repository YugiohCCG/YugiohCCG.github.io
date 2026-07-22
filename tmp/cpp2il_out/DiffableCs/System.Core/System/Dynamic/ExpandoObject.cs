namespace System.Dynamic;

public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<String, Object>, ICollection<KeyValuePair`2<String, Object>>, IEnumerable<KeyValuePair`2<String, Object>>, IEnumerable, INotifyPropertyChanged
{
	[CompilerGenerated]
	private sealed class <GetExpandoEnumerator>d__51 : IEnumerator<KeyValuePair`2<String, Object>>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<String, Object> <>2__current; //Field offset: 0x18
		public ExpandoObject <>4__this; //Field offset: 0x28
		public int version; //Field offset: 0x30
		public ExpandoData data; //Field offset: 0x38
		private int <i>5__2; //Field offset: 0x40

		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[CallerCount(Count = 36)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <GetExpandoEnumerator>d__51(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override KeyValuePair<String, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	[DefaultMember("Item")]
	private class ExpandoData
	{
		internal static ExpandoData Empty; //Field offset: 0x0
		internal readonly ExpandoClass Class; //Field offset: 0x10
		private readonly Object[] _dataArray; //Field offset: 0x18
		private int _version; //Field offset: 0x20

		internal object Item
		{
			[CallerCount(Count = 7)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 43
			[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 6)]
			internal set { } //Length: 126
		}

		internal int Length
		{
			[CallerCount(Count = 11)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal get { } //Length: 26
		}

		internal int Version
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		private static ExpandoData() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private ExpandoData() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal ExpandoData(ExpandoClass klass, Object[] data, int version) { }

		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal object get_Item(int index) { }

		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal int get_Length() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal int get_Version() { }

		[CallerCount(Count = 0)]
		private static int GetAlignedSize(int len) { }

		[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		internal void set_Item(int index, object value) { }

		[CalledBy(Type = typeof(ExpandoObject), Member = "PromoteClassCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoClass), typeof(ExpandoClass)}, ReturnType = typeof(ExpandoData))]
		[CalledBy(Type = typeof(ExpandoObject), Member = "PromoteClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 14)]
		internal ExpandoData UpdateClass(ExpandoClass newClass) { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(KeyCollectionDebugView))]
	private class KeyCollection : ICollection<String>, IEnumerable<String>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<String>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x10
			private string <>2__current; //Field offset: 0x18
			public KeyCollection <>4__this; //Field offset: 0x20
			private int <i>5__2; //Field offset: 0x28
			private int <n>5__3; //Field offset: 0x2C

			private override string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			[CallerCount(Count = 36)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetEnumerator>d__15(int <>1__state) { }

			[CallerCount(Count = 0)]
			[Calls(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "CheckVersion", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			private override bool MoveNext() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[CallerCount(Count = 13327)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.IDisposable.Dispose() { }

		}

		private readonly ExpandoObject _expando; //Field offset: 0x10
		private readonly int _expandoVersion; //Field offset: 0x18
		private readonly int _expandoCount; //Field offset: 0x1C
		private readonly ExpandoData _expandoData; //Field offset: 0x20

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
			[CallsUnknownMethods(Count = 3)]
			 get { } //Length: 104
		}

		public override bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal KeyCollection(ExpandoObject expando) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionReadOnly", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		public override void Add(string item) { }

		[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection+<GetEnumerator>d__15", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		private void CheckVersion() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionReadOnly", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		public override void Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 7)]
		public override bool Contains(string item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ContractUtils), Member = "RequiresArrayRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", typeof(int), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public override void CopyTo(String[] array, int arrayIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		public override int get_Count() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public override bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		public override IEnumerator<String> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionReadOnly", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		public override bool Remove(string item) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private sealed class KeyCollectionDebugView
	{

	}

	private class MetaExpando : DynamicMetaObject
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public InvokeMemberBinder binder; //Field offset: 0x10
			public DynamicMetaObject[] args; //Field offset: 0x18

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass3_0() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject value) { }

		}

		[CompilerGenerated]
		private sealed class <GetDynamicMemberNames>d__6 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x10
			private string <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20
			public MetaExpando <>4__this; //Field offset: 0x28
			private ExpandoData <expandoData>5__2; //Field offset: 0x30
			private ExpandoClass <klass>5__3; //Field offset: 0x38
			private int <i>5__4; //Field offset: 0x40

			private override string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			[CallerCount(Count = 18)]
			[CallsDeduplicatedMethods(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetDynamicMemberNames>d__6(int <>1__state) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
			[CallsUnknownMethods(Count = 6)]
			private override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[CallerCount(Count = 13327)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.IDisposable.Dispose() { }

		}


		public ExpandoObject Value
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 87
		}

		[CalledBy(Type = typeof(ExpandoObject), Member = "System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(DynamicMetaObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DynamicMetaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(BindingRestrictions), typeof(object)}, ReturnType = typeof(void))]
		public MetaExpando(Expression expression, ExpandoObject value) { }

		[CalledBy(Type = typeof(MetaExpando), Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(MetaExpando), Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(MetaExpando), Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DynamicMetaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(BindingRestrictions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BindingRestrictions), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingRestrictions)}, ReturnType = typeof(BindingRestrictions))]
		[Calls(Type = typeof(BindingRestrictions), Member = "GetTypeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject)}, ReturnType = typeof(BindingRestrictions))]
		[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
		[Calls(Type = typeof(DynamicMetaObjectBinder), Member = "GetUpdateExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Expression))]
		[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
		[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(MetaExpando), Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
		[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MetaExpando), Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[Calls(Type = typeof(DynamicMetaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(BindingRestrictions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Expression), Member = "IfThen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
		[Calls(Type = typeof(Expression), Member = "Not", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
		[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
		[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(MetaExpando), Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 8)]
		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MetaExpando), Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

		[CalledBy(Type = typeof(MetaExpando), Member = "BindGetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GetMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(MetaExpando), Member = "BindInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokeMemberBinder), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MetaExpando), Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[Calls(Type = typeof(BindingRestrictions), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingRestrictions)}, ReturnType = typeof(BindingRestrictions))]
		[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
		[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Type)}, ReturnType = typeof(ConditionalExpression))]
		[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DynamicMetaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(BindingRestrictions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
		[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(MetaExpando), Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
		[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 37)]
		private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MetaExpando), Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MetaExpando), Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[Calls(Type = typeof(DynamicMetaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(BindingRestrictions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression[])}, ReturnType = typeof(MethodCallExpression))]
		[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
		[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(MetaExpando), Member = "GetLimitedSelf", ReturnType = typeof(Expression))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExpandoClass), Member = "FindNewClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ExpandoClass))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 36)]
		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		public ExpandoObject get_Value() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_Value", ReturnType = typeof(object))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ExpandoObject)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExpandoClass), Member = "FindNewClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ExpandoClass))]
		[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[IteratorStateMachine(typeof(<GetDynamicMemberNames>d__6))]
		public virtual IEnumerable<String> GetDynamicMemberNames() { }

		[CalledBy(Type = typeof(MetaExpando), Member = "BindGetOrInvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(string), typeof(bool), typeof(DynamicMetaObject), typeof(System.Func`2<System.Dynamic.DynamicMetaObject, System.Dynamic.DynamicMetaObject>)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(MetaExpando), Member = "BindSetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetMemberBinder), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(MetaExpando), Member = "BindDeleteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeleteMemberBinder)}, ReturnType = typeof(DynamicMetaObject))]
		[CalledBy(Type = typeof(MetaExpando), Member = "AddDynamicTestAndDefer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObjectBinder), typeof(ExpandoClass), typeof(ExpandoClass), typeof(DynamicMetaObject)}, ReturnType = typeof(DynamicMetaObject))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DynamicMetaObject), Member = "get_LimitType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		private Expression GetLimitedSelf() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingRestrictions), Member = "GetTypeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject)}, ReturnType = typeof(BindingRestrictions))]
		private BindingRestrictions GetRestrictions() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ValueCollectionDebugView))]
	private class ValueCollection : ICollection<Object>, IEnumerable<Object>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<Object>, IDisposable, IEnumerator
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public ValueCollection <>4__this; //Field offset: 0x20
			private ExpandoData <data>5__2; //Field offset: 0x28
			private int <i>5__3; //Field offset: 0x30

			private override object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 31)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 5
			}

			[CallerCount(Count = 36)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetEnumerator>d__15(int <>1__state) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
			[CallsUnknownMethods(Count = 6)]
			private override bool MoveNext() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override object System.Collections.IEnumerator.get_Current() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[CallerCount(Count = 13327)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override void System.IDisposable.Dispose() { }

		}

		private readonly ExpandoObject _expando; //Field offset: 0x10
		private readonly int _expandoVersion; //Field offset: 0x18
		private readonly int _expandoCount; //Field offset: 0x1C
		private readonly ExpandoData _expandoData; //Field offset: 0x20

		public override int Count
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
			[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = "Mono.Net.Security.BufferOffsetSize2", Member = "Reset", ReturnType = typeof(void))]
			[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls+unitytls_interface_struct")]
			[Calls(Type = "Mono.Btls.MonoBtlsBio", Member = "get_Handle", ReturnType = "Mono.Btls.MonoBtlsBio+BoringBioHandle")]
			[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
			[Calls(Type = "Mono.Btls.MonoBtlsObject", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 4)]
			[CallsUnknownMethods(Count = 43)]
			 get { } //Length: 1891
		}

		public override bool IsReadOnly
		{
			[CallerCount(Count = 23)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal ValueCollection(ExpandoObject expando) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionReadOnly", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		public override void Add(object item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 3)]
		private void CheckVersion() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionReadOnly", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		public override void Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 10)]
		public override bool Contains(object item) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "RequiresArrayRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", typeof(int), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 20)]
		public override void CopyTo(Object[] array, int arrayIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionModifiedWhileEnumerating", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "Mono.Net.Security.BufferOffsetSize2", Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls+unitytls_interface_struct")]
		[Calls(Type = "Mono.Btls.MonoBtlsBio", Member = "get_Handle", ReturnType = "Mono.Btls.MonoBtlsBio+BoringBioHandle")]
		[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[Calls(Type = "Mono.Btls.MonoBtlsObject", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 43)]
		public override int get_Count() { }

		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		public override bool get_IsReadOnly() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IteratorStateMachine(typeof(<GetEnumerator>d__15))]
		public override IEnumerator<Object> GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Error), Member = "CollectionReadOnly", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		public override bool Remove(object item) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private sealed class ValueCollectionDebugView
	{

	}

	private static readonly MethodInfo s_expandoTryGetValue; //Field offset: 0x0
	private static readonly MethodInfo s_expandoTrySetValue; //Field offset: 0x8
	private static readonly MethodInfo s_expandoTryDeleteValue; //Field offset: 0x10
	private static readonly MethodInfo s_expandoPromoteClass; //Field offset: 0x18
	private static readonly MethodInfo s_expandoCheckVersion; //Field offset: 0x20
	internal static readonly object Uninitialized; //Field offset: 0x28
	internal readonly object LockObject; //Field offset: 0x10
	private ExpandoData _data; //Field offset: 0x18
	private int _count; //Field offset: 0x20
	private PropertyChangedEventHandler _propertyChanged; //Field offset: 0x28

	internal ExpandoClass Class
	{
		[CallerCount(Count = 21)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 27
	}

	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.Generic.IDictionary<System.String,System.Object>.Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Error), Member = "KeyDoesNotExistInExpando", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 103
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		private set { } //Length: 129
	}

	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 84
	}

	private override ICollection<Object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 84
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static ExpandoObject() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.ExpandoObjectConverter", Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.ExpandoObjectConverter", Member = "ReadObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader"}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public ExpandoObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private bool ExpandoContainsKey(string key) { }

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ExpandoClass get_Class() { }

	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, System.Object>>))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[IteratorStateMachine(typeof(<GetExpandoEnumerator>d__51))]
	private IEnumerator<KeyValuePair`2<String, Object>> GetExpandoEnumerator(ExpandoData data, int version) { }

	[CalledBy(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsDeletedMember(int index) { }

	[CalledBy(Type = typeof(RuntimeOps), Member = "ExpandoPromoteClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoObject), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoData), Member = "UpdateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoClass)}, ReturnType = typeof(ExpandoData))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void PromoteClass(object oldClass, object newClass) { }

	[CalledBy(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExpandoData), Member = "UpdateClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoClass)}, ReturnType = typeof(ExpandoData))]
	[CallsUnknownMethods(Count = 2)]
	private ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryAddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<String, Object> item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<String, Object> item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresArrayRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", typeof(int), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<String, Object>[] array, int arrayIndex) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private override int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<String, Object> item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryAddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	private override void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Error), Member = "KeyDoesNotExistInExpando", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	private override object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override ICollection<String> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override ICollection<Object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoObject), Member = "TryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(object)}, ReturnType = typeof(bool))]
	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private override void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "GetExpandoEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoData), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, System.Object>>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator<KeyValuePair`2<String, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "GetExpandoEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoData), typeof(int)}, ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, System.Object>>))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MetaExpando), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(ExpandoObject)}, ReturnType = typeof(void))]
	private override DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, System.Object>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoObject), Member = "TrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	private void TryAddMember(string key, object value) { }

	[CalledBy(Type = typeof(RuntimeOps), Member = "ExpandoTryDeleteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoObject), typeof(object), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, System.Object>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoData), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "AmbiguousMatchInExpandoObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	[CalledBy(Type = typeof(RuntimeOps), Member = "ExpandoTryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoObject), typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryGetValueForKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, System.Object>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Error), Member = "AmbiguousMatchInExpandoObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpandoObject), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(string), typeof(bool), typeof(Object&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	private bool TryGetValueForKey(string key, out object value) { }

	[CalledBy(Type = typeof(RuntimeOps), Member = "ExpandoTrySetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoObject), typeof(object), typeof(int), typeof(object), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "TryAddMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpandoClass), Member = "GetValueIndexCaseInsensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExpandoObject)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExpandoClass), Member = "FindNewClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ExpandoClass))]
	[Calls(Type = typeof(ExpandoObject), Member = "PromoteClassCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpandoClass), typeof(ExpandoClass)}, ReturnType = typeof(ExpandoData))]
	[Calls(Type = typeof(ExpandoData), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "AmbiguousMatchInExpandoObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Error), Member = "SameKeyExistsInExpando", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

}

