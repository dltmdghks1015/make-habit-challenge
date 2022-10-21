const { ActionRowBuilder, ButtonBuilder } = require('@discordjs/builders');
const { SlashCommandBuilder } = require('discord.js');

module.exports = {
	data: new SlashCommandBuilder()
		.setName('버튼')
		.setDescription('버튼을 만듭니다!'),
	async execute(interaction) {
        const row = new ActionRowBuilder().addComponents(
            new ButtonBuilder()
                .setCustomId("test1")
                .setLabel("첫번째")
                .setStyle("PRIMARY")
        );

		await interaction.reply({
            content: '버튼!', components: [row]
        });
	},
};