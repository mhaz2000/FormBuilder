using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enums
{
    //Coutries
    public enum Countries
    {
        Afghanistan,
        Albania,
        Algeria,
        Andorra,
        Angola,
        [Display(Name = "Antigua and Barbuda")]
        AntiguaAndBarbuda,
        Argentina,
        Armenia,
        Australia,
        Austria,
        [Display(Name = "Austrian Empire")]
        AustrianEmpire,
        Azerbaijan,
        Baden,
        Bahamas,
        Bahrain,
        Bangladesh,
        Barbados,
        Bavaria,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Bolivia,
        [Display(Name = "Bosnia and Herzegovina")]
        BosniaAndHerzegovina,
        Botswana,
        Brazil,
        Brunei,
        [Display(Name = "Brunswick and Lüneburg")]
        BrunswickAndLüneburg,
        Bulgaria,
        [Display(Name = "Burkina Faso")]
        BurkinaFaso,
        Burma,
        Burundi,
        [Display(Name = "Cabo Verde")]
        CaboVerde,
        Cambodia,
        Cameroon,
        Canada,
        [Display(Name = "CaymanIslands")]
        CaymanIslands,
        [Display(Name = "Central African Republic")]
        CentralAfricanRepublic,
        [Display(Name = "Central American Federation")]
        CentralAmericanFederation,
        Chad,
        Chile,
        China,
        Colombia,
        Comoros,
        [Display(Name = "Congo Free State")]
        CongoFreeState,
        [Display(Name = "Costa Rica")]
        CostaRica,
        [Display(Name = "Cote d’Ivoire")]
        CotedIvoire,
        Croatia,
        Cuba,
        Cyprus,
        Czechia,
        Czechoslovakia,
        [Display(Name = "Democratic Republic of the Congo")]
        DemocraticRepublicOfTheCongo,
        Denmark,
        Djibouti,
        Dominica,
        [Display(Name = "Dominican Republic")]
        DominicanRepublic,
        [Display(Name = "Duchy of Parma")]
        DuchyOfParma,
        [Display(Name = "East Germany (German Democratic Republic)")]
        EastGermany,
        Ecuador,
        Egypt,
        [Display(Name = "El Salvador")]
        ElSalvador,
        [Display(Name = "Equatorial Guinea")]
        EquatorialGuinea,
        Eritrea,
        Estonia,
        Eswatini,
        Ethiopia,
        Fiji,
        Finland,
        France,
        Gabon,
        Gambia,
        Georgia,
        Germany,
        Ghana,
        [Display(Name = "Grand Duchy of Tuscany")]
        GrandDuchyOfTuscany,
        Greece,
        Grenada,
        Guatemala,
        Guinea,
        [Display(Name = "Guinea-Bissau")]
        GuineaBissau,
        Guyana,
        Haiti,
        Hanover,
        [Display(Name = "Hanseatic Republics")]
        HanseaticRepublics,
        Hawaii,
        Hesse,
        [Display(Name = "Holy See")]
        HolySee,
        Honduras,
        Hungary,
        Iceland,
        India,
        Indonesia,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jordan,
        Kazakhstan,
        Kenya,
        [Display(Name = "Kingdom Of Serbia/Yugoslavia")]
        KingdomOfSerbia_Yugoslavia,
        Kiribati,
        Korea,
        Kosovo,
        Kuwait,
        Kyrgyzstan,
        Laos,
        Latvia,
        Lebanon,
        Lesotho,
        [Display(Name = "Lew Chew (Loochoo)")]
        LewChew,
        Liberia,
        Libya,
        Liechtenstein,
        Lithuania,
        Luxembourg,
        Madagascar,
        Malawi,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        [Display(Name = "Marshall Islands")]
        MarshallIslands,
        Mauritania,
        Mauritius,
        [Display(Name = "Mecklenburg-Schwerin")]
        MecklenburgSchwerin,
        [Display(Name = "Mecklenburg-Strelitz")]
        MecklenburgStrelitz,
        Mexico,
        Micronesia,
        Moldova,
        Monaco,
        Mongolia,
        Montenegro,
        Morocco,
        Mozambique,
        Namibia,
        Nassau,
        Nauru,
        Nepal,
        Netherlands,
        [Display(Name = "New Zealand")]
        NewZealand,
        Nicaragua,
        Niger,
        Nigeria,
        [Display(Name = "North German Confederation")]
        NorthGermanConfederation,
        [Display(Name = "North German Union")]
        NorthGermanUnion,
        [Display(Name = "North Macedoni")]
        NorthMacedonia,
        Norway,
        Oman,
        Pakistan,
        Palau,
        Panama,
        [Display(Name = "Papal States")]
        PapalStates,
        [Display(Name = "Papua New Guine")]
        PapuaNewGuinea,
        Paraguay,
        Peru,
        Philippines,
        [Display(Name = "Piedmont-Sardinia")]
        PiedmontSardinia,
        Poland,
        Portugal,
        Qatar,
        [Display(Name = " Republic of Genoa")]
        RepublicOfGenoa,
        [Display(Name = "Republic of Korea (South Korea)")]
        RepublicOfKorea,
        [Display(Name = "Republic of the Congo")]
        RepublicOfTheCongo,
        Romania,
        Russia,
        Rwanda,
        [Display(Name = "Saint Kitts and Nevis")]
        SaintKittsAndNevis,
        [Display(Name = "Saint Lucia")]
        SaintLucia,
        [Display(Name = "Saint Vincent and the Grenadines")]
        SaintVincentAndTheGrenadines,
        Samoa,
        [Display(Name = "Republic of the Congo")]
        SanMarino,
        [Display(Name = "Sao Tome and Principe")]
        SaoTomeAndPrincipe,
        [Display(Name = "Saudi Arabia")]
        SaudiArabia,
        [Display(Name = "Schaumburg-Lippe")]
        SchaumburgLippe,
        Senegal,
        Serbia,
        Seychelles,
        [Display(Name = "Sierra Leone")]
        SierraLeone,
        Singapore,
        Slovakia,
        Slovenia,
        [Display(Name = "Solomon Islands")]
        SolomonIslands,
        Somalia,
        [Display(Name = "South Africa")]
        SouthAfrica,
        [Display(Name = "South Sudan")]
        SouthSudan,
        Spain,
        [Display(Name = "Sri Lanka")]
        SriLanka,
        Sudan,
        Suriname,
        Sweden,
        Switzerland,
        Syria,
        Tajikistan,
        Tanzania,
        Thailand,
        [Display(Name = "Timor-Leste")]
        TimorLeste,
        Togo,
        Tonga,
        [Display(Name = "Trinidad and Tobago")]
        TrinidadAndTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        Tuvalu,
        Uganda,
        Ukraine,
        [Display(Name = "United Arab Emirates")]
        UnitedArabEmirates,
        [Display(Name = "United Kingdom")]
        UnitedKingdom,
        Uruguay,
        Uzbekistan,
        Vanuatu,
        Venezuela,
        Vietnam,
        Yemen,
        Zambia,
        Zimbabwe,
    }
}
