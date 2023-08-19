// accesses MBDS packet stream using console
function SendPacket(packet) {
	console.log(JSON.stringify(packet));
}

// Write all @"content" to the file at @"path"
export function WriteAllText(path, content)
{
	SendPacket({
		type: `WriteAllText`,
		path: path,
		contents: content
	})
}

// Create directory/folder at @"path"
export function CreateDirectory(path)
{
	SendPacket({
		type: `CreateDirectory`,
		path: path
	})
}

// Execute a console level command via @"command"
export function ExecuteCommand(command)
{
	SendPacket({
		type: `ExecuteCommand`,
		command: command
	})
}