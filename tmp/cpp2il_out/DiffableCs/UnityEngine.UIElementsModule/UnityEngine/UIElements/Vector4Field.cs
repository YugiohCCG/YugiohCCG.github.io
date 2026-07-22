namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector4Field : BaseCompositeField<Vector4, FloatField, Single>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector4, Single> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_1; //Field offset: 0x10
		public static Func<Vector4, Single> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_3; //Field offset: 0x20
		public static Func<Vector4, Single> <>9__0_4; //Field offset: 0x28
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_5; //Field offset: 0x30
		public static Func<Vector4, Single> <>9__0_6; //Field offset: 0x38
		public static WriteDelegate<Vector4, FloatField, Single> <>9__0_7; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal float <DescribeFields>b__0_0(Vector4 r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_1(ref Vector4 r, float v) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal float <DescribeFields>b__0_2(Vector4 r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_3(ref Vector4 r, float v) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal float <DescribeFields>b__0_4(Vector4 r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_5(ref Vector4 r, float v) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal float <DescribeFields>b__0_6(Vector4 r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_7(ref Vector4 r, float v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Vector4Field, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Vector4>
	{
		private UxmlFloatAttributeDescription m_XValue; //Field offset: 0x98
		private UxmlFloatAttributeDescription m_YValue; //Field offset: 0xA0
		private UxmlFloatAttributeDescription m_ZValue; //Field offset: 0xA8
		private UxmlFloatAttributeDescription m_WValue; //Field offset: 0xB0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector4>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public UxmlTraits() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static Vector4Field() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector4, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public Vector4Field() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector4, System.Object, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[Calls(Type = typeof(Image), Member = "ReadCustomProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomStyle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public Vector4Field(string label) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	internal virtual FieldDescription<Vector4, FloatField, Single>[] DescribeFields() { }

}

