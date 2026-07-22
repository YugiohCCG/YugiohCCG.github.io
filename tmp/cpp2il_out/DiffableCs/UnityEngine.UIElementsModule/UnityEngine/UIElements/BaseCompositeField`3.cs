namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseCompositeField : BaseField<TValueType>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public FieldDescription<TValueType, TField, TFieldValue> desc; //Field offset: 0x0
		public TField field; //Field offset: 0x0
		public BaseCompositeField<TValueType, TField, TFieldValue> <>4__this; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass18_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseField`1), Member = "ValidatedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = "TValueType")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(TextInputBaseField`1), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		internal void <.ctor>b__1(ChangeEvent<TFieldValue> e) { }

	}

	public struct FieldDescription
	{
		internal sealed class WriteDelegate : MulticastDelegate
		{

			[CalledBy(Type = typeof(RectField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Rect, FloatField, Single>[]))]
			[CalledBy(Type = typeof(RectIntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<RectInt, IntegerField, Int32>[]))]
			[CalledBy(Type = typeof(Vector2Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2, FloatField, Single>[]))]
			[CalledBy(Type = typeof(Vector3Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3, FloatField, Single>[]))]
			[CalledBy(Type = typeof(Vector4Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector4, FloatField, Single>[]))]
			[CalledBy(Type = typeof(Vector2IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2Int, IntegerField, Int32>[]))]
			[CalledBy(Type = typeof(Vector3IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3Int, IntegerField, Int32>[]))]
			[CallerCount(Count = 13)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public WriteDelegate(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(ref TValueType val, TFieldValue fieldValue) { }

		}

		internal readonly string name; //Field offset: 0x0
		internal readonly string ussName; //Field offset: 0x0
		internal readonly Func<TValueType, TFieldValue> read; //Field offset: 0x0
		internal readonly WriteDelegate<TValueType, TField, TFieldValue> write; //Field offset: 0x0

		[CalledBy(Type = typeof(RectField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Rect, FloatField, Single>[]))]
		[CalledBy(Type = typeof(RectIntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<RectInt, IntegerField, Int32>[]))]
		[CalledBy(Type = typeof(Vector2Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2, FloatField, Single>[]))]
		[CalledBy(Type = typeof(Vector3Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3, FloatField, Single>[]))]
		[CalledBy(Type = typeof(Vector4Field), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector4, FloatField, Single>[]))]
		[CalledBy(Type = typeof(Vector2IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector2Int, IntegerField, Int32>[]))]
		[CalledBy(Type = typeof(Vector3IntField), Member = "DescribeFields", ReturnType = typeof(FieldDescription<Vector3Int, IntegerField, Int32>[]))]
		[CallerCount(Count = 22)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, WriteDelegate<TValueType, TField, TFieldValue> write) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string spacerUssClassName; //Field offset: 0x0
	public static readonly string multilineVariantUssClassName; //Field offset: 0x0
	public static readonly string fieldGroupUssClassName; //Field offset: 0x0
	public static readonly string fieldUssClassName; //Field offset: 0x0
	public static readonly string firstFieldVariantUssClassName; //Field offset: 0x0
	public static readonly string twoLinesVariantUssClassName; //Field offset: 0x0
	private List<TField> m_Fields; //Field offset: 0x0
	private bool m_ShouldUpdateDisplay; //Field offset: 0x0
	private bool m_ForceUpdateDisplay; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 61)]
	[DeduplicatedMethod]
	private static BaseCompositeField`3() { }

	[CalledBy(Type = typeof(RectField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RectField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "add_onValidateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TValueType, TValueType>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Focusable), Member = "set_delegatesFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Rect>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 30)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected BaseCompositeField`3(string label, int fieldsByLine) { }

	internal abstract FieldDescription<TValueType, TField, TFieldValue>[] DescribeFields() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private VisualElement GetSpacer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<UnityEngine.Rect>), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal virtual void OnViewDataReady() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.Rect>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.Rect>))]
	[Calls(Type = typeof(BaseField`1), Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void UpdateDisplay() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void UpdateMixedValueContent() { }

}

