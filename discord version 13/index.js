// Discord.js Version 13
const { Client, Collection, Intents, GatewayIntentBits } = require('discord.js');
const { token } = require('./config.json');
const fs = require('fs');


// Create a new client instance
const client = new Client({ intents: [GatewayIntentBits.Guilds] });
// GUILDS == Server

client.commands = new Collection();
const commandFile = fs.readdirSync('./commands').filter(file => file.endsWith('.js'));

for (const file of commandFile) {
    const command = require(`./commands/${file}`);
    client.commands.set(command.data.name, command);
}

// When the client is ready, run this code (only once)
client.once('ready', () => {
    console.log('봇이 준비 되었습니다');
});

client.on('interactionCreate', async interaction => {
	if (!interaction.isChatInputCommand()) return;

	const command = client.commands.get(interaction.commandName);

    if (!command) return; // 만약 command가 없으면 아무것도 실행 하지마라

    try{
        await command.execute(interaction); // 만약 실행해서 command.execute의 에러가 발생하면 catch를 실행 발생이 안되면 try 실행
    } catch (error) {
        console.error(error);
        await interaction.reply({ content : 'There was an error while executing this command!', ephemeral: true});
    }
});

// Login to Discord with your client's token
client.login(token);