using RoR2;
using UnityEngine;

namespace LabRebalance.Characters
{
    class CharChanges : RebalBase
    {
        public static void Gaming()
        {
            Debug.Log("Importing changes...");
            mandoPrefab = BodyCatalog.FindBodyPrefab("CommandoBody");
            ApplyChanges(mandoPrefab.GetComponent<CharacterBody>(), mandoStats);
            Debug.Log("Commando done.");
            huntPrefab = BodyCatalog.FindBodyPrefab("HuntressBody");
            ApplyChanges(huntPrefab.GetComponent<CharacterBody>(), huntStats);
            Debug.Log("Huntress done.");
            bndtPrefab = BodyCatalog.FindBodyPrefab("Bandit2Body");
            ApplyChanges(bndtPrefab.GetComponent<CharacterBody>(), bndtStats);
            Debug.Log("Bandit done.");
            multPrefab = BodyCatalog.FindBodyPrefab("ToolbotBody");
            ApplyChanges(multPrefab.GetComponent<CharacterBody>(), multStats);
            Debug.Log("MUL-T done.");
            engiPrefab = BodyCatalog.FindBodyPrefab("EngiBody");
            ApplyChanges(engiPrefab.GetComponent<CharacterBody>(), engiStats);
            Debug.Log("Engineer done.");
            artiPrefab = BodyCatalog.FindBodyPrefab("MageBody");
            ApplyChanges(artiPrefab.GetComponent<CharacterBody>(), artiStats);
            Debug.Log("Artificer done.");
            mercPrefab = BodyCatalog.FindBodyPrefab("MercBody");
            ApplyChanges(mercPrefab.GetComponent<CharacterBody>(), mercStats);
            Debug.Log("Mercenary done.");
            rexPrefab = BodyCatalog.FindBodyPrefab("TreebotBody");
            ApplyChanges(rexPrefab.GetComponent<CharacterBody>(), rexStats);
            Debug.Log("REX done.");
            lodrPrefab = BodyCatalog.FindBodyPrefab("LoaderBody");
            ApplyChanges(lodrPrefab.GetComponent<CharacterBody>(), lodrStats);
            Debug.Log("Loader done.");
            crocPrefab = BodyCatalog.FindBodyPrefab("CrocoBody");
            ApplyChanges(crocPrefab.GetComponent<CharacterBody>(), crocStats);
            Debug.Log("Acrid done.");
            captPrefab = BodyCatalog.FindBodyPrefab("CaptainBody");
            ApplyChanges(captPrefab.GetComponent<CharacterBody>(), captStats);
            Debug.Log("Captain done.");
            birbPrefab = BodyCatalog.FindBodyPrefab("HereticBody");
            ApplyChanges(birbPrefab.GetComponent<CharacterBody>(), birbStats);
            Debug.Log("Heretic done.");
        }
        public static void ApplyChanges(CharacterBody body, CharBase charBase)
        {
            body.baseMaxHealth = charBase.healthBase;
            body.levelMaxHealth = charBase.healthLevel;
            body.baseRegen = charBase.regenBase;
            body.levelRegen = charBase.regenLevel;
            body.baseMaxShield = charBase.shieldBase;
            body.levelMaxShield = charBase.shieldLevel;
            body.baseDamage = charBase.damageBase;
            body.levelDamage = charBase.damageLevel;
            body.baseArmor = charBase.armor;
            body.baseMoveSpeed = charBase.moveSpeed;
        }
    }
}
