using UnrealBuildTool;

public class PrototypeProjectTarget : TargetRules
{
	public PrototypeProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PrototypeProject");
	}
}
