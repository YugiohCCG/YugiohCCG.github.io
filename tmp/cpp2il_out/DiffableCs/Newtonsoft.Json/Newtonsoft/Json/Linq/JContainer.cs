namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged
{
	[CompilerGenerated]
	private sealed class <GetDescendants>d__36 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JToken <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private bool self; //Field offset: 0x24
		public bool <>3__self; //Field offset: 0x25
		[Nullable(0)]
		public JContainer <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator<JToken> <>7__wrap1; //Field offset: 0x30
		[Nullable(0)]
		private JToken <o>5__3; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		private IEnumerator<JToken> <>7__wrap3; //Field offset: 0x40

		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
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
		public <GetDescendants>d__36(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void <>m__Finally2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JContainer), Member = "GetDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 26)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
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

		[CalledBy(Type = typeof(ValidationEventArgs), Member = "get_Path", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <ReadContentFromAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		[Nullable(0)]
		public JContainer <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public JsonLoadSettings settings; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		[Nullable(0)]
		private IJsonLineInfo <lineInfo>5__2; //Field offset: 0x40
		[Nullable(0)]
		private JContainer <parent>5__3; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x50
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JValue), Member = "CreateUndefined", ReturnType = typeof(JValue))]
		[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(JsonReader), Member = "SkipAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(JContainer), Member = "ReadProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings), typeof(IJsonLineInfo), typeof(JContainer)}, ReturnType = typeof(JProperty))]
		[Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(JValue), Member = "CreateComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JValue))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 51)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadTokenFromAsync>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public JsonReader reader; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		[Nullable(0)]
		public JContainer <>4__this; //Field offset: 0x30
		[Nullable(0)]
		public JsonLoadSettings options; //Field offset: 0x38
		private int <startDepth>5__2; //Field offset: 0x40
		[Nullable(0)]
		private ConfiguredTaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadContentFromAsync>d__1&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ConfiguredTaskAwaitable))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 30)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; //Field offset: 0x30
	[Nullable(2)]
	internal AddingNewEventHandler _addingNew; //Field offset: 0x38
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; //Field offset: 0x40
	[Nullable(2)]
	private object _syncRoot; //Field offset: 0x48
	private bool _busy; //Field offset: 0x50

	public event AddingNewEventHandler AddingNew
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 add { } //Length: 159
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 remove { } //Length: 159
	}

	[Nullable(2)]
	public override event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[NullableContext(2)]
		 add { } //Length: 159
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[NullableContext(2)]
		 remove { } //Length: 159
	}

	public override event ListChangedEventHandler ListChanged
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 add { } //Length: 159
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		 remove { } //Length: 159
	}

	protected abstract IList<JToken> ChildrenTokens
	{
		 get { } //Length: 0
	}

	public override int Count
	{
		[CalledBy(Type = typeof(JContainer), Member = "CopyItemsTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyValuePair`2<String, JToken>[]), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter+<ExecuteFilter>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PathFilter), Member = "GetTokenIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSelectSettings), typeof(int)}, ReturnType = typeof(JToken))]
		[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
		[CallerCount(Count = 13)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 88
	}

	[Nullable(2)]
	public virtual JToken First
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[NullableContext(2)]
		 get { } //Length: 135
	}

	public virtual bool HasValues
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 94
	}

	[Nullable(2)]
	public virtual JToken Last
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[NullableContext(2)]
		 get { } //Length: 136
	}

	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 17
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 17
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		private get { } //Length: 107
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[Nullable(2)]
	private override object System.Collections.IList.Item
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		private get { } //Length: 17
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
		[CallsDeduplicatedMethods(Count = 1)]
		[NullableContext(2)]
		private set { } //Length: 64
	}

	private override bool System.ComponentModel.IBindingList.AllowEdit
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.AllowNew
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.AllowRemove
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.IsSorted
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override ListSortDirection System.ComponentModel.IBindingList.SortDirection
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[Nullable(2)]
	private override PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		[NullableContext(2)]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsChangeNotification
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSearching
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.ComponentModel.IBindingList.SupportsSorting
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[CalledBy(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal JContainer() { }

	[CalledBy(Type = typeof(JObject), Member = "CloneToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonCloneSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JProperty), Member = "CloneToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonCloneSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JProperty), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JConstructor), Member = "CloneToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonCloneSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JConstructor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JArray), Member = "CloneToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonCloneSettings)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(JArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JArray), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JArray)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JConstructor), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	internal JContainer(JContainer other, JsonCloneSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	public override void Add(object content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public void add_AddingNew(AddingNewEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public override void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public override void add_ListChanged(ListChangedEventHandler value) { }

	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "AddParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void AddAndSkipParentCheck(JToken token) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[NullableContext(2)]
	public void AddFirst(object content) { }

	[CalledBy(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JContainer), Member = "RemoveItemAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "ClearItems", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal void CheckReentrancy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JEnumerable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual JEnumerable<JToken> Children() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	internal override void ClearItems() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal override bool ContainsItem(JToken item) { }

	[CalledBy(Type = typeof(JArray), Member = "DeepEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JConstructor), Member = "DeepEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JProperty), Member = "DeepEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal bool ContentsEqual(JContainer container) { }

	[CalledBy(Type = typeof(JArray), Member = "GetDeepHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JConstructor), Member = "GetDeepHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JObject), Member = "GetDeepHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	internal int ContentsHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 26)]
	internal override void CopyItemsTo(Array array, int arrayIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override IList<JToken> CreateChildrenCollection() { }

	[CalledBy(Type = typeof(JContainer), Member = "MergeEnumerableContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(IEnumerable), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	internal static JToken CreateFromContent(object content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JTokenWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer)}, ReturnType = typeof(void))]
	public JsonWriter CreateWriter() { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.Extensions+<>c__2`1", Member = "<Descendants>b__2_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JContainer), Member = "GetDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	public IEnumerable<JToken> Descendants() { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.Extensions+<>c__3`1", Member = "<DescendantsAndSelf>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.QueryScanFilter+<ExecuteFilter>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JContainer), Member = "GetDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	public IEnumerable<JToken> DescendantsAndSelf() { }

	[CalledBy(Type = typeof(JContainer), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[CallsDeduplicatedMethods(Count = 2)]
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "System.Collections.IList.set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[NullableContext(2)]
	private JToken EnsureValue(object value) { }

	protected abstract IList<JToken> get_ChildrenTokens() { }

	[CalledBy(Type = typeof(JContainer), Member = "CopyItemsTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyValuePair`2<String, JToken>[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter+<ExecuteFilter>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PathFilter), Member = "GetTokenIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(JsonSelectSettings), typeof(int)}, ReturnType = typeof(JToken))]
	[CalledBy(Type = typeof(DiscriminatedUnionConverter), Member = "ReadJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(Type), typeof(object), typeof(JsonSerializer)}, ReturnType = typeof(object))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public virtual JToken get_First() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_HasValues() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public virtual JToken get_Last() { }

	[CalledBy(Type = typeof(<GetDescendants>d__36), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JContainer), Member = "Descendants", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CalledBy(Type = typeof(JContainer), Member = "DescendantsAndSelf", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<GetDescendants>d__36))]
	internal IEnumerable<JToken> GetDescendants(bool self) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	internal abstract int IndexOfItem(JToken item) { }

	[CalledBy(Type = typeof(JObject), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JProperty), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "EnsureParentToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(bool), typeof(bool)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[NullableContext(2)]
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[CalledBy(Type = typeof(JArray), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JContainer), Member = "ValidateContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal bool IsMultiContent(object content) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "ValidateContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public void Merge(object content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "ValidateContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	public void Merge(object content, JsonMergeSettings settings) { }

	[CalledBy(Type = typeof(JArray), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JConstructor), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "CreateFromContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[Calls(Type = typeof(JContainer), Member = "ValidateContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 49)]
	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings) { }

	internal abstract void MergeItem(object content, JsonMergeSettings settings) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnAddingNew(AddingNewEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnListChanged(ListChangedEventArgs e) { }

	[CalledBy(Type = typeof(JContainer), Member = "ReadTokenFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[AsyncStateMachine(typeof(<ReadContentFromAsync>d__1))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadContentFromAsync>d__1)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadContentFromAsync>d__1&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null) { }

	[CalledBy(Type = typeof(<ReadContentFromAsync>d__1), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JObject), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(JProperty))]
	[Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JToken), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IJsonLineInfo), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[NullableContext(2)]
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	[CalledBy(Type = typeof(JArray), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JArray))]
	[CalledBy(Type = typeof(JConstructor), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JConstructor))]
	[CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JObject))]
	[CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(JProperty))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(JsonLoadSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonReader), typeof(string)}, ReturnType = typeof(JsonReaderException))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	[AsyncStateMachine(typeof(<ReadTokenFromAsync>d__0))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JArray+<LoadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JConstructor+<LoadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject+<LoadAsync>d__2", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JProperty+<LoadAsync>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadTokenFromAsync>d__0)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReadTokenFromAsync>d__0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public void remove_AddingNew(AddingNewEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(2)]
	public override void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	public override void remove_ListChanged(ListChangedEventHandler value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveAll() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[NullableContext(2)]
	internal override bool RemoveItem(JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	internal override void RemoveItemAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ReplaceAll(object content) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void ReplaceItem(JToken existing, JToken replacement) { }

	[CalledBy(Type = typeof(JProperty), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JContainer), Member = "CheckReentrancy", ReturnType = typeof(void))]
	[Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
	[Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListChangedType), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotifyCollectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyCollectionChangedAction), typeof(object), typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 25)]
	[ContainsUnimplementedInstructions]
	[NullableContext(2)]
	internal override void SetItem(int index, JToken item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	private override int System.Collections.IList.Add(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.IList.Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	private override bool System.Collections.IList.Contains(object value) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	private override object System.Collections.IList.get_Item(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	private override int System.Collections.IList.IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	private override void System.Collections.IList.Remove(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JContainer), Member = "EnsureValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(JToken))]
	[CallsDeduplicatedMethods(Count = 1)]
	[NullableContext(2)]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddingNewEventArgs), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private override object System.ComponentModel.IBindingList.AddNew() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_AllowNew() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_IsSorted() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	private override PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.ComponentModel.IBindingList.RemoveSort() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyDescriptor[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private override PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	[CalledBy(Type = typeof(JTokenWriter), Member = "AddJValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JValue), typeof(JsonToken)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(2)]
	internal bool TryAdd(object content) { }

	[CalledBy(Type = typeof(JContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JToken), Member = "AddAfterSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JToken), Member = "AddBeforeSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(JContainer), Member = "IsMultiContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JContainer), Member = "TryAddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[NullableContext(2)]
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	[CalledBy(Type = typeof(JContainer), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "Merge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JContainer), Member = "MergeEnumerableContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JContainer), typeof(IEnumerable), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "MergeItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(JsonMergeSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JContainer), Member = "IsMultiContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void ValidateContent(object content) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal override void ValidateToken(JToken o, JToken existing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(2)]
	public virtual IEnumerable<T> Values() { }

}

