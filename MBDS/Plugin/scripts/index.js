import { world, system, EquipmentSlot } from '@minecraft/server';

import { WriteAllText, CreateDirectory, ExecuteCommand } from 'fileio.js';

// some examples of the MBDS bridge use
world.afterEvents.itemUse.subscribe(evd => {
	// Right click carrot on a stick to reload plugins
	if (evd.itemStack.typeId == 'minecraft:carrot_on_a_stick')
	{
		// execute reload command from console level
		ExecuteCommand("reload");
		world.sendMessage("§c§aReloaded all plugins");
	}

	// writing to files example
	if (evd.itemStack.typeId == 'minecraft:compass')
	{
		// create serverdata in workspace folder (if it doesnt exist)
		CreateDirectory("ServerData")

		// create two files in the serverdata folder
		WriteAllText("ServerData\\text.txt", "Hello, world!")
		WriteAllText("ServerData\\cian.txt", "cian is such a fucking nigger jrytryhjhtrjkvjuhreeritsjhneeh0945vjh9e45phtieo")
		
		world.sendMessage("§c§aWritten files to server workspace");
	}
	
	return;
});