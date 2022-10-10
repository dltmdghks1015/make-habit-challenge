module.exports = {
    name : "ping",
    cooldown : 5,
    execute(message){
        const Discord = require('discord.js')
        const Embed = new Discord.MessageEmbed()
        message.reply(Embed.setTitle("답변").setDescription("Pong").setColor("#FFFFFF").addField("핑","퐁").setAuthor("승환").setFooter("승환"))
    }
}