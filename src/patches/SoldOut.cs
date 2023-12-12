using HarmonyLib;
using GameNetcodeStuff;


namespace SoldOut.patches
{
  
  [HarmonyPatch]
  class SoldOut
  {
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Terminal), "SetItemSales")]
    static void SetItemSales(ref int[] ___itemSalesPercentages)
    { 
      for (int i=0; i<___itemSalesPercentages.Length; i++) 
        ___itemSalesPercentages[i] = 0;
    }
  }
}
