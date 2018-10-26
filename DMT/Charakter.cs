using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMT
{
    enum Klasse { Barbar, Barde, Druide, Hexenmeister, Kämpfer, Kleriker, Magier, Mönch, Paladin, Schurke, Waldläufer, Zauberer }
    enum Rasse { Aasimar, Drachenblütiger, Echsenvolk, Elf, Firbolg, Gnom, Goliat, Halbelf, Halbling, Halbork, Kenku, Mensch, Tabaxi, Tiefling, Triton, Zwerg}
    enum RüstungLeicht { keine = 0, gefütterteRüstung = 11, Lederrüstung = 11, beschlageneLederrüstung = 12}
    enum RüstungMittel { keine = 0, Fellrüstung = 12, Kettenhemd = 13, Schuppenpanzer = 14, Brustplatte = 14, Plattenpanzer = 15 }
    enum RüstungSchwer { keine = 0, Ringpanzer = 14, Kettenpanzer = 16, Schienenpanzer = 17, Ritterrüstung = 18}
    enum Gesinnung { rechtschaffendBöse = 1, neutralBöse = 2, chaotischBöse = 3, rechtschaffendNeutral = 4, neutral = 5, chaotischNeutral = 6,
                        rechtschaffendGut = 7, neutralGut = 8, chaotischGut = 9 }
    class Charakter
    {
        public string SpielerName, CharakterName;
        public Klasse Klasse;
        public Rasse Rasse;
        public RüstungLeicht RüstungLeicht;
        public RüstungMittel RüstungMittel;
        public RüstungSchwer RüstungSchwer;
        public Gesinnung Gesinnung;
        public int Level, Hp, Stärke, Geschick, Konstitution, Intelligenz, Weisheit, Charisma, Übungsbonus, Initiative, Rüstungsklasse, Akrobatik, ArkaneKunde, Athletik, Auftreten, Einschüchtern,
            Fingerfertigkeit, Geschichte, Heilkunde, Heimlichkeit, MitTierenUmgehen, MotiveErkennen, Nachforschungen, Naturkunde, Religion, Täuschen, Überlebenskunst, Überzeugen, Wahrnehmung, Exp,
            ModStärke, ModGeschick, ModKonstitution, ModIntelligenz, ModWeisheit, ModCharisma;
        public bool GeübtAkrobatik, GeübtArkaneKunde, GeübtAthletik, GeübtAuftreten, GeübtEinschüchtern, GeübtFingerfertigkeit, GeübtGeschichte, GeübtHeilkunde, GeübtHeimlichkeit, GeübtMitTierenUmgehen,
            GeübtMotiveErkennen, GeübtNachforschungen, GeübtNaturkunde, GeübtReligion, GeübtTäuschen, GeübtÜberlebenskunst, GeübtÜberzeugen, GeübtWahrnehmung;

        public Charakter(string spielerName, string charakterName, Klasse klasse, Rasse rasse, Gesinnung gesinnung, int level, int hp, int stärke, int geschick, int konstitution, int intelligenz, int weisheit, int charisma,
            int exp, bool geübtAkrobatik = false, bool geübtArkaneKunde = false, bool geübtAthletik = false, bool geübtAuftreten = false, bool geübtEinschüchtern = false, bool geübtFingerfertigkeit = false,
            bool geübtGeschichte = false, bool geübtHeilkunde = false, bool geübtHeimlichkeit = false, bool geübtMitTierenUmgehen = false, bool geübtMotiveErkennen = false, bool geübtNachforschungen = false,
            bool geübtNaturkunde = false, bool geübtReligion = false, bool geübtTäuschen = false, bool geübtÜberlebenskunst = false, bool geübtÜberzeugen = false, bool geübtWahrnehmung = false, RüstungLeicht rüstungLeicht = RüstungLeicht.keine,
            RüstungMittel rüstungMittel = RüstungMittel.keine, RüstungSchwer rüstungSchwer = RüstungSchwer.keine)
        {
            SpielerName = spielerName;
            CharakterName = charakterName;
            Klasse = klasse;
            Rasse = rasse;
            Level = level;
            Hp = hp;
            Gesinnung = gesinnung;

            Stärke = stärke;
            Geschick = geschick;
            Konstitution = konstitution;
            Intelligenz = intelligenz;
            Weisheit = weisheit;
            Charisma = charisma;

            ModStärke = BerechneModifikator(stärke);
            ModGeschick = BerechneModifikator(geschick);
            ModKonstitution = BerechneModifikator(konstitution);
            ModIntelligenz = BerechneModifikator(intelligenz);
            ModWeisheit = BerechneModifikator(weisheit);
            ModCharisma = BerechneModifikator(charisma);

            //Double Proficency noch nicht berücksichtigt!
            Akrobatik = BerechneFertigkeit(ModGeschick, geübtAkrobatik);
            ArkaneKunde = BerechneFertigkeit(ModIntelligenz, geübtArkaneKunde);
            Athletik = BerechneFertigkeit(ModStärke, geübtAthletik);
            Auftreten = BerechneFertigkeit(ModCharisma, geübtAuftreten);
            Einschüchtern = BerechneFertigkeit(ModCharisma, geübtAuftreten);
            Fingerfertigkeit = BerechneFertigkeit(ModGeschick, geübtFingerfertigkeit);
            Geschichte = BerechneFertigkeit(ModIntelligenz, geübtGeschichte);
            Heilkunde = BerechneFertigkeit(ModWeisheit, geübtHeilkunde);
            Heimlichkeit = BerechneFertigkeit(ModGeschick, geübtHeimlichkeit);
            MitTierenUmgehen = BerechneFertigkeit(ModWeisheit,  geübtMitTierenUmgehen);
            MotiveErkennen = BerechneFertigkeit(ModWeisheit, geübtMotiveErkennen);
            Nachforschungen = BerechneFertigkeit(ModIntelligenz, geübtNachforschungen);
            Naturkunde = BerechneFertigkeit(ModIntelligenz, geübtNaturkunde);
            Religion = BerechneFertigkeit(ModIntelligenz, geübtReligion);
            Täuschen = BerechneFertigkeit(ModCharisma, GeübtTäuschen);
            Überlebenskunst = BerechneFertigkeit(ModWeisheit, geübtÜberlebenskunst);
            Überzeugen = BerechneFertigkeit(ModCharisma, geübtÜberzeugen);
            Wahrnehmung = BerechneFertigkeit(ModWeisheit, geübtWahrnehmung);

            Übungsbonus = BerechneÜbungsbonus();
            Rüstungsklasse = BerechneRüstungsklasse(rüstungLeicht, rüstungMittel, rüstungSchwer);
            Initiative = BerechneInitiative();
        }

        int BerechneModifikator(int attribut)
        {
            return attribut / 2 - 5;
        }

        int BerechneFertigkeit(int modifikator, bool geübteInFertigkeit)
        {
            if (geübteInFertigkeit)
            {
                return modifikator + Übungsbonus;
            }
            else
            {
                return modifikator;
            }
        }

        int BerechneRüstungsklasse(RüstungLeicht rüstungLeicht = RüstungLeicht.keine, RüstungMittel rüstungMittel = RüstungMittel.keine,
            RüstungSchwer rüstungSchwer = RüstungSchwer.keine)
        {
            if(rüstungLeicht != RüstungLeicht.keine)
            {
                return (int)rüstungLeicht + ModGeschick;
            }
            else if(rüstungMittel != RüstungMittel.keine)
            {
                if(ModGeschick > 2)
                {
                    return (int)rüstungMittel + 2;
                }
                else
                {
                    return (int)rüstungMittel + ModGeschick;
                }     
            }
            else if(rüstungSchwer != RüstungSchwer.keine)
            {
                return (int)rüstungSchwer;
            }
            else
            {
                return 10 + ModGeschick;
            }
        }

        int BerechneÜbungsbonus()
        {
            if (Level <= 4) return 2;
            if (Level <= 8) return 3;
            if (Level <= 12) return 4;
            if (Level <= 16) return 5;
            return 6;
        }

        int BerechneInitiative()
        {
            if (RüstungLeicht != RüstungLeicht.keine) return 0 -ModGeschick;
            if (RüstungMittel != RüstungMittel.keine) return 2 - ModGeschick;
            if(RüstungSchwer != RüstungSchwer.keine) return 4 - ModGeschick;
            return -2 - ModGeschick;
        }
    }
}
