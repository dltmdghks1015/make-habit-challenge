const fs = require('fs');
const { REST, SlashCommandBuilder, Routes } = require('discord.js');
const { clientId, guildId, token } = require('./config.json');

const commandFile = fs.readdirSync('./commands').filter(file => file.endsWith('.js'));

const commands = [
	// new SlashCommandBuilder().setName('핑').setDescription('퐁!이라고 대답합니다'),
    // new SlashCommandBuilder().setName('play').setDescription('노래를 재생합니다'),
    // new SlashCommandBuilder().setName('서버').setDescription('서버 정보를 불러옵니다')
]
	.map(command => command.toJSON());

for (const file of commandFile) {
    const command = require(`./commands/${file}`);
    commands.push(command.data.toJSON());
}
const rest = new REST({ version: '10' }).setToken(token);

rest.put(Routes.applicationGuildCommands(clientId, guildId), { body: commands })
	.then((data) => console.log('성공했습니다.'))
	.catch(console.error);