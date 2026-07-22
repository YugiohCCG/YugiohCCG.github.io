namespace UnityEngine.InputSystem.Controls;

public class DpadControl : Vector2Control
{
	public enum ButtonBits
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3,
	}

	[InputControlLayout(hideInUI = True)]
	internal class DpadAxisControl : AxisControl
	{
		[CompilerGenerated]
		private int <component>k__BackingField; //Field offset: 0x130

		public int component
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			 set { } //Length: 7
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AxisControl), Member = ".ctor", ReturnType = typeof(void))]
		public DpadAxisControl() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AxisControl), Member = "FinishSetup", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputControl), Member = "get_name", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		protected virtual void FinishSetup() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_component() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		public void set_component(int value) { }

	}

	[CompilerGenerated]
	private ButtonControl <up>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private ButtonControl <down>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <left>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private ButtonControl <right>k__BackingField; //Field offset: 0x138

	[InputControl(bit = 1, displayName = "Down")]
	public ButtonControl down
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(bit = 2, displayName = "Left")]
	public ButtonControl left
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(bit = 3, displayName = "Right")]
	public ButtonControl right
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = True)]
	[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = True)]
	[InputControl(bit = 0, displayName = "Up")]
	public ButtonControl up
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2Control), Member = ".ctor", ReturnType = typeof(void))]
	public DpadControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(Vector2Control), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_down() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_left() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_right() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ButtonControl get_up() { }

	[CalledBy(Type = typeof(Vector2Composite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = true) { }

	[CalledBy(Type = typeof(Vector2Composite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	public static Vector2 MakeDpadVector(float up, float down, float left, float right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_down(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_left(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_right(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_up(ButtonControl value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValueIntoState(Vector2 value, Void* statePtr) { }

}

