﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPlagSolution.AlgorithmModules
{
    class StopWordsHandler
    {
        private static Dictionary<string, int> _stopWords;
        public static string[] stopWordsList = new string[]{
                    "ثھی"
,"خو"
,"گی"
,"اپٌے"
,"گئے"
,"ثہت"
,"طرف"
,"ہوبری"
,"پبئے"
,"اپٌب"
,"دوضری"
,"گیب"
,"کت"
,"گب"
,"ضے"
,"ہر"
,"پر"
,"اش"
,"دی"
,"گے"
,"لگیں"
,"ہے"
,"ثعذ"
,"ضکتے"
,"وٍ"
,"تھی"
,"اى"
,"دیب"
,"لئے"
,"والے"
,"یہ"
,"ثدبئے"
,"ضکتی"
,"ے"
,"تھب"
,"اًذر"
,"رریعے"
,"لگی"
,"ہوبرا"
,"ہوًے"
,"ثبہر"
,"ضکتب"
,"تو"
,"اور"
,"رہب"
,"لگے"
,"ہوضکتب"
,"ہوں"
,"کب"
,"ہوبرے"
,"توبم"
,"کیب"
,"ایطے"
,"رہی"
,"هگر"
,"ہوضکتی"
,"کریں"
,"ہو"
,"تک"
,"کی"
,"ایک"
,"رہے"
,"هیں"
,"ہوضکتے"
,"کیطے"
,"ہوًب"
,"تت"
,"کہ"
,"ہوا"
,"آئے"
,"ضبتھ"
,"ب"
,"تھے"
,"کیوں"
,"ہوتب"
,"ہ"
,"خت"
,"کے"
,"پھر"
,"ثغیر"
,"خبرہے"
,"رکھ"
,"کیطب"
,"کوئی"
,"ثبرے"
,"خب"
,"اضطرذ"
,"ثلکہ"
,"خجکہ"
,"رکھتب"
,"کیطرف"
,"ثراں"
,"خبرہب"
,"رریعہ"
,"کطی"
,"اضکب"
,"ثٌذ"
,"خص"
,"رکھتبہوں"
,"کیلئے"
,"ثبئیں"
,"توہیں"
,"دوضرے"
,"کررہی"
,"اضکی"
,"ثیچ"
,"خوکہ"
,"رکھتی"
,"کیوًکہ"
,"دوًوں"
,"کررہے"
,"خبرہی"
,"اضکے"
,"پچھلا"
,"خیطب"
,"رکھتے"
,"کےثعذ"
,"توہی"
,"دوراى"
,"کررہب"
,"یہبں"
,"آش"
,"اًہیں"
,"ثي"
,"پطٌذ"
,"تھوڑا"
,"چکے"
,"زکویہ"
,"دوضروں"
,"ضکب"
,"اة"
,"اوًچب"
,"ثٌب"
,"پل"
,"تھوڑی"
,"چلا"
,"خبهوظ"
,"دیتب"
,"ضکٌب"
,"اخبزت"
,"اوًچبئی"
,"ثٌبرہب"
,"پوچھب"
,"تھوڑے"
,"چلو"
,"ختن"
,"دیتی"
,"ضکی"
,"اچھب"
,"اوًچی"
,"ثٌبرہی"
,"پوچھتب"
,"تیي"
,"چلیں"
,"در"
,"دیتے"
,"ضکے"
,"اچھی"
,"اوًچے"
,"ثٌبرہے"
,"پوچھتی"
,"خبًب"
,"چلے"
,"درخبت"
,"دیر"
,"ضلطلہ"
,"اچھے"
,"اٹھبًب"
,"ثٌبًب"
,"پوچھتے"
,"خبًتب"
,"چھوٹب"
,"درخہ"
,"دیکھٌب"
,"ضوچ"
,"اختتبم"
,"اہن"
,"پوچھٌب"
,"خبًتی"
,"چھوٹوں"
,"درخے"
,"دیکھو"
,"ضوچب"
,"ادھر"
,"آئی"
,"ثٌذکرًب"
,"پوچھو"
,"خبًتے"
,"چھوٹی"
,"درزقیقت"
,"دیکھی"
,"ضوچتب"
,"ارد"
,"آئےثٌذکرو"
,"پوچھوں"
,"خبًٌب"
,"چھوٹے"
,"درضت"
,"دیکھیں"
,"ضوچتی"
,"اردگرد"
,"ثٌذی"
,"پوچھیں"
,"خططرذ"
,"چھہ"
,"دش"
,"دیٌب"
,"ضوچتے"
,"ارکبى"
,"آخر"
,"ثڑا"
,"پورا"
,"خگہ"
,"چیسیں"
,"دفعہ"
,"دے"
,"ضوچٌب"
,"اضتعوبل"
,"آخرکبر"
,"ثڑوں"
,"پہلا"
,"خگہوں"
,"زبصل"
,"دکھبئیں"
,"راضتوں"
,"ضوچو"
,"اضتعوبلات"
,"آدهی"
,"ثڑی"
,"پہلی"
,"خگہیں"
,"زبضر"
,"دکھبتب"
,"راضتہ"
,"ضوچی"
,"اغیب"
,"آًب"
,"ثڑے"
,"پہلےضی"
,"خلذی"
,"زبل"
,"دکھبتی"
,"راضتے"
,"ضوچیں"
,"اطراف"
,"آٹھ"
,"ثھر"
,"پہلےضے"
,"خٌبة"
,"دکھبتے"
,"رکي"
,"ضیذھب"
,"افراد"
,"آیب"
,"ثھرا"
,"پہلےضےہی"
,"خواى"
,"زبلات"
,"دکھبًب"
,"رکھب"
,"ضیذھی"
,"اکثر"
,"ثب"
,"ثھراہوا"
,"پیع"
,"خوًہی"
,"زبلیہ"
,"دکھبو"
,"رکھی"
,"ضیذھے"
,"اکٹھب"
,"ثبترتیت"
,"ثھرپور"
,"تبزٍ"
,"خیطبکہ"
,"زصوں"
,"دکھبیب"
,"رکھے"
,"ضیکٌڈ"
,"اکٹھی"
,"ثبری"
,"ثہتر"
,"تر"
,"چبر"
,"زصہ"
,"دلچطپ"
,"زیبدٍ"
,"غبیذ"
,"اکٹھے"
,"ثبلا"
,"ثہتری"
,"ترتیت"
,"چبہب"
,"زصے"
,"دلچطپی"
,"ضبت"
,"غخص"
,"اکیلا"
,"ثبلترتیت"
,"ثہتریي"
,"تریي"
,"چبہٌب"
,"زقبئق"
,"دلچطپیبں"
,"ضبدٍ"
,"غذ"
,"اکیلی"
,"ثرش"
,"پبش"
,"تعذاد"
,"چبہے"
,"زقیتیں"
,"هٌبضت"
,"ضبرا"
,"غروع"
,"اکیلے"
,"پبًب"
,"اً"
,"ج"
,"ی"
,"ر"
,"ق"
,"ت"
,"چکب"
,"زقیقت"
,"دو"
,"ضبرے"
,"غروعبت"
,"اگرچہ"
,"ثلٌذ"
,"پبًچ"
,"تن"
,"چکی"
,"زکن"
,"دور"
,"ضبل"
,"غے"
,"الگ"
,"ثلٌذوثبلا"
,"پراًب"
,"تٌہب"
,"چکیں"
,"و"
,"ک"
,"ز"
,"دوضرا"
,"ضبلوں"
,"صبف"
,"صسیر"
,"قجیلہ"
,"کوًطے"
,"لازهی"
,"هطئلے"
,"یب"
,"طریق"
,"کرتی"
,"کہتے"
,"صفر"
,"قطن"
,"کھولا"
,"لگتب"
,"هطبئل"
,"وار"
,"طریقوں"
,"کرتے"
,"کہٌب"
,"صورت"
,"کئی"
,"کھولٌب"
,"لگتی"
,"هطتعول"
,"طریقہ"
,"کرتےہو"
,"صورتسبل"
,"کئے"
,"کھولو"
,"لگتے"
,"هػتول"
,"ٹھیک"
,"طریقے"
,"کرًب"
,"کہو"
,"صورتوں"
,"کبفی"
,"کھولیلگٌب"
,"هطلق"
,"ڈھوًڈا"
,"طور"
,"کرو"
,"کہوں"
,"صورتیں"
,"کبم"
,"کھولیں"
,"هعلوم"
,"ڈھوًڈلیب"
,"طورپر"
,"کہی"
,"ضرور"
,"کجھی"
,"کھولے"
,"هکول"
,"ڈھوًڈًب"
,"ظبہر"
,"کرے"
,"کہیں"
,"ضرورت"
,"کرا"
,"کہب"
,"لوجب"
,"هلا"
,"ڈھوًڈو"
,"عذد"
,"کل"
,"ض"
,"کرتب"
,"کہتب"
,"لوجی"
,"هوکي"
,"ڈھوًڈی"
,"عظین"
,"کن"
,"کہے"
,"ضروری"
,"کرتبہوں"
,"کہتی"
,"لوجے"
,"هوکٌبت"
,"ڈھوًڈیں"
,"علاقوں"
,"کوتر"
,"کیے"
,"لوسبت"
,"هوکٌہ"
,"ہن"
,"لے"
,"بپطٌذ"
,"ہورہے"
,"علاقہ"
,"کورا"
,"کےرریعے"
,"لوسہ"
,"هڑا"
,"ہوئی"
,"هتعلق"
,"بگسیر"
,"گئ"
,"علاقے"
,"کوروں"
,"گئی"
,"لو"
,"هڑًب"
,"ہوئے"
,"هسترم"
,"طجت"
,"ہوگئے"
,"علاوٍ"
,"کورٍ"
,"گرد"
,"لوگ"
,"هڑے"
,"ہوتی"
,"هسترهہ"
,"قطہ"
,"ہوگیب"
,"ه"
,"ع"
,"کورے"
,"گروپ"
,"لوگوں"
,"هہرثبى"
,"ہوتے"
,"هسطوش"
,"ہوًی"
,"عووهی"
,"کوطي"
,"گروٍ"
,"لڑکپي"
,"هیرا"
,"ہوچکب"
,"هختلف"
,"ہی"
,"فرد"
,"کوى"
,"گروہوں"
,"لی"
,"هیری"
,"ہوچکی"
,"هسیذ"
,"فی"
,"کوًطب"
,"گٌتی"
,"لیب"
,"هیرے"
,"ہوچکے"
,"هطئلہ"
,"وخواى"
,"یقیٌی"
,"قجل"
,"کوًطی"
,"لا"
,"لیٌب"
,"ئی"
,"ہورہب"
,"لیں"
,"ہورہی"
,"ثبعث"
,"ضت"
,"تھا"
,"چکا"
,"آتیں"
,"میں"
,"کر"
,"مگر"
,"کو"
,"ہیں"
,"بنا"
,"آتے"
,"ہوتا"
,"اس"
,"نے"
,"دیے"
,"ان"
,"سے"
,"کیا"
,"اپنے"
,"لیکن"
,"لیے"
,"ہونے"
,"وہ"
,"گیا"
,"جو"
,"جس"
,"دیا"
,"والی"
,"لیا"
,"آیا"
,"جبکہ"
,"کرنے"
,"رکھا"
,"~"
,"آ"
,"ء"
,"آپ"
,"لاۓ"
,"انہوں"
,"اب"
,"وہیں"
,"تھیں"
,"بھی"
,"جب"
,"کا"

            };
        public StopWordsHandler()
        {
            if (_stopWords == null)
            {
                _stopWords = new Dictionary<string, int>();
                int temp = 0;
                foreach (var item in stopWordsList)
                {
                    _stopWords.Add(item, temp); //Dictionary data structure is used to 
                    //to perform better searching
                }
            }
        }

        public static bool IsStopWord(string word)
        {
            return _stopWords.ContainsKey(word);
        }
    }
}
