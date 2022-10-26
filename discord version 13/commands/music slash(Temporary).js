const { Collection, VoiceChannel, DiscordAPIError, EmbedBuilder , SlashCommandBuilder } = require('discord.js');
const ydtl = require('ytdl-core');
const yts = require('yt-search');
const Playlist = new Collection();

module.exports = {
    data : new SlashCommandBuilder()
            .setName("노래")
            .setDescription("유튜브에서 노래를 찾고 재생하는 기능을 실행시키는 명령어"),
    async execute(message,args) {
        var PlaylistArray = new Array()
        const MGI = message.guild.id
        if(!Playlist.has(MGI)) Playlist.set(MGI, new Collection())
        else PlaylistArray = Playlist.get(MGI).get("musicplaylist")
        const MPL = Playlist.get(MGI).get("musicplaylist")
        if(MPL == null) Playlist.get(MGI).set("musicplaylist",PlaylistArray)
        const status = message.guild.voice?.connection?.status
        const client_voice_status = message.guild.voice?.connection?.speaking?.bitfield
        const client_voice = message.guild.voice
        if(args[0] == "재생"){
            const voiceChannel = message.member.voice.channel
            if(!voiceChannel) return message.reply("오류 : 이 명령어를 사용하기 위해서는 음성채널에 들어가 있으셔야 사용이 가능합니다.")
            if(status != null){
                if(VoiceChannel.id != client_voice?.channel.id){
                    if(client_voice_status == 1 || MPL[0] != null){
                        return message.reply("오류 : 노래가 다른 채널에서 재생중이거나 플레이리스트에 재생곡이 남아있습니다.")
                    }
                }
            }
            if(!args[1]){
                if(MPL[0] != null){
                    if(status == null){
                        await voiceChannel.join()
                        return music_play(message)
                    }else if(client_voice_status == 0) return music_play(message)
                    else return message.reply("오류 : 노래가 이미 재생되고 있습니다.")
                }else return message.reply("오류 : 유튜브에서 찾을 노래 제목이나 URL을 입력해주세요.")
            }
            const music = await search_youtube_music(message.content)
            if(!music) return message.reply("오류 : 검색 결과가 없습니다.")
            const data = {title: music.title, url: music.url}
            PlaylistArray.push(data)
            Playlist.get(MGI).set("musicplaylist",PlaylistArray)
            if(status != null){
                message.reply(new EmbedBuilder().setTitle("✅ 플레이리스트에 노래를 추가했어요 ✅").setDescription("**!노래 플레이리스트 확인** 명령어로 현재 플레이리스트를 확인할수있어요").setColor("#33ff73"))
                if(client_voice_status == 0) return music_play(message)
            }else{
                const permission = voiceChannel.permissionsFor(message.client.user)
                if(!permission.has('CONNECT')) return message.reply("오류 : 음성 채널 연결 권한이 없습니다.")
                if(!permission.has('SPEAK')) return message.reply("오류 : 본 명령어에서는 음성 채널에 말하기 권한이 필요합니다.")
                await voiceChannel.join()
                music_play(message)
            }
        }else if(args[0] == "종료"){
            if(MPL[0] != null || client_voice_status == 1) return message.reply("오류 : 모든 플레이리스트가 끝나지 않았습니다.")
            if(status == null) return message.reply("오류 : 노래가 이미 종료되어있습니다.")
            if(!IsJoinVoiceChannel(message)) return
            PlaylistArray = []
            Playlist.get(MGI).set("musicplaylist",PlaylistArray)
            await message.guild.voice.channel.leave()
            await message.reply("노래가 종료되었습니다 🙊")
        }else if(args[0] == "플레이리스트"){
            if(args[1] == "삭제" || args[1] == "확인"){
                switch(args[1]){
                    case "삭제":
                        PlaylistArray = Playlist.get(MGI).get("musicplaylist")
                        if(!args[2] || isNaN(args[2]) || args[2] > PlaylistArray.length || args[2] < 0) return message.reply("오류 : 플레이리스트에서 삭제 할 올바른 노래 번호를 입력해주세요.")
                        Playlist.get(MGI).set("musicplaylist",PlaylistArray.splice(--args[2],1))
                        message.reply(new EmbedBuilder().setTitle("⛔ 플레이리스트의 항목을 삭제했어요 ⛔").setDescription("**!노래 플레이리스트 확인** 명령어로 현재 플레이리스트를 확인 할 수 있어요"))
                        break
                    case "확인":
                        const Embed = new EmbedBuilder().setTitle("🎶 현재 플레이리스트 입니다 🎶").setColor("#009dff")
                        if(Playlist.get(MGI).get("musicplaylist") == null || Playlist.get(MGI).get("musicplaylist")[0] == null) return message.reply("표시 할 플레이리스트가 없습니다.")
                        PlaylistArray = Playlist.get(MGI).get("musicplaylist")
                        for(var i = 0; i < PlaylistArray.length; i++){
                            var number = i
                            Embed.addFields(`${++number}. ${PlaylistArray[i].title}`, `[바로가기](${PlaylistArray[i].url})`)
                        }
                        message.reply(Embed)
                        break
                }
            }else message.reply("오류 : 올바른 인수를 입력해주세요 (인수 : 삭제, 확인)")
        }else if(args[0] == "건너뛰기"){
            if(!IsJoinVoiceChannel(message)) return
            return music_play(message)
        }
    }
}

async function music_play(message){
    const voice = await message.guild.voice.connection
    const MGI = message.guild.id
    if(!Playlist.get(MGI).get("musicplaylist")[0]){
        message.reply(new EmbedBuilder().setTitle("✅ 플레이리스트의 끝이에요 ❎").setDescription(`노래를 종료합니다.`))
        return await voice.channel.leave()
    }
    const music = Playlist.get(MGI).get("musicplaylist")[0]
    var PlaylistArray = new Array()
    PlaylistArray = Playlist.get(MGI).get("musicplaylist")
    PlaylistArray.shift()
    Playlist.get(MGI).set("musicplaylist",PlaylistArray)
    message.reply(new EmbedBuilder().setTitle("✅ 유튜브에서 노래를 재생했어요 ✅").setDescription(`현재 재생곡 : [${music,title}](${music.url})`).setColor("#33ff7e"))
    const stream = await ydtl(music.url, {filter : 'audioonly'})
    voice.play(stream,{seek: 0, volume: 1}).on('finish',() =>{
        music_play(message)
    })
}

async function search_youtube_music(music_name){
    const r = await yts(music_name.split("!노래 재생")[1])
    const videos = r.videos.slice(0,1)
    return videos[0]
}

function IsJoinVoiceChannel(message){
    if(!message.member.voice.channel){
        message.reply("오류 : 본 명령어를 사용하기 위해서는 음성 채널에 속해있어야 사용이 가능합니다.")
        return false
    }else return true
}
