// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class InventoryEditor : ModuleRules
{
	public InventoryEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(
			new string[] {
				"Inventory",
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore",
				"Kismet",
				"EditorStyle",
				"Slate",
				"SlateCore"
			}
		);

		PrivateIncludePaths.AddRange(
			new string[] {
				"InventoryEditor/Private",
			}
		);

		var DynamicModuleNames = new string[] {
			"LevelEditor",
			"PropertyEditor",
		};

		foreach (var Name in DynamicModuleNames)
		{
			PrivateIncludePathModuleNames.Add(Name);
			DynamicallyLoadedModuleNames.Add(Name);
		}
	}
}
