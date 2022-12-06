const Discord = require('discord.js');
const client = new Discord.Client({ intents: ["GUILDS","GUILD_MESSAGES"]});

client.on('ready' , () =>{ // client on() : 이벤트가 발생하면 실행되는 이벤트 핸들러 *once는 한번 on은 여러번*
    console.log("봇이 준비되었습니다");
});
client.on('message', (msg) =>{
    if (msg.content.startsWith("핑")) { //메세지가 핑으로 시작된다면
        msg.channel.send("퐁!") //퐁! 이라는 메세지를 채널에 전송
    }
});

client.login('디스코드 봇 토큰');