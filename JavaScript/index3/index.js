// Discord.js version 12.5.3
const Discord = require('discord.js');
const client = new Discord.Client()
const {prefix, token} = require('./config.json');
const fs = require('fs');

client.commands = new Discord.Collection();

const cooldowns = new Discord.Collection()

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
    if(!command) return
    if(!cooldowns.has(command.name)){
        cooldowns.set(command.name,new Discord.Collection())
    }
    const now = Date.now()
    const timestamps = cooldowns.get(command.name)
    const cooldownAmount = (command.cooldown || 3)*1000
    if(timestamps.has(msg.author.id)){
        const expirationTime = timestamps.get(msg.author.id) + cooldownAmount
        if(now < expirationTime){
            const timeLeft = (expirationTime - now) / 1000
            return msg.reply(`${command.name} 해당 명령어를 사용하기 위해서는 ${timeLeft.toFixed(1)}초를 더 기다리셔야 합니다.`)
        }
    }
    timestamps.set(msg.author.id,now)
    setTimeout( () => timestamps.delete(msg.author.id),cooldownAmount)
    try{
        command.execute(msg,args);
    }catch(error){ // try/catch로 에러를 잡아냄.(예외처리) 
        console.log(error); //에러가 발생하게 되면 멈추지 않고 콘솔로 출력하게 됨
    }
});

client.login(token);