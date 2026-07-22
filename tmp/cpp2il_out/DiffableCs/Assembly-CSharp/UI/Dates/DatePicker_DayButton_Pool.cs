namespace UI.Dates;

public class DatePicker_DayButton_Pool : MonoBehaviour
{
	private DatePicker _datePicker; //Field offset: 0x20
	[SerializeField]
	private RectTransform _poolRect; //Field offset: 0x28
	private Dictionary<DatePickerDayButtonType, DatePicker_DayButton_Pool_List> pool; //Field offset: 0x30

	private DatePicker datePicker
	{
		[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetPoolList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton_Pool_List))]
		[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 141
	}

	private RectTransform poolRect
	{
		[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetPoolList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton_Pool_List))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		private get { } //Length: 541
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public DatePicker_DayButton_Pool() { }

	[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "GetPoolList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton_Pool_List))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void AddExistingButton(DatePicker_DayButton button) { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void FreeAll() { }

	[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetPoolList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton_Pool_List))]
	[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	private DatePicker get_datePicker() { }

	[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetPoolList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton_Pool_List))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private RectTransform get_poolRect() { }

	[CalledBy(Type = typeof(DatePicker), Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "GetPoolList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton_Pool_List))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool_List), Member = "GetButton", ReturnType = typeof(DatePicker_DayButton))]
	[CallsUnknownMethods(Count = 1)]
	public DatePicker_DayButton GetButton(DatePickerDayButtonType type) { }

	[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "AddExistingButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_DayButton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_DayButton_Pool), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(DatePicker_DayButton))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "get_poolRect", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "get_datePicker", ReturnType = typeof(DatePicker))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private DatePicker_DayButton_Pool_List GetPoolList(DatePickerDayButtonType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_DayButton_Pool), Member = "get_datePicker", ReturnType = typeof(DatePicker))]
	[CallsUnknownMethods(Count = 1)]
	private DatePicker_DayButton GetTemplate(DatePickerDayButtonType type) { }

	[CalledBy(Type = typeof(DatePicker), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "InvalidateAllDayButtonTemplates", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool_List), Member = "Invalidate", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void InvalidateAll() { }

	[CalledBy(Type = typeof(DatePicker), Member = "InvalidateDayButtonTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePickerDayButtonType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DatePicker_DayButton_Pool_List), Member = "Invalidate", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void InvalidateType(DatePickerDayButtonType type) { }

}

