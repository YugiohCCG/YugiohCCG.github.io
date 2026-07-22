namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleDataRef : IEquatable<StyleDataRef`1<T>>
{
	private class RefCounted
	{
		private static uint m_NextId; //Field offset: 0x0
		private int m_RefCount; //Field offset: 0x0
		private readonly uint m_Id; //Field offset: 0x0
		public T value; //Field offset: 0x0

		public int refCount
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private static RefCounted() { }

		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Create", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public RefCounted() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public void Acquire() { }

		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public RefCounted<T> Copy() { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public int get_refCount() { }

		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Release", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public void Release() { }

	}

	private RefCounted<T> m_Ref; //Field offset: 0x0

	[CalledBy(Type = typeof(ComputedStyle), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedStyle))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public StyleDataRef<T> Acquire() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RefCounted), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(InheritedData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void CopyFrom(StyleDataRef<T> other) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "CreateInitial", ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RefCounted), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static StyleDataRef<T> Create() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool Equals(StyleDataRef<T> other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InheritedData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task`1), Member = "DangerousSetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "DangerousSetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<System.Boolean, System.Boolean, System.Byte>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 26)]
	[DeduplicatedMethod]
	public static bool op_Equality(StyleDataRef<T> lhs, StyleDataRef<T> rhs) { }

	[CallerCount(Count = 327)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T Read() { }

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool ReferenceEquals(StyleDataRef<T> other) { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RefCounted), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Release() { }

	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "FinalizeApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyUnityTextOutline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 79)]
	[Calls(Type = typeof(RefCounted), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RefCounted), Member = "Copy", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>+RefCounted<T>")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public T Write() { }

}

