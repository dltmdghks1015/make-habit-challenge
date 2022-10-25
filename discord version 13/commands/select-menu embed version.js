const { SelectMenuBuilder } = require('@discordjs/builders');
const { SlashCommandBuilder , ActionRowBuilder , EmbedBuilder } = require('discord.js');

module.exports = {
	data: new SlashCommandBuilder()
		.setName('셀렉트메뉴')
		.setDescription('셀렉트 메뉴를 호출합니다!'),
	async execute(interaction) {
        // 셀렉트 메뉴 기능을 만들어 줌
        const row = new ActionRowBuilder()
            .addComponents(
                    new SelectMenuBuilder()
                        .setCustomId('select')
                        .setPlaceholder('선택되지 않음')
                        .addOptions(
                            {
                                label: "봇 프로필",
                                description:"봇을 소개 합니다 (embed)",
                                value: "profile",
                            },
                            {
                                label: "봇 설명서",
                                description:"봇 설명서입니다",
                                value: "guide",
                            },
                            {
                                label: "셀렉트3",
                                description:"설명3(미구현)",
                                value: "select3",
                            },
                        )
            )
		await interaction.reply({ content: "셀렉트메뉴 호출",components: [row]});

        const filter = (interaction) => {
            return interaction.customId === "select";
        }
        // 셀렉트 메뉴를 선택하면 뭘 할지 개발해야 함
        const collector = interaction.channel.createMessageComponentCollector({
            filter,
            time: 60*1000,
        });

        collector.on("collect",async (interaction) => {
            if (interaction.customId === "select") {
                const selectedValue = interaction.values[0];
                if(selectedValue === "profile") {
                    // 디스코드 봇이 embed로 대답하게 함
                    const exampleEmbed = new EmbedBuilder()
	                    .setColor(0x0099FF)
	                    .setTitle('Some title')
	                    .setURL('https://discord.js.org/')
	                    .setAuthor({ name: 'Some name', iconURL: 'https://i.imgur.com/AfFp7pu.png', url: 'https://discord.js.org' })
	                    .setDescription('안녕하세요 디스코드 봇입니다. 저를 소개하겠습니다')
	                    .setThumbnail('https://i.imgur.com/AfFp7pu.png')
                        .addFields(
                            { name: '취미', value: '대답하기', inline: true },
                            { name: "특기", value: "로봇", inline: true },
                            { name: '혈액형', value: 'O형', inline: true },
                            { name: '사는곳', value: '컴퓨터', inline: true },
                            { name: "좋아하는것", value: "전기", inline: true },
                            { name: "싫어하는것", value: "물", inline: true }
                        )
	                    .addFields({ name: 'Inline field title', value: 'Some value here', inline: true })
	                    .setImage('https://i.imgur.com/AfFp7pu.png')
	                    .setTimestamp(new Date())
                    interaction.channel.send({ embeds: [exampleEmbed] });
                    interaction.deferUpdate(); //아무것도 하지 않음
                } else{
                    interaction.reply({
                        content: selectedValue + "기능이 구현되지 않았어!",
                        ephemral: true, //선택을 한 유저만 메세지를 볼 수 있음
                    });
                }
            }
        });

        collector.on("end", async (collect) => {
            console.log("시간초과!");
        })
	},
};