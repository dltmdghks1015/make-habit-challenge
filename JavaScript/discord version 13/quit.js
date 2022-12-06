const { SlashCommandBuilder, EmbedBuilder } = require("discord.js")

module.exports = {
    data : new SlashCommandBuilder()
        .setName("quit")
        .setDescription("Stops the bot and clears the queue"),
    run : async({ client, interaction }) => {
        const queue = client.player.getQueue(interaction.guildId)

        if (!queue) return await interaction.editReply("There are no songs in the queue")

        queue.destroy()
        await interaction.editReply("Bye!")
    },
}