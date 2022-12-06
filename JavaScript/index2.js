// Discord.js version 12.5.3
const Discord = require('discord.js');
const client = new Discord.Client()
const {prefix, token} = require('./config.json');
const fs = require('fs');

client.commands = new Discord.Collection();
const commandFiles = fs.readdirSync('./commands').filter(file => file.endsWith('.js'));
for(const file of commandFiles){
    const command = require(`./commands/${file}`);
    client.commands.set(command.name,command);
};
 
client.on('ready' , () =>{ // client on() : 이벤트가 발생하면 실행되는 이벤트 핸들러 *once는 한번 on은 여러번*
    console.log("봇이 준비되었습니다");
});
client.on('message', (msg) =>{
    if(!msg.content.startsWith(prefix) || msg.author.bot) return
    const args = msg.content.slice(prefix.length).trim().split(/ +/);
    const commandName = args.shift()
    const command = client.commands.get(commandName);
    try{
        command.execute(msg,args);
    }catch(error){ // try/catch로 에러를 잡아냄.(예외처리) 
        console.log(error); //에러가 발생하게 되면 멈추지 않고 콘솔로 출력하게 됨
    }
});

client.login(token);