using LabRebalance.Characters;
using BepInEx.Configuration;
using BepInEx;

namespace LabRebalance
{
    class RebalConfig : RebalBase
    {
        public static void ConfigSetup()
        {
            StatConfig = new ConfigFile(Paths.ConfigPath + "\\SurvivorConfig.cfg", true);
            MandoConfig();
            HuntConfig();
            BndtConfig();
            MulTConfig();
            EngiConfig();
            ArtiConfig();
            MercConfig();
            RexConfig();
            LodrConfig();
            CrocConfig();
            CaptConfig();
            BirbConfig();
        }
        public static void MandoConfig()
        {
            MandoBaseHealth = StatConfig.Bind<float>("Commando", "Base Health", 110);
            MandoLevelHealth = StatConfig.Bind<float>("Commando", "Health by level", 33);
            MandoBaseShield = StatConfig.Bind<float>("Commando", "Base Shield", 0);
            MandoLevelShield = StatConfig.Bind<float>("Commando", "Shield by level", 0);
            MandoBaseRegen = StatConfig.Bind<float>("Commando", "Base Regen", 1);
            MandoLevelRegen = StatConfig.Bind<float>("Commando", "Regen by level", 0.2f);
            MandoBaseDamage = StatConfig.Bind<float>("Commando", "Base Damage", 12);
            MandoLevelDamage = StatConfig.Bind<float>("Commando", "Damage by level", 2.4f);
            MandoArmor = StatConfig.Bind<float>("Commando", "Armor", 0);
            MandoSpeed = StatConfig.Bind<float>("Commando", "Base Speed", 7);
            mandoStats = new CharBase
            {
                healthBase = MandoBaseHealth.Value,
                healthLevel = MandoLevelHealth.Value,
                regenBase = MandoBaseRegen.Value,
                regenLevel = MandoLevelRegen.Value,
                damageBase = MandoBaseDamage.Value,
                damageLevel = MandoLevelDamage.Value,
                shieldBase = MandoBaseShield.Value,
                shieldLevel = MandoLevelShield.Value,
                armor = MandoArmor.Value,
                moveSpeed = MandoSpeed.Value
            };
        }
        public static void HuntConfig()
        {
            HuntBaseHealth = StatConfig.Bind<float>("Huntress", "Base Health", 90);
            HuntLevelHealth = StatConfig.Bind<float>("Huntress", "Health by level", 27);
            HuntBaseShield = StatConfig.Bind<float>("Huntress", "Base Shield", 0);
            HuntLevelShield = StatConfig.Bind<float>("Huntress", "Shield by level", 0);
            HuntBaseRegen = StatConfig.Bind<float>("Huntress", "Base Regen", 1);
            HuntLevelRegen = StatConfig.Bind<float>("Huntress", "Regen by level", 0.2f);
            HuntBaseDamage = StatConfig.Bind<float>("Huntress", "Base Damage", 12);
            HuntLevelDamage = StatConfig.Bind<float>("Huntress", "Damage by level", 2.4f);
            HuntArmor = StatConfig.Bind<float>("Huntress", "Armor", 0);
            HuntSpeed = StatConfig.Bind<float>("Huntress", "Base Speed", 7);
            huntStats = new CharBase
            {
                healthBase = HuntBaseHealth.Value,
                healthLevel = HuntLevelHealth.Value,
                regenBase = HuntBaseRegen.Value,
                regenLevel = HuntLevelRegen.Value,
                damageBase = HuntBaseDamage.Value,
                damageLevel = HuntLevelDamage.Value,
                shieldBase = HuntBaseShield.Value,
                shieldLevel = HuntLevelShield.Value,
                armor = HuntArmor.Value,
                moveSpeed = HuntSpeed.Value
            };
        }
        public static void BndtConfig()
        {
            BndtBaseHealth = StatConfig.Bind<float>("Bandit", "Base Health", 110);
            BndtLevelHealth = StatConfig.Bind<float>("Bandit", "Health by level", 33);
            BndtBaseShield = StatConfig.Bind<float>("Bandit", "Base Shield", 0);
            BndtLevelShield = StatConfig.Bind<float>("Bandit", "Shield by level", 0);
            BndtBaseRegen = StatConfig.Bind<float>("Bandit", "Base Regen", 1);
            BndtLevelRegen = StatConfig.Bind<float>("Bandit", "Regen by level", 0.24f);
            BndtBaseDamage = StatConfig.Bind<float>("Bandit", "Base Damage", 12);
            BndtLevelDamage = StatConfig.Bind<float>("Bandit", "Damage by level", 2.4f);
            BndtArmor = StatConfig.Bind<float>("Bandit", "Armor", 0);
            BndtSpeed = StatConfig.Bind<float>("Bandit", "Base Speed", 7);
            bndtStats = new CharBase
            {
                healthBase = BndtBaseHealth.Value,
                healthLevel = BndtLevelHealth.Value,
                regenBase = BndtBaseRegen.Value,
                regenLevel = BndtLevelRegen.Value,
                damageBase = BndtBaseDamage.Value,
                damageLevel = BndtLevelDamage.Value,
                shieldBase = BndtBaseShield.Value,
                shieldLevel = BndtLevelShield.Value,
                armor = BndtArmor.Value,
                moveSpeed = BndtSpeed.Value
            };
        }
        public static void MulTConfig()
        {
            MulTBaseHealth = StatConfig.Bind<float>("MUL-T", "Base Health", 200);
            MulTLevelHealth = StatConfig.Bind<float>("MUL-T", "Health by level", 60);
            MulTBaseShield = StatConfig.Bind<float>("MUL-T", "Base Shield", 0);
            MulTLevelShield = StatConfig.Bind<float>("MUL-T", "Shield by level", 0);
            MulTBaseRegen = StatConfig.Bind<float>("MUL-T", "Base Regen", 1);
            MulTLevelRegen = StatConfig.Bind<float>("MUL-T", "Regen by level", 0.2f);
            MulTBaseDamage = StatConfig.Bind<float>("MUL-T", "Base Damage", 11);
            MulTLevelDamage = StatConfig.Bind<float>("MUL-T", "Damage by level", 2.2f);
            MulTArmor = StatConfig.Bind<float>("MUL-T", "Armor", 14);
            MulTSpeed = StatConfig.Bind<float>("MUL-T", "Base Speed", 7);
            multStats = new CharBase
            {
                healthBase = MulTBaseHealth.Value,
                healthLevel = MulTLevelHealth.Value,
                regenBase = MulTBaseRegen.Value,
                regenLevel = MulTLevelRegen.Value,
                damageBase = MulTBaseDamage.Value,
                damageLevel = MulTLevelDamage.Value,
                shieldBase = MulTBaseShield.Value,
                shieldLevel = MulTLevelShield.Value,
                armor = MulTArmor.Value,
                moveSpeed = MulTSpeed.Value
            };
        }
        public static void EngiConfig()
        {
            EngiBaseHealth = StatConfig.Bind<float>("Engineer", "Base Health", 130);
            EngiLevelHealth = StatConfig.Bind<float>("Engineer", "Health by level", 39);
            EngiBaseShield = StatConfig.Bind<float>("Engineer", "Base Shield", 0);
            EngiLevelShield = StatConfig.Bind<float>("Engineer", "Shield by level", 0);
            EngiBaseRegen = StatConfig.Bind<float>("Engineer", "Base Regen", 1);
            EngiLevelRegen = StatConfig.Bind<float>("Engineer", "Regen by level", 0.2f);
            EngiBaseDamage = StatConfig.Bind<float>("Engineer", "Base Damage", 14);
            EngiLevelDamage = StatConfig.Bind<float>("Engineer", "Damage by level", 2.8f);
            EngiArmor = StatConfig.Bind<float>("Engineer", "Armor", 0);
            EngiSpeed = StatConfig.Bind<float>("Engineer", "Base Speed", 7);
            engiStats = new CharBase
            {
                healthBase = EngiBaseHealth.Value,
                healthLevel = EngiLevelHealth.Value,
                regenBase = EngiBaseRegen.Value,
                regenLevel = EngiLevelRegen.Value,
                damageBase = EngiBaseDamage.Value,
                damageLevel = EngiLevelDamage.Value,
                shieldBase = EngiBaseShield.Value,
                shieldLevel = EngiLevelShield.Value,
                armor = EngiArmor.Value,
                moveSpeed = EngiSpeed.Value
            };
        }
        public static void ArtiConfig()
        {
            ArtiBaseHealth = StatConfig.Bind<float>("Artificer", "Base Health", 110);
            ArtiLevelHealth = StatConfig.Bind<float>("Artificer", "Health by level", 33);
            ArtiBaseShield = StatConfig.Bind<float>("Artificer", "Base Shield", 0);
            ArtiLevelShield = StatConfig.Bind<float>("Artificer", "Shield by level", 0);
            ArtiBaseRegen = StatConfig.Bind<float>("Artificer", "Base Regen", 1);
            ArtiLevelRegen = StatConfig.Bind<float>("Artificer", "Regen by level", 0.2f);
            ArtiBaseDamage = StatConfig.Bind<float>("Artificer", "Base Damage", 12);
            ArtiLevelDamage = StatConfig.Bind<float>("Artificer", "Damage by level", 2.4f);
            ArtiArmor = StatConfig.Bind<float>("Artificer", "Armor", 0);
            ArtiSpeed = StatConfig.Bind<float>("Artificer", "Base Speed", 7);
            artiStats = new CharBase
            {
                healthBase = ArtiBaseHealth.Value,
                healthLevel = ArtiLevelHealth.Value,
                regenBase = ArtiBaseRegen.Value,
                regenLevel = ArtiLevelRegen.Value,
                damageBase = ArtiBaseDamage.Value,
                damageLevel = ArtiLevelDamage.Value,
                shieldBase = ArtiBaseShield.Value,
                shieldLevel = ArtiLevelShield.Value,
                armor = ArtiArmor.Value,
                moveSpeed = ArtiSpeed.Value
            };
        }
        public static void MercConfig()
        {
            MercBaseHealth = StatConfig.Bind<float>("Mercenary", "Base Health", 110);
            MercLevelHealth = StatConfig.Bind<float>("Mercenary", "Health by level", 33);
            MercBaseShield = StatConfig.Bind<float>("Mercenary", "Base Shield", 0);
            MercLevelShield = StatConfig.Bind<float>("Mercenary", "Shield by level", 0);
            MercBaseRegen = StatConfig.Bind<float>("Mercenary", "Base Regen", 1);
            MercLevelRegen = StatConfig.Bind<float>("Mercenary", "Regen by level", 0.2f);
            MercBaseDamage = StatConfig.Bind<float>("Mercenary", "Base Damage", 12);
            MercLevelDamage = StatConfig.Bind<float>("Mercenary", "Damage by level", 2.4f);
            MercArmor = StatConfig.Bind<float>("Mercenary", "Armor", 20);
            MercSpeed = StatConfig.Bind<float>("Mercenary", "Base Speed", 7);
            mercStats = new CharBase
            {
                healthBase = MercBaseHealth.Value,
                healthLevel = MercLevelHealth.Value,
                regenBase = MercBaseRegen.Value,
                regenLevel = MercLevelRegen.Value,
                damageBase = MercBaseDamage.Value,
                damageLevel = MercLevelDamage.Value,
                shieldBase = MercBaseShield.Value,
                shieldLevel = MercLevelShield.Value,
                armor = MercArmor.Value,
                moveSpeed = MercSpeed.Value
            };
        }
        public static void RexConfig()
        {
            RexBaseHealth = StatConfig.Bind<float>("REX", "Base Health", 130);
            RexLevelHealth = StatConfig.Bind<float>("REX", "Health by level", 39);
            RexBaseShield = StatConfig.Bind<float>("REX", "Base Shield", 0);
            RexLevelShield = StatConfig.Bind<float>("REX", "Shield by level", 0);
            RexBaseRegen = StatConfig.Bind<float>("REX", "Base Regen", 1f);
            RexLevelRegen = StatConfig.Bind<float>("REX", "Regen by level", 0.2f);
            RexBaseDamage = StatConfig.Bind<float>("REX", "Base Damage", 12);
            RexLevelDamage = StatConfig.Bind<float>("REX", "Damage by level", 2.4f);
            RexArmor = StatConfig.Bind<float>("REX", "Armor", 20);
            RexSpeed = StatConfig.Bind<float>("REX", "Base Speed", 7);
            rexStats = new CharBase
            {
                healthBase = RexBaseHealth.Value,
                healthLevel = RexLevelHealth.Value,
                regenBase = RexBaseRegen.Value,
                regenLevel = RexLevelRegen.Value,
                damageBase = RexBaseDamage.Value,
                damageLevel = RexLevelDamage.Value,
                shieldBase = RexBaseShield.Value,
                shieldLevel = RexLevelShield.Value,
                armor = RexArmor.Value,
                moveSpeed = RexSpeed.Value
            };
        }
        public static void LodrConfig()
        {
            LodrBaseHealth = StatConfig.Bind<float>("Loader", "Base Health", 160);
            LodrLevelHealth = StatConfig.Bind<float>("Loader", "Health by level", 48);
            LodrBaseShield = StatConfig.Bind<float>("Loader", "Base Shield", 0);
            LodrLevelShield = StatConfig.Bind<float>("Loader", "Shield by level", 0);
            LodrBaseRegen = StatConfig.Bind<float>("Loader", "Base Regen", 2.5f);
            LodrLevelRegen = StatConfig.Bind<float>("Loader", "Regen by level", 0.5f);
            LodrBaseDamage = StatConfig.Bind<float>("Loader", "Base Damage", 12);
            LodrLevelDamage = StatConfig.Bind<float>("Loader", "Damage by level", 2.4f);
            LodrArmor = StatConfig.Bind<float>("Loader", "Armor", 20);
            LodrSpeed = StatConfig.Bind<float>("Loader", "Base Speed", 7);
            lodrStats = new CharBase
            {
                healthBase = LodrBaseHealth.Value,
                healthLevel = LodrLevelHealth.Value,
                regenBase = LodrBaseRegen.Value,
                regenLevel = LodrLevelRegen.Value,
                damageBase = LodrBaseDamage.Value,
                damageLevel = LodrLevelDamage.Value,
                shieldBase = LodrBaseShield.Value,
                shieldLevel = LodrLevelShield.Value,
                armor = LodrArmor.Value,
                moveSpeed = LodrSpeed.Value
            };
        }
        public static void CrocConfig()
        {
            CrocBaseHealth = StatConfig.Bind<float>("Acrid", "Base Health", 160);
            CrocLevelHealth = StatConfig.Bind<float>("Acrid", "Health by level", 48);
            CrocBaseShield = StatConfig.Bind<float>("Acrid", "Base Shield", 0);
            CrocLevelShield = StatConfig.Bind<float>("Acrid", "Shield by level", 0);
            CrocBaseRegen = StatConfig.Bind<float>("Acrid", "Base Regen", 2.5f);
            CrocLevelRegen = StatConfig.Bind<float>("Acrid", "Regen by level", 0.5f);
            CrocBaseDamage = StatConfig.Bind<float>("Acrid", "Base Damage", 15);
            CrocLevelDamage = StatConfig.Bind<float>("Acrid", "Damage by level", 3);
            CrocArmor = StatConfig.Bind<float>("Acrid", "Armor", 20);
            CrocSpeed = StatConfig.Bind<float>("Acrid", "Base Speed", 7);
            crocStats = new CharBase
            {
                healthBase = CrocBaseHealth.Value,
                healthLevel = CrocLevelHealth.Value,
                regenBase = CrocBaseRegen.Value,
                regenLevel = CrocLevelRegen.Value,
                damageBase = CrocBaseDamage.Value,
                damageLevel = CrocLevelDamage.Value,
                shieldBase = CrocBaseShield.Value,
                shieldLevel = CrocLevelShield.Value,
                armor = CrocArmor.Value,
                moveSpeed = CrocSpeed.Value
            };
        }
        public static void CaptConfig()
        {
            CaptBaseHealth = StatConfig.Bind<float>("Captain", "Base Health", 110);
            CaptLevelHealth = StatConfig.Bind<float>("Captain", "Health by level", 33);
            CaptBaseShield = StatConfig.Bind<float>("Captain", "Base Shield", 0);
            CaptLevelShield = StatConfig.Bind<float>("Captain", "Shield by level", 0);
            CaptBaseRegen = StatConfig.Bind<float>("Captain", "Base Regen", 1);
            CaptLevelRegen = StatConfig.Bind<float>("Captain", "Regen by level", 0.2f);
            CaptBaseDamage = StatConfig.Bind<float>("Captain", "Base Damage", 12);
            CaptLevelDamage = StatConfig.Bind<float>("Captain", "Damage by level", 2.4f);
            CaptArmor = StatConfig.Bind<float>("Captain", "Armor", 0);
            CaptSpeed = StatConfig.Bind<float>("Captain", "Base Speed", 7);
            captStats = new CharBase
            {
                healthBase = CaptBaseHealth.Value,
                healthLevel = CaptLevelHealth.Value,
                regenBase = CaptBaseRegen.Value,
                regenLevel = CaptLevelRegen.Value,
                damageBase = CaptBaseDamage.Value,
                damageLevel = CaptLevelDamage.Value,
                shieldBase = CaptBaseShield.Value,
                shieldLevel = CaptLevelShield.Value,
                armor = CaptArmor.Value,
                moveSpeed = CaptSpeed.Value
            };
        }
        public static void BirbConfig()
        {
            BirbBaseHealth = StatConfig.Bind<float>("Heretic", "Base Health", 440);
            BirbLevelHealth = StatConfig.Bind<float>("Heretic", "Health by level", 132);
            BirbBaseShield = StatConfig.Bind<float>("Heretic", "Base Shield", 0);
            BirbLevelShield = StatConfig.Bind<float>("Heretic", "Shield by level", 0);
            BirbBaseRegen = StatConfig.Bind<float>("Heretic", "Base Regen", -6f);
            BirbLevelRegen = StatConfig.Bind<float>("Heretic", "Regen by level", -1.2f);
            BirbBaseDamage = StatConfig.Bind<float>("Heretic", "Base Damage", 18);
            BirbLevelDamage = StatConfig.Bind<float>("Heretic", "Damage by level", 3.6f);
            BirbArmor = StatConfig.Bind<float>("Heretic", "Armor", 0);
            BirbSpeed = StatConfig.Bind<float>("Heretic", "Base Speed", 8);
            birbStats = new CharBase
            {
                healthBase = BirbBaseHealth.Value,
                healthLevel = BirbLevelHealth.Value,
                regenBase = BirbBaseRegen.Value,
                regenLevel = BirbLevelRegen.Value,
                damageBase = BirbBaseDamage.Value,
                damageLevel = BirbLevelDamage.Value,
                shieldBase = BirbBaseShield.Value,
                shieldLevel = BirbLevelShield.Value,
                armor = BirbArmor.Value,
                moveSpeed = BirbSpeed.Value
            };
        }
        public static ConfigFile StatConfig { get; set; }
        public static ConfigEntry<float> MandoBaseHealth { get; set; }
        public static ConfigEntry<float> MandoLevelHealth { get; set; }
        public static ConfigEntry<float> MandoBaseShield { get; set; }
        public static ConfigEntry<float> MandoLevelShield { get; set; }
        public static ConfigEntry<float> MandoBaseRegen { get; set; }
        public static ConfigEntry<float> MandoLevelRegen { get; set; }
        public static ConfigEntry<float> MandoBaseDamage { get; set; }
        public static ConfigEntry<float> MandoLevelDamage { get; set; }
        public static ConfigEntry<float> MandoArmor { get; set; }
        public static ConfigEntry<float> MandoSpeed { get; set; }
        public static ConfigEntry<float> HuntBaseHealth { get; set; }
        public static ConfigEntry<float> HuntLevelHealth { get; set; }
        public static ConfigEntry<float> HuntBaseShield { get; set; }
        public static ConfigEntry<float> HuntLevelShield { get; set; }
        public static ConfigEntry<float> HuntBaseRegen { get; set; }
        public static ConfigEntry<float> HuntLevelRegen { get; set; }
        public static ConfigEntry<float> HuntBaseDamage { get; set; }
        public static ConfigEntry<float> HuntLevelDamage { get; set; }
        public static ConfigEntry<float> HuntArmor { get; set; }
        public static ConfigEntry<float> HuntSpeed { get; set; }
        public static ConfigEntry<float> BndtBaseHealth { get; set; }
        public static ConfigEntry<float> BndtLevelHealth { get; set; }
        public static ConfigEntry<float> BndtBaseShield { get; set; }
        public static ConfigEntry<float> BndtLevelShield { get; set; }
        public static ConfigEntry<float> BndtBaseRegen { get; set; }
        public static ConfigEntry<float> BndtLevelRegen { get; set; }
        public static ConfigEntry<float> BndtBaseDamage { get; set; }
        public static ConfigEntry<float> BndtLevelDamage { get; set; }
        public static ConfigEntry<float> BndtArmor { get; set; }
        public static ConfigEntry<float> BndtSpeed { get; set; }
        public static ConfigEntry<float> MulTBaseHealth { get; set; }
        public static ConfigEntry<float> MulTLevelHealth { get; set; }
        public static ConfigEntry<float> MulTBaseShield { get; set; }
        public static ConfigEntry<float> MulTLevelShield { get; set; }
        public static ConfigEntry<float> MulTBaseRegen { get; set; }
        public static ConfigEntry<float> MulTLevelRegen { get; set; }
        public static ConfigEntry<float> MulTBaseDamage { get; set; }
        public static ConfigEntry<float> MulTLevelDamage { get; set; }
        public static ConfigEntry<float> MulTArmor { get; set; }
        public static ConfigEntry<float> MulTSpeed { get; set; }
        public static ConfigEntry<float> EngiBaseHealth { get; set; }
        public static ConfigEntry<float> EngiLevelHealth { get; set; }
        public static ConfigEntry<float> EngiBaseShield { get; set; }
        public static ConfigEntry<float> EngiLevelShield { get; set; }
        public static ConfigEntry<float> EngiBaseRegen { get; set; }
        public static ConfigEntry<float> EngiLevelRegen { get; set; }
        public static ConfigEntry<float> EngiBaseDamage { get; set; }
        public static ConfigEntry<float> EngiLevelDamage { get; set; }
        public static ConfigEntry<float> EngiArmor { get; set; }
        public static ConfigEntry<float> EngiSpeed { get; set; }
        public static ConfigEntry<float> ArtiBaseHealth { get; set; }
        public static ConfigEntry<float> ArtiLevelHealth { get; set; }
        public static ConfigEntry<float> ArtiBaseShield { get; set; }
        public static ConfigEntry<float> ArtiLevelShield { get; set; }
        public static ConfigEntry<float> ArtiBaseRegen { get; set; }
        public static ConfigEntry<float> ArtiLevelRegen { get; set; }
        public static ConfigEntry<float> ArtiBaseDamage { get; set; }
        public static ConfigEntry<float> ArtiLevelDamage { get; set; }
        public static ConfigEntry<float> ArtiArmor { get; set; }
        public static ConfigEntry<float> ArtiSpeed { get; set; }
        public static ConfigEntry<float> MercBaseHealth { get; set; }
        public static ConfigEntry<float> MercLevelHealth { get; set; }
        public static ConfigEntry<float> MercBaseShield { get; set; }
        public static ConfigEntry<float> MercLevelShield { get; set; }
        public static ConfigEntry<float> MercBaseRegen { get; set; }
        public static ConfigEntry<float> MercLevelRegen { get; set; }
        public static ConfigEntry<float> MercBaseDamage { get; set; }
        public static ConfigEntry<float> MercLevelDamage { get; set; }
        public static ConfigEntry<float> MercArmor { get; set; }
        public static ConfigEntry<float> MercSpeed { get; set; }
        public static ConfigEntry<float> RexBaseHealth { get; set; }
        public static ConfigEntry<float> RexLevelHealth { get; set; }
        public static ConfigEntry<float> RexBaseShield { get; set; }
        public static ConfigEntry<float> RexLevelShield { get; set; }
        public static ConfigEntry<float> RexBaseRegen { get; set; }
        public static ConfigEntry<float> RexLevelRegen { get; set; }
        public static ConfigEntry<float> RexBaseDamage { get; set; }
        public static ConfigEntry<float> RexLevelDamage { get; set; }
        public static ConfigEntry<float> RexArmor { get; set; }
        public static ConfigEntry<float> RexSpeed { get; set; }
        public static ConfigEntry<float> LodrBaseHealth { get; set; }
        public static ConfigEntry<float> LodrLevelHealth { get; set; }
        public static ConfigEntry<float> LodrBaseShield { get; set; }
        public static ConfigEntry<float> LodrLevelShield { get; set; }
        public static ConfigEntry<float> LodrBaseRegen { get; set; }
        public static ConfigEntry<float> LodrLevelRegen { get; set; }
        public static ConfigEntry<float> LodrBaseDamage { get; set; }
        public static ConfigEntry<float> LodrLevelDamage { get; set; }
        public static ConfigEntry<float> LodrArmor { get; set; }
        public static ConfigEntry<float> LodrSpeed { get; set; }
        public static ConfigEntry<float> CrocBaseHealth { get; set; }
        public static ConfigEntry<float> CrocLevelHealth { get; set; }
        public static ConfigEntry<float> CrocBaseShield { get; set; }
        public static ConfigEntry<float> CrocLevelShield { get; set; }
        public static ConfigEntry<float> CrocBaseRegen { get; set; }
        public static ConfigEntry<float> CrocLevelRegen { get; set; }
        public static ConfigEntry<float> CrocBaseDamage { get; set; }
        public static ConfigEntry<float> CrocLevelDamage { get; set; }
        public static ConfigEntry<float> CrocArmor { get; set; }
        public static ConfigEntry<float> CrocSpeed { get; set; }
        public static ConfigEntry<float> CaptBaseHealth { get; set; }
        public static ConfigEntry<float> CaptLevelHealth { get; set; }
        public static ConfigEntry<float> CaptBaseShield { get; set; }
        public static ConfigEntry<float> CaptLevelShield { get; set; }
        public static ConfigEntry<float> CaptBaseRegen { get; set; }
        public static ConfigEntry<float> CaptLevelRegen { get; set; }
        public static ConfigEntry<float> CaptBaseDamage { get; set; }
        public static ConfigEntry<float> CaptLevelDamage { get; set; }
        public static ConfigEntry<float> CaptArmor { get; set; }
        public static ConfigEntry<float> CaptSpeed { get; set; }
        public static ConfigEntry<float> BirbBaseHealth { get; set; }
        public static ConfigEntry<float> BirbLevelHealth { get; set; }
        public static ConfigEntry<float> BirbBaseShield { get; set; }
        public static ConfigEntry<float> BirbLevelShield { get; set; }
        public static ConfigEntry<float> BirbBaseRegen { get; set; }
        public static ConfigEntry<float> BirbLevelRegen { get; set; }
        public static ConfigEntry<float> BirbBaseDamage { get; set; }
        public static ConfigEntry<float> BirbLevelDamage { get; set; }
        public static ConfigEntry<float> BirbArmor { get; set; }
        public static ConfigEntry<float> BirbSpeed { get; set; }
    }
}
