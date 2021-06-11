using UnityEngine;
using RoR2;
using LabRebalance.Characters;
namespace LabRebalance
{
    class RebalBase
    {
        public static void Rebalance()
        {
            RebalConfig.ConfigSetup();
            On.RoR2.BodyCatalog.Init += orig =>
            {
                orig();
                CharChanges.Gaming();
            };
        }
        public static GameObject mandoPrefab;
        public static CharBase mandoStats;
        public static GameObject huntPrefab;
        public static CharBase huntStats;
        public static GameObject bndtPrefab;
        public static CharBase bndtStats;
        public static GameObject multPrefab;
        public static CharBase multStats;
        public static GameObject engiPrefab;
        public static CharBase engiStats;
        public static GameObject artiPrefab;
        public static CharBase artiStats;
        public static GameObject mercPrefab;
        public static CharBase mercStats;
        public static GameObject rexPrefab;
        public static CharBase rexStats;
        public static GameObject lodrPrefab;
        public static CharBase lodrStats;
        public static GameObject crocPrefab;
        public static CharBase crocStats;
        public static GameObject captPrefab;
        public static CharBase captStats;
        public static GameObject birbPrefab;
        public static CharBase birbStats;
    }
}
