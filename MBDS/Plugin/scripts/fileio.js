function SendPacket(packet) {
	// accesses MBDS packet stream using console
	console.log(JSON.stringify(packet));
}

export function WriteAllText(path, content)
{
	SendPacket({
		type: `WriteAllText`,
		path: path,
		contents: content
	})
}

export function CreateDirectory(path, content)
{
	SendPacket({
		type: `CreateDirectory`,
		path: path
	})
}

export function ExecuteCommand(command)
{
	SendPacket({
		type: `ExecuteCommand`,
		command: command
	})
}