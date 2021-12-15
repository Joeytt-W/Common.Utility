﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utility
{
    public class Utils
    {
        private static string[] PY = new string[] {
                "A阿啊锕嗄厑哎哀唉埃挨溾锿鎄啀捱皑凒溰嘊敳皚癌毐昹嗳矮蔼躷噯藹譪霭靄艾伌爱砹硋隘嗌塧嫒愛碍暧瑷僾壒嬡懓薆曖璦鴱皧瞹馤鑀鱫安侒峖桉氨庵谙萻腤鹌蓭誝鞌鞍盦馣鮟盫韽啽雸垵俺唵埯铵隌揞罯銨犴岸按荌案胺豻堓婩暗貋儑錌黯肮岇昂昻枊盎醠凹坳垇柪軪爊敖厫隞嗷嗸嶅廒滶獒獓遨熬璈蔜翱聱螯翶謷翺鳌鏖鰲鷔鼇芺袄媪镺襖岙扷岰傲奡奥嫯慠骜奧嶴澳懊擙謸鏊",
                "B八仈巴叭扒朳玐吧夿岜芭疤哵捌笆粑紦羓蚆釟豝鲃魞叐犮抜坺妭拔茇炦癹胈釛菝詙跋軷魃把靶坝弝爸垻罢鲅鮁覇矲霸壩灞欛挀掰白百佰柏栢捭竡粨摆擺襬呗拝败拜唄敗稗粺鞁薭贁兡瓸扳攽班般颁斑搬斒瘢螁癍辬阪坂岅昄板版瓪钣粄舨鈑蝂魬办半伴扮姅怑拌绊秚絆鉡靽辦瓣邦峀垹帮捠梆浜邫幇幚縍幫鞤绑綁榜膀玤蚌傍棒谤塝稖蒡蜯磅镑艕謗勹包佨孢苞胞笣煲龅蕔褒闁齙窇嫑雹宝怉饱保鸨珤堡堢媬葆寚飹飽褓駂鳵緥鴇賲藵寳寶靌勽报抱豹趵菢鲍靤骲暴髱虣儤曓爆忁鑤萡陂卑杯盃桮悲揹碑鹎藣鵯喺北鉳贝狈貝邶备昁牬苝背钡俻倍悖狽被偝偹梖珼鄁備僃惫焙軰辈愂碚禙蓓蛽犕褙誖骳輩鋇憊糒鞴鐾奔泍贲倴渀逩犇锛錛本苯奙畚楍坌捹桳笨撪輽伻崩绷閍嵭嘣綳繃甭埲菶琫鞛泵迸塴甏镚蹦鏰屄毴逼豍鲾鵖鰏柲荸鼻嬶匕比夶朼佊吡妣沘疕彼柀秕俾笔粊舭筆鄙聛貏匂币必毕闭佖坒庇诐邲妼怭畀畁哔毖珌疪荜陛毙狴畢袐铋婢庳敝梐萆萞閇閉堛弻弼愊愎湢皕禆筚詖貱赑嗶彃楅滗滭煏痹腷蓖蓽蜌裨跸閟飶幣弊熚獙碧箅綼蔽鄪馝幤潷獘罼襅駜髲壁嬖廦篦篳縪薜觱避鮅斃濞臂蹕髀奰璧鄨饆繴襞襣鏎鞸韠躃躄魓贔鐴驆鷝鷩鼊边砭笾编煸甂箯編蝙獱邉鍽鳊邊鞭鯾鯿籩炞贬扁窆匾惼碥稨褊糄鴘藊卞弁忭抃汳汴苄釆峅便变変昪覍揙缏遍辡艑辧辨辩辫辮變彪标飑髟猋脿墂幖滮骠標熛膘瘭镖飙飚儦颷瀌爂臕贆鏢镳飆飇飈飊鑣表婊裱諘褾錶檦俵鳔鰾憋鳖鱉鼈虌龞別别咇莂蛂徶襒蟞蹩瘪癟彆邠宾彬傧斌椕滨缤槟瑸賓賔镔儐濒濱濵虨豳瀕霦繽蠙鑌顮氞摈殡膑髩擯鬂殯臏髌鬓髕鬢仌氷冰兵栟掤梹鋲檳丙邴陃怲抦秉苪昺柄炳饼窉蛃棅禀鈵鞆餅餠燷并並併幷垪庰倂栤病竝偋傡寎摒誁鮩靐癶拨波玻剥盋袯钵饽啵紴缽脖菠鉢僠嶓播餑蹳驋鱍仢伯孛驳帛泊狛瓝侼勃胉郣亳挬浡秡钹铂舶博渤葧鹁愽搏鈸鉑馎鲌僰煿牔箔膊艊馛駁踣鋍镈薄駮鮊懪礡簙鎛餺鵓犦欂襮礴鑮跛箥簸孹擘檗糪譒蘗蔔峬庯逋钸晡鈽誧餔轐醭卜卟补哺捕補鳪鸔不布佈步咘怖歨歩钚勏埗悑部埠瓿廍蔀踄篰餢簿玢佛夯宀疒瀑",
                "C嚓擦礤礸遪猜才材财財戝裁采倸埰婇寀彩採睬跴綵踩菜棌蔡縩乲参飡骖湌嬠餐驂残蚕惭殘慚蝅慙蠶蠺惨慘噆憯黪黲灿粲儏澯薒燦璨爘仓仺伧沧苍倉舱傖凔嵢滄獊蒼濸艙螥罉藏欌鑶賶撡操糙曺曹嘈嶆漕蓸槽褿艚螬鏪艹艸草愺騲肏襙册侧厕恻测荝敇萗惻測策萴筞蓛墄箣憡嵾膥岑梣涔噌层層竲驓蹭硛硳岾猠乽叉芆杈肞臿訍偛嗏插馇銟锸艖疀鍤餷垞查査茬茶嵖搽猹靫槎察碴檫衩镲鑔奼汊岔侘诧姹差紁拆钗釵犲侪柴祡豺喍儕虿袃瘥蠆囆辿觇梴掺搀鋓幨婵谗孱棎湹禅馋嬋煘缠獑蝉誗鋋廛潹潺緾磛毚鄽镡瀍儳劖蟾酁嚵壥巉瀺纏纒躔镵艬讒鑱饞产刬旵丳浐剗谄產産铲阐蒇剷嵼滻幝蕆諂閳簅冁繟醦鏟闡囅灛讇忏硟摲懴颤懺羼韂伥昌娼淐猖菖阊晿椙琩裮锠錩鲳鯧鼚兏肠苌尝偿常徜瓺萇甞腸嘗嫦瑺膓鋿償嚐蟐鲿鏛鱨厂场昶惝敞僘厰廠氅鋹怅玚畅倡鬯唱悵暢畼誯韔抄弨怊欩钞焯超鈔繛牊晁巢巣朝鄛漅嘲潮窲罺轈吵炒眧煼麨巐仦耖觘车車砗唓莗硨蛼扯偖撦屮彻坼迠烢聅掣硩頙徹撤澈勶瞮爡抻郴棽琛嗔諃賝尘臣忱沉辰陈茞宸烥莐敐晨訦谌揨煁蔯塵樄瘎霃螴諶薼麎曟鷐趻硶碜墋夦磣踸贂闯衬疢称龀趁榇稱齓齔嚫谶襯讖阷泟柽爯棦浾偁蛏铛牚琤赪憆摚靗撐撑緽橕瞠赬頳檉竀穪蟶鏳鏿饓丞成呈承枨诚郕城宬峸洆荿乘埕挰珹掁窚脭铖堘惩棖椉程筬絾裎塍塖溗碀誠畻酲鋮澂澄橙檙鯎瀓懲騬悜逞骋庱睈騁秤吃妛杘侙哧彨蚩鸱瓻眵笞訵嗤媸摛痴瞝螭鴟鵄癡魑齝攡麶彲黐弛池驰迟岻茌持竾荎淔筂貾遅馳墀踟篪謘尺叺呎肔侈卶齿垑胣恥耻蚇豉欼歯裭鉹褫齒彳叱斥灻赤饬抶勅恜炽翄翅敕烾痓啻湁傺痸腟鉓雴憏翤遫慗瘛翨熾懘趩饎鶒鷘充冲忡沖茺浺珫翀舂嘃摏憃憧衝罿艟蹖虫崇崈隀宠铳銃抽瘳篘犨犫仇俦帱栦惆绸菗畴絒愁皗稠筹酧酬踌雔嬦懤燽雠疇躊讎讐丑丒吜杽侴瞅醜矁魗臭遚殠出岀初摴樗貙齣刍除厨滁蒢豠锄榋耡蒭蜍趎雏犓廚篨橱懨幮櫉蟵躇櫥蹰鶵躕杵础椘储楮禇楚褚濋儲檚璴礎齭齼亍処处竌怵拀绌豖竐珿絀傗琡鄐搐触踀閦儊憷橻斶歜臅黜觸矗搋膗揣啜嘬踹巛川氚穿剶瑏传舡船圌遄椽歂暷輲舛荈喘僢汌串玔钏釧賗刅囱疮窓窗牎摐牕瘡窻床牀噇傸磢闖创怆刱剏剙愴吹炊龡垂桘陲捶菙棰槌锤錘顀旾杶春萅堾媋暙椿槆瑃箺蝽橁櫄鰆鶞纯陙唇浱莼淳脣犉滣蒓鹑漘醇醕鯙偆萶惷睶賰踳蠢踔戳辵娖惙涰绰逴辍酫綽輟龊擉磭歠嚽齪鑡呲玼疵趀偨词珁垐柌祠茈茨瓷詞辝慈甆辞磁雌鹚糍辤飺餈嬨濨鴜礠辭鶿鷀此佌皉朿次佽刺刾庛茦栨莿絘蛓赐螆賜嗭从匆囪苁忩枞茐怱悤焧葱漗聡蔥骢暰樬瑽璁聦聪瞛篵聰蟌繱鏦騘驄丛従婃孮徖悰淙琮慒誴賨賩樷藂叢灇欉爜謥凑湊楱腠辏輳粗觕麁麄麤徂殂促猝媨瘄蔟誎趗憱醋瘯簇縬蹙鼀蹴蹵顣汆撺镩蹿攛躥鑹攅櫕巑窜熶篡殩簒竄爨崔催凗墔慛摧榱獕磪鏙乼漼璀皠忰疩翆脃脆啐啛悴淬萃毳焠瘁粹翠膵膬竁襊臎邨村皴澊竴存刌忖寸籿搓瑳遳磋撮蹉醝髊虘嵯嵳痤矬蒫鹾鹺齹脞剉剒厝夎挫莝莡措逪棤锉蓌错銼刂刹畜曾膪澶骣粢",
                "D詫襜燀譂奲虰坘蚳赿跮揰裯儔幬篅搥錞踧吋咑哒耷畣搭嗒褡噠墶达妲怛垯炟羍荙匒笪答詚跶瘩靼薘鞑燵繨蟽躂鐽龖龘打大亣眔橽呆獃懛歹傣代汏轪侢垈岱帒甙绐迨带待怠柋殆玳贷帯軑埭帶紿袋逮軩瑇叇曃緿鮘鴏戴艜黛簤瀻霴襶靆丹妉单担眈砃耼耽郸聃躭媅殚瘅匰箪褝鄲頕儋勯殫襌簞聸刐狚玬瓭胆衴疸紞掸馾澸黕膽旦但帎沊泹诞柦疍啖啗弹惮淡萏蛋啿氮腅蜑觛窞誕噉髧憚憺澹禫駳鴠甔癚嚪贉霮饏当珰裆筜當儅噹澢璫襠簹艡蟷挡党谠擋譡灙讜氹凼圵宕砀垱荡档菪瓽雼碭瞊趤壋檔璗盪礑刀叨屶忉氘舠釖鱽魛捯导岛陦倒島捣祷禂搗隝嶋嶌槝導隯壔嶹擣蹈禱到悼盗菿椡盜道稲噵稻衜檤衟翿軇瓙纛恴得淂悳惪锝嘚徳德鍀的揼扥扽灯登豋噔嬁燈璒竳簦艠覴蹬等戥邓凳鄧隥墱嶝瞪磴镫櫈鐙仾低彽袛啲埞羝隄堤趆嘀滴镝磾鞮鏑廸狄肑籴苖迪唙敌涤荻梑笛觌靮滌嫡蔋蔐頔魡敵嚁藡豴糴鸐氐厎诋邸阺呧坻底弤抵柢砥掋菧軧聜骶鯳地弟旳杕玓怟枤俤帝埊娣递逓偙梊焍眱祶第菂谛釱棣睇缔蒂僀禘腣鉪馰墑墬碲蔕慸甋締嶳螮嗲敁掂傎厧嵮滇槙瘨颠蹎巅癫巓巔攧癲齻典奌点婰敟椣碘蒧蕇踮电佃甸阽坫店垫扂玷钿婝惦淀奠琔殿蜔電墊壂橂澱靛磹癜簟驔刁叼汈刟虭凋奝弴彫蛁琱貂碉殦瞗雕鮉鲷簓鼦鯛鵰屌弔伄吊钓窎訋掉釣铞鈟竨銱雿瘹窵鋽鑃爹跌褺苵迭垤峌恎绖胅瓞眣耊戜谍堞幉揲畳絰耋詄叠殜牃牒镻嵽碟蜨褋艓蝶疂蹀鲽曡疉疊氎嚸丁仃叮帄玎甼疔盯钉耵酊靪顶頂鼎嵿薡鐤订饤矴定訂飣啶萣椗腚碇锭碠聢錠磸顁丟丢铥颩銩东冬咚岽東苳昸氡倲鸫埬娻崬涷笗菄氭蝀鮗鼕鯟鶇鶫董嬞懂箽蕫諌动冻侗垌姛峒恫挏栋洞胨迵凍戙胴動崠硐棟腖働駧霘剅唗都兜兠蔸橷篼艔斗乧阧抖陡蚪鈄豆郖浢荳逗饾鬥梪脰酘痘閗窦鬦餖斣闘竇鬪鬬鬭嘟督醏毒涜读渎椟牍犊裻読蝳獨錖凟匵嬻瀆櫝殰牘犢瓄皾騳黩讀豄贕韣髑鑟韇韥黷讟厾独笃堵帾琽赌睹覩賭篤芏妒杜肚妬度荰秺渡靯镀螙殬鍍蠧蠹偳媏端鍴短段断塅缎葮椴煅瑖腶碫锻緞毈簖鍛斷躖籪叾垖堆塠嵟痽頧鴭鐜队对兑対祋怼陮碓綐對憝濧薱镦懟瀩譈鐓譵吨惇敦墩墪壿撴獤噸撉犜礅蹲蹾驐盹趸躉伅沌炖盾砘逇钝顿遁鈍頓碷遯潡踲多咄哆剟崜毲裰嚉夺铎剫掇敓敚敪痥鈬奪凙踱鮵鐸朵朶哚垛挅挆埵缍椯趓躱躲綞亸鬌嚲刴剁沲陊饳垜尮桗堕舵惰跢跥跺飿嶞憜墯鵽卩亻赕铫町铤夂",
                "E娾砵妸妿娿屙讹囮迗俄娥峨峩涐莪珴訛皒睋鈋锇鹅蛾磀誐頟额額鵝鵞譌枙砈婀騀鵈厄歺戹阨呃扼苊阸呝砐轭咢垩峉匎恶砨蚅饿偔卾悪硆谔軛鄂阏堮崿愕湂萼豟軶遌遏廅搹琧腭僫蝁锷鹗蕚遻頞颚餓噩擜覨諤餩鍔鳄歞顎櫮鰐鶚讍鑩齶鱷奀恩蒽峎摁鞥仒乻旕儿而侕陑峏洏荋栭胹袻鸸粫輀鲕隭髵鮞鴯轜尔耳迩洱饵栮毦珥铒餌駬薾邇趰二弍弐佴刵咡贰貮衈貳誀嗯唔诶",
                "F颰墢鼥韛朌頒報賁獖祊埄偪胇貶昞眪袚撥柭襏舩发沷発發彂髪橃醗乏伐姂垡疺罚阀栰傠筏瞂罰閥罸藅佱法砝鍅灋珐琺髮帆忛番勫噃墦嬏幡憣旙旛翻藩轓颿飜鱕凡凢凣匥杋柉矾籵钒舤烦舧笲釩棥煩緐樊蕃橎燔璠薠繁襎繙羳蹯瀿礬蘩鐇蠜鷭反仮払辺返氾犯奿汎泛饭范贩畈訉軓梵盕笵販軬飯飰滼嬎範嬔瀪方邡坊芳枋牥钫淓蚄堏鈁錺鴋防妨房肪埅鲂魴仿访纺昉昘瓬眆倣旊紡舫訪髣鶭放飞妃非飛啡婓婔渄绯菲扉猆靟裶緋蜚霏鲱餥馡騑騛鯡飝肥淝暃腓蜰蟦匪诽奜悱斐棐榧翡蕜誹篚吠废杮沸狒肺昲费俷剕厞疿屝萉廃費痱镄廢蕟曊癈鼣濷櫠鐨靅分吩帉纷芬昐氛竕紛翂棻訜躮酚鈖雰朆餴饙坟妢岎汾枌炃肦梤羒蚠蚡棼焚蒶馚隫墳幩蕡魵鳻橨燌燓豮鼢羵鼖豶轒鐼馩黂粉瞓黺份坋弅奋忿秎偾愤粪僨憤奮膹糞鲼瀵鱝丰风仹凨凬妦沣沨凮枫封疯盽砜風峯峰偑桻烽琒崶渢溄猦葑锋楓犎蜂瘋碸僼篈鄷鋒檒豐鎽鏠酆寷灃靊飌麷冯捀逢堸綘缝艂縫讽覂唪諷凤奉甮俸湗焨煈赗鳯鳳鴌賵蘕瓰覅仏坲梻紑缶否缹缻雬鴀夫伕邞呋姇枎玞肤怤柎砆荂衭娐荴旉紨趺酜麸稃跗鈇筟綒孵敷麩糐麬麱懯乀弗伏凫甶冹刜孚扶芙芣芾咈岪帗彿怫拂服泭绂绋苻茀俘垘枹柫氟洑炥玸畉畐祓罘茯郛韨鳬哹栿浮畗砩莩蚨匐桴涪烰琈符笰紱紼翇艴菔幅絥罦葍福粰綍艀蜉辐鉘鉜颫鳧榑稪箙複韍幞澓蝠髴鴔諨踾輻鮄癁鮲黻鵩鶝抚甫府弣拊斧俌郙俯釜釡捬辅椨焤盙腑滏腐輔簠黼父讣付妇负附咐坿竎阜驸复祔訃負赴蚥袝偩冨副婏婦蚹傅媍富復萯蛗覄詂赋椱缚腹鲋禣褔赙緮蕧蝜蝮賦駙縛輹鮒賻鍑鍢鳆覆馥鰒猤攵犭",
                "G玵閞鳺旮伽嘠钆尜嘎噶錷尕玍尬魀该陔垓姟峐荄晐赅畡祴該豥賅賌忋改絠鎅丐乢匃匄杚钙盖溉葢鈣戤概蓋槩槪漑瓂干甘芉迀杆玕肝坩泔苷柑竿疳酐粓亁凲尲尴筸漧尶尷魐皯秆衦赶敢笴稈感澉趕橄擀簳鳡鱤旰盰矸绀倝凎淦紺詌骭幹檊赣灨冈罓冮刚岗纲肛岡牨疘缸钢剛罡堈掆釭棡犅堽綱罁鋼鎠崗港杠焵筻槓戆皋羔高皐髙槔睾膏槹橰篙糕餻櫜韟鷎鼛鷱夰杲菒稁搞缟槁獔稿镐縞藁檺吿告勂诰郜峼祮祰锆筶禞誥鋯戈圪纥戓疙牱哥胳袼鸽割搁彁歌滒戨閤鴐鴚擱謌鴿鎶呄佮匌阁革敋格鬲愅臵葛隔嗝塥滆觡搿槅膈閣镉韐骼諽鮯櫊韚轕鞷騔鰪哿舸个各虼個硌铬箇獦给根跟哏亘艮茛揯搄更刯庚畊浭耕掶菮椩焿絚赓鹒緪縆賡羹鶊郠哽埂峺挭绠耿莄梗綆鲠骾鯁亙堩啹喼嗰工弓公功攻杛供糼肱宫宮恭蚣躬龚匑塨幊觥躳匔碽髸觵龔巩汞拱拲栱珙輁鞏共贡貢慐熕兝兣勾佝沟钩袧缑鈎緱褠篝簼鞲韝岣狗苟枸玽耇耉笱耈豿坸构诟购垢姤茩冓够夠訽媾彀搆遘雊煹觏撀覯購估咕姑孤沽泒柧轱唂唃罛鸪笟菇菰蛄蓇觚軱軲辜酤毂箍箛嫴篐橭鮕鴣轂鹘古汩诂谷股峠牯骨罟羖逧钴傦啒脵蛊蛌尳愲硲詁馉榾鼓鼔嘏榖皷穀糓薣濲臌餶瀔盬瞽固故凅顾堌崓崮梏牿棝祻雇痼稒锢頋僱錮鲴鯝顧瓜刮苽胍鸹歄焻煱颪劀緺銽鴰騧冎叧呱剐剮啩寡卦坬诖挂掛罣罫褂詿乖拐枴柺箉怪恠关观官冠覌倌棺蒄窤瘝癏観鳏觀鱞馆痯筦管輨舘錧館躀鳤毌贯泴悺惯掼涫悹祼慣摜遦樌盥罆鏆灌爟瓘礶鹳罐鑵鱹光灮侊炗炚炛咣垙姯茪桄烡珖胱僙輄銧黆欟广広犷俇逛撗归圭妫龟规邽皈茥闺帰珪亀硅袿媯椝瑰郌摫閨鲑嬀槻槼璝瞡鬶瓌櫷宄轨庋佹匦诡陒垝癸軌鬼庪祪匭晷湀蛫觤詭厬簋蟡刽刿攰柜炅攱贵桂椢筀貴蓕跪瞆劊劌撌槶禬簂櫃鳜鱥衮惃绲袞辊滚蓘滾蔉磙輥鲧鮌鯀棍棞睴璭謴呙埚郭啯崞聒鈛锅墎瘑嘓彉蝈鍋彍囯囶囻国圀國帼掴幗慖摑漍聝蔮虢馘果惈淉猓菓馃椁褁槨綶蜾裹餜鐹过桧咯莞呷",
                "H餲淲豩豰俿腄墮吪魤犿浲侅郂絯忓攼仠桿汵榦臯鎬暠犵挌蛤厷愩唝羾詬鶻淈鹄鈷縎鵠怘趏潅雚洸襘鞼緄腘膕粿輠過铪丷哈嗨孩骸海胲烸塰酼醢亥骇害氦嗐餀駭駴嚡饚乤兯佄顸哻蚶酣頇谽憨馠魽鼾邗含邯函凾虷唅圅娢浛崡晗梒涵焓寒嵅韩甝筨爳蜬澏鋡韓厈罕浫喊蔊豃鬫汉屽扞汗闬旱垾悍捍晘涆猂莟晥焊琀菡釬閈皔睅傼蛿颔撖蜭暵銲鋎憾撼翰螒頷顄駻雗瀚鶾魧苀斻杭垳绗笐航蚢颃貥筕絎頏沆蒿嚆薅竓蚝毫椃嗥獆噑豪嘷獋儫曍嚎壕濠籇蠔譹好郝号昊昦哠恏浩耗晧淏傐皓聕號暤暭澔皜皞皡薃皥颢灏顥鰝灝兞诃呵喝訶嗬蠚禾合何劾咊和姀河峆曷柇盇籺阂哬敆核盉盍荷啝涸渮盒秴菏萂龁惒粭訸颌楁詥鉌阖鲄熆閡鹖麧澕篕翮魺闔齕覈鶡皬鑉龢佫垎贺寉焃湼賀煂碋褐赫鹤翯壑癋爀鶴齃靍靎鸖靏黒黑嘿潶嬒拫痕鞎佷很狠詪恨亨哼悙涥脝姮恆恒桁烆珩胻鸻横橫衡鴴鵆蘅鑅堼囍乊乥叿灴轰哄訇烘軣焢硡薨輷嚝鍧轟仜弘妅红吰宏汯玒纮闳宖泓玜苰垬娂洪竑荭虹浤紘翃耾硔紭谹鸿渱竤粠葒葓鈜閎綋翝谼潂鉷鞃魟篊鋐彋蕻霐黉霟鴻黌晎嗊讧訌撔澋澒銾侯矦喉帿猴葔瘊睺篌糇翭骺鍭餱鯸吼犼后郈厚垕後洉逅候鄇堠豞鲎鲘鮜鱟乎匢虍呼垀忽昒曶泘苸烀轷匫唿惚淴虖軤雽嘑寣滹雐歑囫抇弧狐瓳胡壶壷斛焀喖壺媩湖猢絗葫楜煳瑚嘝蔛鹕槲箶糊蝴衚魱縠螜醐頶觳鍸餬瀫鬍鰗鶘鶦鶮乕汻虎浒唬萀琥虝箎錿鯱互弖戶户戸冱冴帍护沍沪岵怙戽昈枑祜笏粐婟扈瓠綔鄠嫭嫮摢滬蔰槴熩鳸簄鍙鹱護鳠韄頀鱯鸌花芲埖婲椛硴糀誮錵蘤华哗姡骅铧滑猾嘩撶璍螖鏵驊鷨化划杹画话崋桦婳畫嬅畵話劃摦槬樺嫿澅諙諣黊繣蘳怀徊淮槐褢踝懐褱懷櫰耲蘹坏壊壞蘾欢歓鴅嚾懽獾歡貛讙驩还环峘洹荁桓萈萑堚寏絙雈羦貆锾阛寰缳環豲鍰鹮糫繯轘闤鬟睆缓緩攌幻奂肒奐宦唤换浣涣烉患梙焕逭喚嵈愌換渙痪煥瑍豢漶瘓槵鲩擐澣瞣藧鯇鯶鰀巟肓荒衁塃慌皇偟凰隍黃黄喤堭媓崲徨惶湟葟遑楻煌瑝墴潢獚锽熿璜篁艎蝗癀磺穔諻簧蟥鍠餭鳇趪鐄騜鰉鱑鷬怳恍炾宺晃晄奛谎幌愰詤縨謊櫎皩兤滉榥曂皝鎤灰灳诙咴恢拻挥洃虺晖烣珲豗婎媈揮翚辉隓暉楎琿禈詼幑睳噅噕翬輝麾徽隳瀈鰴囘回囬佪廻廽恛洄茴迴烠逥痐蛔蛕蜖鮰悔螝毇檓燬譭卉屷汇会讳泋哕浍绘芔荟诲恚恵烩贿彗晦秽喙惠絵缋翙阓匯彙彚毀毁滙詯賄僡嘒蔧誨圚寭慧憓暳槥潓蕙徻橞獩璤薈薉諱頮檅檜燴篲藱餯嚖懳瞺穢繢蟪櫘繪翽譓闠鐬靧譿顪昏昬荤婚涽阍惽棔睧睯閽忶浑馄渾魂繉鼲诨俒倱圂掍混焝溷慁觨諢吙耠锪劐鍃豁攉騞佸活秮火伙邩钬鈥夥沎或货咟俰捇眓获剨祸貨惑旤湱禍嗀奯濩獲霍檴謋穫镬嚯瀖耯藿蠖嚿曤臛癨矐鑊夻行砉圜",
                "I",
                "J皀髉畟筴簎笒覘樔伡俥鋤雛處諔堲蠀覿茤岋紇裓構颳夬叏獷臩臦昋鱖妎悎饸紅鵍丌讥击刉叽饥乩刏圾机玑肌芨矶鸡枅咭迹剞唧姬屐积笄飢基绩喞嵆嵇犄筓缉赍勣嗘畸跻鳮僟箕銈嘰撃槣樭畿稽賫躸齑墼憿機激璣積錤隮磯簊績羁賷櫅耭雞譏韲鶏譤癪躋鞿鷄齎羇虀鑇覉鑙齏羈鸄覊亼及伋吉岌彶忣汲级即极亟佶郆卽叝姞急狤皍笈級揤疾觙偮卙庴脨谻戢棘極殛湒集塉嫉愱楫蒺蝍趌辑槉耤膌銡嶯潗瘠箿蕀蕺鞊鹡橶檝螏輯襋蹐鍓艥籍轚鏶霵鶺鷑雦雧几己丮妀犱泲虮挤脊掎鱾幾戟嵴麂魢撠擠穖彑旡计记伎纪坖妓忌技芰芶际剂季哜垍峜既洎济紀茍計剤紒继觊記偈寂寄徛悸旣梞祭惎臮葪兾痵継蓟裚跡際墍暨漃漈禝稩穊誋跽霁鲚暩稷諅鲫冀劑曁穄薊襀髻檕繋罽覬鮆檵蹟鵋齌廭懻癠糭蘎骥鯚瀱繼蘮鱀蘻霽鰶鰿鱭驥加夹抸佳泇迦枷毠浃珈家痂梜笳耞袈猳葭跏犌腵鉫嘉镓糘豭貑鎵麚圿扴岬郏荚郟恝莢戛铗戞蛱颊蛺跲餄鋏頬頰鴶鵊甲玾胛斚贾钾婽斝椵賈鉀榎槚瘕檟价驾架假嫁幏榢稼駕嗧戋奸尖幵坚歼间冿戔肩艰姦姧兼监堅惤猏笺菅菺湔牋犍缄葌葏間搛椷煎瑊睷缣蒹箋樫熞緘蕑蕳鲣鹣熸篯縑鋻艱鞬馢麉瀐鞯殱礛覸鵳瀸殲籛韀鰹囏虃韉囝拣枧俭柬茧倹挸捡笕减剪检湕趼揀検減睑硷裥詃锏弿瑐简絸谫彅戩戬碱儉翦檢藆襇襉謇蹇瞼簡繭謭鬋鰎鹸瀽蠒鐗鐧鹻譾襺鹼见件侟建饯剑洊牮荐贱俴健剣涧珔舰剱徤渐谏釼寋旔楗毽溅腱臶践賎鉴键僭榗劍劎墹澗箭糋諓賤趝踐踺劒劔橺薦鍵餞瞷磵礀螹鍳擶繝覵艦轞鑑鑒鑬鑳江姜将茳浆畕豇葁翞僵漿螀壃缰薑橿殭螿鳉疅礓疆繮韁鱂讲奖桨傋蒋奨奬蔣槳獎耩膙講顜匞匠夅弜杢降洚绛弶袶絳畺酱摾滰嵹犟糡醤糨醬櫤謽艽芁交郊姣娇峧浇茭骄胶椒焦蛟跤僬嘄虠鲛嬌嶕嶣憍膠蕉膲礁穚鮫鹪簥蟭鐎鷦鷮櫵臫角佼挢狡绞饺晈笅皎矫脚铰搅筊剿勦敫煍腳賋摷暞踋鉸餃儌劋撹徼敽敿缴曒璬矯皦鵤孂纐攪灚鱎叫呌挍訆珓轿较敎教窖滘嘂嘦斠漖酵噍嬓獥藠趭轎醮譥皭釂阶疖皆接掲痎秸階喈嗟堦媘揭脻街煯稭鞂蝔擑癤鶛孑尐节讦刦刧劫岊昅刼劼杰衱诘拮洁结迼桀桝莭訐婕崨捷袺傑結颉嵥楶滐睫節蜐詰鉣魝截榤碣竭蓵鲒潔羯誱踕幯嶻擮礍鍻巀櫭蠞蠘蠽姐毑媎解飷檞丯介岕庎忦戒芥屆届斺玠界畍疥砎衸诫借蚧徣堺楐琾蛶骱犗誡褯魪藉巾今斤钅兓金釒津矜砛衿觔珒紟惍琎堻琻筋璡鹶黅襟仅卺巹紧堇菫僅谨锦嫤廑漌盡緊蓳馑槿瑾錦謹饉劤尽劲妗近进侭枃勁浕荩晉晋浸烬赆祲進煡缙寖搢溍禁靳瑨僸凚殣觐儘噤縉賮嚍壗嬧濜藎燼璶覲贐齽坕京泾经茎亰秔荆荊婛惊旌旍猄経菁晶稉腈睛粳經兢精聙橸鲸鵛鯨鶁麖鼱驚麠井丼阱刭宑汫汬肼剄穽颈景儆幜憬璄憼暻燝璟璥頸蟼警妌净弪径迳浄胫凈弳徑痉竞逕婙婧桱梷淨竟竫敬痙傹靖境獍誩静頚曔镜靜瀞鏡競竸冋坰扃埛絅駉駫蘏冏囧迥侰炯逈浻烱煚窘颎綗僒煛熲澃燛褧蘔丩勼纠朻究糺鸠糾赳阄萛啾揪揫鬏鬮九久乆乣奺汣杦灸玖舏韭紤酒镹韮匛旧臼咎疚柩柾倃桕厩救就廄匓舅僦廏廐慦殧舊鹫鯦麔匶齨鷲欍凥抅匊居拘泃狙苴驹倶挶疽痀罝陱娵婅婮崌掬梮涺椐琚腒锔裾雎艍蜛諊踘鋦駒鴡鞠鞫鶋局泦侷狊桔毩淗焗菊郹椈毱湨犑輂粷躹閰橘檋駶鵙蹫鵴巈蘜鶪驧咀沮举矩莒挙椇筥榉榘蒟龃聥舉踽擧櫸欅襷句巨讵姖岠怇拒洰苣邭具拠昛歫炬秬钜俱倨冣剧粔耟蚷袓埧埾惧据詎距焣犋鉅飓虡豦锯愳窭聚駏劇勮屦踞鮔壉懅據澽遽鋸屨颶簴躆醵懼爠姢娟捐涓裐鹃勬鋑镌鎸鵑鐫蠲卷呟帣埍菤锩臇錈奆劵倦勌桊狷绢隽淃瓹眷鄄睊絭罥睠慻蔨餋羂噘撅撧屩屫亅孒孓决刔氒诀抉芵玦玨挗珏砄绝虳觉倔欮崛掘斍桷殌覐觖訣赽趹厥絕絶覚趉鈌劂瑴谲嶡嶥憰熦爴獗瘚蕝蕨鴂鴃憠橛橜镼爵臄镢蟨蟩爑譎蹶蹷嚼矍覺鐝灍爝觼彏戄攫玃鷢欔矡龣貜钁军君均汮袀軍钧莙蚐桾皲菌鈞碅筠皸皹覠銁銞鲪麇鍕鮶呁俊郡陖埈峻捃晙浚馂骏珺畯竣箟蜠儁寯懏餕燇駿鵔鵕鵘纟挟廴",
                "K錒嵦濭骯奟喫噄鉺朏胐阬槀稾藳溝絓鰥卝丱硄廣胿膭歸楇鉿妔薧蚵毼袔齁恗搰華磆蕐會澮璯餛秳漷監譼槛檻捁撟悈脛踁駃咔咖喀卡佧垰胩裃鉲开奒揩衉锎鐦凯剀垲恺闿铠凱剴慨蒈塏愷楷輆暟锴鍇鎧闓颽忾炌欬烗勓嘅鎎乫刊栞勘龛堪戡龕冚坎侃砍莰偘惂塪輡竷轗看衎崁墈阚瞰磡矙忼砊粇康嫝嵻慷漮槺穅糠躿鏮鱇扛摃亢伉匟邟囥抗犺闶炕钪鈧閌尻髛攷考拷洘栲烤铐犒銬鲓靠鮳鯌匼坷苛柯牁珂科胢轲疴趷钶嵙棵痾萪軻颏搕犐稞窠鈳榼薖颗樖瞌磕蝌頦醘顆髁礚壳咳翗嶱可岢炣渇嵑敤渴克刻剋勀勊客峇恪娔尅课堁氪骒缂嗑愙溘锞碦緙課錁礊騍肎肯肻垦恳啃豤墾錹懇掯裉褃劥吭坑硁牼铿硻誙銵鍞鏗巪乬唟厼怾空倥埪崆悾硿箜躻錓鵼孔恐控鞚廤抠芤眍剾彄瞘口劶叩扣怐敂冦宼寇釦窛筘滱蔲蔻瞉簆鷇刳郀枯哭桍堀崫圐跍窟骷鮬狜苦楛库俈绔庫秙焅袴喾絝裤瘔酷褲嚳夸姱舿侉咵垮銙挎胯跨骻蒯擓巜凷圦块快侩郐哙狯脍塊筷鲙儈鄶廥獪膾旝糩鱠宽寛寬髋鑧髖梡款窽窾匡劻诓邼匩哐恇洭筐筺誆軭狂狅诳軖軠誑鵟夼儣懭邝圹纩况旷岲況矿昿贶框眖砿眶絋絖貺軦鉱鋛鄺壙黋懬曠爌矌礦穬纊鑛亏刲岿悝盔窥聧窺虧闚顝蘬奎晆逵鄈頄馗喹揆葵骙戣暌楏楑魁睽蝰頯櫆藈鍨鍷騤夔蘷虁躨卼傀煃跬頍蹞尯匮欳喟媿愦愧溃蒉馈匱嘳嬇憒篑聩聭蕢樻殨餽簣聵籄鐀鑎坤昆晜堃堒婫崐崑猑菎裈焜琨髠裩锟髡鹍尡潉蜫褌髨熴瑻醌錕鲲臗騉鯤鵾鶤悃捆阃壸梱祵硱稇裍壼稛綑閫閸困涃睏扩拡括挄栝桰筈萿葀蛞阔廓頢濶闊鞟韕懖霩鞹鬠穒",
                "L冫勑粚誺銐寵娕坔釘詻鄜膚鬴茖蛒鎘鉻羮篢睔腂蘫谾瘣暕撿諫倞靓靚牞摎樛畂寠窶垃拉柆啦翋菈邋旯砬揦磖喇藞嚹剌溂腊揧楋瘌蜡蝋辢辣蝲臈攋爉臘鬎櫴瓎镴鯻蠟鑞鞡来來俫倈崃徕涞莱郲婡崍庲徠梾淶猍萊逨棶琜筙铼箂錸騋鯠鶆麳唻赉睐睞赖賚濑賴頼顂癞鵣瀨瀬籁藾癩襰籟兰岚拦栏婪嵐葻阑蓝谰澜褴儖斓篮燣藍襕镧闌璼襤譋幱攔瀾灆籃繿蘭斕欄礷襴囒灡籣欗讕躝襽鑭钄韊览浨揽缆榄漤罱醂壈懒覧擥嬾懶孄覽孏攬欖爦纜烂滥燗嚂濫爁爛爤瓓灠糷啷勆郎郞欴狼莨嫏廊桹琅蓈榔瑯硠稂锒筤艆蜋郒螂躴鋃鎯駺悢朗阆朖烺塱蓢樃誏閬朤埌浪蒗唥捞粩撈劳労牢狫窂哰唠崂浶勞痨铹僗嶗憥朥癆磱簩蟧醪鐒顟髝老佬咾姥恅荖栳珯硓铑蛯銠潦橑鮱轑涝烙嗠耢酪嫪憦澇橯耮軂仂阞乐叻忇扐氻艻玏泐竻砳勒楽韷簕鳓鰳饹餎雷嫘缧蔂樏畾檑縲镭櫑瓃羸礧纍罍蘲鐳轠壨鑘靁虆鱩欙纝鼺厽耒诔垒塁絫傫誄磊蕌磥蕾儡壘癗藟櫐矋礨灅蠝蘽讄儽鑸鸓肋泪洡类涙淚累酹銇頛頪擂錑攂礌颣類纇蘱禷嘞脷塄棱楞碐稜踜薐冷倰堎愣睖唎刕厘剓梨狸离荲莉骊悡梸犁菞喱棃犂鹂剺漓睝筣缡艃蓠蜊嫠孷樆璃盠竰糎蔾褵鋫鲡黎篱縭罹錅蟍謧醨嚟藜邌離鯏鏫鯬鵹黧囄灕蘺蠡蠫孋廲劙鑗穲籬驪鱺鸝礼李里俚峛哩娌峲浬逦理裡锂粴裏豊鋰鲤澧禮鯉蟸醴鳢邐鱧欚力历厉屴立吏朸丽利励呖坜沥苈例岦戾枥疠苙隶俐俪栃栎疬砅茘荔赲轹郦娳悧栗栛栵涖猁珕砺砾秝莅唳婯悷琍笠粒粝蚸蛎傈凓厤棙痢蛠詈跞雳塛慄搮溧蒚蒞鉝鳨厯厲暦歴瑮綟蜧勵曆歷篥隷鴗巁檪濿癘磿隸鬁儮曞櫔爄犡禲蠇嚦壢攊瀝瓅礪藶櫪爏瓑皪盭礫糲蠣儷癧礰鷅麜囇轢欐讈轣攭瓥靂鱱靋瓈俩倆嫾奁连帘怜涟莲連梿联裢亷嗹廉慩漣蓮匲奩覝劆匳噒憐磏聨聫褳鲢濂濓縺翴聮薕螊櫣聯臁蹥謰鎌镰簾蠊鬑鐮鰱籢籨敛琏脸裣摙槤璉蔹嬚斂歛臉鄻襝羷练娈炼恋浰殓堜媡湅萰链僆楝煉瑓潋練澰錬殮鍊鏈瀲鰊戀纞簗良俍凉梁涼椋辌粮粱墚綡踉樑輬糧両两兩唡啢掚脼裲緉蜽魉魎亮哴谅辆喨晾湸量煷輌諒輛鍄蹽辽疗聊僚寥嵺廖憀膋嘹嫽寮嶚嶛憭撩敹獠缭遼暸燎璙窷膫竂镣鹩屪廫簝蟟豂賿蹘爎鐐髎飉鷯钌釕鄝蓼爒镽了尥炓料尞撂瞭咧毟挘埓列劣冽劽姴峢挒洌茢迾埒浖烈烮捩猎猟蛚裂煭睙聗趔巤颲儠鮤鴷擸獵犣躐鬛鬣鱲邻林临啉崊惏淋晽琳粦痳碄箖粼鄰隣嶙潾獜遴斴暽燐璘辚霖瞵磷臨繗翷麐轔壣瀶鏻鳞驎麟鱗菻亃稟僯凛凜撛廩廪懍懔澟檁檩癛癝顲吝恡悋赁焛賃蔺橉甐膦閵疄藺蹸躏躙躪轥拎伶刢灵囹坽夌姈岭岺彾泠狑苓昤朎柃玲瓴凌皊砱秢竛铃陵鸰婈崚掕棂淩琌笭紷绫羚翎聆舲菱蛉衑祾詅跉軨蓤裬鈴閝零龄綾蔆輘霊駖澪蕶錂霗魿鲮鴒鹷燯霛霝齢瀮酃鯪孁蘦齡櫺醽靈欞爧麢龗阾袊领領嶺令另呤炩溜熘刘沠畄浏流留旈琉畱硫裗媹嵧旒蒥蓅遛馏骝榴瑠飗劉瑬瘤磂镏駠鹠橊璢疁镠癅蟉駵嚠懰瀏藰鎏鎦餾麍鏐飀鐂騮飅鰡鶹驑柳栁桞珋桺绺锍綹熮罶鋶橮羀嬼六翏塯廇澑磟鹨蹓霤雡飂鬸鷚瓼甅囖龙屸咙泷茏昽栊珑胧眬砻笼聋隆湰嶐槞漋癃窿篭嚨巃巄蘢鏧霳曨朧櫳爖瓏矓礱礲襱籠聾蠪蠬龓豅躘鑨靇鸗陇垄垅拢儱隴壟壠攏竉哢梇硦徿贚娄偻婁喽溇蒌僂楼嘍廔慺蔞遱樓熡耧蝼瞜耬艛螻謱軁髅鞻髏嵝搂塿嶁摟漊甊篓簍陋屚漏瘘镂瘺瘻鏤露噜撸嚕擼卢庐芦垆枦泸炉栌胪轳舮鸬玈舻颅鈩鲈魲盧嚧壚廬攎瀘獹璷蘆櫨爐瓐臚矑籚纑罏艫蠦轤鑪顱髗鱸鸕黸卤虏挔捛掳鹵硵鲁虜塷滷蓾樐澛魯擄橹磠镥瀂櫓氌艣鏀艪鐪鑥圥甪陆侓坴彔录峍勎赂辂陸娽淕淥渌硉菉逯鹿椂琭祿禄僇剹勠滤盝睩碌稑賂路塶廘摝漉箓粶蔍戮樚熝膔膟觮趢踛辘醁潞穋蕗錄録錴璐簏螰鴼濾簶蹗轆騄鹭簬簵鏕鯥鵦鵱麓鏴騼籙觻虂鷺氇驴闾榈閭馿膢櫚藘曥鷜驢吕呂侣郘侶旅梠焒祣稆铝屡絽缕屢膂膐褛鋁履褸儢穞縷穭寽垏律哷虑率绿嵂氯葎綠緑慮箻勴繂櫖爈鑢孪峦挛栾鸾脔滦銮鵉圝奱孌孿巒攣曫欒灓羉臠圞灤虊鑾癴癵鸞卵乱釠亂掠略畧锊圙鋝鋢抡掄仑伦囵沦纶侖轮倫陯圇婨崘崙惀淪菕棆腀碖綸蜦踚輪磮錀鯩稐耣论埨溣論捋頱囉罗啰猡脶萝逻椤腡锣箩骡镙螺羅覶鏍儸覼騾玀蘿邏欏鸁籮鑼饠驘剆倮砢蓏裸躶瘰蠃臝攞曪癳泺峈洛络荦骆珞笿絡落摞漯犖雒駱鮥鵅纙鱳",
                "M絔硥苾牑訬仯哋尒尓爾坆呒撫羙秏狢貈貉湏惛殙貇氂犛厸龍龒嘸呣妈媽嬤嬷麻痲嫲蔴犘蟆蟇马犸玛码蚂馬溤獁遤瑪碼螞鎷鷌鰢亇杩祃閁骂唛傌睰嘜榪禡罵駡礣鬕吗嗎嘛埋霾买荬買嘪蕒鷶劢迈佅売麦卖脉脈麥衇勱賣邁霡霢颟顢姏悗蛮慲摱馒樠瞒瞞鞔饅鳗鬗鬘鰻蠻屘満睌满滿螨襔蟎鏋矕曼僈谩墁幔慢漫獌缦蔄蔓熳澷镘縵蟃謾鏝蘰牤邙吂忙汒芒杗杧盲厖恾笀茫哤娏浝牻硭釯铓痝蛖鋩駹蘉莽莾茻壾漭蟒蠎匁猫貓毛矛枆牦茅旄渵軞酕蛑锚緢髦蝥錨蟊鶜冇卯戼峁泖茆昴铆笷蓩鉚冃皃芼冐茂冒眊贸耄袤覒媢帽貿鄚愗暓楙毷瑁瞀貌鄮蝐懋唜庅嚒濹嚰么癦沒没枚玫苺栂眉脄莓梅珻脢郿堳媒嵋湄湈猸睂葿楣楳煤瑂禖腜塺槑酶镅鹛鋂霉徾鎇矀攗蘪鶥攟黴毎每凂美挴浼媄嵄渼媺镁嬍燘躾鎂黣妹抺沬昧祙袂眛媚寐痗跊鬽煝睸魅篃蝞嚜椚门扪玣钔門閅捫菛璊穈鍆虋闷焖悶暪燜懑懣们們掹擝氓甿虻冡庬罞萌萠夢溕盟甍儚橗瞢蕄蝱鄳鄸幪懞濛獴曚朦檬氋矇礞鯍艨鹲矒靀饛顭鸏勐猛瓾蒙锰艋蜢錳懵蠓鯭鼆孟梦夣懜霥踎咪瞇冞弥祢迷猕谜蒾詸謎醚擟糜縻麊麋靡獼麛爢戂攠蘼醾醿鸍釄米羋芈侎弭洣敉粎脒眯渳葞蝆蔝銤孊灖糸汨宓泌觅峚祕宻秘密淧覓覔幂谧塓幎覛嘧榓滵漞熐蔤蜜鼏冪樒幦濗藌謐櫁簚羃芇眠婂绵媔棉綿緜臱蝒嬵檰櫋矈矊矏丏汅免沔黾俛勉眄娩偭冕勔喕愐湎缅葂腼緬鮸靣面糆麪麫麺麵喵苗媌描瞄鹋嫹鶓鱙杪眇秒淼渺缈篎緲藐邈妙庙竗庿廟吀咩哶孭灭搣滅蔑薎鴓幭懱瀎篾櫗蠛衊鑖鱴瓱民垊姄岷怋旻旼玟苠珉盿冧罠崏捪琘琝缗暋瑉痻碈鈱緍緡錉鍲皿冺刡闵抿泯勄敃闽悯敏笢笽湣閔愍敯黽閩僶慜憫潣簢鳘蠠鰵名明鸣洺眀茗冥朙眳铭鄍嫇溟猽蓂暝榠銘鳴瞑螟覭佲姳凕慏酩命掵詺谬缪繆謬摸嚤尛谟嫫馍摹模膜麼麽摩魹橅磨糢謨謩擵饃嚩蘑髍魔劘饝抹懡麿末劰圽妺怽歿殁沫茉陌帞昩枺皌眜眿砞秣莈莫眽粖絈袹蛨貃嗼塻寞漠蓦貊銆墨嫼暯瘼瞐瞙镆魩黙縸默貘藦蟔鏌爅驀礳纆耱乮哞牟侔劺恈洠眸谋鉾謀鍪鴾麰某母毪獏氁亩牡姆拇峔牳畆畒胟畝畞砪畮鉧踇木仫目凩沐狇坶炑牧苜毣莯蚞钼募萺雮墓幕幙慔楘睦鉬慕暮艒霂穆鞪旀丆椧渑",
                "N懝抝拗秅莀袲唸毭咹児兒耏聏峊廾嫨跈聻茮澆涳巙崀尦竜袮彌镾濔瀰乜樢拏拿誽镎鎿乸哪雫内那吶妠纳肭娜衲钠納袦捺笝豽軜貀嗱蒳靹魶腉熋孻乃奶艿氖疓妳廼迺倷釢嬭奈柰耐萘渿鼐褦螚錼囡男抩枏枬侽南娚畘莮难喃遖暔楠煵諵難赧揇湳萳腩蝻戁婻囔乪嚢囊鬞馕欜饢擃曩攮灢儾齉孬檂呶怓挠峱硇铙猱蛲詉碙嶩夒鐃巎獿垴恼悩脑匘脳堖惱嫐瑙腦碯闹婥淖閙鬧讷呐眲訥呢馁腇餒鮾鯘氝焾嫩能莻鈪銰啱妮尼坭怩泥籾倪屔秜郳铌埿婗淣猊蚭棿跜鈮蜺觬貎霓鲵鯢麑齯臡伱伲你拟抳狔苨柅旎晲馜儞隬擬薿檷鑈氼迡昵胒逆匿痆眤堄惄嫟愵溺睨腻暱縌膩嬺拈年秊哖秥鲇鮎鲶鵇黏鯰捻辇撚撵碾輦簐攆躎卄廿念姩埝娘嬢酿醸釀鸟茑袅嫋裊蔦嬝褭嬲尿脲捏揑帇圼苶枿陧涅聂臬啮惗隉敜嗫嵲踂摰踗踙镊镍嶭篞臲錜颞蹑鎳闑孼孽櫱籋蘖齧巕糱糵蠥囓讘躡鑷顳脌囜您拰宁咛拧狞柠聍寍寕寜寧儜凝嚀嬣擰獰薴檸聹鑏鬡鸋橣矃佞侫泞甯寗澝濘妞牛牜忸扭沑狃纽杻炄钮紐鈕靵农侬哝浓脓秾農儂辳噥憹濃蕽禯膿穠襛醲欁繷弄挊挵癑齈羺譨啂槈耨鎒鐞譳奴孥驽笯駑伮努弩砮胬怒傉搙女钕籹釹衂恧朒衄疟虐瘧奻渜暖煗餪硸黁燶郍挪梛傩搻儺橠诺喏掿逽搦锘榒稬諾糑懦懧糥穤糯恁蔫",
                "O吽摳噢哦筽夞乯鞰讴欧殴瓯鸥塸歐熰甌膒鴎櫙藲鏂鷗吘呕偶腢耦蕅藕怄沤慪漚",
                "P钯鈀跁罷猈螌褩闆湴牓棓徬鎊剝襃铇袌鉋鮑琲絣痭琣逬跰螕鎞粃枈痺辟稫箆鞞猵萹拚徧緶辯骉蔈颮麃藨謤穮驃驫摽汃砏璸鉼碆磻犻苩瓟桲淿湐猼馞嚗髆蚾獛鵏吥荹鈈郶茷籓膰趽彷衯夆馮摓垺妚尃豧巿襆襥脯蜅秿鈲窌攈脟濼尨眫冖覕屰妑皅趴舥啪葩杷爬耙琶筢潖帊帕怕袙拍俳徘排猅棑牌箄輫簰犤哌派湃蒎鎃磗眅畨潘攀爿柈盘跘媻幋蒰搫槃磐縏蹒瀊蟠蹣鎜鞶坢冸判沜泮炍叛牉盼畔袢詊溿頖鋬鵥襻鑻乓汸沗肨胮雱滂膖霶厐庞逄旁舽嫎篣螃鳑龎龐鰟蠭嗙耪覫髈炐胖抛拋脬刨咆垉庖狍炮炰爮袍匏蚫軳鞄褜麅跑奅泡疱皰砲萢麭礟礮呸怌肧柸胚衃醅阫陪陫培毰赔锫裴裵賠錇俖伂沛佩帔姵斾旆浿珮配笩蓜辔馷嶏霈轡喷噴濆歕瓫盆湓葐呠翉翸喯匉怦抨泙恲胓砰梈烹硑軯閛漰嘭駍磞芃朋挷竼倗莑堋弸彭棚椖傰塜塳搒漨硼稝蓬鹏槰樥熢憉澎輣篷膨錋韸髼蟚蟛鬅纄韼鵬騯鬔鑝捧淎皏剻掽椪碰踫浌巼闏乶喸丕伓伾批纰邳坯怶披抷炋狉狓砒悂秛秠紕铍旇翍耚豾鈚鈹鉟銔劈磇駓髬噼錃錍魾憵礔礕闢霹皮阰芘岯枇毞肶毗毘疲笓蚍郫陴啤埤崥蚽豼椑焷琵脾腗榌鲏罴膍蜱隦魮壀鮍篺螷貔簲羆鵧朇鼙蠯匹庀仳圮苉脴痞銢諀鴄擗噽癖嚭屁淠渒揊媲嫓睤睥潎僻澼甓疈譬鷿鸊片囨偏媥犏篇翩鶣骈胼腁楄楩賆諚骿蹁駢騈覑谝貵諞骗魸騗騙剽彯漂缥飘磦旚縹翲螵犥飃飄魒瓢薸闝殍瞟篻醥皫顠票僄勡嘌嫖徱慓氕撇撆暼瞥丿苤鐅嫳姘拼礗穦馪驞玭贫貧琕嫔频頻嬪薲嚬矉颦顰品榀朩牝汖娉聘乒甹俜涄砯艵竮頩平评凭呯坪岼苹郱屏帡枰洴玶荓娦瓶屛帲淜萍蚲塀幈焩甁缾聠蓱蛢評軿鲆凴慿箳輧憑鮃檘簈蘋钋坡岥泼娝釙颇溌酦潑醱鏺婆嘙蔢鄱皤謈櫇叵尀钷笸鉕駊廹岶迫敀昢洦珀哱烞破砶粕蒪頗魄剖颒抔抙捊掊裒箁咅哣婄犃兺哛仆攴扑抪炇巬巭柨陠痡铺駇噗撲鋪擈鯆圤匍莆菩菐葡蒱蒲僕酺墣璞濮瞨穙镤贌纀鏷朴圃埔浦烳普圑溥暜谱潽樸氆諩檏镨譜蹼鐠舖舗曝",
                "Q摮磝朁鸧鶬鼜詧軙儭櫬趍袳創敠匚釓隑矼肐鉤扢琯矔鸛龜氿肣馯抲頜礉隺渹舙酄攲敧稘毄緝觭禨鄿鐖饑焏踖躤蟣済萕濟袷唊脥價靬鳒鰜鶼鑯揃葥漸摪彊勥焳燋湫湬蟜譑峤嶠潐噭椄疌倢偼媫蛣楬鮚荕埐嶜厪墐慬歏濅涇鶄捄趄跔鮈跼趜弆瞿鐻捲弮蚗傕鶌躩麏麕焌箘開欿歁殻揢挳硜矻誇厱熑燫艌鳥毆七迉沏妻柒倛凄栖桤缼郪娸悽戚捿桼淒萋朞期欺紪褄僛嘁慽榿槭漆緀慼磎諆霋蹊魌鏚鶈亓祁齐圻岐岓芪其奇斉歧祈肵疧竒剘斊旂耆脐蚑蚚颀埼崎帺掑淇渏猉畦萁跂軝釮骐骑棊棋琦琪祺蛴愭碁碕褀頎鬾鬿旗粸綥綦綨緕蜝蜞璂禥蕲踑螧鲯懠濝藄檱櫀簱臍騎騏鳍蘄鯕鵸鶀麒籏纃艩蠐鬐騹魕鰭玂麡乞邔企屺岂芑启呇杞玘盀唘豈起啓啔啟婍绮晵棨綮諬簯闙气讫気汔迄弃汽矵芞呮泣炁盵咠契砌荠栔訖唭欫夡愒棄湆湇葺碛摖暣甈碶噐憇器憩磜磧薺礘罊蟿掐葜拤跒酠鞐圶冾帢恰洽殎硈愘髂千仟阡奷扦汘芊迁佥岍杄汧茾竏钎拪牵粁悭蚈谸铅婜牽釺谦雃僉愆签骞鹐搴摼撁箞諐遷褰顅檶攐攑櫏簽鏲鵮攓騫鐱鬜鬝籤韆仱岒忴扲拑乹前钤歬虔钱钳乾偂掮揵軡媊鈐鉗墘榩箝銭潜橬錢黔鎆黚騝濳騚灊籖鰬浅肷淺嵰慊遣蜸潛谴缱繾譴鑓欠刋芡茜倩悓堑傔嵌棈椠皘蒨塹歉蔳儙槧篏輤篟壍嬱縴呛羌戕戗斨枪玱猐琷跄嗴椌獇腔嗆溬蜣锖嶈戧槍牄瑲羫锵篬錆蹌镪蹡鎗鏘鏹強强墙嫱蔷樯漒蔃墻嬙檣牆謒艢蘠抢羟搶羥墏摤繈襁繦炝唴熗羻兛瓩悄硗郻鄗嵪跷鄡鄥劁敲踍锹墝碻頝墽幧橇缲磽鍫鍬繑趬蹺蹻乔侨荍荞桥硚喬僑槗谯嘺嫶憔蕎鞒樵橋犞癄瞧礄藮譙趫鐈鞽顦巧釥愀髜俏诮陗峭帩窍殼翘誚髚僺撬鞘竅翹躈切苆癿茄聺且厒妾怯匧窃倿悏挈洯惬淁笡愜蛪朅箧緁锲魥篋踥穕藒鍥鯜鐑竊籡亲侵钦衾骎菳媇嵚誛嶔親顉駸鮼寴庈芩芹埁珡矝秦耹菦蚙捦琴琹禽鈙雂勤嗪溱靲噙擒斳鳹懄檎澿瘽螓懃蠄坅昑笉梫赾寑锓寝寢鋟螼吢吣抋沁唚菣揿搇撳瀙藽靑青氢轻倾卿郬圊氫淸清傾廎蜻輕鲭鑋夝甠剠勍情殑硘晴棾氰葝暒擏樈擎檠黥苘顷请庼頃漀請檾謦庆凊掅碃箐靘慶磬儬濪罄櫦宆跫銎卭邛穷穹茕桏笻筇赹惸焪焭琼舼蛩蛬煢熍睘瞏窮儝憌橩璚藑竆藭丘丠邱坵恘秋秌寈蚯媝萩楸鹙篍緧蝵穐趥鳅蟗鞦鞧蘒鰌鰍鶖龝叴囚扏犰玌朹肍求虬泅虯俅觓訄訅酋唒浗紌莍逎逑釚梂殏毬球赇釻崷巯湭皳盚遒煪絿蛷裘巰觩賕璆蝤銶醔鮂鼽鯄鵭蠤鰽搝糗区曲佉匤岖诎阹驱坥屈岴抾浀祛胠袪區蛆躯筁粬蛐詘趋嶇駆憈敺誳駈麹髷趨麯軀麴黢驅鰸鱋佢劬斪朐菃衐鸲淭渠絇葋軥蕖璖磲螶鴝璩翵蟝鼩蘧匷忂灈戵欋氍籧臞癯蠷衢躣蠼鑺鸜取竘娶紶詓竬龋齲厺去刞呿迲郥耝阒觑趣閴麮闃覰覷鼁覻峑悛圈圏棬駩騡鐉全权佺诠姾泉洤荃拳牷辁啳埢婘惓痊硂铨湶犈筌絟腃葲搼楾瑔觠詮輇蜷銓権踡縓醛闎鳈鬈孉巏鰁權齤蠸颧顴犬汱畎烇绻綣虇劝券巻牶椦勧韏勸炔缺蒛瘸却埆崅悫雀硞确阕塙搉皵阙鹊愨榷墧慤毃確趞燩闋礐闕鵲礭夋囷峮逡宭帬裙羣群裠郄",
                "R吺兊兌熯卪坈繚髳挐鈉柟蟯臑抐內涊蹨孃菍莥獳檽蹃亽罖囕呥肰衻袇蚦袡蚺然髥嘫髯燃繎冄冉姌苒染珃媣蒅穣瀼獽禳瓤穰躟鬤壌嚷壤攘爙让懹譲讓荛饶桡橈襓饒犪扰娆隢擾绕遶繞惹热熱人仁壬忈朲忎秂芢鈓魜銋鵀忍荏栠栣荵秹稔綛躵刃刄认仞仭讱任屻扨纫妊杒牣纴肕轫韧饪姙紉衽紝訒軔梕袵絍腍靭靱韌飪認餁扔仍辸礽芿陾日驲囸釰鈤馹戎肜栄狨绒茙茸荣容峵毧烿媶嵘絨羢嫆搈搑摉榵溶蓉榕榮熔瑢穁蝾褣镕氄縙融螎駥髶嬫嶸爃鎔瀜曧蠑冗宂傇軵穃厹禸柔粈媃揉渘葇瑈腬糅蝚蹂輮鍒鞣瓇騥鰇鶔楺煣韖肉宍嶿邚如侞帤茹桇袽铷渪筎蒘銣蕠儒鴑嚅嬬孺濡薷鴽曘燸襦蠕颥醹顬鱬汝肗乳辱鄏入扖込杁洳嗕媷溽缛蓐鳰褥縟擩堧撋壖阮朊软耎偄軟媆愞瑌腝嫰碝緛蝡輭瓀礝桵甤緌蕤蕊蕋橤繠蘂蘃芮枘蚋锐瑞睿叡壡闰润閏閠潤橍叒若偌弱鄀婼渃焫楉嵶蒻箬篛爇鰙鰯鶸",
                "S鉍灬杓攃偲纔參叄叅喰傪穇懆鄵拺笧粣鎈褨剎摻攙摌顫塲場綝乗娍匙飭埫醻敊猭漺輴縒棇楤漎憁缞縗鎝単單擔伔僤宲鍉遞遰挕阇闍陏蘴棴丨鞨咶鏸韢閄靃濈櫼帴菨嫅潏麗攦療蕯瀧氀稤蠰娞淰掱忯圱圲凵廧薔鐰韒鞩嫀殸棯葚挼仨桬撒洒訯靸潵卅飒脎萨摋隡馺颯薩櫒栍毢愢揌塞毸腮嘥噻鳃顋嗮赛僿賽簺虄三弎叁毵毶厁毿犙鬖壭伞傘散糁糂馓橵糝糣糤繖鏒饊俕閐桒桑槡嗓搡磉褬颡鎟顙丧喪掻慅搔溞骚缫臊鳋颾騒鰠鱢扫掃嫂埽瘙氉矂髞色栜涩啬渋铯歮琗嗇瑟歰銫澁懎擌濇濏瘷穑澀璱瀒穡繬穯轖鏼譅飋裇聓森槮襂僧鬙閪縇杀沙纱乷砂唦挱猀粆紗莎铩痧硰蔱裟樧魦鲨閷鎩鯊鯋繺傻儍繌倽唼啥帹萐喢歃煞翜翣閯霎筛篩簁簛晒曬山彡邖圸删刪杉杣芟姗衫钐埏狦珊舢痁脠軕笘閊跚剼搧嘇幓煽蔪潸澘曑檆膻鯅羴羶闪陕炶陝閃晱煔睒熌覢讪汕疝苫扇訕赸傓善椫銏骟僐鄯墠墡缮嬗擅敾樿膳磰謆赡繕蟮譱贍鐥饍騸鳝灗鱔伤殇商觞傷墒慯滳蔏殤熵螪觴謪鬺裳垧扄晌赏賞鑜丄上仩尙尚恦绱緔弰捎梢烧焼稍旓筲艄蛸輎蕱燒髾鮹勺芍柖玿韶少劭卲邵绍哨娋袑紹綤潲奢猞赊畲輋賒賖檨舌佘蛇蛥舍捨厍设社舎厙射涉涻渉設赦弽慑摄滠慴摵蔎蠂韘騇懾灄麝欇申屾扟伸身侁呻妽籶绅罙诜柛氠珅穼籸娠峷甡眒砷堔深紳兟椮葠裑訷罧蓡詵甧蔘燊薓駪鲹鯓鵢鯵鰺神榊鉮鰰邥弞抌沈审矤哂矧宷谂谉婶渖訠審諗頣魫曋瞫嬸瀋覾讅肾侺昚甚胂涁眘渗祳脤腎愼慎椹瘆蜃滲鋠瘮升生阩呏声斘昇枡泩苼殅牲珄竔胜陞曻陹笙湦焺甥鉎聲鍟鼪鵿绳憴澠譝省眚偗渻圣晟晠剰盛剩勝貹嵊聖墭榺蕂橳賸尸失师呞虱诗邿鸤屍施浉狮師絁湤湿葹溮溼獅蒒蓍詩瑡酾鳲蝨鳾褷鲺鍦鯴鰤鶳襹籭釃十饣什石辻佦时竍识实実旹飠峕拾炻祏蚀食埘時莳寔湜遈塒嵵溡蒔榯蝕鉽篒鲥鮖鼫鼭鰣史矢乨豕使始驶兘屎笶榁鉂駛士氏礻世丗仕市示卋式叓事侍势呩柹视试饰冟室恀恃拭是枾柿眂贳适栻烒眎眡舐轼逝铈視釈崼弑揓谥貰释勢嗜弒煶睗筮觢試軾鈰飾舓誓奭噬嬕澨諟諡遾餝螫簭籂襫鰘兙瓧収收手守垨首艏寿受狩兽售授绶痩膄壽瘦綬夀獣獸鏉书殳抒纾叔杸枢陎姝柕倏倐書殊紓掓梳淑焂菽軗鄃疎疏舒摅毹毺綀输跾踈樞蔬輸橾鮛攄瀭鵨尗秫婌孰赎塾熟璹贖暏暑黍署鼠鼡蜀潻薯曙癙襡糬襩籔蠴鱪鱰朮术戍束沭述侸怷树竖荗恕庶庻絉蒁術裋数竪腧墅漱潄數澍豎樹濖錰鏣鶐虪刷唰耍誜衰摔甩帅帥蟀卛闩拴閂栓涮腨双滝霜雙孀骦孇騻欆礵鷞鹴艭驦鸘爽塽慡樉縔鏯灀谁脽誰氵水氺閖帨涗涚祱税裞睡吮楯顺舜順蕣橓瞚瞤瞬鬊说妁烁朔铄欶硕矟嗍搠蒴嗽槊碩鎙厶丝司糹私咝泀俬思恖鸶媤斯絲缌蛳楒禗鉰飔凘厮榹禠罳銯锶嘶噝廝撕澌緦蕬螄鍶蟖蟴颸騦鐁鷥鼶死巳亖四罒寺汜伺似佀兕姒泤祀価孠泗饲驷俟娰柶牭梩洍涘肂飤笥耜釲竢覗嗣肆貄鈻飼禩駟蕼儩騃瀃螦乺忪松枀枩娀柗倯凇梥崧庺淞菘嵩硹蜙憽檧濍鬆怂悚捒耸竦傱愯嵷慫聳駷讼宋诵送颂訟頌誦餸鎹凁捜鄋嗖廀廋搜溲獀蒐蓃馊飕摗锼艘螋醙鎪餿颼騪叟傁嗾瞍擞薮擻藪櫢瘶苏甦酥稣窣穌鯂蘇蘓櫯囌俗玊夙诉泝肃洬涑珟素速殐粛骕傃粟訴谡嗉塐塑嫊愫溯溸肅遡鹔僳愬榡膆蔌觫趚遬憟樎樕潥鋉餗縤璛簌藗謖蹜驌鱐鷫狻痠酸匴祘笇筭蒜算夊芕虽倠哸浽荽荾眭葰滖睢熣濉鞖雖绥隋随遀綏隨瓍膸瀡髄髓亗岁砕祟粋谇埣嵗脺遂歲歳煫碎隧嬘澻穂誶賥檖燧璲禭穗穟繀襚邃旞繐繸鐆譢鐩孙狲荪飧搎猻蓀飱槂蕵薞畃损笋隼損榫箰鎨巺潠唆娑莏傞挲桫梭睃嗦羧蓑摍缩趖簑簔縮髿鮻所唢索琐琑惢锁嗩暛溑瑣鎍鎖鎻鏁逤溹蜶厦忄莘疋栅属",
                "T諳啚裧儃禪蟬繵閶瞋鐺珵侱漦爞綢籌俶埱蓴鶉鈶撘迏迖沓荅逹溚達鎉韃呔蚮軚貸癉撣嘾彈餤黨攩欓逿蕩簜蘯闣朷焘燾僜奃髢詆弚苐媂諦顚顛鈿调蓧啑惵趃奵忊墥峝湩詷钭鋀褍蜳橔囤庉憞燉軃鋨鞈騩咍漢宊她冂燑轁墤謉饋噋擴斄伖鍩奤嵜鉆汭蟺鱓愓漡苕萔姼忕徥褆扌涭瑹儵稅磃鋖枱他它牠祂咜趿铊塌榙溻褟蹹侤塔墖獭鮙鳎獺鰨挞狧闼崉涾搨遝遢阘榻毾禢撻澾誻踏嚃錔嚺濌蹋鞜闒鞳闥譶躢襨囼孡骀胎台邰坮抬苔炱炲跆鲐箈臺颱儓鮐嬯擡薹檯籉太冭夳忲汰态肽钛泰粏舦酞鈦溙態燤坍贪怹啴痑舑貪摊滩嘽潬瘫擹攤灘癱坛昙倓谈郯婒惔弾覃榃痰锬谭墰墵憛潭談醈壇曇檀顃罈藫壜譚貚醰譠罎鷤忐坦袒钽菼毯鉭嗿憳憻暺醓璮叹炭埮探傝湠僋嘆碳舕歎賧汤铴嘡劏羰蝪薚镗蹚鏜鐋鞺鼞饧坣唐堂傏啺棠鄌塘嵣搪溏蓎隚榶漟煻瑭禟膅樘磄糃膛橖篖糖螗踼糛螳赯醣鎕餹闛饄鶶帑倘偒淌傥耥躺镋鎲儻戃曭爣矘钂烫摥趟燙仐夲弢涛绦掏絛詜嫍幍慆搯滔槄瑫韬飸縚縧濤謟鞱韜饕迯咷洮逃桃陶啕梼淘绹萄祹裪綯蜪鞀醄鞉鋾錭駣檮騊鼗讨套討畓忑忒特貣脦铽慝鋱蟘膯鼟疼痋幐腾誊漛滕邆縢螣駦謄儯藤騰籐鰧籘虅驣霯唞朰剔梯锑踢銻鷈鷉厗绨偍珶啼崹惿提渧稊缇罤遆鹈嗁瑅綈碮徲漽緹蕛蝭题趧蹄醍謕蹏鍗鳀題鮷鵜騠鯷鶗鶙体挮躰骵軆體戻屉剃洟倜悌涕逖悐惕掦逷惖揥替楴裼褅殢髰嚏鬀瓋鬄籊天兲婖添酟靔黇靝田屇沺恬畋畑胋畠甛甜菾湉填搷阗碵緂磌窴鴫璳闐鷆鷏忝殄倎唺悿捵淟晪琠腆觍痶睓舔餂覥賟錪靦掭瑱睼舚旫佻庣挑祧聎芀条岧岹迢祒條笤蓚龆樤蜩鋚鞗髫鲦螩鯈鎥齠鰷宨晀朓脁窕誂窱嬥眺粜絩覜趒跳頫糶贴萜貼铁蛈僣鴩鐡鐵驖呫帖飻餮厅庁汀艼听耓厛烃烴綎鞓聴聼廰聽廳邒廷亭庭莛停婷嵉渟筳葶蜓楟榳閮霆聤蝏諪鼮圢侹娗挺涏梃烶珽脡艇颋誔鋌頲濎乭囲炵通痌嗵蓪樋熥仝同佟彤峂庝哃狪茼晍桐浵烔砼蚒眮秱铜童粡絧衕酮鉖僮勭銅餇鲖潼曈朣橦氃犝膧瞳鮦统捅桶筒統綂恸痛慟憅偷偸鍮头投骰頭妵紏敨斢黈蘣透凸禿秃怢突唋涋捸堗湥痜葖嶀鋵鵚鼵図图凃峹庩徒捈涂荼途屠梌揬稌塗嵞瘏筡腯蒤鈯圖圗廜跿酴馟鍎駼鵌鶟鷋鷵土圡吐汢钍釷兎迌兔莵堍菟鵵湍猯煓貒团団抟團慱槫檲鏄糰鷒鷻圕疃彖湪褖推蓷藬颓隤頹頺頽魋穨蘈蹪俀脮腿僓蹆骽退娧煺蜕褪駾吞呑朜焞暾黗屯芚饨豘豚軘鲀魨霕臀臋氽畽坉乇讬托汑饦侂咃拕拖沰侻莌袥託涶脫脱飥魠驮佗陀坨岮沱驼柁砣砤袉鸵紽堶跎酡碢馱槖駄踻駝駞橐鮀鴕鼧騨鼍驒鼉妥毤庹媠椭楕嫷橢鵎拓柝唾跅毻箨籜",
                "U辪癷袰蝊曢聣烪燞躼蒊蓞耂稥洜毜毝茒桛毮朑焽虲鶑鎼鐢艈霻闧焑屗歚徚鍂藔贘皼斏聁祍",
                "V",
                "W趡惡噁唲陚龏萖関闗關貫窐姽恑瞶咼堝濄幠膴鋘譁瀤綄朚撝蒦嚄擭雘艧扝噲抂巋磈薶槾鄤澫堥夘呅韎雺霿沕忞鴖譕帓歾靺瞴蟱墲娒孯掔瓗渞蜹捼琞亠撱鰖屲劸哇娃徍挖洼娲畖窊媧嗗蛙搲溛漥窪鼃攨瓦佤邷咓瓲砙袜嗢腽膃襪韈韤歪喎竵崴外弯剜婠帵塆湾睕蜿潫豌彎壪灣丸刓汍纨芄完岏忨抏玩笂紈捖顽烷琓貦頑邜宛倇唍挽晚盌埦婉惋晩梚绾脘菀晼椀琬皖畹碗綩綰輓踠鋔鍐万卍卐杤捥腕萬翫鋄薍錽贃鎫贎尩尪尫汪亡亾兦王仼彺莣蚟网忹往徃枉罔惘菵暀棢焹蛧辋網蝄誷輞瀇魍妄忘迋旺盳望朢危威烓偎逶隇隈喴媁媙愄揋揻渨煀葨葳微椳楲溦煨詴縅蝛覣嶶薇鳂癐巍鰃鰄囗为韦围帏沩违闱峗峞洈為韋桅涠唯帷惟维喡圍嵬幃湋溈爲違潍蓶鄬潙潿濰鍏闈鮠癓覹犩霺伟伪尾纬芛苇委炜玮洧娓捤浘荱诿偉偽崣梶硊萎隗骩嵔廆徫愇猥葦蒍骪骫暐椲煒瑋痿腲艉韪僞碨蜲蜼鲔寪緯蔿諉踓韑頠儰濻鍡鮪壝韙颹瀢亹斖卫未位味苿畏胃軎尉硙菋谓喂媦渭猬煟墛蔚慰熭犚磑緭蝟衛懀濊璏罻衞謂餧鮇螱褽餵魏藯轊鏏霨鳚蘶饖讆躗讏躛昷塭温殟溫瑥榲瘟豱鳁鎾饂鰛鰮文彣纹芠炆砇闻紋蚉蚊珳阌鈫雯瘒聞馼魰鳼鴍螡閺閿蟁闅鼤闦刎吻呚忟抆呡肳紊桽脗稳穏穩问妏汶莬問渂脕揾搵絻顐璺翁嗡鹟螉鎓鶲奣塕嵡滃蓊暡瞈聬瓮蕹甕罋齆挝倭涡莴唩涹渦猧萵喔窝窩蜗蝸踒我婐婑捰仴沃肟卧臥偓媉幄握渥焥硪楃腛斡瞃濣瓁龌齷乌圬弙污邬呜杇巫屋洿诬钨趶剭窏釫鄔嗚誈誣箼螐鴮鎢鰞无毋吴吾呉芜梧洖浯茣莁珸祦鹀無禑蜈蕪璑鵐鯃鼯鷡乄五午仵伍坞妩庑忤怃迕旿武玝侮俉倵捂啎娬牾珷塢摀熓碔鹉瑦舞嫵廡憮潕錻儛橆甒鵡躌兀勿务戊阢伆屼扤岉杌芴忢物矹敄误務悞悟悮粅逜晤焐婺嵍痦隖靰骛奦嵨溩雾寤熃誤鹜鋈窹霚鼿霧齀蘁騖鶩",
                "X欸庍壆扱烲愖糦臰欪滀嘼錯廗諜摡給蚼規嶲鮭巂鬹咁譀迒茠滈欱郃螛嗃熇燺揈閧闀闂鬨銗謼滸芐觟懁郇狟澴還镮鐶儶譮孈葷轋掝擊彐蔇縘繫夾埉浹傢裌叚徦鰔梘筧礆見閒瞯鵁轇驕絞較湝頡觧吤繲坙巠坓顈眗鼰鼳鋗絹獧決泬勪噱姰濬愾埳堿闞晇欵歀潰搚懢壏嘮釐溓蘝蘞稴漻衖莔禰瓕賯撓譊鉨鉩煖謳嘔盤嚊恓棲諿氣欦臤慳荨羬蕁槏伣俔嗛骹燆睄綅瓊蓲鱃魼胊卻舃碏儴勷蘘纕繻灑钑鈒鰓騷雭殺榝姍釤縿莦颵姺濕宩昰笹齛咰鉥獡箾蜤燍叜宿碿潚橚孫鶽橝撢餳饀屜歒盷蓨赨緰圩韡捾夕兮忚汐西覀吸希卥昔析矽穸肸肹俙徆怸郗饻唏奚娭屖息悕晞氥浠牺狶莃唽悉惜桸欷淅渓烯焁焈琋硒菥赥釸傒惁晰晳焟犀睎稀粞翕翖舾鄎厀嵠徯溪煕皙蒠锡僖榽熄熙緆蜥豨餏嘻噏嬆嬉瘜膝餙凞樨橀歙熹熺熻窸羲螅螇錫燨犠瞦礂蟋谿豀豯貕繥雟鯑鵗觹譆醯鏭隵巇曦爔犧酅觽鼷蠵鸂觿鑴习郋席習袭觋媳椺蒵蓆嶍漝覡趘槢蝷薂隰檄謵鎴霫鳛飁騱騽襲鰼驨枲洗玺徙铣喜葈葸鈢屣漇蓰銑憘憙暿橲禧諰壐縰謑蟢蹝璽鱚矖纚躧匸卌戏屃系饩呬忥怬细係恄盻郤欯绤細釳阋塈椞舄趇隙慀滊禊綌赩隟熂犔稧戯潟澙蕮覤戱黖戲磶虩餼鬩嚱闟霼衋虾谺傄閕敮煆颬瞎蝦鰕匣侠狎俠峡柙炠狭陜峽烚狹珨祫硖笚翈舺陿溊硤遐搳暇瑕筪碬舝辖縀蕸縖赮魻轄鍜霞鎋黠騢鶷閜丅下吓圷疜夏梺廈睱諕嚇懗罅夓鏬仙仚屳先奾纤佡忺氙杴祆秈苮籼珗莶掀铦跹酰锨僊僲嘕銛鲜暹韯憸鍁繊褼韱鮮馦蹮孅廯攕譣纎鶱襳躚纖鱻伭咞闲妶弦贤咸挦涎胘娴娹婱絃舷蚿衔啣痫蛝閑鹇嫌甉銜嫺嫻憪撏澖誸賢諴輱醎癇癎藖鹹礥贒鑦鷳鷴鷼冼狝显险毨烍猃蚬険赻筅尟尠搟禒蜆跣箲獫獮藓鍌燹顕幰攇櫶蘚玁韅顯灦县岘苋现线臽限姭宪県陥哯垷娊娨峴晛涀莧陷現馅睍絤缐羡献粯腺僩僴綫誢撊線鋧憲橌縣錎餡豏瀗臔獻糮鏾霰鼸乡芗相香郷厢啌鄉鄊廂湘缃葙鄕楿薌箱緗膷襄忀骧麘欀瓖镶鱜鑲驤瓨佭详庠栙祥絴翔跭享亯响蚃饷晑飨想銄餉鲞嚮蠁鯗響饗饟鱶向姠巷项珦象缿萫項像勨嶑曏橡襐蟓鐌鱌灱灲呺枭侾削哓枵骁宯宵庨恷消绡虓逍鸮啋婋梟焇猇萧痚痟硝硣窙翛萷销揱綃嘐歊潇箫踃嘵憢撨獢銷霄彇膮蕭魈鴞穘簘藃蟂蟏謞鴵嚣瀟簫蟰髇嚻囂櫹髐鷍蠨驍毊虈洨郩崤淆訤誵小晓暁筱筿皛曉篠謏皢孝肖効咲恔俲哮效校涍笑啸傚敩滧詨嘋嘨誟嘯歗熽斅斆些楔歇蝎蠍劦协旪邪協胁垥奊恊拹挾脅脇脋衺偕斜谐猲絜翓嗋愶携瑎綊熁膎勰撷擕緳缬蝢鞋諧燲擷鞵襭攜纈讗龤写冩寫藛伳灺泄泻祄绁缷卸炧炨卨娎屑屓偰徢械焎禼亵媟屟揳渫絬谢僁塮榍榭褉噧屧暬韰嶰廨懈澥獬糏薢薤邂燮褻謝夑瀉瀣爕蟹蠏齘齥齂躠屭躞心邤妡忻芯辛昕杺欣盺俽惞鈊锌新歆廞噷噺嬜薪馨鑫馫枔鬵鐔伈潃阠伩囟孞炘信軐脪衅訫焮馸舋顖釁兴狌星垶骍惺猩煋瑆腥蛵觪箵篂興謃曐觲騂皨刑邢形陉侀郉哘型洐钘陘娙硎裄铏鈃鉶銒鋞睲醒擤杏姓幸性荇倖莕婞悻涬塂緈嬹臖凶兄兇匈芎讻忷汹哅恟洶胷胸訩詾雄熊诇詗夐敻休俢修咻庥烋烌羞脙鸺臹貅馐樇銝髤髹鎀鮴鵂饈鏅飍苬朽綇滫糔秀岫珛绣袖琇锈溴綉璓裦螑繍繡鏥鏽齅戌旴疞盱欨胥须訏顼虗虚谞媭幁揟欻虛須楈窢頊嘘稰需魆噓墟嬃歔縃蕦蝑歘諝譃魖驉鑐鬚俆徐蒣许呴姁诩冔栩珝偦許湑暊詡鄦糈醑盨旭伵序汿侐卹沀叙恤昫洫垿欰殈烅珬勖勗敍敘烼绪续酗喣壻婿朂溆絮訹嗅慉煦続蓄賉槒漵潊盢瞁緒聟銊稸緖瞲藚續蓿吅轩昍咺宣晅軒梋谖喧塇媗愃愋揎萱萲暄煊瑄蓒睻儇禤箮翧蝖嬛蕿諠諼鍹駽矎翾藼蘐蠉譞鰚讂玄玹痃悬旋琁蜁嫙漩暶璇檈璿懸选烜暅選癣癬怰泫昡炫绚眩袨铉琄眴衒渲絢楦鉉碹蔙镟鞙颴縼繏鏇贙疶蒆靴薛鞾穴斈乴坹学岤峃茓泶袕鸴踅學嶨澩燢觷雤鷽雪樰膤艝轌鳕鱈血吷怴泧狘疦桖烕谑趐謔瀥坃勋埙焄勛塤熏窨蔒勲勳薫駨嚑壎獯薰曛燻臐矄蘍壦爋纁醺寻巡旬驯杊询峋恂洵浔紃荀栒桪毥珣偱尋循揗詢馴鄩鲟噚攳樳燂燅燖璕襑蟳鱏鱘灥卂训讯伨汛迅侚徇狥迿逊殉訊訓訙奞巽殾遜愻賐噀蕈顨鑂吁",
                "Y叆賹礙譺靉菴媕葊痷闇鵪鶕晻洝媼澚墺驁頨瑒耛拸呾訑婸潒扚昳屵姶堊搤閼煾妋鳱輵夃焸蠱溎裷緷蟈淊嚛欥瓛輐喛揘韹熀袆煇褘蚘噦矆拁玪豜豣將侥烄僥伒莖俓泂揂圧僪貗飬妜焆鐍炏顑丂髺樂貍櫟躒輅擽嫚玅桙獶輗掜孴儗肀喦噛槷嚙钀汼齵堷踦锜錡裿綺鉛膁羗撽赺欽汓翑蝺輑橪蕘嬈嵤銳鋭挻烻剡虵縄繩鱦釶鉇箷戺謚釋哾說説爍鑠梀筍鉈珆旲錟湯匋鴺趯恌銕桯筩婾媮殕悇蛻涒扡挩捝狏迱詑彵啘乛涴妧尣燰琟維厃痏薳叞榅辒輼轀勜臒汙汚烏歍吳郚娪焬熈誒歖潝疨磍嬐薟唌湺衘崄險嶮硍羨麲詳峫鐷洩紲絏緤訢脩褎褏銹獝藇鱮楥辥廵潯丫压呀庘押鸦桠鸭孲铔椏鴉錏鴨壓鵶鐚牙伢岈芽厓枒琊笌蚜堐崕崖涯猚瑘睚衙漄齖厊庌哑唖啞痖雅瘂蕥劜圠亚穵襾讶亜犽迓亞玡垭娅挜砑俹氩埡婭掗訝揠氬猰聐圔稏窫齾咽恹剦烟珚胭偣崦淹焉菸阉湮腌傿煙鄢嫣漹嶖樮醃閹嬮篶懕臙黫讠円延闫严妍芫言訁岩昖沿炎郔姸娫狿研莚娮盐琂硏訮閆阎嵒嵓筵綖蜒塩揅楌詽碞蔅颜虤閻厳檐顏顔嚴壛巌簷櫩麙壧孍巖巗巚欕礹鹽麣夵抁沇乵兖奄俨兗匽弇衍偃厣掩眼萒郾酓嵃愝扊揜棪渰渷琰遃隒椼硽罨裺演褗戭蝘魇噞躽縯檿黡厴甗鰋鶠黤齞龑儼黬黭顩鼴巘曮魘鼹齴黶厌妟觃牪姲彥彦砚唁宴晏艳覎验偐掞焔谚隁喭堰敥焰焱猒硯葕雁椻滟鳫厭墕暥熖酽嬊谳餍鴈燄燕諺赝鬳曕鴳酀騐験嚥嬿艶贋軅爓醶騴鷃灔贗觾讌醼饜驗鷰艷灎釅驠灧讞豓豔灩央咉姎抰泱殃胦眏秧鸯鉠雵鞅鍈鴦扬羊阦阳旸杨炀佯劷氜疡钖飏垟徉昜洋羏烊珜眻陽崵崸揚蛘敭暘楊煬禓瘍諹輰鍚鴹颺鐊鰑霷鸉卬仰佒坱奍岟养炴氧痒紻傟楧軮慃氱羪養駚懩攁瀁癢礢怏柍恙样羕詇様漾樣幺夭吆妖枖祅訞喓葽楆腰鴁邀爻尧尭肴垚姚峣轺倄烑珧窑傜堯揺殽谣軺嗂媱徭愮搖摇猺遙遥摿暚榣瑤瑶銚飖餆嶢嶤徺磘窯窰餚繇謠謡鳐颻蘨顤鰩仸宎岆抭杳殀狕苭咬柼眑窅窈舀偠婹崾溔榚鴢闄騕齩鷕穾药要袎窔筄葯詏熎覞靿獟鹞薬鼼曜燿艞藥矅曣耀纅鷂讑鑰倻椰暍噎潱蠮爷耶捓揶铘爺釾鋣鎁擨也吔亪冶埜野嘢漜壄业叶曳页邺夜抴亱枼洂頁晔枽烨掖液谒堨殗腋葉鄓墷楪業馌僷曄曅歋燁擛皣瞱鄴靥嶪嶫澲謁餣嚈擫曗瞸鍱擪爗礏鎑饁鵺靨驜鸈膶岃一弌辷衤伊衣医吚壱依祎咿洢猗畩郼铱壹揖欹蛜禕嫛漪稦銥嬄噫夁瑿鹥繄檹毉醫黟譩鷖黳乁仪匜圯夷冝宐沂诒侇宜怡沶狋衪迤饴咦姨峓弬恞柂瓵荑贻迻宧巸扅栘桋眙胰袘酏痍移萓媐椬羠蛦詒貽遗暆椸誃跠頉颐飴疑儀熪遺嶬彛彜螔頤頥寲嶷簃顊鮧彝彞謻鏔籎觺讉鸃乙已以迆钇佁攺矣苡苢庡舣蚁釔倚扆笖逘偯崺旑椅鈘鉯鳦旖輢敼螘檥礒艤蟻顗轙齮乂义亿弋刈忆艺仡匇肊议阣亦伇屹异忔芅伿佚劮呓坄役抑曵杙耴苅译邑佾呭呹峄怈怿易枍泆炈绎诣驿俋奕帟帠弈枻浂玴疫羿衵轶唈垼悒挹栧欭浥浳益袣谊貤陭勚埶埸悘悥殹異羛翊翌萟訲訳豙豛逸釴隿幆敡晹棭殔湙焲蛡詍跇鈠骮亄兿意溢獈痬竩缢義肄裔裛詣勩嫕廙榏潩瘗膉蓺蜴靾駅億撎槸毅熠熤熼瘞誼镒鹝鹢黓劓圛墿嬑嬟嶧憶懌曀殪澺燚瘱瞖穓縊艗薏螠褹寱斁曎檍歝燡燱翳翼臆貖鮨癔藙藝贀鎰镱繶繹豷霬鯣鶂鶃鶍瀷蘙譯議醳醷饐囈鐿鷁鷊懿襼驛鷧虉鷾讛齸乚囙因阥阴侌垔姻洇茵荫音骃栶殷氤陰凐秵裀铟陻隂喑堙婣愔筃絪歅溵禋蒑蔭慇瘖銦磤緸鞇諲霒駰噾濦闉霠韾冘吟犾苂垠泿圁峾烎狺珢粌荶訔唫婬寅崟崯淫訡银鈝龂滛碒鄞夤蔩訚誾銀龈噖殥璌嚚檭蟫霪齗齦鷣尹引吲饮蚓隐淾釿鈏飲隠靷飮朄趛檃瘾隱嶾濥螾蘟櫽癮讔印茚洕胤垽湚猌廕酳慭癊憖憗鮣懚檼应応英偀桜珱莺啨婴媖愥渶绬朠煐瑛嫈碤锳嘤撄滎甇緓缨罂蝧賏樱璎噟罃褮霙鴬鹦嬰應膺韺甖鎣鹰鶧嚶孆孾攖瀴罌蘡櫻瓔礯譻鶯鑍纓蠳鷪軈鷹鸎鸚盁迎茔盈荥荧莹萤营萦蛍営溁溋萾僌塋楹滢蓥潆熒蝇瑩蝿嬴營縈螢濙濚濴藀覮謍赢巆攍攚瀛瀠瀯蠅櫿灐籝灜贏籯矨郢梬颍颕颖摬影潁瘿穎頴巊廮鐛癭映暎硬媵膡鞕瀅譍哟唷喲佣拥痈邕庸傭嗈鄘雍墉嫞慵滽槦牅噰壅擁澭郺镛臃癕雝鏞鳙廱灉饔鱅鷛癰喁颙顒鰫永甬咏怺泳俑勇勈栐埇悀柡涌恿傛惥愑湧硧詠塎嵱彮愹蛹慂踊禜鲬踴鯒用苚砽醟优忧攸呦怮泑幽悠麀滺憂優鄾嚘懮瀀櫌纋耰尢尤由沋犹邮怞油肬怣斿柚疣峳浟秞莜莤莸逌郵铀偤蚰訧逰游猶遊鱿楢猷鲉輏駀蕕蝣魷輶鮋櫾邎友有丣卣苃酉羑庮羐莠梄聈脜铕湵蒏禉蜏銪槱牖牗黝又右幼佑侑孧狖糿哊囿姷宥峟牰祐诱迶唀梎蚴亴貁釉酭誘鼬扜纡迂迃穻陓紆虶唹淤盓渝瘀箊于亐予邘伃余妤扵杅欤玗玙於盂臾衧鱼俞兪禺竽舁茰荢娛娯娱狳谀酑馀渔萸釪隃隅雩魚堣堬崳嵎嵛愉揄楰湡畬畭硢腴逾骬愚楡榆歈牏瑜艅虞觎漁睮窬舆褕歶羭蕍蝓諛雓餘魣嬩懙澞覦踰歟璵螸輿鍝礖謣髃鮽旟籅騟鯲鰅鷠鸆与伛宇屿羽雨俁俣挧禹语圄峿祤偊匬圉庾敔鄅萭萮铻傴寙斞楀瑀瘐與語窳鋙龉噳嶼貐斔麌蘌齬玉驭聿芋芌妪忬饫育郁彧昱狱秗茟俼峪栯浴砡钰预喐域堉悆惐欲淢淯袬谕逳阈喅喩喻媀寓庽御棛棜棫焴琙矞裕遇飫馭鹆愈滪煜稢罭蒮蓣誉鈺預嫗嶎戫毓獄瘉緎蜟蜮輍銉隩噊慾稶蓹薁豫遹鋊鳿澦燏燠蕷諭錥閾鴥鴧鴪儥礇禦魊鹬癒礜穥篽繘醧鵒櫲饇蘛譽轝鐭霱欎驈鬻籞鱊鷸鸒欝軉鬰鬱灪籲爩囦鸢剈冤弲悁眢鸳寃渁渆渊渕惌淵葾棩蒬蜎鹓箢鳶蜵駌鋺鴛嬽鵷灁鼘鼝元贠邧员园沅杬垣爰貟原員圆笎蚖袁厡酛圎援湲猨缘鈨鼋園圓塬媴嫄源溒猿獂蒝榞榬辕緣縁蝝蝯魭橼羱薗螈謜轅黿鎱櫞邍騵鶢鶰厵远盶逺遠夗肙妴苑怨院垸衏傆媛掾瑗禐愿裫褑褤噮願曰曱约約箹矱彟彠月戉刖岄抈礿岳枂玥恱钥悅悦蚎蚏軏钺阅捳跀跃粤越鈅粵鉞閱閲嬳樾篗嶽龠籆瀹蘥黦爚禴躍籥鸑籰龥鸙蒀煴蒕熅奫蝹赟頵馧贇云勻匀伝呍囩妘抣沄纭芸昀畇眃秐郧涢紜耘耺鄖雲愪氲溳筼蒷氳熉澐蕓鋆橒篔縜繧允阭夽抎狁玧陨荺殒喗鈗隕殞褞馻磒霣齫齳孕运枟郓恽晕鄆酝傊惲愠缊運慍暈腪韫韵熨緼蕰蕴縕薀賱醖醞餫藴韗韞蘊韻這",
                "Z敱捗囃謲匨蔵冊側厠廁嶒扠挿揷蹅茝僝欃倀长仧長镸鼌鼂謿謓迧陳鈂趂朾脀憕徎胵絺泜歭遟遲迣徸漴褈緟蝩蟲紬搊椆詶薵偢芻鉏蕏傳鶨倕埀箠鎚純湻辶腏趠齱骴薋泚跐從蓯樅熜緫潀潈潨酢噈欑穳篹嶉槯伜倅紣綷顇墫拵踆睉蔖剳蹛黱酖亶翢篴拞牴觝啇摕蝃踶點鳭調藋喋臷鰈眰鼑枓剢耑磓隊腞夛仛喥柮樲胕阝贛戇滜睪牫贑嫢啈楖嚌璾鯽穧椾碊鳽餰栫袸濺瀳鏩繳擳竧鳩砠蓻齟怚跙脧雋捔逫嵁沴酈譧驡狵沵摨聶囁釽亝祇蚔齊磩鈆謙綪繰菬埥軽鯖伹岨恮跧甽繅洓篸箑摂攝鉐實識亊鉃適銴檡薥藷鸀尌虒睟簨駘菭襢犆媞薙嚔鐟塡怗聑跕鉄鉵獞穜潳剬剸塼摶漙篿尵旽啍忳飩杔馲驝陁萚蘀聉顡醀錗撾扸杫咥枮鮝鞢鋅鮏鯹鎐蓔捙偞擖杝妷秇栺軼乑斦浧銿鈾圫汋帀匝沞咂拶沯桚紥紮鉔魳臜臢杂砸韴雑磼襍雜囐雥災灾甾哉栽烖菑渽溨睵賳宰载崽載再在扗洅傤酨儎縡兂糌簪簮鐕咱偺喒昝寁撍儧攒儹攢趱趲暂暫賛赞錾鄼濽蹔酂瓉贊鏨瓒酇囋灒讃瓚禶襸讚饡牂羘赃賍臧賘贓髒贜驵駔奘弉脏塟葬銺臓臟傮遭糟蹧醩凿鑿早枣栆蚤棗璅澡璪薻藻灶皁皂唕唣造梍喿慥煰艁噪簉燥竃譟趮躁竈啫伬则択沢择泎泽责迮則唶啧帻笮舴責溭矠嘖嫧幘箦蔶樍歵諎赜擇澤皟瞔簀耫礋襗謮賾蠌齚齰鸅仄夨庂汄昃昗捑崱稄贼賊鲗蠈鰂鱡怎谮譖譛囎曽増鄫增憎缯橧熷璔矰磳罾繒譄鱛锃鋥甑赠贈吒迊咋抯挓柤哳偧喳揸渣溠楂劄皶箚樝觰皻譇齄齇扎札甴轧軋闸蚻铡煠牐閘霅鍘譗厏苲眨砟搩鲊鲝踷鮓鮺乍灹诈咤奓柵炸宱痄蚱詐搾摣榨醡夈粂捚斋斎摘榸齋宅翟窄鉙债砦債寨瘵沾毡旃栴粘蛅飦惉詀趈詹閚谵噡嶦薝邅霑氈氊瞻鹯旜譫饘鳣驙魙鱣鸇讝拃斩飐展盏崭斬琖搌盞嶃嶄榐辗颭嫸醆橏蹍輾皽黵占佔战栈桟站偡绽菚棧湛戦綻嶘輚戰虥虦覱轏蘸驏张弡張章傽鄣嫜彰慞漳獐粻蔁遧暲樟璋餦蟑鏱騿鱆麞仉涨涱掌漲幥礃鞝鐣丈仗扙帐杖胀账粀帳脹痮障墇嶂幛賬瘬瘴瞕佋钊妱巶招昭炤盄釗啁鉊駋窼鍣爫找沼瑵召兆诏枛垗狣赵笊肁旐棹罀詔照罩箌肇肈趙曌燳鮡櫂瞾羄蜇嫬遮厇折歽矺砓籷虴哲埑粍袩啠悊晢晣辄喆棏蛰詟谪摺輒樀磔輙銸辙蟄嚞謫謺鮿轍讁襵讋者锗赭褶鍺这柘浙淛嗻蔗樜鹧蟅鷓贞针侦浈珍珎貞帪栕桢眞真砧祯針偵敒桭酙寊湞葴遉搸斟楨獉甄禎蒖蓁鉁靕榛槇殝瑧碪禛潧箴樼澵臻薽錱轃鍖鍼籈鱵屒诊抮枕姫弫昣胗轸畛疹眕袗紾聄萙裖覙診軫嫃缜稹駗縝縥辴鬒黰圳阵纼侲挋陣鸩振朕栚紖眹赈塦揕絼蜄敶誫賑鋴镇震鴆鎭鎮黮凧争佂姃征怔爭峥挣炡狰烝眐钲埩崝崢掙猙睁聇铮媜揁筝徰睜蒸鉦徴箏徵踭篜錚鬇癥氶抍糽拯掟塣晸愸撜整正证诤郑帧政症幀証鄭諍鴊證之支卮汁芝吱巵汥枝知织肢徔栀祗秓秖胑胝衹衼倁疷祬秪脂隻梔戠椥臸搘禔綕榰蜘馶鳷謢鴲織蘵鼅禵执侄坧直姪値值聀釞埴執职植殖禃絷跖瓡墌摭馽嬂慹漐踯樴膱縶職蟙蹠蹢軄躑止只凪劧旨阯址坁帋扺汦沚纸芷抧祉茋咫恉指枳洔砋轵淽疻紙訨趾軹黹酯藢襧阤至芖志忮扻豸制厔垁帙帜治炙质郅俧峙庢庤挃柣栉洷祑陟娡徏挚晊桎狾秩致袟贽轾乿偫徝掷梽猘畤痔秲秷窒紩翐袠觗貭铚鸷傂崻彘智滞痣蛭骘寘廌搱滍稙稚筫置跱輊锧雉墆槜滯潌疐瘈製覟誌銍幟憄摯潪熫稺膣觯質踬鋕旘瀄緻隲駤鴙儨劕懥擲擿櫛穉螲懫贄櫍瓆觶騭鯯礩豑騺驇躓鷙鑕豒中伀汷刣妐彸迚忠泈炂终柊盅衳钟舯衷終鈡幒蔠锺螤鴤螽鍾鼨蹱鐘籦肿种冢喠尰塚歱煄腫瘇種踵仲众妕狆祌茽衶重蚛偅眾堹媑筗衆諥州舟诌侜周洀洲炿诪烐珘辀郮婤徟淍矪週鸼喌粥赒輈銂賙輖霌駲嚋盩謅鵃騆譸妯轴軸碡肘帚疛菷晭睭箒鯞纣伷呪咒宙绉冑咮昼紂胄荮晝皱酎粙葤詋甃僽皺駎噣縐骤籀籕籒驟朱劯侏诛邾洙茱株珠诸猪硃袾铢絑蛛誅跦槠潴蝫銖橥諸豬駯鮢鴸瀦藸櫧櫫鼄鯺蠩竹泏竺炢笁茿烛窋逐笜舳瘃蓫燭蠋躅鱁劚孎灟斸曯欘爥蠾钃主宔拄砫罜陼渚煑煮詝嘱濐麈瞩屬囑矚伫佇住助纻芧苎坾杼注苧贮迬驻壴柱柷殶炷祝疰眝祩竚莇秼紵紸羜著蛀嵀筑註貯跓軴铸筯鉒飳馵墸箸翥樦鋳駐築篫霔麆鑄抓檛膼簻髽爪拽跩专叀専砖專鄟嫥瑼甎膞颛磚諯蟤顓鱄转孨転竱轉灷啭堟蒃瑑僎赚撰篆馔縳襈賺譔饌囀籑妆庄妝庒荘娤桩莊湷粧装裝樁糚丬壮壯状狀壵梉焋幢撞戅隹追骓椎锥錐騅鵻沝坠笍娷缀惴甀缒畷硾膇墜綴赘縋諈醊錣餟礈贅轛鑆宒迍肫窀谆諄衠准埻凖準綧訰稕卓拙炪倬捉桌棁涿棳琸窧槕穛穱蠿圴彴犳灼叕妰茁斫浊丵浞烵诼酌啄啅娺梲着斮晫椓琢斱硺窡罬撯擆斲禚劅諁諑鋜濁篧擢斀斵濯櫡謶镯鐯鵫灂蠗鐲籗鷟籱仔孖孜茊兹咨姕姿茲栥玆紎赀资崰淄秶缁谘赼嗞孳嵫椔湽滋葘辎鄑孶禌觜貲資趑锱稵緇鈭镃龇輜鼒澬諮趦輺錙髭鲻鍿鎡頾頿鯔鶅齍鰦齜籽子吇姉姊杍矷秄胏呰秭耔虸笫梓釨啙紫滓訾訿榟橴字自芓茡倳剚恣牸渍眥眦胔胾漬唨宗倧综骔堫嵏嵕惾棕猣腙葼朡椶嵸稯綜緃熧緵翪艐蝬踨踪磫豵蹤騌鬃騣鬉鬷鯮鯼鑁总偬捴惣愡揔搃傯蓗摠総縂燪總鍯鏓纵昮疭倊猔碂粽糉瘲縦錝縱邹驺诹郰陬掫菆棷棸鄒箃緅諏鄹鲰鯫黀騶齺赱走鯐奏揍媰租菹葅蒩卆足卒哫崒崪族傶稡箤踤踿镞鏃诅阻组俎爼珇祖組詛靻鎺謯劗躜鑚躦鑽繤缵纂纉籫纘钻揝攥厜朘嗺樶蟕纗嶊嘴噿濢璻枠栬絊酔晬最祽罪辠酻蕞醉嶵檇鋷錊檌穝欈尊嶟遵樽繜罇鶎鐏鳟鱒鷷僔噂撙譐捘銌昨秨莋捽椊葃稓筰鈼左佐繓作坐阼岝岞怍侳柞祚胙唑座袏做葄蓙飵糳咗"
            };
        private static string[] WB = new string[] {
            "A鞴鞲鞣鞫鞯鞔鞒鞑鞅靼銎跫綦翳蛩颟鹳鹋鸫鸢慝觐觋贳瓯戡檠迓甙忒弋撖摁廾蘼蘖蘩蘅蘧藿藜藁藓薰薷薹薅薜薮蕹薏薇薨薤蕻蕲蕃瞢蕺蕞蕤蕨蕈蕙蓼蓿蔻蕖蔺蔟蔹蓰蔸甍蔌蓣蓥蒗蒴蒹蒡蓠蒺蒿蓊蓓蒽蓦蓐蓍蓁葭萱蒎蒌葶葩葆萼葸蒉葺蒈蒇葳葙葚葑葜菡菰萦菀菅菪菹菸萃萏菟菔萆萑萸萜菖菽菝萋萘堇菘菥萁菁莼莺莨莞莘荻莸荽莩莶荼莅莜莓莪莠莴莳荸莰荮荭荪荬荩茛荨荥荦茳茺茭荠茗荀荟荃荇荏茯荞莛茱茴茼莒茈荜荛荑茜苕苠茕茔茆茚茑苓苻茌苘苒苴苜茇茏苤苷茉苡芤苎苄芟芪芡芴芩苁苌苋芮芷芘苣苊苈芰芾芸芫芙芗芑芎芄芨芊芏艿艽艹鄞郾邛劐蒯赜匾匮匦叵匚廿茁著芝蒸斟蔗蘸藻葬匝蕴苑芋荧营萤莹英荫茵艺颐医药尧燕雅牙芽鸦薛靴蓄芯薪邪鞋萧巷项匣熙昔芜巫卧蔚萎苇藤萄苔蓑蒜苏斯薯蔬世式甚芍苫莎散萨若蕊茹荣蓉茸戎惹鹊颧区擎芹勤莲荔莉蕾勒劳蓝莱葵匡苦恐苛勘菌巨菊鞠敬警茎荆靳芥藉戒节蕉匠蒋荐茧荚蓟基惑或获荤茄切翘鞘巧蔷其七欺期蒲菩葡莆萍苹匹蓬藕殴鸥欧孽蔫匿慕募幕暮墓某莫蘑摹蔑藐苗蒙萌茂茅莽茫芒蔓落萝芦菱黄荒划花葫菏荷邯菇苟共贡汞巩恭功攻工葛革戈甘芬匪菲芳范藩贰董东蒂荡葱茨臣茶茬草藏苍蔡菜菠鞭蔽蓖苯薄苞靶芭鞍艾蔼",
            "B粜蚩颞聩聒聍聆聃耵骘孢孓孑屮隳凵勐鄹隰隗隍隈陴陲陬陧陟陔陉陂阼阽阪阱阡阢阝卺亟丞阻子孜坠职阵障陨院隅隐阴也耶阳逊限陷险隙卫陀陶孙祟隧随隋陕阮孺娶取了辽聊联孔聚阶降际聘陪聂陌孟陆陋陇隆陵函孩孤耿隔附防耳堕队陡耽聪除出耻承陈陛隘阿",
            "C鍪蟊蝥颡矜皴鹬鹜甬瞀怼炱毵骧骥骣骢骠骟骝骛骖骓骒骐骊骈骅骁骀驿驺驸驷驵婺逡迨迳巯畚弁厶邰刭驻骤蚤允驭豫预予又勇恿以矣验驯熊戏驼驮通台双驶圣骚桑叁柔劝驱垒骏驹颈劲骄艰鸡骑骗能难牟矛马骆骡驴欢骇观对叠邓怠驰骋叉参驳巴",
            "D鬣鬟鬓鬏鬈髹髭髻髫髯髦髡髟魇蹙趸翡舂蜚蜃虿耱耨耩耧耦耥耢耠耜耖耔耒鹩鹕鹌鸸鸪瓠礴礞礤礓磴礅磲磉磙磔碥碹碲碣碡碜碇碚碓碛硪硌硇硐硗硖硭硎砩砣砬砥砼砟砻砺砹砝砜砭斫砑砘砗砉砀矸矶恧恝焘斐飙欹腴挈臧戛彗尴尬尥尢匏耷奁夼劢酆劂剞刳赝靥厮厥厣厝厍仄嘏左奏鬃砖砧丈在砸耘愿原郁右友有尤硬页雁砚厌艳奄研压戌雄硝厢咸夏厦袭矽硒戊威万碗厅套碳态太泰碎肆硕爽耍戍寿石盛砷奢砂三辱确犬秦历砾励厉厘磊奎盔矿夸克磕砍厩韭兢礁硷碱慧灰磺牵砌契奇戚破砒碰硼砰裴耪碾奈耐面迈码碌垄聋龙硫磷胡厚耗夯硅顾故古辜龚耕感奉丰奋非矾而厄夺碟碉碘大达磋存磁蠢唇春础厨成辰厂碴厕布泵奔辈悲碑磅帮邦百耙碍",
            "E雎貔貘貅貊貂豸豕繇鹞燹膦臁膻臊朦臌膪膣滕膑膈媵塍腧腭腽腼腩腠腱腚腙腓腌腈脲脘脬脞脶豚脒朕胼胲脎脍胭胴胱胫胝朐胗胍胙胂胛胪胩胨胧肷肭肫肱肽朊肼肜肟刖虢爰戤孚尕邈彡豳奚垡郛鼐助逐肘肿脂肢胀脏孕月用臃盈臆胰腋舀遥腰悬须胸腥胁腺县膝腕妥脱腿腆腾膛胎舜甩受胜膳腮乳脸肋腊胯爵脚胶及肌且腔脐脾鹏朋膨胚胖脓腻脑乃膜觅貌脉貉股胳肛肝腹腑脯服肤肺肥肪肚胆脆肠彩采膊脖豹胞膀肮胺爱",
            "F鼋霾霰霭霪霎霏霈霁霆雯雳雩謦赭赧趱趑趔趄赳麴翥裘箐罄螫颢颉顸耋鹁盍瞽磬悫恚熹觳毂彀耄觏觌赍贲耆甏戟辇韬韫嫠遘逵逑懿鼙馨墀墚墉墁塬塥堠塄堙堞堀埭埽堍堋埝埤埸埯埴垸埒埙埚埘埕垠垴垧埏垲垌垤垭坳坶坭坨坻坼垆坫垅坩坂圻坜圯圮圹圳圪圬圩酃邗卦啬孛亓兀亍走专煮志址直支震真者赵增载哉栽运云越远袁垣元域雨壹堰严盐雪需墟幸协孝霄献现霞喜雾坞无斡未违韦顽土填替趟塘坦坛坍塔塌索寺霜士示十声赦墒丧韧壤却去趣趋求雷老垃坤亏款块垮坑壳坷考坎堪刊均救境井进劫截教嘉吉圾击魂卉墙乾起埔坡坪霹坯彭培霓南霉卖埋露零霖坏壶赫郝壕翰韩过圭规鼓垢埂赶干赴夫封坟坊二垛墩堆堵都动颠地堤戴寸矗翅赤城趁朝超场才裁埠勃博雹霸坝埃",
            "G餮餍鳌鏊靓豉豇麸纛翮蠹螯虺聱鹉鹂忑欤敕赉戬戋軎殪殡殛殚殍殓殒殄殇殂殁獒橐瓒璩璨璞璋璇璁璀璎璜瑾瑭瑷瑙瑕瑗瑜瑁琚琛琬琮琰琨琥琦瑛琪琏珲珞珧珩琊顼珙珥珈珉珀玳玷珑珂珏玟玢玮玑玎骜遨逦逋忝墼垩鄢郦郅郏邳邴剌芈噩孬鬲亘丕卅丐琢赘珠致至殖政正整臻珍盏责枣遭再玉与盂于迂夷一瑶殃焉亚殉邢形型刑下五武吾王玩豌歪瓦屯吞天琐速素死束殊事蚀珊瑟瑞融球琼青琴裂列两璃丽理琅赖来开玖静晋柬歼颊夹棘霍惠妻平琵琶弄囊末灭玫麦玛琉玲琳烈还环画互瑚瑰更副甫敷否珐恶顿毒逗豆靛到殆带歹刺曹残蚕不玻丙表碧逼甭班斑熬敖",
            "H虍瞿龌龊龉龈龇龆龅龃龀訾觜鹾粲虔颦颥鸬瞵瞰瞠瞟瞑瞌睽瞍睿睥睢睨睚睃睇睑睐眸眵眦眭眙眈眇盹眍眄盱砦忐氍觑觇赀攴遽壑矍卣乩丨紫桌卓瞩止睁贞战占瞻眨虞眼眩虚些瞎凸瞳眺瞬睡叔上龋眶肯卡具旧睛睫瞧歧颇频皮盼虐睦目瞄眠眯瞒虑虏卤颅卢龄虎睹督鼎盯点瞪此雌瞅齿柴餐睬步卜彪",
            "I鲨鲎鎏鋈裟淼泶沓懑氅挲尜娑逍灞灏瀵瀹瀛瀣瀚濯濠濞濮濡濂澶澹澧濉濑潺潼潲潸澌澍澉漩漉漪潴潋漶漯滹漕漤潇潆潢溟滂溏滏溴滗溷溻溽溧溥滢漭滠溘溱滟湄渥渲湔湓溆湟溲湫湎湮渫涮渌涫渖淙淝淦渑淠涿渎淞淅淇渚浣浼浠浜涔涓浞涠涞浯涑洳浔浒浏洚洵洮浍洫洎洙洄洇浈浃洌洧洹泾泯泓沱泮泫泺泖泠沲泗泱泸泷沭泔泐沩沆汶汴汩汨沌沔沐沅沣汊汜汔氵喾凼黉鼗渍滓淄滋注洲治滞汁浙兆沼涨掌漳湛沾渣泽澡源渊浴誉渔渝淤游油涌泳淫溢沂液耀漾洋演淹涯汛学汹兴泻泄肖小淆消削湘涎洗汐溪污沃涡温渭潍汪湾洼湍涂汀添涕淘逃滔涛烫淌棠堂汤潭滩汰溯水漱淑湿省渗沈深涉少裳尚赏汕沙涩洒润汝溶染雀渠泅清沁潦粱梁涟沥漓泪涝浪滥澜溃渴浚觉沮举酒浸津洁浇江涧溅渐尖济脊汲激活混浑汇辉浅潜洽泣汽沏柒漆瀑浦婆泼漂澎沛泡潘派湃沤浓泞涅溺泥淖漠沫渺泌没漫满洛沦滦滤潞漏流溜淋劣涣淮滑沪湖洪鸿涸河浩汉汗涵海光灌沽沟港溉涪浮汾沸泛法洱渡洞淀滇涤滴党当淡淬淳滁池澄沉尘澈潮敞常尝测沧泊渤波滨濒澳",
            "J蠼蠛蠊蟾蠓蠖蟮蟠蟪蟛蟀蟑蟓蟋螳螵螬蟥螃螗螭螅螈蟆蟒螨螓蝙蝤蝼蝣蝓螋蝮蝌蝰蝠蝻蝾蝽蜢螂蜿蜷蜩蜱蜴蝈蜾蜮蜥蜞蜻蜣蜉蜍蜊蜈蛸蛑蛘蛟蛴蛞蜓蛐蛳蛭蛲蛱蚴蛏蛉蚯蚱蚺蚰蛎蚵蛄蚶蚓蚪蚣蚧蚝蚬蚋蚍蚨虻虼虮虬煦曩曦曜曛暾暝暧暌暄晷晗晡晖晏晁晔晟昵昱昴曷炅昀昕昃杲昙昊旰旯戥韪暹遢夥勖刂禺昨最蛀蛛蜘照昭早晕曰遇愚蛹映影蝇易蚁曳野蜒蚜星蝎歇晓显贤暇虾晰晤蜗蚊旺晚蛙蜕题剔帅墅竖曙暑是时师肾申蛇晌晒蠕日蛆晴晾量里览蜡昆颗景晶紧鉴坚监晦蛔晃蝗曝暖螟明冕盟昧冒曼蚂螺临蝴虹旱果滚归蛊蛤蜂遏蛾蝶电旦虫匙晨畅昌蝉暴蚌昂暗",
            "K饕鼍黾躞躜躐躔躏躅蹴蹯蹼蹶蹰蹊蹒蹑蹂蹁蹉踱踽踵踹蹀踺踯踣踮踬踟踝踔跽踉跤跻跹跣跸跷跬跆跛跏跎跞跚跗跖跄趺趼趿趵颚鹭鹗戢璐囔嚯嚓嚅噼噻噫噱噤嚆噔噌噜噙噢噍嘬噗嘹噘嘭嘧嘀嗾嘣嘤嘁嘌嘈嘞嗤嗵嗨嗍嗌嗳嗲嗥嗯嗄嗝嗦嗔嗬嗫嗑嘟嗉嗷嗪喙喔喽嗟喑嗖啾喟喁喈喹喱喃嗒喋啜唰唳啷啶啵啖唷唼啐唿啕啁啭啉喵喏啧唪唧唑唏唣唢哳唔哽唠哧唛哞哏哝咤咪咩哜哚哙哌咿咻哕咣呲哔哓咦咧哒咴哂咭哐咝呦呶咄咛咚呤呱呷咔咂吲吣呙呗吡呃呖呔呓呒呋吆吖吒叻叨叩叽叱卟郢嘴足踪啄嘱咒忠盅中只趾吱咋喳噪躁咱郧跃员喻吁咏踊哟吟邑遗叶噎咬唁咽哑呀勋喧嘘嗅兄啸嚣哮响吓吸嘻吴呜嗡吻喂味唯哇唾吐听跳嚏啼蹄踢叹踏蹋唆虽嗽嗣嘶顺吮噬嗜史呻哨啥嗓嚷哩啦喇旷跨哭口吭啃咳咯咖喀鹃踞距咀叫嚼践呛遣器品啤喷呸跑咆趴啪呕哦啮呢呐哪鸣吗嘛骂吕路咙另唤患哗唬呼吼喉哄哼嘿喝呵号嚎喊哈贵跪剐咕跟嘎噶咐吩吠啡鄂跺哆蹲吨叮跌吊叼蹬蹈呆蹿吹串喘川躇踌吃逞呈吵嘲唱蹭踩哺别鄙蹦跋吧叭唉哎啊",
            "L黯黪黥黩黢黟黠黝黜錾袈罾羁罹罱罴罨詈罟罡罘疃畹畛畈畋畎畀町辚辘辏辎辍辋辄辂辁轾轼轺轹轷轸轶轵轳轲轱轭轫椠嬲迦圜圉圊圄囿囹囫囵囡囝囗勰哿罪浊转轴置辙罩辗斩轧暂圆园辕因鸭轩辖胃畏围团图田四思蜀署输软圈囚轻辆连力累困界较轿驾架甲加辑畸回堑黔畦圃毗畔男默墨皿逻罗轮略轰黑贺国辊轨固辅辐罚恩囤畴车边办罢",
            "M髑髌髋髂髅髀髁骼骺骶鹘骷骰骱罂颛鹦殳飚飕飓飑胄觊赙赕赇赈赆赅贻贶遄迥巅嶷嶝嶙嶂嵴嵩嵊嵫嵝嵯嵛嵬崽崴崾嵘崆崞崤崮崦崧崃崂峥峋峤峒峄岷峁岣岫岬岽岢岵岜岚岑岘岈岖岐岍屺岌幡幞幛幔幄帷帼帻帱帔帙帏兕夙罔冂剀刿赚贮周峙帜帧账帐崭赠贼则赃峪屿邮由婴屹鸯央岩崖峡巍网彤同帖贴炭岁髓赎赊赡删山肉冉曲岿凯峻巾见贱几贿幌凰峭嵌岂崎赔帕内帽赂岭骸骨购岗刚冈赋幅凤风峰贩凡帆峨剁朵赌雕典迪丹崔赐幢崇册财贬崩贝败凹盎岸",
            "N鐾羿襞胥疋鹨鹛愍熨擘甓檗璧嬖羼屦屣孱屙屐咫尻遐戕爿懵懔憷憧憔憬慵慊愫愎愀惴愣愕愦愠悴惚惆惘惝悱悻惬悛悌悒悃悝悭悚悖恽恪恂恺恻恹恸怡怿怊怫怩怍怏怛怦怵怙忸忭忪怆怅忾忤忡怄忮怃忏忖忉忄嵋崛奘巽乜昼怔展憎悦羽愉忧翌翼异忆乙已迅恤性惺心忻屑懈习犀惜悟屋慰尉尾惟惋臀屠恬屉惕巳司刷属书疏收恃屎虱尸慎慑屈情怜懒愧快慷慨剧惧局居惊尽届忌悸己悔恢恍惶怯悄恰屏譬屁劈怕懦尿尼恼悯民眉忙慢买屡履戮慌怀恒恨悍憾憨惯怪敢改愤飞发惰恫懂刁殿惦翟悼导蛋惮翠戳丑尺迟忱层惨惭怖避臂壁辟必懊",
            "O糨糗糅糈糍糌糇糁粽粼粞粝粑敉籼黼黻黹灬爝燧燔燠熠熵熳熘煺煸煊煅煨煜煳焱焯焖焓焐烊烨炫炷烀炻炝炖炜炀遴燮郯邺剡籽灼烛粘炸燥灶凿糟业焰炎烟烯熄烷烃糖烁数烧煽熔燃炔料燎粮炼粒类烙烂烤炕糠炬炯粳精烬火烩煌粕炮糯米迷煤炉娄焕糊烘焊糕烽粪粉烦断灯粹粗锤炊炽炒糙灿炳焙爆",
            "P衤窳窭皲襻襦襁褶褫褴褊褛褓褙褡裰裾裨裼褚裱裥裣裎裢裉袼袷裆袢袂衿衽衲衩窨窬窠窦窕窈窆窀穹穸鸩禳禧禚禊禅祺祧祯祠祗祢祚祓祜祛祉祆祀礻邃逭辶謇蹇寰褰寮寤搴骞甯宸宥宓宕宄宀廴郓冥冢冖剜祖宗字祝宙窒之寨窄宅宰灾冤裕寓宇寅宜揖窑宴穴宣袖写宵祥宪窝宛完袜褪突袒它宿宋守视室实审神社衫赛塞褥冗容裙穷寝寥帘礼牢窥宽裤窟寇空客军究窘襟窖家寂寄祸豁窃窍祁祈袍农宁寞幂密蜜寐裸禄窿宦宏鹤褐罕寒害冠官褂寡宫割富袱福额定祷窜窗穿初宠衬察补宾被宝袄案安",
            "Q鳢鳟鳝鳜鳙鳗鳕鳔鳓鳐鳏鳎鳍鳋鳊鳇鳆鳅鳄鲽鲼鲻鲺鲷鲶鲵鲴鲳鲲鲱鲰鲮鲭鲫鲩鲧鲦鲥鲣鲢鲡鲠鲟鲛鲚鲕鲔鲒鲑鲐鲋稣鲈鲇鲆鲅鲂鱿鑫觯觫觥觚觞觖斛袅鹱鸱鸲锺镳镲镱镯镬镫镪镩镨镧镦镥镤镢镡镝镟镞镛镙镘镗镖镔镓镒镏镎镌镉镆镅镄锵镂锿锾锼锸锷锶锴锲锱锬锩锫锪锢锟锞锝锛锘锖锕锔锓锒锏锎锍锊锉锇锆锂锃铿铽铼铹铷铵铴铳铯铮铫铩铪铨铧铥铤铢铠铟铞铛铘铙铗铖铕铒铑铐铎铍铌铋铊铉铈铄钿钽钼钺钹钸钷钶钴钲钰钯钬钭钪钫钤钣钜钛钚钕钗钔钐钏钍钌钊钋钇钆钅盥眢欷肴橥桀枭玺邂遛逖迩馕馔馓馑馐馍馊馇馄馀饽饷饴饬饫饪饩饨饧饣夤飧舛獾獯獬獠獗獍獐猱猸猬猥猹猢猕猝猞猊猡猓猗狻狺猃狳猁狷狴狲狩狯狨狒狍狎狁狃犸犷犴犰犭弑鬯劬奂刍郗郇郄邸邬凫匐訇匍勹刎刈氐爻丌钻邹锥铸猪皱钟炙争狰镇针锗詹铡匀钥怨猿鸳狱鱼犹铀迎印饮银逸铱旬锈匈凶猩锌蟹销象镶馅鲜锨狭铣夕希锡勿乌钨危外鸵兔铜铁锑獭锁饲氏饰狮勺煞刹杀色鳃锐饶然卿镣链镰吏鲤狸镭乐狼馈狂钧句锯狙灸久镜鲸锦金解饺角狡铰饯键钾急饥昏钦锹欠钳钱铅钎铺刨钮狞镍镊鸟馁钠名铭勉免猛锰镁贸卯铆锚猫馒锣卵铝鲁留馏铃猎猾狐忽猴狠锅龟逛馆够狗勾钩铬镐钢钙负孵锋饭犯钒饵尔儿饿多钝锻镀独兜锭钉钓甸狄岛错匆触雏锄钞猖铲馋猜铂钵狈钡鲍饱包镑",
            "R魑魍魈魉魃魅踅絷罅缶蜇颀鹎鸷瓞皤皓皎皈敫氲氪氤氩氡氚氙氘氕搿掰贽遑逅攮攥攉擢擤擗擐擀撺撙撸撷摺摭撄摞搡搦搌搠搛搋摅掾揆摒揎揞揄揿揠揸揲掼掮捩掊掬捭掴掎捺捱揶掭捃捋挹拶挢拮拗拚拊抻抟扪扌郫邾卮揍拙捉撞撰拽爪抓拄朱质制掷挚指执拯挣振蛰哲折找招摘扎择皂攒岳援拥殷抑掖摇邀氧扬掩押欣卸携挟掀舞捂握挝皖挽挖拓托拖推投捅挺挑提掏搪探摊抬挞所损擞搜撕拴摔抒授手势逝誓拭拾失摄捎擅扫搔撒揉扔热扰攘缺泉邱丘氰氢擒撂撩擂捞揽拦拉扩括捆魁挎扣抠控拷抗扛看揩掘抉攫撅捐据拒拘揪近斤捷接揭搅捡拣技挤挥皇撬抢扦掐气扑迫魄乒拼撇披批捧抨抛乓排拍爬挪扭牛拧捏捻撵年拈拟挠氖拇抹摸抿描抡掠氯掳搂拢拎换护后捍撼氦鬼罐拐挂瓜拱搁搞皋缸抚氟拂扶氛返反扼掇遁盾抖迭掉垫掂抵的捣挡氮掸担打搭挫措搓撮摧捶揣搐抽斥持撑掣撤扯抄掺搀拆搽插操擦捕帛搏拨播兵摈膘卑报抱拌扮扳搬拜摆白把拔扒捌翱按氨皑挨",
            "S醺醴醵醯醮醭醪醣醢醑醍醐醅醌酹酴酲酾酽酯酩酰酡酢酤酏酎酐酊覃皙懋檫檩檐檑橼橘樨樽橹檎樵橛樾橄槲樘樗槭樯槿榍槠榕槟槁榱槔榭榫榻榧榛楹楣楦榉槎榈榇槌椴楸榀楫榄楝楂楠椹楱椐棣楗椁椋棰椤棹椟棼楮棂桫梓桷桴梏梵栩桉桧桁桦桕栝梃桤桄桢桎桡桠栳栲柽柁栎柢枸柃栀柝枳柚枵柙栌枰柩栊柘栉柰杼杷枋枞枨杵枧枘杳杪枇枥杩杈杞杓杌鄄剽柞醉棕酌椎桩柱株植枝枕甄杖樟栈榨栅札酝榆酉樱椅椰要样杨酗朽杏醒械楔校橡想相檄西析梧桅枉椭桶酮桐梯桃檀酞梭酸粟酥松栓树述术梳枢柿梢杉森榷醛权栗李楞棱酪榔栏婪框酷枯可棵柯楷禁杰桔酵椒槛检贾枷极机桥橇枪棋栖朴票瓢飘棚配攀柠酿木模棉醚梦檬酶梅枚麓楼柳榴林桓槐横核杭酣棍柜桂棺构梗根格歌哥杠柑杆概覆枫焚酚樊杜栋顶丁档村醋醇椿椽楚橱酬橙郴查槽材柄彬标本杯棒榜梆板柏",
            "T齄鼾鼽黧鳘雒艨艟艚艏艋艉艄舾舴舳舻舸舫舨舯舭舣舢舡衄臬籀籁簸簦簪簟簋簖簏篼篾簌篪篦篥篚篝篌篁篑箴箫箢箜箪箅箨箝箬箸箧箦筱筲筢筻筮筠筝筌筵筅筚筘笞笾笳笤笥笠笱笮笙笪笸筇笏笫笊笕笄笃笈竽竺舐螽鹄鸹穰馥黏穑稷稹稔稞稂稃嵇稆秫秣秭秕雉矬矧眚憩愆歃牖牒牍攵氆氇毽毳毪犒犏犍犋犄牿牾牯牦牝昝榘逶逄迤迮迕夂衢徼徵徭徨徜徙徕後徉徇徂彷彳岙鄱郜籴汆劓睾毓胤囟夭乇丿纂租自篆筑竹舟重种稚秩智知征毡乍怎造赞粤御禹釉役移秧衍延衙循熏血选徐秀行衅笑向箱香舷衔先系悉息稀牺务物午我稳魏委微往颓徒秃透筒艇廷条舔甜特躺毯笋穗算艘私税黍释适矢剩升牲甥生身射舌稍扇筛入壬躯秋利篱黎犁梨篮筐筷科靠矩咎径筋街秸矫舰箭简笺稼季籍箕积稽秽徽簧乔签迁千迄乞片篇篷磐盘徘牌穆牧牡敏秒秘每么毛箩乱律篓笼徊乎衡很和禾航管乖刮箍躬各告稿篙秆竿复符逢繁翻番乏筏鹅舵躲短犊冬丢第笛敌等得德稻待答篡簇囱辞垂船处臭筹愁稠秤惩程乘称彻长策舱簿舶箔秉币彼笔鼻笨惫备版般稗笆奥矮",
            "U鲞蹩翦粢羲羰羯羧羟羝竦翊癯癫癖癜癔癞癍瘳瘾癃瘵瘿瘰瘭癀瘠瘢瘼瘛瘙瘕瘘瘥瘊瘗瘌瘅瘀瘐痿痼痱瘃痧痫痤痦痨痣痍痖痂痃疰疱痄疸疴疳疣疬疝疠疖疔疒鹣鹚鹈鹇蠲戆恣恙飒歆旮甑瓿猷槊桊孳妾遒丬阚阙阗阖阕阒阏阍阌阋阊阈阆阄阃闾闼闶闵闳闱闫闩啻鄯鄣邶凇冼冽冱冫衮兖夔冁馘遵尊总姿资咨兹着准状壮妆装痔郑症疹瘴彰章站闸曾韵阅痈音益毅意疫冶养痒羊疡彦沿阎颜阉丫癣羞新辛效翔羡闲问闻瘟头痛童剃誊疼痰瘫遂塑送朔兽瘦首韶商善闪闰瘸券拳痊酋亲疗凉立痢冷兰阑辣阔况竣决卷眷疽疚净竞竟靖痉疥竭郊交酱奖桨浆将将姜减剪兼煎间冀疾羌歉前凄普剖瓶瞥痞疲旁叛判疟凝逆闹闽闷门美六瘤凌羚凛豢痪痕阂闺关羹阁疙羔赣盖冯疯阀兑端痘斗冻凋奠递弟帝盗道郸单瘩瘁凑次瓷慈疵闯疮冲痴阐产差部并病冰瘪憋鳖辫辩辨弊敝闭痹迸背北半瓣疤癌",
            "V鼷鼹鼯鼬鼢暨艮舄舁臾鸠聿肀邕甾巛驽孥孀嬷嬗嬉嫜嫘嫦嫖嫱嫣媸嫔嫒媲嫫媾婷媛媪胬婵婢娼婕婊婧婀娓娣娴娲娉娌姹姘姣姝娆娅姗妯妲姒妤妞妫姊妗妣妪妩妍妃妁弩彐邋逯帑叟劭馗帚召杂娱尹姻姨姚妖巡寻婿絮旭姓嫌媳婉丸娃退迢她肃恕鼠始婶娠邵嫂如妊刃忍群隶姥恳垦郡君娟舅臼九姐剿娇建奸嫁妓既嫉即姬婚毁女怒努奴娘妮嫩奶娜那姆妙娩媚妹媒妈录灵好姑妇妨娥妒嫡刀逮巢剥",
            "W黛雠隽隼隹翕翎衾颔颌鹪鹆鸺畲龛恁爨煲歙毹牮觎瓴戗璺岱坌郐兮龠俎佥佘氽仝儋儇僮僦僬僭儆僖傺傩傧傥偻偬偎偈偕偃偾倨倥倌倜俾倭倮倏倬俳偌倩俸俟俑俜俣俚俅俪俨俦侔侬佼侪佻佾侏侃侉侑佴佶伽伲佗佟佝佚攸佧佞伫伉伧伥仵佤伢仳伛仞仫仡仨仂仉仃亻劁坐作做佐仔追住众仲侄值侦仗债欲愈逾俞余舆佑悠优佣亿倚仪伊依爷仰佯叙修休信斜像仙侠侮伍瓮翁位伪伟途偷停体倘贪他僳俗颂怂耸似伺舒售侍仕使食什伸舍伤傻僧伞儒仍任人仁全倾禽侵僚敛俩俐例傈儡佬傀侩俊倔倦俱仅今介借侥焦僵剑健件俭价假佳祭伎集货伙会俏侨仟企仆凭贫偏僻盆佩偶您念你倪拿命们仑伦侣令领伶赁鳞邻化华候侯盒合何含刽癸谷估公供个鸽父阜付傅斧釜俯俘伏佛忿份分仿伐俄段侗爹佃低凳登倒但袋贷代傣催促丛从创传储仇侈倡偿豺岔侧仓伯饼便倍堡保傍伴颁佰爸八傲俺",
            "X飨糸蠡颍鸶鸨犟畿幺缵缳缲缱缰缯缭缬缫缪缧缦缥缤缣缢缡缟缛缜缙缗缒缑缏缌缋缈缇缃缂缁绾绻绺绶缍绲绱绯绮绫绨绡绠绛绗绔绐绌绋绉绂绁绀纾纰纭纩纨纥纣纡纟鬻弼艴弭弪彘彖辔匕组纵综缀粥终纸旨织张绽约缘幼幽颖缨引绎肄彝疑绚续绪绣乡线弦纤细毋纹纬维统绦缩绥丝绳绅绍缮纱弱绒纫绕顷练缆绝绢纠经结皆绞缴疆缄纪继级缉绩绘强纽纳母缅绵弥络纶绿缕幻缓弧红弘贯弓给纲缚弗缝纷费纺缎缔弹绰纯绸弛缠编毖毙毕比绷绑绊",
            "Y麟麝鏖麒麋麈麇麂縻麾麽饔銮綮翩颏颃鹫鹧鹑鸾憝扉扈扃戽戾旖旒旎旌旃旄旆於斓齑膂肓昶栾娈膺廪廨廛廑廒赓庳庾庵庹庠庥庖庋庑庀奕弈壅塾劾邡邙邝谶谵谳谲谯谮谫谪谧谥谡谠谟谝谘谛谙谖谕谔谒谑谏谌谇谄谂谀诿诼诹诶诳诰诮诩诨诤诠诟诜诙诘诖诔诓诒诎诏诋诃诂讷讵讴讪讧讦讠羸蠃嬴禀裒脔亵袤亳亠丶座诅族卒谆庄主诛诸诌州衷证诊这遮肇斋诈育语诱永雍庸赢应鹰译谊议诣义裔亦衣夜谣谚言讶讯训询玄旋畜序许谢谐享详襄席误诬紊文谓为妄忘望亡弯庭亭讨唐谈谭诉诵讼说谁衰庶熟孰试市识诗施设认让瓤庆请廖谅亮良恋廉离朗郎廊谰廓库课刻亢康诀就京谨诫讲肩记计剂讥迹诲讳谎敲谴谦讫弃启旗齐谱评烹庞诺亩谋魔摩磨谬庙谜糜靡氓盲谩蛮麻论孪挛峦率旅鹿庐刘吝话户亨毫豪亥裹郭诡广雇庚膏高该讣腐府讽废诽放访房方讹敦度读订谍调店底诞词床充诚颤谗诧斌遍卞变扁庇褒谤哀",
            "！@#%…&*（）—；：”’？《》，。、~={}','|"};
        /// <summary>
        /// 获取拼音码
        /// </summary>
        /// <param name="sInputStr"></param>
        /// <returns></returns>
        public static string GetPYCode(string sInputStr)
        {
            if (sInputStr == null)
                return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            sInputStr = sInputStr.Replace(" ", "");
            if (string.IsNullOrEmpty(sInputStr))
                return string.Empty;

            foreach (Char c in sInputStr)
            {
                int asciicode = (int)c;
                //如果是254以内的ASCII 表示是西文字母和字符，直接显示，无需翻译
                if (asciicode >= 1 && asciicode <= 254)
                {
                    stringBuilder.Append(c);
                }
                else
                {
                    for (int i = 0; i < PY.Length; i++)
                    {
                        if (PY[i].IndexOf(c) > 0)
                        {
                            stringBuilder.Append(PY[i][0]);
                            break;
                        }
                    }
                }
            }

            return stringBuilder.ToString();
        }
        /// <summary>
        /// 获取五笔码
        /// </summary>
        /// <param name="sInputStr"></param>
        /// <returns></returns>
        public static string GetWBCode(string sInputStr)
        {
            if (sInputStr == null)
                return string.Empty;

            StringBuilder result = new StringBuilder();
            //用char循环取得每一个String的 字符
            for (int i = 0; i < sInputStr.Length; i++)
            {
                char temp1 = sInputStr[i];
                int asciicode = (int)temp1;
                //如果是254以内的ASCII 表示是西文字母和字符，直接显示，无需翻译
                if (asciicode >= 1 && asciicode <= 254)
                {
                    result.Append(temp1);
                }
                else
                {
                    //循环遍历汉字五笔的字库（按照五笔首字符字符分组）
                    for (int j = 0; j < WB.Length; j++)
                    {
                        char[] dbTmp = WB[j].ToCharArray();
                        //循环遍历每个英文字母的字库
                        for (int k = 1; k < dbTmp.Length; k++)
                        {
                            //找到
                            if ((int)temp1 == (int)dbTmp[k])
                            {
                                //如果在WB最后一行，表明是中文标点符号，直接显示，否则显示对应的五笔首字母(该行的第1个字符)
                                if (j == WB.Length - 1)
                                {
                                    result.Append(dbTmp[k]);
                                }
                                else
                                {
                                    result.Append(dbTmp[0]);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            return result.ToString();
        }
    }
}