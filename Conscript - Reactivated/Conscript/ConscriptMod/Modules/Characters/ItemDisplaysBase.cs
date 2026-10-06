using System.Collections.Generic;
using RoR2;

namespace ConscriptMod.Modules.Characters;

public abstract class ItemDisplaysBase
{
    public void SetItemDisplays(ItemDisplayRuleSet itemDisplayRuleSet)
    {
        List<ItemDisplayRuleSet.KeyAssetRuleGroup> list = new List<ItemDisplayRuleSet.KeyAssetRuleGroup>();
        this.SetItemDisplayRules(list);
        itemDisplayRuleSet.keyAssetRuleGroups = list.ToArray();
    }

    protected abstract void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules);
}
