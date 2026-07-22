namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/ScriptingRuntime.h")]
[VisibleToOtherModules]
internal class ScriptingRuntime
{

	[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static String[] GetAllUserAssemblies() { }

}

