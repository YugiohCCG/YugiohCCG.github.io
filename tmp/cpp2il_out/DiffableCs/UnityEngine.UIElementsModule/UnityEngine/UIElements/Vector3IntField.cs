namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, Int32>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector3Int, Int32> <>9__0_0; //Field offset: 0x8
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_1; //Field offset: 0x10
		public static Func<Vector3Int, Int32> <>9__0_2; //Field offset: 0x18
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_3; //Field offset: 0x20
		public static Func<Vector3Int, Int32> <>9__0_4; //Field offset: 0x28
		public static WriteDelegate<Vector3Int, IntegerField, Int32> <>9__0_5; //Field offset: 0x30

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
		internal int <DescribeFields>b__0_0(Vector3Int r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_1(ref Vector3Int r, int v) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int <DescribeFields>b__0_2(Vector3Int r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_3(ref Vector3Int r, int v) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int <DescribeFields>b__0_4(Vector3Int r) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void <DescribeFields>b__0_5(ref Vector3Int r, int v) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Vector3IntField, UxmlTraits>
	{

		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Vector3Int>
	{
		private UxmlIntAttributeDescription m_XValue; //Field offset: 0x98
		private UxmlIntAttributeDescription m_YValue; //Field offset: 0xA0
		private UxmlIntAttributeDescription m_ZValue; //Field offset: 0xA8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1+UxmlTraits<UnityEngine.Vector3Int>), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public UxmlTraits() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static Vector3IntField() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3IntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public Vector3IntField() { }

	[CalledBy(Type = typeof(BoundsIntField), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3IntField), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseCompositeField`3<UnityEngine.Vector3Int, System.Object, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "get_visualInput", ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 1)]
	public Vector3IntField(string label) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Func`2<TValueType, TFieldValue>", "UnityEngine.UIElements.BaseCompositeField`3<TValueType, TField, TFieldValue>+FieldDescription<TValueType, TField, TFieldValue>+WriteDelegate<TValueType, TField, TFieldValue>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	internal virtual FieldDescription<Vector3Int, IntegerField, Int32>[] DescribeFields() { }

}

