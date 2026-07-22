namespace UnityEngine.InputSystem.Processors;

public class StickDeadzoneProcessor : InputProcessor<Vector2>
{
	public float min; //Field offset: 0x10
	public float max; //Field offset: 0x14

	private float maxOrDefault
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 110
	}

	private float minOrDefault
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 110
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StickDeadzoneProcessor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private float get_maxOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private float get_minOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private float GetDeadZoneAdjustedValue(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual Vector2 Process(Vector2 value, InputControl control = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}

