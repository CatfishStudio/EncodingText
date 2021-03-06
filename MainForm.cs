﻿/*
 * Сделано в SharpDevelop.
 * Пользователь: SOMOV
 * Дата: 16.11.2014
 * Время: 18:17
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EncodingText
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private String[,] table_DecHex = {{"32","20"},{"33","21"},{"34","22"},{"35","23"},{"36","24"},{"37","25"},{"38","26"},{"39","27"},
			{"40","28"},{"41","29"},{"42","2A"},{"43","2B"},{"44","2C"},{"45","2D"},{"46","2E"},{"47","2F"},{"48","30"},{"49","31"},
			{"50","32"},{"51","33"},{"52","34"},{"53","35"},{"54","36"},{"55","37"},{"56","38"},{"57","39"},{"58","3A"},{"59","3B"},
			{"60","3C"},{"61","3D"},{"62","3E"},{"63","3F"},{"64","40"},{"65","41"},{"66","42"},{"67","43"},{"68","44"},{"69","45"},
			{"70","46"},{"71","47"},{"72","48"},{"73","49"},{"74","4A"},{"75","4B"},{"76","4C"},{"77","4D"},{"78","4E"},{"79","4F"},
			{"80","50"},{"81","51"},{"82","52"},{"83","53"},{"84","54"},{"85","55"},{"86","56"},{"87","57"},{"88","58"},{"89","59"},
			{"90","5A"},{"91","5B"},{"92","5C"},{"93","5D"},{"94","5E"},{"95","5F"},{"96","60"},{"97","61"},{"98","62"},{"99","63"},
			{"100","64"},{"101","65"},{"102","66"},{"103","67"},{"104","68"},{"105","69"},{"106","6A"},{"107","6B"},{"108","6C"},{"109","6D"},
			{"110","6E"},{"111","6F"},{"112","70"},{"113","71"},{"114","72"},{"115","73"},{"116","74"},{"117","75"},{"118","76"},{"119","77"},
			{"120","78"},{"121","79"},{"122","7A"},{"123","7B"},{"124","7C"},{"125","7D"},{"126","7E"},{"127","7F"},{"128","80"},{"129","81"},
			{"130","82"},{"131","83"},{"132","84"},{"133","85"},{"134","86"},{"135","87"},{"136","88"},{"137","89"},{"138","8A"},{"139","8B"},
			{"140","8C"},{"141","8D"},{"142","8E"},{"143","8F"},{"144","90"},{"145","91"},{"146","92"},{"147","93"},{"148","94"},{"149","95"},
			{"150","96"},{"151","97"},{"152","98"},{"153","99"},{"154","9A"},{"155","9B"},{"156","9C"},{"157","9D"},{"158","9E"},{"159","9F"},
			{"160","A0"},{"161","A1"},{"162","A2"},{"163","A3"},{"164","A4"},{"165","A5"},{"166","A6"},{"167","A7"},{"168","A8"},{"169","A9"},
			{"170","AA"},{"171","AB"},{"172","AC"},{"173","AD"},{"174","AE"},{"175","AF"},{"176","B0"},{"177","B1"},{"178","B2"},{"179","B3"},
			{"180","B4"},{"181","B5"},{"182","B6"},{"183","B7"},{"184","B8"},{"185","B9"},{"186","BA"},{"187","BB"},{"188","BC"},{"189","BD"},
			{"190","BE"},{"191","BF"},{"192","C0"},{"193","C1"},{"194","C2"},{"195","C3"},{"196","C4"},{"197","C5"},{"198","C6"},{"199","C7"},
			{"200","C8"},{"201","C9"},{"202","CA"},{"203","CB"},{"204","CC"},{"205","CD"},{"206","CE"},{"207","CF"},{"208","D0"},{"209","D1"},
			{"210","D2"},{"211","D3"},{"212","D4"},{"213","D5"},{"214","D6"},{"215","D7"},{"216","D8"},{"217","D9"},{"218","DA"},{"219","DB"},
			{"220","DC"},{"221","DD"},{"222","DE"},{"223","DF"},{"224","E0"},{"225","E1"},{"226","E2"},{"227","E3"},{"228","E4"},{"229","E5"},
			{"230","E6"},{"231","E7"},{"232","E8"},{"233","E9"},{"234","EA"},{"235","EB"},{"236","EC"},{"237","ED"},{"238","EE"},{"239","EF"},
			{"240","F0"},{"241","F1"},{"242","F2"},{"243","F3"},{"244","F4"},{"245","F5"},{"246","F6"},{"247","F7"},{"248","F8"},{"249","F9"},
			{"250","FA"},{"251","FB"},{"252","FC"},{"253","FD"},{"254","FE"},{"255","FF"}
		};
		
		private String[,] table_ASCII = {{" ","32","20"},{"!","33","21"},{"\"","34","22"},
			{"#","35","23"},{"$","36","24"},{"%","37","25"},{"&","38","26"},{"'","39","27"},
			{"(","40","28"},{")","41","29"},{"*","42","2A"},{"+","43","2B"},{",","44","2C"},
			{"-","45","2D"},{".","46","2E"},{"/","47","2F"},{"0","48","30"},{"1","49","31"},
			{"2","50","32"},{"3","51","33"},{"4","52","34"},{"5","53","35"},{"6","54","36"},
			{"7","55","37"},{"8","56","38"},{"9","57","39"},{":","58","3A"},{";","59","3B"},
			{"<","60","3C"},{"=","61","3D"},{">","62","3E"},{"?","63","3F"},{"@","64","40"},
			{"A","65","41"},{"B","66","42"},{"C","67","43"},{"D","68","44"},{"E","69","45"},
			{"F","70","46"},{"G","71","47"},{"H","72","48"},{"I","73","49"},{"J","74","4A"},
			{"K","75","4B"},{"L","76","4C"},{"M","77","4D"},{"N","78","4E"},{"O","79","4F"},
			{"P","80","50"},{"Q","81","51"},{"R","82","52"},{"S","83","53"},{"T","84","54"},
			{"U","85","55"},{"V","86","56"},{"W","87","57"},{"X","88","58"},{"Y","89","59"},
			{"Z","90","5A"},{"[","91","5B"},{"\\","92","5C"},{"]","93","5D"},{"^","94","5E"},
			{"_","95","5F"},{"`","96","60"},{"a","97","61"},{"b","98","62"},{"c","99","63"},
			{"d","100","64"},{"e","101","65"},{"f","102","66"},{"g","103","67"},{"h","104","68"},
			{"i","105","69"},{"j","106","6A"},{"k","107","6B"},{"l","108","6C"},{"m","109","6D"},
			{"n","110","6E"},{"o","111","6F"},{"p","112","70"},{"q","113","71"},{"r","114","72"},
			{"s","115","73"},{"t","116","74"},{"u","117","75"},{"v","118","76"},{"w","119","77"},
			{"x","120","78"},{"y","121","79"},{"z","122","7A"},{"{","123","7B"},{"|","124","7C"},
			{"}","125","7D"},{"~","126","7E"},{"■","127","7F"},
			{"Ç","128","80"},{"ü","129","81"},{"é","130","82"},{"â","131","83"},{"ä","132","84"},
			{"à","133","85"},{"å","134","86"},{"ç","135","87"},{"ê","136","88"},{"ë","137","89"},
			{"è","138","8A"},{"ï","139","8B"},{"î","140","8C"},{"ì","141","8D"},{"Ä","142","8E"},
			{"Å","143","8F"},{"É","144","90"},{"æ","145","91"},{"Æ","146","92"},{"ô","147","93"},
			{"ö","148","94"},{"ò","149","95"},{"û","150","96"},{"ù","151","97"},{"ÿ","152","98"},
			{"Ö","153","99"},{"Ü","154","9A"},{"ø","155","9B"},{"£","156","9C"},{"Ø","157","9D"},
			{"×","158","9E"},{"ƒ","159","9F"},{"á","160","A0"},{"í","161","A1"},{"ó","162","A2"},
			{"ú","163","A3"},{"ñ","164","A4"},{"Ñ","165","A5"},{"ª","166","A6"},{"º","167","A7"},
			{"¿","168","A8"},{"®","169","A9"},{"¬","170","AA"},{"½","171","AB"},{"¼","172","AC"},
			{"¡","173","AD"},{"«","174","AE"},{"»","175","AF"},{"░","176","B0"},{"▒","177","B1"},
			{"▓","178","B2"},{"│","179","B3"},{"┤","180","B4"},{"Á","181","B5"},{"Â","182","B6"},
			{"À","183","B7"},{"©","184","B8"},{"╣","185","B9"},{"║","186","BA"},{"╗","187","BB"},
			{"╝","188","BC"},{"¢","189","BD"},{"¥","190","BE"},{"┐","191","BF"},{"└","192","C0"},
			{"┴","193","C1"},{"┬","194","C2"},{"├","195","C3"},{"─","196","C4"},{"┼","197","C5"},
			{"ã","198","C6"},{"Ã","199","C7"},{"╚","200","C8"},{"╔","201","C9"},{"╩","202","CA"},
			{"╦","203","CB"},{"╠","204","CC"},{"═","205","CD"},{"╬","206","CE"},{"¤","207","CF"},
			{"ð","208","D0"},{"Ð","209","D1"},{"Ê","210","D2"},{"Ë","211","D3"},{"È","212","D4"},
			{"ı","213","D5"},{"Í","214","D6"},{"Î","215","D7"},{"Ï","216","D8"},{"┘","217","D9"},
			{"┌","218","DA"},{"█","219","DB"},{"▄","220","DC"},{"¦","221","DD"},{"Ì","222","DE"},
			{"▀","223","DF"},{"Ó","224","E0"},{"ß","225","E1"},{"Ô","226","E2"},{"Ò","227","E3"},
			{"õ","228","E4"},{"Õ","229","E5"},{"µ","230","E6"},{"þ","231","E7"},{"Þ","232","E8"},
			{"Ú","233","E9"},{"Û","234","EA"},{"Ù","235","EB"},{"ý","236","EC"},{"Ý","237","ED"},
			{"¯","238","EE"},{"´","239","EF"},{"≡","240","F0"},{"±","241","F1"},{"‗","242","F2"},
			{"¾","243","F3"},{"¶","244","F4"},{"§","245","F5"},{"÷","246","F6"},{"¸","247","F7"},
			{"°","248","F8"},{"¨","249","F9"},{"·","250","FA"},{"¹","251","FB"},{"³","252","FC"},
			{"²","253","FD"},{"■","254","FE"},{"","255","FF"}
		};
		
		
		private String[,] table_MSDOS = {{" ","32","20"},{"!","33","21"},{"\"","34","22"},
			{"#","35","23"},{"$","36","24"},{"%","37","25"},{"&","38","26"},{"'","39","27"},
			{"(","40","28"},{")","41","29"},{"*","42","2A"},{"+","43","2B"},{",","44","2C"},
			{"-","45","2D"},{".","46","2E"},{"/","47","2F"},{"0","48","30"},{"1","49","31"},
			{"2","50","32"},{"3","51","33"},{"4","52","34"},{"5","53","35"},{"6","54","36"},
			{"7","55","37"},{"8","56","38"},{"9","57","39"},{":","58","3A"},{";","59","3B"},
			{"<","60","3C"},{"=","61","3D"},{">","62","3E"},{"?","63","3F"},{"@","64","40"},
			{"A","65","41"},{"B","66","42"},{"C","67","43"},{"D","68","44"},{"E","69","45"},
			{"F","70","46"},{"G","71","47"},{"H","72","48"},{"I","73","49"},{"J","74","4A"},
			{"K","75","4B"},{"L","76","4C"},{"M","77","4D"},{"N","78","4E"},{"O","79","4F"},
			{"P","80","50"},{"Q","81","51"},{"R","82","52"},{"S","83","53"},{"T","84","54"},
			{"U","85","55"},{"V","86","56"},{"W","87","57"},{"X","88","58"},{"Y","89","59"},
			{"Z","90","5A"},{"[","91","5B"},{"\\","92","5C"},{"]","93","5D"},{"^","94","5E"},
			{"_","95","5F"},{"`","96","60"},{"a","97","61"},{"b","98","62"},{"c","99","63"},
			{"d","100","64"},{"e","101","65"},{"f","102","66"},{"g","103","67"},{"h","104","68"},
			{"i","105","69"},{"j","106","6A"},{"k","107","6B"},{"l","108","6C"},{"m","109","6D"},
			{"n","110","6E"},{"o","111","6F"},{"p","112","70"},{"q","113","71"},{"r","114","72"},
			{"s","115","73"},{"t","116","74"},{"u","117","75"},{"v","118","76"},{"w","119","77"},
			{"x","120","78"},{"y","121","79"},{"z","122","7A"},{"{","123","7B"},{"|","124","7C"},
			{"}","125","7D"},{"~","126","7E"},{"■","127","7F"},
			
			{"А","128","80"},{"Б","129","81"},{"В","130","82"},{"Г","131","83"},{"Д","132","84"},
			{"Е","133","85"},{"Ж","134","86"},{"З","135","87"},{"И","136","88"},{"Й","137","89"},
			{"К","138","8A"},{"Л","139","8B"},{"М","140","8C"},{"Н","141","8D"},{"О","142","8E"},
			{"П","143","8F"},{"Р","144","90"},{"С","145","91"},{"Т","146","92"},{"У","147","93"},
			{"Ф","148","94"},{"Х","149","95"},{"Ц","150","96"},{"Ч","151","97"},{"Ш","152","98"},
			{"Щ","153","99"},{"Ъ","154","9A"},{"Ы","155","9B"},{"Ь","156","9C"},{"Э","157","9D"},
			{"Ю","158","9E"},{"Я","159","9F"},{"а","160","A0"},{"б","161","A1"},{"в","162","A2"},
			{"г","163","A3"},{"д","164","A4"},{"е","165","A5"},{"ж","166","A6"},{"з","167","A7"},
			{"и","168","A8"},{"й","169","A9"},{"к","170","AA"},{"л","171","AB"},{"м","172","AC"},
			{"н","173","AD"},{"о","174","AE"},{"п","175","AF"},
			{"░","176","B0"},{"▒","177","B1"},{"▓","178","B2"},{"│","179","B3"},{"┤","180","B4"},
			{"╡","181","B5"},{"╢","182","B6"},{"╖","183","B7"},{"╕","184","B8"},{"╣","185","B9"},
			{"║","186","BA"},{"╗","187","BB"},{"╝","188","BC"},{"╜","189","BD"},{"╛","190","BE"},
			{"┐","191","BF"},{"└","192","C0"},{"┴","193","C1"},{"┬","194","C2"},{"├","195","C3"},
			{"─","196","C4"},{"┼","197","C5"},{"╞","198","C6"},{"╟","199","C7"},{"╚","200","C8"},
			{"╔","201","C9"},{"╩","202","CA"},{"╦","203","CB"},{"╠","204","CC"},{"═","205","CD"},
			{"╬","206","CE"},{"╧","207","CF"},{"╨","208","D0"},{"╤","209","D1"},{"╥","210","D2"},
			{"╙","211","D3"},{"╘","212","D4"},{"╒","213","D5"},{"╓","214","D6"},{"╫","215","D7"},
			{"╪","216","D8"},{"┘","217","D9"},{"┌","218","DA"},{"█","219","DB"},{"▄","220","DC"},
			{"▌","221","DD"},{"▐","222","DE"},{"▀","223","DF"},
			{"р","224","E0"},{"с","225","E1"},{"т","226","E2"},{"у","227","E3"},{"ф","228","E4"},
			{"х","229","E5"},{"ц","230","E6"},{"ч","231","E7"},{"ш","232","E8"},{"щ","233","E9"},
			{"ъ","234","EA"},{"ы","235","EB"},{"ь","236","EC"},{"э","237","ED"},{"ю","238","EE"},
			{"я","239","EF"},{"Ё","240","F0"},{"ё","241","F1"},{"Є","242","F2"},{"є","243","F3"},
			{"Ї","244","F4"},{"ї","245","F5"},{"Ў","246","F6"},{"ў","247","F7"},{"°","248","F8"},
			{"∙","249","F9"},{"·","250","FA"},{"√","251","FB"},{"№","252","FC"},{"¤","253","FD"},
			{"■","254","FE"},{"","255","FF"}
		};
		
		private String[,] table_Windows1251 = {{" ","32","20"},{"!","33","21"},{"\"","34","22"},
			{"#","35","23"},{"$","36","24"},{"%","37","25"},{"&","38","26"},{"'","39","27"},
			{"(","40","28"},{")","41","29"},{"*","42","2A"},{"+","43","2B"},{",","44","2C"},
			{"-","45","2D"},{".","46","2E"},{"/","47","2F"},{"0","48","30"},{"1","49","31"},
			{"2","50","32"},{"3","51","33"},{"4","52","34"},{"5","53","35"},{"6","54","36"},
			{"7","55","37"},{"8","56","38"},{"9","57","39"},{":","58","3A"},{";","59","3B"},
			{"<","60","3C"},{"=","61","3D"},{">","62","3E"},{"?","63","3F"},{"@","64","40"},
			{"A","65","41"},{"B","66","42"},{"C","67","43"},{"D","68","44"},{"E","69","45"},
			{"F","70","46"},{"G","71","47"},{"H","72","48"},{"I","73","49"},{"J","74","4A"},
			{"K","75","4B"},{"L","76","4C"},{"M","77","4D"},{"N","78","4E"},{"O","79","4F"},
			{"P","80","50"},{"Q","81","51"},{"R","82","52"},{"S","83","53"},{"T","84","54"},
			{"U","85","55"},{"V","86","56"},{"W","87","57"},{"X","88","58"},{"Y","89","59"},
			{"Z","90","5A"},{"[","91","5B"},{"\\","92","5C"},{"]","93","5D"},{"^","94","5E"},
			{"_","95","5F"},{"`","96","60"},{"a","97","61"},{"b","98","62"},{"c","99","63"},
			{"d","100","64"},{"e","101","65"},{"f","102","66"},{"g","103","67"},{"h","104","68"},
			{"i","105","69"},{"j","106","6A"},{"k","107","6B"},{"l","108","6C"},{"m","109","6D"},
			{"n","110","6E"},{"o","111","6F"},{"p","112","70"},{"q","113","71"},{"r","114","72"},
			{"s","115","73"},{"t","116","74"},{"u","117","75"},{"v","118","76"},{"w","119","77"},
			{"x","120","78"},{"y","121","79"},{"z","122","7A"},{"{","123","7B"},{"|","124","7C"},
			{"}","125","7D"},{"~","126","7E"},{"■","127","7F"},
			
			{"Ђ","128","80"},{"Ѓ","129","81"},{"‚","130","82"},{"ѓ","131","83"},{"„","132","84"},
			{"…","133","85"},{"†","134","86"},{"‡","135","87"},{"€","136","88"},{"‰","137","89"},
			{"Љ","138","8A"},{"‹","139","8B"},{"Њ","140","8C"},{"Ќ","141","8D"},{"Ћ","142","8E"},
			{"Џ","143","8F"},{"ђ","144","90"},{"‘","145","91"},{"’","146","92"},{"“","147","93"},
			{"”","148","94"},{"•","149","95"},{"–","150","96"},{"—","151","97"},{"","152","98"},
			{"™","153","99"},{"љ","154","9A"},{"›","155","9B"},{"њ","156","9C"},{"ќ","157","9D"},
			{"ћ","158","9E"},{"џ","159","9F"},{"█","160","A0"},{"Ў","161","A1"},{"ў","162","A2"},
			{"Ј","163","A3"},{"¤","164","A4"},{"Ґ","165","A5"},{"¦","166","A6"},{"§","167","A7"},
			{"Ё","168","A8"},{"©","169","A9"},{"Є","170","AA"},{"«","171","AB"},{"¬","172","AC"},
			{"▄","173","AD"},{"®","174","AE"},{"Ї","175","AF"},{"°","176","B0"},{"±","177","B1"},
			{"І","178","B2"},{"і","179","B3"},{"ґ","180","B4"},{"µ","181","B5"},{"¶","182","B6"},
			{"·","183","B7"},{"ё","184","B8"},{"№","185","B9"},{"є","186","BA"},{"»","187","BB"},
			{"ј","188","BC"},{"Ѕ","189","BD"},{"ѕ","190","BE"},{"ї","191","BF"},{"А","192","C0"},
			{"Б","193","C1"},{"В","194","C2"},{"Г","195","C3"},{"Д","196","C4"},{"Е","197","C5"},
			{"Ж","198","C6"},{"З","199","C7"},{"И","200","C8"},{"Й","201","C9"},{"К","202","CA"},
			{"Л","203","CB"},{"М","204","CC"},{"Н","205","CD"},{"О","206","CE"},{"П","207","CF"},
			{"Р","208","D0"},{"С","209","D1"},{"Т","210","D2"},{"У","211","D3"},{"Ф","212","D4"},
			{"Х","213","D5"},{"Ц","214","D6"},{"Ч","215","D7"},{"Ш","216","D8"},{"Щ","217","D9"},
			{"Ъ","218","DA"},{"Ы","219","DB"},{"Ь","220","DC"},{"Э","221","DD"},{"Ю","222","DE"},
			{"Я","223","DF"},{"а","224","E0"},{"б","225","E1"},{"в","226","E2"},{"г","227","E3"},
			{"д","228","E4"},{"е","229","E5"},{"ж","230","E6"},{"з","231","E7"},{"и","232","E8"},
			{"й","233","E9"},{"к","234","EA"},{"л","235","EB"},{"м","236","EC"},{"н","237","ED"},
			{"о","238","EE"},{"п","239","EF"},{"р","240","F0"},{"с","241","F1"},{"т","242","F2"},
			{"у","243","F3"},{"ф","244","F4"},{"х","245","F5"},{"ц","246","F6"},{"ч","247","F7"},
			{"ш","248","F8"},{"щ","249","F9"},{"ъ","250","FA"},{"ы","251","FB"},{"ь","252","FC"},
			{"э","253","FD"},{"ю","254","FE"},{"я","255","FF"}
		};
		
		private String[,] table_KOI8 = {{" ","32","20"},{"!","33","21"},{"\"","34","22"},
			{"#","35","23"},{"$","36","24"},{"%","37","25"},{"&","38","26"},{"'","39","27"},
			{"(","40","28"},{")","41","29"},{"*","42","2A"},{"+","43","2B"},{",","44","2C"},
			{"-","45","2D"},{".","46","2E"},{"/","47","2F"},{"0","48","30"},{"1","49","31"},
			{"2","50","32"},{"3","51","33"},{"4","52","34"},{"5","53","35"},{"6","54","36"},
			{"7","55","37"},{"8","56","38"},{"9","57","39"},{":","58","3A"},{";","59","3B"},
			{"<","60","3C"},{"=","61","3D"},{">","62","3E"},{"?","63","3F"},{"@","64","40"},
			{"A","65","41"},{"B","66","42"},{"C","67","43"},{"D","68","44"},{"E","69","45"},
			{"F","70","46"},{"G","71","47"},{"H","72","48"},{"I","73","49"},{"J","74","4A"},
			{"K","75","4B"},{"L","76","4C"},{"M","77","4D"},{"N","78","4E"},{"O","79","4F"},
			{"P","80","50"},{"Q","81","51"},{"R","82","52"},{"S","83","53"},{"T","84","54"},
			{"U","85","55"},{"V","86","56"},{"W","87","57"},{"X","88","58"},{"Y","89","59"},
			{"Z","90","5A"},{"[","91","5B"},{"\\","92","5C"},{"]","93","5D"},{"^","94","5E"},
			{"_","95","5F"},{"`","96","60"},{"a","97","61"},{"b","98","62"},{"c","99","63"},
			{"d","100","64"},{"e","101","65"},{"f","102","66"},{"g","103","67"},{"h","104","68"},
			{"i","105","69"},{"j","106","6A"},{"k","107","6B"},{"l","108","6C"},{"m","109","6D"},
			{"n","110","6E"},{"o","111","6F"},{"p","112","70"},{"q","113","71"},{"r","114","72"},
			{"s","115","73"},{"t","116","74"},{"u","117","75"},{"v","118","76"},{"w","119","77"},
			{"x","120","78"},{"y","121","79"},{"z","122","7A"},{"{","123","7B"},{"|","124","7C"},
			{"}","125","7D"},{"~","126","7E"},{"■","127","7F"},
			{"─","128","80"},{"│","129","81"},{"┌","130","82"},{"┐","131","83"},{"└","132","84"},
			{"┘","133","85"},{"├","134","86"},{"┤","135","87"},{"┬","136","88"},{"┴","137","89"},
			{"┼","138","8A"},{"▀","139","8B"},{"▄","140","8C"},{"█","141","8D"},{"▌","142","8E"},
			{"▐","143","8F"},{"░","144","90"},{"▒","145","91"},{"▓","146","92"},{"⌠","147","93"},
			{"■","148","94"},{"∙","149","95"},{"√","150","96"},{"≈","151","97"},{"≤","152","98"},
			{"≥","153","99"},{"љ","154","9A"},{"⌡","155","9B"},{"°","156","9C"},{"²","157","9D"},
			{"·","158","9E"},{"÷","159","9F"},{"═","160","A0"},{"║","161","A1"},{"╒","162","A2"},
			{"ё","163","A3"},{"╓","164","A4"},{"╔","165","A5"},{"╕","166","A6"},{"╖","167","A7"},
			{"╗","168","A8"},{"╘","169","A9"},{"╙","170","AA"},{"╚","171","AB"},{"╛","172","AC"},
			{"╜","173","AD"},{"╝","174","AE"},{"╞","175","AF"},{"╟","176","B0"},{"╠","177","B1"},
			{"╡","178","B2"},{"Ё","179","B3"},{"╢","180","B4"},{"╣","181","B5"},{"╤","182","B6"},
			{"╥","183","B7"},{"╦","184","B8"},{"╧","185","B9"},{"╨","186","BA"},{"╩","187","BB"},
			{"╪","188","BC"},{"╫","189","BD"},{"╬","190","BE"},{"©","191","BF"},{"ю","192","C0"},
			{"а","193","C1"},{"б","194","C2"},{"ц","195","C3"},{"д","196","C4"},{"е","197","C5"},
			{"ф","198","C6"},{"г","199","C7"},{"х","200","C8"},{"и","201","C9"},{"й","202","CA"},
			{"к","203","CB"},{"л","204","CC"},{"м","205","CD"},{"н","206","CE"},{"о","207","CF"},
			{"п","208","D0"},{"я","209","D1"},{"р","210","D2"},{"с","211","D3"},{"т","212","D4"},
			{"у","213","D5"},{"ж","214","D6"},{"в","215","D7"},{"ь","216","D8"},{"ы","217","D9"},
			{"з","218","DA"},{"ш","219","DB"},{"э","220","DC"},{"щ","221","DD"},{"ч","222","DE"},
			{"ъ","223","DF"},{"Ю","224","E0"},{"А","225","E1"},{"Б","226","E2"},{"Ц","227","E3"},
			{"Д","228","E4"},{"Е","229","E5"},{"Ф","230","E6"},{"Г","231","E7"},{"Х","232","E8"},
			{"И","233","E9"},{"Й","234","EA"},{"К","235","EB"},{"Л","236","EC"},{"М","237","ED"},
			{"Н","238","EE"},{"О","239","EF"},{"П","240","F0"},{"Я","241","F1"},{"Р","242","F2"},
			{"С","243","F3"},{"Т","244","F4"},{"У","245","F5"},{"Ж","246","F6"},{"В","247","F7"},
			{"Ь","248","F8"},{"Ы","249","F9"},{"З","250","FA"},{"Ш","251","FB"},{"Э","252","FC"},
			{"Щ","253","FD"},{"Ч","254","FE"},{"Ъ","255","FF"}
		};
		
		private RichTextBox _selectRTB;
		
		void MainFormLoad(object sender, EventArgs e)
		{
			_selectRTB = richTextBox1;
		}
		
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		/* ВЫПОЛНЕНИЕ КОДИРОВАНИЯ ================================= */
		// Определяем Dec и Hex представление символов
		bool GetCodingChars(String typeCoding)
		{
			if(typeCoding == "ASCII"){
				for(int i = 0; i < richTextBox1.Text.Length; i++){
					for(int iascii = 0; iascii < (table_ASCII.Length / 3); iascii++){
						if(richTextBox1.Text[i].ToString() == table_ASCII[iascii,0]){
							richTextBox3.Text += table_ASCII[iascii,1] + " ";
							richTextBox4.Text += table_ASCII[iascii,2] + " ";
						}
					}
				}
			}
			if(typeCoding == "MS-DOS"){
				for(int i = 0; i < richTextBox1.Text.Length; i++){
					for(int imsdos = 0; imsdos < (table_MSDOS.Length / 3); imsdos++){
						if(richTextBox1.Text[i].ToString() == table_MSDOS[imsdos,0]){
							richTextBox3.Text += table_MSDOS[imsdos,1] + " ";
							richTextBox4.Text += table_MSDOS[imsdos,2] + " ";
						}
					}
				}
			}
			if(typeCoding == "Windows-1251"){
				for(int i = 0; i < richTextBox1.Text.Length; i++){
					for(int iwin = 0; iwin < (table_Windows1251.Length / 3); iwin++){
						if(richTextBox1.Text[i].ToString() == table_Windows1251[iwin,0]){
							richTextBox3.Text += table_Windows1251[iwin,1] + " ";
							richTextBox4.Text += table_Windows1251[iwin,2] + " ";
						}
					}
				}
			}
			if(typeCoding == "KOI-8"){
				for(int i = 0; i < richTextBox1.Text.Length; i++){
					for(int ikoi = 0; ikoi < (table_KOI8.Length / 3); ikoi++){
						if(richTextBox1.Text[i].ToString() == table_KOI8[ikoi,0]){
							richTextBox3.Text += table_KOI8[ikoi,1] + " ";
							richTextBox4.Text += table_KOI8[ikoi,2] + " ";
						}
					}
				}
			}
			if(typeCoding == "Dec представление"){
				String sDec = "";
				richTextBox3.Text = richTextBox1.Text;
				for(int i = 0; i < richTextBox3.Text.Length; i++){
					if(richTextBox3.Text[i].ToString() == " "){
						
						for(int idec = 0; idec < (table_DecHex.Length / 2); idec++){
							if(sDec == table_DecHex[idec,0]){
								richTextBox4.Text += table_DecHex[idec,1] + " ";
								break;
							}
						}
						sDec = "";
						
					}else{
						sDec += richTextBox3.Text[i].ToString();
					}
				}
			}
			if(typeCoding == "Hex представление"){
				String sHex = "";
				richTextBox4.Text = richTextBox1.Text;
				for(int i = 0; i < richTextBox4.Text.Length; i++){
					if(richTextBox4.Text[i].ToString() == " "){
						
						for(int ihex = 0; ihex < (table_DecHex.Length / 2); ihex++){
							if(sHex == table_DecHex[ihex,1]){
								richTextBox3.Text += table_DecHex[ihex,0] + " ";
								break;
							}
						}
						sHex = "";
						
					}else{
						sHex += richTextBox4.Text[i].ToString();
					}
				}
			}
			
			return true;
		}
	
		/* Выполнение кодирования в соответствии с полученным числовом представлении символов */
		bool PerformCoding(String typeCoding)
		{
			String sChar = "";
			//------------------------------------------------------
			if(typeCoding == "ASCII"){
				for(int i = 0; i < richTextBox3.Text.Length; i++){
					if(richTextBox3.Text[i].ToString() == " "){
						
						for(int iascii = 0; iascii < (table_ASCII.Length / 3); iascii++){
							if(sChar == table_ASCII[iascii,1]){
								richTextBox2.Text += table_ASCII[iascii,0];
								break;
							}
						}
						sChar = "";
						
					}else{
						sChar += richTextBox3.Text[i].ToString();
					}
				}
			}
			//------------------------------------------------------
			if(typeCoding == "MS-DOS"){
				for(int i = 0; i < richTextBox3.Text.Length; i++){
					if(richTextBox3.Text[i].ToString() == " "){
						
						for(int imsdos = 0; imsdos < (table_MSDOS.Length / 3); imsdos++){
							if(sChar == table_MSDOS[imsdos,1]){
								richTextBox2.Text += table_MSDOS[imsdos,0];
								break;
							}
						}
						sChar = "";
						
					}else{
						sChar += richTextBox3.Text[i].ToString();
					}
				}
			}
			//------------------------------------------------------
			if(typeCoding == "Windows-1251"){
				for(int i = 0; i < richTextBox3.Text.Length; i++){
					if(richTextBox3.Text[i].ToString() == " "){
						
						for(int iwin = 0; iwin < (table_Windows1251.Length / 3); iwin++){
							if(sChar == table_Windows1251[iwin,1]){
								richTextBox2.Text += table_Windows1251[iwin,0];
								break;
							}
						}
						sChar = "";
						
					}else{
						sChar += richTextBox3.Text[i].ToString();
					}
				}
			}
			//------------------------------------------------------
			if(typeCoding == "KOI-8"){
				for(int i = 0; i < richTextBox3.Text.Length; i++){
					if(richTextBox3.Text[i].ToString() == " "){
						
						for(int ikoi = 0; ikoi < (table_KOI8.Length / 3); ikoi++){
							if(sChar == table_KOI8[ikoi,1]){
								richTextBox2.Text += table_KOI8[ikoi,0];
								break;
							}
						}
						sChar = "";
						
					}else{
						sChar += richTextBox3.Text[i].ToString();
					}
				}
			}
			//------------------------------------------------------
			return true;
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			richTextBox2.Clear();
			richTextBox3.Clear();
			richTextBox4.Clear();
			
			if(GetCodingChars(toolStripComboBox1.Text))
				if(PerformCoding(toolStripComboBox2.Text))
					MessageBox.Show("Готово!");
			
			
		}
		
		/* Paint */
		void PaintToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("mspaint.exe");
		}
		
		/* Wordpad */
		void WordpadToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("wordpad.exe");
		}
		
		/* Блокнот */
		void БлокнотToolStripMenuItem1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("notepad.exe"); // блокнот
		}
		
		/* Проводник */
		void ПроводникToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("explorer.exe");
		}
		
		/* Калькулятор */
		void КалькуляторToolStripMenuItem1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("calc.exe"); // калькулятор
		}
		
		/* Командная строка */
		void КоманднаяСтрокаToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("cmd.exe");
		}
		
		/* Правка: Отмена, Повтор, Вырезать, Копировать, Вставить, Удалить */
		void editUndo() // отмена
		{
			_selectRTB.Undo();
		}
		
		void editRedo() // повтор
		{
			_selectRTB.Redo();
		}
		
		void editCut() // вырезать
		{
			_selectRTB.Cut();
		}
		
		void editCopy() // копировать
		{
			_selectRTB.Copy();
		}
		
		void editPaste() // вставить
		{
			_selectRTB.Paste();
		}
		
		void editDelete() // удалить
		{
			Clipboard.SetDataObject("");
			_selectRTB.Paste();
		}
		
		void editSelectAll() // Выделить всё
		{
			_selectRTB.SelectAll();
		}
		
		void ОтменитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			editUndo();
		}
		
		void ПовторитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			editRedo();
		}
		
		void ВырезатьToolStripMenuItemClick(object sender, EventArgs e)
		{
			editCut();
		}
		
		void КопироватьToolStripMenuItemClick(object sender, EventArgs e)
		{
			editCopy();
		}
		
		void ВставитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			editPaste();
		}
		
		void УдалитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			editDelete();
		}
		
		void ВыделитьВсёToolStripMenuItemClick(object sender, EventArgs e)
		{
			editSelectAll();
		}
		
		/* Определяем выбранное текстовое поле */
		void RichTextBox1Click(object sender, EventArgs e)
		{
			_selectRTB = richTextBox1;
		}
		
		void RichTextBox2Click(object sender, EventArgs e)
		{
			_selectRTB = richTextBox2;
		}
		
		void RichTextBox3Click(object sender, EventArgs e)
		{
			_selectRTB = richTextBox3;
		}
		
		void RichTextBox4Click(object sender, EventArgs e)
		{
			_selectRTB = richTextBox4;
		}
		
		
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			_selectRTB = richTextBox1;
		}
		
		void RichTextBox2TextChanged(object sender, EventArgs e)
		{
			_selectRTB = richTextBox2;
		}
		
		void RichTextBox3TextChanged(object sender, EventArgs e)
		{
			_selectRTB = richTextBox3;
		}
		
		void RichTextBox4TextChanged(object sender, EventArgs e)
		{
			_selectRTB = richTextBox4;
		}
		
		
		
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			editUndo();
		}
		
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			editRedo();
		}
		
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
			editCut();
		}
		
		void ToolStripMenuItem5Click(object sender, EventArgs e)
		{
			editCopy();
		}
		
		void ToolStripMenuItem6Click(object sender, EventArgs e)
		{
			editPaste();
		}
		
		void ToolStripMenuItem7Click(object sender, EventArgs e)
		{
			editDelete();
		}
		
		void ВыделитьВсёToolStripMenuItem1Click(object sender, EventArgs e)
		{
			editSelectAll();
		}
		
		void ToolStripMenuItem8Click(object sender, EventArgs e)
		{
			MessageBox.Show("Программа: EncodingText" + System.Environment.NewLine + "Версия: 1.0" + System.Environment.NewLine + "Автор: Сомов Евгений Павлович" + System.Environment.NewLine + "©  Somov Evgeniy, 2014", "О программе", MessageBoxButtons.OK);			
		}
		
		void ОткрытьФайлВходныхДанныхToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK) richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
		}
		
		void СохранитьФайлВходныхДанныхToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
		}
		
		void СохранитьРезультатКодировкиToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) richTextBox2.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
		}
		
		void СохранитьДесятичноеПредставлениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) richTextBox3.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);			
		}
		
		void СохранитьШестнадцатеричноеПредставлениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) richTextBox4.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);			
		}
		
		void TabControl2SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabControl2.SelectedTab.Text == "Результат"){
				сохранитьРезультатКодировкиToolStripMenuItem.Enabled = true;
				сохранитьДесятичноеПредставлениеToolStripMenuItem.Enabled = false;
				сохранитьШестнадцатеричноеПредставлениеToolStripMenuItem.Enabled = false;
			}
			if(tabControl2.SelectedTab.Text == "Dec"){
				сохранитьРезультатКодировкиToolStripMenuItem.Enabled = false;
				сохранитьДесятичноеПредставлениеToolStripMenuItem.Enabled = true;
				сохранитьШестнадцатеричноеПредставлениеToolStripMenuItem.Enabled = false;
			}
			if(tabControl2.SelectedTab.Text == "Hex"){
				сохранитьРезультатКодировкиToolStripMenuItem.Enabled = false;
				сохранитьДесятичноеПредставлениеToolStripMenuItem.Enabled = false;
				сохранитьШестнадцатеричноеПредставлениеToolStripMenuItem.Enabled = true;
			}
		}
	}
}
