namespace UnityEngine.InputSystem.Composites;

[DisplayName("Up/Down/Left/Right/Forward/Backward Composite")]
[DisplayStringFormat("{up}+{down}/{left}+{right}/{forward}+{backward}")]
public class Vector3Composite : InputBindingComposite<Vector3>
{
	internal enum Mode
	{
		Analog = 0,
		DigitalNormalized = 1,
		Digital = 2,
	}

	[InputControl(layout = "Axis")]
	public int up; //Field offset: 0x10
	[InputControl(layout = "Axis")]
	public int down; //Field offset: 0x14
	[InputControl(layout = "Axis")]
	public int left; //Field offset: 0x18
	[InputControl(layout = "Axis")]
	public int right; //Field offset: 0x1C
	[InputControl(layout = "Axis")]
	public int forward; //Field offset: 0x20
	[InputControl(layout = "Axis")]
	public int backward; //Field offset: 0x24
	public Mode mode; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.InputSystem.InputControlExtensions+<GetAllButtonPresses>d__43", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public Vector3Composite() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual Vector3 ReadValue(ref InputBindingCompositeContext context) { }

}

