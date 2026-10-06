using System;
using R2API;

namespace ConscriptMod.Modules;

internal static class Tokens
{
    internal static void AddTokens()
    {
        string text = "MANTI_CONSCRIPT_BODY_";
        string text2 = string.Concat(string.Concat(string.Concat(string.Concat("Conscript is a versatile and heavy-hitting mid-range survivor.<color=#c300ff>" + Environment.NewLine + Environment.NewLine, "< ! > Your R76 Rifle is a consistant source of damage at mid-range.", Environment.NewLine, Environment.NewLine), "< ! > The Baton can be used to stun enemies which get too close.", Environment.NewLine, Environment.NewLine), "< ! > Kick nearby enemies to make some distance.", Environment.NewLine, Environment.NewLine), "< ! > Electric Grenades are a great way to damage and stun large crowds of enemies.", Environment.NewLine, Environment.NewLine);
        string text3 = "..and so he left, another mission complete.";
        string text4 = "..and so he vanished, another casuality of war.";
        LanguageAPI.Add(text + "NAME", "Conscript");
        LanguageAPI.Add(text + "DESCRIPTION", text2);
        LanguageAPI.Add(text + "SUBTITLE", "The Maniacal Soldier");
        string text5 = "Armed with an R79 Rifle in his hands, he charged directly towards the battlefield with little to no sense of self-preservation. Upon seeing the enemy, he'd aim and pull the trigger, bringing down foe after foe who were unfortunate enough to not get out of the way of the blast. The soldier by many others was seen as patriotic and willing to do anything and everything for their colony. In fact, he was even put on several posters and seen as a war hero despite him being a conscripted unit. Of course, the Military knew that he wasn't a patriot, nor a war hero. He knew that they were a deranged soldier who was much to eager to enter the battlefield and follow orders because he enjoyed the thrill of killing. At first, this wasn't a problem given that he was fighting a war at the time, and a loyal soldier was necessary.But when the fighting was near its end, they feared what he would do when there is no one left for him to fight. Then one day, the Military had gotten word that a Free Company had just opened up and were looking for members to join them.They saw this as an opportunity.";
        text5 = string.Concat(text5 + Environment.NewLine + Environment.NewLine + "--- YOU HAVE BEEN REASSIGNED.REPORT TO COMMAND FOR YOUR NEW ASSIGNMENT.---" + Environment.NewLine + Environment.NewLine, "When the message was recieved, the soldier asked no questions nor made no comment.He got his reassignment then gathered his belongings.made his way to the transport.He knew that the war he used to fight would end.Being a part of the Free Company of course meant that he was able to continue the thrills that he felt being on the battlefield. The mission that came in from the UES Safe Travels was just another mission to complete.");
        LanguageAPI.Add(text + "LORE", text5);
        LanguageAPI.Add(text + "OUTRO_FLAVOR", text3);
        LanguageAPI.Add(text + "OUTRO_FAILURE", text4);
        LanguageAPI.Add(text + "DEFAULT_SKIN_NAME", "Default");
        LanguageAPI.Add(text + "MASTERY_SKIN_NAME", "Marine");
        LanguageAPI.Add(text + "PASSIVE_NAME", "Reactive Vitality System");
        LanguageAPI.Add(text + "PASSIVE_DESCRIPTION", "Healing recharges Shield.");
        LanguageAPI.Add(text + "PRIMARY_RIFLE_NAME", "R76 - Focus Fire Configured");
        LanguageAPI.Add(text + "PRIMARY_RIFLE_DESCRIPTION", $"Fire a Piercing shot for <style=cIsDamage>{300f}% damage</style>.");
        LanguageAPI.Add(text + "PRIMARY_ALT_RIFLE_NAME", "R76 - Burst Fire Configured");
        LanguageAPI.Add(text + "PRIMARY_ALT_RIFLE_DESCRIPTION", $"Fire a burst of shots for <style=cIsDamage>10x{100f}% damage</style>.");
        LanguageAPI.Add(text + "SECONDARY_BATON_NAME", "Electric Baton");
        LanguageAPI.Add(text + "SECONDARY_BATON_DESCRIPTION", $"<style=cIsUtility>Stunning</style>. Lunge and swing your Baton for <style=cIsDamage>{500f}% damage</style>.");
        LanguageAPI.Add(text + "UTILITY_KICK_NAME", "Defensive Kick");
        LanguageAPI.Add(text + "UTILITY_KICK_DESCRIPTION", $"Kick enemies in front of you, knocking them back and dealing <style=cIsDamage>{1200f}% damage</style>.");
        LanguageAPI.Add(text + "SPECIAL_GRENADE_NAME", "Electric Grenade");
        LanguageAPI.Add(text + "SPECIAL_GRENADE_DESCRIPTION", $"<style=cIsUtility>Stunning</style>. Throw an Electric Grenade which deals <style=cIsDamage>{800f}% damage</style>. Can hold up to 2.");
        LanguageAPI.Add(text + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Conscript: Mastery");
        LanguageAPI.Add(text + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Conscript, beat the game or obliterate on Monsoon.");
        LanguageAPI.Add(text + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Conscript: Mastery");
    }
}
