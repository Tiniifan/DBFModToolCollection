﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseParamEditor.Common
{
    public class Characters
    {
        public static Dictionary<int, string> English = new Dictionary<int, string>
        {
            {0x00000000, "Avatar"},
            {0x00000001, "Free fusion"},
            {0x00000020, "Goku"},
            {0x00000024, "Gowry"},
            {0x00000025, "Tyber"},
            {0x00000030, "Goku (Super Saiyan)"},
            {0x00000040, "Goku (Super Saiyan 3)"},
            {0x00000050, "Goku (Super Saiyan 4)"},
            {0x00000060, "Goku (Super Saiyan God)"},
            {0x00000080, "Gohan (Teen)"},
            {0x00000090, "Gohan (Teen) (Super Saiyan)"},
            {0x00000100, "Gohan"},
            {0x00000110, "Gohan (Super Saiyan)"},
            {0x00000120, "Great Saiyaman 1"},
            {0x00000130, "Goten"},
            {0x00000140, "Goten (Super Saiyan)"},
            {0x00000150, "Vegeta"},
            {0x00000160, "Vegeta (Super Saiyan)"},
            {0x00000170, "Vegeta (Super Saiyan 3)"},
            {0x00000180, "Vegeta (Super Saiyan 4)"},
            {0x00000190, "Trunks (Future)"},
            {0x00000200, "Trunks (Future) (Super Saiyan)"},
            {0x00000210, "Trunks (Future) (Super Saiyan 3)"},
            {0x00000220, "Trunks"},
            {0x00000230, "Trunks (Super Saiyan)"},
            {0x00000241, "Piccolo"},
            {0x00000250, "Krillin"},
            {0x00000260, "Yamcha"},
            {0x00000270, "Tien"},
            {0x00000280, "Chiaotzu"},
            {0x00000290, "Hercule"},
            {0x00000300, "Videl"},
            {0x00000310, "Great Saiyaman 2"},
            {0x00000320, "Pan"},
            {0x00000330, "Uub"},
            {0x00000340, "Super Uub"},
            {0x00000350, "Gotenks"},
            {0x00000360, "Gotenks (Super Saiyan)"},
            {0x00000370, "Gotenks (Super Saiyan 3)"},
            {0x00000380, "Vegito"},
            {0x00000390, "Vegito (Super Saiyan)"},
            {0x00000400, "Gogeta (Super Saiyan)"},
            {0x00000420, "Gogeta (Super Saiyan 4)"},
            {0x00000430, "Demon King Piccolo"},
            {0x00000440, "Raditz"},
            {0x00000450, "Nappa"},
            {0x00000460, "Saibaman"},
            {0x00000470, "Nail"},
            {0x00000490, "Zarbon"},
            {0x00000510, "Dodoria"},
            {0x00000520, "Captain Ginyu"},
            {0x00000530, "Guldo"},
            {0x00000540, "Jeice"},
            {0x00000550, "Burter"},
            {0x00000560, "Recoome"},
            {0x00000590, "Frieza"},
            {0x00000620, "Bardock"},
            {0x00000630, "Gine"},
            {0x00000650, "Android 19"},
            {0x00000660, "Android 20"},
            {0x00000670, "Android 17"},
            {0x00000680, "Super 17"},
            {0x00000690, "Android 18"},
            {0x00000700, "Android 16"},
            {0x00000730, "Cell"},
            {0x00000740, "Cell Jr."},
            {0x00000750, "Pikkon"},
            {0x00000760, "Majin Buu: Good"},
            {0x00000800, "Majin Buu: Pure"},
            {0x00000810, "Supreme Kai"},
            {0x00000820, "Kibito"},
            {0x00000830, "Dabura"},
            {0x00000900, "Broly"},
            {0x00000910, "Broly (Super Saiyan 3)"},
            {0x00000940, "Super Janemba"},
            {0x00000970, "Baby"},
            {0x00001000, "Omega Shenron"},
            {0x00001020, "Nuova Shenron"},
            {0x00001030, "Beerus"},
            {0x00001040, "Whis"},
            {0x00001060, "Arale"},
            {0x00001110, "Goku (GT)"},
            {0x00001120, "Goku (GT) (Super Saiyan)"},
            {0x00001130, "Goku (GT) (Super Saiyan 3)"},
            {0x00001140, "Turles"},
            {0x00001150, "Bardock (Super Saiyan)"},
            {0x00001930, "Jaco"},
            {0x00001950, "Golden Frieza"},
            {0x00001970, "Goku (Super Saiyan God Super Saiyan)"},
            {0x00001980, "Vegeta (Super Saiyan God Super Saiyan)"},
            {0x00001990, "Champa"},
            {0x00002000, "Vados"},
            {0x00002010, "Shale"},
            {0x00002020, "Snei"},
            {0x00002030, "Escart"},
            {0x00002040, "Lugo"},
            {0x00002050, "Uzma"},
            {0x00002060, "Toomlin"},
            {0x00002070, "Moolin"},
            {0x00002080, "Jijee"},
            {0x00002090, "Mekuji"},
            {0x00002100, "Mai mai"},
            {0x00002110, "Bongo"},
            {0x00002120, "Ryuto"},
            {0x00002130, "Fargo"},
            {0x00002140, "Android 76"},
            {0x00002150, "Toronbon"},
            {0x00002160, "Eemai"},
            {0x00002170, "Datsum"},
            {0x00002180, "Cital"},
            {0x00002190, "Ghiro"},
            {0x00002200, "Scarl"},
            {0x00002210, "Bukha"},
            {0x00002220, "Cissisto"},
            {0x00002230, "Zukini"},
            {0x00002240, "Skwash"},
            {0x00002250, "Kress"},
            {0x00002270, "Vasabi"},
            {0x00002280, "Zibar"},
            {0x00002310, "Jagamo"},
            {0x00002340, "Quilin"},
            {0x00002350, "Garatz"},
            {0x00002360, "Rakyo"},
            {0x00002370, "Heiya"},
            {0x00002380, "Lomen"},
            {0x00002390, "Rhubub"},
            {0x00002410, "Goyan"},
            {0x00002420, "Racyoh"},
            {0x00002430, "Huki"},
            {0x00002440, "Sage"},
            {0x00002450, "Nenjo"},
            {0x00002460, "Plauto"},
            {0x00002470, "Mibatz"},
            {0x00002480, "Leganon"},
            {0x00002490, "Yashimo"},
            {0x00002510, "Kalif"},
            {0x00002520, "Zysa"},
            {0x00002530, "Prika"},
            {0x00002540, "Kiclee"},
            {0x00002550, "Nira"},
            {0x00002560, "Chokly"},
            {0x00002570, "Narmis"},
            {0x00002580, "Nazz"},
            {0x00002590, "Yunaly"},
            {0x00002600, "Lisee"},
            {0x00002610, "Ruccola"},
            {0x00002620, "Stabba"},
            {0x00002630, "Mint"},
            {0x00002640, "Shalot"},
            {0x00002650, "Sesamy"},
            {0x00002660, "Dennish"},
            {0x00002670, "Manell"},
            {0x00002680, "Stroganof"},
            {0x00002690, "Assam"},
            {0x00002700, "Dran"},
            {0x00002710, "Baba G"},
            {0x00002720, "Kalpochof"},
            {0x00002730, "Yamkun"},
            {0x00002740, "Shaoron"},
            {0x00002750, "Kloa"},
            {0x00002760, "Mabon"},
            {0x00002770, "Hoycoli"},
            {0x00002780, "Android 33"},
            {0x00002790, "Quiche"},
            {0x00002800, "Wanta"},
            {0x00002810, "Damjee"},
            {0x00002820, "Waffen"},
            {0x00002830, "Powa"},
            {0x00002840, "Kutz"},
            {0x00002850, "Panna"},
            {0x00002860, "Jajee"},
            {0x00002870, "Gato"},
            {0x00002880, "Beeyan"},
            {0x00002890, "Chauda"},
            {0x00002900, "Hoji"},
            {0x00002910, "Ampa"},
            {0x00002920, "Macaroo"},
            {0x00002930, "Chinjao"},
            {0x00002940, "Piscuit"},
            {0x00002950, "Android 44"},
            {0x00002960, "Android 55"},
            {0x00002970, "Quinny"},
            {0x00002980, "Tirami"},
            {0x00002990, "Eclain"},
            {0x00003000, "Marinay"},
            {0x00003010, "Peperon"},
            {0x00003020, "Stella"},
            {0x00003030, "Bagetta"},
            {0x00003040, "Chocora"},
            {0x00003050, "Kallon"},
            {0x00003060, "Peco"},
            {0x00003070, "Jam"},
            {0x00003080, "Sanla"},
            {0x00003090, "Strony"},
            {0x00003100, "Oats"},
            {0x00003110, "Edamay"},
            {0x00003120, "Tartar"},
            {0x00003130, "Tumeric"},
            {0x00003140, "Calao"},
            {0x00003150, "Zalutz"},
            {0x00003160, "Yuba"},
            {0x00003170, "Shabbet"},
            {0x00003180, "Camarbo"},
            {0x00003190, "Chiwak"},
            {0x00003200, "Caluppa"},
            {0x00003210, "Marmad"},
            {0x00003220, "Futoh"},
            {0x00003230, "Basco"},
            {0x00003240, "Natto"},
            {0x00003250, "Noomeg"},
            {0x00003260, "Chapp"},
            {0x00003270, "Mustard"},
            {0x00003280, "Peppa"},
            {0x00003290, "Bekkon"},
            {0x00003300, "Saibaking"},
            {0x00003310, "Doola"},
            {0x00003320, "Parm"},
            {0x00003330, "Vereen"},
            {0x00003340, "Shorny"},
            {0x00003350, "Kranola"},
            {0x00003360, "Toomel"},
            {0x00003370, "Banya"},
            {0x00003380, "Sirami"},
            {0x00003390, "Mepple"},
            {0x00003400, "Granyu"},
            {0x00003410, "Kadoola"},
            {0x00003420, "Maida"},
            {0x00003430, "Ratopa"},
            {0x00003440, "Pakka"},
            {0x00003450, "Parl"},
            {0x00003460, "Kabla"},
            {0x00003470, "Rumoss"},
            {0x00003480, "Mardoo"},
            {0x00003490, "Haric"},
            {0x00003500, "Ariano"},
            {0x00003510, "Nox"},
            {0x00003520, "Mashima"},
            {0x00003530, "Halto"},
            {0x00003540, "Rubee"},
            {0x00003550, "Paopao"},
            {0x00003560, "Horrito"},
            {0x00003570, "Nanmu"},
            {0x00003580, "Yamma"},
            {0x00003590, "Butor"},
            {0x00003600, "Pappan"},
            {0x00003610, "Petrona"},
            {0x00003620, "Lullus"},
            {0x00003630, "Ninny"},
            {0x00003640, "Pipila"},
            {0x00003650, "Mirayo"},
            {0x00003660, "Neryl"},
            {0x00003670, "Hirica"},
            {0x00003680, "Halda"},
            {0x00003690, "Makma"},
            {0x00003700, "Litee"},
            {0x00003710, "Goku (Kid)"},
            {0x00003720, "Cooler"},
            {0x00003730, "Metal-Cooler"},
            {0x00003740, "Botamo"},
            {0x00003750, "Towa"},
            {0x00003760, "Mira"},
            {0x00003770, "Pinich"},
            {0x00003790, "EX Gotenks"},
            {0x00003800, "Cabbe"},
            {0x00003810, "Frost"},
            {0x00003820, "Hit"},
            {0x00003830, "Magetta"},
            {0x00003840, "Bulla"},
            {0x00003850, "Yamhan"},
            {0x00003860, "Pirillin"},
            {0x00003870, "Pinita"},
            {0x00003880, "Perfect 16"},
            {0x00003890, "Celluza"},
            {0x00003900, "Damira"},
            {0x00003910, "Android 1718"},
            {0x00003920, "Yamta"},
            {0x00003930, "Coolieza"},
            {0x00003940, "Coohan"},
            {0x00003950, "EX Gogeta"},
            {0x00003960, "Great Saiyaman 12"},
            {0x00003970, "Kallohan"},
            {0x00003980, "Picohan"},
            {0x00003990, "Gorillin"},
            {0x00004000, "Krigohan"},
            {0x00004010, "EX Yamham"},
            {0x00004020, "Chiaoldo"},
            {0x00004030, "Vegenks"},
            {0x00004040, "Rappa"},
            {0x00004050, "Dodobon"},
            {0x00004060, "Ginyuman"},
            {0x00004070, "Burce"},
            {0x00004080, "Reguldo"},
            {0x00004090, "Chiaohan"},
            {0x00004100, "Barlot"},
            {0x00004110, "Android 1920"},
            {0x00004120, "Android 1617"},
            {0x00004130, "Cell 17"},
            {0x00004140, "Majin Hercule"},
            {0x00004150, "Janembu"},
            {0x00004160, "Karoly"},
            {0x00004170, "Arale 18"},
            {0x00004180, "Chiaoman"},
            {0x00004190, "Bulpan"},
            {0x00004200, "Nuova Goku"},
            {0x00004210, "Jacunks"},
            {0x00004220, "Towane"},
            {0x00004230, "Ginyuza"},
            {0x00004240, "Towale"},
            {0x00004250, "Whirus"},
            {0x00004260, "Great Jaco"},
            {0x00004270, "Turtz"},
            {0x00004280, "Pandel"},
            {0x00004290, "Kibicollo Kai"},
            {0x00004300, "Kibeer Kai"},
            {0x00004310, "Demon King Daccolo"},
            {0x00004320, "EX Pirillin"},
            {0x00004350, "Goku (Z)"},
            {0x00004360, "Goku (Z) (Super Saiyan)"},
            {0x00004370, "Goku (Z) (Super Saiyan 3)"},
            {0x00004380, "Vegeta (Saiyan Saga)"},
            {0x00004390, "Natz"},
            {0x00004400, "Recurter"},
            {0x00004410, "Gulce"},
            {0x00004420, "EX Gohanks"},
            {0x00004430, "Gohanks: Future"},
            {0x00004440, "Pinich (Super Saiyan)"},
            {0x00004450, "Tanks"},
            {0x00004460, "Great Herculeman"},
            {0x00004470, "Gorus"},
            {0x00004480, "Trunks (DBS)"},
            {0x00004490, "Goku Black"},
            {0x00004500, "Goku Black Super Saiyan Rosé"},
            {0x00004510, "EX Trunks"},
            {0x00004520, "Karoly Black"},
            {0x00004530, "Trunks (DBS) (Super Saiyan)"},
            {0x00004540, "Vegito (Super Saiyan God Super Saiyan)"},
            {0x00004550, "Zamasu"},
            {0x00004560, "Fused Zamasu"},
            {0x00004570, "Gomasu"},
            {0x00011000, "Sageloa"},
            {0x00011001, "Seiya"},
            {0x00011002, "Noomege"},
            {0x00011003, "Sageppa"},
            {0x00011004, "Rubeege"},
            {0x00011005, "Saida"},
            {0x00011006, "Sagelin"},
            {0x00011007, "Mekuge"},
            {0x00011008, "Heiyachof"},
            {0x00011009, "Kloya"},
            {0x00011010, "Heiypa"},
            {0x00011011, "Heiymeg"},
            {0x00011012, "Heiyda"},
            {0x00011013, "Heiybee"},
            {0x00011014, "Mekuya"},
            {0x00011015, "Nooloa"},
            {0x00011016, "Kloachof"},
            {0x00011017, "Rubeeloa"},
            {0x00011018, "Kloda"},
            {0x00011019, "Klolin"},
            {0x00011020, "Mekua"},
            {0x00011021, "Kalpeppa"},
            {0x00011022, "Noopochof"},
            {0x00011023, "Kalpoida"},
            {0x00011024, "Rubeechof"},
            {0x00011025, "Kalpoji"},
            {0x00011026, "Kalpolin"},
            {0x00011027, "Rubeg"},
            {0x00011028, "Noopa"},
            {0x00011029, "Noomlin"},
            {0x00011030, "Noomeji"},
            {0x00011031, "Maidappa"},
            {0x00011032, "Rubeepa"},
            {0x00011033, "Mekuppa"},
            {0x00011034, "Toompa"},
            {0x00011035, "Toomee"},
            {0x00011036, "Rubeeda"},
            {0x00011037, "Mekuida"},
            {0x00011038, "Toomida"},
            {0x00011039, "Mekulin"},
            {0x00011040, "Ghirompa"},
            {0x00011041, "Ghironta"},
            {0x00011042, "Ghirocart"},
            {0x00011043, "Ghirobo"},
            {0x00011044, "Ghirodoo"},
            {0x00011045, "Ghirolto"},
            {0x00011046, "Ghirober"},
            {0x00011047, "Ghirouto"},
            {0x00011048, "Escanta"},
            {0x00011049, "Escampa"},
            {0x00011050, "Estoh"},
            {0x00011051, "Plascart"},
            {0x00011052, "Eyber"},
            {0x00011053, "Elto"},
            {0x00011054, "Mascart"},
            {0x00011055, "Plampa"},
            {0x00011056, "Fumpa"},
            {0x00011057, "Wanpa"},
            {0x00011058, "Halpa"},
            {0x00011059, "Typa"},
            {0x00011060, "Camarpa"},
            {0x00011061, "Wantoh"},
            {0x00011062, "Planta"},
            {0x00011063, "Warnta"},
            {0x00011064, "Camanta"},
            {0x00011065, "Wanber"},
            {0x00011066, "Plarbo"},
            {0x00011067, "Pladoo"},
            {0x00011068, "Platoh"},
            {0x00011069, "Plaulto"},
            {0x00011070, "Martoh"},
            {0x00011071, "Futono"},
            {0x00011072, "Fuber"},
            {0x00011073, "Fulto"},
            {0x00011074, "Halmarbo"},
            {0x00011075, "Tybarbo"},
            {0x00011076, "Camardoo"},
            {0x00011077, "Marber"},
            {0x00011078, "Marlto"},
            {0x00011079, "Halber"},
            {0x00011080, "Rhubjee"},
            {0x00011081, "Racyob"},
            {0x00011082, "Rhubjee"},
            {0x00011083, "Gatob"},
            {0x00011084, "Pappab"},
            {0x00011085, "Yambub"},
            {0x00011086, "Rhubad"},
            {0x00011087, "Rhububon"},
            {0x00011088, "Racto"},
            {0x00011089, "Gatojee"},
            {0x00011090, "Gatonbon"},
            {0x00011091, "Gatord"},
            {0x00011092, "Gatormad"},
            {0x00011093, "Gatomma"},
            {0x00011094, "Gatojee"},
            {0x00011095, "Darjeed"},
            {0x00011096, "Darjard"},
            {0x00011097, "Racjee"},
            {0x00011098, "Toronjee"},
            {0x00011099, "Darjijee"},
            {0x00011100, "Darjpan"},
            {0x00011101, "Racyord"},
            {0x00011102, "Racyomad"},
            {0x00011103, "Racyomma"},
            {0x00011104, "Racyopan"},
            {0x00011105, "Racyojee"},
            {0x00011106, "Pappamad"},
            {0x00011107, "Marmamma"},
            {0x00011108, "Marmard"},
            {0x00011109, "Marmanbon"},
            {0x00011110, "Yammard"},
            {0x00011111, "Muspan"},
            {0x00011112, "Musjee"},
            {0x00011113, "Toronbard"},
            {0x00011114, "Pappanbon"},
            {0x00011115, "Jeepan"},
            {0x00011116, "Pappanma"},
            {0x00011117, "Yamjee"},
            {0x00011118, "Toronma"},
            {0x00011119, "Toronjee"},
            {0x00011120, "Paomai"},
            {0x00011121, "Paobatz"},
            {0x00011122, "Paoyan"},
            {0x00011123, "Paobon"},
            {0x00011124, "Paomoss"},
            {0x00011125, "Paojao"},
            {0x00011126, "Paotal"},
            {0x00011127, "Paopp"},
            {0x00011128, "Zemmatz"},
            {0x00011129, "Eebatz"},
            {0x00011130, "Mabobatz"},
            {0x00011131, "Gobatz"},
            {0x00011132, "Mijao"},
            {0x00011133, "Rubatz"},
            {0x00011134, "Chappbatz"},
            {0x00011135, "Eeyan"},
            {0x00011136, "Zemmai"},
            {0x00011137, "Eemoss"},
            {0x00011138, "Eejao"},
            {0x00011139, "Citamai"},
            {0x00011140, "Chappmai"},
            {0x00011141, "Zemon"},
            {0x00011142, "Zemyan"},
            {0x00011143, "Zemjao"},
            {0x00011144, "Zemmoss"},
            {0x00011145, "Zechapp"},
            {0x00011146, "Citamma"},
            {0x00011147, "Gomoss"},
            {0x00011148, "Maboyan"},
            {0x00011149, "Gotal"},
            {0x00011150, "Chappyan"},
            {0x00011151, "Mabojao"},
            {0x00011152, "Mabomoss"},
            {0x00011153, "Mabopp"},
            {0x00011154, "Mabotal"},
            {0x00011155, "Rumotal"},
            {0x00011156, "Rujao"},
            {0x00011157, "Chajao"},
            {0x00011158, "Chintal"},
            {0x00011159, "Citapp"},
            {0x00011160, "Shaless"},
            {0x00011161, "Shalugo"},
            {0x00011162, "Shamo"},
            {0x00011163, "Shaji"},
            {0x00011164, "Cissile"},
            {0x00011165, "Noxle"},
            {0x00011166, "Tarle"},
            {0x00011167, "Calule"},
            {0x00011168, "Jalugo"},
            {0x00011169, "Jagamoss"},
            {0x00011170, "Jagawa"},
            {0x00011171, "Jagappa"},
            {0x00011172, "Jagartar"},
            {0x00011173, "Jagax"},
            {0x00011174, "Jagato"},
            {0x00011175, "Kreppa"},
            {0x00011176, "Powess"},
            {0x00011177, "Krego"},
            {0x00011178, "Crex"},
            {0x00011179, "Taress"},
            {0x00011180, "Kreiji"},
            {0x00011181, "Powago"},
            {0x00011182, "Calugo"},
            {0x00011183, "Cissigo"},
            {0x00011184, "Luji"},
            {0x00011185, "Tartarugo"},
            {0x00011186, "Caluji"},
            {0x00011187, "Cissippa"},
            {0x00011188, "Powappa"},
            {0x00011189, "Calux"},
            {0x00011190, "Cissiwa"},
            {0x00011191, "Powaji"},
            {0x00011192, "Powatar"},
            {0x00011193, "Powax"},
            {0x00011194, "Hojix"},
            {0x00011195, "Tarji"},
            {0x00011196, "Cissiji"},
            {0x00011197, "Tarsito"},
            {0x00011198, "Cissix"},
            {0x00011199, "Tarx"},
            {0x00011200, "Legabet"},
            {0x00011201, "Gowbet"},
            {0x00011202, "Shaberito"},
            {0x00011203, "Edabet"},
            {0x00011204, "Shabeooa"},
            {0x00011205, "Biwabet"},
            {0x00011206, "Shabessam"},
            {0x00011207, "Snebbet"},
            {0x00011208, "Gowmay"},
            {0x00011209, "Legamay"},
            {0x00011210, "Edanei"},
            {0x00011211, "Android Edamay 33"},
            {0x00011212, "Edassam"},
            {0x00011213, "Biwamay"},
            {0x00011214, "Edarrito"},
            {0x00011215, "Legsam"},
            {0x00011216, "Android Leganon 33"},
            {0x00011217, "Legowry"},
            {0x00011218, "Leganei"},
            {0x00011219, "Legarrito"},
            {0x00011220, "Legapa"},
            {0x00011221, "Android Gowry 33"},
            {0x00011222, "Gowsam"},
            {0x00011223, "Biwaly"},
            {0x00011224, "Gowtopa"},
            {0x00011225, "Gowrrito"},
            {0x00011226, "Ratossam"},
            {0x00011227, "Biwassam"},
            {0x00011228, "Android Assam 33"},
            {0x00011229, "Snessam"},
            {0x00011230, "Android Biwala 33"},
            {0x00011231, "Android Ratopa 33"},
            {0x00011232, "Android Horrito 33"},
            {0x00011233, "Android Snei 33"},
            {0x00011234, "Ratosnei"},
            {0x00011235, "Ratorito"},
            {0x00011236, "Ratowala"},
            {0x00011237, "Biwalito"},
            {0x00011238, "Biwanei"},
            {0x00011239, "Snito"},
            {0x00011240, "Wazma"},
            {0x00011241, "Zukima"},
            {0x00011242, "Uzmai"},
            {0x00011243, "Mashizma"},
            {0x00011244, "Uznell"},
            {0x00011245, "Uziano"},
            {0x00011246, "Uza G"},
            {0x00011247, "Bazma"},
            {0x00011248, "Zukibar"},
            {0x00011249, "Zukiffen"},
            {0x00011250, "Mashini"},
            {0x00011251, "Maikini"},
            {0x00011252, "Arini"},
            {0x00011253, "Zukinell"},
            {0x00011254, "Zukisco"},
            {0x00011255, "Maiffen"},
            {0x00011256, "Waffar"},
            {0x00011257, "Waffell"},
            {0x00011258, "Ariffen"},
            {0x00011259, "Waff G"},
            {0x00011260, "Wafco"},
            {0x00011261, "Mashimar"},
            {0x00011262, "Maimar"},
            {0x00011263, "Aribar"},
            {0x00011264, "Zibarell"},
            {0x00011265, "Zibasco"},
            {0x00011266, "Zibara G"},
            {0x00011267, "Mainell"},
            {0x00011268, "Mashimai"},
            {0x00011269, "Maba G"},
            {0x00011270, "Masco"},
            {0x00011271, "Mashiano"},
            {0x00011272, "Mashiell"},
            {0x00011273, "Mashibasco"},
            {0x00011274, "Mashiba G"},
            {0x00011275, "Babanell"},
            {0x00011276, "Mariano"},
            {0x00011277, "Arisco"},
            {0x00011278, "Ariba G"},
            {0x00011279, "Basba G"},
            {0x00011280, "Android Bekon 55"},
            {0x00011281, "Android Beeyan 55"},
            {0x00011282, "Android Stroganof 55"},
            {0x00011283, "Android Saibaking"},
            {0x00011284, "Android Ryuto 55"},
            {0x00011285, "Android Parl 55"},
            {0x00011286, "Android Binas 55"},
            {0x00011287, "Android Vasabi 55"},
            {0x00011288, "Stronganoyan"},
            {0x00011289, "Bekoganof"},
            {0x00011290, "Strolin"},
            {0x00011291, "Strogasabi"},
            {0x00011292, "Binaganof"},
            {0x00011293, "Strogarl"},
            {0x00011294, "Stroganoto"},
            {0x00011295, "Besabi"},
            {0x00011296, "Bekkolin"},
            {0x00011297, "Bekkoyan"},
            {0x00011298, "Bekkorl"},
            {0x00011299, "Benas"},
            {0x00011300, "Saibaekkon"},
            {0x00011301, "Beelin"},
            {0x00011302, "Sabiyan"},
            {0x00011303, "Ryuyan"},
            {0x00011304, "Saibayan"},
            {0x00011305, "Binayan"},
            {0x00011306, "Saibavasabi"},
            {0x00011307, "Ryusabi"},
            {0x00011308, "Sabilin"},
            {0x00011309, "Vasarl"},
            {0x00011310, "Ryulin"},
            {0x00011311, "Saibalin"},
            {0x00011312, "Parlin"},
            {0x00011313, "Binalin"},
            {0x00011314, "Saibaparl"},
            {0x00011315, "Saibanas"},
            {0x00011316, "Saibato"},
            {0x00011317, "Ryunas"},
            {0x00011318, "Ryarl"},
            {0x00011319, "Binarl"},
            {0x00011320, "Papiba"},
            {0x00011321, "Yubash"},
            {0x00011322, "Jejeeba"},
            {0x00011323, "Yubanjo"},
            {0x00011324, "Yubak"},
            {0x00011325, "Yucarl"},
            {0x00011326, "Yubaric"},
            {0x00011327, "Yubakka"},
            {0x00011328, "Dennijo"},
            {0x00011329, "Paprijo"},
            {0x00011330, "Panjo"},
            {0x00011331, "Shaonjo"},
            {0x00011332, "Harinjo"},
            {0x00011333, "Nencarl"},
            {0x00011334, "Nenja"},
            {0x00011335, "Paparic"},
            {0x00011336, "Papron"},
            {0x00011337, "Dennika"},
            {0x00011338, "Paprakka"},
            {0x00011339, "Paprija"},
            {0x00011340, "Papwak"},
            {0x00011341, "Denniron"},
            {0x00011342, "Denniric"},
            {0x00011343, "Dennarl"},
            {0x00011344, "Dennik"},
            {0x00011345, "Dennija"},
            {0x00011346, "Hariwak"},
            {0x00011347, "Haricarl"},
            {0x00011348, "Harion"},
            {0x00011349, "Harrikka"},
            {0x00011350, "Shaorl"},
            {0x00011351, "Shaok"},
            {0x00011352, "Jajaron"},
            {0x00011353, "Pakkaron"},
            {0x00011354, "Chiwakka"},
            {0x00011355, "Jajak"},
            {0x00011356, "Chiwarl"},
            {0x00011357, "Jacarl"},
            {0x00011358, "Scakka"},
            {0x00011359, "Pajee"},
            {0x00011360, "Nankutz"},
            {0x00011361, "Nanga"},
            {0x00011362, "Nanda"},
            {0x00011363, "Nanto"},
            {0x00011364, "Nanquiche"},
            {0x00011365, "Nanlin"},
            {0x00011366, "Nanshimo"},
            {0x00011367, "Nantsum"},
            {0x00011368, "Sogac"},
            {0x00011369, "Sogutz"},
            {0x00011370, "Nattoga"},
            {0x00011371, "Souda"},
            {0x00011372, "Quiga"},
            {0x00011373, "Souiche"},
            {0x00011374, "Datsuga"},
            {0x00011375, "Chautz"},
            {0x00011376, "Kumeric"},
            {0x00011377, "Kuiche"},
            {0x00011378, "Kullin"},
            {0x00011379, "Kumo"},
            {0x00011380, "Datz"},
            {0x00011381, "Nattoric"},
            {0x00011382, "Chauric"},
            {0x00011383, "Quilic"},
            {0x00011384, "Turmeche"},
            {0x00011385, "Datsuric"},
            {0x00011386, "Yashiric"},
            {0x00011387, "Chauche"},
            {0x00011388, "Nattoda"},
            {0x00011389, "Yashida"},
            {0x00011390, "Datsuda"},
            {0x00011391, "Nattolin"},
            {0x00011392, "Nattoche"},
            {0x00011393, "Nattom"},
            {0x00011394, "Nattomo"},
            {0x00011395, "Yashiche"},
            {0x00011396, "Quilliche"},
            {0x00011397, "Datsulin"},
            {0x00011398, "Yashilin"},
            {0x00011399, "Datsumo"},
            {0x00011400, "Android Kabla 44"},
            {0x00011401, "Hukibla"},
            {0x00011402, "Kadoobla"},
            {0x00011403, "Calabla"},
            {0x00011404, "Hoybla"},
            {0x00011405, "Kabmen"},
            {0x00011406, "Rakbla"},
            {0x00011407, "Macabla"},
            {0x00011408, "Hukidoola"},
            {0x00011409, "Android Kadoola 44"},
            {0x00011410, "Kadongo"},
            {0x00011411, "Kadoroo"},
            {0x00011412, "Rajyoola"},
            {0x00011413, "Kadoomen"},
            {0x00011414, "Kadocoli"},
            {0x00011415, "Android Macaroo 44"},
            {0x00011416, "Android Bongo 44"},
            {0x00011417, "Android Huki 44"},
            {0x00011418, "Android Lomen 44"},
            {0x00011419, "Android Rakyo 44"},
            {0x00011420, "Android Calao 44"},
            {0x00011421, "Hukingo"},
            {0x00011422, "Hukiroo"},
            {0x00011423, "Hukicoli"},
            {0x00011424, "Hukio"},
            {0x00011425, "Hukiyo"},
            {0x00011426, "Macalo"},
            {0x00011427, "Hoycoliroo"},
            {0x00011428, "Bongroo"},
            {0x00011429, "Macamen"},
            {0x00011430, "Bongcoli"},
            {0x00011431, "Calango"},
            {0x00011432, "Rakyongo"},
            {0x00011433, "Bonmen"},
            {0x00011434, "Calamen"},
            {0x00011435, "Calayo"},
            {0x00011436, "Calacoli"},
            {0x00011437, "Hoycoyo"},
            {0x00011438, "Hoicomen"},
            {0x00011439, "Loyo"},
            {0x00011440, "Bukun"},
            {0x00011441, "Bukhatz"},
            {0x00011442, "Bukhan"},
            {0x00011443, "Bukwash"},
            {0x00011444, "Android Bukha 76"},
            {0x00011445, "Bukhatz"},
            {0x00011446, "Bucuit"},
            {0x00011447, "Bakhator"},
            {0x00011448, "Garash"},
            {0x00011449, "Yamash"},
            {0x00011450, "Butosh"},
            {0x00011451, "Fargash"},
            {0x00011452, "Pikwash"},
            {0x00011453, "Zalush"},
            {0x00011454, "Drash"},
            {0x00011455, "Yamcuit"},
            {0x00011456, "Yamgo"},
            {0x00011457, "Yamatz"},
            {0x00011458, "Butokun"},
            {0x00011459, "Drakun"},
            {0x00011460, "Android Yamkun 76"},
            {0x00011461, "Fargoz"},
            {0x00011462, "Piratz"},
            {0x00011463, "Zarutz"},
            {0x00011464, "Android Garatz 76"},
            {0x00011465, "Garan"},
            {0x00011466, "Android Piscuit 76"},
            {0x00011467, "Zalcuit"},
            {0x00011468, "Fargocuit"},
            {0x00011469, "Butcuit"},
            {0x00011470, "Zalugo"},
            {0x00011471, "Android Fargo 76"},
            {0x00011472, "Fargon"},
            {0x00011473, "Fargole"},
            {0x00011474, "Android Butor 76"},
            {0x00011475, "Android Dran 76"},
            {0x00011476, "Android Zalutz 76"},
            {0x00011477, "Dratz"},
            {0x00011478, "Zaltor"},
            {0x00011479, "Butran"},
            {0x00011480, "Parmon"},
            {0x00011481, "Eclon"},
            {0x00011482, "Kallorny"},
            {0x00011483, "Choklyn"},
            {0x00011484, "Liteen"},
            {0x00011485, "Khaloccola"},
            {0x00011486, "Pannan"},
            {0x00011487, "Kallcona"},
            {0x00011488, "Nazzlain"},
            {0x00011489, "Parmain"},
            {0x00011490, "Choklain"},
            {0x00011491, "Eckainy"},
            {0x00011492, "Ruccorain"},
            {0x00011493, "Litain"},
            {0x00011494, "Petraina"},
            {0x00011495, "Parmny"},
            {0x00011496, "Nazzarm"},
            {0x00011497, "Liteem"},
            {0x00011498, "Parmcola"},
            {0x00011499, "Pamna"},
            {0x00011500, "Pamrona"},
            {0x00011501, "Nazzly"},
            {0x00011502, "Nazzny"},
            {0x00011503, "Nazzcola"},
            {0x00011504, "Naztee"},
            {0x00011505, "Nazzrona"},
            {0x00011506, "Nazzna"},
            {0x00011507, "Liteerny"},
            {0x00011508, "Chokny"},
            {0x00011509, "Pannarny"},
            {0x00011510, "Petrony"},
            {0x00011511, "Chokola"},
            {0x00011512, "Liteely"},
            {0x00011513, "Petrokly"},
            {0x00011514, "Chokna"},
            {0x00011515, "Liteena"},
            {0x00011516, "Ruccolitee"},
            {0x00011517, "Ructrona"},
            {0x00011518, "Ruccona"},
            {0x00011519, "Patonna"},
            {0x00011520, "Stabstrony"},
            {0x00011521, "Pribba"},
            {0x00011522, "Sesabba"},
            {0x00011523, "Stabban"},
            {0x00011524, "Lulluba"},
            {0x00011525, "Stellaba"},
            {0x00011526, "Makmaba"},
            {0x00011527, "Kranoba"},
            {0x00011528, "Sesarika"},
            {0x00011529, "Sesarony"},
            {0x00011530, "Sesatta"},
            {0x00011531, "Kranomy"},
            {0x00011532, "Sesama"},
            {0x00011533, "Sestella"},
            {0x00011534, "Lulluny"},
            {0x00011535, "Kranoly"},
            {0x00011536, "Strotta"},
            {0x00011537, "Priony"},
            {0x00011538, "Stellany"},
            {0x00011539, "Makrony"},
            {0x00011540, "Vereeny"},
            {0x00011541, "Pritta"},
            {0x00011542, "Prinola"},
            {0x00011543, "Prillus"},
            {0x00011544, "Preen"},
            {0x00011545, "Prima"},
            {0x00011546, "Kranoleen"},
            {0x00011547, "Lullola"},
            {0x00011548, "Kranotta"},
            {0x00011549, "Krastella"},
            {0x00011550, "Lullutta"},
            {0x00011551, "Veretta"},
            {0x00011552, "Maketta"},
            {0x00011553, "Stetta"},
            {0x00011554, "Verella"},
            {0x00011555, "Vereema"},
            {0x00011556, "Lullun"},
            {0x00011557, "Lulluma"},
            {0x00011558, "Lulla"},
            {0x00011559, "Mella"},
            {0x00011560, "Gram"},
            {0x00011561, "Jamsee"},
            {0x00011562, "Jams"},
            {0x00011563, "Jysa"},
            {0x00011564, "Jalda"},
            {0x00011565, "Jamila"},
            {0x00011566, "Jample"},
            {0x00011567, "Jarmis"},
            {0x00011568, "Oatsee"},
            {0x00011569, "Oatnyu"},
            {0x00011570, "Oatco"},
            {0x00011571, "Oatmis"},
            {0x00011572, "Oapple"},
            {0x00011573, "Oatla"},
            {0x00011574, "Oatda"},
            {0x00011575, "Gramis"},
            {0x00011576, "Peconyu"},
            {0x00011577, "Liseenyu"},
            {0x00011578, "Pipinyu"},
            {0x00011579, "Meppnyu"},
            {0x00011580, "Grasa"},
            {0x00011581, "Liseco"},
            {0x00011582, "Liseemis"},
            {0x00011583, "Liseeda"},
            {0x00011584, "Liseesa"},
            {0x00011585, "Lisepple"},
            {0x00011586, "Narsa"},
            {0x00011587, "Narmida"},
            {0x00011588, "Percomis"},
            {0x00011589, "Pipimis"},
            {0x00011590, "Pecopple"},
            {0x00011591, "Pipipeco"},
            {0x00011592, "Pecolda"},
            {0x00011593, "Pecosa"},
            {0x00011594, "Pipisa"},
            {0x00011595, "Meysa"},
            {0x00011596, "Halsa"},
            {0x00011597, "Melda"},
            {0x00011598, "Pipida"},
            {0x00011599, "Pipipple"},
            {0x00011600, "Minya"},
            {0x00011601, "Peperonya"},
            {0x00011602, "Marinya"},
            {0x00011603, "Toonya"},
            {0x00011604, "Kicleenya"},
            {0x00011605, "Hirinya"},
            {0x00011606, "Shalonyan"},
            {0x00011607, "Ninnya"},
            {0x00011608, "Pepemel"},
            {0x00011609, "Minmel"},
            {0x00011610, "Ninmel"},
            {0x00011611, "Sanmel"},
            {0x00011612, "Shalomel"},
            {0x00011613, "Hirimel"},
            {0x00011614, "Marimel"},
            {0x00011615, "Shalont"},
            {0x00011616, "Sant"},
            {0x00011617, "Pepent"},
            {0x00011618, "Ninnt"},
            {0x00011619, "Mirinay"},
            {0x00011620, "Minlee"},
            {0x00011621, "Pepenla"},
            {0x00011622, "Shaloron"},
            {0x00011623, "Peperica"},
            {0x00011624, "Pepelee"},
            {0x00011625, "Mariron"},
            {0x00011626, "Shalolee"},
            {0x00011627, "Hirilot"},
            {0x00011628, "Sanlot"},
            {0x00011629, "Ninlot"},
            {0x00011630, "Sanlica"},
            {0x00011631, "Kicla"},
            {0x00011632, "Marinla"},
            {0x00011633, "Ninnla"},
            {0x00011634, "Ninnly"},
            {0x00011635, "Marilee"},
            {0x00011636, "Kirica"},
            {0x00011637, "Hirinay"},
            {0x00011638, "Ninrica"},
            {0x00011639, "Marinny"},
            {0x00011640, "Nerylnira"},
            {0x00011641, "Nerydoola"},
            {0x00011642, "Kaliryl"},
            {0x00011643, "Minaryl"},
            {0x00011644, "Yunaryl"},
            {0x00011645, "Tiraryl"},
            {0x00011646, "Quinnyl"},
            {0x00011647, "Chocoryl"},
            {0x00011648, "Miradoola"},
            {0x00011649, "Mirara"},
            {0x00011650, "Miracora"},
            {0x00011651, "Mirami"},
            {0x00011652, "Miranny"},
            {0x00011653, "Mirarami"},
            {0x00011654, "Kaliyo"},
            {0x00011655, "Quinnira"},
            {0x00011656, "Sirara"},
            {0x00011657, "Nidoola"},
            {0x00011658, "Chocorara"},
            {0x00011659, "Kalira"},
            {0x00011660, "Yunara"},
            {0x00011661, "Siradoola"},
            {0x00011662, "Quidoola"},
            {0x00011663, "Tiradoola"},
            {0x00011664, "Doonaly"},
            {0x00011665, "Kalifoola"},
            {0x00011666, "Yunanny"},
            {0x00011667, "Tiranny"},
            {0x00011668, "Quimi"},
            {0x00011669, "Choconny"},
            {0x00011670, "Sitirami"},
            {0x00011671, "Yunami"},
            {0x00011672, "Silif"},
            {0x00011673, "Chocorami"},
            {0x00011674, "Yunara"},
            {0x00011675, "Yunaf"},
            {0x00011676, "Tiraly"},
            {0x00011677, "Tiraf"},
            {0x00011678, "Tirata"},
            {0x00011679, "Chocof"},
        };
    }
}
