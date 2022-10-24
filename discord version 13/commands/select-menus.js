const { SelectMenuBuilder } = require('@discordjs/builders');
const { SlashCommandBuilder } = require('discord.js');
const { ActionRowBuilder } = require("discord.js");
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
                        .setMinValues(2) //옵션을 최소 몇개인지 선택해야하는 함수
                        .setMaxValues(3) //옵션을 최대 몇개인지 선택하는 함수
                        .addOptions(
                            {
                                label: "셀렉트1",
                                description:"설명1",
                                value: "select1",
                            },
                            {
                                label: "셀렉트2",
                                description:"설명2",
                                value: "select2",
                            },
                            {
                                label: "셀렉트3",
                                description:"설명3",
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
                let selected = "";
                interaction.values.map((value) => {
                    // 반복하면서 실행
                    switch(value) {
                        case "select1":
                            selected += "1번 "
                            break;
                        case "select2":
                            selected += "2번 "
                            break;
                        case "select3":
                            selected += "3번 "
                            break;
                    }
                });
                interaction.reply(selected + "선택됨!");
            }
        });

        collector.on("end", async (collect) => {
            console.log("시간초과!");
        })
	},
};
