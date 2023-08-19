import { world, system, EquipmentSlot } from '@minecraft/server';

import { WriteAllText, CreateDirectory, ExecuteCommand } from 'fileio.js';

world.afterEvents.itemUse.subscribe(evd => {
	if (evd.itemStack.typeId == 'minecraft:carrot_on_a_stick')
	{
		//CreateDirectory("ServerData")
		//WriteAllText("ServerData\\text.txt", "Hello, world!")
		//WriteAllText("ServerData\\cian.txt", "cian is such a fucking nigger jrytryhjhtrjkvjuhreeritsjhneeh0945vjh9e45phtieo")
		
		// execute reload command from console level
		ExecuteCommand("reload");
		world.sendMessage("§c§aReloaded all plugins");
	}
	
	if (evd.itemStack.typeId == 'minecraft:compass')
	{
		CreateDirectory("ServerData")
		WriteAllText("ServerData\\text.txt", "Hello, world!")
		WriteAllText("ServerData\\cian.txt", "cian is such a fucking nigger jrytryhjhtrjkvjuhreeritsjhneeh0945vjh9e45phtieo")
		
		world.sendMessage("§c§aWritten files to server workspace");
	}
	
	// idk if i wanna do stuff if failed yet
	return;
});